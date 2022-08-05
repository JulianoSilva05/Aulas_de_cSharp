using System;
using System.Globalization;

namespace Exercicio_propostos_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 01
            {
                //Console.WriteLine("Faça um programa para ler dois valores inteiros, e " +
                //    "depois mostrar na tela a soma desses números com uma" +
                //    "mensagem explicativa, conforme exemplos.");

                //int a = 10, b = 30, soma = 0;
                //Console.WriteLine("A soma de {0} + {1} = {2}",a, b, soma=a+b);

                //int a = -30, b = 10, soma = a + b;
                //Console.WriteLine("Soma = {0}", soma);

                //int a = 0, b = 0, soma = a + b;
                //Console.WriteLine("SOMA = " + soma);
            }

            //Exercicio 02
            {
                //Console.WriteLine("Faça um programa para ler o valor do raio de um círculo, e" +
                // " depois mostrar o valor da área deste círculo com quatro"+
                // "casas decimais conforme exemplos."+
                // "\nFórmula da área: area = π.raio2 \nConsidere o valor de π = 3.14159");

                //double r = 2;
                //double r = 100.64;
                //double r = 150.00;
                //double pi = 3.14159;
                //double a = 0;

                //a = pi * (r * r);

                //Console.WriteLine("Com Raio=2: \nArea = "+ a.ToString("F4", CultureInfo.InvariantCulture));

            }

            //Exercicio 03
            {
                /*
                    Console.WriteLine("Fazer um programa para ler quatro valores inteiros A, B, C e D. " +
                        "A seguir, calcule e mostre a diferença do produto"+
                        "de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).");

                    int a, b, c, d, dif;

                    a = int.Parse(Console.ReadLine());
                    b = int.Parse(Console.ReadLine());
                    c = int.Parse(Console.ReadLine());
                    d = int.Parse(Console.ReadLine());
                    dif = a * b - c * d;

                    Console.WriteLine("DIFERENÇA = {0}", dif);
                
                */
            }

            //Exercicio 04
            {
                /*
                  Console.WriteLine("Fazer um programa que leia o número de um funcionário, " +
                      "seu número de horas trabalhadas, o valor que recebe por " +
                      "hora e calcula o salário desse funcionário.A seguir, mostre " +
                      "o número e o salário do funcionário, com duas casas decimais.");

                  Console.WriteLine("Entre com o numero do funcionario: ");
                  int num = int.Parse(Console.ReadLine());
                  Console.WriteLine("Horas trabalhadas: ");
                  double h = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                  Console.WriteLine("Qual o valor da Hora/Trabalho?: ");
                  double val = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                  double sal= h*val;

                  Console.WriteLine("Matricula {0} = Salario = {1}",num, sal.ToString("F2",CultureInfo.InvariantCulture));
                */

            }

            //Exercicio 05
            {
                Console.WriteLine("Fazer um programa para ler o código de uma peça 1, o " +
                    "número de peças 1, o valor unitário de cada peça 1, o" +
                    "código de uma peça 2, o número de peças 2 e o valor unitário " +
                    "de cada peça 2.Calcule e mostre o valor a ser pago.");

                Console.WriteLine("Digite o Cod da peça 1, a quantidade e o valor!");
                string[] vet1 = Console.ReadLine().Split(" ");
                int codigo = int.Parse(vet1[0]);
                int numeroPecas = int.Parse(vet1[1]);
                double valorPeca = double.Parse(vet1[2], CultureInfo.InvariantCulture);
                double valorTotal = valorPeca * numeroPecas;

                Console.WriteLine("Digite o Cod da peça 2, a quantidade e o valor!");
                string[] vet2 = Console.ReadLine().Split(" ");
                int codigo2 = int.Parse(vet2[0]);
                int numeroPecas2 = int.Parse(vet2[1]);
                double valorPeca2 = double.Parse(vet2[2], CultureInfo.InvariantCulture);

                double valorTotal2 = valorPeca2 * numeroPecas2;

                double totalizador = valorTotal + valorTotal2;

                Console.WriteLine("VALOR A PAGAR: R$ " + totalizador.ToString("F2", CultureInfo.InvariantCulture));
                
            }

        }
    }
}
