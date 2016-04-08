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

        private const string nomFichierCartes = "cards-collectible.xml";

        #endregion

        #region MÉTHODES

        public static Heros[] ChargerHeros(String cheminFichier)
        {
            return null;
        }

        /// <summary>
        /// Charge les carte du fichier .xml
        /// </summary>
        /// <param name="cheminFichier"></param>
        /// <returns></returns>
        public static Carte[] ChargerCartes(String cheminFichier)
        {

            // Création d'un document XML (un objet .NET) à partir du fichier au format XML (désérialisation).
            XmlDocument xmlDoc=null;
            if (cheminFichier == null)
                cheminFichier = "cards-collectible.xml";


            try
            {
                xmlDoc
                    = new XmlDocument();

                xmlDoc.Load(cheminFichier);

            }
            catch (FileNotFoundException fnfe)
            {
                return null;
            }
            catch (OverflowException oe)
            {
                Console.WriteLine("chemin trop long");
            }
            catch (Exception e)
            {
                throw new ArgumentException();
            }



            // Récupération de tous les éléments "Cartes".
            XmlNodeList listeElemCarte = xmlDoc.GetElementsByTagName("card");

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
            List<string> lstMeca = null;
            HerosClasse classe = HerosClasse.Neutre;
            ServiteurRace race = ServiteurRace.Aucune;
            CarteType type = CarteType.Minion;
            XmlElement elemCarte = null;


            for (int i = 0; i < listeElemCarte.Count; i++)
            {
                if (elemCarte.GetElementsByTagName("type")[0].InnerText != "Hero")
                {
                    // Récupération du noeud "Carte" à traiter.
                    elemCarte = (XmlElement) listeElemCarte[i];
                    // Récupération du type, de l'attaque, de la durabilité, de la vie, du coût, de l'extension, de l'id, du nom, de regxId, du texte, du tableau de 
                    //mecanique, de la rareté, de la classe et de la race.
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
                    if (elemCarte.GetElementsByTagName("mechanics")[0].InnerText.Length != 0)
                        lstMeca.Add(elemCarte.GetElementsByTagName("mechanics")[0].InnerText);
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
            if (cheminFichier == null)
                return;


            if (cheminFichier.Length >= 300)
                throw new ArgumentException("Le nom du fichier est trop long"); 
            XmlDocument xmlDoc = null;
            try
            {
                // Création d'un document XML vide (un objet .NET)
                xmlDoc = new XmlDocument();

            }
            catch (FileNotFoundException fnfe)
            {
                   throw new ArgumentException();
            }
            catch (Exception e)
            {
                Console.WriteLine("Une exception s'est produite.");
                Console.WriteLine("Type d'exception : " + e.GetType());
                Console.WriteLine("Message d'erreur : " + e.Message);
            }





            // Ajout de la déclaration xml.
            XmlDeclaration xmlDec1 = xmlDoc.CreateXmlDeclaration("1.0", "utf-8", null);
            xmlDoc.AppendChild(xmlDec1);

            //Cération de l'élément racine du document XMl, soit "listeCartes".
            XmlElement elemListeCartes = xmlDoc.CreateElement("listeCartes");

            //Ajout de l'élément "listeCartes" au document XML.
            xmlDoc.AppendChild(elemListeCartes);

            //Variables utilitaires pour la création des éléments "Carte" et de ses sous-éléments.
            XmlElement elemAttaque, elemClasse, elemCout, elemDurabilite,elemExtension, elemVie,  elemId,
                elemNom, elemRegexId, elemTexte, elemRarete, elemLstMeca, 
                 elemRace, elemType, elemCarte;

            //Traitement de chaque objet "Carte" du tableau.
            for (int i = 0; i < tabCartes.Length; i++)
            {
                //Création de l'élément "Carte" (ainsi que de son contenu) pour le deck.
                elemCarte = xmlDoc.CreateElement("Carte");

                elemAttaque = xmlDoc.CreateElement("Attaque");
                elemAttaque.InnerText = tabCartes[i].Attaque + "";

                elemDurabilite = xmlDoc.CreateElement("Durabilite");
                elemDurabilite.InnerText = tabCartes[i].Durabilite + "";

                elemVie = xmlDoc.CreateElement("Vie");
                elemVie.InnerText = tabCartes[i].Vie + "";

                elemCout = xmlDoc.CreateElement("Cout");
                elemVie.InnerText = tabCartes[i].Vie + "";

                elemExtension = xmlDoc.CreateElement("Extension");
                elemExtension.InnerText = tabCartes[i].Extension;

                elemId = xmlDoc.CreateElement("Id");
                elemId.InnerText = tabCartes[i].Id;

                elemNom = xmlDoc.CreateElement("Nom");
                elemNom.InnerText = tabCartes[i].Nom;

                elemRegexId = xmlDoc.CreateElement("RegexId");
                elemRegexId.InnerText = tabCartes[i].RegexId;

                elemTexte = xmlDoc.CreateElement("Texte");
                elemTexte.InnerText = tabCartes[i].Texte;

                elemRarete = xmlDoc.CreateElement("Rarete");
                elemRarete.InnerText = tabCartes[i].Rarete;

                elemLstMeca = xmlDoc.CreateElement("LstMeca");
                elemLstMeca.InnerText = tabCartes[i].LstMeca + "";

                elemClasse = xmlDoc.CreateElement("Classe");
                elemClasse.InnerText = tabCartes[i].Classe + "";

                elemRace = xmlDoc.CreateElement("Race");
                elemRace.InnerText = tabCartes[i].Race + "";

                elemType = xmlDoc.CreateElement("Type");
                elemType.InnerText = tabCartes[i].Type + "";

                //Ajout des sous-éléments à l'élément "Carte".
                elemCarte.AppendChild(elemAttaque);
                elemCarte.AppendChild(elemDurabilite);
                elemCarte.AppendChild(elemVie);
                elemCarte.AppendChild(elemCout);
                elemCarte.AppendChild(elemExtension);
                elemCarte.AppendChild(elemId);
                elemCarte.AppendChild(elemNom);
                elemCarte.AppendChild(elemRegexId);
                elemCarte.AppendChild(elemTexte);
                elemCarte.AppendChild(elemRarete);
                elemCarte.AppendChild(elemLstMeca);
                elemCarte.AppendChild(elemClasse);
                elemCarte.AppendChild(elemRace);
                elemCarte.AppendChild(elemType);
                




                //Ajout de l'élément "Carte" à l'élément "listeCartes".
                elemListeCartes.AppendChild(elemCarte);
            }

            //Enregistrement du document XML dans un fichier par sérialisation.
            xmlDoc.Save(cheminFichier);
        }


        #endregion

    }
}
