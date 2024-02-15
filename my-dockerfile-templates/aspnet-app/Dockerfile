FROM mcr.microsoft.com/dotnet/sdk:8.0 as build

WORKDIR /source/app

COPY . .

RUN dotnet restore 
RUN mkdir /source/publish 
RUN dotnet publish -c Release -o /source/publish

WORKDIR /source/publish 

FROM mcr.microsoft.com/dotnet/aspnet:8.0 

EXPOSE 80

ENV ASPNETCORE_URLS=http://+:80

WORKDIR /publish/

COPY --from=build /source/publish .

ENTRYPOINT [ "dotnet", "aspapp1.dll"]