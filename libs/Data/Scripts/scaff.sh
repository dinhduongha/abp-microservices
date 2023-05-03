#!/bin/sh
APP="Bamboo"
MOD="Core"

FOLDER="$APP"."$MOD"

dotnet ef dbcontext scaffold 'Host=127.0.0.1; Port=5432;Database=odoo_uuid;User ID=postgres;Password=password;' "Npgsql.EntityFrameworkCore.PostgreSQL" --namespace "$APP"."$MOD".Entities -o ../"$APP"."$MOD".Domain/Entities -c "$MOD"DbContext --startup-project host/"$APP"."$MOD".HttpApi.Host/"$APP"."$MOD".HttpApi.Host.csproj --project src/"$APP"."$MOD".EntityFrameworkCore/"$APP"."$MOD".EntityFrameworkCore.csproj --context-dir "$MOD"DbContext --force --data-annotations

