FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Количество нулей между максимумом и минимумом/Количество нулей между максимумом и минимумом.csproj", "Количество нулей между максимумом и минимумом/"]
RUN dotnet restore "Количество нулей между максимумом и минимумом/Количество нулей между максимумом и минимумом.csproj"
COPY . .
WORKDIR "/src/Количество нулей между максимумом и минимумом"
RUN dotnet build "Количество нулей между максимумом и минимумом.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "Количество нулей между максимумом и минимумом.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Количество нулей между максимумом и минимумом.dll"]
