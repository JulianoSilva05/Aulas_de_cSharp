using System;

namespace Aula_30_Funcoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 3 numeros para saber o maior");
            
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            //Debugging - Encontrar e remover erros
            //Atalhos:
            //F9 - marca o inicio do Debugging
            //F5 - inicia/continua o Debugging
            //F10 - executa um passo a passo (pula função)
            //F11 - Executa passo a passo - entra na função
            //Shift+F11 - sai do método em execução
            //Shift+F5 - Para o Debugging

            //Sem função//
            /*
                if (n1 > n2 && n1 > n3)
                {
                    Console.WriteLine("Maior = " + n1);
                }
                else if (n2 > n3)
                {
                    Console.WriteLine("Maior = " + n2);
                }
                else
                {
                    Console.WriteLine("Maior = " + n3);
                }
            */

            double resultado = Maior(n1, n2, n3); //aqui será usado o valor do "return m".
            Console.WriteLine("Maior = " + resultado);
        }

        static int Maior (int a, int b , int c)
        {
            int m; //Criar uma variavel para receber o maior valor
            if (a > b && a > c)
            {
                m = a;
            }
            else if (b > c)
            {
                m = b;
            }
            else
            {
                m = c;
            }
            return m; //Valor do M será armazenado para ser usado na chamada da função. 
        }
    }
}
