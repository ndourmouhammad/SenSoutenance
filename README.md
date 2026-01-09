# SenSoutenance

Application WinForms (.NET Framework 4.8) pour la gestion des soutenances.

Objectif
--------
Projet de gestion des soutenances avec interfaces WinForms pour gérer les sessions, années, mémoires, soutenances, départements, candidats et professeurs.

Structure du projet
-------------------
Arborescence principale (fichiers importants) :

- `AppSenSoutenance/`
  - `Models/` (entités EF) — ex. `BdSenSoutenanceContext.cs`, `Session.cs`, `AnneeAcademique.cs`
  - `Views/Parametre/` (forms) — ex. `frmSession.cs`, `frmAnneeAcademique.cs`, `frmSoutenance.cs`, `frmMemoire.cs`, `frmDepartement.cs`, `frmChefDepartement.cs`, `frmProfesseur.cs`, `frmCandidat.cs`
  - `Shared/` — utilitaires comme `FilerList.cs`, `ListItem.cs`
  - `Migrations/` — migrations Entity Framework
  - `App.config` — chaîne de connexion et configuration EF
  - `Form1.cs`, `frmMDI.cs`, `Program.cs`

Assignation des interfaces
--------------------------
- DONE
  - `AppSenSoutenance\Views\Parametre\frmSession.cs`
  - `AppSenSoutenance\Views\Parametre\frmAnneeAcademique.cs`

- TO DO - Cheikh
  - `AppSenSoutenance\Views\Parametre\frmSoutenance.cs`
  - `AppSenSoutenance\Views\Parametre\frmMemoire.cs`

- TO DO - RBK
  - `AppSenSoutenance\Views\Parametre\frmDepartement.cs`
  - `AppSenSoutenance\Views\Parametre\frmSujet.cs`

- TO DO - Mouhammad
  - `AppSenSoutenance\Views\Accounts\frmUtilisateur.cs`
  - `la connexion`

Bonnes pratiques pour l'équipe
-----------------------------
- Branches : `votre-prenom`.
- Ne merger pas directement creer juste de pull request.

Installation rapide
-------------------
Prérequis : Visual Studio (avec workload Desktop .NET), .NET Framework 4.8, MySQL Server, Git.

1. Cloner :

```
git clone https://github.com/<organisation>/<repo>.git
cd <repo>
```

2. Ouvrir la solution : `AppSenSoutenance\AppSenSoutenance.csproj` dans Visual Studio.

3. Restaurer les packages NuGet (Visual Studio le fait automatiquement) ou :

```
nuget restore
```

4. Configurer la base : éditez `AppSenSoutenance\App.config` — mettez vos paramètres dans la clé `connBdSenSoutenance`.

Exemple :

```
<add name="connBdSenSoutenance" providerName="MySql.Data.MySqlClient" connectionString="server=localhost;port=3306;database=bdsensoutenance;uid=root;password=VotreMDP" />
```


5. Appliquer les migrations (si nécessaire) :

```
Update-Database -Verbose
```

6. Lancer l'application (F5).

Dépannage rapide
----------------
- Si EF/MySQL pose problème : installez `MySql.Data` et `MySql.Data.EntityFramework` compatibles.
- Si Update-Database échoue : vérifiez la chaîne de connexion et `Migrations\Configuration.cs`.
