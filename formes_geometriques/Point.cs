using System;

namespace formes_geometriques
{
    // Classe qui représente un point dans un plan 2D
    public class Point
    {
        // Coordonnées du point
        public double X { get; set; }
        public double Y { get; set; }

        // Constructeur pour créer un point avec ses coordonnées
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        // Méthode pour calculer la distance entre deux points
        public double Distance(Point autre)
        {
            double dx = autre.X - this.X;
            double dy = autre.Y - this.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }

        // Redéfinition de ToString() pour afficher joliment le point
        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }
}
