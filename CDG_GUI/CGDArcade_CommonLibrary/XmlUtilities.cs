using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml;

namespace CGDArcade_CommonLibrary
{
    static public class XmlUtilities
    {
        static public string RetrieveAttributeFromXMLNode(XmlNode tempNode, string attribute)
        {
            string value = "";

            try
            {
                if (tempNode.Attributes[attribute] != null)
                {
                    value = tempNode.Attributes[attribute].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

            return value;
        }

    }
}
