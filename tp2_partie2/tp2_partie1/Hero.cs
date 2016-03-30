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
    /// Classe contenant tout le contenu relatif à un héro.
    /// </summary>
    public class Heros
    {
        #region ATTRIBUTS

        /// <summary>
        /// L'identifiant du héro.
        /// </summary>
        private string _identifiant;
         
        /// <summary>
        /// Le nom du héro.
        /// </summary>
        private string _nom;

        /// <summary>
        /// L'extension du héro.
        /// </summary>
        private string _extension;

        /// <summary>
        /// La rareté du héro.
        /// </summary>
        private string _rarete;

        /// <summary>
        /// La classe du héro.
        /// </summary>
        private string _classeHeros;

        /// <summary>
        /// Les points de vie du héro.
        /// </summary>
        private byte _ptsVie;

        #endregion

        #region PROPRIÉTÉS
        
        /// <summary>
        /// L'identifiant du héro.
        /// </summary>
        public string Identifiant
        {
            get { return this._identifiant; }
            set { this._identifiant = value; }
        }

        /// <summary>
        /// Le nom du unité.
        /// </summary>
        public string Nom
        {
            get { return this._nom; }
            set { this._nom = value; }
        }

        /// <summary>
        /// L'extension du héro.
        /// </summary>
        public string Extension
        {
            get { return this._extension; }
            set { this._extension = value; }
        }

        /// <summary>
        /// La rareté du héro.
        /// </summary>
        public string Rarete
        {
            get { return this._rarete; }
            set { this._rarete = value; }
        }

        /// <summary>
        /// La classe du héro.
        /// </summary>
        public string Classe
        {
            get { return this._classeHeros; }
            set { this._classeHeros = value; }
        }

        /// <summary>
        /// Les points de vie du héro.
        /// </summary>
        public byte PtsVie
        {
            get { return this._ptsVie; }
            set { this._ptsVie = value; }
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

        #region CONSTRUCTEUR

        /// <summary>
        /// Constructeur paramétré qui accepte les 6 arguments d'un héro.
        /// </summary>
        /// <param name="identifiant">Identifiant du héro.</param>
        /// <param name="nom">Nom du héro.</param>
        /// <param name="extension">Extension du héro.</param>
        /// <param name="rarete">Rareté du héro.</param>
        /// <param name="classHero">Classe du héro.</param>
        /// <param name="ptsVie">Points de vie du héro.</param>
        public Heros(string identifiant, string nom, string extension, string rarete, string classHero, byte ptsVie)
        {
            this._identifiant = identifiant;
            this._nom = nom;
            this._extension = extension;
            this._rarete = rarete;
            this._classeHeros = classHero;
            this._ptsVie = ptsVie;
        }

       #endregion

    }
}
