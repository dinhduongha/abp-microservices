# Introduction

Init ABP Framework micro-services application, powershell scripts. 

The project is inspired by:
* https://github.com/abpframework/eShopOnAbp

* https://github.com/antosubash/abp-setup

# Features

  * PostgreSQL
  * Micro-services
  * API Gateway
  * Sortable UUID, compatible with ULID
  * ABP v6
  * UI
    * Blazor
    * Blazor Server
    * MVC  

# How-to

* Create new ABP Application

    ```./init.ps1 YourProjectName```

then copy libs/global.json to YourProjectName
* Add services

    Edit add-services.ps1, add more micro-services as you want. For examle:
    
    ```
        $services.Add('Logging', 'logging')
        $services.Add('Notification', 'notification')
        $services.Add('Kyc', 'kyc')
    ```
    then run:
    
    ```./add-services.ps1```
    
  # Solutions structure
  
  * account/*.Account.sln: Main solution, manage users, settings, tenants
  * services/*.Services.All.sln: All micro-services
  * gateways/*.Gateway.sln: API Gateway
  * web_apps/*.Web.sln: Client UI application, include Blazor, BlazorServer and MVC
  * shared: Common shared projects for all micro-serivces
