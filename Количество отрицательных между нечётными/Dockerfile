FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Количество отрицательных между нечётными/Количество отрицательных между нечётными.csproj", "Количество отрицательных между нечётными/"]
RUN dotnet restore "Количество отрицательных между нечётными/Количество отрицательных между нечётными.csproj"
COPY . .
WORKDIR "/src/Количество отрицательных между нечётными"
RUN dotnet build "Количество отрицательных между нечётными.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "Количество отрицательных между нечётными.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Количество отрицательных между нечётными.dll"]
