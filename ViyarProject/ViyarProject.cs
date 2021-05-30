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
    
    [XmlType("project")]
    public class ViyarProject
    {
         
         [XmlAttribute]
         public string currency="грн";
         [XmlAttribute]
         public string version = "1";
         [XmlAttribute]
         public string costOperation = "0";
         [XmlAttribute]
         public string costMaterial = "0";
         [XmlAttribute]
         public string cost = "0";
         [XmlAttribute]
         public string date = DateTime.Now.ToString(new CultureInfo( "ru-RU"));
         [XmlAttribute]
         public string orderDate = "0";
         [XmlAttribute]
         public string productFilter = "false";

         public Viyar viyar = new Viyar() ;
         
         public ViyarProject() { }     
         
        public void addMaterial(AbstractMaterial material){
            int matId = viyar.Materials.Count + 1;
            material.id = matId;
            viyar.Materials.Add(material);
        }

        public void addDetail(Detail detail){
            int detId = viyar.details.details.Count + 1;
            detail.id = detId;
            viyar.details.details.Add(detail);
        }



    }
}