using System;

namespace Aula_22_Entrada_de_dados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Notas:
            {
                /*
                 Para entrada de dados usamos:
                    Console.ReadLine();
                    ◙ Lê da entrada padão etá a quebra de linha
                    ◙ Retorna os dados lidos na forma de String.
                 */
            }
            string frase = Console.ReadLine(); //Entrada de dados
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

           
            string[] v = Console.ReadLine().Split('-');
            string a = v[0];
            string b = v[1];
            string c = v[2];


            Console.WriteLine("Você digitou: ");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

        }
    }
}
