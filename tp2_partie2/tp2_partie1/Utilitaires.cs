#region MÉTADONNÉES
/* Nom du fichier         : A CHANGER
 * Nom du programmeur     : Maxim Desloges et Junior Cortenbach
 * Date                   : 30 mars 2016
 */
#endregion

#region USING

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace tp2_partie1
{
    /// <summary>
    /// Classe statique contenant les informations utilitaires.
    /// </summary>
    public class Utilitaire
    {
        public FrmGestionJeu FrmGestionJeu
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        #region MÉTHODES

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cheminFichier"></param>
        /// <returns></returns>
        public static Cartes[] ChargerCartes(String cheminFichier)
        {
            return null;
        }


        /// <summary>
        /// Charger un deck en utilisant une boîte de dialogue standard de Windows.
        /// </summary>
        /// <returns></returns>
        public static Deck ChargerDeck()
        {
            return null;
        }

        #endregion

    }
}
