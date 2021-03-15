using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListadeExercícios08_03_2021
{
    class Ex2
    {
        static void Main(string[] args)
        {
            float e, b, n, v;
            Console.WriteLine("Exercício Eleitores");
            Console.WriteLine("Qtd Eleitores:");
            e = float.Parse(Console.ReadLine());
            Console.WriteLine("Votos Brancos:");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("Votos Nulos:");
            n = float.Parse(Console.ReadLine());

            v = ((e - b - n)/100 * e);

            b = (b/100 * e);

            n = (n/100 * e);

            Console.WriteLine("% Validos:" + v);
            Console.WriteLine("% Brancos:" + b);
            Console.WriteLine("% Nulos:" + n);

            Console.ReadKey();

        }
    }
}
