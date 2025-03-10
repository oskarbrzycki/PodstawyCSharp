using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący rok i wypisujący na ekranie informację czy jest to rok przestępny
            //czy też nie.
            int rok = int.Parse(Console.ReadLine());
            if (rok % 4 == 0 && rok % 100 != 0 || rok % 400 == 0)
            {
                Console.WriteLine("Rok przestępny");     
            }
            else
            {
                Console.WriteLine("Rok nie jest przestępny");
            }
            Console.ReadKey(true);

               
        }
    }
}
