FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["OOP_ConsoleApp/OOP_ConsoleApp.csproj", "OOP_ConsoleApp/"]
RUN dotnet restore "OOP_ConsoleApp/OOP_ConsoleApp.csproj"
COPY . .
WORKDIR "/src/OOP_ConsoleApp"
RUN dotnet build "OOP_ConsoleApp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "OOP_ConsoleApp.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "OOP_ConsoleApp.dll"]
