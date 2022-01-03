FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Mapping.Console/Mapping.Console.csproj", "Mapping.Console/"]
RUN dotnet restore "Mapping.Console/Mapping.Console.csproj"
COPY . .
WORKDIR "/src/Mapping.Console"
RUN dotnet build "Mapping.Console.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Mapping.Console.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Mapping.Console.dll"]
