using System;

namespace ex07GerenciamentoDeFuncionarios
{
    public class Funcionario
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public double Salario { get; set; }

        public Funcionario(string id, string nome, string cargo, double salario)
        {
            Id = id;
            Nome = nome;
            Cargo = cargo;
            Salario = salario;
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"Identificador: {Id}");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Cargo: {Cargo}");
            Console.WriteLine($"Salário: {Salario:C}");
        }

        public void AtualizarSalario(double novoSalario)
        {
            Salario = novoSalario;
            Console.WriteLine($"Seu salário atual é de: {Salario:C}");
        }

        public double CalcularBonus()
        {
            return Salario * 0.10;
        }

        public string Promover(double novoSalario, string novoCargo)
        {
            Salario = novoSalario;
            Cargo = novoCargo;
            Console.WriteLine($"Você foi promovido para {Cargo}. Seu novo salário é de {Salario:C}");
            return Cargo;
        }
    }
}