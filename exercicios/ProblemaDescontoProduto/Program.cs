using System;

namespace ProblemaDescontoProduto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o nome do produto: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o preço do produto: ");
            double preco = double.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade do produto: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto produto = new Produto(nome, preco, quantidade);

            produto.CalcularDesconto();
            Console.WriteLine($"O valor total do pedido do produto {produto.Nome} é: {produto.ValorTotal}");
            Console.ReadKey();
        }
    }
}
