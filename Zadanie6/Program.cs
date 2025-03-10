using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący dwie liczby i wypisujący na ekranie ich sumę, różnicę, iloczyn i
            //iloraz.
            double a, b, suma, roznica, iloczyn, iloraz;
            Console.WriteLine("Podaj A");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj B");
            b = Convert.ToDouble(Console.ReadLine());
            suma = a + b;
            roznica = a - b;
            iloczyn = a * b;
            iloraz = a / b;
            Console.WriteLine("Suma = {0}", suma);
            Console.WriteLine("Różnica = {0}", roznica);
            Console.WriteLine("Iloczyn = {0}", iloczyn);
            Console.WriteLine("Iloraz = {0}", iloraz);
            Console.ReadKey(true);
        }
    }
}
