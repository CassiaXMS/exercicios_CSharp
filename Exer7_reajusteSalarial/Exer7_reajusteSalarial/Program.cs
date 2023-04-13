using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer7_reajusteSalarial
{
    class Program
    {
        static void Main(string[] args)
        {
            Double salarioAtual;
            Double salarioBase = 1700.00;
            
            Console.Write("\n Digite o seu salario (sem virgula/ponto) e pressione enter: ");
            salarioAtual = Convert.ToDouble(Console.ReadLine());

            if( salarioAtual < salarioBase)
            {
                salarioAtual = (salarioAtual + 300);
                Console.WriteLine("\n O novo salario foi ajustado para: " + (salarioAtual.ToString("C")));
            }
            else if(salarioAtual > salarioBase){
                salarioAtual = (salarioAtual + 200);
                Console.WriteLine("\n O novo salario foi ajustado para: " + (salarioAtual.ToString("C")));
            }
            else
            {
                Console.WriteLine("\n O salario não teve ajuste!");
            }

            Console.ReadKey();

        }
    }
}
