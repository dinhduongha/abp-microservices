$name = $args[0]
$name = "Bamboo"
$abpver = "7.1.0"

$sln_service = "$name.Services.All"
$shared_common = "$name/shared/common"
$use_share = "True"
$ui_enable = "True"
$admin_name = "Admin"

$services = @{}
$services.Add('Admin', 'admin')
#$services.Add('Base', 'base')
$services.Add('Core', 'core')
#$services.Add('Crm', 'crm')
#$services.Add('Sales', 'sales')
#$services.Add('Pos', 'pos')
#$services.Add('Shop', 'shop')
#$services.Add('Inventory', 'inventory')
#$services.Add('Purchase', 'purchase')
#$services.Add('Repairs', 'repairs')
#$services.Add('Barcode', 'barcode')
#$services.Add('Accounting', 'account')
#$services.Add('Invoice', 'invoice')
#$services.Add('Payment', 'payment')
#$services.Add('Hr', 'hr')
#$services.Add('Mrp', 'mrp')
#$services.Add('Administration', 'administration')
#$services.Add('Logging', 'logging')
#$services.Add('Notification', 'notification')
#$services.Add('CmsService', 'cmskit')

function CmsKitAddReference {
	# CmsService SERVICES 
	## Domain.Shared
	if ($use_share -eq "True") {
		$shared_folder = "./$name/shared/$folder"
	} else {
		$shared_folder = "./$name/services/$folder/src"		
	}
	$admin = "CmsService"
	
	#dotnet add $shared_folder/$name.$admin.Domain.Shared/$name.$admin.Domain.Shared.csproj package Volo.Abp.Identity.Domain.Shared -v $abpver
	#dotnet add $shared_folder/$name.$admin.Domain.Shared/$name.$admin.Domain.Shared.csproj package Volo.Abp.BackgroundJobs.Domain.Shared -v $abpver
	#dotnet add $shared_folder/$name.$admin.Domain.Shared/$name.$admin.Domain.Shared.csproj package Volo.Abp.AuditLogging.Domain.Shared -v $abpver
	#dotnet add $shared_folder/$name.$admin.Domain.Shared/$name.$admin.Domain.Shared.csproj package Volo.Abp.TenantManagement.Domain.Shared -v $abpver
	#dotnet add $shared_folder/$name.$admin.Domain.Shared/$name.$admin.Domain.Shared.csproj package Volo.Abp.FeatureManagement.Domain.Shared -v $abpver
	#dotnet add $shared_folder/$name.$admin.Domain.Shared/$name.$admin.Domain.Shared.csproj package Volo.Abp.SettingManagement.Domain.Shared -v $abpver
	#dotnet add $shared_folder/$name.$admin.Domain.Shared/$name.$admin.Domain.Shared.csproj package Volo.Abp.OpenIddict.Domain.Shared -v $abpver
	#dotnet add $shared_folder/$name.$admin.Domain.Shared/$name.$admin.Domain.Shared.csproj package Volo.Abp.PermissionManagement.Domain.Shared -v $abpver
	dotnet add $shared_folder/$name.$admin.Domain.Shared/$name.$admin.Domain.Shared.csproj package Volo.CmsKit.Domain.Shared -v $abpver
	
	## Domain
	#dotnet add $name/services/$folder/src/$name.$admin.Domain/$name.$admin.Domain.csproj package Volo.Abp.Emailing -v $abpver
	#dotnet add $name/services/$folder/src/$name.$admin.Domain/$name.$admin.Domain.csproj package Volo.Abp.Identity.Domain -v $abpver
	#dotnet add $name/services/$folder/src/$name.$admin.Domain/$name.$admin.Domain.csproj package Volo.Abp.OpenIddict.Domain -v $abpver
	#dotnet add $name/services/$folder/src/$name.$admin.Domain/$name.$admin.Domain.csproj package Volo.Abp.BackgroundJobs.Domain -v $abpver
	#dotnet add $name/services/$folder/src/$name.$admin.Domain/$name.$admin.Domain.csproj package Volo.Abp.AuditLogging.Domain -v $abpver
	#dotnet add $name/services/$folder/src/$name.$admin.Domain/$name.$admin.Domain.csproj package Volo.Abp.TenantManagement.Domain -v $abpver
	#dotnet add $name/services/$folder/src/$name.$admin.Domain/$name.$admin.Domain.csproj package Volo.Abp.FeatureManagement.Domain -v $abpver
	#dotnet add $name/services/$folder/src/$name.$admin.Domain/$name.$admin.Domain.csproj package Volo.Abp.SettingManagement.Domain -v $abpver
	#dotnet add $name/services/$folder/src/$name.$admin.Domain/$name.$admin.Domain.csproj package Volo.Abp.PermissionManagement.Domain.Identity -v $abpver
	#dotnet add $name/services/$folder/src/$name.$admin.Domain/$name.$admin.Domain.csproj package Volo.Abp.PermissionManagement.Domain.OpenIddict -v $abpver
	dotnet add $name/services/$folder/src/$name.$admin.Domain/$name.$admin.Domain.csproj package Volo.CmsKit.Domain -v $abpver

	## Application.Contracts
	#dotnet add $shared_folder/$name.$admin.Application.Contracts/$name.$admin.Application.Contracts.csproj package Volo.Abp.ObjectExtending -v $abpver
	#dotnet add $shared_folder/$name.$admin.Application.Contracts/$name.$admin.Application.Contracts.csproj package Volo.Abp.Ddd.Application.Contracts -v $abpver
	#dotnet add $shared_folder/$name.$admin.Application.Contracts/$name.$admin.Application.Contracts.csproj package Volo.Abp.Account.Application.Contracts -v $abpver
	#dotnet add $shared_folder/$name.$admin.Application.Contracts/$name.$admin.Application.Contracts.csproj package Volo.Abp.Identity.Application.Contracts -v $abpver
	#dotnet add $shared_folder/$name.$admin.Application.Contracts/$name.$admin.Application.Contracts.csproj package Volo.Abp.TenantManagement.Application.Contracts -v $abpver
	#dotnet add $shared_folder/$name.$admin.Application.Contracts/$name.$admin.Application.Contracts.csproj package Volo.Abp.FeatureManagement.Application.Contracts -v $abpver
	#dotnet add $shared_folder/$name.$admin.Application.Contracts/$name.$admin.Application.Contracts.csproj package Volo.Abp.SettingManagement.Application.Contracts -v $abpver
	#dotnet add $shared_folder/$name.$admin.Application.Contracts/$name.$admin.Application.Contracts.csproj package Volo.Abp.PermissionManagement.Application.Contracts -v $abpver
	dotnet add $shared_folder/$name.$admin.Application.Contracts/$name.$admin.Application.Contracts.csproj package Volo.CmsKit.Application.Contracts -v $abpver
	
	## Application
	#dotnet add $name/services/$folder/src/$name.$admin.Application/$name.$admin.Application.csproj package Volo.Abp.Account.Application -v $abpver
	#dotnet add $name/services/$folder/src/$name.$admin.Application/$name.$admin.Application.csproj package Volo.Abp.Identity.Application -v $abpver
	#dotnet add $name/services/$folder/src/$name.$admin.Application/$name.$admin.Application.csproj package Volo.Abp.TenantManagement.Application -v $abpver
	#dotnet add $name/services/$folder/src/$name.$admin.Application/$name.$admin.Application.csproj package Volo.Abp.FeatureManagement.Application -v $abpver
	#dotnet add $name/services/$folder/src/$name.$admin.Application/$name.$admin.Application.csproj package Volo.Abp.SettingManagement.Application -v $abpver
	#dotnet add $name/services/$folder/src/$name.$admin.Application/$name.$admin.Application.csproj package Volo.Abp.PermissionManagement.Application -v $abpver
	dotnet add $name/services/$folder/src/$name.$admin.Application/$name.$admin.Application.csproj package Volo.CmsKit.Application -v $abpver
	
	## EntityFrameworkCore
	#dotnet add $name/services/$folder/src/$name.$admin.EntityFrameworkCore/$name.$admin.EntityFrameworkCore.csproj package Volo.Abp.Identity.EntityFrameworkCore -v $abpver
	#dotnet add $name/services/$folder/src/$name.$admin.EntityFrameworkCore/$name.$admin.EntityFrameworkCore.csproj package Volo.Abp.OpenIddict.EntityFrameworkCore -v $abpver
	#dotnet add $name/services/$folder/src/$name.$admin.EntityFrameworkCore/$name.$admin.EntityFrameworkCore.csproj package Volo.Abp.TenantManagement.EntityFrameworkCore -v $abpver
	#dotnet add $name/services/$folder/src/$name.$admin.EntityFrameworkCore/$name.$admin.EntityFrameworkCore.csproj package Volo.Abp.PermissionManagement.EntityFrameworkCore -v $abpver
	#dotnet add $name/services/$folder/src/$name.$admin.EntityFrameworkCore/$name.$admin.EntityFrameworkCore.csproj package Volo.Abp.FeatureManagement.EntityFrameworkCore -v $abpver
	#dotnet add $name/services/$folder/src/$name.$admin.EntityFrameworkCore/$name.$admin.EntityFrameworkCore.csproj package Volo.Abp.SettingManagement.EntityFrameworkCore -v $abpver
	#dotnet add $name/services/$folder/src/$name.$admin.EntityFrameworkCore/$name.$admin.EntityFrameworkCore.csproj package Volo.Abp.AuditLogging.EntityFrameworkCore -v $abpver
	#dotnet add $name/services/$folder/src/$name.$admin.EntityFrameworkCore/$name.$admin.EntityFrameworkCore.csproj package Volo.Abp.BackgroundJobs.EntityFrameworkCore -v $abpver
	#dotnet add $name/services/$folder/src/$name.$admin.EntityFrameworkCore/$name.$admin.EntityFrameworkCore.csproj package Microsoft.EntityFrameworkCore.Tools #-v "6.0.5"
	dotnet add $name/services/$folder/src/$name.$admin.EntityFrameworkCore/$name.$admin.EntityFrameworkCore.csproj package Volo.CmsKit.EntityFrameworkCore -v $abpver

	## HTTP API
	#dotnet add $name/services/$folder/src/$name.$admin.HttpApi/$name.$admin.HttpApi.csproj package Volo.Abp.Account.HttpApi -v $abpver
	#dotnet add $name/services/$folder/src/$name.$admin.HttpApi/$name.$admin.HttpApi.csproj package Volo.Abp.Identity.HttpApi -v $abpver
	#dotnet add $name/services/$folder/src/$name.$admin.HttpApi/$name.$admin.HttpApi.csproj package Volo.Abp.TenantManagement.HttpApi -v $abpver
	#dotnet add $name/services/$folder/src/$name.$admin.HttpApi/$name.$admin.HttpApi.csproj package Volo.Abp.PermissionManagement.HttpApi -v $abpver
	#dotnet add $name/services/$folder/src/$name.$admin.HttpApi/$name.$admin.HttpApi.csproj package Volo.Abp.FeatureManagement.HttpApi -v $abpver
	#dotnet add $name/services/$folder/src/$name.$admin.HttpApi/$name.$admin.HttpApi.csproj package Volo.Abp.SettingManagement.HttpApi -v $abpver
	dotnet add $name/services/$folder/src/$name.$admin.HttpApi/$name.$admin.HttpApi.csproj package Volo.CmsKit.HttpApi -v $abpver

	## HTTP API CLIENT
	#dotnet add $shared_folder/$name.$admin.HttpApi.Client/$name.$admin.HttpApi.Client.csproj package Volo.Abp.Account.HttpApi.Client -v $abpver
	#dotnet add $shared_folder/$name.$admin.HttpApi.Client/$name.$admin.HttpApi.Client.csproj package Volo.Abp.Identity.HttpApi.Client -v $abpver
	#dotnet add $shared_folder/$name.$admin.HttpApi.Client/$name.$admin.HttpApi.Client.csproj package Volo.Abp.TenantManagement.HttpApi.Client -v $abpver	
	#dotnet add $shared_folder/$name.$admin.HttpApi.Client/$name.$admin.HttpApi.Client.csproj package Volo.Abp.PermissionManagement.HttpApi.Client -v $abpver
	#dotnet add $shared_folder/$name.$admin.HttpApi.Client/$name.$admin.HttpApi.Client.csproj package Volo.Abp.FeatureManagement.HttpApi.Client -v $abpver
	#dotnet add $shared_folder/$name.$admin.HttpApi.Client/$name.$admin.HttpApi.Client.csproj package Volo.Abp.SettingManagement.HttpApi.Client -v $abpver
	dotnet add $shared_folder/$name.$admin.HttpApi.Client/$name.$admin.HttpApi.Client.csproj package Volo.CmsKit.HttpApi.Client -v $abpver
}

function AccountServiceAddReference {
	# ADMINISTRATION SERVICES 
	if ($use_share -eq "True") {
		$shared_folder = "./$name/shared/$folder"
	} else {
		$shared_folder = "./$name/services/$folder/src"		
	}
	$admin = $admin_name
	
	dotnet add $shared_folder/$name.$admin.Domain.Shared/$name.$admin.Domain.Shared.csproj package Volo.Abp.Identity.Domain.Shared -v $abpver
	dotnet add $shared_folder/$name.$admin.Domain.Shared/$name.$admin.Domain.Shared.csproj package Volo.Abp.BackgroundJobs.Domain.Shared -v $abpver
	dotnet add $shared_folder/$name.$admin.Domain.Shared/$name.$admin.Domain.Shared.csproj package Volo.Abp.AuditLogging.Domain.Shared -v $abpver
	dotnet add $shared_folder/$name.$admin.Domain.Shared/$name.$admin.Domain.Shared.csproj package Volo.Abp.TenantManagement.Domain.Shared -v $abpver
	dotnet add $shared_folder/$name.$admin.Domain.Shared/$name.$admin.Domain.Shared.csproj package Volo.Abp.FeatureManagement.Domain.Shared -v $abpver
	dotnet add $shared_folder/$name.$admin.Domain.Shared/$name.$admin.Domain.Shared.csproj package Volo.Abp.SettingManagement.Domain.Shared -v $abpver
	dotnet add $shared_folder/$name.$admin.Domain.Shared/$name.$admin.Domain.Shared.csproj package Volo.Abp.OpenIddict.Domain.Shared -v $abpver
	dotnet add $shared_folder/$name.$admin.Domain.Shared/$name.$admin.Domain.Shared.csproj package Volo.Abp.PermissionManagement.Domain.Shared -v $abpver
	
	## Domain
	dotnet add $name/services/$folder/src/$name.$admin.Domain/$name.$admin.Domain.csproj package Volo.Abp.Emailing -v $abpver
	dotnet add $name/services/$folder/src/$name.$admin.Domain/$name.$admin.Domain.csproj package Volo.Abp.Identity.Domain -v $abpver
	dotnet add $name/services/$folder/src/$name.$admin.Domain/$name.$admin.Domain.csproj package Volo.Abp.BackgroundJobs.Domain -v $abpver
	dotnet add $name/services/$folder/src/$name.$admin.Domain/$name.$admin.Domain.csproj package Volo.Abp.AuditLogging.Domain -v $abpver
	dotnet add $name/services/$folder/src/$name.$admin.Domain/$name.$admin.Domain.csproj package Volo.Abp.TenantManagement.Domain -v $abpver
	dotnet add $name/services/$folder/src/$name.$admin.Domain/$name.$admin.Domain.csproj package Volo.Abp.FeatureManagement.Domain -v $abpver
	dotnet add $name/services/$folder/src/$name.$admin.Domain/$name.$admin.Domain.csproj package Volo.Abp.SettingManagement.Domain -v $abpver
	dotnet add $name/services/$folder/src/$name.$admin.Domain/$name.$admin.Domain.csproj package Volo.Abp.OpenIddict.Domain -v $abpver
	dotnet add $name/services/$folder/src/$name.$admin.Domain/$name.$admin.Domain.csproj package Volo.Abp.PermissionManagement.Domain.Identity -v $abpver
	dotnet add $name/services/$folder/src/$name.$admin.Domain/$name.$admin.Domain.csproj package Volo.Abp.PermissionManagement.Domain.OpenIddict -v $abpver

	## Application.Contracts
	#dotnet add $shared_folder/$name.$admin.Application.Contracts/$name.$admin.Application.Contracts.csproj package Volo.Abp.ObjectExtending -v $abpver
	dotnet add $shared_folder/$name.$admin.Application.Contracts/$name.$admin.Application.Contracts.csproj package Volo.Abp.Ddd.Application.Contracts -v $abpver
	dotnet add $shared_folder/$name.$admin.Application.Contracts/$name.$admin.Application.Contracts.csproj package Volo.Abp.Account.Application.Contracts -v $abpver
	dotnet add $shared_folder/$name.$admin.Application.Contracts/$name.$admin.Application.Contracts.csproj package Volo.Abp.Identity.Application.Contracts -v $abpver
	dotnet add $shared_folder/$name.$admin.Application.Contracts/$name.$admin.Application.Contracts.csproj package Volo.Abp.TenantManagement.Application.Contracts -v $abpver
	dotnet add $shared_folder/$name.$admin.Application.Contracts/$name.$admin.Application.Contracts.csproj package Volo.Abp.FeatureManagement.Application.Contracts -v $abpver
	dotnet add $shared_folder/$name.$admin.Application.Contracts/$name.$admin.Application.Contracts.csproj package Volo.Abp.SettingManagement.Application.Contracts -v $abpver
	dotnet add $shared_folder/$name.$admin.Application.Contracts/$name.$admin.Application.Contracts.csproj package Volo.Abp.PermissionManagement.Application.Contracts -v $abpver
	
	## Application
	dotnet add $name/services/$folder/src/$name.$admin.Application/$name.$admin.Application.csproj package Volo.Abp.Account.Application -v $abpver
	dotnet add $name/services/$folder/src/$name.$admin.Application/$name.$admin.Application.csproj package Volo.Abp.Identity.Application -v $abpver
	dotnet add $name/services/$folder/src/$name.$admin.Application/$name.$admin.Application.csproj package Volo.Abp.TenantManagement.Application -v $abpver
	dotnet add $name/services/$folder/src/$name.$admin.Application/$name.$admin.Application.csproj package Volo.Abp.FeatureManagement.Application -v $abpver
	dotnet add $name/services/$folder/src/$name.$admin.Application/$name.$admin.Application.csproj package Volo.Abp.SettingManagement.Application -v $abpver
	dotnet add $name/services/$folder/src/$name.$admin.Application/$name.$admin.Application.csproj package Volo.Abp.PermissionManagement.Application -v $abpver
	
	## EntityFrameworkCore
	dotnet add $name/services/$folder/src/$name.$admin.EntityFrameworkCore/$name.$admin.EntityFrameworkCore.csproj package Volo.Abp.Identity.EntityFrameworkCore -v $abpver
	dotnet add $name/services/$folder/src/$name.$admin.EntityFrameworkCore/$name.$admin.EntityFrameworkCore.csproj package Volo.Abp.PermissionManagement.EntityFrameworkCore -v $abpver
	dotnet add $name/services/$folder/src/$name.$admin.EntityFrameworkCore/$name.$admin.EntityFrameworkCore.csproj package Volo.Abp.TenantManagement.EntityFrameworkCore -v $abpver
	dotnet add $name/services/$folder/src/$name.$admin.EntityFrameworkCore/$name.$admin.EntityFrameworkCore.csproj package Volo.Abp.FeatureManagement.EntityFrameworkCore -v $abpver
	dotnet add $name/services/$folder/src/$name.$admin.EntityFrameworkCore/$name.$admin.EntityFrameworkCore.csproj package Volo.Abp.SettingManagement.EntityFrameworkCore -v $abpver
	dotnet add $name/services/$folder/src/$name.$admin.EntityFrameworkCore/$name.$admin.EntityFrameworkCore.csproj package Volo.Abp.OpenIddict.EntityFrameworkCore -v $abpver
	dotnet add $name/services/$folder/src/$name.$admin.EntityFrameworkCore/$name.$admin.EntityFrameworkCore.csproj package Volo.Abp.AuditLogging.EntityFrameworkCore -v $abpver
	dotnet add $name/services/$folder/src/$name.$admin.EntityFrameworkCore/$name.$admin.EntityFrameworkCore.csproj package Volo.Abp.BackgroundJobs.EntityFrameworkCore -v $abpver
	dotnet add $name/services/$folder/src/$name.$admin.EntityFrameworkCore/$name.$admin.EntityFrameworkCore.csproj package Volo.Abp.EntityFrameworkCore.PostgreSql -v $abpver
	dotnet add $name/services/$folder/src/$name.$admin.EntityFrameworkCore/$name.$admin.EntityFrameworkCore.csproj package Microsoft.EntityFrameworkCore.Tools -v "7.0.1"

	## HTTP API
	dotnet add $name/services/$folder/src/$name.$admin.HttpApi/$name.$admin.HttpApi.csproj package Volo.Abp.Account.HttpApi -v $abpver
	dotnet add $name/services/$folder/src/$name.$admin.HttpApi/$name.$admin.HttpApi.csproj package Volo.Abp.Identity.HttpApi -v $abpver
	dotnet add $name/services/$folder/src/$name.$admin.HttpApi/$name.$admin.HttpApi.csproj package Volo.Abp.PermissionManagement.HttpApi -v $abpver
	dotnet add $name/services/$folder/src/$name.$admin.HttpApi/$name.$admin.HttpApi.csproj package Volo.Abp.TenantManagement.HttpApi -v $abpver
	dotnet add $name/services/$folder/src/$name.$admin.HttpApi/$name.$admin.HttpApi.csproj package Volo.Abp.FeatureManagement.HttpApi -v $abpver
	dotnet add $name/services/$folder/src/$name.$admin.HttpApi/$name.$admin.HttpApi.csproj package Volo.Abp.SettingManagement.HttpApi -v $abpver
	dotnet add $name/services/$folder/src/$name.$admin.HttpApi/$name.$admin.HttpApi.csproj package Volo.Abp.OpenIddict.AspNetCore -v $abpver

	## HTTP API CLIENT
	dotnet add $shared_folder/$name.$admin.HttpApi.Client/$name.$admin.HttpApi.Client.csproj package Volo.Abp.Account.HttpApi.Client -v $abpver
	dotnet add $shared_folder/$name.$admin.HttpApi.Client/$name.$admin.HttpApi.Client.csproj package Volo.Abp.Identity.HttpApi.Client -v $abpver
	dotnet add $shared_folder/$name.$admin.HttpApi.Client/$name.$admin.HttpApi.Client.csproj package Volo.Abp.PermissionManagement.HttpApi.Client -v $abpver
	dotnet add $shared_folder/$name.$admin.HttpApi.Client/$name.$admin.HttpApi.Client.csproj package Volo.Abp.TenantManagement.HttpApi.Client -v $abpver
	dotnet add $shared_folder/$name.$admin.HttpApi.Client/$name.$admin.HttpApi.Client.csproj package Volo.Abp.FeatureManagement.HttpApi.Client -v $abpver
	dotnet add $shared_folder/$name.$admin.HttpApi.Client/$name.$admin.HttpApi.Client.csproj package Volo.Abp.SettingManagement.HttpApi.Client -v $abpver
}

function AdminServiceAddReference {
	# ADMINISTRATION SERVICES 
	## Domain.Shared
	if ($use_share -eq "True") {
		$shared_folder = "./$name/shared/$folder"
	} else {
		$shared_folder = "./$name/services/$folder/src"		
	}
	$admin = "Administration"
	
	#dotnet add $shared_folder/$name.$admin.Domain.Shared/$name.$admin.Domain.Shared.csproj package Volo.Abp.Identity.Domain.Shared -v $abpver
	#dotnet add $shared_folder/$name.$admin.Domain.Shared/$name.$admin.Domain.Shared.csproj package Volo.Abp.BackgroundJobs.Domain.Shared -v $abpver
	#dotnet add $shared_folder/$name.$admin.Domain.Shared/$name.$admin.Domain.Shared.csproj package Volo.Abp.AuditLogging.Domain.Shared -v $abpver
	#dotnet add $shared_folder/$name.$admin.Domain.Shared/$name.$admin.Domain.Shared.csproj package Volo.Abp.TenantManagement.Domain.Shared -v $abpver
	dotnet add $shared_folder/$name.$admin.Domain.Shared/$name.$admin.Domain.Shared.csproj package Volo.Abp.FeatureManagement.Domain.Shared -v $abpver
	dotnet add $shared_folder/$name.$admin.Domain.Shared/$name.$admin.Domain.Shared.csproj package Volo.Abp.SettingManagement.Domain.Shared -v $abpver
	#dotnet add $shared_folder/$name.$admin.Domain.Shared/$name.$admin.Domain.Shared.csproj package Volo.Abp.OpenIddict.Domain.Shared -v $abpver
	dotnet add $shared_folder/$name.$admin.Domain.Shared/$name.$admin.Domain.Shared.csproj package Volo.Abp.PermissionManagement.Domain.Shared -v $abpver
	
	## Domain
	dotnet add $name/services/$folder/src/$name.$admin.Domain/$name.$admin.Domain.csproj package Volo.Abp.Emailing -v $abpver
	#dotnet add $name/services/$folder/src/$name.$admin.Domain/$name.$admin.Domain.csproj package Volo.Abp.Identity.Domain -v $abpver
	#dotnet add $name/services/$folder/src/$name.$admin.Domain/$name.$admin.Domain.csproj package Volo.Abp.OpenIddict.Domain -v $abpver
	#dotnet add $name/services/$folder/src/$name.$admin.Domain/$name.$admin.Domain.csproj package Volo.Abp.BackgroundJobs.Domain -v $abpver
	#dotnet add $name/services/$folder/src/$name.$admin.Domain/$name.$admin.Domain.csproj package Volo.Abp.AuditLogging.Domain -v $abpver
	#dotnet add $name/services/$folder/src/$name.$admin.Domain/$name.$admin.Domain.csproj package Volo.Abp.TenantManagement.Domain -v $abpver
	dotnet add $name/services/$folder/src/$name.$admin.Domain/$name.$admin.Domain.csproj package Volo.Abp.FeatureManagement.Domain -v $abpver
	dotnet add $name/services/$folder/src/$name.$admin.Domain/$name.$admin.Domain.csproj package Volo.Abp.SettingManagement.Domain -v $abpver
	dotnet add $name/services/$folder/src/$name.$admin.Domain/$name.$admin.Domain.csproj package Volo.Abp.PermissionManagement.Domain.Identity -v $abpver
	dotnet add $name/services/$folder/src/$name.$admin.Domain/$name.$admin.Domain.csproj package Volo.Abp.PermissionManagement.Domain.OpenIddict -v $abpver

	## Application.Contracts
	dotnet add $shared_folder/$name.$admin.Application.Contracts/$name.$admin.Application.Contracts.csproj package Volo.Abp.ObjectExtending -v $abpver
	dotnet add $shared_folder/$name.$admin.Application.Contracts/$name.$admin.Application.Contracts.csproj package Volo.Abp.Ddd.Application.Contracts -v $abpver
	#dotnet add $shared_folder/$name.$admin.Application.Contracts/$name.$admin.Application.Contracts.csproj package Volo.Abp.Account.Application.Contracts -v $abpver
	#dotnet add $shared_folder/$name.$admin.Application.Contracts/$name.$admin.Application.Contracts.csproj package Volo.Abp.Identity.Application.Contracts -v $abpver
	#dotnet add $shared_folder/$name.$admin.Application.Contracts/$name.$admin.Application.Contracts.csproj package Volo.Abp.TenantManagement.Application.Contracts -v $abpver
	dotnet add $shared_folder/$name.$admin.Application.Contracts/$name.$admin.Application.Contracts.csproj package Volo.Abp.FeatureManagement.Application.Contracts -v $abpver
	dotnet add $shared_folder/$name.$admin.Application.Contracts/$name.$admin.Application.Contracts.csproj package Volo.Abp.SettingManagement.Application.Contracts -v $abpver
	dotnet add $shared_folder/$name.$admin.Application.Contracts/$name.$admin.Application.Contracts.csproj package Volo.Abp.PermissionManagement.Application.Contracts -v $abpver
	
	## Application
	#dotnet add $name/services/$folder/src/$name.$admin.Application/$name.$admin.Application.csproj package Volo.Abp.Account.Application -v $abpver
	#dotnet add $name/services/$folder/src/$name.$admin.Application/$name.$admin.Application.csproj package Volo.Abp.Identity.Application -v $abpver
	#dotnet add $name/services/$folder/src/$name.$admin.Application/$name.$admin.Application.csproj package Volo.Abp.TenantManagement.Application -v $abpver
	dotnet add $name/services/$folder/src/$name.$admin.Application/$name.$admin.Application.csproj package Volo.Abp.FeatureManagement.Application -v $abpver
	dotnet add $name/services/$folder/src/$name.$admin.Application/$name.$admin.Application.csproj package Volo.Abp.SettingManagement.Application -v $abpver
	dotnet add $name/services/$folder/src/$name.$admin.Application/$name.$admin.Application.csproj package Volo.Abp.PermissionManagement.Application -v $abpver
	
	## EntityFrameworkCore
	#dotnet add $name/services/$folder/src/$name.$admin.EntityFrameworkCore/$name.$admin.EntityFrameworkCore.csproj package Volo.Abp.Identity.EntityFrameworkCore -v $abpver
	#dotnet add $name/services/$folder/src/$name.$admin.EntityFrameworkCore/$name.$admin.EntityFrameworkCore.csproj package Volo.Abp.OpenIddict.EntityFrameworkCore -v $abpver
	#dotnet add $name/services/$folder/src/$name.$admin.EntityFrameworkCore/$name.$admin.EntityFrameworkCore.csproj package Volo.Abp.TenantManagement.EntityFrameworkCore -v $abpver
	dotnet add $name/services/$folder/src/$name.$admin.EntityFrameworkCore/$name.$admin.EntityFrameworkCore.csproj package Volo.Abp.PermissionManagement.EntityFrameworkCore -v $abpver
	dotnet add $name/services/$folder/src/$name.$admin.EntityFrameworkCore/$name.$admin.EntityFrameworkCore.csproj package Volo.Abp.FeatureManagement.EntityFrameworkCore -v $abpver
	dotnet add $name/services/$folder/src/$name.$admin.EntityFrameworkCore/$name.$admin.EntityFrameworkCore.csproj package Volo.Abp.SettingManagement.EntityFrameworkCore -v $abpver
	dotnet add $name/services/$folder/src/$name.$admin.EntityFrameworkCore/$name.$admin.EntityFrameworkCore.csproj package Volo.Abp.AuditLogging.EntityFrameworkCore -v $abpver
	#dotnet add $name/services/$folder/src/$name.$admin.EntityFrameworkCore/$name.$admin.EntityFrameworkCore.csproj package Volo.Abp.BackgroundJobs.EntityFrameworkCore -v $abpver
	dotnet add $name/services/$folder/src/$name.$admin.EntityFrameworkCore/$name.$admin.EntityFrameworkCore.csproj package Microsoft.EntityFrameworkCore.Tools #-v "6.0.5"

	## HTTP API
	#dotnet add $name/services/$folder/src/$name.$admin.HttpApi/$name.$admin.HttpApi.csproj package Volo.Abp.Account.HttpApi -v $abpver
	#dotnet add $name/services/$folder/src/$name.$admin.HttpApi/$name.$admin.HttpApi.csproj package Volo.Abp.Identity.HttpApi -v $abpver
	#dotnet add $name/services/$folder/src/$name.$admin.HttpApi/$name.$admin.HttpApi.csproj package Volo.Abp.TenantManagement.HttpApi -v $abpver
	dotnet add $name/services/$folder/src/$name.$admin.HttpApi/$name.$admin.HttpApi.csproj package Volo.Abp.PermissionManagement.HttpApi -v $abpver
	dotnet add $name/services/$folder/src/$name.$admin.HttpApi/$name.$admin.HttpApi.csproj package Volo.Abp.FeatureManagement.HttpApi -v $abpver
	dotnet add $name/services/$folder/src/$name.$admin.HttpApi/$name.$admin.HttpApi.csproj package Volo.Abp.SettingManagement.HttpApi -v $abpver
	
	
	## HTTP API CLIENT
	#dotnet add $shared_folder/$name.$admin.HttpApi.Client/$name.$admin.HttpApi.Client.csproj package Volo.Abp.Account.HttpApi.Client -v $abpver
	#dotnet add $shared_folder/$name.$admin.HttpApi.Client/$name.$admin.HttpApi.Client.csproj package Volo.Abp.Identity.HttpApi.Client -v $abpver
	#dotnet add $shared_folder/$name.$admin.HttpApi.Client/$name.$admin.HttpApi.Client.csproj package Volo.Abp.TenantManagement.HttpApi.Client -v $abpver	
	dotnet add $shared_folder/$name.$admin.HttpApi.Client/$name.$admin.HttpApi.Client.csproj package Volo.Abp.PermissionManagement.HttpApi.Client -v $abpver
	dotnet add $shared_folder/$name.$admin.HttpApi.Client/$name.$admin.HttpApi.Client.csproj package Volo.Abp.FeatureManagement.HttpApi.Client -v $abpver
	dotnet add $shared_folder/$name.$admin.HttpApi.Client/$name.$admin.HttpApi.Client.csproj package Volo.Abp.SettingManagement.HttpApi.Client -v $abpver

}

function AdminServiceAddSource {
	# SOURCE CODE
	abp add-module Volo.AuditLogging -s "services/$folder/$name.$admin.sln" --skip-db-migrations
	abp add-module Volo.FeatureManagement -s "services/$folder/$name.$admin.sln" --skip-db-migrations
	abp add-module Volo.PermissionManagement -s "services/$folder/$name.$admin.sln" --skip-db-migrations
	abp add-module Volo.SettingManagement -s "services/$folder/$name.$admin.sln" --skip-db-migrations
	abp add-module Volo.Identity -s "services/$folder/$name.$admin.sln" --skip-db-migrations
	abp add-module Volo.OpenIddict -s "services/$folder/$name.$admin.sln" --skip-db-migrations
	abp add-module Volo.TenantManagement -s "services/saas/$name.$admin.sln" --skip-db-migrations
}


function CreateServices {
	$sln_service = "$name.Services.All"
	if (-not(Test-Path -Path "./$name/services/$sln_service.sln" -PathType Leaf)) {
		#dotnet new sln -n "$sln_service" -o ./services
	}
	#dotnet sln "./web_apps/$name.Web.Blazor.sln" add --solution-folder shared (Get-ChildItem -r ./$shared_common/$name.Shared.Common/$name.Shared.Common.csproj)
	#dotnet sln "./web_apps/$name.Web.BlazorServer.sln" add --solution-folder shared (Get-ChildItem -r ./$shared_common/$name.Shared.Common/$name.Shared.Common.csproj)
	#dotnet sln "./web_apps/$name.Web.MVC.sln" add --solution-folder shared (Get-ChildItem -r ./$shared_common/$name.Shared.Common/$name.Shared.Common.csproj)
	foreach($service in $services.keys)
	{
		$folder = $services[$service]
		Write-Output "PROCESS $service $folder" 
		if (Test-Path -Path "./$name/services/$folder") {
			"$service's path exists!"
			continue
		}
		if ($use_share -eq "True") {
			$shared_folder = "./$name/shared/$folder"
			new-item "$shared_folder" -itemtype directory			
		} else {
			$shared_folder = "./$nameservices/$folder/src"		
		}
		
		if ($ui_enable -eq "True") {
			new-item "./$name/web_apps/$folder/src" -itemtype directory
			new-item "./$name/web_apps/$folder/host" -itemtype directory
	        Copy-Item "./common.props*" -Destination "./$name/web_apps/$folder/" -Force
			#abp new "Bamboo.Base" -t module -o Bamboo/services/base --skip-installing-libs
			abp new "$name.$service" -t module -o $name/services/$folder --skip-installing-libs
		} else {
			abp new "$name.$service" -t module --no-ui -o $name/services/$folder --skip-installing-libs			
		}

		dotnet add ./$name/services/$folder/host/"$name.$service".HttpApi.Host/"$name.$service".HttpApi.Host.csproj reference ./$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj
		dotnet add ./$name/services/$folder/host/"$name.$service".HttpApi.Host/"$name.$service".HttpApi.Host.csproj package Volo.Abp.EntityFrameworkCore.PostgreSql -v $abpver
		#dotnet remove ./services/$folder/host/"$name.$service".HttpApi.Host/"$name.$service".HttpApi.Host.csproj package Volo.Abp.EntityFrameworkCore.SqlServer
		
		dotnet add ./$name/services/$folder/src/"$name.$service".EntityFrameworkCore/"$name.$service".EntityFrameworkCore.csproj reference ./$shared_common/$name.Shared.EfCore/$name.Shared.EfCore.csproj
		#dotnet add ./services/$folder/src/"$name.$service".Domain/"$name.$service".Domain.csproj reference ./$shared_common/$name.Shared.Domain/$name.Shared.Domain.csproj
		
		if ($service -ne $admin_name) {
			dotnet sln "./$name/services/$folder/$name.$service.sln" remove (Get-ChildItem -r ./$name/services/$folder/host/$name.$service.AuthServer/$name.$service.AuthServer.csproj)			
		}
		if ($use_share  -eq "True") {
			dotnet sln "./$name/services/$folder/$name.$service.sln" remove (Get-ChildItem -r ./$name/services/$folder/src/$name.$service.Domain.Shared/$name.$service.Domain.Shared.csproj)
			dotnet sln "./$name/services/$folder/$name.$service.sln" remove (Get-ChildItem -r ./$name/services/$folder/src/$name.$service.Application.Contracts/$name.$service.Application.Contracts.csproj)
			dotnet sln "./$name/services/$folder/$name.$service.sln" remove (Get-ChildItem -r ./$name/services/$folder/src/$name.$service.HttpApi.Client/$name.$service.HttpApi.Client.csproj)
			if ($ui_enable -eq "True") {
				dotnet sln "./$name/services/$folder/$name.$service.sln" remove (Get-ChildItem -r ./$name/services/$folder/src/$name.$service.Blazor/$name.$service.Blazor.csproj)
				dotnet sln "./$name/services/$folder/$name.$service.sln" remove (Get-ChildItem -r ./$name/services/$folder/src/$name.$service.Blazor.WebAssembly/$name.$service.Blazor.WebAssembly.csproj)
				dotnet sln "./$name/services/$folder/$name.$service.sln" remove (Get-ChildItem -r ./$name/services/$folder/src/$name.$service.Blazor.Server/$name.$service.Blazor.Server.csproj)
				dotnet sln "./$name/services/$folder/$name.$service.sln" remove (Get-ChildItem -r ./$name/services/$folder/src/$name.$service.Web/$name.$service.Web.csproj)

                dotnet sln "./$name/services/$folder/$name.$service.sln" remove (Get-ChildItem -r ./$name/services/$folder/host/$name.$service.Blazor.Host/$name.$service.Blazor.Host.csproj)
                dotnet sln "./$name/services/$folder/$name.$service.sln" remove (Get-ChildItem -r ./$name/services/$folder/host/$name.$service.Blazor.Server.Host/$name.$service.Blazor.Server.Host.csproj)
                dotnet sln "./$name/services/$folder/$name.$service.sln" remove (Get-ChildItem -r ./$name/services/$folder/host/$name.$service.Web.Host/$name.$service.Web.Host.csproj)
                dotnet sln "./$name/services/$folder/$name.$service.sln" remove (Get-ChildItem -r ./$name/services/$folder/host/$name.$service.Web.Unified/$name.$service.Web.Unified.csproj)
				#dotnet sln "./$name/services/$folder/$name.$service.sln" remove (Get-ChildItem -r ./$name/services/$folder/test/$name.$service.HttpApi.Client.ConsoleTestApp/$name.$service.HttpApi.Client.ConsoleTestApp.csproj)
			}
			
			# Remove reference
			dotnet remove ./$name/services/$folder/src/"$name.$service".Domain/"$name.$service".Domain.csproj reference "..\$name.$service.Domain.Shared\$name.$service.Domain.Shared.csproj"
			#dotnet remove ./services/$folder/src/"$name.$service".Domain/"$name.$service".Domain.csproj reference ./services/$folder/"$name.$service".Domain.Shared/"$name.$service".Domain.Shared.csproj
			dotnet remove ./$name/services/$folder/src/"$name.$service".Application/"$name.$service".Application.csproj reference "..\$name.$service.Application.Contracts\$name.$service.Application.Contracts.csproj"
			dotnet remove ./$name/services/$folder/src/"$name.$service".HttpApi/"$name.$service".HttpApi.csproj reference "..\$name.$service.Application.Contracts\$name.$service.Application.Contracts.csproj"
			#dotnet remove ./$name/services/$folder/host/"$name.$service".HttpApi.Host/"$name.$service".HttpApi.Host.csproj reference  "..\$name.$service.Host.Shared\$name.$service.Host.Shared.csproj"
			if ($ui_enable -eq "True") {
				dotnet remove ./$name/services/$folder/src/"$name.$service".Blazor/"$name.$service".Blazor.csproj reference "..\$name.$service.Application.Contracts\$name.$service.Application.Contracts.csproj"
				dotnet remove ./$name/services/$folder/src/"$name.$service".Blazor.WebAssembly/"$name.$service".Blazor.WebAssembly.csproj reference "..\$name.$service.HttpApi.Client\$name.$service.HttpApi.Client.csproj"
				dotnet remove ./$name/services/$folder/src/"$name.$service".Web/"$name.$service".Web.csproj reference "..\$name.$service.Application.Contracts\$name.$service.Application.Contracts.csproj"

                dotnet remove ./$name/services/$folder/host/"$name.$service".Blazor.Host/"$name.$service".Blazor.Host.csproj reference  "..\$name.$service.Host.Shared\$name.$service.Host.Shared.csproj"
                
                dotnet remove ./$name/services/$folder/host/"$name.$service".Blazor.Server.Host/"$name.$service".Blazor.Server.Host.csproj reference  "..\$name.$service.Host.Shared\$name.$service.Host.Shared.csproj"
                dotnet remove ./$name/services/$folder/host/"$name.$service".Blazor.Server.Host/"$name.$service".Blazor.Server.Host.csproj reference  "..\..\src\$name.$service.Application\$name.$service.Application.csproj"
                dotnet remove ./$name/services/$folder/host/"$name.$service".Blazor.Server.Host/"$name.$service".Blazor.Server.Host.csproj reference  "..\..\src\$name.$service.EntityFrameworkCore\$name.$service.EntityFrameworkCore.csproj"
                dotnet remove ./$name/services/$folder/host/"$name.$service".Blazor.Server.Host/"$name.$service".Blazor.Server.Host.csproj reference  "..\..\src\$name.$service.HttpApi\$name.$service.HttpApi.csproj"

                dotnet remove ./$name/services/$folder/host/"$name.$service".Web.Host/"$name.$service".Web.Host.csproj reference  "..\$name.$service.Host.Shared\$name.$service.Host.Shared.csproj"
                dotnet remove ./$name/services/$folder/host/"$name.$service".Web.Host/"$name.$service".Web.Host.csproj reference  "..\..\src\$name.$service.HttpApi.Client\$name.$service.HttpApi.Client.csproj"
                dotnet remove ./$name/services/$folder/host/"$name.$service".Web.Host/"$name.$service".Web.Host.csproj reference  "..\..\src\$name.$service.HttpApi\$name.$service.HttpApi.csproj"                                                				
                
				dotnet remove ./$name/services/$folder/host/"$name.$service".Web.Unified/"$name.$service".Web.Unified.csproj reference  "..\$name.$service.Host.Shared\$name.$service.Host.Shared.csproj"
                dotnet remove ./$name/services/$folder/host/"$name.$service".Web.Unified/"$name.$service".Web.Unified.csproj reference  "..\..\src\$name.$service.Application\$name.$service.Application.csproj"
                dotnet remove ./$name/services/$folder/host/"$name.$service".Web.Unified/"$name.$service".Web.Unified.csproj reference  "..\..\src\$name.$service.EntityFrameworkCore\$name.$service.EntityFrameworkCore.csproj"
                dotnet remove ./$name/services/$folder/host/"$name.$service".Web.Unified/"$name.$service".Web.Unified.csproj reference  "..\..\src\$name.$service.HttpApi\$name.$service.HttpApi.csproj"
				
				dotnet remove ./$name/services/$folder/test/$name.$service.HttpApi.Client.ConsoleTestApp/$name.$service.HttpApi.Client.ConsoleTestApp.csproj reference  "..\..\src\$name.$service.HttpApi.Client\$name.$service.HttpApi.Client.csproj"

			}

			## Move Project
			Move-Item -Path "./$name/services/$folder/src/$name.$service.Domain.Shared" -Destination $shared_folder"/$name.$service.Domain.Shared" -Force
			Move-Item -Path "./$name/services/$folder/src/$name.$service.Application.Contracts" -Destination $shared_folder"/$name.$service.Application.Contracts" -Force
			Move-Item -Path "./$name/services/$folder/src/$name.$service.HttpApi.Client" -Destination $shared_folder"/$name.$service.HttpApi.Client" -Force

			if ($ui_enable -eq "True") {
				Move-Item -Path "./$name/services/$folder/src/$name.$service.Blazor" -Destination "./$name/web_apps/$folder/src/$name.$service.Blazor" -Force
				Move-Item -Path "./$name/services/$folder/src/$name.$service.Blazor.WebAssembly" -Destination "./$name/web_apps/$folder/src/$name.$service.Blazor.WebAssembly" -Force
				Move-Item -Path "./$name/services/$folder/src/$name.$service.Blazor.Server" -Destination "./$name/web_apps/$folder/src/$name.$service.Blazor.Server" -Force
				Move-Item -Path "./$name/services/$folder/src/$name.$service.Web" -Destination "./$name/web_apps/$folder/src/$name.$service.Web" -Force

				Move-Item -Path "./$name/services/$folder/host/$name.$service.Blazor.Host" -Destination "./$name/web_apps/$folder/host/$name.$service.Blazor.Host" -Force
				Move-Item -Path "./$name/services/$folder/host/$name.$service.Blazor.Server.Host" -Destination "./$name/web_apps/$folder/host/$name.$service.Blazor.Server.Host" -Force
				Move-Item -Path "./$name/services/$folder/host/$name.$service.Web.Host" -Destination "./$name/web_apps/$folder/host/$name.$service.Web.Host" -Force
				Move-Item -Path "./$name/services/$folder/host/$name.$service.Web.Unified" -Destination "./$name/web_apps/$folder/host/$name.$service.Web.Unified" -Force

				Move-Item -Path "./$name/services/$folder/angular" -Destination "./$name/web_apps/angular/$folder" -Force
				#if (-not(Test-Path -Path "./$name/web_apps/angular/projects/dev-app")) {
				#	Move-Item -Path "./$name/services/$folder/angular/projects/dev-app" -Destination "./$name/web_apps/angular/projects/" -Force
				#}
				#Remove-Item -Recurse -Force ./$name/services/$folder/angular*
			}

			## Add reference back to projects
			dotnet add ./$name/services/$folder/src/$name.$service.Domain/$name.$service.Domain.csproj reference "$shared_folder/$name.$service.Domain.Shared/$name.$service.Domain.Shared.csproj"
			dotnet add ./$name/services/$folder/src/$name.$service.Application/$name.$service.Application.csproj reference "$shared_folder/$name.$service.Application.Contracts/$name.$service.Application.Contracts.csproj"
			dotnet add ./$name/services/$folder/src/$name.$service.HttpApi/$name.$service.HttpApi.csproj reference "$shared_folder/$name.$service.Application.Contracts/$name.$service.Application.Contracts.csproj"
			dotnet add ./$name/web_apps/$folder/src/$name.$service.Blazor/$name.$service.Blazor.csproj reference "$shared_folder/$name.$service.Application.Contracts/$name.$service.Application.Contracts.csproj"
			dotnet add ./$name/web_apps/$folder/src/$name.$service.Blazor.WebAssembly/$name.$service.Blazor.WebAssembly.csproj reference "$shared_folder/$name.$service.HttpApi.Client/$name.$service.HttpApi.Client.csproj"
			dotnet add ./$name/web_apps/$folder/src/$name.$service.Web/$name.$service.Web.csproj reference "$shared_folder/$name.$service.Application.Contracts/$name.$service.Application.Contracts.csproj"
			
            if ($ui_enable -eq "True") {
                dotnet add ./$name/web_apps/$folder/host/$name.$service.Blazor.Host/$name.$service.Blazor.Host.csproj reference ./$name/services/$folder/host/$name.$service.Host.Shared/$name.$service.Host.Shared.csproj

                dotnet add ./$name/web_apps/$folder/host/$name.$service.Blazor.Server.Host/$name.$service.Blazor.Server.Host.csproj reference ./$name/services/$folder/host/$name.$service.Host.Shared/$name.$service.Host.Shared.csproj
                dotnet add ./$name/web_apps/$folder/host/$name.$service.Blazor.Server.Host/$name.$service.Blazor.Server.Host.csproj reference ./$name/services/$folder/src/$name.$service.Application/$name.$service.Application.csproj
                dotnet add ./$name/web_apps/$folder/host/$name.$service.Blazor.Server.Host/$name.$service.Blazor.Server.Host.csproj reference ./$name/services/$folder/src/$name.$service.EntityFrameworkCore/$name.$service.EntityFrameworkCore.csproj
                dotnet add ./$name/web_apps/$folder/host/$name.$service.Blazor.Server.Host/$name.$service.Blazor.Server.Host.csproj reference ./$name/services/$folder/src/$name.$service.HttpApi/$name.$service.HttpApi.csproj

                dotnet add ./$name/web_apps/$folder/host/$name.$service.Web.Host/$name.$service.Web.Host.csproj reference ./$name/services/$folder/host/$name.$service.Host.Shared/$name.$service.Host.Shared.csproj
                dotnet add ./$name/web_apps/$folder/host/$name.$service.Web.Host/$name.$service.Web.Host.csproj reference ./$name/services/$folder/src/$name.$service.HttpApi/$name.$service.HttpApi.csproj
                dotnet add ./$name/web_apps/$folder/host/$name.$service.Web.Host/$name.$service.Web.Host.csproj reference "$shared_folder/$name.$service.HttpApi.Client/$name.$service.HttpApi.Client.csproj"
                
                dotnet add ./$name/web_apps/$folder/host/$name.$service.Web.Unified/$name.$service.Web.Unified.csproj reference ./$name/services/$folder/host/$name.$service.Host.Shared/$name.$service.Host.Shared.csproj
                dotnet add ./$name/web_apps/$folder/host/$name.$service.Web.Unified/$name.$service.Web.Unified.csproj reference ./$name/services/$folder/src/$name.$service.Application/$name.$service.Application.csproj
                dotnet add ./$name/web_apps/$folder/host/$name.$service.Web.Unified/$name.$service.Web.Unified.csproj reference ./$name/services/$folder/src/$name.$service.EntityFrameworkCore/$name.$service.EntityFrameworkCore.csproj
                dotnet add ./$name/web_apps/$folder/host/$name.$service.Web.Unified/$name.$service.Web.Unified.csproj reference ./$name/services/$folder/src/$name.$service.HttpApi/$name.$service.HttpApi.csproj
				
				dotnet add ./$name/services/$folder/test/$name.$service.HttpApi.Client.ConsoleTestApp/$name.$service.HttpApi.Client.ConsoleTestApp.csproj reference "$shared_folder/$name.$service.HttpApi.Client/$name.$service.HttpApi.Client.csproj"
			
            }
		}

		# DBMigrator
		if ($service -eq $admin_name) 
		{
			dotnet new console -n "$name.$service.DbMigrator" -o ./$name/services/$folder/host/$name.$service.DbMigrator
			dotnet add ./$name/services/$folder/host/$name.$service.DbMigrator/$name.$service.DbMigrator.csproj package Microsoft.Extensions.Hosting -v "7.0.*"
			dotnet add ./$name/services/$folder/host/$name.$service.DbMigrator/$name.$service.DbMigrator.csproj package Serilog.Extensions.Logging -v "3.1.0"
			dotnet add ./$name/services/$folder/host/$name.$service.DbMigrator/$name.$service.DbMigrator.csproj package Serilog.Sinks.Async -v "1.5.0"
			dotnet add ./$name/services/$folder/host/$name.$service.DbMigrator/$name.$service.DbMigrator.csproj package Serilog.Sinks.File -v "5.0.0"
			dotnet add ./$name/services/$folder/host/$name.$service.DbMigrator/$name.$service.DbMigrator.csproj package Serilog.Sinks.ColoredConsole -v "3.0.1"	
			dotnet add ./$name/services/$folder/host/$name.$service.DbMigrator/$name.$service.DbMigrator.csproj package Volo.Abp.Autofac -v $abpver	
			dotnet add ./$name/services/$folder/host/$name.$service.DbMigrator/$name.$service.DbMigrator.csproj package Volo.Abp.BackgroundJobs -v $abpver
			dotnet add ./$name/services/$folder/host/$name.$service.DbMigrator/$name.$service.DbMigrator.csproj package Volo.Abp.Identity.Domain -v $abpver
			dotnet add ./$name/services/$folder/host/$name.$service.DbMigrator/$name.$service.DbMigrator.csproj package Volo.Abp.TenantManagement.Domain -v $abpver	
			dotnet add ./$name/services/$folder/host/$name.$service.DbMigrator/$name.$service.DbMigrator.csproj reference ./$name/services/$folder/src/$name.$service.EntityFrameworkCore/$name.$service.EntityFrameworkCore.csproj
			Copy-Item -Path "./libs/Bamboo.Shared.DbMigrator/*" -Destination ./$name/services/$folder/host/$name.$service.DbMigrator/ -recurse -Force
			if ($service -ne $admin_name) {
				Copy-Item -Path "./libs/Bamboo.Shared.DbMigrator/*" -Destination ./$name/services/$folder/host/$name.$service.DbMigrator/ -recurse -Force
			}
			if ($use_share  -eq "True") {
				dotnet add ./$name/services/$folder/host/$name.$service.DbMigrator/$name.$service.DbMigrator.csproj reference "$shared_folder/$name.$service.Application.Contracts/$name.$service.Application.Contracts.csproj"			
			} else {
				dotnet add ./$name/services/$folder/host/$name.$service.DbMigrator/$name.$service.DbMigrator.csproj reference ./$name/services/$folder/src/$name.$service.Application.Contracts/$name.$service.Application.Contracts.csproj
			}
			dotnet sln "./$name/services/$folder/$name.$service.sln" add --solution-folder host ./$name/services/$folder/host/$name.$service.DbMigrator/$name.$service.DbMigrator.csproj
		}
		# End DBMigrator

		dotnet add $shared_folder/"$name.$service".Domain.Shared/"$name.$service".Domain.Shared.csproj reference ./$shared_common/$name.Shared.Common/$name.Shared.Common.csproj

		Write-Output "Solution remove ./$name/services/$folder/$name.$service.sln" 
		#dotnet sln "./$name/services/$folder/$name.$service.sln" remove (Get-ChildItem -r ./$name/services/$folder/host/$name.$service.Host.Shared/$name.$service.Host.Shared.csproj)		
		#dotnet sln "./$name/services/$folder/$name.$service.sln" remove (Get-ChildItem -r ./$name/services/$folder/src/$name.$service.MongoDB/$name.$service.MongoDB.csproj)
		dotnet sln "./$name/services/$folder/$name.$service.sln" remove (Get-ChildItem -r ./$name/services/$folder/test/$name.$service.MongoDB.Tests/$name.$service.MongoDB.Tests.csproj)
		dotnet sln "./$name/services/$folder/$name.$service.sln" remove (Get-ChildItem -r ./$name/services/$folder/src/$name.$service.Installer/$name.$service.Installer.csproj)
		
		if ($service -ne $admin_name) {
			Remove-Item -Recurse -Force (Get-ChildItem -r ./$name/services/**/*.$service.AuthServer)		
		}
		Write-Output "REMOVE UN-USE ITEMS" 
		#Remove-Item -Recurse -Force (Get-ChildItem -r **/*.$service.Host.Shared)
		#Remove-Item -Recurse -Force ./$name/services/$folder/src/*.$service.MongoDB
		Remove-Item -Recurse -Force ./$name/services/$folder/test/*.$service.MongoDB.Tests
		Remove-Item -Recurse -Force ./$name/services/$folder/src/*.$service.Installer
		#Remove-Item -Recurse -Force ./$name/services/$folder/angular*

		Write-Output "Solution add ./$name/services/$folder/$name.$service.sln" 
		dotnet sln "./$name/services/$folder/$name.$service.sln" add --solution-folder shared (Get-ChildItem -r ./$shared_common/**/*.csproj)
		dotnet sln "./$name/services/$folder/$name.$service.sln" add --solution-folder shared (Get-ChildItem -r $shared_folder/**/*.csproj)			

		if ($ui_enable -eq "True") {
			#dotnet sln "./$name/services/$folder/$name.$service.sln" add --solution-folder "ui/shared"(Get-ChildItem -r ./$name/web_apps/$folder/src/**/*.csproj)
			#dotnet sln "./$name/services/$folder/$name.$service.sln" add --solution-folder "ui/host"(Get-ChildItem -r ./$name/web_apps/$folder/host/**/*.csproj)	
		}		
				
		dotnet sln "./$name/services/$sln_service.sln" add (Get-ChildItem -r ./$name/services/$folder/**/*.csproj)
		if ($use_share  -eq "True") {
			dotnet sln "./$name/services/$sln_service.sln" add --solution-folder "$name/modules_shared" (Get-ChildItem -r $shared_folder/**/*.csproj)
			if ($ui_enable -eq "True") {
				dotnet sln "./$name/web_apps/$name.Web.Blazor.sln" add --solution-folder "ui" (Get-ChildItem -r ./$name/web_apps/$folder/src/*.Blazor.csproj)
				dotnet sln "./$name/web_apps/$name.Web.Blazor.sln" add --solution-folder "ui" (Get-ChildItem -r ./$name/web_apps/$folder/src/*.WebAssembly.csproj)
				dotnet sln "./$name/web_apps/$name.Web.Blazor.sln" add --solution-folder "modules_shared" (Get-ChildItem -r $shared_folder/**/*.csproj)
				dotnet add ./$name/web_apps/$name.Blazor/$name.Blazor.csproj reference ./$name/web_apps/$folder/src/$name.$service.Blazor.WebAssembly/$name.$service.Blazor.WebAssembly.csproj
				
				dotnet sln "./$name/web_apps/$name.Web.BlazorServer.sln" add --solution-folder "ui" (Get-ChildItem -r ./$name/web_apps/$folder/src/*.Blazor.csproj)
				dotnet sln "./$name/web_apps/$name.Web.BlazorServer.sln" add --solution-folder "ui" (Get-ChildItem -r ./$name/web_apps/$folder/src/*.Blazor.Server.csproj)
				dotnet sln "./$name/web_apps/$name.Web.BlazorServer.sln" add --solution-folder "modules_shared" (Get-ChildItem -r $shared_folder/**/*.csproj)
				dotnet add ./$name/web_apps/$name.BlazorServer/$name.BlazorServer.csproj reference ./$name/web_apps/$folder/src/$name.$service.Blazor.Server/$name.$service.Blazor.Server.csproj
				
				# MVC
				dotnet sln "./$name/web_apps/$name.Web.MVC.sln" add --solution-folder "ui" (Get-ChildItem -r ./$name/web_apps/$folder/src/*.Web.csproj)
				dotnet sln "./$name/web_apps/$name.Web.MVC.sln" add --solution-folder "modules_shared" (Get-ChildItem -r $shared_folder/**/*.csproj)
				dotnet sln "./$name/web_apps/$name.Web.MVC.sln" add --solution-folder "modules_shared" ./$name/services/$folder/src/$name.$service.HttpApi/$name.$service.HttpApi.csproj
				dotnet add ./$name/web_apps/$name.Web/$name.Web.csproj reference ./$name/web_apps/$folder/src/$name.$service.Web/$name.$service.Web.csproj
				dotnet add ./$name/web_apps/$name.Web/$name.Web.csproj reference ./$name/services/$folder/src/$name.$service.HttpApi/$name.$service.HttpApi.csproj
			}
		}
		if ($service -eq $admin_name) {
		
			Copy-Item -Path "./libs/Bamboo.Authentication" -Destination ./$name/services/$folder/src/$name.Authentication -recurse -Force
			Move-Item -Path "./$name/services/$folder/src/$name.Authentication/Bamboo.Authentication.csproj" -Destination "./$name/services/$folder/src/$name.Authentication/$name.Authentication.csproj" -Force
			Copy-Item -Path "./libs/Bamboo.LoginUi.Web" -Destination ./$name/services/$folder/src/$name.LoginUi.Web -recurse -Force
			Move-Item -Path "./$name/services/$folder/src/$name.LoginUi.Web/Bamboo.LoginUi.Web.csproj" -Destination "./$name/services/$folder/src/$name.LoginUi.Web/$name.LoginUi.Web.csproj" -Force
			AccountServiceAddReference
			dotnet add ./$name/services/$folder/host/$name.$service.AuthServer/$name.$service.AuthServer.csproj package Volo.Abp.EntityFrameworkCore.PostgreSql -v $abpver
			dotnet remove ./$name/services/$folder/host/"$name.$service".AuthServer/"$name.$service".AuthServer.csproj reference "..\..\src\$name.$service.Application.Contracts\$name.$service.Application.Contracts.csproj"
			dotnet add ./$name/services/$folder/host/$name.$service.AuthServer/$name.$service.AuthServer.csproj reference "$shared_folder/$name.$service.Application.Contracts/$name.$service.Application.Contracts.csproj"
			#dotnet add ./$name/services/$folder/host/$name.$service.AuthServer/$name.$service.AuthServer.csproj reference "..\..\src\$name.$service.Application.Contracts\$name.$service.Application.Contracts.csproj"
			dotnet add ./$name/services/$folder/host/$name.$service.AuthServer/$name.$service.AuthServer.csproj reference ./$name/services/$folder/src/$name.Authentication/$name.Authentication.csproj
			dotnet add ./$name/services/$folder/host/$name.$service.AuthServer/$name.$service.AuthServer.csproj reference ./$name/services/$folder/src/$name.LoginUi.Web/$name.LoginUi.Web.csproj
			dotnet add ./$name/services/$folder/host/$name.$service.AuthServer/$name.$service.AuthServer.csproj reference ./$shared_common/$name.Shared.Common/$name.Shared.Common.csproj
					
			#dotnet add ./$name/services/$folder/host/"$name.$service".HttpApi.Host/"$name.$service".HttpApi.Host.csproj package Volo.Abp.OpenIddict.AspNetCore -v $abpver
			#dotnet add ./$name/services/$folder/host/"$name.$service".HttpApi.Host/"$name.$service".HttpApi.Host.csproj package Volo.Abp.BackgroundJobs.HangFire -v $abpver
			dotnet add ./$name/services/$folder/host/$name.$service.HttpApi.Host/$name.$service.HttpApi.Host.csproj reference ./$name/services/$folder/src/$name.Authentication/$name.Authentication.csproj
			#dotnet add ./$name/services/$folder/host/"$name.$service".HttpApi.Host/"$name.$service".HttpApi.Host.csproj reference ./$name/services/$folder/src/$name.LoginUi.Web/$name.LoginUi.Web.csproj
			
			dotnet sln "./$name/services/$folder/$name.$service.sln" add (Get-ChildItem -r ./$name/services/$folder/src/**/*.csproj)
		}
		if ($service -eq 'Administration') {
			AdminServiceAddReference
		}
		if ($service -eq 'CmsService') {
			dotnet add ./$name/web_apps/$folder/src/$name.$service.Web/$name.$service.Web.csproj package Volo.CmsKit.Public.Web -v $abpver
			CmsKitAddReference
		}
	}
}

CreateServices

cmd /c pause
