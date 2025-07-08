# TEZ Project - GitHub Codespaces Setup

## 🚀 Швидкий старт

1. **Клонуйте репозиторій**
2. **Відкрийте в Codespace:**
   - Натисніть `Code` → `Create codespace on main`
   - Чекайте 2-3 хвилини на ініціалізацію

3. **Компілюйте проект:**
   ```bash
   # Консольна версія (працює в Linux)
   dotnet build TEZ_Project.Console
   dotnet run --project TEZ_Project.Console
   
   # Для WPF версії потрібен Windows Codespace
   dotnet build TEZ_Project --runtime win-x64
   ```

## 📁 Структура проекту

- `TEZ_Project/` - Головний WPF додаток (тільки Windows)
- `TEZ_Project.Common/` - Бізнес-логіка (кросплатформна)
- `TEZ_Project.Console/` - Консольна версія для тестування
- `TEZ_Project.Common_Windows/` - Повна версія для Windows

## 🛠 Команди

```bash
# Відновити залежності
dotnet restore

# Компілювати всі проекти
dotnet build

# Запустити консольну версію
dotnet run --project TEZ_Project.Console

# Перевірити код
dotnet test (якщо є тести)
```

## ⚠️ Обмеження

- WPF працює тільки на Windows
- В Linux Codespace можна тестувати лише бізнес-логіку
- Для повного GUI потрібен Windows Codespace або локальна Windows VM
