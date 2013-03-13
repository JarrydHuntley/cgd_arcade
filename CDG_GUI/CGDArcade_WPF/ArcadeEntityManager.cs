using CGDArcade_CommonLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml;

namespace CGDArcade_WPF
{
    public class ArcadeEntityManager
    {
        public List<GenericArcadeEntity> arcadeEntities;
        XmlDocument entityManifestXmlDoc;
        public bool manifestHasChanged = false;

        public ArcadeEntityManager()
        {
            this.arcadeEntities = new List<GenericArcadeEntity>();
            LoadEntityManifest();
        }

        private void LoadEntityManifest()
        {
            if (!File.Exists("EntityManifest.xml")) { CreateEntityManifest(); }

            try
            {
                this.entityManifestXmlDoc = new XmlDocument();
                this.entityManifestXmlDoc.Load("EntityManifest.xml");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void CreateEntityManifest()
        {
            XmlDocument newDoc = new XmlDocument();
            XmlNode tempNode = newDoc.CreateElement("Manifest");
            newDoc.AppendChild(tempNode);
            newDoc.Save("EntityManifest.xml");
        }





        //  =--==--==--==--==--==--==--==--==--==--=
        //  XML INTERACTIONS
        public void AddEntityToManifest(GenericArcadeEntity arcadeEntity)
        {
            this.manifestHasChanged = true;

            XmlNode tempNode = this.entityManifestXmlDoc.CreateElement("Entity");

            // ---------------------------
            XmlAttribute xmlAttr = this.entityManifestXmlDoc.CreateAttribute("entityTitle");
            tempNode.Attributes.Append(xmlAttr);
            tempNode.Attributes["entityTitle"].Value = arcadeEntity.entityTitle;

            xmlAttr = this.entityManifestXmlDoc.CreateAttribute("entityAuthor");
            tempNode.Attributes.Append(xmlAttr);
            tempNode.Attributes["entityAuthor"].Value = arcadeEntity.entityAuthor;

            xmlAttr = this.entityManifestXmlDoc.CreateAttribute("entityDescription");
            tempNode.Attributes.Append(xmlAttr);
            tempNode.Attributes["entityDescription"].Value = arcadeEntity.entityDescription;

            // ---------------------------
            xmlAttr = this.entityManifestXmlDoc.CreateAttribute("playPath");
            tempNode.Attributes.Append(xmlAttr);
            tempNode.Attributes["playPath"].Value = arcadeEntity.playPath;

            xmlAttr = this.entityManifestXmlDoc.CreateAttribute("pathArgs");
            tempNode.Attributes.Append(xmlAttr);
            tempNode.Attributes["pathArgs"].Value = arcadeEntity.pathArgs;

            // ---------------------------
            xmlAttr = this.entityManifestXmlDoc.CreateAttribute("img1Path");
            tempNode.Attributes.Append(xmlAttr);
            tempNode.Attributes["img1Path"].Value = arcadeEntity.img1Path;

            xmlAttr = this.entityManifestXmlDoc.CreateAttribute("img2Path");
            tempNode.Attributes.Append(xmlAttr);
            tempNode.Attributes["img2Path"].Value = arcadeEntity.img2Path;

            xmlAttr = this.entityManifestXmlDoc.CreateAttribute("img3Path");
            tempNode.Attributes.Append(xmlAttr);
            tempNode.Attributes["img3Path"].Value = arcadeEntity.img3Path;

            xmlAttr = this.entityManifestXmlDoc.CreateAttribute("logoImgPath");
            tempNode.Attributes.Append(xmlAttr);
            tempNode.Attributes["logoImgPath"].Value = arcadeEntity.logoImgPath;

            this.entityManifestXmlDoc.SelectSingleNode("Manifest").AppendChild(tempNode);
            this.entityManifestXmlDoc.Save("EntityManifest.xml");
            LoadEntityManifest();

        }

        public void UpdateEntityToManifest(GenericArcadeEntity arcadeEntity)
        {
            this.manifestHasChanged = true;

            XmlNode tempNode = RetrieveEntityFromManifest(arcadeEntity.entityTitle);

            // ---------------------------
            tempNode.Attributes["entityTitle"].Value = arcadeEntity.entityTitle;
            tempNode.Attributes["entityAuthor"].Value = arcadeEntity.entityAuthor;
            tempNode.Attributes["entityDescription"].Value = arcadeEntity.entityDescription;

            // ---------------------------
            tempNode.Attributes["playPath"].Value = arcadeEntity.playPath;
            tempNode.Attributes["pathArgs"].Value = arcadeEntity.pathArgs;

            // ---------------------------
            tempNode.Attributes["img1Path"].Value = arcadeEntity.img1Path;
            tempNode.Attributes["img2Path"].Value = arcadeEntity.img2Path;
            tempNode.Attributes["img3Path"].Value = arcadeEntity.img3Path;
            tempNode.Attributes["logoImgPath"].Value = arcadeEntity.logoImgPath;

            this.entityManifestXmlDoc.SelectSingleNode("Manifest").AppendChild(tempNode);
            this.entityManifestXmlDoc.Save("EntityManifest.xml");
            LoadEntityManifest();
        }

        public void DeleteEntityFromManifest(GenericArcadeEntity arcadeEntity)
        {
            this.manifestHasChanged = true;

            XmlNode tempNode = RetrieveEntityFromManifest(arcadeEntity.entityTitle);
            if (tempNode != null)
            {
                tempNode.ParentNode.RemoveChild(tempNode);
            }

            this.entityManifestXmlDoc.Save("EntityManifest.xml");
            LoadEntityManifest();
        }





        //  =--==--==--==--==--==--==--==--==--==--=
        //  ENTITY INTERACTIONS
        public void CreateArcadeEntitiesList()
        {
            this.arcadeEntities = new List<GenericArcadeEntity>();
            List<GenericArcadeEntity> unsortedEntities = new List<GenericArcadeEntity>();

            XmlNodeList nodeList = this.entityManifestXmlDoc.SelectNodes("Manifest/Entity");

            foreach(XmlNode node in nodeList)
            {
                unsortedEntities.Add(CreateEntityFromXmlNode(node));
            }

            this.arcadeEntities = unsortedEntities.OrderBy(o => o.entityTitle).ToList();
        }

        public GenericArcadeEntity CreateEntityFromXmlNode(XmlNode tempNode)
        {
            GenericArcadeEntity newEntity = new GenericArcadeEntity();

            newEntity.entityTitle = XmlUtilities.RetrieveAttributeFromXMLNode(tempNode, "entityTitle");
            newEntity.entityAuthor = XmlUtilities.RetrieveAttributeFromXMLNode(tempNode, "entityAuthor");
            newEntity.entityDescription = XmlUtilities.RetrieveAttributeFromXMLNode(tempNode, "entityDescription");

            newEntity.playPath = XmlUtilities.RetrieveAttributeFromXMLNode(tempNode, "playPath");
            newEntity.pathArgs = XmlUtilities.RetrieveAttributeFromXMLNode(tempNode, "pathArgs");

            newEntity.img1Path = XmlUtilities.RetrieveAttributeFromXMLNode(tempNode, "img1Path");
            newEntity.img2Path = XmlUtilities.RetrieveAttributeFromXMLNode(tempNode, "img2Path");
            newEntity.img3Path = XmlUtilities.RetrieveAttributeFromXMLNode(tempNode, "img3Path");
            newEntity.logoImgPath = XmlUtilities.RetrieveAttributeFromXMLNode(tempNode, "logoImgPath");

            return newEntity;
        }


        public XmlNode RetrieveEntityFromManifest(string entityTitle)
        {
            return this.entityManifestXmlDoc.SelectSingleNode(string.Format("Manifest/Entity[@entityTitle='{0}']", entityTitle));
        }




    }
}
