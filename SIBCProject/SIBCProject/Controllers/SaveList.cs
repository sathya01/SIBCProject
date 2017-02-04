using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Xml;
using SIBCProject.Models;

namespace SIBCProject.Controllers
{
    public class SaveList
    {
        public static void SaveData(Food item)
        {
            XmlDocument doc = new XmlDocument();

            //(1) the xml declaration is recommended, but not mandatory
            XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            XmlElement root = doc.DocumentElement;
            doc.InsertBefore(xmlDeclaration, root);

            //(2) string.Empty makes cleaner code
            XmlElement element1 = doc.CreateElement(string.Empty, "body", string.Empty);
            doc.AppendChild(element1);

            XmlElement element2 = doc.CreateElement(string.Empty, "FoodItem", string.Empty);
            XmlText text1 = doc.CreateTextNode(item.food);
            element2.AppendChild(text1);
            element1.AppendChild(element2);

            XmlElement element3 = doc.CreateElement(string.Empty, "Name", string.Empty);
            XmlText text2 = doc.CreateTextNode(item.name);
            element3.AppendChild(text2);
            element1.AppendChild(element3);

            doc.Save(@"C:\Users\sathy_000\Documents\Visual Studio 2012\Projects\SIBCProject\SIBCProject\Controllers\MyDocument2.xml");
        }
    }
}