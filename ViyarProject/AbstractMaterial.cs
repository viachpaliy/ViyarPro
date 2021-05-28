using System;
using System.IO;
using System.Xml;
using System.Text;
using System.Xml.Serialization;
using System.Globalization;
using System.ComponentModel;

namespace ViyarProject
{
    [XmlInclude(typeof(DspMaterial))]   
    public class AbstractMaterial
    {
        [XmlAttribute]
        public string id = "0";
        [XmlAttribute]
        public string type = "abstract";
      
        public AbstractMaterial(){}
    }
}