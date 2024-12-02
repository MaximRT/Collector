# Используем официальный образ .NET для сборки приложения (SDK)
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

# Устанавливаем рабочую директорию внутри контейнера
WORKDIR /app

# Копируем файл проекта и восстанавливаем зависимости
COPY . .
RUN dotnet restore

# Копируем оставшиеся файлы и собираем приложение
COPY . ./
RUN dotnet publish -c Release -o /out

# Используем официальный образ .NET для запуска приложения (Runtime)
FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS runtime

# Копируем собранное приложение из предыдущего этапа
COPY --from=build /out ./

# Указываем порт, который будет использоваться в контейнере
EXPOSE 80

# Указываем команду для запуска приложения
ENTRYPOINT ["dotnet", "API.dll"]
