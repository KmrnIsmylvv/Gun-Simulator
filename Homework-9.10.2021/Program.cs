using System;

namespace Homework_9._10._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Avtomat avt = new Avtomat();
            avt.Gullesayi = 0;
            Console.WriteLine($"Baslangic Gulle: {avt.Gullesayi}");
            avt.AvtomatRejimi();
            avt.MaqaziniTekTekDoldurmaq();
            avt.MaqaziniBirbasaDoldurmaq();
            avt.TekliRejim();
            avt.AvtomatRejimi();
            avt.TekliRejim();
        }
    }
}
