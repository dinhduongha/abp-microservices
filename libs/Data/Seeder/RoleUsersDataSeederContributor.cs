using System;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Guids;
using Volo.Abp.Identity;
using Volo.Abp.MultiTenancy;

class DefaultRolesDataSeederContributor
        : IDataSeedContributor, ITransientDependency
{
    private readonly IdentityUserManager _identityUserManager;
    private readonly IdentityRoleManager _identityRoleManager;
    private readonly ICurrentTenant _currentTenant;
    private readonly IGuidGenerator _guidGenerator;
    public DefaultRolesDataSeederContributor(IdentityUserManager identityUserManager,
        IdentityRoleManager identityRoleManager,
        ICurrentTenant currentTenant, IGuidGenerator guidGenerator)
    {
        _identityUserManager = identityUserManager;
        _identityRoleManager = identityRoleManager;
        _currentTenant = currentTenant;
        _guidGenerator = guidGenerator;
    }

    public async Task SeedAsync(DataSeedContext context)
    {
        // Add Role
        IdentityRole role = new IdentityRole(Guid.NewGuid(), "admin", _currentTenant.Id)
        {
            IsStatic = true,
            IsPublic = true
        };
        await _identityRoleManager.CreateAsync(role);
        //role = new IdentityRole(_guidGenerator.Create(), "owner", _currentTenant.Id)
        //{
        //    IsStatic = true,
        //    IsPublic = true
        //};
        //await _identityRoleManager.CreateAsync(role);
        role = new IdentityRole(_guidGenerator.Create(), "manager", _currentTenant.Id)
        {
            IsStatic = true,
            IsPublic = true
        };
        await _identityRoleManager.CreateAsync(role);
        role = new IdentityRole(_guidGenerator.Create(), "customer", _currentTenant.Id)
        {
            IsStatic = true,
            IsPublic = true
        };
        await _identityRoleManager.CreateAsync(role);
        role = new IdentityRole(_guidGenerator.Create(), "readonly", _currentTenant.Id)
        {
            IsStatic = true,
            IsPublic = true
        };
        await _identityRoleManager.CreateAsync(role);
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