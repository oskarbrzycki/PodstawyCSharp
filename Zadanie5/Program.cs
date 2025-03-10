using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie5
{ 

    class Program
    {
        static void Main(string[] args)
        {
            // Wczytanie promienia podstawy stożka
            Console.Write("Podaj r: ");
            double r = Convert.ToDouble(Console.ReadLine());

            // Wczytanie wysokości stożka
            Console.Write("Podaj h: ");
            double h = Convert.ToDouble(Console.ReadLine());

            // Obliczenie objętości stożka
            double volume = (1.0 / 3.0) * Math.PI * Math.Pow(r, 3) * h;

            // Obliczenie tworzącej stożka
            double l = Math.Sqrt(Math.Pow(r, 2) + Math.Pow(h, 2));

            // Obliczenie pola powierzchni całkowitej stożka
            double surfaceArea = Math.PI * r * (r + l);

            // Wyświetlenie wyników
            Console.WriteLine($"Objętość stożka: {volume}");
            Console.WriteLine($"Pole całkowite stożka: {surfaceArea}");
        }
    }
}
