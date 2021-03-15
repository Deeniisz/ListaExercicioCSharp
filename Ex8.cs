using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListadeExercícios08_03_2021
{
    class Ex8
    {
        static void Main(string[] args)
        {
            while(n1 == n2 || n1 == n3 || n2 == n3)
            {
            Console.WriteLine("--APP 'é triangulo'--");
            Console.WriteLine("*Informe o valor dos lados*");
            Console.WriteLine("Informe o Primeiro lado:");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o Segundo lado:");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o Terceiro lado:");
            int n3 = int.Parse(Console.ReadLine());
            }
            
            if(n1 > n2+n3 || n2 > n1+n3 || n3 > n1+n2)
            {
                Console.WriteLine("Não é um triangulo");
            }
            else
            {
                Console.WriteLine("É um triangulo");
            }
        }
    }
}
