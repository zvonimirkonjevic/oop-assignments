FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["OOP_ZAD4_ConsoleApp/OOP_ZAD4_ConsoleApp.csproj", "OOP_ZAD4_ConsoleApp/"]
RUN dotnet restore "OOP_ZAD4_ConsoleApp/OOP_ZAD4_ConsoleApp.csproj"
COPY . .
WORKDIR "/src/OOP_ZAD4_ConsoleApp"
RUN dotnet build "OOP_ZAD4_ConsoleApp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "OOP_ZAD4_ConsoleApp.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "OOP_ZAD4_ConsoleApp.dll"]
