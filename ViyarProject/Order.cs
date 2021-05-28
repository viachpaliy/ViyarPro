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
    public class Order 
    {
        [XmlAttribute]
        public string delivery = "d";
        [XmlAttribute]
        public string uuid = "";
        public Order(){}
    }
}