using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5_nome_porParametro
{
    class Program
    {
        static void Main(string[] args)
        {
            String inputNome;

            Console.Write("\n Nome: ");
            inputNome = Console.ReadLine();
            retornarNome(inputNome);

            Console.ReadKey();

        }

        private static void retornarNome(String nome)
        {
    
            Console.WriteLine(" Olá meu nome é: " + nome);
           
        }

    }

    
}
