$name = $args[0]
$name = "Bamboo"
$abpver = "8.2.0"
$msver = "8.0.*"
$ntsver = "13.0.1"

$shared_path = "shared"
$shared_common = "$shared_path/common"
$services_path = "services"
$apps_path = "apps"

$app_admin = "admin"
$app_name = "$name.Admin"
$app_shared = "$shared_path/$app_admin"
$app_path = "$name/$services_path/$app_admin"
$app_apps = "$name/$apps_path/$app_admin"
$sln_admin = "$name.Admin.Host"

$sln_service = "$name.Services.All"
$sln_gateways = "$name.Gateways"
$sln_webs = "$name.Web"
$use_share = "True"	

function CreatePath {

	if (-not(Test-Path -Path "$name")) {
		new-item "$name" -itemtype directory
	}
	if (-not(Test-Path -Path "$name/$shared_path")){
		new-item "$name/$shared_path" -itemtype directory
	}
	if (-not(Test-Path -Path "$name/$shared_common")){
		new-item "$name/$shared_common" -itemtype directory
	}
	if (-not(Test-Path -Path "$name/$services_path")){
		new-item "$name/$services_path" -itemtype directory
	}	
	if (-not(Test-Path -Path "$name/$apps_path")){
		new-item "$name/$apps_path" -itemtype directory
	}
	if (-not(Test-Path -Path "$name/$apps_path/$app_admin")){
		new-item "$name/$apps_path/$app_admin" -itemtype directory
	}
	if (-not(Test-Path -Path "$name/$apps_path/angular")){
		new-item "$name/$apps_path/angular" -itemtype directory
	}
	if (-not(Test-Path -Path "$name/mobile")){
		new-item "$name/mobile" -itemtype directory
	}	

	Copy-Item "./common.props*" -Destination ./$name/ -Force
	Copy-Item "./common.props*" -Destination ./$name/$apps_path/ -Force
	Copy-Item "./libs/global.json" -Destination ./$name/ -Force
	Copy-Item "./libs/global.json" -Destination ./$name/$apps_path -Force

	dotnet new sln -n "$sln_service" -o ./$name/services # --force
	dotnet new sln -n "$sln_webs.Blazor" -o ./$name/$apps_path --force
	dotnet new sln -n "$sln_webs.BlazorServer" -o ./$name/$apps_path --force
	dotnet new sln -n "$sln_webs.MVC" -o ./$name/$apps_path --force
}


function CreateCoreLibs {
		
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
    dotnet add ./$name/$shared_common/$name.Shared.EfCore/$name.Shared.EfCore.csproj package Npgsql.EntityFrameworkCore.PostgreSQL.NetTopologySuite #-v 8.0.0
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

	#dotnet new classlib -n "$name.Shared.AspNetCore" -o "./$name/$shared_common/$name.Shared.AspNetCore"
	##dotnet add ./$name/$shared_common/$name.Shared.AspNetCore/$name.Shared.AspNetCore.csproj package Serilog.AspNetCore -v "5.0.0"
	#dotnet add ./$name/$shared_common/$name.Shared.AspNetCore/$name.Shared.AspNetCore.csproj package Volo.Abp.AspNetCore.Serilog -v $abpver
	#dotnet add ./$name/$shared_common/$name.Shared.AspNetCore/$name.Shared.AspNetCore.csproj package Volo.Abp.Swashbuckle -v $abpver
	#dotnet add ./$name/$shared_common/$name.Shared.AspNetCore/$name.Shared.AspNetCore.csproj reference ./$name/$shared_common/$name.Shared.Hosting/$name.Shared.Hosting.csproj
	#Copy-Item -Path "./libs/Bamboo.Shared.Hosting/AspNetCore/*" -Destination ./$name/$shared_common/$name.Shared.AspNetCore/ -recurse -Force
	#Remove-Item -Path ./$name/$shared_common/$name.Shared.AspNetCore/Class1.cs -Force 
	
	dotnet new classlib -n "$name.Shared.Microservices" -o "./$name/$shared_common/$name.Shared.Microservices"
	dotnet add ./$name/$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj package Microsoft.AspNetCore.DataProtection.StackExchangeRedis -v $msver
	dotnet add ./$name/$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj package Microsoft.AspNetCore.Authentication.JwtBearer -v $msver
	dotnet add ./$name/$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj package DistributedLock.FileSystem -v 1.0.1
	dotnet add ./$name/$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj package DistributedLock.Redis -v 1.0.2
	dotnet add ./$name/$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj package Swashbuckle.AspNetCore #-v 6.4.0
	dotnet add ./$name/$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj package Hangfire.LiteDB
	dotnet add ./$name/$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj package IdentityModel -v 6.2.0
	dotnet add ./$name/$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj package Rebus.ServiceProvider -v 10.1.2
	dotnet add ./$name/$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj package Rebus.Redis -v 0.0.1
	dotnet add ./$name/$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj package Rebus.PostgreSql -v 9.1.1
	#dotnet add ./$name/$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj package Rebus.Kafka -v 3.4.1
	#dotnet add ./$name/$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj package Serilog.Sinks.Async -v 1.5.0
	#dotnet add ./$name/$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj package Serilog.AspNetCore -v 5.0.0
	
	dotnet add ./$name/$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj package Volo.Abp.Autofac -v $abpver
	dotnet add ./$name/$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj package Volo.Abp.AspNetCore.Serilog -v $abpver
	dotnet add ./$name/$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj package Volo.Abp.AspNetCore.MultiTenancy -v $abpver	
	dotnet add ./$name/$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj package Volo.Abp.AspNetCore.Authentication.JwtBearer -v $abpver
	dotnet add ./$name/$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj package Volo.Abp.BackgroundJobs.RabbitMQ -v $abpver
	dotnet add ./$name/$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj package Volo.Abp.BackgroundJobs.HangFire -v $abpver
	dotnet add ./$name/$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj package Volo.Abp.BackgroundWorkers.HangFire -v $abpver
	dotnet add ./$name/$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj package Volo.Abp.BlobStoring -v $abpver
	dotnet add ./$name/$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj package Volo.Abp.BlobStoring.FileSystem -v $abpver
	#dotnet add ./$name/$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj package Volo.Abp.BlobStoring.Database -v $abpver
	dotnet add ./$name/$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj package Volo.Abp.Caching.StackExchangeRedis -v $abpver
	dotnet add ./$name/$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj package Volo.Abp.Data -v $abpver
	dotnet add ./$name/$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj package Volo.Abp.DistributedLocking -v $abpver
	dotnet add ./$name/$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj package Volo.Abp.EntityFrameworkCore -v $abpver
	dotnet add ./$name/$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj package Volo.Abp.EntityFrameworkCore.PostgreSql -v $abpver
	dotnet add ./$name/$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj package Volo.Abp.EventBus.RabbitMQ -v $abpver
	dotnet add ./$name/$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj package Volo.Abp.EventBus.Azure -v $abpver
	dotnet add ./$name/$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj package Volo.Abp.EventBus.Kafka -v $abpver
	dotnet add ./$name/$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj package Volo.Abp.EventBus.Rebus -v $abpver
	dotnet add ./$name/$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj package Volo.Abp.Localization -v $abpver
	dotnet add ./$name/$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj package Volo.Abp.MultiTenancy -v $abpver
	dotnet add ./$name/$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj package Volo.Abp.MongoDB -v $abpver
	dotnet add ./$name/$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj package Volo.Abp.Swashbuckle -v $abpver

	dotnet add ./$name/$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj package Volo.Abp.Identity.Application -v $abpver	
	dotnet add ./$name/$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj package Volo.Abp.SettingManagement.Application -v $abpver	
	dotnet add ./$name/$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj package Volo.Abp.TenantManagement.Application -v $abpver	

	#dotnet add ./$name/$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj package Volo.Abp.AuditLogging.EntityFrameworkCore -v $abpver
	#dotnet add ./$name/$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj package Volo.Abp.BackgroundJobs.EntityFrameworkCore -v $abpver
	dotnet add ./$name/$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj reference ./$name/$shared_common/$name.Shared.Hosting/$name.Shared.Hosting.csproj
	#dotnet add ./$name/$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj reference ./$name/$shared_common/$name.Shared.AspNetCore/$name.Shared.AspNetCore.csproj
	Copy-Item -Path "./libs/Bamboo.Shared.Hosting/Microservices/*" -Destination ./$name/$shared_common/$name.Shared.Microservices/ -recurse -Force
	Remove-Item -Path ./$name/$shared_common/$name.Shared.Microservices/Class1.cs -Force
	
	# if (-not(Test-Path -Path "$name/$apps_path")){
	# 	new-item "$name/$apps_path" -itemtype directory
	# }

	Copy-Item "./common.props*" -Destination ./$name/ -Force
	Copy-Item "./common.props*" -Destination ./$name/shared/ -Force
	Copy-Item "./common.props*" -Destination ./$name/$apps_path/ -Force

	dotnet sln "./$name/services/$sln_service.sln" add --solution-folder "shared/common" (Get-ChildItem -r ./$name/$shared_common/**/*.csproj)
}

function CreateGateways {
	if (-not(Test-Path -Path "$name/gateways")){
		new-item "$name/gateways" -itemtype directory
	}
	dotnet new sln -n "$sln_gateways" -o ./$name/gateways
	dotnet new classlib -n "$name.Shared.Gateway" -o "./$name/gateways/shared/$name.Shared.Gateway"
	dotnet add ./$name/gateways/shared/$name.Shared.Gateway/$name.Shared.Gateway.csproj package Yarp.ReverseProxy -v 2.0.0
	#dotnet add ./$name/gateways/shared/$name.Shared.Gateway/$name.Shared.Gateway.csproj reference ./$name/$shared_common/$name.Shared.AspNetCore/$name.Shared.AspNetCore.csproj
	Copy-Item -Path "./libs/Bamboo.Shared.Hosting/Gateways/*" -Destination ./$name/gateways/shared/$name.Shared.Gateway/ -recurse -Force
	Remove-Item -Path ./$name/gateways/shared/$name.Shared.Gateway/Class1.cs -Force 
	
	dotnet new web -n "$name.Gateway" -o "./$name/gateways/$name.Gateway"
	dotnet add ./$name/gateways/$name.Gateway/$name.Gateway.csproj reference ./$name/gateways/shared/$name.Shared.Gateway/$name.Shared.Gateway.csproj
	dotnet sln "./$name/gateways/$sln_gateways.sln" add (Get-ChildItem -r ./$name/gateways/**/*.csproj)
	dotnet sln "./$name/gateways/$sln_gateways.sln" add --solution-folder shared (Get-ChildItem -r ./$name/$shared_common/$name.Shared.Hosting/**/*.csproj)
	#dotnet sln "./$name/gateways/$sln_gateways.sln" add --solution-folder shared (Get-ChildItem -r ./$name/$shared_common/$name.Shared.AspNetCore/**/*.csproj)
	#dotnet sln "./gateways/$sln_gateways.sln" add (Get-ChildItem -r ./$shared_common/$name.Shared.Gateway/**/*.csproj)
}

function CreateCoreApp  {
	if (-not(Test-Path -Path "./$name/$app_shared")){
		new-item "./$name/$app_shared" -itemtype directory
	}
	if (-not(Test-Path -Path "$app_path")){
		new-item "$app_path" -itemtype directory
	}

	if ($use_share -ne "True") {
		$app_shared = "$app_path/$app_name/src"
	}
	if (-not(Test-Path -Path "$name/$apps_path/$app_admin")){
		new-item "$name/$apps_path/$app_admin" -itemtype directory
	}
	dotnet new sln -n "$sln_admin" -o ./$name/$services_path --force
	
	## Blazor Client
	# abp new "Bamboo" -t app --no-open --no-random-port -u blazor --database-provider ef -dbms PostgreSQL --create-solution-folder --skip-installing-libs -m none --skip-bundling -o temp/$name-blazor
	# abp new "Bamboo.Admin" -t app --no-open --no-random-port -u blazor --separate-auth-server --database-provider ef -dbms PostgreSQL --create-solution-folder --skip-installing-libs -m none --skip-bundling -o $name/$services_path
	abp new "$app_name" -t app --no-open --no-random-port -u blazor --separate-auth-server --database-provider ef -dbms PostgreSQL --create-solution-folder --skip-installing-libs -m none --skip-bundling -o $app_path -v $abpver
	#Remove-Item -Recurse -Force $app_path/$app_name/src/$app_name.Blazor
	#Move-Item -Path $name/$services_path/$name/src/$name.Blazor -Destination ./$name/$apps_path/"$name.Blazor" -Force

	abp new "$app_name" -t app --no-open --no-random-port -u blazor --database-provider ef -dbms PostgreSQL --create-solution-folder --skip-installing-libs -m none -o temp/$name-blazor-bundle -v $abpver
    #Copy-Item -Path temp/$name-blazor-bundle/$app_name/src/$app_name.AuthServer -Destination $app_path/$app_name/src/$app_name.AuthServer -recurse -Force
	Copy-Item -Path temp/$name-blazor-bundle/$app_name/src/$app_name.HttpApi.Host -Destination $app_path/$app_name/src/$app_name.HttpApi.Host.Bundle -recurse -Force
	Move-Item -Path $app_path/$app_name/src/$app_name.HttpApi.Host.Bundle/$app_name.HttpApi.Host.csproj -Destination $app_path/$app_name/src/$app_name.HttpApi.Host.Bundle/$app_name.HttpApi.Host.Bundle.csproj -Force
	
	# https://gist.github.com/ebicoglu/ce0f0425bab806d0ee1a87d0073af96b
	# dotnet new web -n "$app_name.ExternalLogin" -o $app_path/$app_name/src/$app_name.ExternalLogin
	# dotnet add $app_path/$app_name/src/$app_name.EntityFrameworkCore/$app_name.EntityFrameworkCore.csproj reference ./$shared_common/$name.Shared.EfCore/$name.Shared.EfCore.csproj

	dotnet add $app_path/$app_name/src/$app_name.Domain.Shared/$app_name.Domain.Shared.csproj package Newtonsoft.Json -v $ntsver
	dotnet add $app_path/$app_name/src/$app_name.Domain.Shared/$app_name.Domain.Shared.csproj package Volo.Abp.Guids -v $abpver
	dotnet add $app_path/$app_name/src/$app_name.Domain.Shared/$app_name.Domain.Shared.csproj package Volo.Abp.Ddd.Application.Contracts -v $abpver

	dotnet add $app_path/$app_name/src/$app_name.EntityFrameworkCore/$app_name.EntityFrameworkCore.csproj package Npgsql.EntityFrameworkCore.PostgreSQL.NetTopologySuite -v 8.0.0		
	Copy-Item -Path "./libs/Bamboo.Shared.EfCore/Extensions" -Destination $app_path/$app_name/src/$app_name.EntityFrameworkCore/ -recurse -Force

	dotnet add $app_path/$app_name/src/$app_name.HttpApi.Host reference $name/$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj
	#dotnet add $app_path/$app_name/src/$app_name.HttpApi.Host.Bundle reference $name/$shared_common/$name.Shared.Microservices/$name.Shared.Microservices.csproj

	if ($use_share -eq "True") {
		dotnet sln "$app_path/$app_name/$app_name.sln" remove $app_path/$app_name/src/$app_name.Blazor/$app_name.Blazor.csproj		
		dotnet sln "$app_path/$app_name/$app_name.sln" remove $app_path/$app_name/src/$app_name.Blazor.Client/$app_name.Blazor.Client.csproj
		dotnet sln "$app_path/$app_name/$app_name.sln" remove $app_path/$app_name/src/$app_name.HttpApi.Client/$app_name.HttpApi.Client.csproj
		dotnet sln "$app_path/$app_name/$app_name.sln" remove $app_path/$app_name/src/$app_name.Application.Contracts/$app_name.Application.Contracts.csproj
		dotnet sln "$app_path/$app_name/$app_name.sln" remove $app_path/$app_name/src/$app_name.Domain.Shared/$app_name.Domain.Shared.csproj
		
		# Remove reference
		Write-Output "Remove reference"
		dotnet remove $app_path/$app_name/src/$app_name.Domain/$app_name.Domain.csproj reference "..\$app_name.Domain.Shared\$app_name.Domain.Shared.csproj"		
		dotnet remove $app_path/$app_name/src/$app_name.Application/$app_name.Application.csproj reference "..\$app_name.Application.Contracts\$app_name.Application.Contracts.csproj"
		dotnet remove $app_path/$app_name/src/$app_name.HttpApi/$app_name.HttpApi.csproj reference "..\$app_name.Application.Contracts\$app_name.Application.Contracts.csproj"
		dotnet remove $app_path/$app_name/src/$app_name.DbMigrator/$app_name.DbMigrator.csproj reference "..\$app_name.Application.Contracts\$app_name.Application.Contracts.csproj"
		dotnet remove $app_path/$app_name/src/$app_name.Blazor.Client/$app_name.Blazor.Client.csproj reference "..\..\src\$app_name.HttpApi.Client\$app_name.HttpApi.Client.csproj"
		dotnet remove $app_path/$app_name/test/$app_name.HttpApi.Client.ConsoleTestApp/$app_name.HttpApi.Client.ConsoleTestApp.csproj reference "..\$app_name.HttpApi.Client\$app_name.HttpApi.Client.csproj"
		
		#dotnet remove $app_path/$app_name/src/$name.$service.Domain/$name.$service.Domain.csproj reference ./services/$folder/"$name.$service".Domain.Shared/"$name.$service".Domain.Shared.csproj
		#dotnet remove $app_path/$app_name/src/$name.$service.HttpApi.Host/$name.$service.HttpApi.Host.csproj reference  "..\$name.$service.Host.Shared\$name.$service.Host.Shared.csproj"

		Write-Output "Move-Item"
		Move-Item -Path "$app_path/$app_name/src/$app_name.Domain.Shared" -Destination "./$name/$app_shared/" -Force
		Move-Item -Path "$app_path/$app_name/src/$app_name.Application.Contracts" -Destination "./$name/$app_shared/" -Force
		Move-Item -Path "$app_path/$app_name/src/$app_name.HttpApi.Client" -Destination "./$name/$app_shared/" -Force
		
		Move-Item -Path $app_path/$app_name/src/$app_name.Blazor -Destination ./$name/$apps_path/$app_admin/ -Force
		Move-Item -Path $app_path/$app_name/src/$app_name.Blazor.Client -Destination ./$name/$apps_path/$app_admin/ -Force

		# For MVC
		# Copy-Item -Path "$app_path/$app_name/src/$app_name.HttpApi" -Destination "./$name/$app_shared/" -recurse -Force

		Write-Output "Add reference"
		dotnet add "$name/$app_shared/$app_name.Domain.Shared/$app_name.Domain.Shared.csproj" reference $name/$shared_common/$name.Shared.Common/$name.Shared.Common.csproj
		dotnet add $app_path/$app_name/src/$app_name.Domain/$app_name.Domain.csproj reference "$name/$app_shared/$app_name.Domain.Shared/$app_name.Domain.Shared.csproj"
		dotnet add $app_path/$app_name/src/$app_name.Application/$app_name.Application.csproj reference "$name/$app_shared/$app_name.Application.Contracts/$app_name.Application.Contracts.csproj"
		dotnet add $app_path/$app_name/src/$app_name.HttpApi/$app_name.HttpApi.csproj reference "$name/$app_shared/$app_name.Application.Contracts/$app_name.Application.Contracts.csproj"
		dotnet add $app_path/$app_name/src/$app_name.DbMigrator/$app_name.DbMigrator.csproj reference "$name/$app_shared/$app_name.Application.Contracts/$app_name.Application.Contracts.csproj"
		dotnet add $name/$apps_path/$app_admin/$app_name.Blazor.Client/$app_name.Blazor.Client.csproj reference "$name/$app_shared/$app_name.HttpApi.Client/$app_name.HttpApi.Client.csproj"
		dotnet add $app_path/$app_name/test/$app_name.HttpApi.Client.ConsoleTestApp/$app_name.HttpApi.Client.ConsoleTestApp.csproj reference "$name/$app_shared/$app_name.HttpApi.Client/$app_name.HttpApi.Client.csproj"

		#Copy-Item "$app_path/$app_name/$app_name.sln" ./$name/$apps_path/$app_admin/ -Force
		dotnet new sln -n "$app_name" -o ./$name/$apps_path/$app_admin
		#dotnet sln "./$name/$apps_path/$app_admin/$app_name.sln"  add --solution-folder shared (Get-ChildItem -r $name/$shared_common/$name.Shared.Common/**/*.csproj)
		dotnet sln "./$name/$apps_path/$app_admin/$app_name.sln"  add --solution-folder shared $name/$shared_common/$name.Shared.Common/$name.Shared.Common.csproj
		dotnet sln "./$name/$apps_path/$app_admin/$app_name.sln"  add --solution-folder shared (Get-ChildItem -r $name/$app_shared/**/*.csproj)
		dotnet sln "./$name/$apps_path/$app_admin/$app_name.sln"  add --solution-folder src (Get-ChildItem -r $name/$apps_path/$app_admin/**/*.csproj)

		dotnet sln "$app_path/$app_name/$app_name.sln"  add --solution-folder shared (Get-ChildItem -r $name/$shared_common/**/*.csproj)
		dotnet sln "$app_path/$app_name/$app_name.sln"  add --solution-folder shared (Get-ChildItem -r $name/$app_shared/**/*.csproj)			

	} else {		
		dotnet add $app_path/$app_name/src/$app_name.Domain.Shared reference $name/$shared_common/$name.Shared.Common/$name.Shared.Common.csproj
		dotnet sln "$app_path/$app_name/$app_name.sln"  add --solution-folder shared (Get-ChildItem -r $name/$shared_common/**/*.csproj)
		# Copy-Item -Path "./libs/Bamboo.Shared.Common/Extensions" -Destination $app_path/$app_name/src/$app_name.Domain.Shared/ -recurse -Force
		# Copy-Item -Path "./libs/Bamboo.Shared.Common/Guids" -Destination $app_path/$app_name/src/$app_name.Domain.Shared/ -recurse -Force
		# Copy-Item -Path "./libs/Bamboo.Shared.Common/Filter" -Destination $app_path/$app_name/src/$app_name.Domain.Shared/ -recurse -Force
		# Copy-Item -Path "./libs/Bamboo.Shared.Common/Utils" -Destination $app_path/$app_name/src/$app_name.Domain.Shared/ -recurse -Force
	}

	Write-Output "Add Extensions"
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
	dotnet add $app_path/$app_name/src/$name.AdminExtensions/$name.AdminExtensions.csproj package Volo.Abp.EventBus.Rebus -v $abpver
		
	Copy-Item -Path "./libs/Bamboo.LoginUi.Web" -Destination $app_path/$app_name/src/$name.LoginUi.Web -recurse -Force
	Move-Item -Path $app_path/$app_name/src/$name.LoginUi.Web/Bamboo.LoginUi.Web.csproj -Destination $app_path/$app_name/src/$name.LoginUi.Web/$name.LoginUi.Web.csproj -Force
	dotnet add $app_path/$app_name/src/$name.LoginUi.Web package Volo.Abp.Caching.StackExchangeRedis -v $abpver
	dotnet add $app_path/$app_name/src/$name.LoginUi.Web package Volo.Abp.DistributedLocking -v $abpver
	dotnet add $app_path/$app_name/src/$name.LoginUi.Web package Volo.Abp.Account.Web.OpenIddict -v $abpver
	dotnet add $app_path/$app_name/src/$name.LoginUi.Web package Volo.Abp.Account.HttpApi -v $abpver
	dotnet add $app_path/$app_name/src/$name.LoginUi.Web package Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared -v $abpver
	dotnet add $app_path/$app_name/src/$name.LoginUi.Web package Volo.Abp.Identity.Web -v $abpver
	dotnet add $app_path/$app_name/src/$name.LoginUi.Web package Volo.Abp.SettingManagement.Application -v $abpver
	dotnet add $app_path/$app_name/src/$name.LoginUi.Web package Volo.Abp.TenantManagement.Application -v $abpver
	dotnet add $app_path/$app_name/src/$name.LoginUi.Web package Volo.Abp.Sms -v $abpver

	if ($use_share -eq "True") {
		dotnet add $app_path/$app_name/src/$name.LoginUi.Web/$name.LoginUi.Web.csproj reference "$name/$app_shared/$app_name.Domain.Shared/$app_name.Domain.Shared.csproj"
		dotnet add $app_path/$app_name/src/$name.AdminExtensions/$name.AdminExtensions.csproj reference "$name/$app_shared/$app_name.Domain.Shared/$app_name.Domain.Shared.csproj"
	}
	#Copy-Item -Path "./libs/Bamboo.AdminExtensions" -Destination $app_path/$app_name/src/$name.AdminExtensions -recurse -Force
	#Copy-Item -Path "./libs/Bamboo.LoginUi.Web" -Destination $app_path/$app_name/src/$name.LoginUi.Web -recurse -Force
	
	
	Write-Output "PATH: $app_path/$app_name"

	dotnet sln "$app_path/$app_name/$app_name.sln" remove $app_path/$app_name/src/$app_name.Blazor/$app_name.Blazor.csproj
	dotnet sln "$app_path/$app_name/$app_name.sln" add (Get-ChildItem -r $app_path/$app_name/src/**/*.csproj)
	#dotnet sln "$app_path/$app_name/$app_name.sln" add --solution-folder src (Get-ChildItem -r $name/$shared_common/$name.Shared.Microservices/**/*.csproj)
	#dotnet sln "$app_path/$app_name/$app_name.sln" add --solution-folder src (Get-ChildItem -r $name/$shared_common/$name.Shared.Hosting/**/*.csproj)

	#dotnet sln "./$name/$services_path/$sln_admin.sln" add (Get-ChildItem -r $app_path/$app_name/src/**/*.csproj)	

	#dotnet add $app_path/$app_name/src/$name.AuthServer reference $app_path/$app_name/src/$name.AdminExtensions
	dotnet add $app_path/$app_name/src/$app_name.AuthServer reference $app_path/$app_name/src/$name.LoginUi.Web
	
	dotnet add $app_path/$app_name/src/$app_name.HttpApi.Host reference $app_path/$app_name/src/$name.AdminExtensions
	dotnet add $app_path/$app_name/src/$app_name.HttpApi.Host reference $app_path/$app_name/src/$name.LoginUi.Web
	dotnet add $app_path/$app_name/src/$app_name.HttpApi.Host package Rebus.ServiceProvider -v 10.1.2

	dotnet add $app_path/$app_name/src/$app_name.HttpApi.Host.Bundle reference $app_path/$app_name/src/$name.AdminExtensions
	dotnet add $app_path/$app_name/src/$app_name.HttpApi.Host.Bundle reference $app_path/$app_name/src/$name.LoginUi.Web
	dotnet add $app_path/$app_name/src/$app_name.HttpApi.Host.Bundle package Rebus.ServiceProvider -v 10.1.2

}

function CreateExtraApp  {

	if ($use_share -ne "True") {
		$app_shared = "$app_path/$app_name/src"
	}

	# MAUI
	# dotnet new mauiapp -f net8.0 --design-pattern Hybrid --razor-class-library --target-platform Desktop Mobile -n "Blazor.Maui" -o "$apps_path/maui"
	# dotnet new mauiapp -f net8.0 --design-pattern Hybrid --razor-class-library --target-platform Desktop Mobile -n "$name.Maui" -o "$name/$apps_path/maui"
	# dotnet new maui-blazor -n "Blazor.Maui" -o "$apps_path/maui"
	# dotnet new maui-blazor -n "$name.Maui" -o "$name/$apps_path/maui"
	#abp new "Bamboo.App" -t maui --no-open --no-random-port --database-provider ef -dbms PostgreSQL --create-solution-folder --skip-installing-libs --skip-bundling -o temp/Bamboo-maui
	#abp new "$name.App" -t maui --no-open --no-random-port --database-provider ef -dbms PostgreSQL  --separate-auth-server --skip-installing-libs -o $name/mobile/maui -v $abpver
	
	# No Layer application
	# abp new "Bamboo.Server" -t app-nolayers --no-open --no-random-port --database-provider ef -dbms PostgreSQL --create-solution-folder --skip-installing-libs -u none --skip-bundling -o Bamboo/apps
	# abp new "$name.Server" -t app-nolayers --no-open --no-random-port --database-provider ef -dbms PostgreSQL --create-solution-folder --skip-installing-libs -u none --skip-bundling -o $name/$services_path -v $abpver

	## Angular
	# abp new Bamboo -t app --no-open --no-random-port -u angular -m react-native --database-provider ef -dbms PostgreSQL --create-solution-folder --skip-installing-libs --skip-bundling --with-public-website -o temp/blazor-angular --pwa
	#abp new "$name" -t app --no-open --no-random-port -u angular -m react-native --database-provider ef -dbms PostgreSQL --create-solution-folder --separate-auth-server --skip-installing-libs -o temp/$name-angular -v $abpver
	#Move-Item -Path ./temp/$name-angular/$name/angular -Destination ./$name/$apps_path/angular/app -Force
	#Move-Item -Path ./temp/$name-angular/$name/react-native -Destination ./$name/mobile/ -Force

	## Blazor Client
	# abp new Bamboo -t app --no-open --no-random-port -u blazor -m none --database-provider ef -dbms PostgreSQL --create-solution-folder --skip-installing-libs --skip-bundling --with-public-website -o temp/blazor-client-bundle --pwa
	# abp new Bamboo -t app --no-open --no-random-port -u blazor -m none --database-provider ef -dbms PostgreSQL --create-solution-folder --separate-auth-server --skip-installing-libs --skip-bundling --with-public-website -o temp/blazor-client-tiered --pwa
	# abp new Bamboo -t app --no-open --no-random-port -u blazor -m none --database-provider ef -dbms SQLite --create-solution-folder --skip-installing-libs --skip-bundling --with-public-website -o temp/blazor-client-sqlite -v 8.0.1 --pwa

	abp new "$name" -t app --no-open --no-random-port -u blazor -m none --database-provider ef -dbms PostgreSQL --create-solution-folder --skip-installing-libs --skip-bundling -o temp/$name-blazor-client-bundle -v $abpver
	#Copy-Item -Path temp/$name-blazor-client-bundle/$name/src/$name.Blazor -Destination ./$name/$apps_path/"$name.Blazor" -recurse -Force
	#dotnet remove ./$name/$apps_path/$name.Blazor/$name.Blazor.csproj reference "..\..\src\$name.HttpApi.Client\$name.HttpApi.Client.csproj"
	#dotnet add ./$name/$apps_path/$name.Blazor/$name.Blazor.csproj reference $name/$app_shared/$app_name.HttpApi.Client/$app_name.HttpApi.Client.csproj
	#dotnet sln ./$name/$apps_path/$sln_webs.Blazor.sln add --solution-folder shared (Get-ChildItem -r $name/$shared_common/$name.Shared.Common/$name.Shared.Common.csproj)
	#dotnet sln ./$name/$apps_path/$sln_webs.Blazor.sln add --solution-folder shared (Get-ChildItem -r $name/$app_shared/$app_name.Domain.Shared/$app_name.Domain.Shared.csproj)
	#dotnet sln ./$name/$apps_path/$sln_webs.Blazor.sln add --solution-folder shared (Get-ChildItem -r $name/$app_shared/$app_name.Application.Contracts/$app_name.Application.Contracts.csproj)
	#dotnet sln ./$name/$apps_path/$sln_webs.Blazor.sln add --solution-folder shared (Get-ChildItem -r $name/$app_shared/$app_name.HttpApi.Client/$app_name.HttpApi.Client.csproj)
	#dotnet sln ./$name/$apps_path/$sln_webs.Blazor.sln add (Get-ChildItem -r ./$name/$apps_path/$name.Blazor/**/*.csproj)

	Write-Output "Create Blazor Wasm project"
	## Blazor --separate-identity-server
	abp new "$name" -t app --no-open --no-random-port -u blazor -m none --database-provider ef -dbms PostgreSQL --create-solution-folder --separate-auth-server --skip-installing-libs --skip-bundling --with-public-website -v $abpver -o temp/$name-blazor-client-tiered
	Copy-Item -Path temp/$name-blazor-client-tiered/$name/src/$name.Blazor -Destination ./$name/$apps_path/"$name.BlazorWasm" -recurse -Force
	Move-Item ./$name/$apps_path/$name.BlazorWasm/$name.Blazor.csproj -Destination "./$name/$apps_path/$name.BlazorWasm/$name.BlazorWasm.csproj" -Force
	Copy-Item -Path temp/$name-blazor-client-tiered/$name/src/$name.Blazor.Client -Destination ./$name/$apps_path/"$name.Blazor.Client" -recurse -Force
	dotnet remove ./$name/$apps_path/$name.Blazor.Client/$name.Blazor.Client.csproj reference "..\..\src\$name.HttpApi.Client\$name.HttpApi.Client.csproj"
	dotnet add ./$name/$apps_path/$name.Blazor.Client/$name.Blazor.Client.csproj reference $name/$app_shared/$app_name.HttpApi.Client/$app_name.HttpApi.Client.csproj

	#Copy-Item -Path $app_path/$app_name/src/$app_name.Blazor -Destination ./$name/$apps_path/"$name.Blazor" -recurse -Force
	#Move-Item -Path $app_path/$app_name/src/$app_name.HttpApi.Saas.Host/$name.HttpApi.Host.csproj -Destination $app_path/$app_name/src/"$name.HttpApi.Saas.Host.csproj" -Force
	dotnet sln ./$name/$apps_path/$sln_webs.Blazor.sln add --solution-folder shared (Get-ChildItem -r $name/$shared_common/$name.Shared.Common/$name.Shared.Common.csproj)
	dotnet sln ./$name/$apps_path/$sln_webs.Blazor.sln add --solution-folder shared (Get-ChildItem -r $name/$app_shared/$app_name.Domain.Shared/$app_name.Domain.Shared.csproj)
	dotnet sln ./$name/$apps_path/$sln_webs.Blazor.sln add --solution-folder shared (Get-ChildItem -r $name/$app_shared/$app_name.Application.Contracts/$app_name.Application.Contracts.csproj)
	dotnet sln ./$name/$apps_path/$sln_webs.Blazor.sln add --solution-folder shared (Get-ChildItem -r $name/$app_shared/$app_name.HttpApi.Client/$app_name.HttpApi.Client.csproj)
	dotnet sln ./$name/$apps_path/$sln_webs.Blazor.sln add (Get-ChildItem -r ./$name/$apps_path/$name.Blazor.Client/**/*.csproj)
	dotnet sln ./$name/$apps_path/$sln_webs.Blazor.sln add (Get-ChildItem -r ./$name/$apps_path/$name.BlazorWasm/**/*.csproj)


	Write-Output "Create Blazor WebApp project"
	## Blazor Web-App
	# abp new "Bamboo" -t app --no-open --no-random-port -u blazor-webapp -m none --database-provider ef -dbms PostgreSQL --create-solution-folder --skip-installing-libs --skip-bundling --with-public-website -o temp/blazor-webapp-bundle --pwa
	# abp new "Bamboo" -t app --no-open --no-random-port -u blazor-webapp -m none --tiered --database-provider ef -dbms PostgreSQL --create-solution-folder --skip-installing-libs --skip-bundling --with-public-website -o temp/blazor-webapp-tiered --pwa
	# abp new "$name" -t app --no-open --no-random-port -u blazor-webapp -m none --database-provider ef -dbms PostgreSQL --create-solution-folder --skip-installing-libs -o temp/$name-blazor-webapp-bundle -v $abpver

	abp new "$name" -t app --no-open --no-random-port -u blazor-webapp -m none --tiered --database-provider ef -dbms PostgreSQL --create-solution-folder --skip-installing-libs -o temp/$name-blazor-webapp-tiered -v $abpver
	Copy-Item -Path temp/$name-blazor-webapp-tiered/$name/src/$name.Blazor -Destination ./$name/$apps_path/"$name.BlazorWebApp" -recurse -Force
	Move-Item ./$name/$apps_path/$name.BlazorWebApp/$name.Blazor.csproj -Destination "./$name/$apps_path/$name.BlazorWebApp/$name.BlazorWebApp.csproj" -Force
	dotnet remove ./$name/$apps_path/$name.BlazorWebApp/$name.BlazorWebApp.csproj reference "..\$name.HttpApi.Client\$name.HttpApi.Client.csproj"
	dotnet add ./$name/$apps_path/$name.BlazorWebApp/$name.BlazorWebApp.csproj reference $name/$app_shared/$app_name.HttpApi.Client/$app_name.HttpApi.Client.csproj
	dotnet sln ./$name/$apps_path/$sln_webs.Blazor.sln add (Get-ChildItem -r ./$name/$apps_path/$name.BlazorWebApp/**/*.csproj)

	Write-Output "Create Blazor Server"
	## Blazor Server
	# abp new "Bamboo" -t app --no-open --no-random-port -u blazor-server -m none --database-provider ef -dbms PostgreSQL --create-solution-folder --skip-installing-libs --with-public-website -o temp/blazor-server-bundle 
	# abp new "Bamboo" -t app --no-open --no-random-port -u blazor-server -m none --tiered --database-provider ef -dbms PostgreSQL --create-solution-folder --skip-installing-libs --with-public-website -o temp/blazor-server-tiered 
	abp new "$name" -t app --no-open --no-random-port -u blazor-server -m none --tiered --database-provider ef -dbms PostgreSQL --create-solution-folder --skip-installing-libs --with-public-website -o temp/$name-blazor-server-tiered -v $abpver
	Copy-Item -Path ./temp/$name-blazor-server-tiered/$name/src/$name.Blazor -Destination ./$name/$apps_path/$name.BlazorServer -recurse -Force
	dotnet remove ./$name/$apps_path/$name.BlazorServer/$name.Blazor.csproj reference "..\$name.HttpApi.Client\$name.HttpApi.Client.csproj"
	dotnet add ./$name/$apps_path/$name.BlazorServer/$name.Blazor.csproj reference $name/$app_shared/$app_name.HttpApi.Client/$app_name.HttpApi.Client.csproj	
	Move-Item ./$name/$apps_path/$name.BlazorServer/$name.Blazor.csproj -Destination "./$name/$apps_path/$name.BlazorServer/$name.BlazorServer.csproj" -Force
	dotnet sln ./$name/$apps_path/$sln_webs.BlazorServer.sln add --solution-folder shared (Get-ChildItem -r $name/$shared_common/$name.Shared.Common/$name.Shared.Common.csproj)
	dotnet sln ./$name/$apps_path/$sln_webs.BlazorServer.sln add --solution-folder shared (Get-ChildItem -r $name/$app_shared/$app_name.Domain.Shared/$app_name.Domain.Shared.csproj)
	dotnet sln ./$name/$apps_path/$sln_webs.BlazorServer.sln add --solution-folder shared (Get-ChildItem -r $name/$app_shared/$app_name.Application.Contracts/$app_name.Application.Contracts.csproj)
	dotnet sln ./$name/$apps_path/$sln_webs.BlazorServer.sln add --solution-folder shared (Get-ChildItem -r $name/$app_shared/$app_name.HttpApi.Client/$app_name.HttpApi.Client.csproj)
	dotnet sln ./$name/$apps_path/$sln_webs.BlazorServer.sln add (Get-ChildItem -r ./$name/$apps_path/$name.BlazorServer/**/*.csproj)
	dotnet sln ./$name/$apps_path/$sln_webs.Blazor.sln add (Get-ChildItem -r ./$name/$apps_path/$name.BlazorServer/**/*.csproj)	

	Write-Output "Create MVC project"
	## MVC
	# abp new "Bamboo" -t app --no-open --no-random-port -u mvc -m none --tiered --database-provider ef -dbms PostgreSQL --create-solution-folder --with-public-website -o ./temp/mvc --skip-installing-libs
	abp new "$name" -t app --no-open --no-random-port -u mvc -m none --tiered --database-provider ef -dbms PostgreSQL --create-solution-folder --skip-installing-libs -o ./temp/$name-mvc-tiered -v $abpver
	Copy-Item -Path ./temp/$name-mvc-tiered/$name/src/$name.Web -Destination ./$name/$apps_path/ -recurse -Force
	dotnet remove ./$name/$apps_path/$name.Web/$name.Web.csproj reference "..\$name.HttpApi.Client\$name.HttpApi.Client.csproj"
	dotnet remove ./$name/$apps_path/$name.Web/$name.Web.csproj reference "..\$name.HttpApi\$name.HttpApi.csproj"	
	dotnet add ./$name/$apps_path/$name.Web/$name.Web.csproj reference $name/$app_shared/$app_name.HttpApi.Client/$app_name.HttpApi.Client.csproj
	#dotnet add ./$name/$apps_path/$name.Web/$name.Web.csproj reference $name/$app_shared/$app_name.Domain.Shared/$app_name.Domain.Shared.csproj
	#dotnet add ./$name/$apps_path/$name.Web/$name.Web.csproj reference $name/$app_shared/$app_name.HttpApi/$app_name.HttpApi.csproj
	#dotnet add ./$name/$apps_path/$name.Web/$name.Web.csproj reference $app_path/$app_name/src/$name.HttpApi/$name.HttpApi.csproj
	dotnet sln ./$name/$apps_path/$sln_webs.MVC.sln add --solution-folder shared (Get-ChildItem -r $name/$shared_common/$name.Shared.Common/$name.Shared.Common.csproj)
	dotnet sln ./$name/$apps_path/$sln_webs.MVC.sln add --solution-folder shared (Get-ChildItem -r $name/$app_shared/$app_name.Domain.Shared/$app_name.Domain.Shared.csproj)
	dotnet sln ./$name/$apps_path/$sln_webs.MVC.sln add --solution-folder shared (Get-ChildItem -r $name/$app_shared/$app_name.Application.Contracts/$app_name.Application.Contracts.csproj)
	dotnet sln ./$name/$apps_path/$sln_webs.MVC.sln add --solution-folder shared (Get-ChildItem -r $name/$app_shared/$app_name.HttpApi.Client/$app_name.HttpApi.Client.csproj)
	dotnet sln ./$name/$apps_path/$sln_webs.MVC.sln add (Get-ChildItem -r ./$name/$apps_path/$name.Web/**/*.csproj)
	
	# MVC use 
	#dotnet sln ./$name/$apps_path/$sln_webs.MVC.sln add --solution-folder shared (Get-ChildItem -r $name/$app_shared/$name.HttpApi/$name.HttpApi.csproj)
	#dotnet sln ./$name/$apps_path/$sln_webs.MVC.sln add --solution-folder shared (Get-ChildItem -r $app_path/$app_name/src/$app_name.HttpApi/$app_name.HttpApi.csproj)
	#dotnet sln "./$name/$apps_path/$sln_webs.sln" add (Get-ChildItem -r ./$services_path/$name/src/$name.Domain/$name.Domain.csproj)
	#dotnet sln "./$name/$apps_path/$sln_webs.sln" add (Get-ChildItem -r ./$services_path/$name/src/$name.Application/$name.Application.csproj)
	
	## Un-comment to use Newtonsoft.Json and Volo.Abp.Guids at client side
	#dotnet add ./$name/$apps_path/$name.Blazor/$name.Blazor.csproj package Newtonsoft.Json -v $ntsver
	#dotnet add ./$name/$apps_path/$name.Blazor/$name.Blazor.csproj package Volo.Abp.Guids -v $abpver
	#dotnet add ./$name/$apps_path/$name.BlazorServer/$name.Blazor.csproj package Newtonsoft.Json -v $ntsver
	#dotnet add ./$name/$apps_path/$name.BlazorServer/$name.BlazorServer.csproj package Volo.Abp.Guids -v $abpver
	#dotnet add ./$name/$apps_path/$name.Web/$name.Web.csproj package Newtonsoft.Json -v $ntsver
	#dotnet add ./$name/$apps_path/$name.Web/$name.Web.csproj package Volo.Abp.Guids -v $abpver

	Write-Output "Add other reference"
	dotnet add ./$name/$apps_path/$name.Blazor.Client/$name.Blazor.Client.csproj reference $name/$shared_common/$name.Shared.Common/$name.Shared.Common.csproj
	dotnet add ./$name/$apps_path/$name.BlazorServer/$name.BlazorServer.csproj reference $name/$shared_common/$name.Shared.Common/$name.Shared.Common.csproj
	dotnet add ./$name/$apps_path/$name.Web/$name.Web.csproj reference $name/$shared_common/$name.Shared.Common/$name.Shared.Common.csproj
	dotnet sln ./$name/$apps_path/$sln_webs.Blazor.sln add --solution-folder shared $name/$shared_common/$name.Shared.Common/$name.Shared.Common.csproj
	dotnet sln ./$name/$apps_path/$sln_webs.BlazorServer.sln add --solution-folder shared $name/$shared_common/$name.Shared.Common/$name.Shared.Common.csproj
	dotnet sln ./$name/$apps_path/$sln_webs.MVC.sln add --solution-folder shared $name/$shared_common/$name.Shared.Common/$name.Shared.Common.csproj
	
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
	#abp add-module Volo.AuditLogging -s "./$services_path/$sln_admin.sln" --skip-db-migrations
	#abp add-module Volo.FeatureManagement -s "./$services_path/$sln_admin.sln" --skip-db-migrations
	#abp add-module Volo.PermissionManagement -s "./$services_path/$sln_admin.sln" --skip-db-migrations
	#abp add-module Volo.SettingManagement -s "./$services_path/$sln_admin.sln" --skip-db-migrations
	#abp add-module Volo.Identity -s "./$services_path/$sln_admin.sln" --skip-db-migrations
	#abp add-module Volo.OpenIddict -s "./$services_path/$sln_admin.sln" --skip-db-migrations
	#abp add-module Volo.TenantManagement -s "./$services_path/$sln_admin.sln" --skip-db-migrations
}

CreatePath
#CreateCoreLibs
#CreateGateways
#CreateCoreApp
CreateExtraApp

cmd /c pause
