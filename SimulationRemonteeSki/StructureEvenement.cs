using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationRemonteeSki
{
    struct StructureEvenement
    {
        public int secteur;                 //Si 0 entrée dans la file d'attente
        public DateTime dateEvenement;
        public int nombrePersonne;          //Nombre de personnes en sortie
    }
}
