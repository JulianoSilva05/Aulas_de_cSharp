using System;

namespace Exercicio_propostos_4_For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com um numero");
            int valor = int.Parse(Console.ReadLine());

            for (int i = 1; i <= valor; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
