using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 01/03/2023
// EXERCÍCIO 1: Desenvolva um algoritmo que permita a entrada do nome do usuário e exiba na tela.

namespace nomeDoUserExercicio2
{
    class Program
    {
        static void Main(string[] args)
        {

            String nomeDigitado;

            Console.Write("\n Digite seu nome e pressione a tecla enter: ");
            nomeDigitado = Console.ReadLine();

            Console.WriteLine("\n\n Seu nome: " + nomeDigitado);
            
            Console.ReadKey();

        }
    }
}
