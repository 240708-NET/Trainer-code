FROM openjdk:8u131-jre-alpine
ENV HW_HOME=/opt/hello-java
ADD HelloJava.class $HW_HOME/
WORKDIR $HW_HOME
ENTRYPOINT [ "java", "HelloJava" ]