#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

FROM node:latest AS node_base

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
COPY --from=node_base . .

WORKDIR /src
COPY ["TroubleShooting-AspNet.csproj", "."]
RUN dotnet restore "TroubleShooting-AspNet.csproj"
COPY . .

WORKDIR "/src/"
RUN dotnet build "TroubleShooting-AspNet.csproj" -c Release -o /app/build


FROM build AS publish
RUN dotnet publish "TroubleShooting-AspNet.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app

COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TroubleShooting-AspNet.dll"]

