#region MÉTADONNÉES
/* Nom du fichier         : JeuHearthstone
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
    /// Classe qui contient les informations du jeu.
    /// </summary>
    public class JeuHearthstone
    {
        #region CONSTANTE
        ///// <summary>
        ///// Constante qui contient le fichier .xml et donc les informations concernant les cartes et les héros.
        ///// </summary>
        //public const string FichierCartesHeros = "cards-collectible.xml";  

        #endregion

        #region ATTRIBUTS

        /// <summary>
        /// Tableau des decks.
        /// </summary>
        private Deck[] _lesDecksDuJeu;

        /// <summary>
        /// Tableau d'héros.
        /// </summary>
        private Heros[] _lesHerosDeReference;

        /// <summary>
        /// Tableau de cartes.
        /// </summary>
        private Cartes[] _lesCartesDeReference;

        #endregion

        #region PROPRIÉTÉS

        /// <summary>
        /// Tableau d'héros.
        /// </summary>
        public Heros[] LesHeros
        {
            get { return this._lesHerosDeReference; }
            private set { this._lesHerosDeReference = value; }
        }

        /// <summary>
        /// Tableau de decks.
        /// </summary>
        public Deck[] LesDecks
        {
            get { return this._lesDecksDuJeu; }
            private set { this._lesDecksDuJeu = value; }
        }

        /// <summary>
        /// Tableau de cartes.
        /// </summary>
        public Cartes[] LesCartes
        {
            get { return this._lesCartesDeReference; }
            set { this._lesCartesDeReference = value; }
        }

        #endregion

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

        #region CONSTRUCTEUR
        /// <summary>
        /// Constructeur non paramétré.
        /// </summary>
        public JeuHearthstone()
        {

        }


       #endregion

        #region MÉTHODES

        /// <summary>
        /// Au démarrage, les données sur les héros doivent être chargées dans des tableaux d’objets, et ce, à partir du fichier XML fourni.
        /// </summary>
        /// <returns></returns>
        public Heros[] ChargerXmlHeros()
        {
            return null;
        }

        /// <summary>
        /// Au démarrage, les données sur les cartes de Hearthstone doivent être chargées dans des tableaux d’objets, et ce, à partir du fichier XML fourni.
        /// </summary>
        /// <returns></returns>
        public Cartes[] ChargeXmlCartes()
        {
            return null;
        }

        /// <summary>
        /// Créer un nouveau deck en respectant les règles de conception décrites.
        /// </summary>
        /// <returns></returns>
        public Deck[] AjouterUnDeck()
        {
            return null;
        }

        #endregion
    }
}
