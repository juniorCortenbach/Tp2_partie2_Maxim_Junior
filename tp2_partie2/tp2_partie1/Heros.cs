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
using System.Text.RegularExpressions;
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
        private HerosClasse _classe;

        /// <summary>
        /// L'extension du héro.
        /// </summary>
        private CarteExtension _extension;

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
        private CarteRarete _rarete;

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
        public HerosClasse Classe
        {
            get { return this._classe; }
            set
            {
                //La class ne doit pas être neutre.
                if (this.Classe.ToString().Contains((char) HerosClasse.Neutre))
                {
                    throw new ArgumentException(null, "La class ne doit pas être neutre.");
                }
                // La class est valide; on le conserve dans l'attribut.
                this._classe = value;
            }
        }

        /// <summary>
        /// L'extension du héro.
        /// </summary>
        public CarteExtension Extension
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
            set
            {
                //Regex qui valide l'id de l'héros 
                Regex idHerosRegex = new Regex("HERO_[0-9]{2}");
                //Valide qu'il y a HERO_ suivit de deux chiffre entre 0-9 
                if (idHerosRegex.ToString().Trim() != this.Id.Trim().ToString())
                {
                    throw new ArgumentOutOfRangeException(null,
                        "L'id doit être HERO_ suivit de 2 chiffres.");
                }
                // L'id prévue est valide; on la conserve dans l'attribut.
             this._id = value;
            }
        }

        /// <summary>
        /// Le nom du unité.
        /// </summary>
        public string Nom
        {
            get { return this._nom; }
            set
            {
                // Validation de la longueur du nom
                // ===================
                // Le nom ne doit pas est être null
                if (value == null)
                    throw new ArgumentNullException(null, "Le nom ne doit pas être nul.");
                String nomTrime = value.Trim();
                // Le nom doit contenir au moins 3 caractères.
                if (nomTrime.Length < 3)
                    throw new ArgumentException("Le nom doit contenir au moins 3 caractères.");
                // Le nom est valide; on le conserve dans l'attribut.
                this._nom = value;
            }
        }

        /// <summary>
        /// La rareté du héro.
        /// </summary>
        public CarteRarete Rarete
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
            set
            {
                // Validation de la vie qui doit être entre 10 et 100
                // ==================================================
                if ((value < 10) || (value > 100))
                    throw new ArgumentOutOfRangeException(null,
                        "La vie du héros doit être entre 10 et 100, inclusivement.");
                // La vie est valide; on la conserve dans l'attribut.
                this._vie = value;
            }
        }

        #endregion


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
        public Heros(string id, string nom, CarteExtension extension, CarteRarete rarete, HerosClasse classe, byte vie)
        {
            this._classe = classe;
            this._extension = extension;
            this._id = id;
            this._nom = nom;
            this._rarete = rarete;
            this._vie = vie;
        }


        /*
        //PEUT SUPRIMMER?????????????
        //public Heros(string classe, string garroshHellscream, CarteExtension core, CarteRarete free, HerosClasse warrior, int regexId)
        //{
        //    throw new NotImplementedException();
        //} */

        #endregion

    }
}
