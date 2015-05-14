using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace SimulationRemonteeSki
{
    public partial class Uc_PopulationFileAttente : UserControl
    {
        /// <summary>
        /// Nombre de pixel par unité de temps
        /// </summary>
        [Description("Valeur de la hauteur sur l'axe vertical"), Category("Diagram")]
        public int PixelParUT { get; set; }

        // TODO Vincent Guagno : A supprimer 
        [Description("Valeur de la hauteur sur l'axe vertical"), Category("Diagram")]
        public int Hauteur { get; set; }

        [Description("Definition sur l'axe vertical (en entier)"), Category("Diagram")]
        public int DefinitionVerticale { get; set; }

        [Description("Correspond à la définition sur l'axe horizontal (en entier)"), Category("Diagram")]
        public int NombreClasse { get; set; }
        
        public int[] NombreValeurIntervalle;
        public int[] NombreValeurIntervallePoisson;
        private double tailleIntervalle;

        public Uc_PopulationFileAttente()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Rafraichir();
        }

        public void Rafraichir()
        {
            using (Graphics gr = this.CreateGraphics())
            {
                gr.Clear(Color.White);

                //Dessin des différents bâtons
                if (NombreValeurIntervalle != null)
                {
                    for (int i = 0; i < NombreClasse; i++)
                    {

                        Point pos1 = new Point(20 + ((this.Width - 40) / NombreClasse * i), this.Height - 20 - (int)(((double)(this.Height - 40)) * NombreValeurIntervalle[i] / ((double)Hauteur)));
                        Point taille = new Point(((this.Width - 40) / NombreClasse), (int)(((double)(this.Height - 40)) * NombreValeurIntervalle[i] / ((double)Hauteur)));
                        gr.FillRectangle(new SolidBrush(Color.OrangeRed), pos1.X, pos1.Y - 5, taille.X, taille.Y + 5);
                    }
                    /*
                    for (int i = 0; i < NombreClasse; i++)
                    {
                        Point pos1 = new Point(20 + ((this.Width - 40) / NombreClasse * i), this.Height - 20 - (int)(((double)(this.Height - 40)) * NombreValeurIntervallePoisson[i] / ((double)Hauteur)));
                        Point taille = new Point(((this.Width - 40) / NombreClasse), (int)(((double)(this.Height - 40)) * NombreValeurIntervallePoisson[i] / ((double)Hauteur)));
                        gr.FillRectangle(new SolidBrush(Color.DeepSkyBlue), pos1.X, pos1.Y - 5, taille.X, taille.Y + 5);
                    }
                    */
                }

                AdjustableArrowCap bigArrow = new AdjustableArrowCap(5, 5);
                Pen p = new Pen(Color.Blue, 1);
                p.CustomEndCap = bigArrow;
                gr.DrawLine(p, 20, this.Height - 10, 20, 10);
                gr.DrawLine(p, 10, this.Height - 20, this.Width - 10, this.Height - 20);

                //Dessin des aides sur l'axe vertical  
                Pen p1 = new Pen(Color.Black, 1);
                for (int i = 0; i < DefinitionVerticale; i++)
                {
                    Point position = new Point(20, 20 + (this.Height - 30) - ((this.Height - 30) / DefinitionVerticale * (i + 1)));
                    gr.DrawLine(p1, position.X - 5, position.Y, position.X + 5, position.Y);
                    gr.DrawString((Hauteur / DefinitionVerticale * (i + 1)).ToString(), new Font("Arial", 8), new SolidBrush(Color.Black), new PointF(position.X - 20, position.Y));
                }

                //Dessin des aides sur l'axe horizontal
                for (int i = 0; i < NombreClasse; i++)
                {
                    Point position = new Point(20 + ((this.Width - 40) / NombreClasse * (i + 1)), this.Height - 20);
                    gr.DrawLine(p1, position.X, position.Y - 5, position.X, position.Y + 5);
                    //gr.DrawString(Math.Round((i + 1) * tailleIntervalle, 2).ToString(), new Font("Arial", 8), new SolidBrush(Color.Black), new PointF(position.X, position.Y + 5));
                }
            }
        }
        public void DessinerDiagram(double[] tabD)
        {
            double valeurMax = tabD.Max();
            double valeurMin = 0d;
            tailleIntervalle = (valeurMax - valeurMin) / (double)NombreClasse;
            int[] nbValeurIntervalle = new int[NombreClasse];
            if (!IsProcessusPoisson)
            {
                for (int i = 0; i < NombreClasse; i++)
                {
                    nbValeurIntervalle[i] = 0;
                    foreach (double d in tabD)
                    {
                        if (d <= tailleIntervalle * (i + 1) && d > tailleIntervalle * i)
                            nbValeurIntervalle[i]++;
                    }
                }
            }
            else
            {
                for (int i = 0; i < NombreClasse; i++)
                {
                    nbValeurIntervalle[i] = 0;
                    foreach (double d in tabD)
                    {
                        if (d <= tailleIntervalle * (i + 1) && d > tailleIntervalle * i && nbValeurIntervalle[i] < 1)
                            nbValeurIntervalle[i]++;
                    }
                }
            }
            NombreValeurIntervalle = nbValeurIntervalle;
            Rafraichir();
        }

        internal void DessinerDiagram(int[] tabI)
        {
            double valeurMax = tabI.Max();
            double valeurMin = 0d;
            tailleIntervalle = (valeurMax - valeurMin) / (double)NombreClasse;
            int[] nbValeurIntervalle = new int[NombreClasse];
            for (int i = 0; i < NombreClasse; i++)
            {
                nbValeurIntervalle[i] = 0;
                foreach (int d in tabI)
                {
                    if (d <= tailleIntervalle * (i + 1) && d > tailleIntervalle * i)
                        nbValeurIntervalle[i]++;
                }
            }
            NombreValeurIntervalle = nbValeurIntervalle;
            Rafraichir();
        }
    }
}
