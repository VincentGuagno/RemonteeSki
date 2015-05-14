﻿using System;
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
        private Dictionary<double,int> personneParDate;

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

                if (personneParDate == null)
                    personneParDate = new Dictionary<double, int>();

                this._date = 20; // bouchon

                //Dessin des formes de la population
                foreach (var item in personneParDate)
                {

                    //Point pos1 = new Point(20 + ((this.Width - 40) / NombreClasse * i), this.Height - 20 - (int)(((double)(this.Height - 40)) * NombreValeurIntervalle[i] / ((double)Hauteur)));
                    //Point taille = new Point(((this.Width - 40) / NombreClasse), (int)(((double)(this.Height - 40)) * NombreValeurIntervalle[i] / ((double)Hauteur)));
                    //gr.FillRectangle(new SolidBrush(Color.OrangeRed), pos1.X, pos1.Y - 5, taille.X, taille.Y + 5);
                }

                // Dessin des lignes 
                AdjustableArrowCap bigArrow = new AdjustableArrowCap(5, 5);
                Pen p = new Pen(Color.Blue, 1);
                p.CustomEndCap = bigArrow;
                gr.DrawLine(p, 20, this.Height - 10, 20, 10);
                gr.DrawLine(p, 10, this.Height - 20, (int)(_date * PixelParUT)+10, this.Height - 20);

                //Dessin des aides sur l'axe vertical  
                Pen p1 = new Pen(Color.Black, 1);
                for (int i = 0; i < DefinitionVerticale; i++)
                {
                    Point position = new Point(20, 20 + (this.Height - 30) - ((this.Height - 30) / DefinitionVerticale * (i + 1)));
                    gr.DrawLine(p1, position.X - 5, position.Y, position.X + 5, position.Y);
                    gr.DrawString((Hauteur / DefinitionVerticale * (i + 1)).ToString(), new Font("Arial", 8), new SolidBrush(Color.Black), new PointF(position.X - 20, position.Y));
                }

                //Dessin des aides sur l'axe horizontal
                int nbIntervalle = (int)(_date / TailleGraduationHorizontale);
                for (int i = 0;i<nbIntervalle;i++)
                {
                    Point position = new Point(20 + (int)(_date * PixelParUT / (double)nbIntervalle) * i, this.Height - 20);
                    gr.DrawLine(p1, position.X, position.Y - 5, position.X, position.Y + 5);
                    gr.DrawString(Math.Round((TailleGraduationHorizontale * (i + 1)), 2).ToString(), new Font("Arial", 8), new SolidBrush(Color.Black), new PointF(position.X, position.Y + 5));
                }

                //for (int i = 0; i < NombreClasse; i++)
                //{
                //    Point position = new Point(20 + ((this.Width - 40) / NombreClasse * (i + 1)), this.Height - 20);
                //    gr.DrawLine(p1, position.X, position.Y - 5, position.X, position.Y + 5);
                //    gr.DrawString(Math.Round((i + 1) * tailleIntervalle, 2).ToString(), new Font("Arial", 8), new SolidBrush(Color.Black), new PointF(position.X, position.Y + 5));
                //}
            }
        }
        public void AjoutEvenement(StructureEvenement evennement)
        {
            this._date = evennement.dateEvenement + 2;
            this.Width = (int)Math.Round(_date,MidpointRounding.AwayFromZero) * PixelParUT;
            personneParDate.Add(_date, personneParDate.Last().Value + evennement.nombrePersonne);

            Rafraichir();
        }
    }
}
