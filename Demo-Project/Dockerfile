#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["../Demo-Project/DemoProject.Web.csproj", "/Demo-Project/"]
COPY ["../Demo-Project.Services/Demo-Project.Services.csproj", "/Demo-Project.Services/"]
COPY ["../Demo-Project.Repository/Demo-Project.Repository.csproj", "../Demo-Project.Repository/"]
COPY ["../Demo-Project.Domain/Demo-Project.Domain.csproj", "../Demo-Project.Domain/"]
COPY . .
RUN dotnet restore "/Demo-Project/DemoProject.Web.csproj"

WORKDIR "/src/Demo-Project/"
RUN dotnet build "DemoProject.Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DemoProject.Web.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DemoProject.Web.dll"]