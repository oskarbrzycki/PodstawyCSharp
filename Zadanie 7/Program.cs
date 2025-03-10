using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący liczbę arabską od 1 do 3999 i wypisujący na ekranie jej
            //dpowiednik rzymski.
            int liczba, wynik;
            Console.WriteLine("Podaj liczbe");
            liczba = Convert.ToInt32(Console.ReadLine());
            if (liczba >= 90) { liczba -= 90; Console.WriteLine("XC"); }
            else if (liczba >= 80) { liczba -= 80; Console.WriteLine("LXXX"); }
            else if (liczba >= 70) { liczba -= 70; Console.WriteLine("LXX"); }
            else if (liczba >= 60) { liczba -= 60; Console.WriteLine("LXX"); }
            else if (liczba >= 50) { liczba -= 50; Console.WriteLine("L"); }
            else if (liczba >= 40) { liczba -= 40; Console.WriteLine("XL"); }
            else if (liczba >= 30) { liczba -= 30; Console.WriteLine("XXX"); }
            else if (liczba >= 20) { liczba -= 20; Console.WriteLine("XX"); }
            else if (liczba >= 10) { liczba -= 10; Console.WriteLine("X"); }
            if (liczba >= 900) { liczba -= 900; Console.WriteLine("CM"); }
            else if (liczba >= 800) { liczba -= 800; Console.WriteLine("DCCC"); }
            else if (liczba >= 700) { liczba -= 700; Console.WriteLine("DCC"); }
            else if (liczba >= 600) { liczba -= 600; Console.WriteLine("DC"); }
            else if (liczba >= 500) { liczba -= 500; Console.WriteLine("C"); }
            else if (liczba >= 400) { liczba -= 400; Console.WriteLine("CD"); }
            else if (liczba >= 300) { liczba -= 300; Console.WriteLine("CCC"); }
            else if (liczba >= 200) { liczba -= 200; Console.WriteLine("CC"); }
            else if (liczba >= 100) { liczba -= 100; Console.WriteLine("C"); }
            if (liczba >= 3000) { liczba -= 3000; Console.WriteLine("MMM"); }
            else if (liczba >= 2000) { liczba -= 2000; Console.WriteLine("MM"); }
            else if (liczba >= 1000) { liczba -= 1000; Console.WriteLine("M"); }
            switch (liczba) 
            {
                case 1:
                    Console.WriteLine("I");
                    break;      
                case 2:
                    Console.WriteLine("II");
                    break;
                case 3:
                    Console.WriteLine("III");
                    break;
                case 4:
                    Console.WriteLine("IV");
                    break;
                case 5:
                    Console.WriteLine("V");
                    break;
                case 6:
                    Console.WriteLine("VI");
                    break;
                case 7:
                    Console.WriteLine("VII");
                    break;
                case 8:
                    Console.WriteLine("VIII");
                    break;
                case 9:
                    Console.WriteLine("IX");
                    break;
            }
            Console.ReadKey(true);



        }
    }
}
