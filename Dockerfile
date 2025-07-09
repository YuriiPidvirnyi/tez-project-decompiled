# Multi-stage build for optimized production image
# Build stage
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

WORKDIR /src

# Copy solution and project files
COPY TEZ_Project.Console.sln .
COPY TEZ_Project.Console/*.csproj ./TEZ_Project.Console/
COPY TEZ_Project.Tests/*.csproj ./TEZ_Project.Tests/

# Restore dependencies with retry for network issues
RUN dotnet restore TEZ_Project.Console.sln --verbosity minimal --disable-parallel

# Copy source code
COPY . .

# Build and publish with optimizations
WORKDIR /src/TEZ_Project.Console
RUN dotnet publish -c Release -o /app/publish --no-restore \
    --verbosity minimal \
    -p:TreatWarningsAsErrors=false \
    -p:PublishTrimmed=false \
    -p:DebugType=None \
    -p:DebugSymbols=false

# Runtime stage
FROM mcr.microsoft.com/dotnet/runtime:6.0 AS runtime

# Install security updates
RUN apt-get update && apt-get upgrade -y && \
    apt-get install -y --no-install-recommends \
    ca-certificates && \
    rm -rf /var/lib/apt/lists/*

# Create non-root user for security
RUN groupadd -r tezuser && useradd -r -g tezuser tezuser

WORKDIR /app

# Copy published application with proper ownership
COPY --from=build --chown=tezuser:tezuser /app/publish .

# Create directories for logs and data
RUN mkdir -p /app/logs /app/data && chown -R tezuser:tezuser /app

# Switch to non-root user
USER tezuser

# Set security labels
LABEL security.non-root=true
LABEL security.user=tezuser

# Health check
HEALTHCHECK --interval=30s --timeout=10s --start-period=30s --retries=3 \
    CMD timeout 10s dotnet TEZ_Project.Console.dll || exit 1

# Set entry point
ENTRYPOINT ["dotnet", "TEZ_Project.Console.dll"]
