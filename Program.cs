using System;
using ConsoleVetores.Vetor;

namespace ConsoleVetores
{
    class Program
    {
        static void Main(string[] args)
        {
            VetorArray Vetarray = new VetorArray();
            Console.Write("Informe a quantidade de Valores:");
            int valor = int.Parse(Console.ReadLine());
            Vetarray.AdicionarQuantidadeVetor(valor);
        }
    }
}
