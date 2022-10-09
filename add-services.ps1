$name = $args[0]

$abpver = "6.0.0"

$sln_service = "$name.Services.All"
$shared_common = "shared/common"

$services = @{}
$services.Add('Administration', 'administration')
$services.Add('Logging', 'logging')
$services.Add('Notification', 'notification')

#$services.Add('Base', 'base')
#$services.Add('CmsKit', 'cmskit')

function CmsKitAddReference {
	
}

function AdminServiceAddReference {
	# ADMINISTRATION SERVICES 
	## Domain.Shared
	$admin = "Administration"
	dotnet add services/administration/src/$name.$admin.Domain.Shared/$name.$admin.Domain.Shared.csproj package Volo.Abp.Identity.Domain.Shared -v $abpver
	dotnet add services/administration/src/$name.$admin.Domain.Shared/$name.$admin.Domain.Shared.csproj package Volo.Abp.BackgroundJobs.Domain.Shared -v $abpver
	dotnet add services/administration/src/$name.$admin.Domain.Shared/$name.$admin.Domain.Shared.csproj package Volo.Abp.AuditLogging.Domain.Shared -v $abpver
	dotnet add services/administration/src/$name.$admin.Domain.Shared/$name.$admin.Domain.Shared.csproj package Volo.Abp.TenantManagement.Domain.Shared -v $abpver
	dotnet add services/administration/src/$name.$admin.Domain.Shared/$name.$admin.Domain.Shared.csproj package Volo.Abp.FeatureManagement.Domain.Shared -v $abpver
	dotnet add services/administration/src/$name.$admin.Domain.Shared/$name.$admin.Domain.Shared.csproj package Volo.Abp.PermissionManagement.Domain.Shared -v $abpver
	dotnet add services/administration/src/$name.$admin.Domain.Shared/$name.$admin.Domain.Shared.csproj package Volo.Abp.SettingManagement.Domain.Shared -v $abpver
	dotnet add services/administration/src/$name.$admin.Domain.Shared/$name.$admin.Domain.Shared.csproj package Volo.Abp.OpenIddict.Domain.Shared -v $abpver
	## Domain
	dotnet add services/administration/src/$name.$admin.Domain/$name.$admin.Domain.csproj package Volo.Abp.Emailing -v $abpver
	dotnet add services/administration/src/$name.$admin.Domain/$name.$admin.Domain.csproj package Volo.Abp.Identity.Domain -v $abpver
	dotnet add services/administration/src/$name.$admin.Domain/$name.$admin.Domain.csproj package Volo.Abp.BackgroundJobs.Domain -v $abpver
	dotnet add services/administration/src/$name.$admin.Domain/$name.$admin.Domain.csproj package Volo.Abp.AuditLogging.Domain -v $abpver
	dotnet add services/administration/src/$name.$admin.Domain/$name.$admin.Domain.csproj package Volo.Abp.TenantManagement.Domain -v $abpver
	dotnet add services/administration/src/$name.$admin.Domain/$name.$admin.Domain.csproj package Volo.Abp.FeatureManagement.Domain -v $abpver
	dotnet add services/administration/src/$name.$admin.Domain/$name.$admin.Domain.csproj package Volo.Abp.SettingManagement.Domain -v $abpver
	dotnet add services/administration/src/$name.$admin.Domain/$name.$admin.Domain.csproj package Volo.Abp.OpenIddict.Domain -v $abpver
	dotnet add services/administration/src/$name.$admin.Domain/$name.$admin.Domain.csproj package Volo.Abp.PermissionManagement.Domain.Identity -v $abpver
	dotnet add services/administration/src/$name.$admin.Domain/$name.$admin.Domain.csproj package Volo.Abp.PermissionManagement.Domain.OpenIddict -v $abpver

	## Application.Contracts
	dotnet add services/administration/src/$name.$admin.Application.Contracts/$name.$admin.Application.Contracts.csproj package Volo.Abp.ObjectExtending -v $abpver
	dotnet add services/administration/src/$name.$admin.Application.Contracts/$name.$admin.Application.Contracts.csproj package Volo.Abp.Account.Application.Contracts -v $abpver
	dotnet add services/administration/src/$name.$admin.Application.Contracts/$name.$admin.Application.Contracts.csproj package Volo.Abp.Identity.Application.Contracts -v $abpver
	dotnet add services/administration/src/$name.$admin.Application.Contracts/$name.$admin.Application.Contracts.csproj package Volo.Abp.PermissionManagement.Application.Contracts -v $abpver
	dotnet add services/administration/src/$name.$admin.Application.Contracts/$name.$admin.Application.Contracts.csproj package Volo.Abp.TenantManagement.Application.Contracts -v $abpver
	dotnet add services/administration/src/$name.$admin.Application.Contracts/$name.$admin.Application.Contracts.csproj package Volo.Abp.FeatureManagement.Application.Contracts -v $abpver
	dotnet add services/administration/src/$name.$admin.Application.Contracts/$name.$admin.Application.Contracts.csproj package Volo.Abp.SettingManagement.Application.Contracts -v $abpver

	## Application
	dotnet add services/administration/src/$name.$admin.Application/$name.$admin.Application.csproj package Volo.Abp.Account.Application -v $abpver
	dotnet add services/administration/src/$name.$admin.Application/$name.$admin.Application.csproj package Volo.Abp.Identity.Application -v $abpver
	dotnet add services/administration/src/$name.$admin.Application/$name.$admin.Application.csproj package Volo.Abp.PermissionManagement.Application -v $abpver
	dotnet add services/administration/src/$name.$admin.Application/$name.$admin.Application.csproj package Volo.Abp.TenantManagement.Application -v $abpver
	dotnet add services/administration/src/$name.$admin.Application/$name.$admin.Application.csproj package Volo.Abp.FeatureManagement.Application -v $abpver
	dotnet add services/administration/src/$name.$admin.Application/$name.$admin.Application.csproj package Volo.Abp.SettingManagement.Application -v $abpver

	## EntityFrameworkCore
	dotnet add services/administration/src/$name.$admin.EntityFrameworkCore/$name.$admin.EntityFrameworkCore.csproj package Volo.Abp.Identity.EntityFrameworkCore -v $abpver
	dotnet add services/administration/src/$name.$admin.EntityFrameworkCore/$name.$admin.EntityFrameworkCore.csproj package Volo.Abp.PermissionManagement.EntityFrameworkCore -v $abpver
	dotnet add services/administration/src/$name.$admin.EntityFrameworkCore/$name.$admin.EntityFrameworkCore.csproj package Volo.Abp.TenantManagement.EntityFrameworkCore -v $abpver
	dotnet add services/administration/src/$name.$admin.EntityFrameworkCore/$name.$admin.EntityFrameworkCore.csproj package Volo.Abp.FeatureManagement.EntityFrameworkCore -v $abpver
	dotnet add services/administration/src/$name.$admin.EntityFrameworkCore/$name.$admin.EntityFrameworkCore.csproj package Volo.Abp.SettingManagement.EntityFrameworkCore -v $abpver
	dotnet add services/administration/src/$name.$admin.EntityFrameworkCore/$name.$admin.EntityFrameworkCore.csproj package Volo.Abp.OpenIddict.EntityFrameworkCore -v $abpver
	dotnet add services/administration/src/$name.$admin.EntityFrameworkCore/$name.$admin.EntityFrameworkCore.csproj package Volo.Abp.AuditLogging.EntityFrameworkCore -v $abpver
	dotnet add services/administration/src/$name.$admin.EntityFrameworkCore/$name.$admin.EntityFrameworkCore.csproj package Volo.Abp.BackgroundJobs.EntityFrameworkCore -v $abpver
	dotnet add services/administration/src/$name.$admin.EntityFrameworkCore/$name.$admin.EntityFrameworkCore.csproj package Microsoft.EntityFrameworkCore.Tools -v "6.0.5"

	## HTTP API
	dotnet add services/administration/src/$name.$admin.HttpApi/$name.$admin.HttpApi.csproj package Volo.Abp.Account.HttpApi -v $abpver
	dotnet add services/administration/src/$name.$admin.HttpApi/$name.$admin.HttpApi.csproj package Volo.Abp.Identity.HttpApi -v $abpver
	dotnet add services/administration/src/$name.$admin.HttpApi/$name.$admin.HttpApi.csproj package Volo.Abp.PermissionManagement.HttpApi -v $abpver
	dotnet add services/administration/src/$name.$admin.HttpApi/$name.$admin.HttpApi.csproj package Volo.Abp.TenantManagement.HttpApi -v $abpver
	dotnet add services/administration/src/$name.$admin.HttpApi/$name.$admin.HttpApi.csproj package Volo.Abp.FeatureManagement.HttpApi -v $abpver
	dotnet add services/administration/src/$name.$admin.HttpApi/$name.$admin.HttpApi.csproj package Volo.Abp.SettingManagement.HttpApi -v $abpver

	## HTTP API
	dotnet add services/administration/src/$name.$admin.HttpApi.Client/$name.$admin.HttpApi.Client.csproj package Volo.Abp.Account.HttpApi.Client -v $abpver
	dotnet add services/administration/src/$name.$admin.HttpApi.Client/$name.$admin.HttpApi.Client.csproj package Volo.Abp.Identity.HttpApi.Client -v $abpver
	dotnet add services/administration/src/$name.$admin.HttpApi.Client/$name.$admin.HttpApi.Client.csproj package Volo.Abp.PermissionManagement.HttpApi.Client -v $abpver
	dotnet add services/administration/src/$name.$admin.HttpApi.Client/$name.$admin.HttpApi.Client.csproj package Volo.Abp.TenantManagement.HttpApi.Client -v $abpver
	dotnet add services/administration/src/$name.$admin.HttpApi.Client/$name.$admin.HttpApi.Client.csproj package Volo.Abp.FeatureManagement.HttpApi.Client -v $abpver
	dotnet add services/administration/src/$name.$admin.HttpApi.Client/$name.$admin.HttpApi.Client.csproj package Volo.Abp.SettingManagement.HttpApi.Client -v $abpver

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


function CreateServices {
	foreach($service in $services.keys)
	{
		$folder = $services[$service]
		if (Test-Path -Path "./services/$folder") {
			"$service's path exists!"
			cmd /c pause
			continue
		}
		abp new "$name.$service" -t module --no-ui -o services/$folder --skip-installing-libs
		dotnet add ./services/$folder/host/"$name.$service".HttpApi.Host/"$name.$service".HttpApi.Host.csproj package Volo.Abp.EntityFrameworkCore.PostgreSql
		#dotnet remove ./services/$folder/host/"$name.$service".HttpApi.Host/"$name.$service".HttpApi.Host.csproj package Volo.Abp.EntityFrameworkCore.SqlServer
		
		dotnet add ./services/$folder/src/"$name.$service".Domain.Shared/"$name.$service".Domain.Shared.csproj reference ./$shared_common/$name.Shared.Common/$name.Shared.Common.csproj
		dotnet add ./services/$folder/src/"$name.$service".EntityFrameworkCore/"$name.$service".EntityFrameworkCore.csproj reference ./$shared_common/$name.Shared.EfCore/$name.Shared.EfCore.csproj
		dotnet add ./services/$folder/host/"$name.$service".HttpApi.Host/"$name.$service".HttpApi.Host.csproj reference ./$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj
		#dotnet add ./services/$folder/src/"$name.$service".Domain/"$name.$service".Domain.csproj reference ./$shared_common/$name.Shared.Domain/$name.Shared.Domain.csproj

		dotnet new console -n "$name.$service.DbMigrator" -o ./services/$folder/host/$name.$service.DbMigrator
		dotnet add ./services/$folder/host/$name.$service.DbMigrator/$name.$service.DbMigrator.csproj package Microsoft.Extensions.Hosting -v "6.0.1"
		dotnet add ./services/$folder/host/$name.$service.DbMigrator/$name.$service.DbMigrator.csproj package Serilog.Extensions.Logging -v "3.1.0"
		dotnet add ./services/$folder/host/$name.$service.DbMigrator/$name.$service.DbMigrator.csproj package Serilog.Sinks.Async -v "1.5.0"
		dotnet add ./services/$folder/host/$name.$service.DbMigrator/$name.$service.DbMigrator.csproj package Serilog.Sinks.File -v "5.0.0"
		dotnet add ./services/$folder/host/$name.$service.DbMigrator/$name.$service.DbMigrator.csproj package Serilog.Sinks.Console -v "4.0.1"	
		dotnet add ./services/$folder/host/$name.$service.DbMigrator/$name.$service.DbMigrator.csproj package Volo.Abp.Autofac -v $abpver	
		dotnet add ./services/$folder/host/$name.$service.DbMigrator/$name.$service.DbMigrator.csproj package Volo.Abp.BackgroundJobs -v $abpver
		dotnet add ./services/$folder/host/$name.$service.DbMigrator/$name.$service.DbMigrator.csproj package Volo.Abp.Identity.Domain -v $abpver
		dotnet add ./services/$folder/host/$name.$service.DbMigrator/$name.$service.DbMigrator.csproj package Volo.Abp.TenantManagement.Domain -v $abpver	
		dotnet add ./services/$folder/host/$name.$service.DbMigrator/$name.$service.DbMigrator.csproj reference ./services/$folder/src/$name.$service.Application.Contracts/$name.$service.Application.Contracts.csproj	
		dotnet add ./services/$folder/host/$name.$service.DbMigrator/$name.$service.DbMigrator.csproj reference ./services/$folder/src/$name.$service.EntityFrameworkCore/$name.$service.EntityFrameworkCore.csproj
		Copy-Item -Path "./libs/Bamboo.Shared.DbMigrator/*" -Destination ./services/$folder/host/$name.$service.DbMigrator/ -recurse -Force
		
		if ($service -ne 'Administration') {
			dotnet sln "./services/$folder/$name.$service.sln" remove (Get-ChildItem -r ./services/$folder/host/$name.$service.AuthServer/$name.$service.AuthServer.csproj)
		}
		#dotnet sln "./services/$folder/$name.$service.sln" remove (Get-ChildItem -r ./services/$folder/host/$name.$service.Host.Shared/$name.$service.Host.Shared.csproj)		
		dotnet sln "./services/$folder/$name.$service.sln" remove (Get-ChildItem -r ./services/$folder/src/$name.$service.Installer/$name.$service.Installer.csproj)
		dotnet sln "./services/$folder/$name.$service.sln" remove (Get-ChildItem -r ./services/$folder/src/$name.$service.MongoDB/$name.$service.MongoDB.csproj)
		dotnet sln "./services/$folder/$name.$service.sln" remove (Get-ChildItem -r ./services/$folder/test/$name.$service.MongoDB.Tests/$name.$service.MongoDB.Tests.csproj)
		
		if ($service -ne 'Administration') {
			Remove-Item -Recurse -Force (Get-ChildItem -r ./services/**/*.$service.AuthServer)		
		}
		#Remove-Item -Recurse -Force (Get-ChildItem -r **/*.$service.Host.Shared)
		Remove-Item -Recurse -Force (Get-ChildItem -r ./services/**/*.$service.Installer)
		Remove-Item -Recurse -Force (Get-ChildItem -r ./services/**/*.$service.MongoDB)
		Remove-Item -Recurse -Force (Get-ChildItem -r ./services/**/*.$service.MongoDB.Tests)

		dotnet sln "./services/$folder/$name.$service.sln" add --solution-folder shared (Get-ChildItem -r ./$shared_common/**/*.csproj)
		dotnet sln "./services/$folder/$name.$service.sln" add --solution-folder host ./services/$folder/host/$name.$service.DbMigrator/$name.$service.DbMigrator.csproj		
		dotnet sln "./services/$sln_service.sln" add (Get-ChildItem -r ./services/$folder/**/*.csproj)
		if ($service -eq 'Administration') {
			AdminServiceAddReference
		}
		if ($service -eq 'CmsKit') {
			CmsKitAddReference
		}
	}
}

CreateServices

cmd /c pause
