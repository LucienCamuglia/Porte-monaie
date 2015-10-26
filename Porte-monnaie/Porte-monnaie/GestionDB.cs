using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            //  PorteMonnaieDb = new PorteMonnaiesDataContext();
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
        }
    }
}
