# ---- Build stage ----
FROM mcr.microsoft.com/dotnet/sdk:11.0-preview AS build
WORKDIR /src

# Copy project files first for layer caching
COPY ImmigrantAdvisor.Web/ImmigrantAdvisor.Web.csproj ImmigrantAdvisor.Web/
COPY ImmigrantAdvisor.Shared/ImmigrantAdvisor.Shared.csproj ImmigrantAdvisor.Shared/
RUN dotnet restore ImmigrantAdvisor.Web/ImmigrantAdvisor.Web.csproj

# Copy everything and publish
COPY . .
RUN dotnet publish ImmigrantAdvisor.Web/ImmigrantAdvisor.Web.csproj -c Release -o /app/publish --no-restore

# ---- Runtime stage ----
FROM mcr.microsoft.com/dotnet/aspnet:11.0-preview AS runtime
WORKDIR /app
COPY --from=build /app/publish .

# Railway assigns a dynamic PORT via env var
ENV ASPNETCORE_URLS=http://+:8080
EXPOSE 8080

ENTRYPOINT ["dotnet", "ImmigrantAdvisor.Web.dll"]
