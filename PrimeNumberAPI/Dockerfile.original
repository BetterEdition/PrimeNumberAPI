FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ["PrimeNumberAPI/PrimeNumberAPI.csproj", "PrimeNumberAPI/"]
RUN dotnet restore "PrimeNumberAPI/PrimeNumberAPI.csproj"
COPY . .
WORKDIR "/src/PrimeNumberAPI"
RUN dotnet build "PrimeNumberAPI.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "PrimeNumberAPI.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "PrimeNumberAPI.dll"]