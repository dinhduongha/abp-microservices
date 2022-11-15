using System.Threading.Tasks;
using System.Net.Mail;
using System.Numerics;
using System.Text.RegularExpressions;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using Volo.Abp;
using Volo.Abp.Guids;
using Volo.Abp.Identity;
using Volo.Abp.Sms;
using Volo.Abp.Data;
using Volo.Abp.MultiTenancy;
using Volo.Abp.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using Volo.Abp.Account;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Application.Services;

using Twilio.Types;
using FirebaseAdmin.Auth;

using Bamboo.Abp.VerificationCode;

namespace Bamboo.Authentication.Controllers;

[Route("api/phone/")]
[Produces("application/json")]
public class PhoneController : AbpControllerBase
{

    private readonly IdentityUserManager _userManager;
    private readonly IVerificationCodeManager _verificationCodeManager;
    private readonly ISmsSender _smsSender;
    private readonly IDataFilter _dataFilter;

    public PhoneController(ISmsSender smsSender,
                            IVerificationCodeManager verificationCodeManager,
                            IDataFilter dataFilter,
                            IdentityUserManager userManager)
    {
        _verificationCodeManager = verificationCodeManager;
        _userManager = userManager;
        _smsSender = smsSender;
        _dataFilter = dataFilter;
    }

    /// <summary>
    /// Register user or reset password, use firebase or sms
    /// </summary>
    /// <param name="account"></param>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    [HttpPost]
    [Route("register")]
    [AllowAnonymous]
    [IgnoreAntiforgeryToken]
    public async Task<string> RegisterOrChangePassword(ExternalRegisterOrUpdateDto account, string provider = "" )
    {
        IdentityUser? user = null;
        if ( provider == "sms")
        {
            user = await RegisterOrChangePasswordByToken(account);
        }
        else
        {
            user = await RegisterOrChangePasswordFirebase(account);
        }
        await Task.CompletedTask;
        return user.PhoneNumber;
    }

    protected async Task<IdentityUser?> RegisterOrChangePasswordFirebase(ExternalRegisterOrUpdateDto account)
    {
        try
        {
            var phone = account.Phone;

            if (!Regex.Match(phone, @"^([+]|[00])([0-9]){5,13}$").Success)
            {
                throw new Exception("Invalid phone number");
            }

            UserRecord userRecord = await FirebaseAuth.DefaultInstance.GetUserByPhoneNumberAsync(phone);
            if (userRecord == null)
            {
                throw new Exception("Invalid phone number");
            }
            var decodedToken = await FirebaseAuth.DefaultInstance.VerifyIdTokenAsync(account.Token);
            string uid = decodedToken.Uid;
            userRecord = await FirebaseAuth.DefaultInstance.GetUserAsync(decodedToken.Uid);

            // For Test
            // UserRecord userRecord = await FirebaseAuth.DefaultInstance.GetUserByPhoneNumberAsync(account.Phone);

            if (string.IsNullOrEmpty(phone) || userRecord.PhoneNumber != phone)
            {
                throw new Exception("Invalid phone number");
            }
            return await CreateOrUpdate(account);
        }
        catch (Exception e)
        {
            throw new Exception("Invalid phone number");
        }
    }

    //[HttpGet]
    //[Route("userExist")]
    //public async Task<UserRecord> FirebaseUserExists(string phone)
    //{
    //    try
    //    {
    //        UserRecord userRecord = await FirebaseAuth.DefaultInstance.GetUserByPhoneNumberAsync(phone);
    //        return userRecord;

    //    }
    //    catch (Exception e)
    //    {
    //        int i = 0;
    //    }
    //    return null;
    //}

    /// <summary>
    /// Get code, send code to user for SMS verification
    /// </summary>
    /// <param name="phone"></param>
    /// <returns></returns>
    [HttpGet]
    [Route("smsToken")]
    [AllowAnonymous]
    [IgnoreAntiforgeryToken]
    public async Task<string> Token(string phone)
    {
        if (!Regex.Match(phone, @"^([+]|[00])([0-9]){5,13}$").Success)
        {
            throw new Exception("Invalid phone number");
        }  
        var code = await _verificationCodeManager.GenerateAsync(
            codeCacheKey: $"Starify:PhoneVerification:{phone}",
            codeCacheLifespan: TimeSpan.FromMinutes(5),
            configuration: new VerificationCodeConfiguration());

        await _smsSender.SendAsync(new SmsMessage(phone, $"Starify code is: {code}"));
        return phone;
    }


    /// <summary>
    /// Generate code, let user send the code to SMS Provider for verification. Sms provider must call webhook to own server
    /// </summary>
    /// <param name="phone"></param>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    [HttpGet]
    [Route("smsTokenReceive")]
    [AllowAnonymous]
    [IgnoreAntiforgeryToken]
    public async Task<string> TokenReceive(string phone)
    {
        if (!Regex.Match(phone, @"^([+]|[00])([0-9]){5,13}$").Success)
        {
            throw new Exception("Invalid phone number");
        }
        var code = await _verificationCodeManager.GenerateAsync(
            codeCacheKey: $"Starify:PhoneReceiveVerification:", phone,
            codeCacheLifespan: TimeSpan.FromMinutes(5),
            configuration: new VerificationCodeConfiguration());

        return code;
    }

    protected async Task<IdentityUser?> RegisterOrChangePasswordByToken(ExternalRegisterOrUpdateDto account)
    {
        var isVerified = await _verificationCodeManager.ValidateAsync(
            codeCacheKey: $"Starify:PhoneVerification:{account.Phone}",
            verificationCode: account.Token,
            configuration: new VerificationCodeConfiguration());

        if (isVerified == null)
        {
            throw new Exception("Invalid phone or code");
        }
        return await CreateOrUpdate(account);
    }

    protected async Task<IdentityUser?> CreateOrUpdate(ExternalRegisterOrUpdateDto account)
    {
        using (_dataFilter.Disable<IMultiTenant>())
        {
            string phone = account.Phone;
            var user = await _userManager.FindByNameAsync(phone);
            if (user == null)
            {
                var id = GuidGenerator.Create();
                user = new IdentityUser(id, phone, $"{phone.RemovePreFix("+")}@starify.io", null);
                user.SetPhoneNumber(phone, true);
                var u = await _userManager.CreateAsync(user);
                var resetToken = await _userManager.GeneratePasswordResetTokenAsync(user);
                await _userManager.ResetPasswordAsync(user, resetToken, account.Password);
                //await _identityUserManager.ChangePasswordAsync(user, "", account.Password);
            }
            else
            {
                if (user.TenantId == null)
                {
                    var resetToken = await _userManager.GeneratePasswordResetTokenAsync(user);
                    await _userManager.ResetPasswordAsync(user, resetToken, account.Password);
                    await _userManager.SetLockoutEndDateAsync(user, null);
                }
            }
            await Task.CompletedTask;
            return user;
        }
    }
}


