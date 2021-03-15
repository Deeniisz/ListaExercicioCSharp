using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListadeExercícios08_03_2021
{
    class Ex6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vendedor de Empresa X");
            Console.WriteLine("Salario:");
            float salario = float.Parse(Console.ReadLine());
            Console.WriteLine("Valor total das vendas:");
            float vendas = float.Parse(Console.ReadLine());
            double total = 0;
            if (vendas <= 1500)
            {
                total = vendas + (vendas / 100) * 3;
            }
            else
            {
                total = (1500 + (1500 / 100) * 3) + ((vendas - 1500) + (vendas - 1500) / 100 * 5);
            }

            Console.WriteLine("Salário total é:" + total);

            Console.ReadKey();

        }
    }
}
