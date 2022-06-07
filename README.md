# MyCleanArchitecture

# Update database

dotnet ef database update initial -p ./Infrastructure.Data -s ./MyCleanArchitecture.API

# Add Migration

dotnet ef migrations add initial -p ./Infrastructure.Data -s ./MyCleanArchitecture.API

# docker

docker run --rm -p 5000:80 -p 5001:443 -e ASPNETCORE_HTTPS_PORT=https://+:5001 -e ASPNETCORE_URLS=http://+:5000 mycleanarchitecture/dotnet

docker build -t mycleanarchitecture/dotnet .

docker run --rm -p 5031:80 mycleanarchitecture/dotnet
