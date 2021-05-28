﻿using System;
using System.IO;
using System.Xml;
using System.Text;
using System.Xml.Serialization;
using System.Globalization;
using System.ComponentModel;
using System.Collections.Generic;
using ViyarProject;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var pr=new ViyarProject.ViyarProject();
            string filenm = "viyartest";
            pr.viyar.user.fileName = filenm;
            var dsp = new DspMaterial();
            pr.viyar.Materials.Add(dsp);
            Detail det1 = new Detail();
            Detail det2 = new Detail();
            det1.id="1";
            det2.id="2";
            pr.viyar.details.details.Add(det1);
            pr.viyar.details.details.Add(det2);
            Console.WriteLine("Проект создан!");
            ViyarProjectWriter.writeProject(pr);
            Console.WriteLine("Проект сериализован");
        }
    }
}