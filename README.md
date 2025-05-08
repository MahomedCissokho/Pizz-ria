# 🍕 API Pizza avec EF Core & SQLite

![Version](https://github.com/user-attachments/assets/845965e8-06de-4fa2-9ed3-e21398052271)

![License](https://img.shields.io/badge/license-MIT-green.svg)

> Une API REST légère pour gérer vos pizzas préférées

## 📋 Aperçu

Cette API minimale ASP.NET Core permet de gérer une collection de pizzas avec persistance des données via SQLite et Entity Framework Core.

## 🚀 Fonctionnalités

- ✅ API REST complète avec opérations CRUD
- 📊 Documentation Swagger intégrée
- 💾 Persistance des données avec SQLite
- 🔄 Gestion des migrations EF Core
- 🌿 Organisation du code source par branches Git

## 🛠️ Technologies utilisées

- **ASP.NET Core** - Framework web léger et performant
- **Entity Framework Core** - ORM pour l'accès aux données
- **SQLite** - Base de données légère et portable
- **Swagger/OpenAPI** - Documentation interactive de l'API
- **Git** - Gestion de versions et branches

## 🏗️ Structure du projet

```
API-Pizza/
├── Models/
│   └── PizzaEhod.cs         # Modèle de données
├── Data/
│   └── PizzaEhodDB.cs       # Contexte EF Core 
├── Migrations/              # Fichiers de migration EF Core
├── Program.cs               # Point d'entrée et configuration
├── appsettings.json         # Configuration de l'application
└── Pizzas.db                # Base de données SQLite
```

## 🚦 Routes API

| Méthode | Endpoint | Description |
|---------|----------|-------------|
| GET | `/pizzas` | Récupérer toutes les pizzas |
| GET | `/pizzas/{id}` | Récupérer une pizza par ID |
| POST | `/pizzas` | Créer une nouvelle pizza |
| PUT | `/pizzas/{id}` | Mettre à jour une pizza existante |
| DELETE | `/pizzas/{id}` | Supprimer une pizza |

## 🚀 Installation et démarrage

1. **Cloner le dépôt**
   ```bash
   git clone https://github.com/cisco/api-pizza.git
   cd api-pizza
   ```

2. **Restaurer les packages**
   ```bash
   dotnet restore
   ```

3. **Appliquer les migrations**
   ```bash
   dotnet ef database update
   ```

4. **Lancer l'application**
   ```bash
   dotnet run
   ```

5. **Accéder à Swagger**
   ```
   Voir le port 
   https://localhost:${port}/swagger
   ```

## 🌿 Gestion des branches Git

- **`main`** - Version finale avec SQLite
- **`pizz-ria-ef-core-memory`** - Version avec base de données en mémoire
- **`pizz-ria-ef-core-sqlite`** - Version avec persistance SQLite

## 👨‍💻 Auteur

**Mahomed CISSOKHO** (Cisco)

---

✨ *Projet réalisé dans le cadre d'un cours sur ASP.NET Core et Entity Framework* ✨
