﻿using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "ProgramlamaYA Başlangıç için temel kurs";
            string kurs3 = "Java";

            Console.WriteLine("kurs1");
            Console.WriteLine("kurs2");
            Console.WriteLine("kurs3");

            //array - dizi

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", "Programlamaya Başlangıç için temel kurs", "Java", "Python", "C++" };



            for (int i = 0; i<kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }


            Console.WriteLine("for bitti");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }


            Console.WriteLine("Sayfa sonu - footer");
        }
    }
}
