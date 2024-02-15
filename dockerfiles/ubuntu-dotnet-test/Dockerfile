FROM ubuntu:20.04

RUN apt-get update
RUN apt-get install -y dotnet-sdk-8.0 
RUN apt-get update
RUN apt-get install -y aspnetcore-runtime-8.0

ENTRYPOINT [ "dotnet", "--version" ]