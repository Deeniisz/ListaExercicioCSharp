using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListadeExercícios08_03_2021
{
    class Ex1
    {
        static void Main(string[] args)
        {
            int a, m, d, idade;
            Console.WriteLine("Informe a idade:");
            Console.WriteLine("Anos:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Meses:");
            m = int.Parse(Console.ReadLine());
            Console.WriteLine("Dias:");
            d = int.Parse(Console.ReadLine());

            idade = a * 365 + m * 30 + d;

            Console.WriteLine("Idade em dias é igual a:" + idade);


            Console.ReadKey();

        }
    }
}
