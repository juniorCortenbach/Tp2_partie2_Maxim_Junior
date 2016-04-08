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
using System.Runtime.CompilerServices;
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

        #endregion


        #region CONSTANTES

        const byte VieMax=0;
        const byte VieMin=0;

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

        #endregion

        public HearthstoneData JeuHearthstone
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }

        #region CONSTRUCTEUR

        /// <summary>
        /// Constructeur paramétré.
        /// </summary>
        /// <param name="classe"></param>
        /// <param name="extension"></param>
        /// <param name="id"></param>
        /// <param name="nom"></param>
        /// <param name="rarete"></param>
        /// <param name="regexId"></param>
        /// <param name="vie"></param>
        public Heros(string classe, string extension, string id, string nom, string rarete, byte regexId, byte vie)
        {
            this._classe = classe;
            this._extension = extension;
            this._id = id;
            this._nom = nom;
            this._rarete = rarete;
            this._regexId = regexId;
            this._vie = vie;
        }

        public Heros(string classe, string garroshHellscream, CarteExtension core, CarteRarete free, HerosClasse warrior, int regexId)
        {
            throw new NotImplementedException();
        }

        #endregion

    }
}
