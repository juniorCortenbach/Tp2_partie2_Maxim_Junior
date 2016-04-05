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
    /// <summary>
    /// Classe contenant les informations relatives au deck du héro.
    /// </summary>
    public class Deck
    {
        #region ATTRIBUTS

        /// <summary>
        /// Héro (avec toutes informations du héro contenus dans 
        /// la classe Heros).
        /// </summary>
        private Heros _heros;

        /// <summary>
        /// Tableau de cartes.
        /// </summary>
        private Carte[] _lstCartesAvecQt;

        /// <summary>
        /// Nom du deck.
        /// </summary>
        private string _nom;

        #endregion

        #region PROPRIÉTÉS

        /// <summary>
        /// Tableau de cartes.
        /// </summary>
        public Carte[] NbtTotalCartes
        {
            get { return this._lstCartesAvecQt; }
            set { this._lstCartesAvecQt = value; }
        }

        #endregion

        #region CONSTANTES

        const byte NbMaxCartesDansDeck=30;
        const byte QtMaxCarteLegendaire=1;
        const byte QtMaxCarteNonLegendaire=2;

        #endregion

        #region CONSTRUCTEUR

        /// <summary>
        /// Constructeur paramétré qui accepte les trois attributs d'un deck.
        /// </summary>
        /// <param name="heros"></param>
        /// <param name="lstCartesAvecQt"></param>
        /// <param name="nom"></param>
        public Deck(Heros heros, Carte[] lstCartesAvecQt, string nom)
        {
            this._heros = heros;
            this._lstCartesAvecQt = lstCartesAvecQt;
            this._nom = nom;
        }

        #endregion 

        #region MÉTHODES

        public void AjouterCartes()
        {
            
        }

        public void ObtenirQtCarte()
        {
            
        }

        public void RetirerCarte()
        {
            
        }

        #endregion

    }
}
