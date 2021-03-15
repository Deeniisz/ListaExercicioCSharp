using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListadeExercícios08_03_2021
{
    class Ex9
    {
        static void Main(string[] args)
        {
            int n = 0, maior = 0, total = 0;

            for(int i = 0; i < 15; i++)
            {
                Console.WriteLine("Informe o valor do valor nº" + (n+1));
                n = Console.ReadLine();
                total = total + n;
                if(n > maior)
                {
                    maior = n;
                }
                
            }
            Console.WriteLine("O Maior valor é:" + maior);
            Console.WriteLine("A media entre os 15 numeros é igual a:" + total/15);
            Console.ReadKey();
        }
    }
}
