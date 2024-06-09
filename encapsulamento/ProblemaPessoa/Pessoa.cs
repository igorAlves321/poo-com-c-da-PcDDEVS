using System;

namespace ProblemaPessoa
{
    public class Pessoa
    {

        public string Nome { get; set; }
        public string Idade { get; set; }
        public string Altura { get; set; }


        public Pessoa(string nome, string idade, string altura)
        {
            Nome = nome;
            Idade = idade;
            Altura = altura;
        }

        
        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}.");
            Console.WriteLine($"Minha idade é {Idade}.");
            Console.WriteLine($"Minha altura é: {Altura}.");
        }
    }
}
