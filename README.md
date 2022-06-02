# MyCleanArchitecture

# Update database
dotnet ef database update initial -p ./Infrastructure.Data -s ./MyCleanArchitecture.API

# Add Migration
dotnet ef migrations add initial -p ./Infrastructure.Data -s ./MyCleanArchitecture.API
