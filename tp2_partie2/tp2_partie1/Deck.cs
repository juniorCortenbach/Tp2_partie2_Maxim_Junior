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
        /// Nom du deck.
        /// </summary>
        private string _nomDeck;

        /// <summary>
        /// Héro (avec toutes informations du héro contenus dans 
        /// la classe Heros).
        /// </summary>
        private Heros _heros;

        /// <summary>
        /// Tableau de cartes.
        /// </summary>
        private Cartes[] _tabCartes;

        #endregion

        #region PROPRIÉTÉS

        public string NomDeck
        {
            get { return this._nomDeck; }
            set { this._nomDeck = value; }
        }

        public Heros Heros
        {
            get { return this._heros; }
            set { this._heros = value; }
        }

        public Cartes[] TabCartes
        {
            get { return this._tabCartes; }
            set { this._tabCartes = value; }
        }

        #endregion

        public JeuHearthstone JeuHearthstone
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
        /// Enregistrer un deck dans le fichier au format XML.
        /// </summary>
        public void EnregistrerDeck()
        {

        }

        /// <summary>
        /// Modification du nom du deck dans le fichier .xml.
        /// </summary>
        public void ModifierNom()
        {

        }

        /// <summary>
        /// Ajout d'une carte supplémentaire dans le deck du joueur.
        /// En considérant le nombre maximal de copies d'une même carte permise.
        /// </summary>
        public void AjouterNouvelleCarte()
        {

        }

        /// <summary>
        /// Suppression d'une carte, peu importe son nombre de copies.
        /// </summary>
        public void SupprimerToutesLesCopies()
        {
            ModifierQuantiteCarte(0);
        }

        /// <summary>
        /// Ajout ou soustraction de la quantité d'une carte dans le deck.
        /// </summary>
        /// <param name="nbCartes"></param>
        public void ModifierQuantiteCarte(int nbCartes)
        {

        }


        /// <summary>
        /// Faire une recherche de cartes en limitant automatiquement
        /// celle-ci aux cartes pouvant être incluses dans le deck et, à partir du 
        /// résultat de la recherche, permettre l’ajout d’une carte dans le deck si 
        /// c’est encore possible (nombre maximal de copies non atteint).
        /// </summary>
        /// <returns></returns>
        public Cartes[] RechercheCartes()
        {
            return null;
        }


        #endregion

    }
}
