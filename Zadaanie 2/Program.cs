using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaanie_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący ciąg n (1<=n<=1000) liczb całkowitych i wypisujący wczytane
            //liczby w odwrotnej kolejności na ekranie
            int[] tablica = new int[1000];
            int n;
            Console.WriteLine("Podaj ilość liczb: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Podaj liczbę: ");
                tablica[i] = int.Parse(Console.ReadLine());
            }
            for (int i = n - 1; i >= 0; i--)
            {
                Console.WriteLine(tablica[i]);
            }
            Console.ReadKey();

        }
    }
}
