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
    public class Detail
    {
        [XmlAttribute]
        public int id= 0;
        [XmlAttribute]
        public string tumbarikiConstructionName="";
        [XmlAttribute]
        public string tumbarikiConstructionId="";
        [XmlAttribute]
        public string tumbarikiDetailName="";
        [XmlAttribute]
        public string tumbarikiDetailId="";
        [XmlAttribute]
        public string material="1";
        [XmlAttribute]
        public string barcode="";
        [XmlAttribute]
        public int amount= 1;
        [XmlAttribute]
        public double width= 500 ;
        [XmlAttribute]
        public double height= 400 ;
        [XmlAttribute]
        public double widthFull= 500;
        [XmlAttribute]
        public double heightFull= 400 ;
        [XmlAttribute]
        public string description="";
        [XmlAttribute]
        public string slidingfilling="0";
        [XmlAttribute]
        public string timestamp="1621682794";
        [XmlAttribute]
        public string multiplicity="1";
        [XmlAttribute]
        public string grain="1";
        [XmlAttribute]
        public string decoratedSide="";
        [XmlAttribute]
        public string marker="0";
        [XmlAttribute]
        public string BHXAvailable="true";
        [XmlAttribute]
        public string machineCode="1";

        public Edges edges = new Edges();

        [XmlArrayItem(ElementName = "operation")]
        [XmlArray(ElementName="operations")]
        public List<AbstractOperation> Operations = new List<AbstractOperation>();
     

        public Detail()
        {
            timestamp = DateTime.Now.ToString("yyyyMMddHHmmssffff");
        }

        public void addOperation(AbstractOperation operation){
            int opId = Operations.Count + 1;
            operation.id = opId;
            Operations.Add(operation);
        }

    }
}