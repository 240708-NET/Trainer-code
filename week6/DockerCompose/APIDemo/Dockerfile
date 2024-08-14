FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

WORKDIR /app

COPY . .

RUN dotnet publish -c Release -o ./out


FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS run

WORKDIR /app

COPY --from=build /app/out .

ENTRYPOINT [ "dotnet", "./APIDemo.dll" ]

EXPOSE 80
EXPOSE 443