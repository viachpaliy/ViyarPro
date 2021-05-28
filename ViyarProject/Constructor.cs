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
    public class Constructor
    {
        [XmlAttribute]
        public string id="dsp" ;
        [XmlAttribute]
        public string fromTumbariki="" ;
        [XmlAttribute]
        public string tumbarikiKitchenName="" ;
        [XmlAttribute]
        public string site="viyar.ua" ;
        [XmlAttribute]
        public string city="kiev" ;
        [XmlAttribute]
        public string xnc="1" ;
        [XmlAttribute]
        public string robot="G";

        public Constructor(){}
    }
}