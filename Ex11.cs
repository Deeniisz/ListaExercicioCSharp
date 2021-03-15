using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListadeExercícios08_03_2021
{
    class Ex11
    {
        static void Main(string[] args)
        {
            int[] v = new int[5];
            int menor, maior, total;
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Informe a media do dia" + i+1);
                v[i] = Console.ReadLine();
                if(v[i] > maior)
                {
                    maior = v[i];
                }
                if(v[i] < menor)
                {
                    menor =  v[i];
                }
                total = total + v[i];
            }
            Console.WriteLine("A maior temperatura foi" + maior);
            Console.WriteLine("A menor temperatura foi" + menor);
            Console.WriteLine("A media entre as temperaturas foi" + total/5);
        }
    }
}
