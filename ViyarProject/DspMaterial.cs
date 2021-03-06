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
    public class DspMaterial : AbstractMaterial
    {       
        [XmlAttribute]
        public double offcut_l= 10 ;
        [XmlAttribute]
        public double offcut_t= 10 ;
        [XmlAttribute]
        public double offcut_r= 5 ;
        [XmlAttribute]
        public double offcut_b= 5 ;
        [XmlAttribute]
        public double userOffcut= 0;
        [XmlAttribute]
        public string directCut="0";
        [XmlAttribute]
        public string article = "55";
        [XmlAttribute]
        public string typeMat="dsp";
        [XmlAttribute]
        public string guid = "0000";
        [XmlAttribute]
        public string oldGuid = "0000";
        [XmlAttribute]
        public string uuid = "93d632db-d7e8-4178-98e2-641bb27485f7";
        [XmlAttribute]
        public string name ="�������� ��������� (���)";
        [XmlAttribute]
        public double width= 2800;
        [XmlAttribute]
        public double height = 2070;
        [XmlAttribute]
        public double thickness = 18;
        [XmlAttribute]
        public string isCliental="1";
        [XmlAttribute]
        public string oneSided="";
        [XmlArrayItem(ElementName= "part")]
        [XmlArray(ElementName="parts")]
        public List<Part> Parts = new List<Part>();

        public DspMaterial()
        {
            id = 1;
            type = "sheet";
            Parts.Add(new Part());
        }
    }
}