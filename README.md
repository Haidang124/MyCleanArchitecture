# MyCleanArchitecture

# Update database

cd src
dotnet ef database update init1 -p ./Infrastructure.Data -s ./MyCleanArchitecture.API

# Add Migration

cd src
dotnet ef migrations add init1 -p ./Infrastructure.Data -s ./MyCleanArchitecture.API
