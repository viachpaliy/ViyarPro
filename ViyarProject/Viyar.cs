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
    public class Viyar
    {
        [XmlAttribute]
        public string version="27";
        public User user = new User();
        public Order order = new Order();
        public Constructor constructor = new Constructor();
       
        [XmlArrayItem(ElementName = "material")]
        [XmlArray(ElementName="materials")]
        public List<AbstractMaterial> Materials = new List<AbstractMaterial>();
     
        public Details details = new Details();
       
         public Viyar(){}
        
    }
}