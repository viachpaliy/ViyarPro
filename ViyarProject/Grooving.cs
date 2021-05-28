using System;
using System.IO;
using System.Xml;
using System.Text;
using System.Xml.Serialization;
using System.Globalization;
using System.ComponentModel;
using System.Collections.Generic;

namespace ViyarProject
{
     
    [Serializable] 
    public class Grooving : AbstractOperation
    {       
        [XmlAttribute]
        public string side="6";
        [XmlAttribute]
        public string subtype="0";
        [XmlAttribute]
        public string x="0";
        [XmlAttribute]
        public string y="10";
        [XmlAttribute]
        public string bindH="false";
        [XmlAttribute]
        public string bindV="false";
        [XmlAttribute]
        public string xa="-0.5";
        [XmlAttribute]
        public string ya="9.5";
        [XmlAttribute]
        public string width="4";
        [XmlAttribute]
        public string length="710";
        [XmlAttribute]
        public string depth="8";
        [XmlAttribute]
        public string closed="1";
        [XmlAttribute]
        public string full="1";
        [XmlAttribute]
        public string millD="0";
        [XmlAttribute]
        public string article="";
        [XmlAttribute]
        public string freza="";
        [XmlAttribute]
        public string BHXAvailable="true";

        public Grooving()
        {
            type="grooving";
        }
    }
}