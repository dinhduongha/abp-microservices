using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Guids;
using Volo.Abp.Identity;
using Volo.Abp.MultiTenancy;
using Volo.Abp.Uow;

class DefaultRolesDataSeederContributor
        : IDataSeedContributor, ITransientDependency
{
    private readonly IdentityUserManager _identityUserManager;
    private readonly IdentityRoleManager _identityRoleManager;
    private readonly ICurrentTenant _currentTenant;
    private readonly IGuidGenerator _guidGenerator;
    public DefaultRolesDataSeederContributor(IdentityUserManager identityUserManager,
        IdentityRoleManager identityRoleManager,
        ICurrentTenant currentTenant, 
        IGuidGenerator guidGenerator)
    {
        _identityUserManager = identityUserManager;
        _identityRoleManager = identityRoleManager;
        _currentTenant = currentTenant;
        _guidGenerator = guidGenerator;
    }

    [UnitOfWork]
    public async Task SeedAsync(DataSeedContext context)
    {
        var lstRoles = new List<string>()
        {
            "admin",
            "manager",
            "sales",
            "pos",
            "customer",
            "readonly"
        };
        foreach (var roleName in lstRoles)
        {
            var r = await _identityRoleManager.FindByNameAsync(roleName);
            if (r == null)
            {
                r = new IdentityRole(Guid.NewGuid(), roleName, context.TenantId)
                {
                    IsStatic = true,
                    IsPublic = true
                };
                await _identityRoleManager.CreateAsync(r);
            }
        }

        //IdentityRole role = new IdentityRole(Guid.NewGuid(), "owner", _currentTenant.Id);
        //await _identityRoleManager.CreateAsync(role);
        // Add user
        //IdentityUser identityUser1 = new IdentityUser(Guid.NewGuid(), "test_user1", "testuser1@email.com");
        //await _identityUserManager.CreateAsync(identityUser1, "1q2w3E*");
        //await _identityUserManager.AddToRoleAsync(identityUser1, "Admin");

        //IdentityUser identityUser2 = new IdentityUser(Guid.NewGuid(), "test_user2", "testuser2@email.com");
        //await _identityUserManager.CreateAsync(identityUser2, "1q2w3E*");
        //await _identityUserManager.AddToRoleAsync(identityUser2, "Admin");

        //IdentityUser identityUser3 = new IdentityUser(Guid.NewGuid(), "test_user3", "testuser3@email.com");
        //await _identityUserManager.CreateAsync(identityUser3, "1q2w3E*");
        ////await _identityUserManager.AddToRoleAsync(identityUser3, "Admin");  // Intentionally not making this user and admin
    }
}