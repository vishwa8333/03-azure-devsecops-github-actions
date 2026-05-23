FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY src/DevSecOps.Api.csproj src/
RUN dotnet restore src/DevSecOps.Api.csproj
COPY src/ src/
RUN dotnet publish src/DevSecOps.Api.csproj -c Release -o /app

FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app .
EXPOSE 8080
ENTRYPOINT ["dotnet", "DevSecOps.Api.dll"]

