using System;
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
            pr.addMaterial(dsp);
            var pvc = new EdgeMaterial();
            pr.addMaterial(pvc);
            Detail det1 = new Detail();
            Detail det2 = new Detail();
            det1.id=1;
            det1.edges.Left.type = "kromka";
            det1.edges.Left.param = 2;
            det2.id = 2;
            det2.edges.Top.type = "kromka";
            det2.edges.Top.param = 2;
            var dril = new Drilling();
            det1.addOperation(dril);
            var groov = new Grooving();
            det2.addOperation(groov);
            pr.addDetail(det1);
            pr.addDetail(det2);
            Console.WriteLine("Проект создан!");
            ViyarProjectWriter.writeProject(pr);
            Console.WriteLine("Проект сериализован");
        }
    }
}
