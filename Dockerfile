# .NET Core SDK
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

# Sets the working directory
WORKDIR /app

# Copy Projects
#COPY *.sln .
COPY src/Infrastructure.CrossCutting/Infrastructure.CrossCutting.csproj ./Infrastructure.CrossCutting/
COPY src/Infrastructure.Data/Infrastructure.Data.csproj ./Infrastructure.Data/
COPY src/MyCleanArchitecture.API/MyCleanArchitecture.API.csproj ./MyCleanArchitecture.API/
COPY src/MyCleanArchitecture.Application/MyCleanArchitecture.Application.csproj ./MyCleanArchitecture.Application/
COPY src/MyCleanArchitecture.Domain/MyCleanArchitecture.Domain.csproj ./MyCleanArchitecture.Domain/
COPY src/MyCleanArchitecture.DomainShare/MyCleanArchitecture.DomainShare.csproj ./MyCleanArchitecture.DomainShare/

# .NET Core Restore
RUN dotnet restore ./MyCleanArchitecture.API/MyCleanArchitecture.API.csproj

# Copy All Files
COPY src ./

# .NET Core Build and Publish
RUN dotnet publish ./MyCleanArchitecture.API/MyCleanArchitecture.API.csproj -c Release -o /publish

# ASP.NET Core Runtime
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS runtime
WORKDIR /app
COPY --from=build /publish ./
ENTRYPOINT ["dotnet", "MyCleanArchitecture.API.dll"]