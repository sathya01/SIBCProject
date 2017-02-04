using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Xml;
using SIBCProject.Models;
using System.Xml.Serialization;

namespace SIBCProject.Controllers
{
    public class Savexml
    {
      static  XmlDocument doc;

     public static void SaveData(UserRegistration userReg)
     {
         string xmlpath = (@"C:\Users\sathy_000\Documents\Visual Studio 2012\Projects\SIBCProject\SIBCProject\Service\MyDocument.xml");

         doc = new XmlDocument();
         doc.Load(xmlpath);
         var root = doc.SelectSingleNode("UserDetails");
         doc.AppendChild(root);
         AddToList(root, userReg);
         doc.Save(xmlpath);

     }
     public static void AddToList(XmlNode root, UserRegistration u)
     {

         XmlNode user = doc.CreateElement("user");
         root.AppendChild(user);

         XmlNode fname = doc.CreateElement("fname");
         fname.InnerText = u.FirstName;
         user.AppendChild(fname);

         XmlNode lname = doc.CreateElement("lname");
         lname.InnerText = u.LastName;
         user.AppendChild(lname);

         XmlNode email = doc.CreateElement("email");
         email.InnerText = u.Email;
         user.AppendChild(email);

         XmlNode phone1 = doc.CreateElement("phone1");
         phone1.InnerText = u.PhoneNo1.ToString();
         user.AppendChild(phone1);

         XmlNode phone2 = doc.CreateElement("phone2");
         phone2.InnerText = u.PhoneNo2.ToString();
         user.AppendChild(phone2);

         XmlNode address = doc.CreateElement("address");
         address.InnerText = u.StreetAddress;
         user.AppendChild(address);

         XmlNode city = doc.CreateElement("city");
         city.InnerText = u.City;
         user.AppendChild(city);

         XmlNode spouse = doc.CreateElement("spouse");
         spouse.InnerText = u.SpouseName;
         user.AppendChild(spouse);

 

         //XmlElement element10 = doc.CreateElement(string.Empty, "Child1", string.Empty);
         //XmlText text9 = doc.CreateTextNode(user.Child1);
         //element10.AppendChild(text9);
         //element1.AppendChild(element10);



     }
    }
}