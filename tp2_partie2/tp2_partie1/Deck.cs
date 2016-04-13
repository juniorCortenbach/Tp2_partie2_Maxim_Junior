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
        /// Héro (avec toutes informations du héro contenues dans 
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

        /// <summary>
        /// Le nombre de cartes présentes dans le deck.
        /// </summary>
        private byte _nbTotalCartes;
        #endregion

        #region PROPRIÉTÉS

        /// <summary>
        /// Héro (avec toutes informations du héro
        /// contenues dans la classe Heros).
        /// </summary>
        public Heros Heros
        {
            get { return this._heros; }
            set { this._heros = value; }
        }


        /// <summary>
        /// Tableau de cartes.
        /// </summary>
        public Carte[] LstCartesAvecQt
        {
            get { return this._lstCartesAvecQt; }
            set { this._lstCartesAvecQt = value; }
        }

        /// <summary>
        /// Nom du deck.
        /// </summary>
        public string Nom
        {
            get { return this._nom; }
            set { this._nom = value; }
        }

        /// <summary>
        /// Le nombre de cartes présentes dans le deck.
        /// </summary>
        public byte NbTotalCartes
        {
            get { return this._nbTotalCartes; }
            set { this._nbTotalCartes = value; }
        }

        #endregion

        #region CONSTANTES


        public const byte NbMaxCartesDansDeck=30;
        public const byte QtMaxCarteLegendaire=1;
        public const byte QtMaxCarteNonLegendaire=2;
    
        #endregion

        #region CONSTRUCTEUR

        /// <summary>
        /// Constructeur paramétré qui accepte les trois attributs d'un deck.
        /// </summary>
        public Deck(string nom, Heros heros)
        {
            this._nom = nom;
            this._heros = heros;
        }

        #endregion 

        #region MÉTHODES

        public void AjouterCartes(Carte carteAjoutee, byte nbCopies)
        {
            byte nbCartesLegendaires=0;
            //Restrictions:
            // nbCopies en cas de carte légendaire ne peut pas être > ou < que 1.
            // Une carte ne peut être ajouté si le nombre de cartes déjà présent est 30.

            //Prévoir que la carte ajoutée peut déjà être présente dans le deck et ne pourra
            //être ajoutée qu'une seule fois, si elle ne s'y retrouve qu'une seule fois.

            //Comment j'fais pour déterminer le nombre de cartes légendaires si
            //j'peux pas détermienr la rareté des cartes contenues dans le deck?
            for (int i = 0; i < this.NbTotalCartes; i++)
            {
                if (this.LstCartesAvecQt[i].Rarete == CarteRarete.Legendary);
                nbCartesLegendaires++;
            }

            if(nbCartesLegendaires > Deck.QtMaxCarteLegendaire)
                throw new ArgumentException("Le nombre de cartes légendaire ne peut dépasser 1.");

            if(this.NbTotalCartes == Deck.NbMaxCartesDansDeck)
                throw new ArgumentException("La quantité de cartes présentes dans le deck ne peut pas dépasser 30.");

            
            if(nbCopies > Deck.QtMaxCarteNonLegendaire && carteAjoutee.Rarete == CarteRarete.Legendary)

                throw new ArgumentException("Le nombre de copies d'une même carte ne peut être supérieur à 2.");

            Carte nouvelleCarte = new Carte(carteAjoutee.Type, carteAjoutee.Id, carteAjoutee.Nom, carteAjoutee.Extension,
                carteAjoutee.Rarete, carteAjoutee.Cout, carteAjoutee.Texte, carteAjoutee.Classe, carteAjoutee.Attaque,
                carteAjoutee.Durabilite, carteAjoutee.Race, carteAjoutee.Vie);

            if (nbCopies > 1)
            {
                Carte secondeNouvelleCarte = new Carte(carteAjoutee.Type, carteAjoutee.Id, carteAjoutee.Nom, carteAjoutee.Extension,
                carteAjoutee.Rarete, carteAjoutee.Cout, carteAjoutee.Texte, carteAjoutee.Classe,carteAjoutee.Attaque,
                carteAjoutee.Durabilite, carteAjoutee.Race, carteAjoutee.Vie);
            }


        }

        public byte ObtenirQtCarte(Carte carteLue)
        {
            byte quantitéCarte = 0;

            for (int i = 0; i < this.LstCartesAvecQt.Length; i++)
            {
                if (this.LstCartesAvecQt[i] == carteLue)
                    quantitéCarte++;
            }

            return quantitéCarte;
        }

        public void RetirerCarte(Carte carteRetiree, bool toutesCopiesRetirees)
        {
            if (toutesCopiesRetirees)
                for (int i = 0; i < ObtenirQtCarte(carteRetiree); i++)
                {
                    Array.Resize(ref this._lstCartesAvecQt, this.LstCartesAvecQt.Length - 1);
                }
            else
                Array.Resize(ref this._lstCartesAvecQt, this.LstCartesAvecQt.Length -1);
        }

        #endregion

    }
}
