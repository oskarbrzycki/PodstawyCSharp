using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodstawyCSharp
{
    class Program
    //Napisz funkcję, która oblicza wartość silni z zadanej przez argument wywołania funkcji
//wartości liczby naturalnej.Utwórz wersję rekurencyjną tej funkcji.
//Napisz program testowy wykorzystujący napisaną funkcję
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę naturalną:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Silnia z {n} wynosi {Silnia(n)}");
        }
        static int Silnia(int n)
        {
            if (n == 0 || n == 1)
                return 1;
            return n * Silnia(n - 1);
        }
    }
}