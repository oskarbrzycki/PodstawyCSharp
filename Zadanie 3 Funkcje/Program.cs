using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3_Funkcje
{
    class Program
    {
        //Napisz funkcję o nazwie pole_kola, która posiada jeden parametr r-promień koła i zwraca
        //obliczoną wartość pola koła.Napisz program wykorzystujący funkcję pole_kola.
        static double pole_kola(double r)
        {
            return Math.PI * r * r;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Dla 2 pole koła wynosi {0}", pole_kola(2));
            Console.ReadKey(true);
        }
    }
}
