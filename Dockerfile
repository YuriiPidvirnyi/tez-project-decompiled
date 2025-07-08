# Використовуємо .NET SDK образ для Linux (для компіляції без WPF)
FROM mcr.microsoft.com/dotnet/sdk:6.0

WORKDIR /app

# Скопіювати solution файл
COPY *.sln .

# Скопіювати проектні файли
COPY TEZ_Project.Common/*.csproj ./TEZ_Project.Common/
COPY TEZ_Project/*.csproj ./TEZ_Project/

# Відновити залежності
RUN dotnet restore

# Скопіювати весь код
COPY . .

# Спробувати скомпілювати Common проект (без WPF залежностей)
RUN dotnet build TEZ_Project.Common --configuration Release || echo "Common project build failed"

# Команда для інтерактивного режиму
CMD ["/bin/bash"]
