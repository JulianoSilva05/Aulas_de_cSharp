using System;

namespace Exercicio_propostos_3_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva um programa que repita a leitura de uma senha até que ela seja válida. " +
                "Para cada leitura de senha incorreta informada, escrever a mensagem " +
                " Senha Invalida.Quando a senha for informada corretamente deve ser " +
                "impressa a mensagem Acesso Permitido e o algoritmo encerrado.Considere " +
                "que a senha correta é o valor 2002");
            double senha = double.Parse(Console.ReadLine());

            while (senha != 2002)
            {
                Console.WriteLine("Senha Invalida");
                senha = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso Permitido");
        }
    }
}
