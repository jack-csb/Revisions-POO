using System;

namespace formes_geometriques
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Démonstration Formes Géométriques ===\n");

            // === Création d'un cercle ===
            Forme cercle = new Cercle(5);

            Console.WriteLine(">> Cercle");
            Console.WriteLine($"Rayon : 5");
            Console.WriteLine($"Périmètre : {cercle.Perimetre():F2}");
            Console.WriteLine($"Aire : {cercle.Aire():F2}");
            Console.WriteLine("------------------------------------\n");

            // === Création d'un rectangle ===
            Point centreRectangle = new Point(2, 3);
            Rectangle rectangle = new Rectangle(10, 5, centreRectangle);

            Console.WriteLine(">> Rectangle");
            Console.WriteLine($"Centre : {rectangle.Centre}");
            Console.WriteLine($"Longueur : {rectangle.Longueur}");
            Console.WriteLine($"Largeur : {rectangle.Largeur}");
            Console.WriteLine($"Périmètre : {rectangle.Perimetre():F2}");
            Console.WriteLine($"Aire : {rectangle.Aire():F2}");
            Console.WriteLine("------------------------------------\n");

            // === Test de la classe Point ===
            Point A = new Point(1, 2);
            Point B = new Point(1, 2);
            Point C = new Point(3, 4);

            Console.WriteLine(">> Points");
            Console.WriteLine($"Point A : {A}");
            Console.WriteLine($"Point B : {B}");
            Console.WriteLine($"Point C : {C}");

            // Comparaison des points (par coordonnées)
            if (A.X == B.X && A.Y == B.Y)
                Console.WriteLine("A et B sont égaux.");
            else
                Console.WriteLine("A et B sont différents.");

            if (A.X == C.X && A.Y == C.Y)
                Console.WriteLine("A et C sont égaux.");
            else
                Console.WriteLine("A et C sont différents.");

            // Distance entre A et C
            Console.WriteLine($"Distance entre A et C : {A.Distance(C):F2}");
            Console.WriteLine("------------------------------------\n");

            // Pause pour garder la console ouverte
            Console.WriteLine("Appuyez sur une touche pour quitter...");
            Console.ReadKey();
        }
    }
}
