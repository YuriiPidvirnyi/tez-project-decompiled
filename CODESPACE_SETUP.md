# Codespace Setup для TEZ Project

## ⚠️ Windows Codespace обмеження

**Важливо:** Windows контейнери не підтримуються в GitHub Codespaces. Проект автоматично запуститься в Linux середовищі з .NET 6.0.

## 🚀 Швидкий старт в Linux Codespace

### Крок 1: Створення Codespace
1. Перейдіть на: https://github.com/YuriiPidvirnyi/tez-project-decompiled
2. Натисніть **"Code"** → **"Codespaces"**
3. Натисніть **"Create codespace on main"**
4. **Machine type:** Виберіть **"2-core, 8GB RAM"** (достатньо для консольної версії)
5. Codespace запуститься автоматично з Linux + .NET 6.0

### Крок 2: Команди для компіляції в Linux

```bash
# Відновити залежності
dotnet restore

# ❌ WPF проект НЕ компілюється на Linux
# dotnet build TEZ_Project  # Це НЕ працює

# ✅ Компілювати консольну версію (працює на Linux)
dotnet build TEZ_Project.Console

# ✅ Запустити консольну версію
dotnet run --project TEZ_Project.Console

# Перевірити .NET версію
dotnet --info
```

### Крок 3: Тестування функціональності

```bash
# Запустити тести консольної логіки
dotnet run --project TEZ_Project.Console

# Перевірити структуру проекту
ls -la

# Переглянути файли конфігурації
cat appsettings.json
```

## 🖥 Підтримка GUI в Codespace

### Option 1: VNC (рекомендовано)
```bash
# Встановити X11 сервер
sudo apt update
sudo apt install -y xvfb x11vnc

# Запустити віртуальний дисплей
export DISPLAY=:1
Xvfb :1 -screen 0 1024x768x16 &

# Запустити VNC сервер
x11vnc -display :1 -nopw -listen localhost -xkb &
```

### Option 2: Web-based VNC
```bash
# Встановити noVNC
wget https://github.com/novnc/noVNC/archive/refs/tags/v1.3.0.tar.gz
tar -xzf v1.3.0.tar.gz
cd noVNC-1.3.0
./utils/websockify/run 6080 localhost:5900 &
```

### Option 3: Remote Desktop (якщо Windows Codespace)
```powershell
# Увімкнути RDP (якщо Windows контейнер)
Enable-NetFirewallRule -DisplayGroup "Remote Desktop"
Set-ItemProperty -Path 'HKLM:\System\CurrentControlSet\Control\Terminal Server' -name "fDenyTSConnections" -Value 0
```

## 🔧 Налаштування Environment

### Змінні середовища
```bash
export DOTNET_ROOT=/usr/share/dotnet
export DISPLAY=:1
export LIBGL_ALWAYS_INDIRECT=1
```

### Встановлення додаткових залежностей
```bash
# Для Linux Codespace з WPF підтримкою
sudo apt install -y libgtk-3-dev libx11-dev

# Mono для .NET Framework сумісності
sudo apt install -y mono-complete
```

## ⚠️ Обмеження та Рішення

### WPF на Linux
- WPF не працює нативно на Linux
- Використовуйте Mono або Wine для емуляції
- Краще компілювати на Windows Codespace

### Ресурси Codespace
- **2-core:** Базова компіляція
- **4-core:** Рекомендовано для WPF
- **8-core:** Для великих проектів

### Альтернативи GUI
- **Console версія:** Працює скрізь
- **Web UI:** Blazor Server/WASM
- **Cross-platform:** Avalonia UI

## 📊 Моніторинг ресурсів

```bash
# Перевірити використання пам'яті
free -h

# Перевірити CPU
htop

# Розмір проекту
du -sh .
```

## 🎯 Результат

Після успішного налаштування ви зможете:
- ✅ Компілювати WPF додаток
- ✅ Запускати Common логіку
- ✅ Тестувати функціональність
- ✅ Розробляти в повноцінному Windows середовищі

---

**Примітка:** Windows Codespaces можуть коштувати більше. Використовуйте Linux Codespace для розробки логіки та Windows тільки для GUI тестування.

## 🪟 Альтернативи для Windows WPF

### Option 1: Локальна Windows машина
```powershell
# Клонувати репозиторій
git clone https://github.com/YuriiPidvirnyi/tez-project-decompiled.git
cd tez-project-decompiled

# Компілювати WPF проект
dotnet restore
dotnet build TEZ_Project --configuration Release

# Запустити WPF додаток
dotnet run --project TEZ_Project
```

### Option 2: Azure DevOps Pipeline
- Використати Windows agent для компіляції
- Налаштувати CI/CD для автоматичного білду
- Вартість: ~$40/місяць для приватного агента

### Option 3: AWS EC2 Windows Instance
```bash
# Створити Windows Server instance
# Встановити .NET 6.0 SDK
# Клонувати та компілювати проект
```

### Option 4: Docker Desktop з WSL2
```bash
# На Windows 10/11 з WSL2
docker build -f Dockerfile.windows -t tez-project-windows .
docker run -it tez-project-windows
```

## 📊 Порівняння варіантів

| Варіант | Вартість | Складність | WPF Support |
|---------|----------|------------|-------------|
| Linux Codespace | Безкоштовно | ⭐ | ❌ |
| Local Windows | Безкоштовно | ⭐⭐ | ✅ |
| Azure DevOps | $40/міс | ⭐⭐⭐ | ✅ |
| AWS EC2 | $30-50/міс | ⭐⭐⭐⭐ | ✅ |
| Docker WSL2 | Безкоштовно | ⭐⭐⭐ | ✅ |

## 🎯 Рекомендації

1. **Для розробки логіки:** Використовуйте Linux Codespace
2. **Для GUI тестування:** Локальна Windows машина
3. **Для продакшену:** Azure DevOps або AWS
4. **Для навчання:** Linux Codespace + локальна Windows машина
