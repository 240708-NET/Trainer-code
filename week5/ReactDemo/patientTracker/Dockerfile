FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS building-env

WORKDIR /myApp

# Copy all to my new myApp

COPY . . /

# Run our app / restore as layers
RUN dotnet restore

RUN dotnet publish -c PatientTrackerRelease -o out

# Build runtime image
FROM  mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /myApp
COPY --from=build-ev /myApp/out .
ENTRYPOINT ["dotnet", "patientTracker.dll"]