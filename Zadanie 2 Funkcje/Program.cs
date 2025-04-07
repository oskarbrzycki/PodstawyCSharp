using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2_Funkcje
{
    class Program
    {

        //Napisz funkcję o nazwie max, która wyznacza maksimum z dwóch liczb rzeczywistych
        //zadanych jako argumenty tej funkcji.Napisz program wykorzystujący funkcję max
        static double max (double x, double y)
        {
            
            if (x>y)
                return x;
            else
                return y;
        }
    static void Main(string[] args)
        {
            Console.WriteLine("Podaj dwie liczby całkowite");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Maksimum z {0} i {1} to {2}", a, b, max(a, b));
            Console.ReadKey(true);
        }


    
        
    }
}
