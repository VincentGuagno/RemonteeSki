using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimulationRemonteeSki
{
    public partial class Uc_Evenement : UserControl
    {
        /// <summary>
        /// Nombre de pixel par unité de temps
        /// </summary>
        [Description("Nombre de pixel par unitées de temps"), Category("Diagram")]
        public int PixelParUT { get; set; }

        /// <summary>
        /// Valeur maximale sur l'axe vertical
        /// </summary>
        [Description("Valeur maximale sur l'axe vertical"), Category("Diagram")]
        public int Hauteur { get; set; }

        [Description("Definition sur l'axe vertical (en entier)"), Category("Diagram")]
        public int DefinitionVerticale { get; set; }

        [Description("Taille des graduations horizontales (avec virgule flottante)"), Category("Diagram")]
        public double TailleGraduationHorizontale { get; set; }

        /// <summary>
        /// Date du dernier evenement permettant de calculer la taille de l'UC
        /// </summary>
        private double _date;

        /// <summary>
        /// Nombre de personne par date <date,nbPersonne>
        /// </summary>
        private Dictionary<double, int> stationParDate;

        public Uc_Evenement()
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

                if (stationParDate != null)
                {

                    stationParDate = stationParDate.OrderBy(t => t.Key).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
                    KeyValuePair<double, int> evenementPrecedent = stationParDate.First();

                    Pen redPen = new Pen(Color.Red, 1);
                    Pen bluePen = new Pen(Color.Blue, 1);
                    Pen yellowPen = new Pen(Color.Yellow, 1);
                    Pen violetPen = new Pen(Color.Violet, 1);
                    Pen OrangePen = new Pen(Color.Orange, 1);
                    //Dessin des formes de la population
                    foreach (var item in stationParDate)
                    {
                        Pen penToUse;
                        switch (item.Value)
                        {
                            case 0:
                                penToUse = redPen;
                                break;
                            case 1:
                                penToUse = bluePen;
                                break;
                            case 2:
                                penToUse = yellowPen;
                                break;
                            case 3:
                                penToUse = violetPen;
                                break;
                            case 4:
                                penToUse = OrangePen;
                                break;
                            default:
                                penToUse = redPen;
                                break;
                        }
                        Point position = new Point(20 + (int)(item.Key * PixelParUT), this.Height - 20);

                        gr.DrawLine(penToUse, position.X, position.Y, position.X, 20);
                        //Point pos1 = new Point(20 + ((this.Width - 40) / NombreClasse * i), this.Height - 20 - (int)(((double)(this.Height - 40)) * NombreValeurIntervalle[i] / ((double)Hauteur)));
                        //Point taille = new Point(((this.Width - 40) / NombreClasse), (int)(((double)(this.Height - 40)) * NombreValeurIntervalle[i] / ((double)Hauteur)));
                        //gr.FillRectangle(new SolidBrush(Color.OrangeRed), pos1.X, pos1.Y - 5, taille.X, taille.Y + 5);
                    }
                }

                // Dessin des lignes 
                AdjustableArrowCap bigArrow = new AdjustableArrowCap(5, 5);
                Pen p = new Pen(Color.Blue, 1);
                p.CustomEndCap = bigArrow;
                gr.DrawLine(p, 20, this.Height - 10, 20, 10);
                gr.DrawLine(p, 10, this.Height - 20, (int)(_date * PixelParUT) + 10, this.Height - 20);

                //Dessin des aides sur l'axe horizontal
                Pen p1 = new Pen(Color.Black, 1);
                int nbIntervalle = (int)(_date / TailleGraduationHorizontale);
                for (int i = 0; i < nbIntervalle; i++)
                {
                    Point position = new Point(20 + (int)(_date * PixelParUT / (double)nbIntervalle) * i, this.Height - 20);
                    gr.DrawLine(p1, position.X, position.Y - 5, position.X, position.Y + 5);
                    gr.DrawString(Math.Round((TailleGraduationHorizontale * i), 2).ToString(), new Font("Arial", 8), new SolidBrush(Color.Black), new PointF(position.X, position.Y + 5));
                }
            }
        }
        public void AjoutEvenement(StructureEvenement evennement)
        {
            if (stationParDate == null)
                stationParDate = new Dictionary<double, int>();
            this._date = evennement.dateEvenement;
            stationParDate.Add(5, 2);
            stationParDate.Add(3, 1);
            stationParDate.Add(6, 1);
            stationParDate.Add(7, 3);
            stationParDate.Add(8.5, 5);
            this.Width = 30 + (int)Math.Round(_date, MidpointRounding.AwayFromZero) * PixelParUT;

            if (stationParDate.Count > 0)
                stationParDate.Add(_date, stationParDate.Last().Value + (evennement.secteur == 0 ? evennement.nombrePersonne : evennement.nombrePersonne * -1));
            else
                stationParDate.Add(_date, evennement.nombrePersonne);

            Rafraichir();
        }


    }
}
