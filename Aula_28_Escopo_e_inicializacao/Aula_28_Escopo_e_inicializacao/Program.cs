using System;

namespace Aula_28_Escopo_e_inicializacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double preco = double.Parse(Console.ReadLine()); //Variavel preco pertence ao escopo principal
            double desconto = 0;//Correção

            if (preco > 100)
            {
                //double desconto = preco * 0,1; //anterior, errado, declarando direto no escopo do if
                desconto = preco * 0.1;
            }
            Console.WriteLine(desconto);//Erro - A variavel desconto pertence ao escopo menor, e está sendo 
            //requisistada em um escopo maior!
            //Do escopo maior para o menor é possivel, do menor para o maior não é possivel!
        }

    }
}
