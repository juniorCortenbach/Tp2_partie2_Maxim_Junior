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
using System.Windows.Forms;

#endregion

namespace tp2_partie1
{
    /// <summary>
    /// Classe contenant toutes les informations relatives aux cartes.
    /// </summary>
    public class Carte
    {
        #region ATTRIBUTS

        /// <summary>
        /// Le nombre de points d'attaque de la carte.
        /// </summary>
        private byte _attaque;

        /// <summary>
        /// La classe du héros.
        /// </summary>
        private HerosClasse _classe;

        /// <summary>
        /// Le coût de la carte.
        /// </summary>
        private ushort _cout;

        /// <summary>
        /// Les points de la durabilité de la carte.
        /// </summary>
        private byte _durabilite;

        /// <summary>
        /// L'extension de la carte.
        /// </summary>
        private string _extension;

        /// <summary>
        /// L'ID de la carte.
        /// </summary>
        private string _id;

        /// <summary>
        /// Les mécaniques de la carte.
        /// </summary>
        private string[] _lstMeca;

        /// <summary>
        /// Le nom de la carte.
        /// </summary>
        private string _nom;

        /// <summary>
        /// Race du serviteur.
        /// </summary>
        private ServiteurRace _race;

        /// <summary>
        /// La rareté de la carte.
        /// </summary>
        private string _rarete;

        /// <summary>
        /// 
        /// </summary>
        private string _regexId;

        /// <summary>
        /// Contient du texte décrivant la carte.
        /// </summary>
        private string _texte;
        /// <summary>
        /// Le type de créature.
        /// </summary>
        private Type _type;

        /// <summary>
        /// Le nombre de points de vie de la carte.
        /// </summary>
        private byte _vie;

        /// <summary>
        /// Nombre de points maximale d'une.
        /// </summary>
        private byte _attaqueMax;

        /// <summary>
        /// Le coût maximale d'une carte.
        /// </summary>
        private ushort _coutMax;

        /// <summary>
        /// La durabilité maximale d'une carte.
        /// </summary>
        private byte _durabiliteMax;

        /// <summary>
        /// Les points de vie maximal d'une carte.6
        /// </summary>
        private byte _vieMax;

        #endregion

        #region PROPRIÉTÉS

        /// <summary>
        /// Le nombre de points d'attaque de la carte.
        /// </summary>
        public byte Attaque
        {
            get { return this._attaque; }
            set { this._attaque = value; }
        }

        /// <summary>
        /// La classe du héros.
        /// </summary>
        public HerosClasse Classe
        {
            get { return this._classe; }
            set { this._classe = value; }
        }

        /// <summary>
        /// Coût de la carte.
        /// </summary>
        public ushort Cout
        {
            get { return this._cout; }
            set { this._cout = value; }
        }

        /// <summary>
        /// Les points de durabilite de la carte.
        /// </summary>
        public byte Durabilite
        {
            get { return this._durabilite; }
            set { this._durabilite = value; }
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
        /// L'ID de la carte.
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        /// <summary>
        /// Les mécaniques de la carte.
        /// </summary>
        public string[] LstMeca
        {
            get { return this._lstMeca; }
            set { this._lstMeca = value; }
        }

        /// <summary>
        /// Le nom de la carte.
        /// </summary>
        public string Nom
        {
            get { return this._nom; }
            set { this._nom = value; }
        }

        /// <summary>
        /// Race du serviteur.
        /// </summary>
        public ServiteurRace _race
        {
            get { return this._race; }
            set { this._race = value; }
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
        /// 
        /// </summary>
        public string RegexId
        {
            get { return this._regexId; }
            set { this._regexId = value; }
        }

        /// <summary>
        /// Contient du texte décrivant la carte.
        /// </summary>
        public string Texte
        {
            get { return this._texte; }
            set { this._texte = value; }
        }

        /// <summary>
        /// Le type de créature.
        /// </summary>
        public Type Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        /// <summary>
        /// Le nombre de points de vie de la carte.
        /// </summary>
        public byte Vie
        {
            get { return this._vie; }
            set { this._vie = value; }
        }

        /// <summary>
        /// Nombre de points maximale d'une.
        /// </summary>
        public byte AttaqueMax
        {
            get { return this._attaqueMax; }
            set { this._attaqueMax = value; }
        }

        /// <summary>
        /// Le coût maximale d'une carte.
        /// </summary>
        public ushort CoutMax
        {
            get { return this._coutMax; }
            set { this._coutMax = value; }
        }

        /// <summary>
        /// La durabilité maximale d'une carte.
        /// </summary>
        public byte DurabiliteMax
        {
            get { return this._durabiliteMax; }
            set { this._durabiliteMax = value; }
        }

        /// <summary>
        /// Les points de vie maximal d'une carte.
        /// </summary>
        public byte VieMax
        {
            get { return this._vieMax; }
            set { this._vieMax = value; }
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

        public Carte(byte attaque, HerosClasse classe, ushort cout, byte durabilite,
            string extension, string id, string[] lstMeca, string nom, ServiteurRace race,
            string rarete, string regexId, string texte, Type type, byte vie, byte attaqueMax,
            ushort coutMax, byte durabiliteMax, byte vieMax)
        {
            this._attaque = attaque;
            this._classe = classe;
            this._cout = cout;
            this._durabilite = durabilite;
            this._extension = extension;
            this._id = id;
            this._lstMeca = lstMeca;
            this._nom = nom;
            this._race = race;
            this._rarete = rarete;
            this._regexId = regexId;
            this._texte = texte;
            this._type = type;
            this._vie = vie;
            this._attaqueMax = attaqueMax;
            this._coutMax = coutMax;
            this._durabiliteMax = durabiliteMax;
            this._vieMax = vieMax;

        }

       #endregion

        #region MÉTHODES

        //I GUESS?
        public CarteMecanique AjouterMecanique()
        {
            return null;
        }

        public Carte Carte()
        {
            return null;
        }

        //JE SAIS PAS.
        public Carte CompareTo()
        {
            return null;
        }

        #endregion

    }
}
