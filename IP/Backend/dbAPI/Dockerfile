FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

ENV ASPNETCORE_ENVIRONMENT=Development

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["dbAPI/dbAPI.csproj", "dbAPI/"]
RUN dotnet restore "dbAPI/dbAPI.csproj"
COPY . .
WORKDIR "/src/dbAPI"
RUN dotnet build "dbAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "dbAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "dbAPI.dll"]