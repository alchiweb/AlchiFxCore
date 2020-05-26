# AlchiFxCore

AlchiFxCore est un template de projet C# permettant de créer des projets C# pour Visual Studio 2019 (et 2017).
[Fichier de documentation (.docx)](https://github.com/alchiweb/AlchiFxCore/raw/master/docs/Alchiweb-Dev-AlchiFxCore.docx)

# Le site généré :
## Utilise principalement les technologies :
- Asp.Net Core 3.1 (lui-même basé sur .Net Core 3.1) + Entity Framework Core 3.1
- [Entity Signal](https://entitysignal.com/), pour mettre à jour automatiquement les données affichées dans des pages ouvertes
- [BootStrap 4](https://getbootstrap.com)
- [jQuery](https://jquery.com/) + [jQueryUI](https://jqueryui.com/)
- [jQuery Dialog](https://jqueryui.com/dialog/)  pour le multifenêtrage
- [SlickGrid](http://slickgrid.net/) pour les tables
- [Select2](https://select2.org/) (version compatible avec BootStrap 4), pour les listes déroulantes
## A un design basé sur [AdminLTE 3](https://adminlte.io/themes/dev/AdminLTE/index.html) (BootStrap 4).
Version en cours : [github.com/ColorlibHQ/AdminLTE](https://github.com/ColorlibHQ/AdminLTE)
## Permet de gérer les utilisateurs (avec les pages de profil) :
- Standard Asp.Net Users.
 -Intégration des pages avec le design d’AdminLTE
## Permet de gérer des tables de bases, avec du multifenêtrage ou en utilisant des pages dédiées.
A partir des modèles (et donc aussi du contexte de la base de données), seront générés :
- Les contrôleurs web Api, gérant le CRUD (pour create, read, update, delete)
- Les contrôleurs web gérant le CRUD
- Les vues (pages Web) liées aux contrôleurs web et se servant des contrôleurs web Api.

Remarque : l’interface utilisateur s’inspire de celle utilisée dans le [projet opensource Serene](https://github.com/volkanceylan/Serene) (basé sur [Serenity](https://serenity.is/)). Par exemple : utilisation de jQuery Dialog, SlickGrid, Select2.
