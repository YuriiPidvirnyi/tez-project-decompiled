# 🚀 TEZ Project - CI/CD System Overview

## Що створено

Ваш проект тепер має **повноцінну CI/CD систему** з підтримкою:

### 📁 GitHub Actions Workflows
- **ci-cd.yml** - Основний pipeline (збірка, тести, Docker, деплойменти)
- **deploy-dev.yml** - Швидкий деплойменат для розробки
- **deploy-staging.yml** - Повний тестовий деплойменат
- **deploy-production.yml** - Продакшн деплойменат з додатковими перевірками
- **deploy-k8s.yml** - Kubernetes деплойменат з Helm

### 🐳 Docker Infrastructure
- **Dockerfile** - Оптимізований multi-stage build
- **docker-compose.yml** - Основний compose
- **docker-compose.dev.yml** - Development середовище
- **docker-compose.prod.yml** - Production з повним стеком

### ☸️ Kubernetes Support
- **Helm Chart** в `charts/tez-project/`
- **Multi-environment** конфігурація
- **Auto-scaling** підтримка
- **Health checks** і **monitoring**

## 🎯 Як користуватися

### 1. Local Development
```bash
# Запуск development середовища
docker-compose -f docker-compose.dev.yml up

# Демо CI/CD системи
./scripts/demo-cicd.sh
```

### 2. GitHub Actions
- **Push на `develop`** → Development деплойменат
- **Push на `release/*`** → Staging деплойменат
- **Push на `main`** → Production деплойменат

### 3. Kubernetes
```bash
# Деплой на Kubernetes
helm install tez-project ./charts/tez-project

# Upgrade
helm upgrade tez-project ./charts/tez-project
```

## 🌟 Особливості

### ✅ Automated Testing
- Unit tests з xUnit
- Integration tests
- E2E tests для staging
- Security сканування

### 🔐 Security
- Trivy vulnerability scanning
- Non-root containers
- Secrets management
- Security tests

### 📊 Monitoring
- Prometheus metrics
- Grafana dashboards
- Health checks
- Performance monitoring

### 🔄 Deployment Strategies
- Blue/Green deployments
- Canary releases
- Rollback mechanisms
- Environment-specific configs

## 📚 Середовища

| Environment | URL | Purpose |
|-------------|-----|---------|
| Development | `dev.tez-project.dev` | Швидке тестування |
| Staging | `staging.tez-project.dev` | QA і E2E тести |
| Production | `tez-project.dev` | Live додаток |

## 🛠️ Налаштування

### Необхідні Secrets в GitHub
```
GITHUB_TOKEN - Автоматично надається
KUBE_CONFIG - Kubernetes конфігурація (base64)
```

### Environment Variables
```bash
REGISTRY=ghcr.io
IMAGE_NAME=your-repo/tez-project
DOTNET_VERSION=6.0.x
```

## 🚀 Швидкий старт

1. **Commit і Push**:
```bash
git add .
git commit -m "Add CI/CD pipeline"
git push origin develop
```

2. **Перевірте GitHub Actions**:
   - Перейдіть на GitHub → Actions
   - Побачите запущений pipeline

3. **Локальне тестування**:
```bash
./scripts/demo-cicd.sh
```

## 📈 Metrics & Monitoring

### Prometheus Targets
- Application metrics
- Docker metrics
- Kubernetes metrics

### Grafana Dashboards
- System Overview
- Application Performance
- Deployment Status
- Error Tracking

## 🔧 Troubleshooting

### Common Issues
1. **Docker not running** → Запустіть Docker Desktop
2. **Build fails** → Перевірте dependencies
3. **Tests fail** → Перевірте test configuration

### Logs
```bash
# Docker logs
docker logs container_name

# Kubernetes logs
kubectl logs -f deployment/tez-project

# GitHub Actions logs
# Дивіться в GitHub → Actions → Workflow run
```

## 🎉 Результат

Ваш проект тепер має:
- ✅ **Automated CI/CD** pipeline
- ✅ **Multi-environment** support
- ✅ **Docker containerization**
- ✅ **Kubernetes ready**
- ✅ **Security scanning**
- ✅ **Monitoring setup**
- ✅ **Documentation**

---

**Готово!** Ваша CI/CD система повністю налаштована і готова до використання. 🚀

Для детальної інформації дивіться: `docs/CI-CD-DEPLOYMENT.md`
