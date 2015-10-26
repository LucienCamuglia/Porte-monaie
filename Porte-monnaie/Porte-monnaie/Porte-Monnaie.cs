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

            // Compte le nombre de champs existant
            int count = GestionDB.CountRowPorteMonnaie();

            // S'il n'y a aucun porte-monnaie on en rajoute un
            if (count <= 0)
            {
                MessageBox.Show("Il n'exist acctuellement aucun porte-monnaie ! \r\nVeuillez en créer un !");

                NouveauPorteMonnaie nvPorteMonnaie = new NouveauPorteMonnaie();
                DialogResult dr = nvPorteMonnaie.ShowDialog();
                if (dr == DialogResult.OK)
                    GestionDB.AddFieldPorteMonnaie(count + 1, nvPorteMonnaie.Nom, nvPorteMonnaie.Solde);
            }



        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            Graphique frmGraphique = new Graphique();
            frmGraphique.ShowDialog();
        }
    }
}
