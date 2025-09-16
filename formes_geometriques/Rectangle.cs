using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formes_geometriques
{
    public class Rectangle : Forme
    {
        public double Longueur { get; }
        public double Largeur { get; }
        public Point Centre { get; }

        public Rectangle(double longueur, double largeur, Point centre)
        {
            Longueur = longueur;
            Largeur = largeur;
            Centre = centre;
        }

        public override double Perimetre()
        {
            return 2 * (Longueur + Largeur);
        }

        public override double Aire()
        {
            return Longueur * Largeur;
        }

        public override string ToString()
        {
            return $"Rectangle [Centre: {Centre}, Longueur: {Longueur}, Largeur: {Largeur}, Périmètre: {Perimetre()}, Aire: {Aire()}]";
        }
    }
}