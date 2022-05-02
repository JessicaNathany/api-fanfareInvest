#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/api-fanfareInvest.api/api-fanfareInvest.api.csproj", "src/api-fanfareInvest.api/"]
RUN dotnet restore "src/api-fanfareInvest.api/api-fanfareInvest.api.csproj"
COPY . .
WORKDIR "/src/src/api-fanfareInvest.api"
RUN dotnet build "api-fanfareInvest.api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "api-fanfareInvest.api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "api-fanfareInvest.api.dll"]