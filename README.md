# MyCleanArchitecture

# Update database
dotnet ef database update init1 -p ./Infrastructure.Data -s ./MyCleanArchitecture.API

# Add Migration
dotnet ef migrations add init1 -p ./Infrastructure.Data -s ./MyCleanArchitecture.API
