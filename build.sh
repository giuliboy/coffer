#!/usr/bin/env bash
dotnet test ./CofferTest/CofferTest.csproj -c Release -f netcoreapp1.0
dotnet restore && dotnet build **/project.json
 
