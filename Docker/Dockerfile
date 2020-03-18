FROM mcr.microsoft.com/dotnet/core/sdk:2.2 AS build
WORKDIR /source

# copy csproj and restore as distinct layers
COPY *.sln .
COPY ../Comeia/*.csproj ./Comeia/
RUN dotnet restore

# copy everything else and build app
COPY ../Comeia/. ./Comeia/
WORKDIR /source/Comeia
RUN dotnet publish --output /app/ --configuration Release

# final stage/image
FROM mcr.microsoft.com/dotnet/core/aspnet:2.2
WORKDIR /app
COPY --from=build /app ./
ENTRYPOINT ["dotnet", "Comeia.dll"]
