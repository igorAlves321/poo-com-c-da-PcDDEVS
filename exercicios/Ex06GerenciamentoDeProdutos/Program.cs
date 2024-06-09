namespace Ex06GerenciamentoDeProdutos
{
    public class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto("a1b2c3", "celular", 1000, 10);
            produto.ExibirDetalhes();
            produto.AtualizarPreco(2000);
            produto.VerificarEstoque();
            produto.VenderProdutos(333);

        }
    }
}
