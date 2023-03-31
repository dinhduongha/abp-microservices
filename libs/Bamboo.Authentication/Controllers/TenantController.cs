using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core.Tokenizer;
using System.Net.Http;
using System.Xml.Linq;

using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Security.Claims;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Net.Http.Headers;
using Microsoft.AspNetCore.Identity;

using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Data;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Identity;
using Volo.Abp.MultiTenancy;
using Volo.Abp.TenantManagement;
using Volo.Abp.Identity.AspNetCore;
using Volo.Abp.EntityFrameworkCore;

using Volo.Abp.Domain.Entities;
using Volo.Abp.Users;
using Volo.Abp.ObjectExtending;
using IdentityUser = Volo.Abp.Identity.IdentityUser;

using Microsoft.Extensions.Configuration;
using static Volo.Abp.Identity.Settings.IdentitySettingNames;
using static Volo.Abp.Identity.IdentityPermissions;
using StackExchange.Redis;

using Bamboo.EntityFrameworkCore;
using Bamboo.Authentication;

public interface IVendorController: ITenantAppService
{
}
public class IdentityUserRoleExtension: IdentityUserRole
{
    public IdentityUserRoleExtension(Guid userId, Guid roleId, Guid tenantId)
        :base(userId, roleId, tenantId)
    {
    }
    //public static IdentityUser AddExtRole(this IdentityUser user, Guid roleId, Guid tenantId)
    //{
    //    user.Roles.Add(new IdentityUserRole(user.Id, roleId, tenantId));
    //    return user;
    //}
}

//[Area(IntegrateRemoteServiceConsts.ModuleName)]
//[RemoteService(Name = IntegrateRemoteServiceConsts.RemoteServiceName)]
[Route("api/vendors/")]
[Authorize]
//public class VendorController : IntegrateController //, ILinkAccountAppService
//[AllowAnonymous]
public class VendorController : AbpController
{
    private readonly VendorService _vendorService;
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly IConfiguration _configuration;

    protected AbpSignInManager SignInManager { get; }
    AbpUserClaimsPrincipalFactory _abpUserClaimsPrincipalFactory;
    public VendorController(VendorService vendorService,
                            IConfiguration configuration,
                            AbpSignInManager signInManager,
                            AbpUserClaimsPrincipalFactory abpUserClaimsPrincipalFactory,
                            ILookupNormalizer lookupNormalizer,
                            IHttpClientFactory httpClientFactory)
        : base()
    {
        _configuration = configuration;
        _abpUserClaimsPrincipalFactory = abpUserClaimsPrincipalFactory;
        SignInManager = signInManager;
        _httpClientFactory = httpClientFactory;
        _vendorService = vendorService;

    }
    [HttpGet]
    [Route("{id}")]
    public async Task<TenantDto> GetAsync(Guid id)
    {
        return await _vendorService.GetAsync(id);
    }

    [HttpGet]
    public async Task<PagedResultDto<TenantDto>> GetListAsync(GetTenantsInput input)
    {
        return await _vendorService.GetListAsync(input);
    }

    [HttpPost]
    public async Task<TenantDto> CreateAsync(string name)
    {
        return await _vendorService.CreateAsync(name);
    }

    [HttpGet]
    [Route("roles")]
    public async Task<List<Volo.Abp.Identity.IdentityRole>> GetRoleAsync()
    {
        return await _vendorService.GetRoleAsync();
    }

    [HttpGet]
    [Route("roles/{vendor}")]
    public async Task<List<Volo.Abp.Identity.IdentityRole>> GetRoleByTenantAsync(Guid? vendor)
    {
        return await _vendorService.GetRoleByTenantAsync(vendor);
    }

    [HttpPost]
    [Route("roles-add/{vendor}")]
    public async Task<bool> VendorRoleAddAsync(Guid vendor, VendorRoleCreateDto dto)
    {
        return await _vendorService.VendorUserRoleAddAsync(vendor, dto);
    }

    [HttpDelete]
    [Route("roles-remove/{vendor}/{user}")]
    public async Task<bool> VendorRoleRemoveAsync(Guid vendor, Guid user)
    {
        return await _vendorService.VendorUserRoleRemoveAsync(vendor, user);
    }

}