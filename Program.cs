using System;

namespace L04E09
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[6];
            int somaPar, somaImpar;

            somaPar = 0;
            somaImpar = 0;

            //Preencher o vetor vazio
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine($"Digite número inteiro {i + 1}/6");
                vetor[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            //Dois 'foreach' usados para Apresentação do console ficar agrupado. 
            //Poderia ter usado apenas um, mas ficaria desordenado.
            Console.WriteLine("Números Pares:");
            foreach (int item in vetor)
            {//Se item do vetor for Par: Mostrar na tela o numero par e adicionar na variavel somaPar.
                if (item % 2 == 0)
                {
                    Console.Write(item + " ");
                    somaPar += item;
                }
            }
            //Mostrar somaPar
            Console.WriteLine("");
            Console.WriteLine($"Soma dos Pares = {somaPar}");

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Números ímpares:");
            foreach (int item in vetor)
            {//Se item do vetor for Impar: Mostrar na tela o numero impar e adicionar na variavel somaImpar.
                if (item % 2 != 0)
                {
                    Console.Write(item + " ");
                    somaImpar += item;
                }
            }
            //Mostrar somaImpar
            Console.WriteLine("");
            Console.WriteLine($"Soma dos ímpares = {somaImpar}");
        }
    }
}
