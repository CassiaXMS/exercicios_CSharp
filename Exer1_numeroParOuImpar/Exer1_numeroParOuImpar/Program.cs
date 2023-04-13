using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer1_numeroParOuImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumero;
            Boolean finalizar = false;
            
            Console.WriteLine(" -- Numero par ou ímpar! --\n\n");

            while (!finalizar)
            {
                Console.Write(" Digite um numero e pressione a tecla enter: ");
                inputNumero = Convert.ToInt32(Console.ReadLine());

                if (inputNumero % 2 == 0)
                {
                    Console.WriteLine("\n O numero " + inputNumero + " é par! ");
                }
                else
                {
                    Console.WriteLine("\n O numero " + inputNumero + " é ímpar! ");
                }
                Console.Write("\n Quer continuar? aperte qualquer tecla.\n Senão aperte a tecla 'n': ");
                if (Console.ReadLine() == "n") finalizar = true;

                Console.ReadKey();
            }

        }
    }
}
