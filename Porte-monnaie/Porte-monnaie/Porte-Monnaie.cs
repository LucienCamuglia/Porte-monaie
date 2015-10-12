using System;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace Porte_monnaie
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            //ajoutes nos noms dans le status bar
            tStstbNames.Text = "Camuglia Lucien && Devaud Alan -- T.IS-E1";
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            Graphique frmGraphique = new Graphique();
            frmGraphique.ShowDialog();
        }
    }
}
