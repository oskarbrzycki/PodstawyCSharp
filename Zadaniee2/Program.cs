using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaniee2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący wartość liczby naturalnej n (n>=0), obliczający wartość 2^n (2 do
            //potęgi n) i wypisujący wynik na ekranie w formacie(np.dla n = 10) : 2 ^ 10 = 1024.Do obliczenia
            //wartości wyrażenia użyj pętli for.
            int n;
            int i; int wynik = 1;
            Console.WriteLine("Podaj liczbe n");
            n = int.Parse(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                wynik = wynik * 2;
            }
            {
                
            }
            Console.Write("2^{0} = {1}", n, wynik);
            Console.ReadKey(true);


        }
    }
}
