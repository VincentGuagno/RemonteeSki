using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationRemonteeSki
{
    class Program
    {
        static Random rand;
        static double dateDeFin = 1.0e7;
        static double tempsMoyenEntree = 3.0; // Temps moyen d'arrivée
        static double tempsMoyenSortie = 4.0; // Temps de service moyen
        static double temps = 0.0; // Temps actuel
        static double dateEntree = 0.0; // Temps avant le prochain évènement d'entrée 
        static double dateSortie = dateDeFin; // Temps avant le prochain évènement de sortie
        static long nbFileAttente = 0; // Nombre de personnes dans la file d'attente
        static double nbSortieSysteme = 0.0; // Nombre de personnes sortie du système
        static double aireNbPersonneSysteme = 0.0; // Nombre de personne dans le système
        static double tempsDernierEvenement = temps; // Date du dernier evenement
        static double tempsDernierTraitement; // Date de dernier traitement
        static double debit; // Débit
        static double nombrePersonnesMoyen; // Nombre moyen de personne dans le système
        static double tempsMoyenSysteme; //Temps moyen passé dans le système

        static void Main(string[] args)
        {
            rand = new Random();


            while (temps < dateDeFin)
            {
                if (dateEntree < dateSortie) // Arrivé
                {
                    #region Processus d'entrée

                    temps = dateEntree;
                    aireNbPersonneSysteme = aireNbPersonneSysteme + nbFileAttente * (temps - tempsDernierEvenement); // Mise à jour de l'aire sous la courbe "aireNbPersonneSysteme"
                    nbFileAttente++;
                    tempsDernierEvenement = temps; 
                    dateEntree = temps + expntl(tempsMoyenEntree);
                    if (nbFileAttente == 1)
                    {
                        tempsDernierTraitement = temps;
                        dateSortie = temps + tempsMoyenSortie;
                    }

                    #endregion
                }
                else // Sortie
                {
                    #region Processus de sortie

                    temps = dateSortie;
                    aireNbPersonneSysteme = aireNbPersonneSysteme + nbFileAttente * (temps - tempsDernierEvenement); // Mise à jour de l'aire sous la courbe "aireNbPersonneSysteme"
                    nbFileAttente--;
                    tempsDernierEvenement = temps;
                    nbSortieSysteme++;
                    if (nbFileAttente > 0)
                    {
                        dateSortie = temps + tempsMoyenSortie;
                    }
                    else
                    {
                        dateSortie = dateDeFin;
                    }

                    #endregion
                }
            }
            debit = nbSortieSysteme / temps; // Debit de sortie
            nombrePersonnesMoyen = aireNbPersonneSysteme / temps; // Moyenne du nombre de personne dans le système
            tempsMoyenSysteme = nombrePersonnesMoyen / debit; // Temps moyen passé dans le système
            // Output results

            Console.WriteLine("================================================================\n");
            Console.WriteLine("= *** Results from M/D/1 Simulation *** \n");
            Console.WriteLine("================================================================\n");
            Console.WriteLine("= Total simulated time = "+dateDeFin+" sec");
            Console.WriteLine("================================================================\n");
            Console.WriteLine("= INPUTS: \n");
            Console.WriteLine("= Mean time between arrivals = "+ tempsMoyenEntree);
            Console.WriteLine("= Mean service time ="+ tempsMoyenSortie);
            Console.WriteLine("=============================================================== \n");
            Console.WriteLine("= OUTPUTS: \n");
            Console.WriteLine("= Number of customers = "+ nbSortieSysteme);
            Console.WriteLine("= Throughput rate = "+ debit);
            Console.WriteLine("= Mean number in system = " + nombrePersonnesMoyen);
            Console.WriteLine("= Mean residence time = " + tempsMoyenSysteme);
            Console.WriteLine("============================================================== \n");
            Console.ReadKey();

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
    }
}
