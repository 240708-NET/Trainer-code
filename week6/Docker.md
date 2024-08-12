# Intro to Docker

- **Platform** that allows you to automate the deployment of applications inside lightweight, portable containers. 

- **Containers** are isolated from each other and the host system, providing a consistent environment for applications regardless of where they are run.


- <span style="color:#EC5206; font-weight:bold">Container</span> A lightweight, standalone package that includes everything needed to run a piece of software, including code, runtime, libraries, and dependencies.

- <span style="color:#EC5206; font-weight:bold">Image</span>: A read-only template used to create containers. It includes the application code, libraries, and environment settings.

- <span style="color:#EC5206; font-weight:bold">Dockerfile</span>: A text file that contains a series of instructions on how to build a Docker image.

- <span style="color:#EC5206; font-weight:bold">Docker Engine</span>: The runtime that executes and manages Docker containers.

- <span style="color:#EC5206; font-weight:bold">Docker Hub:</span> A cloud-based registry service where you can find and share Docker images.


### Docker Architecture

It consists of several components:

- <span style="color:#EC5206; font-weight:bold">Docker Daemon:</span> The background service that manages Docker containers and images. It listens for API requests and handles container operations.

- <span style="color:#EC5206; font-weight:bold">Docker CLI:</span> The command-line interface that allows users to interact with Docker. Commands like ```docker run``` and ```docker build```are used to manage containers and images.

- <span style="color:#EC5206; font-weight:bold">Docker Compose:</span> A tool for defining and running multi-container Docker applications using a YAML file.


### Basic Docker Commands

```js
docker --version

//Run container
docker run [OPTIONS] IMAGE [COMMAND] [ARG...]
//Example
docker run hello-world 

//List Running Containers:
docker ps

//List All Containers (including stopped ones):
docker ps -a
//Stop a Container:
docker stop CONTAINER_ID

//Remove a Container:
docker rm CONTAINER_ID

//Pull an Image from Docker Hub:
docker pull IMAGE_NAME

//Build an Image from a Dockerfile:
docker build -t IMAGE_NAME:TAG .

//List Images:
docker images


//Remove an Image:
docker rmi IMAGE_ID

```

## Container vs Image

- **Container** is a running instance of a Docker image.
It is an executable package that includes everything needed to run a specific application or service.

- **Image** blueprint for containers. They provide the complete set of instructions needed to create a running instance of an application.


## Creating a Dockerfile

A Dockerfile is used to build Docker images. It contains a series of instructions that Docker uses to create an image. Here is a basic example of a Dockerfile:

```dockerfile
# Use an official Python runtime as a parent image
FROM python:3.9-slim

# Set the working directory in the container
WORKDIR /app

# Copy the current directory contents into the container at /app
COPY . /app

# Install any needed packages specified in requirements.txt
RUN pip install --no-cache-dir -r requirements.txt

# Make port 80 available to the world outside this container
EXPOSE 80

# Define environment variable
ENV NAME World

# Run app.py when the container launches
CMD ["python", "app.py"]


```

**Important**:
Before adding the .NET app to the Docker image, first it must be published. It's best to have the container run the published version of the app. To publish the app, run the following command:

```
dotnet publish -c Release

```

This command is used in .NET development to prepare an application for deployment. This command compiles your application and packages it into a directory that is ready for distribution and deployment. 