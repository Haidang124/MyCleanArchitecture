FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS runtime
WORKDIR /app
COPY out/ ./
ENTRYPOINT ["dotnet", "MyCleanArchitecture.API.dll"]