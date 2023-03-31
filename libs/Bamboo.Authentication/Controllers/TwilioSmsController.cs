using System.Threading.Tasks;
using System.Numerics;
using System.Net.Mail;
using System.Linq;
using System;
using System.Security.Principal;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using Volo.Abp;
using Volo.Abp.Guids;
using Volo.Abp.Identity;
using Volo.Abp.Sms;
using Volo.Abp.MultiTenancy;
using Volo.Abp.TenantManagement;
using Volo.Abp.Users;
using Volo.Abp.Data;
using Volo.Abp.Linq;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Application.Services;

using Twilio.Types;
using Twilio.AspNet.Common;
using Twilio.AspNet.Core;
using Twilio.TwiML;

using Bamboo.Abp.VerificationCode;

namespace Bamboo.Authentication.Controllers;

[Route("api/twilio/")]
public class TwilioSmsController : TwilioController
{
    private readonly ICurrentUser _currentUser;
    private readonly ITenantManager _tenantManager;
    private readonly IdentityUserManager _userManager;
    protected IDataSeeder _dataSeeder { get; }

    private readonly ITenantRepository _tenantRepository;
    private readonly IIdentityUserRepository _userRepository;

    private readonly IRepository<Tenant, Guid> _tenantRepos;
    //private readonly IRepository<CurrentUser, Guid> _userRepos;
    IHttpClientFactory _httpClientFactory;

    private readonly IVerificationCodeManager _verificationCodeManager;

    public TwilioSmsController(ICurrentUser currentUser,
            ITenantManager tenantManager,
            ITenantRepository tenantRepository,
            IdentityUserManager userManager,
            IIdentityUserRepository userRepository,
            IRepository<Tenant, Guid> tenantRepos,
            IHttpClientFactory httpFactory,
            IVerificationCodeManager verificationCodeManager,
            IDataSeeder dataSeeder)
    {
        _tenantManager = tenantManager;
        _currentUser = currentUser;
        _userManager = userManager;
        _tenantRepository = tenantRepository;
        _userRepository = userRepository;
        _dataSeeder = dataSeeder;
        _tenantRepos = tenantRepos;
        _httpClientFactory = httpFactory;
        _verificationCodeManager = verificationCodeManager;
    }

    /// <summary>
    /// Callback from Twilio services
    /// </summary>
    /// <param name="incomingMessage"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("sms")]
    [AllowAnonymous]
    [IgnoreAntiforgeryToken]
    public async Task<TwiMLResult> Index(SmsRequest incomingMessage)
    {
        var messagingResponse = new MessagingResponse();
        messagingResponse.Message(incomingMessage.Body);
        var isVerified = await _verificationCodeManager.ValidateReceiveAsync(
            codeCacheKey: $"Bamboo:PhoneReceiveVerification:",
            verificationCode: incomingMessage.Body,
            configuration: new VerificationCodeConfiguration());

        if (isVerified == null)
        {
            throw new Exception("Invalid code");
        }
        //return await CreateOrUpdate(account);
        return TwiML(messagingResponse);

    }

    [HttpPost]
    [Route("callback")]
    [AllowAnonymous]
    [IgnoreAntiforgeryToken]
    public async Task<TwiMLResult> Index2(SmsRequest incomingMessage)
    {
        var rs = await _phoneService.TwilioIncomming(incomingMessage);
        return rs;
    }
}
