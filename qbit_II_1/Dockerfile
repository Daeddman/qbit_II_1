FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["qbit_II_1/qbit_II_1.csproj", "qbit_II_1/"]
RUN dotnet restore "qbit_II_1/qbit_II_1.csproj"
COPY . .
WORKDIR "/src/qbit_II_1"
RUN dotnet build "qbit_II_1.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "qbit_II_1.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "qbit_II_1.dll"]
