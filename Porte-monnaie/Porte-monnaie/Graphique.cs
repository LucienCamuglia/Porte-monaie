﻿using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Porte_monnaie
{
    public partial class Graphique : Form
    {
        Chart CammembertDepense = new Chart();
        Chart CammembertCredit = new Chart();

        public Graphique()
        {
            InitializeComponent();
        }

        private void Graphique_Load(object sender, EventArgs e)
        {
            InitialisesGraphique("Débit", CammembertDepense);
            ChargeGraphique("Débit", pnlDepense, CammembertDepense);
            InitialisesGraphique("Crédit",CammembertCredit);
            ChargeGraphique("Crédit", PnlCredit,CammembertCredit);
        }

        /// <summary>
        /// initialisation du graphique
        /// </summary>
        /// <param name="motif">Crédit ou Débit</param>
        /// <param name="cammembert">Chart</param>
        void InitialisesGraphique(string motif, Chart cammembert)
        {
            //crée l'aire dans laquelle apparaitra le graphique
            ChartArea Aire = new ChartArea();
            //crée la legende du graphique (carré en haut a droite)
            Legend Legende = new Legend() { BackColor = Color.CadetBlue, ForeColor = Color.Black, Title = "Catégories" };
            Aire.Name = "AireDuCammembert";
            cammembert.ChartAreas.Add(Aire);
            cammembert.Dock = System.Windows.Forms.DockStyle.Fill;
            Legende.Name = "Etat des "+motif;
            cammembert.Legends.Add(Legende);
            cammembert.Location = new System.Drawing.Point(0, 50);
        }

       /// <summary>
        /// charge le graphique, définit les parts du cammembert et le nom des catégories
       /// </summary>
       /// <param name="motif">Crédit ou Débit</param>
       /// <param name="zone">Panel dans lequel le graphique sera affiché</param>
       /// <param name="cammembert">Chart</param>
        void ChargeGraphique(string motif, Panel zone, Chart cammembert)
        {

            //supprime toutes les parts du cammembert
            cammembert.Series.Clear();
            //pallete de couleures
            cammembert.Palette = ChartColorPalette.Excel;
            cammembert.BackColor = Color.Green;
            //titre du graphique
            cammembert.Titles.Add("Etat des " + motif);
            cammembert.ChartAreas[0].BackColor = Color.Transparent;
            //crée la serie
            Series series1 = new Series
            {
                Name = motif,
                IsVisibleInLegend = true,
                Color = System.Drawing.Color.Blue,
                ChartType = SeriesChartType.Pie
            };

            cammembert.Series.Add(series1);
            string[,] maserie = RecupereInfo(motif);


            for (int i = 0; i < maserie.Length / 2; i++)
            {
                series1.Points.Add(System.Convert.ToDouble(maserie[i, 1]));

                var point = series1.Points[i];
                if (System.Convert.ToDouble(maserie[i, 1]) > 0)
                {
                    point.AxisLabel = maserie[i, 1];
                }
                point.LegendText = maserie[i, 0];



            }

            cammembert.Invalidate();
            zone.Controls.Add(cammembert);
        }

        /// <summary>
        /// Recupère les information de Débit ou crédit
        /// </summary>        
        /// <param name="type">Débit / Crédit</param>
        /// </summary>
        /// <returns>Tableau avec le nom de catégorie et le montant dépensé pour celle-ci</returns>        
        string[,] RecupereInfo(string type)
        {
            string[] categories = GestionDB.GetCategories(type);
            decimal depenseTotal = 0;
            string[,] serie = new string[categories.Length, 2];

            for (int i = 0; i < categories.Length; i++)
            {
                depenseTotal = 0;
                decimal[] transactions;
                transactions = GestionDB.GetTransactionByCat(1, categories[i], type);

                foreach (var trans in transactions)
                {
                    depenseTotal += trans;
                }
                serie[i, 0] = categories[i];
                serie[i, 1] = depenseTotal.ToString().Substring(0, depenseTotal.ToString().IndexOf('.') + 2);

            }


            return serie;
        }
    }
}
