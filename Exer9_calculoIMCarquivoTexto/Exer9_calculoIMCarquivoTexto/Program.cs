using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer9_calculoIMCarquivoTexto
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();

            double inputPeso;
            double inputAltura;
            double calculoIMC;
            int inputIdade;
            String inputNome = "";
            String nomeDoArquivo = "dadosDoIMC.txt";
            String inputDaOperacao = "";
            String situacaoPeso = "";

            Console.WriteLine("\nInforme a opção desejada: ");
            Console.WriteLine("\n N - CADASTRAR NOVOS DADOS");
            Console.WriteLine(" C - CONSULTAR OS DADOS EXISTENTES");
            Console.WriteLine(" S - SAIR");
            Console.Write(" Digite o caracter da operação: ");
            inputDaOperacao = Console.ReadLine().ToUpper();

            while(inputDaOperacao != "S")
            {
                if(inputDaOperacao == "N")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n -- Cadastro");
                    Console.ResetColor();

                    Console.Write("\n Digite o nome: ");
                    inputNome = Console.ReadLine();

                    Console.Write(" Digite sua idade: ");
                    int.TryParse(Console.ReadLine(), out inputIdade);

                    Console.Write(" Digite sua altura(m) utilize vírgula: ");
                    double.TryParse(Console.ReadLine(), out inputAltura);

                    Console.Write(" Digite seu peso(kg) utilize vírgula: ");
                    double.TryParse(Console.ReadLine(), out inputPeso);

                    calculoIMC = Math.Round((inputPeso / (inputAltura * inputAltura)));
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n Dados cadastrados! \n");
                    Console.ResetColor();

                    if (calculoIMC < 18.5)
                        situacaoPeso = "\n Abaixo do peso normal.";
                    else if(calculoIMC > 18.5 && calculoIMC < 25)
                        situacaoPeso = " Peso normal.";
                    else if (calculoIMC > 25 && calculoIMC < 30)
                        situacaoPeso = " Excesso de peso.";
                    else if (calculoIMC > 30 && calculoIMC < 35)
                        situacaoPeso = " Grau de obesida I";
                    else if (calculoIMC > 35 && calculoIMC < 40)
                        situacaoPeso = " Grau de obesidade II (severa)";
                    else if (calculoIMC > 40)
                        situacaoPeso = " Grau de obesidade III (mórbida)";

                    StreamWriter streamWriter = new StreamWriter(nomeDoArquivo, true);

                    streamWriter.WriteLine("\nNome: " + inputNome);
                    streamWriter.WriteLine("Idade: " + inputIdade);
                    streamWriter.WriteLine("Altura: " + inputAltura);
                    streamWriter.WriteLine("Peso: " + inputPeso);
                    streamWriter.WriteLine("Resultado(IMC) = " + calculoIMC + "\nSituação: "  + situacaoPeso);
                    streamWriter.WriteLine("\n --------------\n");
                    streamWriter.Close();


                }
                else if(inputDaOperacao == "C")
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
                Console.WriteLine("\n N - CADASTRAR NOVOS DADOS");
                Console.WriteLine(" C - CONSULTAR DADOS");
                Console.WriteLine(" S - SAIR");
                Console.Write(" Digite o caracter da operação: ");
                inputDaOperacao = Console.ReadLine().ToUpper();
            }
            Console.ReadKey();
        }
    }
}
