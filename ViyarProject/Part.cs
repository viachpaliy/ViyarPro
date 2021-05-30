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
    public class Part
    {
        [XmlAttribute]
        public double width= 2800;
        [XmlAttribute]
        public double height= 2070;
        [XmlAttribute]
        public int quantity= 1;
        
        public Part(){}
    }
}