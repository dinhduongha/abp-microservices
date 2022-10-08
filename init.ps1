$name = $args[0]
$ver = "6.0.0"
$apps = "account"
$shared_common = "shared/common"
$sln_account = "$name.Account"
$sln_service = "$name.Services.All"
$sln_webs = "$name.Web"
$sln_gateways = "$name.Gateways"
	
function CreateCoreLibs {
	new-item "$shared_common" -itemtype directory
	new-item "$apps" -itemtype directory
	new-item "services" -itemtype directory
	new-item "gateways" -itemtype directory
	new-item "web_apps" -itemtype directory

	dotnet new sln -n "$sln_account" -o ./$apps
	dotnet new sln -n "$sln_gateways" -o ./gateways
	dotnet new sln -n "$sln_service" -o ./services
	dotnet new sln -n "$sln_webs" -o ./web_apps

	dotnet new classlib -n "$name.Shared.Common" -o "./$shared_common/$name.Shared.Common" --framework netstandard2.0
	dotnet add ./$shared_common/$name.Shared.Common/$name.Shared.Common.csproj package Newtonsoft.Json -v "13.0.1"
	dotnet add ./$shared_common/$name.Shared.Common/$name.Shared.Common.csproj package Volo.Abp.Guids -v $ver
	dotnet add ./$shared_common/$name.Shared.Common/$name.Shared.Common.csproj package Volo.Abp.Ddd.Application.Contracts -v $ver
	
	dotnet new classlib -n "$name.Shared.EfCore" -o "$shared_common/$name.Shared.EfCore"
	# Un-comment line below to enable TopologySuite/GIS
    dotnet add ./$shared_common/$name.Shared.EfCore/$name.Shared.EfCore.csproj package Npgsql.EntityFrameworkCore.PostgreSQL.NetTopologySuite -v 6.0.5
	dotnet add ./$shared_common/$name.Shared.EfCore/$name.Shared.EfCore.csproj package Volo.Abp.EntityFrameworkCore -v $ver
	dotnet add ./$shared_common/$name.Shared.EfCore/$name.Shared.EfCore.csproj reference ./$shared_common/$name.Shared.Common/$name.Shared.Common.csproj
	Copy-Item -Path "./libs/Bamboo.Shared.Common/Extensions" -Destination ./$shared_common/$name.Shared.Common/ -recurse -Force
	Copy-Item -Path "./libs/Bamboo.Shared.Common/Guids" -Destination ./$shared_common/$name.Shared.Common/ -recurse -Force
	Copy-Item -Path "./libs/Bamboo.Shared.Common/Filter" -Destination ./$shared_common/$name.Shared.Common/ -recurse -Force
	Copy-Item -Path "./libs/Bamboo.Shared.Common/Utils" -Destination ./$shared_common/$name.Shared.Common/ -recurse -Force
	Copy-Item -Path "./libs/Bamboo.Shared.EfCore/Extensions" -Destination ./$shared_common/$name.Shared.EfCore/ -recurse -Force
	
	dotnet new classlib -n "$name.Shared.Localization" -o "./$shared_common/$name.Shared.Localization" --framework netstandard2.0

	dotnet new classlib -n "$name.Shared.Hosting" -o "./$shared_common/$name.Shared.Hosting" --framework netstandard2.0
	dotnet add ./$shared_common/$name.Shared.Hosting/$name.Shared.Hosting.csproj package Serilog.Extensions.Logging -v "3.1.0"
	dotnet add ./$shared_common/$name.Shared.Hosting/$name.Shared.Hosting.csproj package Serilog.Sinks.Async -v "1.5.0"
	dotnet add ./$shared_common/$name.Shared.Hosting/$name.Shared.Hosting.csproj package Serilog.Sinks.File -v "5.0.0"
	dotnet add ./$shared_common/$name.Shared.Hosting/$name.Shared.Hosting.csproj package Serilog.Sinks.Console -v "4.0.1"
	dotnet add ./$shared_common/$name.Shared.Hosting/$name.Shared.Hosting.csproj package Volo.Abp.Autofac -v $ver
	dotnet add ./$shared_common/$name.Shared.Hosting/$name.Shared.Hosting.csproj package Volo.Abp.Data -v $ver
	Copy-Item -Path "./libs/Bamboo.Shared.Hosting/Hosting/*" -Destination ./$shared_common/$name.Shared.Hosting/ -recurse -Force

	dotnet new classlib -n "$name.Shared.AspNetCore" -o "./$shared_common/$name.Shared.AspNetCore"
	dotnet add ./$shared_common/$name.Shared.AspNetCore/$name.Shared.AspNetCore.csproj package Serilog.AspNetCore -v "4.1.0"
	dotnet add ./$shared_common/$name.Shared.AspNetCore/$name.Shared.AspNetCore.csproj package Volo.Abp.AspNetCore.Serilog -v $ver
	dotnet add ./$shared_common/$name.Shared.AspNetCore/$name.Shared.AspNetCore.csproj package Volo.Abp.Swashbuckle -v $ver
	dotnet add ./$shared_common/$name.Shared.AspNetCore/$name.Shared.AspNetCore.csproj reference ./$shared_common/$name.Shared.Hosting/$name.Shared.Hosting.csproj
	Copy-Item -Path "./libs/Bamboo.Shared.Hosting/AspNetCore/*" -Destination ./$shared_common/$name.Shared.AspNetCore/ -recurse -Force
	
	dotnet new classlib -n "$name.Shared.Microservices" -o "./$shared_common/$name.Shared.Microservices"
	dotnet add ./$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj package Microsoft.AspNetCore.DataProtection.StackExchangeRedis -v 6.0.5
	dotnet add ./$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj package Microsoft.AspNetCore.Authentication.JwtBearer -v 6.0.5
	dotnet add ./$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj package DistributedLock.Redis -v 1.0.1
	dotnet add ./$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj package Swashbuckle.AspNetCore -v 6.4.0
	
	dotnet add ./$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj package Volo.Abp.AspNetCore.MultiTenancy -v $ver
	dotnet add ./$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj package Volo.Abp.EventBus.RabbitMQ -v $ver
	dotnet add ./$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj package Volo.Abp.BackgroundJobs.RabbitMQ -v $ver
	dotnet add ./$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj package Volo.Abp.Caching.StackExchangeRedis -v $ver
	dotnet add ./$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj package Volo.Abp.DistributedLocking -v $ver
	dotnet add ./$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj package Volo.Abp.MongoDB -v $ver
	dotnet add ./$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj package Volo.Abp.EntityFrameworkCore -v $ver
	dotnet add ./$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj reference ./$shared_common/$name.Shared.AspNetCore/$name.Shared.AspNetCore.csproj
	Copy-Item -Path "./libs/Bamboo.Shared.Hosting/Microservices/*" -Destination ./$shared_common/$name.Shared.Microservices/ -recurse -Force

}

function CreateGateways {
	dotnet new classlib -n "$name.Shared.Gateway" -o "./gateways/shared/$name.Shared.Gateway"
	dotnet add ./gateways/shared/$name.Shared.Gateway/$name.Shared.Gateway.csproj package Yarp.ReverseProxy -v 1.0.0
	dotnet add ./gateways/shared/$name.Shared.Gateway/$name.Shared.Gateway.csproj reference ./$shared_common/$name.Shared.AspNetCore/$name.Shared.AspNetCore.csproj
	Copy-Item -Path "./libs/Bamboo.Shared.Hosting/Gateways/*" -Destination ./gateways/shared/$name.Shared.Gateway/ -recurse -Force
	
	dotnet new web -n "$name.Gateway" -o "./gateways/$name.Gateway"
	dotnet add ./gateways/$name.Gateway/$name.Gateway.csproj reference ./gateways/shared/$name.Shared.Gateway/$name.Shared.Gateway.csproj
	dotnet sln "./gateways/$sln_gateways.sln" add (Get-ChildItem -r ./gateways/**/*.csproj)
	dotnet sln "./gateways/$sln_gateways.sln" add --solution-folder shared (Get-ChildItem -r ./$shared_common/$name.Shared.Hosting/**/*.csproj)
	dotnet sln "./gateways/$sln_gateways.sln" add --solution-folder shared (Get-ChildItem -r ./$shared_common/$name.Shared.AspNetCore/**/*.csproj)
	#dotnet sln "./gateways/$sln_gateways.sln" add (Get-ChildItem -r ./$shared_common/$name.Shared.Gateway/**/*.csproj)
}

function CreateCoreServices {
	$services = @{}
	$services.Add('Administration', 'administration')

	foreach($service in $services.keys)
	{
		$folder = $services[$service]
		abp new "$name.$service" -t module --no-ui -o services/$folder --skip-installing-libs
		# Un-comment line below to enable TopologySuite/GIS
		dotnet add ./services/$folder/host/"$name.$service".HttpApi.Host/"$name.$service".HttpApi.Host.csproj package Npgsql.EntityFrameworkCore.PostgreSQL.NetTopologySuite -v 6.0.5		
		dotnet add ./services/$folder/host/"$name.$service".HttpApi.Host/"$name.$service".HttpApi.Host.csproj package Volo.Abp.EntityFrameworkCore.PostgreSql
		dotnet add ./services/$folder/src/"$name.$service".Domain.Shared/"$name.$service".Domain.Shared.csproj reference ./$shared_common/$name.Shared.Common/$name.Shared.Common.csproj
		dotnet add ./services/$folder/src/"$name.$service".EntityFrameworkCore/"$name.$service".EntityFrameworkCore.csproj reference ./$shared_common/$name.Shared.EfCore/$name.Shared.EfCore.csproj
		dotnet add ./services/$folder/host/"$name.$service".HttpApi.Host/"$name.$service".HttpApi.Host.csproj reference ./$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj
		#dotnet add ./services/$folder/src/"$name.$service".Domain/"$name.$service".Domain.csproj reference ./$shared_common/$name.Shared.Domain/$name.Shared.Domain.csproj
		
		dotnet new console -n "$name.$service.DbMigrator" -o ./services/$folder/host/$name.$service.DbMigrator
		dotnet add ./services/$folder/host/$name.$service.DbMigrator/$name.$service.DbMigrator.csproj package Volo.Abp.Autofac -v $ver	
		dotnet add ./services/$folder/host/$name.$service.DbMigrator/$name.$service.DbMigrator.csproj package Volo.Abp.BackgroundJobs -v $ver
		dotnet add ./services/$folder/host/$name.$service.DbMigrator/$name.$service.DbMigrator.csproj package Volo.Abp.Identity.Domain -v $ver
		dotnet add ./services/$folder/host/$name.$service.DbMigrator/$name.$service.DbMigrator.csproj package Volo.Abp.TenantManagement.Domain -v $ver			
		dotnet add ./services/$folder/host/$name.$service.DbMigrator/$name.$service.DbMigrator.csproj package Microsoft.Extensions.Hosting -v "6.0.1"
		dotnet add ./services/$folder/host/$name.$service.DbMigrator/$name.$service.DbMigrator.csproj package Serilog.Extensions.Logging -v "3.1.0"
		dotnet add ./services/$folder/host/$name.$service.DbMigrator/$name.$service.DbMigrator.csproj package Serilog.Sinks.Async -v "1.5.0"
		dotnet add ./services/$folder/host/$name.$service.DbMigrator/$name.$service.DbMigrator.csproj package Serilog.Sinks.File -v "5.0.0"
		dotnet add ./services/$folder/host/$name.$service.DbMigrator/$name.$service.DbMigrator.csproj package Serilog.Sinks.Console -v "4.0.1"	
		dotnet add ./services/$folder/host/$name.$service.DbMigrator/$name.$service.DbMigrator.csproj reference ./services/$folder/src/$name.$service.Application.Contracts/$name.$service.Application.Contracts.csproj
		dotnet add ./services/$folder/host/$name.$service.DbMigrator/$name.$service.DbMigrator.csproj reference ./services/$folder/src/$name.$service.EntityFrameworkCore/$name.$service.EntityFrameworkCore.csproj		
		Copy-Item -Path "./libs/Bamboo.Shared.DbMigrator/*" -Destination ./services/$folder/host/$name.$service.DbMigrator/ -recurse -Force
			
		#dotnet sln "./services/$folder/$name.$service.sln" remove (Get-ChildItem -r ./services/$folder/host/$name.$service.Host.Shared/$name.$service.Host.Shared.csproj)
		#dotnet sln "./services/$folder/$name.$service.sln" remove (Get-ChildItem -r ./services/$folder/host/$name.$service.AuthServer/$name.$service.AuthServer.csproj)
		dotnet sln "./services/$folder/$name.$service.sln" remove (Get-ChildItem -r ./services/$folder/src/$name.$service.Installer/$name.$service.Installer.csproj)
		dotnet sln "./services/$folder/$name.$service.sln" remove (Get-ChildItem -r ./services/$folder/src/$name.$service.MongoDB/$name.$service.MongoDB.csproj)
		dotnet sln "./services/$folder/$name.$service.sln" remove (Get-ChildItem -r ./services/$folder/test/$name.$service.MongoDB.Tests/$name.$service.MongoDB.Tests.csproj)

		#Remove-Item -Recurse -Force (Get-ChildItem -r **/*.$service.Host.Shared)
		#Remove-Item -Recurse -Force (Get-ChildItem -r ./services/**/*.$service.AuthServer)
		Remove-Item -Recurse -Force (Get-ChildItem -r ./services/**/*.$service.Installer)
		Remove-Item -Recurse -Force (Get-ChildItem -r ./services/**/*.$service.MongoDB)
		Remove-Item -Recurse -Force (Get-ChildItem -r ./services/**/*.$service.MongoDB.Tests)
		
		dotnet sln "./services/$folder/$name.$service.sln" add --solution-folder shared (Get-ChildItem -r ./$shared_common/**/*.csproj)
		dotnet sln "./services/$folder/$name.$service.sln" add --solution-folder host ./services/$folder/host/$name.$service.DbMigrator/$name.$service.DbMigrator.csproj

	}

	dotnet sln "./services/$sln_service.sln" add --solution-folder shared (Get-ChildItem -r ./$shared_common/**/*.csproj)
	dotnet sln "./services/$sln_service.sln" add (Get-ChildItem -r ./services/**/*.csproj)
}

function CreateCoreApp  {

	## Blazor
	abp new "$name" -t app --no-random-port -u blazor -m none --database-provider ef -dbms PostgreSQL --create-solution-folder -o $apps --skip-installing-libs
	#Move-Item -Path "./$apps/$name/src/$name.DbMigrator" -Destination ./$apps/"$name.DbMigrator" -Force
	Move-Item -Path "./$apps/$name/src/$name.Blazor" -Destination ./web_apps/"$name.Blazor" -Force

	## Blazor Sas
	abp new "$name" -t app --no-random-port -u blazor -m none --database-provider ef -dbms PostgreSQL --create-solution-folder -o temp-sas --separate-auth-server --skip-installing-libs 
	Move-Item -Path "./temp-sas/$name/src/$name.AuthServer" -Destination ./$apps/$name/src/"$name.AuthServer" -Force
	
	## Blazor Server
	abp new "$name" -t app --no-random-port -u blazor-server -m none --tiered --database-provider ef -dbms PostgreSQL --create-solution-folder -o temp-blazor-server --skip-installing-libs
	Move-Item -Path "./temp-blazor-server/$name/src/$name.Blazor" -Destination ./web_apps/"$name.BlazorServer" -Force

	## MVC
	abp new "$name" -t app --no-random-port -u mvc -m none --tiered --database-provider ef -dbms PostgreSQL --create-solution-folder -o temp-mvc --skip-installing-libs
	Move-Item -Path "./temp-mvc/$name/src/$name.Web" -Destination ./web_apps/ -Force

	## Angular
	#abp new "$name" -t app --no-random-port -u angular -m none --separate-auth-server --database-provider ef -dbms PostgreSQL --create-solution-folder -o temp-angular --skip-installing-libs
	#Move-Item -Path "./temp-angular/$name/angular/" -Destination ./web_apps/angular
	#Remove-Item -Recurse -Force ./temp-angular/

	# https://gist.github.com/ebicoglu/ce0f0425bab806d0ee1a87d0073af96b
	# dotnet new web -n "$name.ExternalLogin" -o ./$apps/$name/src/"$name.ExternalLogin"
	# dotnet add ./$apps/$name/src/$name.EntityFrameworkCore/$name.EntityFrameworkCore.csproj reference ./$shared_common/Bamboo.Shared.EfCore/Bamboo.Shared.EfCore.csproj
	# dotnet add ./$apps/$name/src/$name.EntityFrameworkCore/$name.EntityFrameworkCore.csproj reference ./$shared_common/$name.Shared.EfCore/$name.Shared.EfCore.csproj

	dotnet add ./$apps/$name/src/$name.Domain.Shared/$name.Domain.Shared.csproj package Newtonsoft.Json -v 13.0.1
	dotnet add ./$apps/$name/src/$name.Domain.Shared/$name.Domain.Shared.csproj package Volo.Abp.Guids -v $ver
	dotnet add ./$apps/$name/src/$name.Domain.Shared/$name.Domain.Shared.csproj package Volo.Abp.Ddd.Application.Contracts -v $ver	
	dotnet add ./$apps/$name/src/$name.EntityFrameworkCore/$name.EntityFrameworkCore.csproj package Npgsql.EntityFrameworkCore.PostgreSQL.NetTopologySuite -v 6.0.5
	
	Copy-Item -Path "./libs/Bamboo.Shared.Common/Extensions" -Destination ./$apps/$name/src/$name.Domain.Shared/ -recurse -Force
	Copy-Item -Path "./libs/Bamboo.Shared.Common/Guids" -Destination ./$apps/$name/src/$name.Domain.Shared/ -recurse -Force
	Copy-Item -Path "./libs/Bamboo.Shared.Common/Filter" -Destination ./$apps/$name/src/$name.Domain.Shared/ -recurse -Force
	Copy-Item -Path "./libs/Bamboo.Shared.Common/Utils" -Destination ./$apps/$name/src/$name.Domain.Shared/ -recurse -Force
	Copy-Item -Path "./libs/Bamboo.Shared.EfCore/Extensions" -Destination ./$apps/$name/src/$name.EntityFrameworkCore/ -recurse -Force
	
	dotnet sln "./$apps/$sln_account.sln" add (Get-ChildItem -r ./$apps/**/*.csproj)
	
	Move-Item -Path "./temp-sas/$name/src/$name.HttpApi.Host" -Destination ./$apps/$name/src/"$name.HttpApi.Sas.Host" -Force

	dotnet sln "./web_apps/$sln_webs.sln" add --solution-folder shared (Get-ChildItem -r ./$apps/$name/src/$name.Domain.Shared/$name.Domain.Shared.csproj)
	dotnet sln "./web_apps/$sln_webs.sln" add --solution-folder shared (Get-ChildItem -r ./$apps/$name/src/$name.Application.Contracts/$name.Application.Contracts.csproj)
	dotnet sln "./web_apps/$sln_webs.sln" add --solution-folder shared (Get-ChildItem -r ./$apps/$name/src/$name.HttpApi.Client/$name.HttpApi.Client.csproj)

	#dotnet sln "./web_apps/$sln_webs.sln" add (Get-ChildItem -r ./$apps/$name/src/$name.Domain/$name.Domain.csproj)
	#dotnet sln "./web_apps/$sln_webs.sln" add (Get-ChildItem -r ./$apps/$name/src/$name.Application/$name.Application.csproj)
	dotnet sln "./web_apps/$sln_webs.sln" add --solution-folder shared (Get-ChildItem -r ./$apps/$name/src/$name.HttpApi/$name.HttpApi.csproj)
	
	dotnet sln "./web_apps/$sln_webs.sln" add (Get-ChildItem -r ./web_apps/$name.Blazor/**/*.csproj)
	dotnet sln "./web_apps/$sln_webs.sln" add (Get-ChildItem -r ./web_apps/$name.Web/**/*.csproj)

	#dotnet add ./web_apps/$name.Blazor/$name.Blazor.csproj reference ./$apps/$name/src/$name.Domain.Shared/$name.Domain.Shared.csproj
	#dotnet add ./web_apps/$name.Blazor/$name.Blazor.csproj reference ./$apps/$name/src/$name.Application.Contracts/$name.Application.Contracts.csproj	
	dotnet add ./web_apps/$name.Blazor/$name.Blazor.csproj reference ./$apps/$name/src/$name.HttpApi.Client/$name.HttpApi.Client.csproj
	#dotnet add ./web_apps/$name.Web/$name.Web.csproj reference ./$apps/$name/src/$name.Domain.Shared/$name.Domain.Shared.csproj
	#dotnet add ./web_apps/$name.Web/$name.Web.csproj reference ./$apps/$name/src/$name.Application.Contracts/$name.Application.Contracts.csproj
	dotnet add ./web_apps/$name.Web/$name.Web.csproj reference ./$apps/$name/src/$name.HttpApi.Client/$name.HttpApi.Client.csproj
	dotnet add ./web_apps/$name.Web/$name.Web.csproj reference ./$apps/$name/src/$name.HttpApi/$name.HttpApi.csproj

	Remove-Item -Recurse -Force ./temp-sas/
	Remove-Item -Recurse -Force ./temp-blazor-server/
	Remove-Item -Recurse -Force ./temp-mvc/

	#cmd /c pause
	#dotnet sln "./$name.sln" remove (Get-ChildItem -r **/*.Installer.csproj)
	#dotnet sln "./$name.sln" remove (Get-ChildItem -r **/*.Host.Shared.csproj)
	#dotnet sln "./$name.sln" remove (Get-ChildItem -r **/*.MongoDB.csproj)
	#dotnet sln "./$name.sln" remove (Get-ChildItem -r **/*.MongoDB.Tests.csproj)
	#Remove-Item -Recurse -Force (Get-ChildItem -r **/*.MongoDB.Tests)
	#Remove-Item -Recurse -Force (Get-ChildItem -r **/*.MongoDB)
	#Remove-Item -Recurse -Force (Get-ChildItem -r **/*.Host.Shared)
	#Remove-Item -Recurse -Force (Get-ChildItem -r **/*.Installer)
}

function AdminServiceAddReference {
	# ADMINISTRATION SERVICES 
	## Domain.Shared
	$admin = "Administration"
	dotnet add services/administration/src/$name.$admin.Domain.Shared/$name.$admin.Domain.Shared.csproj package Volo.Abp.Identity.Domain.Shared -v $ver
	dotnet add services/administration/src/$name.$admin.Domain.Shared/$name.$admin.Domain.Shared.csproj package Volo.Abp.BackgroundJobs.Domain.Shared -v $ver
	dotnet add services/administration/src/$name.$admin.Domain.Shared/$name.$admin.Domain.Shared.csproj package Volo.Abp.AuditLogging.Domain.Shared -v $ver
	dotnet add services/administration/src/$name.$admin.Domain.Shared/$name.$admin.Domain.Shared.csproj package Volo.Abp.TenantManagement.Domain.Shared -v $ver
	dotnet add services/administration/src/$name.$admin.Domain.Shared/$name.$admin.Domain.Shared.csproj package Volo.Abp.FeatureManagement.Domain.Shared -v $ver
	dotnet add services/administration/src/$name.$admin.Domain.Shared/$name.$admin.Domain.Shared.csproj package Volo.Abp.PermissionManagement.Domain.Shared -v $ver
	dotnet add services/administration/src/$name.$admin.Domain.Shared/$name.$admin.Domain.Shared.csproj package Volo.Abp.SettingManagement.Domain.Shared -v $ver
	dotnet add services/administration/src/$name.$admin.Domain.Shared/$name.$admin.Domain.Shared.csproj package Volo.Abp.OpenIddict.Domain.Shared -v $ver
	## Domain
	dotnet add services/administration/src/$name.$admin.Domain/$name.$admin.Domain.csproj package Volo.Abp.Emailing -v $ver
	dotnet add services/administration/src/$name.$admin.Domain/$name.$admin.Domain.csproj package Volo.Abp.Identity.Domain -v $ver
	dotnet add services/administration/src/$name.$admin.Domain/$name.$admin.Domain.csproj package Volo.Abp.BackgroundJobs.Domain -v $ver
	dotnet add services/administration/src/$name.$admin.Domain/$name.$admin.Domain.csproj package Volo.Abp.AuditLogging.Domain -v $ver
	dotnet add services/administration/src/$name.$admin.Domain/$name.$admin.Domain.csproj package Volo.Abp.TenantManagement.Domain -v $ver
	dotnet add services/administration/src/$name.$admin.Domain/$name.$admin.Domain.csproj package Volo.Abp.FeatureManagement.Domain -v $ver
	dotnet add services/administration/src/$name.$admin.Domain/$name.$admin.Domain.csproj package Volo.Abp.SettingManagement.Domain -v $ver
	dotnet add services/administration/src/$name.$admin.Domain/$name.$admin.Domain.csproj package Volo.Abp.OpenIddict.Domain -v $ver
	dotnet add services/administration/src/$name.$admin.Domain/$name.$admin.Domain.csproj package Volo.Abp.PermissionManagement.Domain.Identity -v $ver
	dotnet add services/administration/src/$name.$admin.Domain/$name.$admin.Domain.csproj package Volo.Abp.PermissionManagement.Domain.OpenIddict -v $ver

	## Application.Contracts
	dotnet add services/administration/src/$name.$admin.Application.Contracts/$name.$admin.Application.Contracts.csproj package Volo.Abp.ObjectExtending -v $ver
	dotnet add services/administration/src/$name.$admin.Application.Contracts/$name.$admin.Application.Contracts.csproj package Volo.Abp.Account.Application.Contracts -v $ver
	dotnet add services/administration/src/$name.$admin.Application.Contracts/$name.$admin.Application.Contracts.csproj package Volo.Abp.Identity.Application.Contracts -v $ver
	dotnet add services/administration/src/$name.$admin.Application.Contracts/$name.$admin.Application.Contracts.csproj package Volo.Abp.PermissionManagement.Application.Contracts -v $ver
	dotnet add services/administration/src/$name.$admin.Application.Contracts/$name.$admin.Application.Contracts.csproj package Volo.Abp.TenantManagement.Application.Contracts -v $ver
	dotnet add services/administration/src/$name.$admin.Application.Contracts/$name.$admin.Application.Contracts.csproj package Volo.Abp.FeatureManagement.Application.Contracts -v $ver
	dotnet add services/administration/src/$name.$admin.Application.Contracts/$name.$admin.Application.Contracts.csproj package Volo.Abp.SettingManagement.Application.Contracts -v $ver

	## Application
	dotnet add services/administration/src/$name.$admin.Application/$name.$admin.Application.csproj package Volo.Abp.Account.Application -v $ver
	dotnet add services/administration/src/$name.$admin.Application/$name.$admin.Application.csproj package Volo.Abp.Identity.Application -v $ver
	dotnet add services/administration/src/$name.$admin.Application/$name.$admin.Application.csproj package Volo.Abp.PermissionManagement.Application -v $ver
	dotnet add services/administration/src/$name.$admin.Application/$name.$admin.Application.csproj package Volo.Abp.TenantManagement.Application -v $ver
	dotnet add services/administration/src/$name.$admin.Application/$name.$admin.Application.csproj package Volo.Abp.FeatureManagement.Application -v $ver
	dotnet add services/administration/src/$name.$admin.Application/$name.$admin.Application.csproj package Volo.Abp.SettingManagement.Application -v $ver

	## EntityFrameworkCore
	dotnet add services/administration/src/$name.$admin.EntityFrameworkCore/$name.$admin.EntityFrameworkCore.csproj package Volo.Abp.Identity.EntityFrameworkCore -v $ver
	dotnet add services/administration/src/$name.$admin.EntityFrameworkCore/$name.$admin.EntityFrameworkCore.csproj package Volo.Abp.PermissionManagement.EntityFrameworkCore -v $ver
	dotnet add services/administration/src/$name.$admin.EntityFrameworkCore/$name.$admin.EntityFrameworkCore.csproj package Volo.Abp.TenantManagement.EntityFrameworkCore -v $ver
	dotnet add services/administration/src/$name.$admin.EntityFrameworkCore/$name.$admin.EntityFrameworkCore.csproj package Volo.Abp.FeatureManagement.EntityFrameworkCore -v $ver
	dotnet add services/administration/src/$name.$admin.EntityFrameworkCore/$name.$admin.EntityFrameworkCore.csproj package Volo.Abp.SettingManagement.EntityFrameworkCore -v $ver
	dotnet add services/administration/src/$name.$admin.EntityFrameworkCore/$name.$admin.EntityFrameworkCore.csproj package Volo.Abp.OpenIddict.EntityFrameworkCore -v $ver
	dotnet add services/administration/src/$name.$admin.EntityFrameworkCore/$name.$admin.EntityFrameworkCore.csproj package Volo.Abp.AuditLogging.EntityFrameworkCore -v $ver
	dotnet add services/administration/src/$name.$admin.EntityFrameworkCore/$name.$admin.EntityFrameworkCore.csproj package Volo.Abp.BackgroundJobs.EntityFrameworkCore -v $ver
	dotnet add services/administration/src/$name.$admin.EntityFrameworkCore/$name.$admin.EntityFrameworkCore.csproj package Microsoft.EntityFrameworkCore.Tools -v "6.0.5"

	## HTTP API
	dotnet add services/administration/src/$name.$admin.HttpApi/$name.$admin.HttpApi.csproj package Volo.Abp.Account.HttpApi -v $ver
	dotnet add services/administration/src/$name.$admin.HttpApi/$name.$admin.HttpApi.csproj package Volo.Abp.Identity.HttpApi -v $ver
	dotnet add services/administration/src/$name.$admin.HttpApi/$name.$admin.HttpApi.csproj package Volo.Abp.PermissionManagement.HttpApi -v $ver
	dotnet add services/administration/src/$name.$admin.HttpApi/$name.$admin.HttpApi.csproj package Volo.Abp.TenantManagement.HttpApi -v $ver
	dotnet add services/administration/src/$name.$admin.HttpApi/$name.$admin.HttpApi.csproj package Volo.Abp.FeatureManagement.HttpApi -v $ver
	dotnet add services/administration/src/$name.$admin.HttpApi/$name.$admin.HttpApi.csproj package Volo.Abp.SettingManagement.HttpApi -v $ver

	## HTTP API
	dotnet add services/administration/src/$name.$admin.HttpApi.Client/$name.$admin.HttpApi.Client.csproj package Volo.Abp.Account.HttpApi.Client -v $ver
	dotnet add services/administration/src/$name.$admin.HttpApi.Client/$name.$admin.HttpApi.Client.csproj package Volo.Abp.Identity.HttpApi.Client -v $ver
	dotnet add services/administration/src/$name.$admin.HttpApi.Client/$name.$admin.HttpApi.Client.csproj package Volo.Abp.PermissionManagement.HttpApi.Client -v $ver
	dotnet add services/administration/src/$name.$admin.HttpApi.Client/$name.$admin.HttpApi.Client.csproj package Volo.Abp.TenantManagement.HttpApi.Client -v $ver
	dotnet add services/administration/src/$name.$admin.HttpApi.Client/$name.$admin.HttpApi.Client.csproj package Volo.Abp.FeatureManagement.HttpApi.Client -v $ver
	dotnet add services/administration/src/$name.$admin.HttpApi.Client/$name.$admin.HttpApi.Client.csproj package Volo.Abp.SettingManagement.HttpApi.Client -v $ver

	# FOR APPS
	#abp add-module Volo.AuditLogging -s "./apps/$name/$name.sln" --skip-db-migrations
	#abp add-module Volo.FeatureManagement -s "./apps/$name/$name.sln" --skip-db-migrations
	#abp add-module Volo.PermissionManagement -s "./apps/$name/$name.sln" --skip-db-migrations
	#abp add-module Volo.SettingManagement -s "./apps/$name/$name.sln" --skip-db-migrations
	#abp add-module Volo.Identity -s "./apps/$name/$name.sln" --skip-db-migrations
	#abp add-module Volo.OpenIddict -s "./apps/$name/$name.sln" --skip-db-migrations
	#abp add-module Volo.TenantManagement -s "./apps/$name/$name.sln" --skip-db-migrations
}

function AdminServiceAddSource {
	# SOURCE CODE
	abp add-module Volo.AuditLogging -s "services/administration/$name.$admin.sln" --skip-db-migrations
	abp add-module Volo.FeatureManagement -s "services/administration/$name.$admin.sln" --skip-db-migrations
	abp add-module Volo.PermissionManagement -s "services/administration/$name.$admin.sln" --skip-db-migrations
	abp add-module Volo.SettingManagement -s "services/administration/$name.$admin.sln" --skip-db-migrations
	abp add-module Volo.Identity -s "services/administration/$name.$admin.sln" --skip-db-migrations
	abp add-module Volo.OpenIddict -s "services/administration/$name.$admin.sln" --skip-db-migrations
	abp add-module Volo.TenantManagement -s "services/saas/$name.$admin.sln" --skip-db-migrations
}

CreateCoreLibs
CreateCoreApp
CreateCoreServices
#AdminServiceAddReference
CreateGateways

cmd /c pause
