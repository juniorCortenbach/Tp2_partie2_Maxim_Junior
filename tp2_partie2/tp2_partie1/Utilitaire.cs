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
using System.Runtime.CompilerServices;
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
        #region CONSTANTE

        private const string nomFichierCartes = "Cartes.xml";

        #endregion

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

            // Création du tableau de cartes; la taille est déterminée par le nombre d'éléments "Carte".
            Carte[] tabCartes = new Carte[listeElemCarte.Count];

            // Variables utilitaires pour la création d'un objet "Carte".
            sbyte attaque=-1;
            sbyte durabilite = -1;
            sbyte vie=-1;
            ushort cout=0;
            String extension = "";
            String id = "";
            String nom = "";
            String regexId = "";
            String texte = "";
            String rarete = "";
            List<string> lstMeca;
            HerosClasse classe = HerosClasse.Neutre;
            ServiteurRace race = ServiteurRace.Aucune;
            CarteType type = CarteType.Minion;
            XmlElement elemCarte = null;

            for(int i=0; i< tabCartes.Length; i++)
            {
                byte compteurMecaniques=0;

                if (elemCarte.GetElementsByTagName("type")[0].InnerText != "Hero")
                {
                    // Récupération du noeud "Carte" à traiter.
                    elemCarte = (XmlElement) listeElemCarte[i];
                    // Récupération de l'attaque, de la durabilité, de la vie, du coût, de l'extension, de l'id, du nom, de regxId, du texte, du tableau de 
                    //mecanique, de la rareté, de la _class, de la  race, du type.
                    if (elemCarte.GetElementsByTagName("type")[0].InnerText.Length != 0)
                        type =
                            (CarteType)
                                Enum.Parse(typeof (CarteType), elemCarte.GetElementsByTagName("type")[0].InnerText);

                        if (elemCarte.GetElementsByTagName("attack")[0].InnerText.Length != 0)
                            attaque = Convert.ToSByte(elemCarte.GetElementsByTagName("attack")[0].InnerText);
                    if (elemCarte.GetElementsByTagName("durability")[0].InnerText.Length != 0)
                        durabilite = (sbyte) Convert.ToByte(elemCarte.GetElementsByTagName("durability")[0].InnerText);
                    if (elemCarte.GetElementsByTagName("set")[0].InnerText.Length != 0)
                        extension = elemCarte.GetElementsByTagName("set")[0].InnerText;
                    if (elemCarte.GetElementsByTagName("id")[0].InnerText.Length != 0)
                        id = Convert.ToString(elemCarte.GetElementsByTagName("id")[0].InnerText);
                    if (elemCarte.GetElementsByTagName("race")[0].InnerText.Length != 0)
                        race =
                            (ServiteurRace)
                                Enum.Parse(typeof (ServiteurRace), elemCarte.GetElementsByTagName("race")[0].InnerText);
                    if (elemCarte.GetElementsByTagName("cost")[0].InnerText.Length != 0)
                        cout = Convert.ToUInt16(elemCarte.GetElementsByTagName("cost")[0].InnerText);
                    if (elemCarte.GetElementsByTagName("name")[0].InnerText.Length != 0)
                        nom = elemCarte.GetElementsByTagName("name")[0].InnerText;
                    if (elemCarte.GetElementsByTagName("text")[0].InnerText.Length != 0)
                        texte = elemCarte.GetElementsByTagName("text")[0].InnerText;
                    if (elemCarte.GetElementsByTagName("rarety")[0].InnerText.Length != 0)
                        rarete = elemCarte.GetElementsByTagName("rarity")[0].InnerText;
                    if (elemCarte.GetElementsByTagName("id")[0].InnerText.Length != 0)
                        regexId = elemCarte.GetElementsByTagName("id")[0].InnerText;
                    if (elemCarte.GetElementsByTagName("health")[0].InnerText.Length != 0)
                        vie = (sbyte) Convert.ToByte(elemCarte.GetElementsByTagName("health")[0].InnerText);

                    do
                    {

                        lstMeca = new List<string> {(elemCarte.GetElementsByTagName("mechanics")[0].InnerText)};

                    } while (elemCarte.GetElementsByTagName("mechanics")[0].InnerText.Length != 0);

                    if (elemCarte.GetElementsByTagName("mechanics")[0].InnerText.Length == 0)
                    lstMeca = new List<string> {""};

                    // Création de l'objet "Carte" dans le tableau.
                    tabCartes[i] = new Carte(attaque, classe, cout, durabilite, extension, id, lstMeca, nom, race,
                        rarete, regexId, texte, type, vie);
                }
            } 

            // On retourne le tableau de cartes créé.
            return tabCartes;
        }


        /// <summary>
        /// Permet d'enregistrer les données dans un fichier au format XML à partir d'un tableau d'objets de type "Carte" (sérialisation).
        /// </summary>
        /// <param name="cheminFichier">Chemin d'accès au fichier dans lequel les données seront sérialisées</param>
        /// <param name="tabCartes">tableau d’objets de type "arrte" à sérialiser dans le fichier. </param>
        private static void EnregistrerDonneesDeck(String cheminFichier, Carte[] tabCartes)
        {
            // Création d'un document XML vide (un objet .NET)
            XmlDocument xmlDoc = new XmlDocument();

            // Ajout de la déclaration xml.
            XmlDeclaration xmlDec1 = xmlDoc.CreateXmlDeclaration("1.0", "utf-8", null);
            xmlDoc.AppendChild(xmlDec1);

            //Cération de l'élément racine du document XMl, soit "listeCartes".
            XmlElement elemListeCartes = xmlDoc.CreateElement("listeCartes");

            //Ajout de l'élément "listeCartes" au document XML.
            xmlDoc.AppendChild(elemListeCartes);

            //Variables utilitaires pour la création des éléments "Carte" et de ses sous-éléments.
            sbyte attaque = -1;
            sbyte durabilite = -1;
            sbyte vie = -1;
            ushort cout = 0;
            String extension = "";
            String id = "";
            String nom = "";
            String regexId = "";
            String texte = "";
            String rarete = "";
            List<string> lstMeca;
            HerosClasse classe = HerosClasse.Neutre;
            ServiteurRace race = ServiteurRace.Aucune;
            CarteType type = CarteType.Minion;
            XmlElement elemCarte;

            //Traitement de chaque objet "Carte" du tableau.
            for (int i = 0; i < tabCartes.Length; i++)
            {
                //Création de l'élément "Carte" (ainsi que de son contenu) pour le deck
            }
        }


        #endregion

    }
}
