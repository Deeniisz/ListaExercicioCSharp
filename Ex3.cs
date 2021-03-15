using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListadeExercícios08_03_2021
{
    class Ex3
    {
        static void Main(string[] args)
        {
            float valor, distribuidor, imposto;
            Console.WriteLine("Informe o Valor de fábrica:");
            valor = float.Parse(Console.ReadLine());
            distribuidor = valor * 45 / 100;
            imposto = valor * 28 / 100;
            valor = valor + distribuidor + imposto;

            Console.WriteLine("Valor Total:" + valor, " Imposto:" + imposto, " Percentual do distribuidor:" + imposto);
            Console.ReadKey();

        }
    }
}
