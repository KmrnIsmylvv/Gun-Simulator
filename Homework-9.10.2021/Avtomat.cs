using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_9._10._2021
{
    class Avtomat
    {
        private int _gullesayi;


        public int Gullesayi { get => _gullesayi; set => _gullesayi = value; }

        public void MaqaziniTekTekDoldurmaq()
        {
            if (_gullesayi != 30)
            {
                _gullesayi++;
                Console.WriteLine($"Gulle Sayi: {_gullesayi}");
            }
            else
            {
                Console.WriteLine("Gulle sayi maksimumdur");
            }
        }

        public void MaqaziniBirbasaDoldurmaq()
        {
            _gullesayi = 30;
            Console.WriteLine($"Gulle Sayi: {_gullesayi}");
        }

        public void TekliRejim()
        {
            if (_gullesayi != 0)
            {
                _gullesayi--;
                Console.WriteLine($"Gulle Sayi: {_gullesayi}");
            }
            else
            {
                Console.WriteLine("Gulle yoxdur");
                Console.WriteLine($"Gulle Sayi: {_gullesayi}");
            }
        }

        public void AvtomatRejimi()
        {
            if (_gullesayi != 0)
            {
                _gullesayi = 0;
                Console.WriteLine($"Gulle Sayi: {_gullesayi}");
            }
            else
            {
                Console.WriteLine("Gulle yoxdur");
                Console.WriteLine($"Gulle Sayi: {_gullesayi}");
            }
        }
    }
}
