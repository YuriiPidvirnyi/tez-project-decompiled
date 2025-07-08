# Windows Codespace Setup для TEZ Project

## 🚀 Швидкий старт в Windows Codespace

### Крок 1: Створення Windows Codespace
1. Перейдіть на: https://github.com/YuriiPidvirnyi/tez-project-decompiled
2. Натисніть **"Code"** → **"Codespaces"**
3. Натисніть **"..."** → **"New with options"**
4. **Machine type:** Виберіть **"4-core, 16GB RAM"** (рекомендовано для WPF)
5. **Dev container configuration:** Виберіть **"TEZ Project - Windows Desktop"**
6. Натисніть **"Create codespace"**

### Крок 2: Команди для компіляції

```powershell
# Відновити залежності
dotnet restore

# Компілювати WPF проект (тільки на Windows)
dotnet build TEZ_Project --configuration Release

# Компілювати як self-contained для Windows
dotnet publish TEZ_Project -c Release -r win-x64 --self-contained

# Запустити (якщо є GUI підтримка)
dotnet run --project TEZ_Project
```

### Крок 3: Альтернативні команди

```bash
# Компілювати Common бібліотеку (працює на Linux/Windows)
dotnet build TEZ_Project.Common

# Запустити консольну версію
dotnet run --project TEZ_Project.Console

# Перевірити всі проекти
dotnet build --configuration Release
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
