# Multi-stage build for optimized production image
# Build stage
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

WORKDIR /src

# Copy solution and project files
COPY TEZ_Project.Console.sln .
COPY TEZ_Project.Console/*.csproj ./TEZ_Project.Console/

# Restore dependencies
RUN dotnet restore TEZ_Project.Console.sln

# Copy source code
COPY . .

# Build and publish
WORKDIR /src/TEZ_Project.Console
RUN dotnet publish -c Release -o /app/publish --no-restore

# Runtime stage
FROM mcr.microsoft.com/dotnet/runtime:6.0 AS runtime

# Create non-root user for security
RUN groupadd -r tezuser && useradd -r -g tezuser tezuser

WORKDIR /app

# Copy published application
COPY --from=build /app/publish .

# Create directories for logs and data
RUN mkdir -p /app/logs /app/data && chown -R tezuser:tezuser /app

# Switch to non-root user
USER tezuser

# Health check
HEALTHCHECK --interval=30s --timeout=10s --start-period=30s --retries=3 \
    CMD timeout 10s dotnet TEZ_Project.Console.dll || exit 1

# Set entry point
ENTRYPOINT ["dotnet", "TEZ_Project.Console.dll"]
