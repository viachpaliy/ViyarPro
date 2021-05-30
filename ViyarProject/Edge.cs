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
    public class Edge
    {
        [XmlAttribute]
        public string type="";
        [XmlAttribute]
        public int param= 0;
        [XmlAttribute]
        public string cut="0";
        [XmlAttribute]
        public string cutId="0";
        [XmlAttribute]
        public string drop="0";
        [XmlAttribute]
        public string curv="0";
        [XmlAttribute]
        public string pur="0";
        [XmlAttribute]
        public string chamfer45="0";

        public Edge(){}
    }
}