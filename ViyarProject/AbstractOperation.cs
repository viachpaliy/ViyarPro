using System;
using System.IO;
using System.Xml;
using System.Text;
using System.Xml.Serialization;
using System.Globalization;
using System.ComponentModel;

namespace ViyarProject
{
    [XmlInclude(typeof(Drilling))]  
    [XmlInclude(typeof(Grooving))] 
    public class AbstractOperation
    {
        [XmlAttribute]
        public int id = 0;
        [XmlAttribute]
        public string type = "abstract";
      
        public AbstractOperation(){}
    }
}