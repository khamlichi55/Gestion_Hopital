# HopitalProject - Système de gestion médicale

Ce projet est une application web développée avec **ASP.NET Core MVC**. Il permet la gestion des entités suivantes :

- **Médecins**
- **Patients**
- **Maladies** (ajoutée récemment, avec fonction de recherche)

## 🛠 Fonctionnalités principales

- Liste, ajout, modification et suppression des **médecins** et **patients**
- Affichage des **maladies** dans une table avec :
  - Recherche par nom
  - Bouton de **rafraîchissement** pour réinitialiser la table
- Interface stylisée avec **Bootstrap**
- Architecture MVC avec **Entity Framework Core** pour la gestion des données

## 📁 Structure du projet

```
Hajarproject/
│
├── Controllers/
│   ├── MedecinController.cs
│   ├── PatientController.cs
│   └── MaladieController.cs
│
├── Models/
│   ├── Medecin.cs
│   ├── Patient.cs
│   └── Maladie.cs
│
├── Views/
│   ├── Maladie/
│   │   ├── Index.cshtml
│   │   └── [Autres fichiers si besoin]
│   └── Shared/
│       └── _Layout.cshtml
│
├── wwwroot/
│   ├── css/
│   │   └── site.css
│   └── lib/
│       └── bootstrap/
│
├── appsettings.json
├── Program.cs
└── Startup.cs
```

## ⚙️ Comment exécuter le projet

1. **Cloner le projet :**
   ```bash
   git clone https://github.com/tonutilisateur/Hajarproject.git
   cd Hajarproject
   ```

2. **Restaurer les dépendances :**
   ```bash
   dotnet restore
   ```

3. **Appliquer les migrations de la base de données :**
   ```bash
   dotnet ef migrations add InitialCreate
   dotnet ef database update
   ```

4. **Lancer le projet :**
   ```bash
   dotnet run
   ```

5. Accéder à l’application :  
   Ouvre ton navigateur à l’adresse : [http://localhost:5000](http://localhost:5000)

## 💡 Technologies utilisées

- ASP.NET Core MVC
- Entity Framework Core
- Bootstrap 5
- C#
- SQL Server / SQLite

## ✍️ Auteur

Projet réalisé par **Hajar** dans le cadre d’un apprentissage ASP.NET MVC.
