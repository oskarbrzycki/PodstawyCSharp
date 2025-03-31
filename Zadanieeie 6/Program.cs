using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanieeie_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zadeklaruj tablicę zawierającą nazwy dni tygodnia. Wypisz elementy tablicy za pomocą pętli
            //foreach.
            string[] tablica = new string[7] { "Poniedziałek", "Wtorek", "Środa", "Czwartek", "Piątek", "Sobota", "Niedziela" };
            foreach (string dzien in tablica)
            {
                Console.WriteLine(dzien);
            }
            Console.ReadKey();
        }
    }
}
