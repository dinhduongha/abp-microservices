$name = $args[0]

$abpver = "6.0.0"
$msver = "6.0.5"
$ntsver = "13.0.1"
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
	dotnet new sln -n "$sln_webs.Blazor" -o ./web_apps
	dotnet new sln -n "$sln_webs.BlazorServer" -o ./web_apps
	dotnet new sln -n "$sln_webs.MVC" -o ./web_apps

	dotnet new classlib -n "$name.Shared.Common" -o "./$shared_common/$name.Shared.Common" --framework netstandard2.0
	dotnet add ./$shared_common/$name.Shared.Common/$name.Shared.Common.csproj package Newtonsoft.Json -v $ntsver
	dotnet add ./$shared_common/$name.Shared.Common/$name.Shared.Common.csproj package Volo.Abp.Guids -v $abpver
	dotnet add ./$shared_common/$name.Shared.Common/$name.Shared.Common.csproj package Volo.Abp.Ddd.Application.Contracts -v $abpver
	
	dotnet new classlib -n "$name.Shared.EfCore" -o "$shared_common/$name.Shared.EfCore"
	# Un-comment line below to enable TopologySuite/GIS
    dotnet add ./$shared_common/$name.Shared.EfCore/$name.Shared.EfCore.csproj package Npgsql.EntityFrameworkCore.PostgreSQL.NetTopologySuite -v 6.0.5
	dotnet add ./$shared_common/$name.Shared.EfCore/$name.Shared.EfCore.csproj package Volo.Abp.EntityFrameworkCore -v $abpver
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
	dotnet add ./$shared_common/$name.Shared.Hosting/$name.Shared.Hosting.csproj package Volo.Abp.Autofac -v $abpver
	dotnet add ./$shared_common/$name.Shared.Hosting/$name.Shared.Hosting.csproj package Volo.Abp.Data -v $abpver
	Copy-Item -Path "./libs/Bamboo.Shared.Hosting/Hosting/*" -Destination ./$shared_common/$name.Shared.Hosting/ -recurse -Force

	dotnet new classlib -n "$name.Shared.AspNetCore" -o "./$shared_common/$name.Shared.AspNetCore"
	dotnet add ./$shared_common/$name.Shared.AspNetCore/$name.Shared.AspNetCore.csproj package Serilog.AspNetCore -v "4.1.0"
	dotnet add ./$shared_common/$name.Shared.AspNetCore/$name.Shared.AspNetCore.csproj package Volo.Abp.AspNetCore.Serilog -v $abpver
	dotnet add ./$shared_common/$name.Shared.AspNetCore/$name.Shared.AspNetCore.csproj package Volo.Abp.Swashbuckle -v $abpver
	dotnet add ./$shared_common/$name.Shared.AspNetCore/$name.Shared.AspNetCore.csproj reference ./$shared_common/$name.Shared.Hosting/$name.Shared.Hosting.csproj
	Copy-Item -Path "./libs/Bamboo.Shared.Hosting/AspNetCore/*" -Destination ./$shared_common/$name.Shared.AspNetCore/ -recurse -Force
	
	dotnet new classlib -n "$name.Shared.Microservices" -o "./$shared_common/$name.Shared.Microservices"
	dotnet add ./$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj package Microsoft.AspNetCore.DataProtection.StackExchangeRedis -v $msver
	dotnet add ./$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj package Microsoft.AspNetCore.Authentication.JwtBearer -v $msver
	dotnet add ./$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj package DistributedLock.Redis -v 1.0.1
	dotnet add ./$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj package Swashbuckle.AspNetCore -v 6.4.0
	
	dotnet add ./$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj package Volo.Abp.AspNetCore.MultiTenancy -v $abpver
	dotnet add ./$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj package Volo.Abp.EventBus.RabbitMQ -v $abpver
	dotnet add ./$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj package Volo.Abp.BackgroundJobs.RabbitMQ -v $abpver
	dotnet add ./$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj package Volo.Abp.Caching.StackExchangeRedis -v $abpver
	dotnet add ./$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj package Volo.Abp.DistributedLocking -v $abpver
	dotnet add ./$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj package Volo.Abp.MongoDB -v $abpver
	dotnet add ./$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj package Volo.Abp.EntityFrameworkCore -v $abpver
	dotnet add ./$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj reference ./$shared_common/$name.Shared.AspNetCore/$name.Shared.AspNetCore.csproj
	Copy-Item -Path "./libs/Bamboo.Shared.Hosting/Microservices/*" -Destination ./$shared_common/$name.Shared.Microservices/ -recurse -Force

	dotnet sln "./services/$sln_service.sln" add --solution-folder shared (Get-ChildItem -r ./$shared_common/**/*.csproj)
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

function CreateCoreApp  {

	## Blazor
	abp new "$name" -t app --no-random-port -u blazor -m none --database-provider ef -dbms PostgreSQL --create-solution-folder -o $apps --skip-installing-libs
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
	# dotnet add ./$apps/$name/src/$name.EntityFrameworkCore/$name.EntityFrameworkCore.csproj reference ./$shared_common/$name.Shared.EfCore/$name.Shared.EfCore.csproj

	dotnet add ./$apps/$name/src/$name.Domain.Shared/$name.Domain.Shared.csproj package Newtonsoft.Json -v $ntsver
	dotnet add ./$apps/$name/src/$name.Domain.Shared/$name.Domain.Shared.csproj package Volo.Abp.Guids -v $abpver
	dotnet add ./$apps/$name/src/$name.Domain.Shared/$name.Domain.Shared.csproj package Volo.Abp.Ddd.Application.Contracts -v $abpver	
	dotnet add ./$apps/$name/src/$name.EntityFrameworkCore/$name.EntityFrameworkCore.csproj package Npgsql.EntityFrameworkCore.PostgreSQL.NetTopologySuite -v 6.0.5
	
	Copy-Item -Path "./libs/Bamboo.Shared.Common/Extensions" -Destination ./$apps/$name/src/$name.Domain.Shared/ -recurse -Force
	Copy-Item -Path "./libs/Bamboo.Shared.Common/Guids" -Destination ./$apps/$name/src/$name.Domain.Shared/ -recurse -Force
	Copy-Item -Path "./libs/Bamboo.Shared.Common/Filter" -Destination ./$apps/$name/src/$name.Domain.Shared/ -recurse -Force
	Copy-Item -Path "./libs/Bamboo.Shared.Common/Utils" -Destination ./$apps/$name/src/$name.Domain.Shared/ -recurse -Force
	Copy-Item -Path "./libs/Bamboo.Shared.EfCore/Extensions" -Destination ./$apps/$name/src/$name.EntityFrameworkCore/ -recurse -Force
	
	dotnet sln "./$apps/$sln_account.sln" add (Get-ChildItem -r ./$apps/**/*.csproj)
	
	Move-Item -Path "./temp-sas/$name/src/$name.HttpApi.Host" -Destination ./$apps/$name/src/"$name.HttpApi.Sas.Host" -Force

	dotnet sln "./web_apps/$sln_webs.Blazor.sln" add --solution-folder shared (Get-ChildItem -r ./$apps/$name/src/$name.Domain.Shared/$name.Domain.Shared.csproj)
	dotnet sln "./web_apps/$sln_webs.Blazor.sln" add --solution-folder shared (Get-ChildItem -r ./$apps/$name/src/$name.Application.Contracts/$name.Application.Contracts.csproj)
	dotnet sln "./web_apps/$sln_webs.Blazor.sln" add --solution-folder shared (Get-ChildItem -r ./$apps/$name/src/$name.HttpApi.Client/$name.HttpApi.Client.csproj)
	
	dotnet sln "./web_apps/$sln_webs.BlazorServer.sln" add --solution-folder shared (Get-ChildItem -r ./$apps/$name/src/$name.Domain.Shared/$name.Domain.Shared.csproj)
	dotnet sln "./web_apps/$sln_webs.BlazorServer.sln" add --solution-folder shared (Get-ChildItem -r ./$apps/$name/src/$name.Application.Contracts/$name.Application.Contracts.csproj)
	dotnet sln "./web_apps/$sln_webs.BlazorServer.sln" add --solution-folder shared (Get-ChildItem -r ./$apps/$name/src/$name.HttpApi.Client/$name.HttpApi.Client.csproj)
	
	dotnet sln "./web_apps/$sln_webs.MVC.sln" add --solution-folder shared (Get-ChildItem -r ./$apps/$name/src/$name.Domain.Shared/$name.Domain.Shared.csproj)
	dotnet sln "./web_apps/$sln_webs.MVC.sln" add --solution-folder shared (Get-ChildItem -r ./$apps/$name/src/$name.Application.Contracts/$name.Application.Contracts.csproj)
	dotnet sln "./web_apps/$sln_webs.MVC.sln" add --solution-folder shared (Get-ChildItem -r ./$apps/$name/src/$name.HttpApi.Client/$name.HttpApi.Client.csproj)
	
	#dotnet sln "./web_apps/$sln_webs.sln" add (Get-ChildItem -r ./$apps/$name/src/$name.Domain/$name.Domain.csproj)
	#dotnet sln "./web_apps/$sln_webs.sln" add (Get-ChildItem -r ./$apps/$name/src/$name.Application/$name.Application.csproj)
	dotnet sln "./web_apps/$sln_webs.MVC.sln" add --solution-folder shared (Get-ChildItem -r ./$apps/$name/src/$name.HttpApi/$name.HttpApi.csproj)
	
	dotnet sln "./web_apps/$sln_webs.Blazor.sln" add (Get-ChildItem -r ./web_apps/$name.Blazor/**/*.csproj)
	dotnet sln "./web_apps/$sln_webs.BlazorServer.sln" add (Get-ChildItem -r ./web_apps/$name.BlazorServer/**/*.csproj)	
	dotnet sln "./web_apps/$sln_webs.MVC.sln" add (Get-ChildItem -r ./web_apps/$name.Web/**/*.csproj)

	dotnet add ./web_apps/$name.Blazor/$name.Blazor.csproj reference ./$apps/$name/src/$name.HttpApi.Client/$name.HttpApi.Client.csproj
	
	dotnet add ./web_apps/$name.BlazorServer/$name.Blazor.csproj reference ./$apps/$name/src/$name.HttpApi.Client/$name.HttpApi.Client.csproj
	
	dotnet add ./web_apps/$name.Web/$name.Web.csproj reference ./$apps/$name/src/$name.HttpApi.Client/$name.HttpApi.Client.csproj
	dotnet add ./web_apps/$name.Web/$name.Web.csproj reference ./$apps/$name/src/$name.HttpApi/$name.HttpApi.csproj
	
	## Un-comment to use Newtonsoft.Json and Volo.Abp.Guids at client side
	#dotnet add ./web_apps/$name.Blazor/$name.Blazor.csproj package Newtonsoft.Json -v $ntsver
	#dotnet add ./web_apps/$name.Blazor/$name.Blazor.csproj package Volo.Abp.Guids -v $abpver
	#dotnet add ./web_apps/$name.BlazorServer/$name.Blazor.csproj package Newtonsoft.Json -v $ntsver
	#dotnet add ./web_apps/$name.BlazorServer/$name.Blazor.csproj package Volo.Abp.Guids -v $abpver
	#dotnet add ./web_apps/$name.Web/$name.Web.csproj reference Newtonsoft.Json -v $ntsver
	#dotnet add ./web_apps/$name.Web/$name.Web.csproj reference Volo.Abp.Guids -v $abpver

	#dotnet add ./web_apps/$name.Blazor/$name.Blazor.csproj reference ./$shared_common/$name.Shared.Common/$name.Shared.Common.csproj
	#dotnet add ./web_apps/$name.BlazorServer/$name.Blazor.csproj reference ./$shared_common/$name.Shared.Common/$name.Shared.Common.csproj
	#dotnet add ./web_apps/$name.Web/$name.Web.csproj reference ./$shared_common/$name.Shared.Common/$name.Shared.Common.csproj
	#dotnet sln "./web_apps/$sln_webs.Blazor.sln" add --solution-folder shared ./$shared_common/$name.Shared.Common/$name.Shared.Common.csproj
	#dotnet sln "./web_apps/$sln_webs.BlazorServer.sln" add --solution-folder shared ./$shared_common/$name.Shared.Common/$name.Shared.Common.csproj
	#dotnet sln "./web_apps/$sln_webs.MVC.sln" add --solution-folder shared ./$shared_common/$name.Shared.Common/$name.Shared.Common.csproj
	
	## ATTENTION: Remember to REMOVE un-use reference in Web projects
	
	Remove-Item -Recurse -Force ./temp-sas/
	Remove-Item -Recurse -Force ./temp-blazor-server/
	Remove-Item -Recurse -Force ./temp-mvc/

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
CreateCoreApp
CreateGateways

cmd /c pause
