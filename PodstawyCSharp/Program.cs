using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodstawyCSharp
{
    class Program
    {
        
        
            //Napisz funkcję o nazwie suma wyznaczającą sumę jej dwóch argumentów będących liczbami
            //całkowitymi.Napisz program wykorzystujący funkcję suma.
            static int suma(int a, int b)
            {
                return a + b;
            }
        static void Main(string[] args)
        {
            Console.WriteLine("1+2={0}", suma(1, 2));
            Console.ReadKey(true);
        }

        }
    }

