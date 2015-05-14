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
    public partial class Form1 : Form
    {
        public Form1()
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


            rtbHistorique.Text += "09:01 - Nouvelle arrivée\n";
            rtbHistorique.Text += "09:01 - Nouvelle arrivée\n";
            rtbHistorique.Text += "09:01 - Nouvelle arrivée\n";
            rtbHistorique.Text += "09:01 - Nouvelle arrivée\n";
            rtbHistorique.Text += "09:01 - Nouvelle arrivée\n";
            rtbHistorique.Text += "09:01 - Nouvelle arrivée\n";
            rtbHistorique.Text += "09:01 - Nouvelle arrivée\n";
            rtbHistorique.Text += "09:01 - Nouvelle arrivée\n";
            rtbHistorique.Text += "09:01 - Nouvelle arrivée\n";
            rtbHistorique.Text += "09:01 - Nouvelle arrivée\n";
            rtbHistorique.Text += "09:01 - Nouvelle arrivée\n";
            rtbHistorique.Text += "09:01 - Nouvelle arrivée\n";
            rtbHistorique.Text += "09:01 - Nouvelle arrivée\n";
            rtbHistorique.Text += "09:01 - Nouvelle arrivée\n";
            rtbHistorique.Text += "09:01 - Nouvelle arrivée\n";
            rtbHistorique.Text += "09:01 - Nouvelle arrivée\n";
            rtbHistorique.Text += "09:01 - Nouvelle arrivée\n";
            rtbHistorique.Text += "09:01 - Nouvelle arrivée\n";
            rtbHistorique.Text += "09:01 - Nouvelle arrivée\n";
            rtbHistorique.Text += "09:01 - Nouvelle arrivée\n";
            rtbHistorique.Text += "09:01 - Nouvelle arrivée\n";
            rtbHistorique.Text += "09:01 - Nouvelle arrivée\n";

            rtbHistorique.Text += "10:00:00 - Nouvelle arrivée\n";
            rtbHistorique.Text += "10:01:20 - Nouvelle arrivée\n";
            rtbHistorique.Text += "10:02:00 - Nouvelle sortie\n";
            rtbHistorique.Text += "10:02:20 - Nouvelle arrivée\n";
            rtbHistorique.Text += "10:02:50 - Nouvelle arrivée\n";
            rtbHistorique.Text += "10:04:00 - Nouvelle sortie\n";
            rtbHistorique.Text += "10:04:40 - Nouvelle arrivée\n";
            rtbHistorique.Text += "10:05:30 - Nouvelle arrivée\n";
            rtbHistorique.Text += "10:06:00 - Nouvelle sortie\n";
            rtbHistorique.Text += "10:08:00 - Nouvelle sortie\n";
            rtbHistorique.Text += "10:09:50 - Nouvelle arrivée\n";
            rtbHistorique.Text += "10:10:00 - Nouvelle sortie\n";
            rtbHistorique.Text += "10:12:00 - Nouvelle sortie\n";
            rtbHistorique.Text += "10:12:50 - Nouvelle arrivée\n";

            rtbHistorique.Text += "09:01 - Nouvelle arrivée\n";
            rtbHistorique.Text += "09:01 - Nouvelle arrivée\n";
            rtbHistorique.Text += "09:01 - Nouvelle arrivée\n";
            rtbHistorique.Text += "09:01 - Nouvelle arrivée\n";
            rtbHistorique.Text += "09:01 - Nouvelle arrivée\n";
            rtbHistorique.Text += "09:01 - Nouvelle arrivée\n";
            rtbHistorique.Text += "09:01 - Nouvelle arrivée\n";
            rtbHistorique.Text += "09:01 - Nouvelle arrivée\n";
            rtbHistorique.Text += "09:01 - Nouvelle arrivée\n";
            rtbHistorique.Text += "09:01 - Nouvelle arrivée\n";
            rtbHistorique.Text += "09:01 - Nouvelle arrivée\n";
            rtbHistorique.Text += "09:01 - Nouvelle arrivée\n";
            rtbHistorique.Text += "09:01 - Nouvelle arrivée\n";
            rtbHistorique.Text += "09:01 - Nouvelle arrivée\n";
            rtbHistorique.Text += "09:01 - Nouvelle arrivée\n";
            rtbHistorique.Text += "09:01 - Nouvelle arrivée\n";
            rtbHistorique.Text += "09:01 - Nouvelle arrivée\n";
            rtbHistorique.Text += "09:01 - Nouvelle arrivée\n";
            rtbHistorique.Text += "09:01 - Nouvelle arrivée\n";
            rtbHistorique.Text += "09:01 - Nouvelle arrivée\n";
            rtbHistorique.Text += "09:01 - Nouvelle arrivée\n";
            rtbHistorique.Text += "09:01 - Nouvelle arrivée\n";


            for (int i = 0;i<400;i++)
            {
                uc_PopulationFileAttente1.AjoutEvenement(SimulationSystemeMultiples.Simulation());
            }
        }
    }
}
