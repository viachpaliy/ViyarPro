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
    public class Detail
    {
        [XmlAttribute]
        public string id="4";
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
        public string amount="1";
        [XmlAttribute]
        public string width="500";
        [XmlAttribute]
        public string height="400";
        [XmlAttribute]
        public string widthFull="500";
        [XmlAttribute]
        public string heightFull="400";
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

        public Detail()
        {
            timestamp = DateTime.Now.ToString("yyyyMMddHHmmssffff");
        }

    }
}