using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_5_Funkcje
{
    internal class Program
    
        {
            //Napisz funkcję, która sprawdza czy jej argument jest liczbą pierwszą. Jako wartość funkcja
            //powinna zwracać 1 dla liczb pierwszych i 0 dla pozostałych liczb.Przetestuj działanie
            //utworzonej funkcji.
            static int czy_pierwsza(int liczba)
            {
                if (liczba < 2) return 0; // liczby mniejsze niż 2 nie są pierwsze
                for (int i = 2; i <= Math.Sqrt(liczba); i++)
                {
                    if (liczba % i == 0) return 0; // jeśli liczba jest podzielna przez i, to nie jest pierwsza
                }
                return 1; // liczba jest pierwsza
            }
        static void Main(string[] args)
            {
            // testujemy naszą funkcję
            Console.WriteLine("Czy 2 jest liczbą pierwszą? {0}", czy_pierwsza(2)); // powinno zwrócić 1
            Console.WriteLine("Czy 4 jest liczbą pierwszą? {0}", czy_pierwsza(4)); // powinno zwrócić 0
            Console.WriteLine("Czy 7 jest liczbą pierwszą? {0}", czy_pierwsza(7)); // powinno zwrócić 1
            Console.WriteLine("Czy 9 jest liczbą pierwszą? {0}", czy_pierwsza(9)); // powinno zwrócić 0
            Console.ReadKey(true); // pauza
        }
    }
}
