using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListadeExercícios08_03_2021
{
    class Ex7
    {
        static void Main(string[] args)
        {
            while(n1 == n2 || n1 == n3 || n2 == n3)
            {
            Console.WriteLine("--Maior Numero--");
            Console.WriteLine("*Informe Números Diferentes*");
            Console.WriteLine("Informe o Primeiro Numero:");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o Segundo Numero:");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o Terceiro Numero:");
            int n3 = int.Parse(Console.ReadLine());
            }
            int maior = n1, menor = n1;
            if(n2 > maior)
            {
                maior = n2;
            }
            if(n3 > maior)
            {
                maior = n3;
            }
            if(n2 < menor)
            {
                menor = n2;
            }
            if(n3 < menor)
            {
                menor = n3;
            }
        }
    }
}
