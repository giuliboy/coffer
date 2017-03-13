#!/usr/bin/env bash
dotnet restore
dotnet test ./CofferTest/CofferTest -c Release -f netcoreapp1.0
dotnet build **/project.json
 
