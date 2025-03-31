using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaanie_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący ciąg n (1<=n<=1000) liczb całkowitych, sortujący je niemalejąco i
            //wypisujący posortowane liczby na ekranie.
            int[] tablica = new int[1000];
            int n;
            Console.WriteLine("Podaj ilość liczb: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Podaj liczbę: ");
                tablica[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(tablica);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(tablica[i]);
            }
            Console.ReadKey();
        }
    }
}
