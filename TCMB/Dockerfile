FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["TCMB/TCMB.csproj", "TCMB/"]
RUN dotnet restore "TCMB/TCMB.csproj"
COPY . .
WORKDIR "/src/TCMB"
RUN dotnet build "TCMB.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TCMB.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TCMB.dll"]
