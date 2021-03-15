using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListadeExercícios08_03_2021
{
    class Ex12
    {
        static void Main(string[] args)
        {
            int[] v = new int[10];
            int total;
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("Informe o valor " + i+1);
                v[i] = Console.ReadLine();
                total = total + v[i];
            }          
            Console.WriteLine("A soma é:" + total);
        }
    }
}
