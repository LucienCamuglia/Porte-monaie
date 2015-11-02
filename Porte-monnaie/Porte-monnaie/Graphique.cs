using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Porte_monnaie
{
    public partial class Graphique : Form
    {
        Chart Cammembert = new Chart();
        public Graphique()
        {
            InitializeComponent();
        }

        private void Graphique_Load(object sender, EventArgs e)
        {
            InitialisesGraphique();
            ChargeGraphique();
        }

        /// <summary>
        /// initialisation du graphique
        /// </summary>
        void InitialisesGraphique()
        {
            //crée l'aire dans laquelle apparaitra le graphique
            ChartArea Aire = new ChartArea();
            //crée la legende du graphique (carré en haut a droite)
            Legend Legende = new Legend() { BackColor = Color.CadetBlue, ForeColor = Color.Black, Title = "Catégories" };
            Aire.Name = "AireDuCammembert";
            Cammembert.ChartAreas.Add(Aire);
            Cammembert.Dock = System.Windows.Forms.DockStyle.Fill;
            Legende.Name = "Etat des dépenses";
            Cammembert.Legends.Add(Legende);
            Cammembert.Location = new System.Drawing.Point(0, 50);
        }

        /// <summary>
        /// charge le graphique, définit les parts du cammembert et le nom des catégories
        /// </summary>
        void ChargeGraphique()
        {
            //supprime toutes les parts du cammembert
            Cammembert.Series.Clear();
            //pallete de couleures
            Cammembert.Palette = ChartColorPalette.Excel;
            Cammembert.BackColor = Color.Green;
            //titre du graphique
            Cammembert.Titles.Add("Etat des dépenses");
            Cammembert.ChartAreas[0].BackColor = Color.Transparent;
            //crée la serie
            Series series1 = new Series
            {
                Name = "Dépenses",
                IsVisibleInLegend = true,
                Color = System.Drawing.Color.Blue,
                ChartType = SeriesChartType.Pie
            };

            Cammembert.Series.Add(series1);
            string[][] maserie = RecupereInfo();

            //créer la boucle qui affiche les séries
            /*series1.Points.Add(70000);
            series1.Points.Add(15000);
            series1.Points.Add(15000);
            series1.Points.Add(60000);*/
            for (int i = 0; i < maserie.Length; i++)
            {
                series1.Points.Add(System.Convert.ToDouble(maserie[i][1]));

                var point = series1.Points[i];
                point.AxisLabel = maserie[i][1];
                point.LegendText = maserie[i][0];

            }
            //faire une seule variable dans la boucle
            /*var p1 = series1.Points[0];
            p1.AxisLabel = "70000";
            p1.LegendText = "Tanigami";
            var p2 = series1.Points[1];
            p2.AxisLabel = "15000";
            p2.LegendText = "Migros";
            var p3 = series1.Points[2];
            p3.AxisLabel = "15000";
            p3.LegendText = "coop";
            var p4 = series1.Points[3];
            p4.AxisLabel = "60000";
            p4.LegendText = "yukiguni";*/

            //fin de la boucle
            Cammembert.Invalidate();
            pnlCammembert.Controls.Add(Cammembert);


        }

        string[][] RecupereInfo()
        {
            string[] categories = GestionDB.GetCategories();
            decimal depenseTotal = 0;
            string[][] serie =new string[500][];

            for (int i = 0; i < categories.Length; i++) {
                depenseTotal = 0;
                decimal[] transactions;
                transactions = GestionDB.GetTransactionByCat(0, categories[i]);
                             
                foreach(var trans in transactions){
                    depenseTotal += trans;
                }
                serie[i][0] = categories[i];
                serie[i][1] = depenseTotal.ToString();
            }


            return serie;
        }
    }
}
