# a dockerfile is a set of instructions a list of steps on how to crete a new env.

# base images: a starting point!
FROM node:latest AS build

# workdir creates and navigates to the working directory
WORKDIR /app
# pwd: /app

#copy {context} {working directory}
COPY . . 

# gather dependencies and install
RUN npm install
# build the app!
RUN npm run build

# time for a new environment!
FROM nginx:latest AS RUN

COPY --from=build /app/dist/* /usr/share/nginx/html

EXPOSE 80
EXPOSE 443
