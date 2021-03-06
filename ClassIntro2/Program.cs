﻿using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Cemal";
            int yas = "33";

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Cemal Kızılırmak";
            kurs1.IzlenmeOrani = "66";

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Azime Kızılırmak";
            kurs2.IzlenmeOrani = "10";

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Ömer Kızılırmak";
            kurs3.IzlenmeOrani = "34";

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "Python";
            kurs4.Egitmen = "Oglum Kızılırmak";
            kurs4.IzlenmeOrani = "34";


            //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3, kurs4, };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);
            }

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