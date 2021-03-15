using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListadeExercícios08_03_2021
{
    class Ex5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("APP Peso ideal");
            Console.WriteLine("Nome:");
            string nome = Console.ReadLine();
            Console.WriteLine("Altura:");
            float altura = float.Parse(Console.ReadLine());
            Console.WriteLine("Sexo (M ou F):");
            string sexo = Console.ReadLine();
            double peso = 0;
            if (sexo == "m" || sexo == "M")
            {
                peso = (72.7 * altura) - 58;
            }
            else
            {
                if(sexo == "F" || sexo == "f")
                {
                    peso = (62.1 * altura) - 44.7;
                }
                else
                {
                    Console.WriteLine("***ERRO***");
                }
            }
            Console.WriteLine("O peso ideal de" + nome + "é:" + peso);


            Console.ReadKey();

        }
    }
}
