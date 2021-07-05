FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Bilbayt.Web.Api.csproj", "Bilbayt.Web.Api/"]
RUN dotnet restore "Bilbayt.Web.Api/Bilbayt.Web.Api.csproj"
COPY . .
WORKDIR "/src/Bilbayt.Web.Api"
RUN dotnet build "Bilbayt.Web.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Bilbayt.Web.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Bilbayt.Web.Api.dll"]
