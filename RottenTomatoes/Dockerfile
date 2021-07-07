FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["RottenTomatoes/RottenTomatoes.csproj", "RottenTomatoes/"]
RUN dotnet restore "RottenTomatoes/RottenTomatoes.csproj"
COPY . .
WORKDIR "/src/RottenTomatoes"
RUN dotnet build "RottenTomatoes.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "RottenTomatoes.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "RottenTomatoes.dll"]
