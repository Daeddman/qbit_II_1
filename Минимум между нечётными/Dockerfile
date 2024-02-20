FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Минимум между нечётными/Минимум между нечётными.csproj", "Минимум между нечётными/"]
RUN dotnet restore "Минимум между нечётными/Минимум между нечётными.csproj"
COPY . .
WORKDIR "/src/Минимум между нечётными"
RUN dotnet build "Минимум между нечётными.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "Минимум между нечётными.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Минимум между нечётными.dll"]
