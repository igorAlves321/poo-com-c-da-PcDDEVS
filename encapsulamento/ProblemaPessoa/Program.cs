using System;

namespace ProblemaPessoa
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa("Igor", "23", "1.70");

            pessoa.Apresentar();
            Console.ReadKey();
        }
    }
}
