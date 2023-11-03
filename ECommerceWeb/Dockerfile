# Use the .NET SDK image to build the application
FROM mcr.microsoft.com/dotnet/core/sdk:8.0 AS build-env
WORKDIR /app
COPY *.csproj .
RUN dotnet restore
COPY . ./
RUN dotnet publish --no-restore -c Release -o out

# Use the ASP.NET Core Runtime image to run the application
FROM mcr.microsoft.com/dotnet/core/aspnet:8.0
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "ECommerceWeb.dll"]


