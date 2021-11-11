FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

ENV ASPNETCORE_ENVIRONMENT=Development

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["saAPI/saAPI.csproj", "saAPI/"]
RUN dotnet restore "saAPI/saAPI.csproj"
COPY . .
WORKDIR "/src/saAPI"
RUN dotnet build "saAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "saAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "saAPI.dll"]