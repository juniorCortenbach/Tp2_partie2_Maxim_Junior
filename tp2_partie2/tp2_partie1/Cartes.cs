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
    /// Classe contenant toutes les informations relatives aux cartes.
    /// </summary>
    public class Cartes
    {
        #region ATTRIBUTS

        /// <summary>
        /// Le type de créature.
        /// </summary>
        private Type _type;

        /// <summary>
        /// L'ID de la carte.
        /// </summary>
        private string _identifiant;

        /// <summary>
        /// Le nom de la carte.
        /// </summary>
        private string _nom;

        /// <summary>
        /// L'extension de la carte.
        /// </summary>
        private string _extension;

        /// <summary>
        /// La rareté de la carte.
        /// </summary>
        private string _rarete;

        /// <summary>
        /// Le coût de la carte.
        /// </summary>
        private ushort _cout;

        /// <summary>
        /// Le texte de la carte.
        /// </summary>
        private string _texte;

        /// <summary>
        /// La classede la carte.
        /// </summary>
        private string _classeCarte;

        /// <summary>
        /// La mécaniques de la carte.
        /// </summary>
        private string _mecaniques;

        /// <summary>
        /// Le nombre de points d'attaque de la carte.
        /// </summary>
        private byte _ptsAttaque;

        /// <summary>
        /// Le nombre de points de vie de la carte.
        /// </summary>
        private byte _ptsVie; 


        //RACE ENUM??????????????

        /// <summary>
        /// Les points de la durabilité de la carte.
        /// </summary>
        private byte _ptsDurabilite;

        #endregion

        #region PROPRIÉTÉS

        /// <summary>
        /// Le nom de la carte.
        /// </summary>
        public string Nom
        {
            get { return this._nom; }
            set { this._nom = value; }
        }

        /// <summary>
        /// Le coût de la carte.
        /// </summary>
        public ushort Cout
        {
            get { return this._cout; }
            set { this._cout = value; }
        }

        /// <summary>
        /// Le type de créature. 
        /// </summary>
        public Type TypeCreature
        {
            get { return this._type; }
            set { this._type = value; }
        }

        /// <summary>
        /// L'ID de la carte.
        /// </summary>
        public string Identifiant
        {
            get { return this._identifiant; }
            set { this._identifiant = value; }
        }

        /// <summary>
        /// L'extension de la carte.
        /// </summary>
        public string Extension
        {
            get { return this._extension; }
            set { this._extension = value; }
        }

        /// <summary>
        /// La rareté de la carte.
        /// </summary>
        public string Rarete
        {
            get { return this._rarete; }
            set { this._rarete = value; }
        }

        /// <summary>
        /// Le texte de la carte.
        /// </summary>
        public string Texte
        {
            get { return this._texte; }
            set { this._texte = value; }
        }

        /// <summary>
        /// Les mécaniques de la carte.
        /// </summary>
        public string Mecaniques
        {
            get { return this._mecaniques; }
            set { this._mecaniques = value; }
        }

        /// <summary>
        /// La classe de la carte.
        /// </summary>
        public string ClasseCarte
        {
            get { return this._classeCarte; }
            set { this._classeCarte = value; }
        }

        /// <summary>
        /// Le nombre de points d'attaque de la carte.
        /// </summary>
        public byte PtsAttaque
        {
            get { return this._ptsAttaque; }
            set { this._ptsAttaque = value; }
        }

        /// <summary>
        /// Le nombre de points de vie de la carte.
        /// </summary>
        public byte PtsVie
        {
            get { return this._ptsVie; }
            set { this._ptsVie = value; }
        }

        /// <summary>
        /// Les points de la durabilité de la carte.
        /// </summary>
        public byte PtsDurabilite
        {
            get { return this._ptsDurabilite; }
            set { this._ptsDurabilite = value; }
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
        /// Constructeur paramétré avec tous les attributs de la classe Carte.
        /// </summary>
        /// <param name="type">Type de la carte</param>
        /// <param name="identifiant">Identifiant de la carte</param>
        /// <param name="nom">Nom de la carte</param>
        /// <param name="extension">Extension de la carte</param>
        /// <param name="cout">Coût de la carte</param>
        /// <param name="texte">Texte de la carte</param>
        /// <param name="classCarte">Classe de la carte</param>
        /// <param name="mecaniques">Mécaniques de la carte</param>
        /// <param name="ptsAttaque">Points d'attaque de la carte</param>
        /// <param name="ptsVie">Points de vie de la carte</param>
        /// <param name="ptsDurabilite">Points de durabilité de la carte</param>
        public Cartes(Type type, string identifiant, string nom, string extension, ushort cout, string texte, string classCarte, string mecaniques, byte ptsAttaque, byte ptsVie, byte ptsDurabilite)
        {
            this._type = type;
            this._identifiant = identifiant;
            this._nom = nom;
            this._extension = extension;
            this._cout = cout;
            this._texte = texte;
            this._classeCarte = classCarte;
            this._mecaniques = mecaniques;
            this._ptsAttaque = ptsAttaque;
            this._ptsVie = ptsVie;
            this.PtsDurabilite = ptsDurabilite;
        }

       #endregion

    }
}
