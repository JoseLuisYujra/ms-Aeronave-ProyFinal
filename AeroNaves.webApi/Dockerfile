#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["AeroNaves.webApi/AeroNaves.webApi.csproj", "AeroNaves.webApi/"]
COPY ["Aeronave.Infraestructure/Aeronaves.Infraestructure.csproj", "Aeronave.Infraestructure/"]
COPY ["Aeronaves.Aplication/Aeronaves.Aplication.csproj", "Aeronaves.Aplication/"]
COPY ["Aeronaves.Domain/Aeronaves.Domain.csproj", "Aeronaves.Domain/"]
RUN dotnet restore "AeroNaves.webApi/AeroNaves.webApi.csproj"
COPY . .
WORKDIR "/src/AeroNaves.webApi"
RUN dotnet build "AeroNaves.webApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AeroNaves.webApi.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AeroNaves.webApi.dll"]