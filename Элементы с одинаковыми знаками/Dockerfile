FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Элементы с одинаковыми знаками/Элементы с одинаковыми знаками.csproj", "Элементы с одинаковыми знаками/"]
RUN dotnet restore "Элементы с одинаковыми знаками/Элементы с одинаковыми знаками.csproj"
COPY . .
WORKDIR "/src/Элементы с одинаковыми знаками"
RUN dotnet build "Элементы с одинаковыми знаками.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "Элементы с одинаковыми знаками.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Элементы с одинаковыми знаками.dll"]
