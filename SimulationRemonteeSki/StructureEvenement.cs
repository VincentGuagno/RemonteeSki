using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationRemonteeSki
{
    public struct StructureEvenement 
    {
        public int secteur;                 //Si 0 entrée dans la file d'attente
        public double dateEvenement;
        public int nombrePersonne;          //Nombre de personnes en sortie
        public StructureEvenement(int secteur, double dateEvenement, int nombrePersonne)
        {
            this.secteur = secteur;
            this.dateEvenement = dateEvenement;
            this.nombrePersonne = nombrePersonne;
        }

    }

}
