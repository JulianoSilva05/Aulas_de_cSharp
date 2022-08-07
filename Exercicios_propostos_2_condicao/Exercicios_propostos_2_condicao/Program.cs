using System;
using System.Globalization;
namespace Exercicios_propostos_2_condicao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Autor: Juliano Silva");
            /*
             //Exercicio 1
                Console.WriteLine("Digite um numero para saber se é positivo ou negativo");
                double num = double.Parse(Console.ReadLine());

                if (num < 0)
                {
                    Console.WriteLine("O numero {0} é Negativo",num);
                }

                else
                {
                    Console.WriteLine("O numero {0} é Positivo", num);
                }
            */

            //Exercicio 2
            //Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar.
            /*
                Console.WriteLine("Digite um numero e falarei se é par ou impar");
                double num = double.Parse(Console.ReadLine());

                if (num % 2 == 0)
                {
                    Console.WriteLine("PAR");
                }
                else
                {
                    Console.WriteLine("IMPAR");
                }
            */

            //Exercicio 3
            /*
                Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem 
                "Sao Multiplos" ou "Nao sao Multiplos", indicando se os valores lidos são 
                múltiplos entre si. Atenção: os números devem poder ser digitados em ordem 
                crescente ou decrescente.
             
                Console.WriteLine("Entre com dois valores para saber se são multiplos");
                string[] vetor = Console.ReadLine().Split(' ');
                int num1 = int.Parse(vetor[0]);
                int num2 = int.Parse(vetor[1]);

                if (num1 % num2 == 0 || num2 % num1 == 0)
                {
                    Console.WriteLine("Os numeros são multiplos");                
                }
                else
                {
                    Console.WriteLine("Não são multiplos");
                }
            */

            //Exercicio 4
            //Leia a hora inicial e a hora final de um jogo. A seguir calcule a
            //duração do jogo, sabendo que o mesmo pode começar em um dia e
            //terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.

            /*
                string[] valores = Console.ReadLine().Split(' ');
                int horaInicial = int.Parse(valores[0]);
                int horaFinal = int.Parse(valores[1]);

                int duracao;
                if (horaInicial < horaFinal)
                {
                    duracao = horaFinal - horaInicial;
                }
                else
                {
                    duracao = 24 - horaInicial + horaFinal;
                }

                Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
            */

            //Exercicio 5
            /*
                Console.WriteLine("Com base na tabela abaixo, escreva um programa que leia o código de " +
                    "um item e a quantidade deste item. A seguir, calcule e mostre o valor da conta a pagar.");

                Console.WriteLine("1 - Cachorro Quente - R$4,00\n2 - X-salada -R$4,50\n3 - X-Bacon - R$5,00\n4 - Torrada Simples - R$2,00\n" +
                    "5 - Refrigerante - R$1,50\n");
                Console.WriteLine("Digite o codigo do produto, seguindo da quantidade");
                string[] vetor = Console.ReadLine().Split(' ');
                int cod  = int.Parse(vetor[0]);
                int quantidade = int.Parse(vetor[1]);

                double preco;

                if (cod == 1)
                {
                    preco = quantidade * 4;
                }
                else if (cod == 2)
                {
                    preco = quantidade * 4.5;
                
                }
                else if (cod == 3)
                {
                    preco = quantidade * 5;
               
                }
                else if (cod == 4)
                {
                    preco = quantidade * 2;
                
                }
                else
                {
                    preco = quantidade * 1.5;
                
                }
                Console.WriteLine("Total = R$"+ preco.ToString("F2", CultureInfo.InvariantCulture));
            */

            //Exercicio 6
            /*
                Console.WriteLine("Você deve fazer um programa que leia um valor qualquer e apresente " +
                    "uma mensagem dizendo em qual dos seguintes intervalos" +
                    "([0,25], (25, 50], (50, 75], (75, 100]) " +
                    "este valor se encontra. Obviamente se o valor não estiver em nenhum " +
                    "destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”.");
                double num = 0;
                Console.WriteLine("Digite um valor: ");
                num = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            */
            //Jeito errado
            /*
                if (num > 0 && num <= 25){
                    Console.WriteLine("Intervalo [0,25]");
                }
                else if (num > 25 && num <= 50){
                    Console.WriteLine("Intervalo (25,50]");
                }
                else if (num > 50 && num <= 75){
                    Console.WriteLine("Intervalo (50, 75]");
                }
                else if (num > 75 && num <= 100){
                    Console.WriteLine("intervalo (75,100]");
                }
                else{
                    Console.WriteLine("Fora de intervalo");
                }
           */

            //Jeito Certo

            /*      if (num < 0.0 || num > 100.0){
                        Console.WriteLine("Fora de intervalo");
                    }
                    else if (num <= 25.0){
                        Console.WriteLine("Intervalo [0,25]");
                    }
                    else if (num <= 50.0){
                        Console.WriteLine("Intervalo (25,50]");
                    }
                    else if (num <= 75.0){
                        Console.WriteLine("Intervalo (50,75]");
                    }
                    else{
                        Console.WriteLine("Intervalo (75,100]");
                    }
            */

            //Exercicio 07

            Console.WriteLine("Leia 2 valores com uma casa decimal (x e y), que devem representar " +
                "as coordenadas de um ponto em um plano.A seguir, determine qual o quadrante ao " +
                "qual pertence o ponto, ou se está sobre um dos eixos cartesianos ou na " +
                "origem(x = y = 0)." +
                "Se o ponto estiver na origem, escreva a mensagem “Origem”." +
                "Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, " +
                "conforme for a situação.");
            
            String[] vetor = Console.ReadLine().Split(' ');
            double x = double.Parse(vetor[0]);
            double y = double.Parse(vetor[1]);

            if (x == 0 && y == 0)
            {
                Console.WriteLine("Origem");
            }
            else if (x > 0 && y > 0)
            {
                Console.WriteLine("Q1");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Q2");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Q3");
            }
            else if(x > 0 && y < 0)
            {
                Console.WriteLine("Q4");
            }
            else if(x == 0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (y == 0)
            {
                Console.WriteLine("Eixo Y");
            }
            else
            {
                Console.WriteLine("Valor invalido");
            }
        }
    }
}
