using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaDecisaoSE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Para utilizar os testes logicos precisamos dos:
            Operadores relacionais:
                Maior                   >
                Menor                   <
                Maior ou igual          >=
                Menor ou igual          <=
                NAO igual (diferente)   !=   

            Operadores Logicos
                "E"                     &&
                "OU"                    ||
            */

            int idade;
            Console.Write("informe sua idade:");
            idade = int.Parse(Console.ReadLine());

            if (idade >= 18) //Não se coloca ; na frente do if pois o ; encerra comando.
            {
                Console.WriteLine("Maior de idade");
            }
            else //Não tem teste logico.
            {
                Console.WriteLine("Menor de idade.");
            }
            Console.ReadKey();
        }
    }
}
