using System.Net;

using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using Volo.Abp;
using Volo.Abp.Caching;
using Volo.Abp.Modularity;
using Volo.Abp.Sms;

using FirebaseAdmin;
using Google.Apis.Auth.OAuth2;
using Twilio;

using Bamboo.Abp.VerificationCode;

namespace Bamboo.Authentication;

[DependsOn(
    typeof(AbpCachingModule),
    typeof(AbpSmsModule))]
public class BambooAuthenticationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        var configuration = context.Services.GetConfiguration();

        context.Services.AddHttpClient();

        context.Services.TryAddTransient<IVerificationCodeGenerator, VerificationCodeGenerator>();
        context.Services.TryAddTransient<IVerificationCodeManager, VerificationCodeManager>();
        ConfigureFirebase(context, configuration);
        ConfigureTwilio(context, configuration);
    }

    private void ConfigureFirebase(ServiceConfigurationContext context, IConfiguration configuration)
    {
        FirebaseApp.Create(new AppOptions()
        {
            //export GOOGLE_APPLICATION_CREDENTIALS
            //Credential = GoogleCredential.GetApplicationDefault(),
            Credential = GoogleCredential.FromFile("firebase-adminsdk.json"),
        }); ;
    }

    private void ConfigureTwilio(ServiceConfigurationContext context, IConfiguration configuration)
    {
        // Find your Account SID and Auth Token at twilio.com/console
        // and set the environment variables. See http://twil.io/secure
        string accountSid = configuration["Twilio:AccountSID"];
        string authToken = configuration["Twilio:AuthToken"];
        TwilioClient.Init(accountSid, authToken);
    }
}

