#region MÉTADONNÉES
/* Nom du fichier         : A CHANGER
 * Nom du programmeur     : Maxim Desloges et Junior Cortenbach
 * Date                   : 30 mars 2016
 */
#endregion


#region USING
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion


namespace tp2_partie1
{
    public class DeckEntree
    {

        #region ATTRIBUTS

        /// <summary>
        /// Objet carte
        /// </summary>
        private Carte _carte;

        /// <summary>
        /// Quantité de carte
        /// </summary>
        private byte _qt;

        #endregion

        #region PROPRIÉTÉS
        /// <summary>
        /// Objet carte
        /// </summary>
        public Carte Carte
        {
            get { return this._carte; }
            set { this._carte = value; }
        }

        /// <summary>
        /// Quantité de carte
        /// </summary>
        public byte Qt
        {
            get { return this._qt; }
            set { this._qt = value; }
        }
        #endregion

        #region MÉTHODE



        #endregion



    }
}
