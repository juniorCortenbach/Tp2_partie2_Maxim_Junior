#region MÉTADONNÉES
/* Nom du fichier         : A CHANGER
 * Nom du programmeur     : Maxim Desloges et Junior Cortenbach
 * Date                   : 30 mars 2016
 */
#endregion

#region USING

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

#endregion

namespace tp2_partie1
{
    /// <summary>
    /// Classe statique contenant les informations utilitaires.
    /// </summary>
    public class Utilitaire
    {
        

        #region MÉTHODES

        /// <summary>
        /// Charge les carte du fichier .xml
        /// </summary>
        /// <param name="cheminFichier"></param>
        /// <returns></returns>
        public static Carte[] ChargerCartes(String cheminFichier)
        {

            // Création d'un document XML (un objet .NET) à partir du fichier au format XML (désérialisation).
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(cheminFichier);

            // Récupération de tous les éléments "Cartes".
            XmlNodeList listeElemCarte = xmlDoc.GetElementsByTagName("Card");

            // Création du tableau de personnes; la taille est déterminée par le nombre d'éléments "Carte".
            Carte[] tabCartes = new Carte[listeElemCarte.Count];

            // Variables utilitaires pour la création d'un objet "Carte".
            sbyte attaque=0;
            byte durabilite, vie;
            ushort cout;
            String extension, id, nom, regexId, texte, rarete;
            string[] lstMeca;
            HerosClasse classe;
            ServiteurRace race;
            Type type;
            XmlElement elemCarte;

            //Traitement de chaque élément "personne".
            for (int i = 0; i < tabCartes.Length; i++)
            {
                // Récupération du noeud "personne" à traiter.
                elemCarte = (XmlElement) listeElemCarte[i];
                // Récupération de l'attaque, de la durabilité, de la vie, du coût, de l'extension, de l'id, du nom, de regxId, du texte, du tableau de 
                //mecanique, de la rareté, de la _class, de la  race, du type.
                if (elemCarte.GetElementsByTagName("attack")[0].InnerText.Length != 0)
                    attaque = Convert.ToSByte(elemCarte.GetElementsByTagName("attack")[0].InnerText);
                else
                    attaque = -1;
                if (elemCarte.GetElementsByTagName("durability")[0].InnerText.Length != 0)
                    durabilite = Convert.ToByte(elemCarte.GetElementsByTagName("durability")[0].InnerText);
                else
                    durabilite = -1;
                if (elemCarte.GetElementsByTagName("set")[0].InnerText != 0)
                    extension = elemCarte.GetElementsByTagName("set")[0].InnerText;
                if (elemCarte.GetElementsByTagName("id")[0].InnerText != 0)
                    id = Convert.ToString(elemCarte.GetElementsByTagName("id")[0].InnerText);
                if (elemCarte.GetElementsByTagName("race")[0].InnerText.Length != 0)
                    race =
                        (ServiteurRace)
                            Enum.Parse(typeof (ServiteurRace), elemCarte.GetElementsByTagName("race")[0].InnerText);
                else
                    race = ServiteurRace.Aucune;
                if (elemCarte.GetElementsByTagName("cost")[0].InnerText.Length != 0)
                    cout = Convert.ToUInt16(elemCarte.GetElementsByTagName("cost")[0].InnerText);
                if (elemCarte.GetElementsByTagName("name")[0].InnerText.Length != 0)
                    nom = elemCarte.GetElementsByTagName("name")[0].InnerText;
                if (elemCarte.GetElementsByTagName("text")[0].InnerText.Length != 0)
                    texte = elemCarte.GetElementsByTagName("text")[0].InnerText;
                else
                    texte = null;
                if (elemCarte.GetElementsByTagName("rarety")[0].InnerText.Length != 0)
                    rarete = elemCarte.GetElementsByTagName("rarity")[0].InnerText;
                if (elemCarte.GetElementsByTagName("id")[0].InnerText.Length != 0)
                     regexId = elemCarte.GetElementsByTagName("id")[0].InnerText;
                if (elemCarte.GetElementsByTagName("type")[0].InnerText.Length != 0)
                    type = (Type)Enum.Parse(typeof(Type), elemCarte.GetElementsByTagName("type")[0].InnerText);
                if (elemCarte.GetElementsByTagName("health")[0].InnerText.Length != 0)
                    vie = Convert.ToByte(elemCarte.GetElementsByTagName("health")[0].InnerText);
                    vie = -1;
                if (elemCarte.GetElementsByTagName("attack")[0].InnerText.Length != 0)
                    lstMeca = new[] { elemCarte.GetElementsByTagName("mechanics")[0].InnerText };
                    else
                        lstMeca[] = " ";

                // Création de l'objet "Personne" dans le tableau.
                //tabCartes[i] = new Carte(attaque, classe, cout, durabilite,extension,id,lstMeca,nom,race,rarete,regexId,texte,type,vie);
            }

            // On retourne le tableau de cartes créé.
            return tabCartes;


        }


        /// <summary>
        /// Permet d'enregistrer les données dans un fichier au format XML à partir d'un tableau d'objets de type "Carte" (sérialisation).
        /// </summary>
        /// <param name="cheminFichier">Chemin d'accès au fichier dans lequel les données seront sérialisées</param>
        /// <param name="tabPersonnes">tableau d’objets de type "arrte" à sérialiser dans le fichier. </param>
        //private static void EnregistrerDonneesPersonnes(String cheminFichier, Carte[] tabCartes)
        //{
        //}


        #endregion

    }
}
