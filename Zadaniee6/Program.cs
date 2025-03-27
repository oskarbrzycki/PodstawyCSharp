using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Zadaniee6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Wczytaj liczbę naturalną n (n>1). Narysuj na ekranie z gwiazdek trójkąt równoramienny, który
            //nie jest trójkątem prostokątnym. Użyj pętli for. Przykładowo dla n = 3 narysowany trójkąt
            //powinien wyglądać:
            //*
            //***
            //*****
            int n;
            Console.WriteLine("Podaj liczbe n");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i * 2; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey(true);

        }
    }
}
