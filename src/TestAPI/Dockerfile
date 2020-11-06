# Get base sdk from microsoft
FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build-env
WORKDIR /app

# Copy tthe CSPROJ file and restore any dependecies
COPY *.csproj ./
RUN dotnet restore

# Copy the project files and build the release
COPY . ./
RUN dotnet publish -c Release -o out

# Generate runtime image
FROM mcr.microsoft.com/dotnet/core/sdk:3.1
WORKDIR /app
EXPOSE 80
COPY --from=build-env /app/out .
ENTRYPOINT [ "dotnet", "TestAPI.dll" ]
