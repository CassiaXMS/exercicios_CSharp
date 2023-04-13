using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex8_gravarDadosDoUser
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();

            String inputNome = "";
            String inputEmail = "";
            int inputTelefone;
            int inputRg;
            String nomeDoArquivo = "dadosDoUser.txt";
            String leituraDaOperacao = "";

            Console.WriteLine("\nInforme a opção desejada: ");
            Console.WriteLine("\n C - CADASTRAR DADOS");
            Console.WriteLine(" L - LER DADOS");
            Console.WriteLine(" S - SAIR");
            Console.Write(" Digite o caracter da operação: ");
            leituraDaOperacao = Console.ReadLine().ToUpper();
  
            while (leituraDaOperacao != "S")
            {
                if (leituraDaOperacao == "C")
                {
                    Console.Write("\n Digite o nome: ");
                    inputNome = Console.ReadLine();
                    Console.Write(" Digite o e-mail: ");
                    inputEmail = Console.ReadLine();
                    Console.Write(" Digite o telefone: ");
                    int.TryParse(Console.ReadLine(), out inputTelefone);
                    Console.Write(" Digite o RG: ");
                    int.TryParse(Console.ReadLine(), out inputRg);
                    Console.WriteLine("\n Dados cadastrados! \n");

                    StreamWriter streamWriter = new StreamWriter(nomeDoArquivo, true);

                    streamWriter.WriteLine("\nNome: " + inputNome);
                    streamWriter.WriteLine("E-mail: " + inputEmail);
                    streamWriter.WriteLine("Telefone: " + inputTelefone);
                    streamWriter.WriteLine("RG: " + inputRg);
                    streamWriter.WriteLine();

                    streamWriter.Close();
                }
                else if (leituraDaOperacao == "L")
                {
                    StreamReader streamReader = new StreamReader(nomeDoArquivo);

                    while (streamReader.EndOfStream != true)
                    {
                        Console.WriteLine(streamReader.ReadLine());
                    }
                    streamReader.Close();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n Operação inválida, digite uma das opções abaixo!");
                    Console.ResetColor();
                }
                
                Console.WriteLine("\nInforme a opção desejada: ");
                Console.WriteLine("\n C - CADASTRAR DADOS");
                Console.WriteLine(" L - LER DADOS");
                Console.WriteLine(" S - SAIR");
                Console.Write(" Digite o caracter da operação: ");
                leituraDaOperacao = Console.ReadLine().ToUpper();
            }
            Console.ReadKey();

        }
           
    }
}
