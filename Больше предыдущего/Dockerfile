FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Больше предыдущего/Больше предыдущего.csproj", "Больше предыдущего/"]
RUN dotnet restore "Больше предыдущего/Больше предыдущего.csproj"
COPY . .
WORKDIR "/src/Больше предыдущего"
RUN dotnet build "Больше предыдущего.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "Больше предыдущего.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Больше предыдущего.dll"]
