using System;

namespace Ex06GerenciamentoDeProdutos
{
    public class Produto
    {
        public string CodigoProduto { get; set; }
        public string NomeProduto { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }

        public Produto(string codigoProduto, string nomeProduto, double preco, int quantidade)
        {
            CodigoProduto = codigoProduto;
            NomeProduto = nomeProduto;
            Preco = preco;
            Quantidade = quantidade;
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine(CodigoProduto);
            Console.WriteLine(NomeProduto);
            Console.WriteLine(Preco);
            Console.WriteLine(Quantidade);
        }

        public void AtualizarPreco(double novoPreco)
        {
            Preco = novoPreco;
            Console.WriteLine("o novo preço do produto é:"+Preco);
        }

        public int VerificarEstoque()
        {
            return Quantidade;
        }

        public int VenderProdutos(int compras)
        {
            if (compras > Quantidade)
            {
                Console.WriteLine("não é possível comprar, não temos essa quantidade em nosso estoque.");
            }
            else
            {
                Quantidade -= compras;
                return Quantidade;
            }
        }
    }
}
