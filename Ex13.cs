using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListadeExercícios08_03_2021
{
    class Ex13
    {
        static void Main(string[] args)
        {
            int n;
            while(n <= 0)
            {
                Console.WriteLine("Informe o valor N");
                n = Console.ReadLine();
            }
            Console.WriteLine("Lista dos numeros entre 0 e " + n);
            for (i = 0; i = n; i++)
            {
                Console.WriteLine(i+1);
            }          
        }
    }
}