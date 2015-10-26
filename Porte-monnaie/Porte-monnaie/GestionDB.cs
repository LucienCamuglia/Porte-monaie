using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Porte_monnaie
{
    static class GestionDB
    {
        static PorteMonnaiesDataContext PorteMonnaieDb = new PorteMonnaiesDataContext();

        /// <summary>
        /// Compte le nombre de champs dans la table PorteMonnaie
        /// </summary>
        /// <returns>Nombre de champs</returns>
        static public int CountRowPorteMonnaie()
        {
            var result = from porteMonnaie in PorteMonnaieDb.PorteMonnaies select porteMonnaie;

            int count = 0;
            foreach (var porteMonnaie in result)
                count++;

            return count;
        }

        /// <summary>
        /// Ajoute un champ dans la table PorteMonnaie
        /// </summary>
        /// <param name="id">Id du porte-monnaie</param>
        /// <param name="nom">Nom du porte-monnaie</param>
        /// <param name="solde">Solde total du porte-monnaie</param>
        static public void AddFieldPorteMonnaie(int id, string nom, decimal solde)
        {
            PorteMonnaies pm = new PorteMonnaies();

            pm.IdPorteMonnaie = id;
            pm.NomPorteMonnaie = nom;
            pm.SoldePorteMonnaie = solde;

            PorteMonnaieDb.PorteMonnaies.InsertOnSubmit(pm);

            // Effectue l'ajout
            try
            {
                PorteMonnaieDb.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Récupère le sole du porte-monnaie
        /// </summary>
        /// <returns>Solde du porte-monnaie</returns>
        static public decimal GetSolde()
        {
            var result = from porteMonnaie in PorteMonnaieDb.PorteMonnaies select porteMonnaie.SoldePorteMonnaie;

            decimal solde = 0;

            foreach (var so in result)
                solde = so;


            return solde;
        }

        /// <summary>
        /// Récupère le nom de toutes les catégories
        /// </summary>
        /// <returns>tableau contenant le nom des categories</returns>
        static public string[] GetCategories()
        {
            List<string> cats = new List<string>();

            var result = from categories in PorteMonnaieDb.Categories select categories.NomCategorie;

            foreach (var cat in result)
                cats.Add(cat);

            return cats.ToArray();
        }

        /// <summary>
        /// Effectue une transaction
        /// </summary>
        /// <param name="motif">Motif de la transaction</param>
        /// <param name="montant">Montant de la transaction</param>
        /// <param name="idCategorie">id de la catégorie</param>
        /// <param name="idPorteMonnaie">id du porte-monnaie concerné</param>
        static public void AddTransaction(string motif, decimal montant, int idCategorie, int idPorteMonnaie)
        {
            Transactions transaction = new Transactions();
            
            transaction.Motif = motif;
            transaction.Montant = montant;
            transaction.IdCategorie = idCategorie;
            transaction.IdPorteMonnaie = idPorteMonnaie;

            PorteMonnaieDb.Transactions.InsertOnSubmit(transaction);

            try
            {
                PorteMonnaieDb.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Récupère l'id d'une catégorie selon son nom
        /// </summary>
        /// <param name="nomCategorie">Nom de la catégorie</param>
        /// <returns></returns>
        static public int GetIdCategorie(string nomCategorie)
        {
            int idCat = 0;
            var result = from categories in PorteMonnaieDb.Categories where categories.NomCategorie == nomCategorie select categories.IdCategorie;
            foreach (int id in result)
                idCat = id;

            return idCat;
        }

        static public Transactions[] GetTransaction(int idPorteMonnaie)
        {
            var result = from transactions in PorteMonnaieDb.Transactions join categories in PorteMonnaieDb.Categories on transactions.IdCategorie equals categories.IdCategorie where transactions.IdPorteMonnaie == idPorteMonnaie select transactions;

            return result.ToArray();
        }
    }
}
