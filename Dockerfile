# Використовуємо .NET SDK образ для Linux (для компіляції без WPF)
FROM mcr.microsoft.com/dotnet/sdk:6.0

WORKDIR /app

# Скопіювати Console solution файл
COPY TEZ_Project.Console.sln .

# Скопіювати проектні файли
COPY TEZ_Project.Console/*.csproj ./TEZ_Project.Console/

# Відновити залежності
RUN dotnet restore

# Скопіювати весь код
COPY . .

# Скомпілювати Console проект (без WPF залежностей)
RUN dotnet build TEZ_Project.Console --configuration Release

# Встановити точку входу для Console додатка
WORKDIR /app/TEZ_Project.Console
CMD ["dotnet", "run"]
