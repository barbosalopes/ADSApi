FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["ADS/ADS.csproj", "ADS/"]
RUN dotnet restore "ADS/ADS.csproj"
COPY . .
WORKDIR "/src/ADS"
RUN dotnet build "ADS.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "ADS.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "ADS.dll"]