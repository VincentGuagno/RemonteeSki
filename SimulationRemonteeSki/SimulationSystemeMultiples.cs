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
        public static int nbStations { get; set; } // 2 nombre de station
        public static double tempsMoyenEntree { get; set; } // 3 Temps moyen d'arrivée
        public static double tempsSortie { get; set; } // 4 Temps de service moyen

        static double dateDeFin = 1.0e7;
        static double temps = 0.0; // Temps actuel
        static double dateEntree; // Tableau des temps avant le prochain évènement d'entrée 
        static Dictionary<int, double> dateSortie; // Temps avant le prochain évènement de sortie
        static long nbFileAttente = 0; // Nombre de personnes dans la file d'attente
        static double nbSortieSysteme = 0; // Nombre de personnes sortie du système
        static double nbEntreeSysteme = 0; // Nombre de personnes entree dans le système
        static double aireNbPersonneSysteme = 0.0; // Nombre de personne dans le système
        static double tempsDernierEvenement = temps; // Date du dernier evenement
        static double debit; // Débit

        public static double nombrePersonnesMoyen { get; private set; } // Nombre moyen de personne dans le système
        public static double tempsMoyenSysteme { get; private set; } //Temps moyen passé dans le système
        public static double nbSortieMoyenne { get; private set; } //Temps moyen passé dans le système
        public static double nbEntreeMoyenne { get; private set; } //Temps moyen passé dans le système

        public static void Init()
        {
            if (rand == null)
                rand = new Random();
            dateSortie = new Dictionary<int, double>();
            for (int i = 1;i<nbStations+1;i++)
            {
                //si deux station
                //premiere sortie de la station 1 à tempsMoyenSortie
                //première sortie de la station 2 à tempsMoyenSortie+1/2tempsMoyenSortie
                dateSortie.Add(i,tempsSortie+(tempsSortie/nbStations*(i-1)));
            }
        }

        public static StructureEvenement Simulation()
        {

            StructureEvenement evenementSimule = new StructureEvenement();

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
                    dateSortie[dateSortieMin.Key] = temps + tempsSortie;
                    evenementSimule = ProcessusEntree();
                }
            }

            debit = nbSortieSysteme / (temps/60); // Debit de sortie
            nombrePersonnesMoyen = aireNbPersonneSysteme / (temps / 60); // Moyenne du nombre de personne dans le système
            tempsMoyenSysteme = nombrePersonnesMoyen / debit; // Temps moyen passé dans le système
            nbSortieMoyenne = nbSortieSysteme / temps ;
            nbEntreeMoyenne = nbEntreeSysteme / temps ;
            return evenementSimule;
        }

        private static StructureEvenement ProcessusSortie(int numStation)
        {
            dateSortie.TryGetValue(numStation, out temps);
            // Mise à jour de l'aire sous la courbe "aireNbPersonneSysteme"
            aireNbPersonneSysteme = aireNbPersonneSysteme + nbFileAttente * (temps - tempsDernierEvenement); 
            nbFileAttente--;
            tempsDernierEvenement = temps;
            nbSortieSysteme++;
            dateSortie[numStation] = temps + tempsSortie;
            return new StructureEvenement(numStation, temps, 1);

        }

        private static StructureEvenement ProcessusEntree()
        {
            temps = dateEntree;
            // Mise à jour de l'aire sous la courbe "aireNbPersonneSysteme"
            aireNbPersonneSysteme = aireNbPersonneSysteme + nbFileAttente * (temps - tempsDernierEvenement);
            nbFileAttente++;
            nbEntreeSysteme++;
            tempsDernierEvenement = temps;

            for (int i=1;i<nbStations+1;i++ )
            {
                while (dateSortie[i]<temps)
                    dateSortie[i] += tempsSortie;
            }

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

        internal static void EffacerSimulation()
        {
            dateDeFin = 0;
            temps = 0;
            nbFileAttente = 0;
            nbSortieSysteme = 0;
            tempsDernierEvenement = 0;
            nombrePersonnesMoyen = 0;
            tempsMoyenSysteme = 0;
        }
    }
}
