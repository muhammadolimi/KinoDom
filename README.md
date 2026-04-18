🎬 KinoDom

Платформа для онлайн-кинотеатра. Пользователи могут просматривать фильмы, добавлять их в избранное, оставлять отзывы и отслеживать историю просмотров. Администраторы управляют контентом (фильмы, жанры, описания).

⚙️ Стек
Frontend: Blazor WASM + MudBlazor
Backend: ASP.NET Core Web API (.NET 10)
Database: PostgreSQL
CI/CD: GitHub Actions
``` bash
📁 Структура проекта
KinoDom/
├── src/
│   ├── KinoDom.API/        # ASP.NET Core Web API
│   └── KinoDom.Blazor.UI/  # Blazor WASM + MudBlazor
├── docs/
│   └── ADR/                # Architecture Decision Records
├── .github/
│   └── workflows/          # CI/CD
├── .gitignore
├── .editorconfig
├── README.md
└── KinoDom.sln
```
🚀 Начало работы
Требования
.NET 10 SDK
Docker (для базы данных)
▶️ Запуск
# Клонируй репозиторий
git clone https://github.com/your-org/KinoDom.git
cd KinoDom

# Запусти базу данных
docker-compose up -d

# Запусти backend
cd src/KinoDom.API
dotnet run

# В отдельном терминале — frontend
``` bash
cd src/KinoDom.Blazor.UI
dotnet run
👥 Роли пользователей
Гость — просмотр фильмов
Пользователь — избранное, отзывы, история
Администратор — управление контентом
📌 Основной функционал
📽 Каталог фильмов
🔍 Поиск и фильтрация (жанры, рейтинг)
⭐️ Добавление в избранное
📝 Отзывы и оценки
📊 История просмотров
🛠 Админ-панель
📄 Команда
```
Проект разработан в рамках обучения и практики разработки fullstack-приложений на .NET.
