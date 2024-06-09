using System;

namespace ex07GerenciamentoDeFuncionarios
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o ID do funcionário: ");
            string id = Console.ReadLine();

            Console.Write("Digite o nome do funcionário: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o cargo do funcionário: ");
            string cargo = Console.ReadLine();

            Console.Write("Digite o salário do funcionário: ");
            double salario = double.Parse(Console.ReadLine());

            Funcionario funcionario = new Funcionario(id, nome, cargo, salario);

            funcionario.ExibirDetalhes();

            Console.Write("Digite o novo salário do funcionário: ");
            double novoSalario = double.Parse(Console.ReadLine());
            funcionario.AtualizarSalario(novoSalario);

            double bonus = funcionario.CalcularBonus();
            Console.WriteLine($"Seu bônus é de: {bonus:C}");

            Console.Write("Digite o novo cargo do funcionário: ");
            string novoCargo = Console.ReadLine();
            Console.Write("Digite o novo salário para o cargo: ");
            double salarioPromocao = double.Parse(Console.ReadLine());

            funcionario.Promover(salarioPromocao, novoCargo);
            funcionario.ExibirDetalhes();
        }
    }
}