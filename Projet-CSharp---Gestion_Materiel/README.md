# Gestion du matériel et des incidents – GSB

Application C# (Windows Forms) de gestion du parc informatique et des incidents matériels du laboratoire Galaxy Swiss Bourdin.

## Fonctionnalités

| Profil | Accès |
|---|---|
| Utilisateur | Déclarer un incident, suivre ses tickets |
| Technicien | Ajouter, consulter et supprimer du matériel ; consulter, prendre en charge et traiter les incidents |
| Responsable | Ajouter, modifier et supprimer des techniciens et des utilisateurs |

## Technologies

- C# / Windows Forms (.NET 8)
- MySQL

## Lancer le projet

Ouvrir `GSBIncidents/GSBIncidents.sln` avec Visual Studio, puis lancer avec F5.

## Structure

```
GSBIncidents/
├── GSBIncidents.sln
└── GSBIncidents/
    ├── Program.cs
    └── FormPrincipal.cs        # fenêtre unique : onglets Connexion, Utilisateur, Technicien, Responsable
```
