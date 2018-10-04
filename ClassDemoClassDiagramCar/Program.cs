using System;
using ClassDemoClassDiagramCar.model;

namespace ClassDemoClassDiagramCar
{
    class Program
    {
        static void Main(string[] args)
        {
            Ejer ejer = new Ejer("Peter");
            Hjul h1 = new Hjul("vinter");
            Hjul h2 = new Hjul("vinter");
            Hjul h3 = new Hjul("vinter");
            Hjul h4 = new Hjul("vinter");

            Bil bil = new Bil("Ford T", 23000);
            bil.BilEjer.Add(ejer);
            bil.BilHjul[0] = h1;
            bil.BilHjul[1] = h2;
            bil.BilHjul[2] = h3;
            bil.BilHjul[3] = h4;
            bil.TilføjDør();
            bil.TilføjDør();
            bil.ÅbenDør(1);


            Console.WriteLine("BIL::" + bil);
            Console.WriteLine("BIL Ejer::" + String.Join("\n", bil.BilEjer));
            Console.Write("BIL Hjul::" );
            foreach (Hjul hjul in bil.BilHjul)
            {
                Console.WriteLine(hjul);
            }
            Console.WriteLine("BIL Døre::" + String.Join("\n", bil.HentDøre()));

            Console.WriteLine($"Næste værkstedsbesøg om {bil.DageTilNæsteVærksted()} dage");

            
            Console.ReadLine();
        }
    }
}
