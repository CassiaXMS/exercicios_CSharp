using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer_filas
{
    class Program
    {
        static void Main(string[] args)
        {

            Queue<string> minhaFila = new Queue<string>();

            minhaFila.Enqueue("Primeiro Cliente");
            minhaFila.Enqueue("Segundo Cliente");
            minhaFila.Enqueue("Terceiro Cliente");

            foreach(string cliente in minhaFila)
            {
                Console.WriteLine(cliente);
            }

            int contador = minhaFila.Count;

            Console.WriteLine("Primeiro elemento: " + minhaFila.Peek());
            Console.WriteLine("Tamanho da fila: " + contador);
            minhaFila.Dequeue();

            Console.WriteLine("NOVO primeiro elemento: " + minhaFila.Peek());
            contador = minhaFila.Count;
            Console.WriteLine("NOVO tamanho da fila: " + contador);
            minhaFila.Clear();

            Console.WriteLine("Filha esvaziada!");

            foreach (string cliente in minhaFila)
            {
                Console.WriteLine("Elemento ecnontrado: " + cliente);
            }

            contador = minhaFila.Count;
            Console.WriteLine("Tamanho da fila após esvaziar: " + contador);
            if(contador == 0)
            {
                Console.WriteLine("Nenhum elemento encontrado na fila.");
            }
            Console.ReadLine();
        }
    }
}
