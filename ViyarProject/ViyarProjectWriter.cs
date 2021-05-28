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
 
  public static class ViyarProjectWriter
  {
     public static void writeProject(ViyarProject project)
     {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            XmlSerializer formatter = new XmlSerializer(typeof(ViyarProject));
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.ConformanceLevel = ConformanceLevel.Document;
            settings.OmitXmlDeclaration = false; // не подавлять xml заголовок
            settings.Encoding = Encoding.GetEncoding("WINDOWS-1251"); // кодировка
            settings.Indent = true; // добавлять отступы
            settings.IndentChars = "    "; // символы отступа

            // подавляем неймспейсы
            XmlSerializerNamespaces dummyNSs = new XmlSerializerNamespaces();
            dummyNSs.Add(string.Empty, string.Empty);
            // получаем поток, куда будем записывать сериализованный объект
            string filename = project.viyar.user.fileName + ".project";
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                 using (XmlWriter xw = XmlWriter.Create(fs, settings))
                {
               formatter.Serialize(xw, project,dummyNSs);
                }
            }
     }
  }
}
 