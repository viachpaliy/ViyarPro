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
    public class Drilling : AbstractOperation
    {       
        [XmlAttribute]
        public string subtype="0";
        [XmlAttribute]
        public int side= 1;
        [XmlAttribute]
        public double  x= 9;
        [XmlAttribute]
        public double y= 50;
        [XmlAttribute]
        public double xo= 9;
        [XmlAttribute]
        public double yo= 50;
        [XmlAttribute]
        public double xl= 0;
        [XmlAttribute]
        public double yl= 0;
        [XmlAttribute]
        public double d= 7;
        [XmlAttribute]
        public double depth= 30;
        [XmlAttribute]
        public string millD="0";


        public Drilling()
        {
            type="drilling";
        }
    }
}