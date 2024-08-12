FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env
WORKDIR /myApp

# Copy everything
COPY . ./
# Restore as distinct layers
RUN dotnet restore
# Build and publish a release
RUN dotnet publish -c PatientTrackerRelease -o out

# Build runtime image
#create a container from the image and run the app, 
#copy the published app to the container, and define the entry point.
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /myApp
COPY --from=build-env /myApp/out .
ENTRYPOINT ["dotnet", "patientTrackerServer.dll"]
