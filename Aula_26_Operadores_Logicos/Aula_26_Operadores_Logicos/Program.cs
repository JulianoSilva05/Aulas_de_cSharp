using System;

namespace Aula_26_Operadores_Logicos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tabela verdade
            {
                //  C1  -  C2  - C1 E C2
                //  F       F       F
                //  F       V       F
                //  V       F       F
                //  V       V       V

                //  C1  -  C2  - C1 OU C2
                //  F       F       F
                //  F       V       V
                //  V       F       V
                //  V       V       V
            }

            bool c1 = 4 != 5; //Não
            bool c2 = 2 > 3 && 4 !=5; //&& = E - para Verdadeiro, ambas condições devem ser verdadeiras.
            bool c3 = 2 > 3 || 4 != 5; // || = OU - Para verdadeiro, uma das condições deve ser verdadeira.
            bool c4 = !(2 > 3) && 4 != 5;

            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
            Console.WriteLine(c4);

            //Procedencia
            {
                /*
                    1) Precedência= ! > && > ||
                    2) Pode-se usar parêntesis à vontade
                    3)Exemplos:
                    2 > 3 || 4 != 5 → Resultado = True
                    !(2 > 3) && 4 != 5 → Resuldado = True
                */
            }
            Console.WriteLine("---------------");
            bool c5 = 10 < 5;
            bool c6 = c3 || c4 && c5;
            Console.WriteLine(c6);

        }
    }
}
