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
    public class Edges
    {
        [XmlElement(ElementName="left")]
        public Edge Left = new Edge();
        [XmlElement(ElementName="top")]
        public Edge Top = new Edge();
        [XmlElement(ElementName="right")]
        public Edge Right = new Edge();
        [XmlElement(ElementName="bottom")]
        public Edge Bottom = new Edge();
        public Edges(){}
    }
}