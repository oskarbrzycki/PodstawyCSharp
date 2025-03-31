using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zADAANIE_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący ciąg n (1<=n<=1000) liczb całkowitych i wypisujący na ekranie
            //sumę wczytanych liczb.
            int[] tablica = new int[1000];
            int n;
            int suma = 0;
            Console.WriteLine("Podaj ilość liczb: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Podaj liczbę: ");
                tablica[i] = int.Parse(Console.ReadLine());
                suma += tablica[i];
            }
            Console.WriteLine("Suma liczb wynosi: " + suma);
            Console.ReadKey();
        }
    }
}
