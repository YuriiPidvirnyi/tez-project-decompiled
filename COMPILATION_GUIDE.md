# Керівництво по компіляції TEZ Project

## Проблема на macOS
WPF (Windows Presentation Foundation) проекти не можуть компілюватись на macOS через обмеження платформи. Це Microsoft технологія, що працює тільки на Windows.

## Рішення

### Варіант 1: Віртуальна машина Windows (Рекомендовано)
1. Встановіть **Parallels Desktop** (платний, найкращий):
   ```bash
   brew install --cask parallels
   ```
   
2. Або **UTM** (безкоштовний):
   ```bash
   brew install --cask utm
   ```

3. Створіть Windows 11 VM
4. Встановіть **Visual Studio Community** або **.NET 6.0 SDK**
5. Перенесіть проект в VM:
   ```cmd
   dotnet restore
   dotnet build
   dotnet run --project TEZ_Project
   ```

### Варіант 2: Docker Desktop з Windows контейнерами

<citations>
  <document>
      <document_type>RULE</document_type>
      <document_id>ahY3lCey47nvCWyeATH37r</document_id>
  </document>
</citations>

1. В Docker Desktop увімкніть WSL-2 backend
2. Переключіться на Windows контейнери
3. Запустіть:
   ```bash
   docker build -f Dockerfile.windows -t tez-project .
   docker run -it tez-project
   ```

### Варіант 3: GitHub Codespaces
1. Завантажте проект на GitHub
2. Створіть Windows Codespace
3. Компілюйте в хмарі

### Варіант 4: Переписування на кросплатформну технологію
- **Avalonia UI** - альтернатива WPF для macOS/Linux
- **.NET MAUI** - Microsoft кросплатформний UI
- **Electron.NET** - веб-технології як десктоп

## Поточний стан проекту
- ✅ Код декомпільований
- ✅ Структура проекту створена
- ✅ Залежності налаштовані
- ❌ Компіляція на macOS неможлива через WPF
- ✅ Common бібліотека може частково компілюватись

## Наступні кроки
1. Встановіть Windows VM
2. Перенесіть папку `~/TEZ/unpacked/FinalProject`
3. Компілюйте в Windows середовищі
