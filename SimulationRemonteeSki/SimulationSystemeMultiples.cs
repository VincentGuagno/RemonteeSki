using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationRemonteeSki
{
    class SimulationSystemeMultiples
    {
        static Random rand;
        static int nbStations = 3;
        static double dateDeFin = 1.0e7;
        static double tempsMoyenEntree = 3.0; // Temps moyen d'arrivée
        static double tempsMoyenSortie = 4.0; // Temps de service moyen
        static double temps = 0.0; // Temps actuel
        static double dateEntree; // Tableau des temps avant le prochain évènement d'entrée 
        static Dictionary<int, double> dateSortie = new Dictionary<int, double>() { { 1, 0.5 }, { 2, 1 }, { 3, 1.5 }, { 4, 2 }, { 5, 2.5 } }; // Temps avant le prochain évènement de sortie
        static long nbFileAttente = 0; // Nombre de personnes dans la file d'attente
        static double nbSortieSysteme = 0.0; // Nombre de personnes sortie du système
        static double aireNbPersonneSysteme = 0.0; // Nombre de personne dans le système
        static double tempsDernierEvenement = temps; // Date du dernier evenement
        static double tempsDernierTraitement; // Date de dernier traitement
        static double debit; // Débit
        static double nombrePersonnesMoyen; // Nombre moyen de personne dans le système
        static double tempsMoyenSysteme; //Temps moyen passé dans le système

        public static StructureEvenement Simulation()
        {
            StructureEvenement evenementSimule = new StructureEvenement();
            if (rand == null)
                rand = new Random();

            {
                KeyValuePair<int, double> dateSortieMin;
                dateSortieMin = dateSortie.First();
                foreach (var item in dateSortie)
                {
                    if (item.Value < dateSortieMin.Value)
                    {
                        dateSortieMin = item;
                    }
                }
                if (dateEntree > dateSortieMin.Value && nbFileAttente > 0)
                    evenementSimule = ProcessusSortie(dateSortieMin.Key);
                else
                {
                    dateSortie[dateSortieMin.Key] = dateSortie[dateSortieMin.Key] + tempsMoyenSortie;
                    evenementSimule = ProcessusEntree();
                }
            }

            debit = nbSortieSysteme / temps; // Debit de sortie
            nombrePersonnesMoyen = aireNbPersonneSysteme / temps; // Moyenne du nombre de personne dans le système
            tempsMoyenSysteme = nombrePersonnesMoyen / debit; // Temps moyen passé dans le système
            return evenementSimule;
        }

        private static StructureEvenement ProcessusSortie(int numStation)
        {
            dateSortie.TryGetValue(numStation, out temps);
            aireNbPersonneSysteme = aireNbPersonneSysteme + nbFileAttente * (temps - tempsDernierEvenement); // Mise à jour de l'aire sous la courbe "aireNbPersonneSysteme"
            nbFileAttente--;
            tempsDernierEvenement = temps;
            nbSortieSysteme++;
            dateSortie[numStation] = temps + tempsMoyenSortie;
            return new StructureEvenement(numStation, temps, 1);

        }

        private static StructureEvenement ProcessusEntree()
        {
            temps = dateEntree;
            aireNbPersonneSysteme = aireNbPersonneSysteme + nbFileAttente * (temps - tempsDernierEvenement); // Mise à jour de l'aire sous la courbe "aireNbPersonneSysteme"
            nbFileAttente++;
            tempsDernierEvenement = temps;
            dateEntree = temps + expntl(tempsMoyenEntree);
            return new StructureEvenement(0, temps, 1);

        }

        static double expntl(double x)
        {
            double z; // Uniform random number from 0 to 1
            // Pull a uniform RV (0 < z < 1)
            do
            {
                z = rand.NextDouble();

            }
            while ((z == 0) || (z == 1));
            return (-x * Math.Log(z));
        }


        public static void EffacerSimulation()
        {
            temps = 0;
            dateEntree = 0;
            dateSortie = new Dictionary<int, double>() { { 1, 0.5 }, { 2, 1 }, { 3, 1.5 }, { 4, 2 }, { 5, 2.5 } };
            nbFileAttente = 0;
            nbSortieSysteme = 0.0; 
            aireNbPersonneSysteme = 0.0; 
            tempsDernierEvenement = temps;
            tempsDernierTraitement = 0;
            debit = 0;
            nombrePersonnesMoyen = 0; 
            tempsMoyenSysteme = 0;
        }
        /*regarde si date d'entrée > à une des dates de sorties pour les stations
        static void tuTiresOuTuPointes (int dateEntree) 
        {
            KeyValuePair<int, double> dateSortieMin;
            dateSortieMin = dateSortie.First();
            foreach(var item in dateSortie)
            {
                if (item.Value < dateSortieMin.Value)
                {
                    dateSortieMin = item;
                }
            }
                if (dateEntree > dateSortieMin.Value || nbFileAttente >0)
                    ProcessusSortie(dateSortieMin.Key);
                else
                    ProcessusEntree();
        }
        
        //tableau de stations avec les dates des prochains évènements de sortie*/
    }
}
