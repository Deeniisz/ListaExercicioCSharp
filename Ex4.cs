using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListadeExercícios08_03_2021
{
    class Ex4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio Carros");
            Console.WriteLine("Qtd Carros Vendidos:");
            int vendidos = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor total de vendas:");
            int vendas = int.Parse(Console.ReadLine());
            Console.WriteLine("Salario:");
            float salario = float.Parse(Console.ReadLine());
            Console.WriteLine("Comissão:");
            float comissao = float.Parse(Console.ReadLine());

            float n = salario + (comissao * vendidos) + (vendas / 100) * 5;

            Console.WriteLine("Salario final do vendedor é igual a: " + n);
        }
    }
}
