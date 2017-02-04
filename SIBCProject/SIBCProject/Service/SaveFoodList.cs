using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Xml;
using SIBCProject.Models;

namespace SIBCProject.Service
{
    public class SaveFoodList
    {
        static XmlDocument doc;
        public static void SaveData(Food items)
        {
            doc = new XmlDocument();
            string xmlpath = (@"C:\Users\sathy_000\Documents\Visual Studio 2012\Projects\SIBCProject\SIBCProject\Service\MyDocument2.xml");

            
            doc.Load(xmlpath);
            var root = doc.SelectSingleNode("FoodList");
            doc.AppendChild(root);
            AddToList(root, items);
            doc.Save(xmlpath);

        }


        public static void AddToList(XmlNode root, Food f)
        {
           
            
                XmlNode item = doc.CreateElement("item");
                root.AppendChild(item);

                XmlNode fitem = doc.CreateElement("fitem");
                fitem.InnerText = f.FoodItem;
                item.AppendChild(fitem);

                XmlNode name = doc.CreateElement("name");
                name.InnerText = f.Name;
                item.AppendChild(name);
            


        }
    }
}