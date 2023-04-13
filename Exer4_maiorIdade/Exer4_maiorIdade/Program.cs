using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer4_maiorIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputIdade;

            Console.Write("\n Digite sua idade: ");
            inputIdade = Convert.ToInt32(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Green;
            

            if (inputIdade < 18)
            {
                Console.WriteLine(" Sem permissão! ", ConsoleColor.Red);
            }
            else
            {
                
                Console.WriteLine(" Permissão Concedida! ", ConsoleColor.Green);
            }

            Console.ReadKey();
        }
    }
}
