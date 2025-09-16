# Formes Geometriques en C#

## Description
Ce projet est une application console en C# (.NET Framework) permettant de manipuler des formes geometriques :
- Cercle
- Rectangle
- Carre
- Triangle
- Point
- Zone (ensemble de formes)

Objectifs principaux :
- Mise en pratique de la programmation orientee objet (POO)
- Utilisation de classes abstraites, heritage et polymorphisme
- Ajout de tests unitaires avec MSTest
- Code entierement commente pour faciliter la comprehension

---

## Fonctionnalites
- Creation et manipulation de differentes formes geometriques
- Calcul automatique de :
  - Aire
  - Perimetre
- Gestion des coordonnees avec la classe Point
- Classe Zone permettant de regrouper plusieurs formes et de calculer leur aire et perimetre total
- Tests unitaires pour verifier les calculs

---

## Structure du projet
```
FormesGeometriques/
│
├── Program.cs          # Point d'entree du programme
├── Forme.cs            # Classe abstraite Forme
├── Cercle.cs           # Classe Cercle (heritage de Forme)
├── Rectangle.cs        # Classe Rectangle (heritage de Forme)
├── Carre.cs            # Classe Carre (heritage de Rectangle)
├── Triangle.cs         # Classe Triangle (heritage de Forme)
├── Point.cs            # Classe Point (coordonnees X, Y)
├── Zone.cs             # Classe Zone (collection de Formes)
└── Tests/              # Projet de tests unitaires (MSTest)
    ├── CercleTests.cs
    ├── RectangleTests.cs
    └── ...
```

---

## Exemple d'utilisation
Extrait de `Program.cs` :

```csharp
Console.WriteLine("=== Demonstration Formes Geometriques ===\n");

// Cercle
Forme cercle = new Cercle(5);
Console.WriteLine($">> Cercle : Perimetre = {cercle.Perimetre():F2}, Aire = {cercle.Aire():F2}");

// Rectangle
Point centreRectangle = new Point(2, 3);
Rectangle rectangle = new Rectangle(10, 5, centreRectangle);
Console.WriteLine($">> Rectangle au centre {rectangle.Centre} : Perimetre = {rectangle.Perimetre()}, Aire = {rectangle.Aire()}");

// Zone
Zone zone = new Zone();
zone.AjouterForme(cercle);
zone.AjouterForme(rectangle);
Console.WriteLine($">> Zone : Aire totale = {zone.AireTotale():F2}, Perimetre total = {zone.PerimetreTotal():F2}");
```

### Resultat attendu dans la console :
```
=== Demonstration Formes Geometriques ===

>> Cercle : Perimetre = 31,42, Aire = 78,54
>> Rectangle au centre (2, 3) : Perimetre = 30, Aire = 50
>> Zone : Aire totale = 128,54, Perimetre total = 61,42
```

---

## Tests unitaires
Les tests unitaires sont realises avec MSTest.  
Exemple : `CercleTests.cs`

```csharp
[TestClass]
public class CercleTests
{
    [TestMethod]
    public void Aire_Rayon1_DoitDonnerPI()
    {
        Cercle c = new Cercle(1);
        Assert.AreEqual(Math.PI, c.Aire(), 0.001);
    }

    [TestMethod]
    public void Perimetre_Rayon1_DoitDonner2PI()
    {
        Cercle c = new Cercle(1);
        Assert.AreEqual(2 * Math.PI, c.Perimetre(), 0.001);
    }
}
```

---

## Concepts utilises
- Programmation Oriente Objet (POO)
  - Abstraction (`Forme`)
  - Heritage (`Rectangle` <- `Forme`, `Carre` <- `Rectangle`)
  - Polymorphisme (`Aire()` et `Perimetre()` definis dans chaque forme)
- Tests unitaires avec MSTest
- Bonnes pratiques :
  - Nommage en PascalCase pour les classes et methodes
  - Nommage en camelCase pour les variables
  - Code commente et lisible

---

## Auteur
Projet developpe par Jack dans le cadre des revisions POO en C#.
