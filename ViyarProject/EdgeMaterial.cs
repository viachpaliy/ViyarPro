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
    public class EdgeMaterial : AbstractMaterial
    {       
        [XmlAttribute]
        public string article = "42691";
        [XmlAttribute]
        public string guid = "42691";
        [XmlAttribute]
        public string oldGuid = "42691";
        [XmlAttribute]
        public string uuid = "835c60ac-c2ca-11e7-b5a5-005056b13af7";
        [XmlAttribute]
        public string name ="������ ��������� 22�0,5��";
        [XmlAttribute]
        public double height =22;
        [XmlAttribute]
        public double thickness = 0.5;
        [XmlAttribute]
        public string markingColor="rgb(255,0,0)";

        public EdgeMaterial()
        {
            id = 2;
            type = "band";
        }
    }
}