using System;

namespace ClassIntro3
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Cemal";
            int yas = "33";

            Kurs Kurs1 = new Kurs();
            Kurs1.KursAdi = "C#";
            Kurs1.Egitmen = "Cemal Kızılırmak";
            Kurs1.IzlenmeOrani = 66;

            Kurs Kurs2 = new Kurs();
            Kurs2.KursAdi = "Java";
            Kurs2.Egitmen = "Azime Kızılırmak";
            Kurs2.IzlenmeOrani = 10;

            Kurs Kurs3 = new Kurs();
            Kurs3.KursAdi = "Python";
            Kurs3.Egitmen = "Ömer Kızılırmak";
            Kurs3.IzlenmeOrani = 34;

            Console.WriteLine(Kurs1.KursAdi + " : " + Kurs1.Egitmen);



            Console.WriteLine("Hello World!");
        }
    }

    class Kurs
    {
       
        public string KursAdi { get; set; }

        public string Egitmen { get; set; }

        public int IzlenmeOrani { get; set; }
    }
}
