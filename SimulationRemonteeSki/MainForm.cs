using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimulationRemonteeSki
{
    public partial class MainForm : Form
    {
        EtatSimulation _etatSimulation;
        Dictionary<string, int> indexTableau;
        public MainForm()
        {
            InitializeComponent();

            SimulationSystemeMultiples.tempsSortie = (double)(1/(numCadenceSortie.Value)/60);

            SimulationSystemeMultiples.tempsMoyenEntree = (double)(1/(numCadenceEntree.Value)/60);

            SimulationSystemeMultiples.nbStations = (int)numStations.Value;

            indexTableau = new Dictionary<string, int>();
            int index = dgvSortie.Rows.Add();
            dgvSortie.Rows[index].Cells["dgvNomValeur"].Value = "Moyenne de personnes dans la file d'attente";
            indexTableau.Add("MoyenneFile", index);


            index = dgvSortie.Rows.Add();
            dgvSortie.Rows[index].Cells["dgvNomValeur"].Value = "Temps d'attente systeme moyen";
            indexTableau.Add("AttenteMoyen", index);


            index = dgvSortie.Rows.Add();
            dgvSortie.Rows[index].Cells["dgvNomValeur"].Value = "Cadence d'arrivée moyenne";
            indexTableau.Add("ArriveeMoyenne", index);


            index = dgvSortie.Rows.Add();
            dgvSortie.Rows[index].Cells["dgvNomValeur"].Value = "Cadence de sortie moyenne";
            indexTableau.Add("SortieMoyenne", index);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (_etatSimulation)    
            {
                case EtatSimulation.Arret:
                    uc_PopulationFileAttente1.Effacer();
                    SimulationSystemeMultiples.EffacerSimulation();
                    SimulationSystemeMultiples.Init();
                    rtbHistorique.Clear();
                    timerIntervalle.Enabled = true;
                    button1.Text = "Stopper la simulation";
                    _etatSimulation = EtatSimulation.Lecture;
                    dtpDebut.Enabled = false;
                    dtpFin.Enabled = false;
                    numCadenceSortie.Enabled = false;
                    numCadenceEntree.Enabled = false;
                    numStations.Enabled = false;
                    break;
                case EtatSimulation.Lecture:
                    timerIntervalle.Enabled = false;
                    button1.Text = "Reprendre la simulation";
                    _etatSimulation = EtatSimulation.Pause;
                    break;
                case EtatSimulation.Pause:
                    timerIntervalle.Enabled = true;
                    button1.Text = "Stopper la simulation";
                    _etatSimulation = EtatSimulation.Lecture;
                    break;
                default:
                    break;
            }
        }

        private void timerIntervalle_Tick(object sender, EventArgs e)
        {
            StructureEvenement evenement = SimulationSystemeMultiples.Simulation();
            uc_PopulationFileAttente1.AjoutEvenement(evenement);
            uc_Evenement1.AjoutEvenement(evenement);
            if (evenement.secteur>0)
                rtbHistorique.Text += this.dtpDebut.Value.AddMinutes(evenement.dateEvenement).ToString("hh:mm:ss") +" - "+ evenement.nombrePersonne +" nouvelle(s) sortie(s)\n";
            else
                rtbHistorique.Text += this.dtpDebut.Value.AddMinutes(evenement.dateEvenement).ToString("hh:mm:ss") + " - " + evenement.nombrePersonne + " nouvelle(s) entrée(s)\n";
            pnScroll.HorizontalScroll.Value = pnScroll.HorizontalScroll.Maximum;
            pnScroll2.HorizontalScroll.Value = pnScroll2.HorizontalScroll.Maximum;

            CalculTableau();

            if (this.dtpDebut.Value.AddMinutes(evenement.dateEvenement) >= dtpFin.Value)
                FinAnimation();
        }

        private void CalculTableau()
        {
            decimal lambda = numCadenceEntree.Value;
            decimal mu = numCadenceSortie.Value;
            decimal temp = mu - lambda;
            decimal ro = lambda / mu;
            dgvSortie.Rows[indexTableau["MoyenneFile"]].Cells["dgvCalcule"].Value = ((lambda * lambda) / (2 * mu * temp)) / numStations.Value;
            dgvSortie.Rows[indexTableau["MoyenneFile"]].Cells["dgvSimule"].Value = SimulationSystemeMultiples.nombrePersonnesMoyen;

            dgvSortie.Rows[indexTableau["AttenteMoyen"]].Cells["dgvCalcule"].Value = (ro / (2 * mu * (1 - ro)))*60*numStations.Value;
            dgvSortie.Rows[indexTableau["AttenteMoyen"]].Cells["dgvSimule"].Value = SimulationSystemeMultiples.tempsMoyenSysteme;

            dgvSortie.Rows[indexTableau["ArriveeMoyenne"]].Cells["dgvCalcule"].Value = numCadenceEntree.Value;
            dgvSortie.Rows[indexTableau["ArriveeMoyenne"]].Cells["dgvSimule"].Value = SimulationSystemeMultiples.nbEntreeMoyenne / 60;

            dgvSortie.Rows[indexTableau["SortieMoyenne"]].Cells["dgvCalcule"].Value = numCadenceSortie.Value;
            dgvSortie.Rows[indexTableau["SortieMoyenne"]].Cells["dgvSimule"].Value = SimulationSystemeMultiples.nbSortieMoyenne / 60;
        }

        private void FinAnimation()
        {
            timerIntervalle.Enabled = false;
            button1.Text = "Lancer la simulation";
            _etatSimulation = EtatSimulation.Arret;
        }

        private enum EtatSimulation
        {
            Arret,
            Lecture,
            Pause
        }

        private void numCadenceSortie_ValueChanged(object sender, EventArgs e)
        {
            SimulationSystemeMultiples.tempsSortie = (double)(1/numCadenceSortie.Value/60);
        }

        private void numCadenceEntree_ValueChanged(object sender, EventArgs e)
        {
            SimulationSystemeMultiples.tempsMoyenEntree = (double)(1 / numCadenceEntree.Value/60);
        }

        private void numStations_ValueChanged(object sender, EventArgs e)
        {
            SimulationSystemeMultiples.nbStations = (int)numStations.Value;
        }

        private void pnScroll_Scroll(object sender, ScrollEventArgs e)
        {
            pnScroll2.HorizontalScroll.Value = pnScroll.HorizontalScroll.Value;
        }

        private void pnScroll2_Scroll(object sender, ScrollEventArgs e)
        {
            pnScroll.HorizontalScroll.Value = pnScroll2.HorizontalScroll.Value;
        }
    }
}
