using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6_trocaDeLetrasNaFrase
{
    class Program
    {
        static void Main(string[] args)
        {
            String inputDaFrase = "";
    
            Console.WriteLine("\n Digite uma frase contendo o caracter 'a' (minúsculo): ");
            inputDaFrase = Console.ReadLine();

            Program program = new Program();
            Console.Write(program.AlterarLetraNaFrase(inputDaFrase));

            Console.ReadKey();
        }

        private String AlterarLetraNaFrase(String fraseDigitada)
        {
            if(fraseDigitada.Trim().Length > 0)
            {
                int totalDeCaracteresNaFrase = fraseDigitada.Length;
                int contadora = 0;

                var StringBuilder = new StringBuilder(fraseDigitada.ToUpper());

                while(contadora < totalDeCaracteresNaFrase)
                {
                    if(StringBuilder[contadora] == 'A')
                    {
                        StringBuilder[contadora] = '&';
                    }
                    contadora++;
                }

                fraseDigitada = StringBuilder.ToString();
                return fraseDigitada.ToLower();

            }
            else
            {
                Console.WriteLine("A frase não foi reconhecida!");
                return null;
              
            }   
        }
    }
}
