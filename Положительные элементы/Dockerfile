FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Положительные элементы/Положительные элементы.csproj", "Положительные элементы/"]
RUN dotnet restore "Положительные элементы/Положительные элементы.csproj"
COPY . .
WORKDIR "/src/Положительные элементы"
RUN dotnet build "Положительные элементы.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "Положительные элементы.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Положительные элементы.dll"]
