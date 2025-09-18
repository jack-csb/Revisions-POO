
# Formes Géométriques en C#

## Description
Ce projet est une projet console en C# permettant de manipuler des formes géométriques simples :
- Cercle
- Rectangle
- Point

Objectifs principaux :
- Mise en pratique de la programmation orientée objet (POO)
- Héritage et classes abstraites (`Forme`)
- Ajout de tests unitaires avec MSTest

---

## Prérequis
Pour exécuter et tester ce projet, vous devez avoir installé le **.NET SDK** :  
👉 [Télécharger le .NET SDK](https://dotnet.microsoft.com/fr-fr/download/visual-studio-sdks?cid=getdotnetsdk)

---

## Structure du projet
```
FormesGeometriques/
│
├── Program.cs          # Point d'entrée du programme
├── Forme.cs            # Classe abstraite Forme
├── Cercle.cs           # Classe Cercle
├── Rectangle.cs        # Classe Rectangle
├── Point.cs            # Classe Point
│
└── Tests/              # Projet de tests unitaires
    ├── CercleTests.cs
    ├── RectangleTests.cs
    └── PointTests.cs
```

---

## Exemple d'utilisation
Dans `Program.cs` :

```csharp
Console.WriteLine("=== Démonstration Formes Géométriques ===");

Forme cercle = new Cercle(5);
Console.WriteLine($"Cercle : Périmètre = {cercle.Perimetre()}, Aire = {cercle.Aire()}");

Rectangle rectangle = new Rectangle(4, 6);
Console.WriteLine($"Rectangle : Périmètre = {rectangle.Perimetre()}, Aire = {rectangle.Aire()}");

Point p1 = new Point(0, 0);
Point p2 = new Point(3, 4);
Console.WriteLine($"Distance entre {p1} et {p2} = {p1.Distance(p2)}");
```

---

## Tests unitaires
Des tests unitaires sont inclus pour vérifier les calculs de base (`Cercle`, `Rectangle`, `Point`).  
Ils utilisent **MSTest**.

### Lancer les tests
1. Ouvrir Visual Studio  
2. Menu **Test → Fenêtres → Explorateur de tests**  
3. Appuyer sur **`Ctrl + R, A`** pour exécuter tous les tests  

👉 Les résultats s’affichent en ✅ vert si tout est correct.

---

## Auteur
Projet réalisé par Jack dans le cadre des révisions POO en C#.
