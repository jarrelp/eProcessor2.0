#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/Services/Fetch/Fetch.API/Fetch.API.csproj", "src/Services/Fetch/Fetch.API/"]
COPY ["src/Services/Fetch/Fetch.Application/Fetch.Application.csproj", "src/Services/Fetch/Fetch.Application/"]
COPY ["src/BuildingBlocks/BuildingBlocks/BuildingBlocks.csproj", "src/BuildingBlocks/BuildingBlocks/"]
COPY ["src/Services/Fetch/Fetch.Domain/Fetch.Domain.csproj", "src/Services/Fetch/Fetch.Domain/"]
COPY ["src/Services/Fetch/Fetch.Infrastructure/Fetch.Infrastructure.csproj", "src/Services/Fetch/Fetch.Infrastructure/"]
RUN dotnet restore "./src/Services/Fetch/Fetch.API/./Fetch.API.csproj"
COPY . .
WORKDIR "/src/src/Services/Fetch/Fetch.API"
RUN dotnet build "./Fetch.API.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Fetch.API.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Fetch.API.dll"]