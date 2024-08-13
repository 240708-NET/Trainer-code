FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /app

COPY ./ ./

RUN dotnet restore

RUN dotnet publish -c Release -o ./out

# After this line, we don't need the dotnet SDK, only the runtime!

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS run

WORKDIR /app

COPY --from=build /app/out ./

ENTRYPOINT ["dotnet", "./simpleapi.dll"]
E 808
EXPOSE 443
EXPOS0