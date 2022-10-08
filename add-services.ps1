$name = $args[0]

$ver = "6.0.0"
$services = @{}
#$services.Add('Administration', 'administration')
$services.Add('Logging', 'logging')
$services.Add('Notification', 'notification')
$services.Add('Kyc', 'kyc')

$sln_service = "$name.Services.All"
$shared_common = "shared/common"
foreach($service in $services.keys)
{
	$folder = $services[$service]
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
	dotnet add ./services/$folder/host/$name.$service.DbMigrator/$name.$service.DbMigrator.csproj package Volo.Abp.Autofac -v $ver	
	dotnet add ./services/$folder/host/$name.$service.DbMigrator/$name.$service.DbMigrator.csproj package Volo.Abp.BackgroundJobs -v $ver
	dotnet add ./services/$folder/host/$name.$service.DbMigrator/$name.$service.DbMigrator.csproj package Volo.Abp.Identity.Domain -v $ver
	dotnet add ./services/$folder/host/$name.$service.DbMigrator/$name.$service.DbMigrator.csproj package Volo.Abp.TenantManagement.Domain -v $ver	
	dotnet add ./services/$folder/host/$name.$service.DbMigrator/$name.$service.DbMigrator.csproj reference ./services/$folder/src/$name.$service.Application.Contracts/$name.$service.Application.Contracts.csproj	
	dotnet add ./services/$folder/host/$name.$service.DbMigrator/$name.$service.DbMigrator.csproj reference ./services/$folder/src/$name.$service.EntityFrameworkCore/$name.$service.EntityFrameworkCore.csproj
	Copy-Item -Path "./libs/Bamboo.Shared.DbMigrator/*" -Destination ./services/$folder/host/$name.$service.DbMigrator/ -recurse -Force
	
	#dotnet sln "./services/$folder/$name.$service.sln" remove (Get-ChildItem -r ./services/$folder/host/$name.$service.Host.Shared/$name.$service.Host.Shared.csproj)
	dotnet sln "./services/$folder/$name.$service.sln" remove (Get-ChildItem -r ./services/$folder/host/$name.$service.AuthServer/$name.$service.AuthServer.csproj)
	dotnet sln "./services/$folder/$name.$service.sln" remove (Get-ChildItem -r ./services/$folder/src/$name.$service.Installer/$name.$service.Installer.csproj)
	dotnet sln "./services/$folder/$name.$service.sln" remove (Get-ChildItem -r ./services/$folder/src/$name.$service.MongoDB/$name.$service.MongoDB.csproj)
	dotnet sln "./services/$folder/$name.$service.sln" remove (Get-ChildItem -r ./services/$folder/test/$name.$service.MongoDB.Tests/$name.$service.MongoDB.Tests.csproj)
	
	#Remove-Item -Recurse -Force (Get-ChildItem -r **/*.$service.Host.Shared)
	Remove-Item -Recurse -Force (Get-ChildItem -r ./services/**/*.$service.AuthServer)
	Remove-Item -Recurse -Force (Get-ChildItem -r ./services/**/*.$service.Installer)
	Remove-Item -Recurse -Force (Get-ChildItem -r ./services/**/*.$service.MongoDB)
	Remove-Item -Recurse -Force (Get-ChildItem -r ./services/**/*.$service.MongoDB.Tests)

	dotnet sln "./services/$folder/$name.$service.sln" add --solution-folder shared (Get-ChildItem -r ./$shared_common/**/*.csproj)
	dotnet sln "./services/$folder/$name.$service.sln" add --solution-folder host ./services/$folder/host/$name.$service.DbMigrator/$name.$service.DbMigrator.csproj		
	dotnet sln "./services/$sln_service.sln" add (Get-ChildItem -r ./services/$folder/**/*.csproj)

}

cmd /c pause
