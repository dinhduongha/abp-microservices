$name = $args[0]
$name = "Bamboo"
$abpver = "7.2.1"
$msver = "7.0.0"
$ntsver = "13.0.1"
$apps = "apps"
$shared_common = "shared/common"
#$app_name = "Bamboo.Admin"
$app_name = "$name.Admin"
$shared_app = "shared/admin"
$app_path = "$name/services/admin"
$sln_account = "$name.App.Host"
$sln_service = "$name.Services.All"
$sln_gateways = "$name.Gateways"
$sln_webs = "$name.Web"
$use_share = "True"	

if (-not(Test-Path -Path "$name")) {
	new-item "$name" -itemtype directory
	Copy-Item "./common.props*" -Destination ./$name/ -Force
}

function CreateCoreLibs {
	if (-not(Test-Path -Path "$name")) {
		new-item "$name" -itemtype directory
	}
	if (-not(Test-Path -Path "$name/$shared_common")){
		new-item "$name/$shared_common" -itemtype directory
	}
	if (-not(Test-Path -Path "$name/services")){
		new-item "$name/services" -itemtype directory
	}	
	
	dotnet new sln -n "$sln_service" -o ./$name/services
	
	dotnet new classlib -n "$name.Shared.Common" -o "./$name/$shared_common/$name.Shared.Common" --framework netstandard2.0
	dotnet add ./$name/$shared_common/$name.Shared.Common/$name.Shared.Common.csproj package Newtonsoft.Json -v $ntsver
	dotnet add ./$name/$shared_common/$name.Shared.Common/$name.Shared.Common.csproj package Volo.Abp.Guids -v $abpver
	dotnet add ./$name/$shared_common/$name.Shared.Common/$name.Shared.Common.csproj package Volo.Abp.Ddd.Application.Contracts -v $abpver
	Copy-Item -Path "./libs/Bamboo.Shared.Common/Extensions" -Destination ./$name/$shared_common/$name.Shared.Common/ -recurse -Force
	Copy-Item -Path "./libs/Bamboo.Shared.Common/Guids" -Destination ./$name/$shared_common/$name.Shared.Common/ -recurse -Force
	Copy-Item -Path "./libs/Bamboo.Shared.Common/Filter" -Destination ./$name/$shared_common/$name.Shared.Common/ -recurse -Force
	Copy-Item -Path "./libs/Bamboo.Shared.Common/Utils" -Destination ./$name/$shared_common/$name.Shared.Common/ -recurse -Force
	Copy-Item -Path "./libs/Bamboo.Shared.Common/AbpSharedCommonModule.cs" -Destination ./$name/$shared_common/$name.Shared.Common/ -recurse -Force
	Remove-Item -Path ./$name/$shared_common/$name.Shared.Common/Class1.cs -Force 

	dotnet new classlib -n "$name.Shared.EfCore" -o "$name/$shared_common/$name.Shared.EfCore"
	# Un-comment line below to enable TopologySuite/GIS
    dotnet add ./$name/$shared_common/$name.Shared.EfCore/$name.Shared.EfCore.csproj package Npgsql.EntityFrameworkCore.PostgreSQL.NetTopologySuite #-v 6.0.5
	dotnet add ./$name/$shared_common/$name.Shared.EfCore/$name.Shared.EfCore.csproj package Volo.Abp.EntityFrameworkCore -v $abpver
	dotnet add ./$name/$shared_common/$name.Shared.EfCore/$name.Shared.EfCore.csproj package EFCore.NamingConventions
	dotnet add ./$name/$shared_common/$name.Shared.EfCore/$name.Shared.EfCore.csproj reference ./$name/$shared_common/$name.Shared.Common/$name.Shared.Common.csproj
	Copy-Item -Path "./libs/Bamboo.Shared.EfCore/Extensions" -Destination ./$name/$shared_common/$name.Shared.EfCore/ -recurse -Force
	Copy-Item -Path "./libs/Bamboo.Shared.EfCore/AbpSharedEfCoreModule.cs" -Destination ./$name/$shared_common/$name.Shared.EfCore/ -recurse -Force
	Remove-Item -Path ./$name/$shared_common/$name.Shared.EfCore/Class1.cs -Force 

	dotnet new classlib -n "$name.Shared.Localization" -o "./$name/$shared_common/$name.Shared.Localization" --framework netstandard2.0
	Remove-Item -Path ./$name/$shared_common/$name.Shared.Localization/Class1.cs -Force 

	dotnet new classlib -n "$name.Shared.Hosting" -o "./$name/$shared_common/$name.Shared.Hosting" --framework netstandard2.0
	dotnet add ./$name/$shared_common/$name.Shared.Hosting/$name.Shared.Hosting.csproj package Serilog.Extensions.Logging -v "3.1.0"
	dotnet add ./$name/$shared_common/$name.Shared.Hosting/$name.Shared.Hosting.csproj package Serilog.Sinks.Async -v "1.5.0"
	dotnet add ./$name/$shared_common/$name.Shared.Hosting/$name.Shared.Hosting.csproj package Serilog.Sinks.File -v "5.0.0"
	#dotnet add ./$name/$shared_common/$name.Shared.Hosting/$name.Shared.Hosting.csproj package Serilog.Sinks.Console -v "4.0.1"
	dotnet add ./$name/$shared_common/$name.Shared.Hosting/$name.Shared.Hosting.csproj package Serilog.Sinks.ColoredConsole -v "3.0.1"
	dotnet add ./$name/$shared_common/$name.Shared.Hosting/$name.Shared.Hosting.csproj package Volo.Abp.Autofac -v $abpver
	dotnet add ./$name/$shared_common/$name.Shared.Hosting/$name.Shared.Hosting.csproj package Volo.Abp.Data -v $abpver
	Copy-Item -Path "./libs/Bamboo.Shared.Hosting/Hosting/*" -Destination ./$name/$shared_common/$name.Shared.Hosting/ -recurse -Force
	Remove-Item -Path ./$name/$shared_common/$name.Shared.Hosting/Class1.cs -Force 

	dotnet new classlib -n "$name.Shared.AspNetCore" -o "./$name/$shared_common/$name.Shared.AspNetCore"
	#dotnet add ./$name/$shared_common/$name.Shared.AspNetCore/$name.Shared.AspNetCore.csproj package Serilog.AspNetCore -v "5.0.0"
	dotnet add ./$name/$shared_common/$name.Shared.AspNetCore/$name.Shared.AspNetCore.csproj package Volo.Abp.AspNetCore.Serilog -v $abpver
	dotnet add ./$name/$shared_common/$name.Shared.AspNetCore/$name.Shared.AspNetCore.csproj package Volo.Abp.Swashbuckle -v $abpver
	dotnet add ./$name/$shared_common/$name.Shared.AspNetCore/$name.Shared.AspNetCore.csproj reference ./$name/$shared_common/$name.Shared.Hosting/$name.Shared.Hosting.csproj
	Copy-Item -Path "./libs/Bamboo.Shared.Hosting/AspNetCore/*" -Destination ./$name/$shared_common/$name.Shared.AspNetCore/ -recurse -Force
	Remove-Item -Path ./$name/$shared_common/$name.Shared.AspNetCore/Class1.cs -Force 
	
	dotnet new classlib -n "$name.Shared.Microservices" -o "./$name/$shared_common/$name.Shared.Microservices"
	dotnet add ./$name/$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj package Microsoft.AspNetCore.DataProtection.StackExchangeRedis -v $msver
	dotnet add ./$name/$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj package Microsoft.AspNetCore.Authentication.JwtBearer -v $msver
	dotnet add ./$name/$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj package DistributedLock.Redis -v 1.0.2
	dotnet add ./$name/$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj package Swashbuckle.AspNetCore #-v 6.4.0
	dotnet add ./$name/$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj package Hangfire.LiteDB
	dotnet add ./$name/$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj package IdentityModel -v 6.0.0
	#dotnet add ./$name/$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj package Serilog.Sinks.Async -v 1.5.0
	#dotnet add ./$name/$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj package Serilog.AspNetCore -v 5.0.0
	
	dotnet add ./$name/$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj package Volo.Abp.Autofac -v $abpver
	dotnet add ./$name/$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj package Volo.Abp.AspNetCore.Serilog -v $abpver
	dotnet add ./$name/$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj package Volo.Abp.AspNetCore.MultiTenancy -v $abpver	
	dotnet add ./$name/$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj package Volo.Abp.AspNetCore.Authentication.JwtBearer -v $abpver
	dotnet add ./$name/$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj package Volo.Abp.BackgroundJobs.RabbitMQ -v $abpver
	dotnet add ./$name/$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj package Volo.Abp.BackgroundJobs.HangFire -v $abpver
	dotnet add ./$name/$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj package Volo.Abp.BlobStoring -v $abpver	
	dotnet add ./$name/$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj package Volo.Abp.Caching.StackExchangeRedis -v $abpver
	dotnet add ./$name/$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj package Volo.Abp.Data -v $abpver
	dotnet add ./$name/$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj package Volo.Abp.DistributedLocking -v $abpver
	dotnet add ./$name/$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj package Volo.Abp.EntityFrameworkCore -v $abpver
	dotnet add ./$name/$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj package Volo.Abp.EntityFrameworkCore.PostgreSql -v $abpver
	dotnet add ./$name/$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj package Volo.Abp.EventBus.RabbitMQ -v $abpver
	dotnet add ./$name/$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj package Volo.Abp.EventBus.Azure -v $abpver
	dotnet add ./$name/$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj package Volo.Abp.EventBus.Kafka -v $abpver
	#dotnet add ./$name/$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj package Volo.Abp.EventBus.Rebus -v $abpver
	dotnet add ./$name/$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj package Volo.Abp.Localization -v $abpver
	dotnet add ./$name/$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj package Volo.Abp.MultiTenancy -v $abpver
	dotnet add ./$name/$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj package Volo.Abp.MongoDB -v $abpver
	dotnet add ./$name/$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj package Volo.Abp.Swashbuckle -v $abpver

	dotnet add ./$name/$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj package Volo.Abp.Identity.Application -v $abpver	
	dotnet add ./$name/$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj package Volo.Abp.TenantManagement.Application -v $abpver	

	#dotnet add ./$name/$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj package Volo.Abp.AuditLogging.EntityFrameworkCore -v $abpver
	#dotnet add ./$name/$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj package Volo.Abp.BackgroundJobs.EntityFrameworkCore -v $abpver
	dotnet add ./$name/$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj reference ./$name/$shared_common/$name.Shared.Hosting/$name.Shared.Hosting.csproj
	#dotnet add ./$name/$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj reference ./$name/$shared_common/$name.Shared.AspNetCore/$name.Shared.AspNetCore.csproj
	Copy-Item -Path "./libs/Bamboo.Shared.Hosting/Microservices/*" -Destination ./$name/$shared_common/$name.Shared.Microservices/ -recurse -Force
	Remove-Item -Path ./$name/$shared_common/$name.Shared.Microservices/Class1.cs -Force
	
	Copy-Item "./common.props*" -Destination ./$name/ -Force
	Copy-Item "./common.props*" -Destination ./$name/shared/ -Force
	Copy-Item "./common.props*" -Destination ./$name/web_apps/ -Force

	dotnet sln "./$name/services/$sln_service.sln" add --solution-folder "shared/common" (Get-ChildItem -r ./$name/$shared_common/**/*.csproj)
}

function CreateGateways {
	if (-not(Test-Path -Path "$name/gateways")){
		new-item "$name/gateways" -itemtype directory
	}
	dotnet new sln -n "$sln_gateways" -o ./$name/gateways
	dotnet new classlib -n "$name.Shared.Gateway" -o "./$name/gateways/shared/$name.Shared.Gateway"
	dotnet add ./$name/gateways/shared/$name.Shared.Gateway/$name.Shared.Gateway.csproj package Yarp.ReverseProxy -v 2.0.0
	dotnet add ./$name/gateways/shared/$name.Shared.Gateway/$name.Shared.Gateway.csproj reference ./$name/$shared_common/$name.Shared.AspNetCore/$name.Shared.AspNetCore.csproj
	Copy-Item -Path "./libs/Bamboo.Shared.Hosting/Gateways/*" -Destination ./$name/gateways/shared/$name.Shared.Gateway/ -recurse -Force
	Remove-Item -Path ./$name/gateways/shared/$name.Shared.Gateway/Class1.cs -Force 
	
	dotnet new web -n "$name.Gateway" -o "./$name/gateways/$name.Gateway"
	dotnet add ./$name/gateways/$name.Gateway/$name.Gateway.csproj reference ./$name/gateways/shared/$name.Shared.Gateway/$name.Shared.Gateway.csproj
	dotnet sln "./$name/gateways/$sln_gateways.sln" add (Get-ChildItem -r ./$name/gateways/**/*.csproj)
	dotnet sln "./$name/gateways/$sln_gateways.sln" add --solution-folder shared (Get-ChildItem -r ./$name/$shared_common/$name.Shared.Hosting/**/*.csproj)
	dotnet sln "./$name/gateways/$sln_gateways.sln" add --solution-folder shared (Get-ChildItem -r ./$name/$shared_common/$name.Shared.AspNetCore/**/*.csproj)
	#dotnet sln "./gateways/$sln_gateways.sln" add (Get-ChildItem -r ./$shared_common/$name.Shared.Gateway/**/*.csproj)
}

function CreateCoreApp  {
	if (-not(Test-Path -Path "./$name/$shared_app")){
		new-item "./$name/$shared_app" -itemtype directory
	}
	if (-not(Test-Path -Path "$name/$apps")){
		new-item "$name/$apps" -itemtype directory
	}	
	if (-not(Test-Path -Path "$app_path")){
		new-item "$app_path" -itemtype directory
	}
	if (-not(Test-Path -Path "$name/mobile")){
		new-item "$name/mobile" -itemtype directory
	}	
	if (-not(Test-Path -Path "$name/web_apps")){
		new-item "$name/web_apps" -itemtype directory
	}
	if (-not(Test-Path -Path "$name/web_apps/angular")){
		new-item "$name/web_apps/angular" -itemtype directory
	}	
	if ($use_share -ne "True") {
		$shared_app = "$app_path/$app_name/src"
	}
	Copy-Item "./common.props*" -Destination ./$name/web_apps/ -Force

	dotnet new sln -n "$sln_account" -o ./$name/$apps
	dotnet new sln -n "$sln_webs.Blazor" -o ./$name/web_apps
	dotnet new sln -n "$sln_webs.BlazorServer" -o ./$name/web_apps
	dotnet new sln -n "$sln_webs.MVC" -o ./$name/web_apps
	
	## Blazor Client
	# abp new "Bamboo" -t app --no-random-port -u blazor --database-provider ef -dbms PostgreSQL --create-solution-folder --skip-installing-libs -m none --skip-bundling -o temp/$name-blazor
	# abp new "Bamboo.Admin" -t app --no-random-port -u blazor --database-provider ef -dbms PostgreSQL --create-solution-folder --skip-installing-libs -m none --skip-bundling -o $name/$apps
	abp new "$app_name" -t app --no-random-port -u blazor --database-provider ef -dbms PostgreSQL --create-solution-folder --skip-installing-libs -m none --skip-bundling -o $app_path -v $abpver
	Remove-Item -Recurse -Force $app_path/$app_name/src/$app_name.Blazor
	#Move-Item -Path $name/$apps/$name/src/$name.Blazor -Destination ./$name/web_apps/"$name.Blazor" -Force


	Copy-Item -Path "./libs/Bamboo.AdminExtensions" -Destination $app_path/$app_name/src/$name.AdminExtensions -recurse -Force
	Move-Item -Path $app_path/$app_name/src/$name.AdminExtensions/Bamboo.AdminExtensions.csproj -Destination $app_path/$app_name/src/$name.AdminExtensions/$name.AdminExtensions.csproj -Force
	dotnet add $app_path/$app_name/src/$name.AdminExtensions/$name.AdminExtensions.csproj package Volo.Abp.AspNetCore.Mvc -v $abpver
	dotnet add $app_path/$app_name/src/$name.AdminExtensions/$name.AdminExtensions.csproj package Volo.Abp.AspNetCore.MultiTenancy -v $abpver
	dotnet add $app_path/$app_name/src/$name.AdminExtensions/$name.AdminExtensions.csproj package Volo.Abp.Autofac -v $abpver
	dotnet add $app_path/$app_name/src/$name.AdminExtensions/$name.AdminExtensions.csproj package Volo.Abp.Caching.StackExchangeRedis -v $abpver
	dotnet add $app_path/$app_name/src/$name.AdminExtensions/$name.AdminExtensions.csproj package Volo.Abp.DistributedLocking -v $abpver
	dotnet add $app_path/$app_name/src/$name.AdminExtensions/$name.AdminExtensions.csproj package Volo.Abp.Sms -v $abpver
	dotnet add $app_path/$app_name/src/$name.AdminExtensions/$name.AdminExtensions.csproj package Volo.Abp.Account.Application -v $abpver
	dotnet add $app_path/$app_name/src/$name.AdminExtensions/$name.AdminExtensions.csproj package Volo.Abp.Account.HttpApi -v $abpver
	dotnet add $app_path/$app_name/src/$name.AdminExtensions/$name.AdminExtensions.csproj package Volo.Abp.Identity.AspNetCore -v $abpver
	dotnet add $app_path/$app_name/src/$name.AdminExtensions/$name.AdminExtensions.csproj package Volo.Abp.Identity.Application -v $abpver
	dotnet add $app_path/$app_name/src/$name.AdminExtensions/$name.AdminExtensions.csproj package Volo.Abp.Identity.HttpApi -v $abpver
	dotnet add $app_path/$app_name/src/$name.AdminExtensions/$name.AdminExtensions.csproj package Volo.Abp.Identity.EntityFrameworkCore -v $abpver
	dotnet add $app_path/$app_name/src/$name.AdminExtensions/$name.AdminExtensions.csproj package Volo.Abp.OpenIddict.Domain -v $abpver
	dotnet add $app_path/$app_name/src/$name.AdminExtensions/$name.AdminExtensions.csproj package Volo.Abp.SettingManagement.Application -v $abpver
	dotnet add $app_path/$app_name/src/$name.AdminExtensions/$name.AdminExtensions.csproj package Volo.Abp.TenantManagement.Application -v $abpver
	dotnet add $app_path/$app_name/src/$name.AdminExtensions/$name.AdminExtensions.csproj package Volo.Abp.TenantManagement.HttpApi -v $abpver
	
	Copy-Item -Path "./libs/Bamboo.LoginUi.Web" -Destination $app_path/$app_name/src/$name.LoginUi.Web -recurse -Force
	Move-Item -Path $app_path/$app_name/src/$name.LoginUi.Web/Bamboo.LoginUi.Web.csproj -Destination $app_path/$app_name/src/$name.LoginUi.Web/$name.LoginUi.Web.csproj -Force
	dotnet add $app_path/$app_name/src/$name.LoginUi.Web package Volo.Abp.Caching.StackExchangeRedis -v $abpver
	dotnet add $app_path/$app_name/src/$name.LoginUi.Web package Volo.Abp.DistributedLocking -v $abpver
	dotnet add $app_path/$app_name/src/$name.LoginUi.Web package Volo.Abp.Account.Web.OpenIddict -v $abpver
	dotnet add $app_path/$app_name/src/$name.LoginUi.Web package Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared -v $abpver
	dotnet add $app_path/$app_name/src/$name.LoginUi.Web package Volo.Abp.Identity.Web -v $abpver
	dotnet add $app_path/$app_name/src/$name.LoginUi.Web package Volo.Abp.SettingManagement.Application -v $abpver
	dotnet add $app_path/$app_name/src/$name.LoginUi.Web package Volo.Abp.TenantManagement.Application -v $abpver

	## Blazor --separate-identity-server
	#abp new "$name" -t app --no-random-port -u blazor --database-provider ef -dbms PostgreSQL --create-solution-folder --separate-auth-server --skip-installing-libs -m none -o temp/$name-blazor-sis
	#abp new "$app_name" -t app --no-random-port -u blazor --database-provider ef -dbms PostgreSQL --create-solution-folder --separate-auth-server --skip-installing-libs -m none -o $app_path -v $abpver
	#Remove-Item -Recurse -Force $app_path/$app_name/src/$app_name.Blazor
	#Copy-Item -Path $app_path/$app_name/src/$app_name.Blazor -Destination ./$name/web_apps/"$name.Blazor" -recurse -Force
	#Move-Item -Path $app_path/$app_name/src/$app_name.HttpApi.Saas.Host/$name.HttpApi.Host.csproj -Destination $app_path/$app_name/src/"$name.HttpApi.Saas.Host.csproj" -Force

	abp new "$app_name" -t app --no-random-port -u blazor --database-provider ef -dbms PostgreSQL --create-solution-folder --separate-auth-server --skip-installing-libs -m none -o temp/$name-blazor-sis -v $abpver
    Copy-Item -Path temp/$name-blazor-sis/$app_name/src/$app_name.AuthServer -Destination $app_path/$app_name/src/$app_name.AuthServer -recurse -Force
	Copy-Item -Path temp/$name-blazor-sis/$app_name/src/$app_name.HttpApi.Host -Destination $app_path/$app_name/src/$app_name.HttpApi.Sis.Host -recurse -Force
	Move-Item -Path $app_path/$app_name/src/$app_name.HttpApi.Sis.Host/$app_name.HttpApi.Host.csproj -Destination $app_path/$app_name/src/$app_name.HttpApi.Sis.Host/$app_name.HttpApi.Sis.Host.csproj -Force

	## Angular
	abp new "$name" -t app --no-random-port -u angular --database-provider ef -dbms PostgreSQL --create-solution-folder --separate-auth-server  --skip-installing-libs -m react-native -o temp/$name-angular -v $abpver
	Move-Item -Path ./temp/$name-angular/$name/angular -Destination ./$name/web_apps/angular/app -Force
	Move-Item -Path ./temp/$name-angular/$name/react-native -Destination ./$name/mobile/ -Force
	
	# MAUI
	#abp new "Bamboo.App" -t maui --no-random-port --database-provider ef -dbms PostgreSQL --create-solution-folder --skip-installing-libs --skip-bundling -o temp/Bamboo-maui
	abp new "$name.App" -t maui --no-random-port --database-provider ef -dbms PostgreSQL  --separate-auth-server --skip-installing-libs -o $name/mobile/maui -v $abpver
	
	# No Layer application
	# abp new "Bamboo.Server" -t app-nolayers --no-random-port --database-provider ef -dbms PostgreSQL --create-solution-folder --skip-installing-libs -u none --skip-bundling -o Bamboo/apps
	# abp new "$name.Server" -t app-nolayers --no-random-port --database-provider ef -dbms PostgreSQL --create-solution-folder --skip-installing-libs -u none --skip-bundling -o $name/$apps -v $abpver

	# https://gist.github.com/ebicoglu/ce0f0425bab806d0ee1a87d0073af96b
	# dotnet new web -n "$app_name.ExternalLogin" -o $app_path/$app_name/src/$app_name.ExternalLogin
	# dotnet add $app_path/$app_name/src/$app_name.EntityFrameworkCore/$app_name.EntityFrameworkCore.csproj reference ./$shared_common/$name.Shared.EfCore/$name.Shared.EfCore.csproj

	dotnet add $app_path/$app_name/src/$app_name.Domain.Shared/$app_name.Domain.Shared.csproj package Newtonsoft.Json -v $ntsver
	dotnet add $app_path/$app_name/src/$app_name.Domain.Shared/$app_name.Domain.Shared.csproj package Volo.Abp.Guids -v $abpver
	dotnet add $app_path/$app_name/src/$app_name.Domain.Shared/$app_name.Domain.Shared.csproj package Volo.Abp.Ddd.Application.Contracts -v $abpver	
	dotnet add $app_path/$app_name/src/$app_name.EntityFrameworkCore/$app_name.EntityFrameworkCore.csproj package Npgsql.EntityFrameworkCore.PostgreSQL.NetTopologySuite -v 7.0.5
	
	Copy-Item -Path "./libs/Bamboo.Shared.Common/Extensions" -Destination $app_path/$app_name/src/$app_name.Domain.Shared/ -recurse -Force
	Copy-Item -Path "./libs/Bamboo.Shared.Common/Guids" -Destination $app_path/$app_name/src/$app_name.Domain.Shared/ -recurse -Force
	Copy-Item -Path "./libs/Bamboo.Shared.Common/Filter" -Destination $app_path/$app_name/src/$app_name.Domain.Shared/ -recurse -Force
	Copy-Item -Path "./libs/Bamboo.Shared.Common/Utils" -Destination $app_path/$app_name/src/$app_name.Domain.Shared/ -recurse -Force
	Copy-Item -Path "./libs/Bamboo.Shared.EfCore/Extensions" -Destination $app_path/$app_name/src/$app_name.EntityFrameworkCore/ -recurse -Force

	#Copy-Item -Path "./libs/Bamboo.AdminExtensions" -Destination $app_path/$app_name/src/$name.AdminExtensions -recurse -Force
	#Copy-Item -Path "./libs/Bamboo.LoginUi.Web" -Destination $app_path/$app_name/src/$name.LoginUi.Web -recurse -Force
	
	#dotnet add $app_path/$app_name/src/$name.AuthServer reference $app_path/$app_name/src/$name.AdminExtensions

	dotnet add $app_path/$app_name/src/$app_name.AuthServer reference $app_path/$app_name/src/$name.LoginUi.Web
	dotnet add $app_path/$app_name/src/$app_name.HttpApi.Host reference $app_path/$app_name/src/$name.AdminExtensions
	dotnet add $app_path/$app_name/src/$app_name.HttpApi.Host reference $app_path/$app_name/src/$name.LoginUi.Web
	dotnet add $app_path/$app_name/src/$app_name.HttpApi.Sis.Host reference $app_path/$app_name/src/$name.AdminExtensions

	#dotnet add $app_path/$app_name/src/$app_name.HttpApi.Host reference $name/$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj
	#dotnet add $app_path/$app_name/src/$app_name.HttpApi.Sis.Host reference $name/$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj

	if ($use_share -eq "True") {	
		Copy-Item -Path "$app_path/$app_name/src/$app_name.Domain.Shared" -Destination "./$name/$shared_app/" -recurse -Force
		Copy-Item -Path "$app_path/$app_name/src/$app_name.Application.Contracts" -Destination "./$name/$shared_app/" -recurse -Force
		Copy-Item -Path "$app_path/$app_name/src/$app_name.HttpApi.Client" -Destination "./$name/$shared_app/" -recurse -Force
		
		# For MVC
		# Copy-Item -Path "$app_path/$app_name/src/$app_name.HttpApi" -Destination "./$name/$shared_app/" -recurse -Force
	}
	dotnet sln "$app_path/$app_name/$app_name.sln" remove $app_path/$app_name/src/$app_name.Blazor/$app_name.Blazor.csproj
	dotnet sln "$app_path/$app_name/$app_name.sln" add (Get-ChildItem -r $app_path/$app_name/src/**/*.csproj)
	#dotnet sln "$app_path/$app_name/$app_name.sln" add --solution-folder src (Get-ChildItem -r $name/$shared_common/$name.Shared.Microservices/**/*.csproj)
	#dotnet sln "$app_path/$app_name/$app_name.sln" add --solution-folder src (Get-ChildItem -r $name/$shared_common/$name.Shared.Hosting/**/*.csproj)

	dotnet sln "./$name/$apps/$sln_account.sln" add (Get-ChildItem -r $app_path/$app_name/src/**/*.csproj)	
	
	## Blazor Client
	abp new "$name" -t app --no-random-port -u blazor --database-provider ef -dbms PostgreSQL --create-solution-folder --skip-installing-libs -m none --skip-bundling -o temp/$name-blazor-client -v $abpver
	Copy-Item -Path temp/$name-blazor-client/$name/src/$name.Blazor -Destination ./$name/web_apps/"$name.Blazor" -recurse -Force

	dotnet remove ./$name/web_apps/$name.Blazor/$name.Blazor.csproj reference "..\..\src\$name.HttpApi.Client\$name.HttpApi.Client.csproj"
	dotnet add ./$name/web_apps/$name.Blazor/$name.Blazor.csproj reference $name/$shared_app/$app_name.HttpApi.Client/$app_name.HttpApi.Client.csproj	
	
	dotnet sln ./$name/web_apps/$sln_webs.Blazor.sln add --solution-folder shared (Get-ChildItem -r $name/$shared_common/$name.Shared.Common/$name.Shared.Common.csproj)
	dotnet sln ./$name/web_apps/$sln_webs.Blazor.sln add --solution-folder shared (Get-ChildItem -r $name/$shared_app/$app_name.Domain.Shared/$app_name.Domain.Shared.csproj)
	dotnet sln ./$name/web_apps/$sln_webs.Blazor.sln add --solution-folder shared (Get-ChildItem -r $name/$shared_app/$app_name.Application.Contracts/$app_name.Application.Contracts.csproj)
	dotnet sln ./$name/web_apps/$sln_webs.Blazor.sln add --solution-folder shared (Get-ChildItem -r $name/$shared_app/$app_name.HttpApi.Client/$app_name.HttpApi.Client.csproj)
	dotnet sln ./$name/web_apps/$sln_webs.Blazor.sln add (Get-ChildItem -r ./$name/web_apps/$name.Blazor/**/*.csproj)

	## Blazor Server
	# abp new "Bamboo" -t app --no-random-port -u blazor-server -m none --tiered --database-provider ef -dbms PostgreSQL --create-solution-folder -o temp/blazor-server --skip-installing-libs
	abp new "$name" -t app --no-random-port -u blazor-server -m none --tiered --database-provider ef -dbms PostgreSQL --create-solution-folder --skip-installing-libs -o temp/$name-blazor-server -v $abpver
	Copy-Item -Path ./temp/$name-blazor-server/$name/src/$name.Blazor -Destination ./$name/web_apps/$name.BlazorServer -recurse -Force
	dotnet remove ./$name/web_apps/$name.BlazorServer/$name.Blazor.csproj reference "..\$name.HttpApi.Client\$name.HttpApi.Client.csproj"
	dotnet add ./$name/web_apps/$name.BlazorServer/$name.Blazor.csproj reference $name/$shared_app/$app_name.HttpApi.Client/$app_name.HttpApi.Client.csproj	
	Move-Item ./$name/web_apps/$name.BlazorServer/$name.Blazor.csproj -Destination "./$name/web_apps/$name.BlazorServer/$name.BlazorServer.csproj" -Force
	dotnet sln ./$name/web_apps/$sln_webs.BlazorServer.sln add --solution-folder shared (Get-ChildItem -r $name/$shared_common/$name.Shared.Common/$name.Shared.Common.csproj)
	dotnet sln ./$name/web_apps/$sln_webs.BlazorServer.sln add --solution-folder shared (Get-ChildItem -r $name/$shared_app/$app_name.Domain.Shared/$app_name.Domain.Shared.csproj)
	dotnet sln ./$name/web_apps/$sln_webs.BlazorServer.sln add --solution-folder shared (Get-ChildItem -r $name/$shared_app/$app_name.Application.Contracts/$app_name.Application.Contracts.csproj)
	dotnet sln ./$name/web_apps/$sln_webs.BlazorServer.sln add --solution-folder shared (Get-ChildItem -r $name/$shared_app/$app_name.HttpApi.Client/$app_name.HttpApi.Client.csproj)
	dotnet sln ./$name/web_apps/$sln_webs.BlazorServer.sln add (Get-ChildItem -r ./$name/web_apps/$name.BlazorServer/**/*.csproj)	

	## MVC
	# abp new "Bamboo" -t app --no-random-port -u mvc -m none --tiered --database-provider ef -dbms PostgreSQL --create-solution-folder -o ./temp/mvc --skip-installing-libs
	abp new "$name" -t app --no-random-port -u mvc -m none --tiered --database-provider ef -dbms PostgreSQL --create-solution-folder --skip-installing-libs -o ./temp/$name-mvc -v $abpver
	Copy-Item -Path ./temp/$name-mvc/$name/src/$name.Web -Destination ./$name/web_apps/ -recurse -Force
	dotnet remove ./$name/web_apps/$name.Web/$name.Web.csproj reference "..\$name.HttpApi.Client\$name.HttpApi.Client.csproj"
	dotnet remove ./$name/web_apps/$name.Web/$name.Web.csproj reference "..\$name.HttpApi\$name.HttpApi.csproj"	
	dotnet add ./$name/web_apps/$name.Web/$name.Web.csproj reference $name/$shared_app/$app_name.HttpApi.Client/$app_name.HttpApi.Client.csproj
	#dotnet add ./$name/web_apps/$name.Web/$name.Web.csproj reference $name/$shared_app/$app_name.Domain.Shared/$app_name.Domain.Shared.csproj
	#dotnet add ./$name/web_apps/$name.Web/$name.Web.csproj reference $name/$shared_app/$app_name.HttpApi/$app_name.HttpApi.csproj
	#dotnet add ./$name/web_apps/$name.Web/$name.Web.csproj reference $app_path/$app_name/src/$name.HttpApi/$name.HttpApi.csproj
	dotnet sln ./$name/web_apps/$sln_webs.MVC.sln add --solution-folder shared (Get-ChildItem -r $name/$shared_common/$name.Shared.Common/$name.Shared.Common.csproj)
	dotnet sln ./$name/web_apps/$sln_webs.MVC.sln add --solution-folder shared (Get-ChildItem -r $name/$shared_app/$app_name.Domain.Shared/$app_name.Domain.Shared.csproj)
	dotnet sln ./$name/web_apps/$sln_webs.MVC.sln add --solution-folder shared (Get-ChildItem -r $name/$shared_app/$app_name.Application.Contracts/$app_name.Application.Contracts.csproj)
	dotnet sln ./$name/web_apps/$sln_webs.MVC.sln add --solution-folder shared (Get-ChildItem -r $name/$shared_app/$app_name.HttpApi.Client/$app_name.HttpApi.Client.csproj)
	dotnet sln ./$name/web_apps/$sln_webs.MVC.sln add (Get-ChildItem -r ./$name/web_apps/$name.Web/**/*.csproj)
	
	# MVC use 
	#dotnet sln ./$name/web_apps/$sln_webs.MVC.sln add --solution-folder shared (Get-ChildItem -r $name/$shared_app/$name.HttpApi/$name.HttpApi.csproj)
	#dotnet sln ./$name/web_apps/$sln_webs.MVC.sln add --solution-folder shared (Get-ChildItem -r $app_path/$app_name/src/$app_name.HttpApi/$app_name.HttpApi.csproj)
	#dotnet sln "./$name/web_apps/$sln_webs.sln" add (Get-ChildItem -r ./$apps/$name/src/$name.Domain/$name.Domain.csproj)
	#dotnet sln "./$name/web_apps/$sln_webs.sln" add (Get-ChildItem -r ./$apps/$name/src/$name.Application/$name.Application.csproj)
	
	## Un-comment to use Newtonsoft.Json and Volo.Abp.Guids at client side
	#dotnet add ./$name/web_apps/$name.Blazor/$name.Blazor.csproj package Newtonsoft.Json -v $ntsver
	#dotnet add ./$name/web_apps/$name.Blazor/$name.Blazor.csproj package Volo.Abp.Guids -v $abpver
	#dotnet add ./$name/web_apps/$name.BlazorServer/$name.Blazor.csproj package Newtonsoft.Json -v $ntsver
	#dotnet add ./$name/web_apps/$name.BlazorServer/$name.BlazorServer.csproj package Volo.Abp.Guids -v $abpver
	#dotnet add ./$name/web_apps/$name.Web/$name.Web.csproj package Newtonsoft.Json -v $ntsver
	#dotnet add ./$name/web_apps/$name.Web/$name.Web.csproj package Volo.Abp.Guids -v $abpver

	dotnet add ./$name/web_apps/$name.Blazor/$name.Blazor.csproj reference $name/$shared_common/$name.Shared.Common/$name.Shared.Common.csproj
	dotnet add ./$name/web_apps/$name.BlazorServer/$name.BlazorServer.csproj reference $name/$shared_common/$name.Shared.Common/$name.Shared.Common.csproj
	dotnet add ./$name/web_apps/$name.Web/$name.Web.csproj reference $name/$shared_common/$name.Shared.Common/$name.Shared.Common.csproj
	dotnet sln ./$name/web_apps/$sln_webs.Blazor.sln add --solution-folder shared $name/$shared_common/$name.Shared.Common/$name.Shared.Common.csproj
	dotnet sln ./$name/web_apps/$sln_webs.BlazorServer.sln add --solution-folder shared $name/$shared_common/$name.Shared.Common/$name.Shared.Common.csproj
	dotnet sln ./$name/web_apps/$sln_webs.MVC.sln add --solution-folder shared $name/$shared_common/$name.Shared.Common/$name.Shared.Common.csproj
	
	## ATTENTION: Remember to REMOVE un-use reference in Web projects
	#Remove-Item -Recurse -Force ./temp/sas/
	#Remove-Item -Recurse -Force ./temp/blazor-server/
	#Remove-Item -Recurse -Force ./temp/mvc/
	#Remove-Item -Recurse -Force ./temp/angular/

	#cmd /c pause
	#dotnet sln "./$name.sln" remove (Get-ChildItem -r **/*.Host.Shared.csproj)
	#dotnet sln "./$name.sln" remove (Get-ChildItem -r **/*.Installer.csproj)
	#dotnet sln "./$name.sln" remove (Get-ChildItem -r **/*.MongoDB.csproj)
	#dotnet sln "./$name.sln" remove (Get-ChildItem -r **/*.MongoDB.Tests.csproj)
	
	#Remove-Item -Recurse -Force (Get-ChildItem -r **/*.Host.Shared)
	#Remove-Item -Recurse -Force (Get-ChildItem -r **/*.MongoDB.Tests)
	#Remove-Item -Recurse -Force (Get-ChildItem -r **/*.MongoDB)
	#Remove-Item -Recurse -Force (Get-ChildItem -r **/*.Installer)
}

function AppAddSource {
	# FOR APPS
	#abp add-module Volo.AuditLogging -s "./$apps/$sln_account.sln" --skip-db-migrations
	#abp add-module Volo.FeatureManagement -s "./$apps/$sln_account.sln" --skip-db-migrations
	#abp add-module Volo.PermissionManagement -s "./$apps/$sln_account.sln" --skip-db-migrations
	#abp add-module Volo.SettingManagement -s "./$apps/$sln_account.sln" --skip-db-migrations
	#abp add-module Volo.Identity -s "./$apps/$sln_account.sln" --skip-db-migrations
	#abp add-module Volo.OpenIddict -s "./$apps/$sln_account.sln" --skip-db-migrations
	#abp add-module Volo.TenantManagement -s "./$apps/$sln_account.sln" --skip-db-migrations
}

CreateCoreLibs
#CreateGateways
CreateCoreApp

cmd /c pause
