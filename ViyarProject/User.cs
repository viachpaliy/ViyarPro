using System;
using System.IO;
using System.Xml;
using System.Text;
using System.Xml.Serialization;
using System.Globalization;
using System.ComponentModel;

namespace ViyarProject
{
  
    [Serializable]
    public class User
    {
        [XmlAttribute]
        public string name = "";
        [XmlAttribute]
        public string phone = "";
        [XmlAttribute]
        public string email = "";
        [XmlAttribute]
        public string uuid = "";
        [XmlAttribute]
        public string fileName = "";
        [XmlAttribute]
        public string ZakazBazar = "";
        public User(){}
    }
}