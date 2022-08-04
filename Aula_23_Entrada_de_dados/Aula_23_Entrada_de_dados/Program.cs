using System;
using System.Globalization;

namespace Aula_23_Entrada_de_dados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Notas
            {
                /*
                int n1 = int.Parse(Console.ReadLine());
                //Console.ReadLine lê os dados na forma de string. POr isso usamos o "int.Parse"
                char ch = char.Parse(Console.ReadLine());
                double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); //Precisa da biblioteca System.Globalization

                string[] vet = Console.ReadLine().Split(' '); //Split - pega todo o texto digitado,
                //separa por pedaços o texto e guarda no vetor.
                string nome = vet[0];
                char sexo = char.Parse(vet[1]);
                int idade = int.Parse(vet[2]);
                double altura = double.Parse(vet[3], CultureInfo.InvariantCulture); //Precisa da biblioteca System.Globalization


                Console.WriteLine("Você digitou: ");
                Console.WriteLine(n1);
                Console.WriteLine(ch);
                Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));//Precisa da biblioteca System.Globalization

                Console.WriteLine(nome);
                Console.WriteLine(sexo);
                Console.WriteLine(idade);
                Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
                */
            }
            //Execicio
            {
                
                Console.WriteLine("Entre com seu nome completo: ");
                string nome = Console.ReadLine();

                Console.WriteLine("Quantos quantos tem sua casa? ");
                int quartos = int.Parse(Console.ReadLine());

                Console.WriteLine("Entre com o preço do produto: ");
                double preco = double.Parse(Console.ReadLine(),(CultureInfo.InvariantCulture));

                Console.WriteLine("Entre com sua último nome, idade e altura (mesma linha)");
                string[] vet = Console.ReadLine().Split(' ');
                string sobre_nome = vet[0];
                int idade = int.Parse(vet[1]);
                double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);//Parse - usado para converter para string
                Console.WriteLine("{0} {1} {2}",sobre_nome, idade, altura.ToString("F2", CultureInfo.InvariantCulture));

            }

        }
        
    }
}
