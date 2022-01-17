FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

ENV ASPNETCORE_ENVIRONMENT=Development

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["authAPI/authAPI.csproj", "authAPI/"]
RUN dotnet restore "authAPI/authAPI.csproj"
COPY . .
WORKDIR "/src/authAPI"
RUN dotnet build "authAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "authAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "authAPI.dll"]