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
        public MainForm()
        {
            InitializeComponent();
            int index = dgvSortie.Rows.Add();
            dgvSortie.Rows[index].Cells["dgvNomValeur"].Value = "Moyenne de personnes dans la file d'attente";
            dgvSortie.Rows[index].Cells["dgvSimule"].Value = 20;
            dgvSortie.Rows[index].Cells["dgvCalcule"].Value = 18;


            index = dgvSortie.Rows.Add();
            dgvSortie.Rows[index].Cells["dgvNomValeur"].Value = "Temps d'attente systeme moyen";
            dgvSortie.Rows[index].Cells["dgvSimule"].Value = 3.3;
            dgvSortie.Rows[index].Cells["dgvCalcule"].Value = 2.25;


            index = dgvSortie.Rows.Add();
            dgvSortie.Rows[index].Cells["dgvNomValeur"].Value = "Cadence d'arrivée moyenne";
            dgvSortie.Rows[index].Cells["dgvSimule"].Value = 312;
            dgvSortie.Rows[index].Cells["dgvCalcule"].Value = 300;


            index = dgvSortie.Rows.Add();
            dgvSortie.Rows[index].Cells["dgvNomValeur"].Value = "Cadence de sortie moyenne";
            dgvSortie.Rows[index].Cells["dgvSimule"].Value = 389;
            dgvSortie.Rows[index].Cells["dgvCalcule"].Value = 400;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (_etatSimulation)    
            {
                case EtatSimulation.Arret:
                    uc_PopulationFileAttente1.Effacer();
                    //SimulationSystemeMultiples.EffacerSimulation();
                    rtbHistorique.Clear();
                    timerIntervalle.Enabled = true;
                    button1.Text = "Stopper la simulation";
                    _etatSimulation = EtatSimulation.Lecture;
                    dtpDebut.Enabled = false;
                    dtpFin.Enabled = false;
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

            if (this.dtpDebut.Value.AddMinutes(evenement.dateEvenement) >= dtpFin.Value)
                FinAnimation();
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
