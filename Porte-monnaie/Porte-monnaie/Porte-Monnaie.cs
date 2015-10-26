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
                DialogResult dr = nvPorteMonnaie.ShowDialog(); // Affiche la fenêtre pour la création du porte-monnaie
                if (dr == DialogResult.OK)
                    GestionDB.AddFieldPorteMonnaie(count + 1, nvPorteMonnaie.Nom, nvPorteMonnaie.Solde); // Ajout le porte-monnaie à la base de données
            }

            this.lblSoldeTotal.Text = GestionDB.GetSolde().ToString();
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            Graphique frmGraphique = new Graphique();
            frmGraphique.ShowDialog();
        }

        private void BtnDepense_Click(object sender, EventArgs e)
        {
            DebitCredit frmDebitCredit = new DebitCredit();
            string[] cats = GestionDB.GetCategories(); // Récupère toute les catégories

            foreach (string name in cats)
                frmDebitCredit.CbxCategorie.Items.Add(name); // Ajoute les catégorie dans la combobox
            frmDebitCredit.CbxCategorie.SelectedIndex = 0;

            DialogResult dr = frmDebitCredit.ShowDialog();

            if (dr == DialogResult.OK)
            {
                int idCat = GestionDB.GetIdCategorie(frmDebitCredit.Categorie); // Récupère l'id de la catégorie
                GestionDB.AddTransaction(frmDebitCredit.Motif, frmDebitCredit.Montant, idCat, 1); // Ajoute le transaction
                dataGridView1.DataSource = GestionDB.GetTransaction(1);
            }
        }
    }
}
