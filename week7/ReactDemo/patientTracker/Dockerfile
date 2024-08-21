FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app
COPY ./ ./
RUN dotnet publish -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS running
WORKDIR /app
COPY --from=build /app/publish ./
EXPOSE 80
EXPOSE 443
ENTRYPOINT [ "dotnet", "./patientTracker.dll" ]