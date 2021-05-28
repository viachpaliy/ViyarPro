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
    [XmlType("details")]
    public class Details 
    {
        [XmlAttribute]
        public string edge="eva";
        [XmlAttribute]
        public string typeEdge="edge";
        [XmlElement("detail")]
        public List<Detail> details = new List<Detail>();
        public Details(){}
    }
}