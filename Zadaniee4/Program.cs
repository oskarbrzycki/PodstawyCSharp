using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaniee4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Wczytaj dwie liczby naturalne dodatnie n i k. Narysuj z gwiazdek na ekranie prostokąt
            //posiadający n wierszy i k kolumn. Użyj pętli for.
            int n, k;
            Console.WriteLine("Podaj liczbe n");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbe k");
            k = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey(true);
        }
    }
}
