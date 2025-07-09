#!/bin/bash

# Kubernetes Secrets Creation Script
# This script creates necessary secrets for the TEZ project deployment

set -e

NAMESPACE=${1:-"tez-project"}
ENVIRONMENT=${2:-"staging"}

echo "🔐 Creating Kubernetes Secrets"
echo "Namespace: $NAMESPACE"
echo "Environment: $ENVIRONMENT"
echo "=============================="

# Function to print colored output
print_step() {
    echo -e "\033[1;34m🔧 $1\033[0m"
}

print_success() {
    echo -e "\033[1;32m✅ $1\033[0m"
}

print_error() {
    echo -e "\033[1;31m❌ $1\033[0m"
}

# Check if kubectl is available
if ! command -v kubectl &> /dev/null; then
    print_error "kubectl is not installed or not in PATH"
    exit 1
fi

# Check if namespace exists
if ! kubectl get namespace $NAMESPACE &> /dev/null; then
    print_step "Creating namespace: $NAMESPACE"
    kubectl create namespace $NAMESPACE
    print_success "Namespace created"
fi

# Generate random passwords if not provided via environment variables
POSTGRES_PASSWORD=${POSTGRES_PASSWORD:-$(openssl rand -base64 32)}
REDIS_PASSWORD=${REDIS_PASSWORD:-$(openssl rand -base64 32)}
JWT_SECRET=${JWT_SECRET:-$(openssl rand -base64 64)}

print_step "Creating PostgreSQL secret"
kubectl create secret generic postgresql-secret \
    --from-literal=postgres-password="$POSTGRES_PASSWORD" \
    --from-literal=password="$POSTGRES_PASSWORD" \
    --namespace=$NAMESPACE \
    --dry-run=client -o yaml | kubectl apply -f -

print_success "PostgreSQL secret created"

print_step "Creating Redis secret"
kubectl create secret generic redis-secret \
    --from-literal=redis-password="$REDIS_PASSWORD" \
    --namespace=$NAMESPACE \
    --dry-run=client -o yaml | kubectl apply -f -

print_success "Redis secret created"

print_step "Creating application secrets"
kubectl create secret generic app-secrets \
    --from-literal=jwt-secret="$JWT_SECRET" \
    --from-literal=environment="$ENVIRONMENT" \
    --namespace=$NAMESPACE \
    --dry-run=client -o yaml | kubectl apply -f -

print_success "Application secrets created"

print_step "Creating TLS secret (if certificates are available)"
if [ -f "certs/tls.crt" ] && [ -f "certs/tls.key" ]; then
    kubectl create secret tls tez-project-$ENVIRONMENT-tls \
        --cert=certs/tls.crt \
        --key=certs/tls.key \
        --namespace=$NAMESPACE \
        --dry-run=client -o yaml | kubectl apply -f -
    print_success "TLS secret created"
else
    echo "⚠️ TLS certificates not found, skipping TLS secret creation"
fi

print_step "Labeling secrets"
kubectl label secret postgresql-secret app=tez-project environment=$ENVIRONMENT --namespace=$NAMESPACE --overwrite
kubectl label secret redis-secret app=tez-project environment=$ENVIRONMENT --namespace=$NAMESPACE --overwrite
kubectl label secret app-secrets app=tez-project environment=$ENVIRONMENT --namespace=$NAMESPACE --overwrite

print_success "Secrets labeled successfully"

echo ""
echo "📋 Secrets Summary:"
echo "==================="
kubectl get secrets -n $NAMESPACE -l app=tez-project

echo ""
echo "🔒 Security Notes:"
echo "- PostgreSQL password: [HIDDEN]"
echo "- Redis password: [HIDDEN]"
echo "- JWT secret: [HIDDEN]"
echo "- All secrets are stored securely in Kubernetes"
echo ""
echo "✅ All secrets created successfully!"
echo ""
echo "📝 Next steps:"
echo "1. Deploy your application: helm install tez-project ./charts/tez-project"
echo "2. Verify deployment: kubectl get pods -n $NAMESPACE"
echo "3. Check logs: kubectl logs -f deployment/tez-project -n $NAMESPACE"
