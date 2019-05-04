using System;

namespace Aluguel
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudante[] vect = new Estudante[10];

            Console.Write("Quantos quartos serão alugados?");
            int qtd = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qtd; i++)
            {
                Console.WriteLine("Aluguel #" + i + ":");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                vect[quarto] = new Estudante(nome, email);


            }

            Console.WriteLine("Quartos ocupados:");
            for (int i = 0; i < vect.Length; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(i+": "+vect[i]);
                }
            }
        }

    }
}
