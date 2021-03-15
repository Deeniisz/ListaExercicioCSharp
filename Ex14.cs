using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListadeExercícios08_03_2021
{
    class Ex14
    {
        static void Main(string[] args)
        {
            int total = 0, n = 0;
            Console.WriteLine("Media entre valores entre 15 e 100")
            for (int i = 15; i = 100; i++)
            {
                total = total + i;
                n++;
            }
            Console.WriteLine("Media entre 15 e 100 é " + total + " / " + n + " = " + total / n);          
        }
    }
}