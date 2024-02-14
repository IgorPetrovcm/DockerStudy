FROM mcr.microsoft.com/dotnet/sdk:8.0 AS base

WORKDIR /FirstProject

COPY . ./

RUN dotnet restore
RUN dotnet publish -c Release -o release

FROM mcr.microsoft.com/dotnet/aspnet:8.0

WORKDIR /FirstProject

COPY --from=base /FirstProject/release .

ENTRYPOINT ["dotnet", "test1.dll"]