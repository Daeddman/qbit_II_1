FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["A0 A2 A4/A0 A2 A4.csproj", "A0 A2 A4/"]
RUN dotnet restore "A0 A2 A4/A0 A2 A4.csproj"
COPY . .
WORKDIR "/src/A0 A2 A4"
RUN dotnet build "A0 A2 A4.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "A0 A2 A4.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "A0 A2 A4.dll"]
