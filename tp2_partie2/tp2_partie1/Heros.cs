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
        /// La classe du héro.
        /// </summary>
        private string _classe;

        /// <summary>
        /// L'extension du héro.
        /// </summary>
        private string _extension;

        /// <summary>
        /// L'identifiant du héro.
        /// </summary>
        private string _id;
         
        /// <summary>
        /// Le nom du héro.
        /// </summary>
        private string _nom;

        /// <summary>
        /// La rareté du héro.
        /// </summary>
        private string _rarete;

        /// <summary>
        /// wtf is this?
        /// </summary>
        private byte _regexId;

        /// <summary>
        /// Les points de vie du héro.
        /// </summary>
        private byte _vie;

        /// <summary>
        /// Points de vie maximales d'un héro.
        /// </summary>
        private byte _vieMax;

        /// <summary>
        /// Points de vie minimales d'un héro.
        /// </summary>
        private byte _vieMin;

        #endregion

        #region PROPRIÉTÉS

        /// <summary>
        /// La classe du héro.
        /// </summary>
        public string Classe
        {
            get { return this._classe; }
            set { this._classe = value; }
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
        /// L'identifiant du héro.
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
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
        /// La rareté du héro.
        /// </summary>
        public string Rarete
        {
            get { return this._rarete; }
            set { this._rarete = value; }
        }

        public byte RegexId
        {
            get { return this._regexId; }
            set { this._regexId = value; }
        }
        /// <summary>
        /// Les points de vie du héro.
        /// </summary>
        public byte Vie
        {
            get { return this._vie; }
            set { this._vie = value; }
        }

        public byte VieMax
        {
            get { return this._vieMax; }
            set { this._vieMax = value; }
        }

        public byte VieMin
        {
            get { return this._vieMin; }
            set { this._vieMin = value; }
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
        public Heros(string classe, string extension, string id, 
            string nom, string rarete, byte regexId, byte vie, byte vieMax, byte vieMin)
        {
            this._classe = classe;
            this._extension = extension;
            this._id = id;
            this._nom = nom;
            this._rarete = rarete;
            this._regexId = regexId;
            this._vie = vie;
            this._vieMax = vieMax;
            this._vieMin = vieMin;
        }

       #endregion

    }
}
