using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formes_geometriques
{
    // Classe abstraite = on ne peut pas l'utiliser directement
    // Elle sert de "modèle" pour les autres formes
    public abstract class Forme
    {
        // Méthode abstraite = chaque forme doit définir son calcul de périmètre
        public abstract double Perimetre();

        // Méthode abstraite = chaque forme doit définir son calcul d'aire
        public abstract double Aire();
    }
}
