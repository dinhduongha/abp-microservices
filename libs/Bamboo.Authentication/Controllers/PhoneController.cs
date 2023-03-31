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

namespace Bamboo.Authentication;

[Route("api/phone/")]
[Produces("application/json")]
public class PhoneController : AbpControllerBase
{

    private readonly PhoneService _phoneService;
    public PhoneController(PhoneService phoneService)
    {
        _phoneService = phoneService;
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
    public async Task<string> Register([FromBody] ExternalRegisterOrUpdateDto account, string provider = "" )
    {
        IdentityUser? user = null;
        user = await _phoneService.Register(account, provider);
        await Task.CompletedTask;
        return user.PhoneNumber;
    }

    [HttpPost]
    [Route("change-password")]
    [AllowAnonymous]
    [IgnoreAntiforgeryToken]
    public async Task<string> ChangePassword([FromBody] ExternalRegisterOrUpdateDto account, string provider = "")
    {
        IdentityUser? user = null;
        user = await _phoneService.ChangePassword(account, provider);
        await Task.CompletedTask;
        return user.PhoneNumber;
    }



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
        var token = await _phoneService.smsToken(phone);
        return phone;
    }

    /// <summary>
    /// Generate code, let user send the code to SMS Provider for verification. Sms provider must call webhook to own server
    /// </summary>
    /// <param name="phone"></param>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    //[HttpGet]
    //[Route("smsTokenProviderCallback")]
    //[AllowAnonymous]
    //[IgnoreAntiforgeryToken]
    //public async Task<string> TokenReceive(string phone)
    //{
    //    if (!Regex.Match(phone, @"^([+]|[00])([0-9]){5,13}$").Success)
    //    {
    //        throw new Exception("Invalid phone number");
    //    }
    //    var code = await _phoneService.TokenReceived(phone);
    //    throw new UserFriendlyException("Not yet implement");
    //    return code;
    //}
}


