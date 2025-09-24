FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /src
COPY ["src/ErwaaSystem.Web.Host/ErwaaSystem.Web.Host.csproj", "src/ErwaaSystem.Web.Host/"]
COPY ["src/ErwaaSystem.Web.Core/ErwaaSystem.Web.Core.csproj", "src/ErwaaSystem.Web.Core/"]
COPY ["src/ErwaaSystem.Application/ErwaaSystem.Application.csproj", "src/ErwaaSystem.Application/"]
COPY ["src/ErwaaSystem.Core/ErwaaSystem.Core.csproj", "src/ErwaaSystem.Core/"]
COPY ["src/ErwaaSystem.EntityFrameworkCore/ErwaaSystem.EntityFrameworkCore.csproj", "src/ErwaaSystem.EntityFrameworkCore/"]
WORKDIR "/src/src/ErwaaSystem.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/ErwaaSystem.Web.Host", "src/ErwaaSystem.Web.Host"]
COPY ["src/ErwaaSystem.Web.Core", "src/ErwaaSystem.Web.Core"]
COPY ["src/ErwaaSystem.Application", "src/ErwaaSystem.Application"]
COPY ["src/ErwaaSystem.Core", "src/ErwaaSystem.Core"]
COPY ["src/ErwaaSystem.EntityFrameworkCore", "src/ErwaaSystem.EntityFrameworkCore"]
WORKDIR "/src/src/ErwaaSystem.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:8.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "ErwaaSystem.Web.Host.dll"]
