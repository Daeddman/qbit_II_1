FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Чётные и нечётные/Чётные и нечётные.csproj", "Чётные и нечётные/"]
RUN dotnet restore "Чётные и нечётные/Чётные и нечётные.csproj"
COPY . .
WORKDIR "/src/Чётные и нечётные"
RUN dotnet build "Чётные и нечётные.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "Чётные и нечётные.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Чётные и нечётные.dll"]
