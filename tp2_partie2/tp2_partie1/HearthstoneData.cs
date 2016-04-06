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
    public class HearthstoneData
    {

        #region CONSTANTE
       
        /// <summary>
        /// Constante qui contient le chemin qui contient le fichier xml qui contient les données. 
        /// </summary>
        public const String CheminFichierCarte= "cartes.xml";  

        #endregion

        #region ATTRIBUTS
        
        /// <summary>
        /// Tableaux de cartes. 
        /// </summary>
        private Carte[] _lesCartes;
        
        /// <summary>
        /// Tableaux de héros.
        /// </summary>
        private Heros[] _lesHeros;

        #endregion 

        #region PROPRIÉTÉS
        /// <summary>
        /// Tableaux de héros.
        /// </summary>
        public Heros[] LesHeros
        {
            get { return this._lesHeros; }
            set { this._lesHeros = value; }
        }

        /// <summary>
        /// Tableaux de cartes. 
        /// </summary>
        public Carte[] LesCartes
        {
            get { return this._lesCartes; }
            set { this._lesCartes = value; }
        }

        #endregion

        #region CONSTRUCTEUR

        /// <summary>
        /// Constructeur paramétré qui accepte les attributs de cartes et de de héros.
        /// </summary>
        public HearthstoneData()
        {
            this.LesCartes = Utilitaire.ChargerCartes(HearthstoneData.CheminFichierCarte);
         //   this.LesHeros = Utilitaire.Charger(HearthstoneData.CheminFichierCarte);
        }
        #endregion

        #region MÉTHODES

        /// <summary>
        /// Prend en paramètre tous les critères de recherche (vous référez à la section « Critères pour la recherche de cartes » plus haut
        /// pour l’ordre des paramètres et leur signification). Retourne une liste générique de « Carte » correspondant aux critères de
        /// recherche et triée premièrement selon le coût (en ordre croissant) et, par la suite, selon le nom (en ordre croissant et
        /// insensible à la casse et aux accents).
        /// </summary>
        /// <param name="?"></param>
        public Carte RechercherCartes(CarteType type, String nomPartiel, List<CarteExtension> extensions, CarteRarete rarete,
            sbyte coutMin,sbyte coutMax, string textePartiel,HerosClasse classe, List<CarteMecanique> mecaniques, 
            sbyte attaqueMin, sbyte attaqueMax, sbyte vieMin, sbyte vieMax,ServiteurRace race, sbyte durabiliteMin,
            sbyte durabiliteMax)
        {
            return null;
        }

        /// <summary>
        /// Prend en paramètre l’identifiant d’une carte et retourne la carte correspondante si l’identifiant est valide; retourne « null » si
        /// l’identifiant est invalide.
        /// </summary>
        /// <returns></returns>
        public Carte RechercherCarteParId(ushort carteRechercher)
        {
                       //Création de tableau d'id converti en chiffre
            ushort[] idCarte = new ushort[this.LesCartes.Length];
            //Création d'un byte d'id
            ushort idTrouver = 0;
      
            try
            {
                //Enlève les 3 premières lettre et l'autre caractère bizarre
                for (int i = 0; i < this.LesCartes.Length; i++)
                {
                    idCarte[i] = ushort.Parse(this.LesCartes[i].Id.Split('_').Last());
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("Veillez entrez un chiffre");
            }
            catch (Exception j)
            {
                Console.WriteLine("Désoler malheureusement : {0}", "Une exception s'est produite.");
                Console.WriteLine("Message système : {0}", j.Message);
            }


            //Retourne idTrouver s'il trouve la carte mais nul s'il ne trouve rien
            for (int j = 0; j < this.LesCartes.Length; j++)
            {
                if (idCarte[j] == carteRechercher)
                {
                    idTrouver = idCarte[j];
                }
                else
                {
                    return null;
                }
            }
            //Retourne la carte trouver
            return this.LesCartes[idTrouver];
        }
        
        /// <summary>
        /// Prend en paramètre l’identifiant d’un héros et retourne le héros correspondant si l’identifiant est valide; retourne « null » si
        /// l’identifiant est invalide.
        /// </summary>
        /// <returns></returns>
        public Heros RechercherHeroParId(ushort heroRechercher)
        {
            //Création de tableau d'id converti en chiffre
            ushort[] idHero = new ushort[this.LesHeros.Length];
            //Création d'un byte d'id
            ushort idTrouver = 0;

            try
            {
                //Enlève les 3 premières lettre et l'autre caractère bizarre
                for (int i = 0; i < this.LesHeros.Length; i++)
                {
                    idHero[i] = ushort.Parse(this.LesHeros[i].Id.Split('_').Last());
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("Veillez entrez un chiffre entre 0 à 65535");
            }
            catch (Exception e)
            {
                Console.WriteLine("Désoler malheureusement : {0}", "Une exception s'est produite.");
                Console.WriteLine("Message système : {0}", e.Message);
            }


            //Retourne idTrouver s'il trouve la carte mais nul s'il ne trouve rien
            for (int j = 0; j < this.LesHeros.Length; j++)
            {
                if (idHero[j] == heroRechercher)
                {
                    idTrouver = idHero[j];
                }
                else
                {
                    return null;
                }
            }
            //Retourne la carte trouver
            return this.LesHeros[idTrouver];
        }

        #endregion


    }

  
}
