FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["Unians.Course.Api/Unians.Course.Api.csproj", "Unians.Course.Api/"]
RUN dotnet restore "Unians.Course.Api/Unians.Course.Api.csproj"
COPY . .
WORKDIR "/src/Unians.Course.Api"
RUN dotnet build "Unians.Course.Api.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Unians.Course.Api.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Unians.Course.Api.dll"]