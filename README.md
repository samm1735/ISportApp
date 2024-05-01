# ISportApp

## Devoir III - Application mobile developpée avec .Net MAUI pour faire des requetes a un API de Sport "(https://www.thesportsdb.com/free_sports_api)". Ce projet consiste a donner des informations de sport, plus précisément de Football.
### Cours
- C# II
  
## Nom et prénom
- ISAAC Sammuel Ramclief

## App Preview

### Recherche de joueur
- Avec la possibilité de voir plus de details sur les joueurs
<img src="https://github.com/samm1735/ISportApp/blob/main/Media_240430_185202.gif" alt="App preview" width="200" height="350">

### Recherche de joueur avec plus d'images
<img src="https://github.com/samm1735/ISportApp/blob/main/Media_240430_185435.gif" alt="App preview" width="200" height="350">

### Recherche d'anciens matchs entre 2 équipes
<img src="https://github.com/samm1735/ISportApp/blob/main/Media_240430_185612.gif" alt="App preview" width="200" height="350">


### Details sur le developpeur
- Avec la possibilité de cliquer et d'ouvrir une application externe
<img src="https://github.com/samm1735/ISportApp/blob/main/Media_240430_185844.gif" alt="App preview" width="200" height="350">



## Description
Application mobile developpée avec .Net MAUI pour onner des informations de football.

Le projet utilise le système de design MVVM.
Par conséquent notre folder structure est la suivante.

```csharp
///                   Models    |
///                             |--> SearchedPlayer.cs    // Notre modèle pour les jouers de football
///                             |--> SearchedEvents.cs    // Notre modèle pour les matchs de football
///                             |--> Constants.cs   // Pour des variables constantes - Mainly used for databse integration
///                   
///                   
///                   Services  |
///                             |--> DatabaseService.cs    // Définition des méthodes de création de table, insertion et update de champs.
///                             |--> SearchingEventService.cs  // Requetes API et retourne une instance de SearchedEvents
///                             |--> SearchingPlayerService.cs  // Requetes API et retourne une instance de SearchedPlayer
///                                                             
///                   ViewModels|
///                             |--> MainPageViewModel.cs    // Utilisée pour le Binding de Views.MainPage.
///                             |--> PlayerDetailsViewModel.cs  // Utilisée pour le Binding de Views.PlayerDetails.
///                             |--> SearchingEventViewModel.cs  // Utilisée pour le Binding de Views.SearchingEventPage.
///                             |--> SearchingPlayerViewModel.cs  // Utilisée pour le Binding de Views.SearchingPlayerPage.
///                   
/// 
/// 
///                   Views     |
///                             |--> MainPage.xaml    // La page principale
///                             |--------> MainPage.xaml.cs //Le code behind de la page principale
///                             |--> PlayerDetails.xaml    // La page utilisée pour les details des joueurs
///                             |--> SearchingEventPage.xaml    // La page utilisée pour les matchs
///                             |--> SearchingPlayerPage.xaml    // La page utilisée la recherche de jouers
///                             
```                         

## Nuget Packages utilisés
- CommunityToolkit.mvvm
- CommunityToolkit.maui
- sqlite-net-pcl
- SQLitePCLRaw.bundle_green
- NewtonSoft

### Liens importants
- [ThheSportsDB](https://www.thesportsdb.com/free_sports_api)
- [Whatsapp du developpeur](https://wa.me/50932424951)
- [E-Mail du developpeur](mailto:ramclief17@gmail.com)



