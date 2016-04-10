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
using System.Globalization;
using System.Text.RegularExpressions;

#endregion

namespace tp2_partie1
{
    /// <summary>
    /// Classe contenant toutes les informations relatives aux cartes.
    /// </summary>
    public class Carte : IComparable<Carte>
    {
        #region ATTRIBUTS

        /// <summary>
        /// Le nombre de points d'attaque de la carte.
        /// </summary>
        private sbyte _attaque;

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
        private sbyte _durabilite;

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
        private List<string> _lstMeca;

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
        private CarteType _type;

        /// <summary>
        /// Le nombre de points de vie de la carte.
        /// </summary>
        private sbyte _vie;

        #endregion

        #region PROPRIÉTÉS

        /// <summary>
        /// Le nombre de points d'attaque de la carte.
        /// </summary>
        public sbyte Attaque
        {
            get { return this._attaque; }
            set
            {
                // Validation de l'attaque doit être compris entre 0 et 12 et être de type serviteur ou arme.
                // ==========================================================================================
                if (((this.Type == CarteType.Weapon) || (this.Type == CarteType.Minion)) &&
                    ((value < 0) || (value > 12)))
                {
                    throw new ArgumentOutOfRangeException(null,
                        "L'attaque doit être entre 0 et 12, inclusivement. et le type doit être serviteur ou arme");
                }
                // Validation de l'attaque doit être -1 et le type doit être sort
                // ======================================================
                if ((this.Type == CarteType.Spell) && (this.Attaque == -1))
                {
                    throw new ArgumentOutOfRangeException(null,
                        "L'attaque doit être -1. et le type doit sort");
                }
                // L'attaque prévue est valide; on la conserve dans l'attribut. 
                this._attaque = value;
            }
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
            set
            {
                // Validation du cout d'une carte
                // ==============================
                if (value > 20)
                    throw new ArgumentOutOfRangeException(null,
                        "Le cout de la carte est de 0 et 20, inclusivement.");
                // Le cout prévue est valide; on la conserve dans l'attribut.
                this._cout = value;
            }
        }

        /// <summary>
        /// Les points de durabilite de la carte.
        /// </summary>
        public sbyte Durabilite
        {
            get { return this._durabilite; }
            set
            {
                // Validation de la durabilité entre 1 et 8 inclusivement pour les carte arme.
                // ===========================================================================
                if ((this.Type == CarteType.Weapon) && ((value < 1) || (value > 8)))
                {
                    throw new ArgumentOutOfRangeException(null,
                        "La durabilité doit être entre 1 et 8, inclusivement. et le type doit être arme");
                }
                // Validation de la durabilité doit être -1 et le type doit être serviteur et sort.
                // ================================================================================
                if ((this.Type == CarteType.Spell) && (this.Durabilite == -1))
                {
                    throw new ArgumentOutOfRangeException(null,
                        "La durabilité doit être -1. et le type doit sort");
                }
                // La durabilité prévue est valide; on la conserve dans l'attribut. 
                this._durabilite = value;
            }
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
            set
            {
                //Regex qui valide l'id de la carte
                Regex idCarteRegex = new Regex("[A-Za-z0-9]{6}_[1-9]{3}");
                //Valide que la carte 
                if (idCarteRegex.ToString().Trim() != this.Id.Trim().ToString())
                {
                    throw new ArgumentOutOfRangeException(null,
                        "L'id doit contenir entre 2 et 6 caractères parmi les lettres minuscules et majuscules et les chiffres de (0 à 9) suivit du caractère de soulignement, _ entre 1 et 3 chiffres de (0 à 9)");
                }
                // L'id prévue est valide; on la conserve dans l'attribut.
                this._id = value;
            }
        }

        /// <summary>
        /// Les mécaniques de la carte.
        /// </summary>
        public List<string> LstMeca
        {
            get { return this._lstMeca; }
            set
            {
                //A faire
                this._lstMeca = value;
            }
        }

        /// <summary>
        /// Le nom de la carte.
        /// </summary>
        public string Nom
        {
            get { return this._nom; }
            set
            {
                // Validation du nom
                // ===================
                // Le nom ne doit pas être nul.
                if (value == null)
                    throw new ArgumentNullException(null, "Le nom ne doit pas être nul.");
                // Retrait des espaces superflus (seulement si le titre n'est pas nul, autrement ça va lever l'exception NullReferenceExcpetion).
                String nomTrime = value.Trim();
                // Le nom doit contenir au moins 3 caractères.
                if (nomTrime.Length < 3)
                    throw new ArgumentException("Le nom doit contenir au moins 3 caractères.");
                // Le titre est valide; on le conserve dans l'attribut.
                this._nom = nomTrime;
            }
        }

        /// <summary>
        /// Race du serviteur.
        /// </summary>
        public ServiteurRace Race
        {
            get { return this._race; }
            set
            {
                //A faire
                this._race = value;
            }
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
            set
            {
                string texteTrime = value.Trim();
                this._texte = texteTrime;
            }
        }

        /// <summary>
        /// Le type de créature.
        /// </summary>
        public CarteType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        /// <summary>
        /// Le nombre de points de vie de la carte.
        /// </summary>
        public sbyte Vie
        {
            get { return this._vie; }
            set
            {
                // Validation de la vie 
                // ==========================================================================================
                if ((this.Type == CarteType.Minion)  && ((value < 0) || (value > 15)))
                {
                    throw new ArgumentOutOfRangeException(null,
                        "La vie doit être entre 0 et 15, inclusivement. et le type doit être un serviteur");
                }
                // Validation de la vie, doit être -1 et le type doit être sort et arme
                // ======================================================
                if ((this.Type == CarteType.Spell)||((this.Type == CarteType.Weapon) && (this.Vie == -1)))
                {
                    throw new ArgumentOutOfRangeException(null,
                        "La vie doit être -1. et le type doit être sort ou arme");
                }
                // La vie prévue est valide; on la conserve dans l'attribut. 
                this._vie = value;
            }
        }

        #endregion


        #region CONSTRUCTEUR

        public Carte(sbyte attaque, HerosClasse classe, ushort cout, sbyte durabilite,
            string extension, string id, List<string> lstMeca, string nom, ServiteurRace race,
            string rarete, string regexId, string texte, CarteType type, sbyte vie)
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
        }

       #endregion

        #region MÉTHODES

    
        /// <summary>
        /// Permet de comparer deux cartes.
        /// </summary>
        /// <returns></returns>
        public int CompareTo(Carte autreCarte)
        {
            return 0;
        }

        #endregion

    }
}
