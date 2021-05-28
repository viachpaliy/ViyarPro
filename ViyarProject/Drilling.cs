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
    public class Drilling : AbstractOperation
    {       
        [XmlAttribute]
        public string subtype="0";
        [XmlAttribute]
        public string side="1";
        [XmlAttribute]
        public string  x="9";
        [XmlAttribute]
        public string y="50";
        [XmlAttribute]
        public string xo="9";
        [XmlAttribute]
        public string yo="50";
        [XmlAttribute]
        public string xl="0";
        [XmlAttribute]
        public string yl="0";
        [XmlAttribute]
        public string d="7";
        [XmlAttribute]
        public string depth="30";
        [XmlAttribute]
        public string millD="0";

        public Drilling()
        {
            type="drilling";
        }
    }
}