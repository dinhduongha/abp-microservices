using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Localization;
using OpenIddict.Abstractions;
using Volo.Abp;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.OpenIddict.Applications;
using Volo.Abp.PermissionManagement;
using Volo.Abp.Uow;

namespace Bamboo.OpenIddict.Multi;

public class ServiceClient
{
    public string ClientId { get; set; }
    public string ClientSecret { get; set; }
    public string ClientUri { get; set; }
    public string[] RootUrls { get; set; }
    public string[] Scopes { get; set; }
    public string[] GrantTypes { get; set; }
    public string[] RedirectUris { get; set; }
    public string[] PostLogoutRedirectUris { get; set; }
    public string[] AllowedCorsOrigins { get; set; }
}

/* Creates initial data that is needed to property run the application
 * and make client-to-server communication possible.
 */
public class MultiOpenIddictDataSeedContributor : IDataSeedContributor, ITransientDependency
{
    private readonly IConfiguration _configuration;
    private readonly IAbpApplicationManager _applicationManager;
    private readonly IOpenIddictScopeManager _scopeManager;
    private readonly IPermissionDataSeeder _permissionDataSeeder;
    private readonly IStringLocalizer<OpenIddictResponse> L;


    public MultiOpenIddictDataSeedContributor(
        IConfiguration configuration,
        IAbpApplicationManager applicationManager,
        IOpenIddictScopeManager scopeManager,
        IPermissionDataSeeder permissionDataSeeder,
        IStringLocalizer<OpenIddictResponse> l)
    {
        _configuration = configuration;
        _applicationManager = applicationManager;
        _scopeManager = scopeManager;
        _permissionDataSeeder = permissionDataSeeder;
        L = l;
    }

    [UnitOfWork]
    public virtual async Task SeedAsync(DataSeedContext context)
    {
        await CreateScopesAsync();
        await CreateApplicationsAsync();
    }

    private async Task CreateScopesAsync()
    {
        if (await _scopeManager.FindByNameAsync("Bamboo") == null)
        {
            await _scopeManager.CreateAsync(new OpenIddictScopeDescriptor
            {
                Name = "Bamboo",
                DisplayName = "Bamboo API",
                Resources =
                {
                    "Bamboo"
                }
            });
        }
    }

    private async Task CreateApplicationsAsync()
    {
        var commonScopes = new List<string>
        {
            OpenIddictConstants.Permissions.Scopes.Address,
            OpenIddictConstants.Permissions.Scopes.Email,
            OpenIddictConstants.Permissions.Scopes.Phone,
            OpenIddictConstants.Permissions.Scopes.Profile,
            OpenIddictConstants.Permissions.Scopes.Roles,
			"offline_access",
            "Bamboo"
        };

		var clients = _configuration.GetSection("Clients").Get<List<ServiceClient>>();
		foreach (var client in clients)
        {            
            var isClientSecretAvailable = !string.IsNullOrEmpty(client.ClientSecret);

            await CreateApplicationAsync(
                    client.ClientId,
                    displayName: client.ClientId,
                    secret: isClientSecretAvailable ? client.ClientSecret : null,
                    type: isClientSecretAvailable ? OpenIddictConstants.ClientTypes.Confidential : OpenIddictConstants.ClientTypes.Public,
                    scopes: commonScopes.Union(client.Scopes).ToList(),
                    grantTypes: client.GrantTypes.ToList(),
                    redirectUris: client.RedirectUris.ToList(),
                    postLogoutRedirectUris: client.PostLogoutRedirectUris.ToList(),
                    consentType: OpenIddictConstants.ConsentTypes.Implicit
                );
        }
		
        var configurationSection = _configuration.GetSection("OpenIddict:Applications");

        //Web Client
        var webClientId = configurationSection["Bamboo_Web:ClientId"];
        if (!webClientId.IsNullOrWhiteSpace())
        {
            var webClientRootUrl = configurationSection["Bamboo_Web:RootUrl"].EnsureEndsWith('/');

            /* Bamboo_Web client is only needed if you created a tiered
             * solution. Otherwise, you can delete this client. */
            await CreateApplicationAsync(
                name: webClientId,
                type: OpenIddictConstants.ClientTypes.Confidential,
                consentType: OpenIddictConstants.ConsentTypes.Implicit,
                displayName: "Web Application",
                secret: configurationSection["Bamboo_Web:ClientSecret"] ?? "1q2w3e*",
                grantTypes: new List<string> //Hybrid flow
                {
                    OpenIddictConstants.GrantTypes.AuthorizationCode,
                    OpenIddictConstants.GrantTypes.Implicit
                },
                scopes: commonScopes,
                redirectUri: $"{webClientRootUrl}signin-oidc",
                clientUri: webClientRootUrl,
                redirectUris: new List<string>
                {
                    "https://pipay.vn/auth/signin-oidc",
                    "https://auth.pipay.vn:8443/signin-oidc",
                    "https://auth.pipay.vn/signin-oidc",
                    "https://localhost:4201/signin-oidc",
					"https://localhost:44305/signin-oidc",
                    "https://localhost:5001/signin-oidc",
                    "https://localhost:5002/signin-oidc",
                },
                postLogoutRedirectUris: new List<string>
                {
                    "https://pipay.vn/auth/signout-callback-oidc",
                    "https://auth.pipay.vn:8443/signout-callback-oidc",
                    "https://auth.pipay.vn/signout-callback-oidc",
                    "https://localhost:4201/signout-callback-oidc",
					"https://localhost:44305/signout-callback-oidc",
                    "https://localhost:5001/signout-callback-oidc",
                    "https://localhost:5002/signout-callback-oidc",
                },
                postLogoutRedirectUri: $"{webClientRootUrl}signout-callback-oidc"
            );
        }

        //Console Test / Angular Client
        var consoleAndAngularClientId = configurationSection["Bamboo_App:ClientId"];
        if (!consoleAndAngularClientId.IsNullOrWhiteSpace())
        {
            var consoleAndAngularClientRootUrl = configurationSection["Bamboo_App:RootUrl"]?.TrimEnd('/');
            await CreateApplicationAsync(
                name: consoleAndAngularClientId,
                type: OpenIddictConstants.ClientTypes.Public,
                consentType: OpenIddictConstants.ConsentTypes.Implicit,
                displayName: "Console Test / Angular Application",
                secret: null,
                grantTypes: new List<string>
                {
                    OpenIddictConstants.GrantTypes.AuthorizationCode,
                    OpenIddictConstants.GrantTypes.Password,
                    OpenIddictConstants.GrantTypes.ClientCredentials,
                    OpenIddictConstants.GrantTypes.RefreshToken
                },
                scopes: commonScopes,
                redirectUri: consoleAndAngularClientRootUrl,
                clientUri: consoleAndAngularClientRootUrl,
                postLogoutRedirectUri: consoleAndAngularClientRootUrl
            );
        }

        // Blazor Client
        var blazorClientId = configurationSection["Bamboo_Blazor:ClientId"];
        if (!blazorClientId.IsNullOrWhiteSpace())
        {
            var blazorRootUrl = configurationSection["Bamboo_Blazor:RootUrl"].TrimEnd('/');

            await CreateApplicationAsync(
                name: blazorClientId,
                type: OpenIddictConstants.ClientTypes.Public,
                consentType: OpenIddictConstants.ConsentTypes.Implicit,
                displayName: "Blazor Application",
                secret: null,
                grantTypes: new List<string>
                {
                    OpenIddictConstants.GrantTypes.AuthorizationCode,
                },
                scopes: commonScopes,
                redirectUri: $"{blazorRootUrl}/authentication/login-callback",
                redirectUris: new List<string>
                {
                    "https://auth.pipay.vn:8443/authentication/login-callback",
                    "https://auth.pipay.vn/authentication/login-callback",
                    "https://localhost:4201/authentication/login-callback",
					"https://localhost:44305/authentication/login-callback",
                    "https://localhost:5001/authentication/login-callback",
                    "https://localhost:5002/authentication/login-callback",
                },
                postLogoutRedirectUris: new List<string>
                {
                    "https://pipay.vn/auth/authentication/logout-callback",
                    "https://auth.pipay.vn:8443/authentication/logout-callback",
                    "https://auth.pipay.vn/authentication/logout-callback",
                    "https://localhost:4201/authentication/logout-callback",
					"https://localhost:44305/authentication/logout-callback",
                    "https://localhost:5001/authentication/logout-callback",
                    "https://localhost:5002/authentication/logout-callback",
                },
                clientUri: blazorRootUrl,
                postLogoutRedirectUri: $"{blazorRootUrl}/authentication/logout-callback"
            );
        }

        // Blazor Server Tiered Client
        var blazorServerTieredClientId = configurationSection["Bamboo_BlazorServerTiered:ClientId"];
        if (!blazorServerTieredClientId.IsNullOrWhiteSpace())
        {
            var blazorServerTieredRootUrl = configurationSection["Bamboo_BlazorServerTiered:RootUrl"].EnsureEndsWith('/');

            await CreateApplicationAsync(
                name: blazorServerTieredClientId,
                type: OpenIddictConstants.ClientTypes.Confidential,
                consentType: OpenIddictConstants.ConsentTypes.Implicit,
                displayName: "Blazor Server Application",
                secret: configurationSection["Bamboo_BlazorServerTiered:ClientSecret"] ?? "1q2w3e*",
                grantTypes: new List<string> //Hybrid flow
                {
                    OpenIddictConstants.GrantTypes.AuthorizationCode,
                    OpenIddictConstants.GrantTypes.Implicit
                },
                scopes: commonScopes,
                redirectUri: $"{blazorServerTieredRootUrl}signin-oidc",
                clientUri: blazorServerTieredRootUrl,
                redirectUris: new List<string>
                {
                    "https://pipay.vn/auth/signin-oidc",
                    "https://auth.pipay.vn:8443/signin-oidc",
                    "https://auth.pipay.vn/signin-oidc",
                    "https://localhost:4201/signin-oidc",
                    "https://localhost:44305/signin-oidc",
                    "https://localhost:5001/signin-oidc",
                    "https://localhost:5002/signin-oidc",
                },
                postLogoutRedirectUri: $"{blazorServerTieredRootUrl}signout-callback-oidc"
            );
        }

        // Swagger Client
        var swaggerClientId = configurationSection["Bamboo_Swagger:ClientId"];
        if (!swaggerClientId.IsNullOrWhiteSpace())
        {
            var swaggerRootUrl = configurationSection["Bamboo_Swagger:RootUrl"].TrimEnd('/');

            await CreateApplicationAsync(
                name: swaggerClientId,
                type: OpenIddictConstants.ClientTypes.Public,
                consentType: OpenIddictConstants.ConsentTypes.Implicit,
                displayName: "Swagger Application",
                secret: null,
                grantTypes: new List<string>
                {
                    OpenIddictConstants.GrantTypes.AuthorizationCode,
                },
                scopes: commonScopes,
                redirectUri: $"{swaggerRootUrl}/swagger/oauth2-redirect.html",
                redirectUris: new List<string>
                {
                    "https://auth.pipay.vn:8443/swagger/oauth2-redirect.html",
                    "https://auth.pipay.vn/swagger/oauth2-redirect.html",
                    "https://service.pipay.vn:8443/swagger/oauth2-redirect.html",
                    "https://service.pipay.vn/swagger/oauth2-redirect.html",
                    "https://admin.pipay.vn:8443/swagger/oauth2-redirect.html",
                    "https://admin.pipay.vn/swagger/oauth2-redirect.html",
                    "https://core.pipay.vn:8443/swagger/oauth2-redirect.html",
                    "https://core.pipay.vn/swagger/oauth2-redirect.html",
                    "https://notification.pipay.vn:8443/swagger/oauth2-redirect.html",
                    "https://notification.pipay.vn/swagger/oauth2-redirect.html",
                    "http://localhost:4200/swagger/oauth2-redirect.html",
                    "https://localhost:4201/swagger/oauth2-redirect.html",
                    "https://localhost:44305/swagger/oauth2-redirect.html",
                    "http://localhost:5001/swagger/oauth2-redirect.html",
                    "https://localhost:5001/swagger/oauth2-redirect.html",
                    "http://localhost:5002/swagger/oauth2-redirect.html",
                    "https://localhost:5002/swagger/oauth2-redirect.html",
                },
                clientUri: swaggerRootUrl
            );
        }
    }

    private async Task CreateApplicationAsync(
        [NotNull] string name,
        [NotNull] string type,
        [NotNull] string consentType,
        string displayName,
        string secret,
        List<string> grantTypes,
        List<string> scopes,
        string clientUri = null,
        string? redirectUri = null,
        string? postLogoutRedirectUri = null,
        List<string> permissions = null,
        List<string> redirectUris = null,
        List<string> postLogoutRedirectUris = null
    )
    {
        if (!string.IsNullOrEmpty(secret) && string.Equals(type, OpenIddictConstants.ClientTypes.Public, StringComparison.OrdinalIgnoreCase))
        {
            throw new BusinessException(L["NoClientSecretCanBeSetForPublicApplications"]);
        }

        if (string.IsNullOrEmpty(secret) && string.Equals(type, OpenIddictConstants.ClientTypes.Confidential, StringComparison.OrdinalIgnoreCase))
        {
            throw new BusinessException(L["TheClientSecretIsRequiredForConfidentialApplications"]);
        }

        if (!string.IsNullOrEmpty(name) && await _applicationManager.FindByClientIdAsync(name) != null)
        {
            return;
            //throw new BusinessException(L["TheClientIdentifierIsAlreadyTakenByAnotherApplication"]);
        }

        var client = await _applicationManager.FindByClientIdAsync(name);
        if (client == null)
        {
            var application = new AbpApplicationDescriptor
            {
                ClientId = name,
                Type = type,
                ClientSecret = secret,
                ConsentType = consentType,
                DisplayName = displayName,
                ClientUri = clientUri,
            };

            Check.NotNullOrEmpty(grantTypes, nameof(grantTypes));
            Check.NotNullOrEmpty(scopes, nameof(scopes));

            if (new [] { OpenIddictConstants.GrantTypes.AuthorizationCode, OpenIddictConstants.GrantTypes.Implicit }.All(grantTypes.Contains))
            {
                application.Permissions.Add(OpenIddictConstants.Permissions.ResponseTypes.CodeIdToken);

                if (string.Equals(type, OpenIddictConstants.ClientTypes.Public, StringComparison.OrdinalIgnoreCase))
                {
                    application.Permissions.Add(OpenIddictConstants.Permissions.ResponseTypes.CodeIdTokenToken);
                    application.Permissions.Add(OpenIddictConstants.Permissions.ResponseTypes.CodeToken);
                }
            }

            if (!redirectUris.IsNullOrEmpty() || !postLogoutRedirectUris.IsNullOrEmpty())
            {
                application.Permissions.Add(OpenIddictConstants.Permissions.Endpoints.Logout);
            }

            foreach (var grantType in grantTypes)
            {
                if (grantType == OpenIddictConstants.GrantTypes.AuthorizationCode)
                {
                    application.Permissions.Add(OpenIddictConstants.Permissions.GrantTypes.AuthorizationCode);
                    application.Permissions.Add(OpenIddictConstants.Permissions.ResponseTypes.Code);
                }

                if (grantType == OpenIddictConstants.GrantTypes.AuthorizationCode || grantType == OpenIddictConstants.GrantTypes.Implicit)
                {
                    application.Permissions.Add(OpenIddictConstants.Permissions.Endpoints.Authorization);
                }

                if (grantType == OpenIddictConstants.GrantTypes.AuthorizationCode ||
                    grantType == OpenIddictConstants.GrantTypes.ClientCredentials ||
                    grantType == OpenIddictConstants.GrantTypes.Password ||
                    grantType == OpenIddictConstants.GrantTypes.RefreshToken ||
                    grantType == OpenIddictConstants.GrantTypes.DeviceCode)
                {
                    application.Permissions.Add(OpenIddictConstants.Permissions.Endpoints.Token);
                    application.Permissions.Add(OpenIddictConstants.Permissions.Endpoints.Revocation);
                    application.Permissions.Add(OpenIddictConstants.Permissions.Endpoints.Introspection);
                }

                if (grantType == OpenIddictConstants.GrantTypes.ClientCredentials)
                {
                    application.Permissions.Add(OpenIddictConstants.Permissions.GrantTypes.ClientCredentials);
                }

                if (grantType == OpenIddictConstants.GrantTypes.Implicit)
                {
                    application.Permissions.Add(OpenIddictConstants.Permissions.GrantTypes.Implicit);
                }

                if (grantType == OpenIddictConstants.GrantTypes.Password)
                {
                    application.Permissions.Add(OpenIddictConstants.Permissions.GrantTypes.Password);
                }

                if (grantType == OpenIddictConstants.GrantTypes.RefreshToken)
                {
                    application.Permissions.Add(OpenIddictConstants.Permissions.GrantTypes.RefreshToken);
                }

                if (grantType == OpenIddictConstants.GrantTypes.DeviceCode)
                {
                    application.Permissions.Add(OpenIddictConstants.Permissions.GrantTypes.DeviceCode);
                    application.Permissions.Add(OpenIddictConstants.Permissions.Endpoints.Device);
                }

                if (grantType == OpenIddictConstants.GrantTypes.Implicit)
                {
                    application.Permissions.Add(OpenIddictConstants.Permissions.ResponseTypes.IdToken);
                    if (string.Equals(type, OpenIddictConstants.ClientTypes.Public, StringComparison.OrdinalIgnoreCase))
                    {
                        application.Permissions.Add(OpenIddictConstants.Permissions.ResponseTypes.IdTokenToken);
                        application.Permissions.Add(OpenIddictConstants.Permissions.ResponseTypes.Token);
                    }
                }
            }

            var buildInScopes = new []
            {
                OpenIddictConstants.Permissions.Scopes.Address,
                OpenIddictConstants.Permissions.Scopes.Email,
                OpenIddictConstants.Permissions.Scopes.Phone,
                OpenIddictConstants.Permissions.Scopes.Profile,
                OpenIddictConstants.Permissions.Scopes.Roles
            };

            foreach (var scope in scopes)
            {
                if (buildInScopes.Contains(scope))
                {
                    application.Permissions.Add(scope);
                }
                else
                {
                    application.Permissions.Add(OpenIddictConstants.Permissions.Prefixes.Scope + scope);
                }
            }

            if (redirectUri != null)
            {
                if (!redirectUri.IsNullOrEmpty())
                {
                    if (!Uri.TryCreate(redirectUri, UriKind.Absolute, out var uri) || !uri.IsWellFormedOriginalString())
                    {
                        throw new BusinessException(L["InvalidRedirectUri", redirectUri]);
                    }

                    if (application.RedirectUris.All(x => x != uri))
                    {
                        application.RedirectUris.Add(uri);
                    }
                }
            }

            if (postLogoutRedirectUri != null)
            {
                if (!postLogoutRedirectUri.IsNullOrEmpty())
                {
                    if (!Uri.TryCreate(postLogoutRedirectUri, UriKind.Absolute, out var uri) || !uri.IsWellFormedOriginalString())
                    {
                        throw new BusinessException(L["InvalidPostLogoutRedirectUri", postLogoutRedirectUri]);
                    }

                    if (application.PostLogoutRedirectUris.All(x => x != uri))
                    {
                        application.PostLogoutRedirectUris.Add(uri);
                    }
                }
            }

            if (permissions != null)
            {
                await _permissionDataSeeder.SeedAsync(
                    ClientPermissionValueProvider.ProviderName,
                    name,
                    permissions,
                    null
                );
            }
            if (!redirectUris.IsNullOrEmpty())
            {
                foreach (var redirect in redirectUris)
                {
					if (redirect.IsNullOrEmpty())
						continue;
                    if (!Uri.TryCreate(redirect, UriKind.Absolute, out var uri) || !uri.IsWellFormedOriginalString())
                    {
                        throw new BusinessException(L["InvalidRedirectUri", redirect]);
                    }

                    if (application.RedirectUris.All(x => x != uri))
                    {
                        application.RedirectUris.Add(uri);
                    }
                }
            }
			
			if (!postLogoutRedirectUris.IsNullOrEmpty())
            {
                foreach (var postLogoutUri in postLogoutRedirectUris)
                {
                    if (!postLogoutUri.IsNullOrEmpty())
                    {
                        if (!Uri.TryCreate(postLogoutUri, UriKind.Absolute, out var uri) || !uri.IsWellFormedOriginalString())
                        {
                            throw new BusinessException(L["InvalidPostLogoutRedirectUri", postLogoutUri]);
                        }

                        if (application.PostLogoutRedirectUris.All(x => x != uri))
                        {
                            application.PostLogoutRedirectUris.Add(uri);
                        }
                    }
                }
            }
            
			await _applicationManager.CreateAsync(application);
        }
    }
}
