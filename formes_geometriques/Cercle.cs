using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formes_geometriques
{
    // Cercle hérite de Forme (il doit donc définir Aire() et Perimetre())
    public class Cercle : Forme
    {
        // Attribut privé pour stocker le rayon du cercle
        private double rayon;

        // Constructeur : permet de créer un cercle en donnant son rayon
        public Cercle(double rayon)
        {
            this.rayon = rayon;
        }

        // Implémentation du calcul du périmètre
        // Formule : 2 × π × rayon
        public override double Perimetre()
        {
            return 2 * Math.PI * rayon;
        }

        // Implémentation du calcul de l'aire
        // Formule : π × rayon²
        public override double Aire()
        {
            return Math.PI * rayon * rayon;
        }
    }
}
