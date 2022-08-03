using System;

namespace Operadores_Aritimeticos_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Notas - Operadores Aritméticos
            { /*
             Notas:
                1) * / % tem procedência maior que + -
                2) Exemplos:
                    3+4*2 → Resultado = 11
                    (3+4)*2 → Resultado = 14
                3) Pode-se usar parêntesis à vontade
                4) Exemplo com mod:
                    17%3 → Resultado = 2
                        17/3=5 sobra 2
            */
            }

            int n1 = 3 + 4 * 2;
            int n2 = (3 + 4) * 2;
            int n3 = 17 % 3;
            double n4 = 10 / 8; //neste caso, o 10 está como inteiro, o resulto será = 1
            //Precisa fazer o casting. 
            n4 = (double)10 / 8; //ou colocar o 10.0
            n4 = 10.0 / 8;//pelo menos um dos elementos devem estar com o (.) Ponto

            double a = 1.0, b = -3.0, c = -4.0;
            //double delta = b * b - 4.0 * a * c; // ou posso usar Math.Pow(b, 2.0)
            double delta = Math.Pow(b, 2.0) - 4.0 * a * c; //delta = b²-4ac

            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine("Delta: " _ delta);
            Console.WriteLine("Raiz positiva da equação "+x1);
            Console.WriteLine("Raiz negativa da equação: "+x2);



        }
    }
}