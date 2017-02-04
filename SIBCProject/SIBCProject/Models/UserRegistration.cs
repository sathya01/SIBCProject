using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Serialization;

namespace SIBCProject.Models
{
    public class UserRegistration 
    {
    [XmlElement ("Fname")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [XmlElement("Lname")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [XmlElement("Email")]
        public string Email { get; set; }
        [XmlElement("Phone1")]
        [Display(Name = "Phone Number(Home)")]
        public int PhoneNo1 { get; set; }

        [XmlElement("Phone2")]
        [Display(Name = "Phone Number(Office)")]
        public int PhoneNo2 { get; set; }
        [XmlElement("Address")]
        [Display(Name = "Street Address")]
        public string StreetAddress { get; set; }

        [XmlElement("City")]
        public string City { get; set; }
        [XmlElement("Spouse")]
        [Display(Name = "Spouse Name")]
        public string SpouseName { get; set; }
        [Display(Name = "Child Name 1")]
        public string Child1 { get; set; }
        [Display(Name = "Child Name 2")]
        public string Child2 { get; set; }
        [Display(Name = "Child Name 3")]
        public string Child3 { get; set; }
        [Display(Name = "Child Name 4")]
        public string Child4 { get; set; }

        public UserRegistration()
        {}

        //public UserRegistration(string FirstName, string LastName, string Email, int PhoneNo1, int PhoneNo2, string StreetAddress, string City, string SpouseName)
        //{
        //    this.FirstName = FirstName;
        //    this.LastName = LastName;
        //    this.Email = Email;
        //    this.PhoneNo1 = PhoneNo1;
        //    this.PhoneNo2 = PhoneNo2;
        //    this.StreetAddress = StreetAddress;
        //    this.City = City;
        //    this.SpouseName = SpouseName;
        //}

    }
}
