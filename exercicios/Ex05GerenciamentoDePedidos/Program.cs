using Ex05GerenciamentoDePedidos;
using System;

class Program
{
    static void Main(string[] args)
    {
        Pedido pedido = new Pedido("888ab", "cliente1", 100.3);
        pedido.ExibirDetalhes();
        pedido.AtualizarValor(50.0);
        pedido.ExibirDetalhes(); // Exibe o novo valor atualizado
        Console.WriteLine($"Pagamento Verificado: {pedido.VerificarPagamento()}");
        bool pagamentoRealizado = pedido.ProcessarPagamento(150.3);

        if (pagamentoRealizado)
        {
            Console.WriteLine("Pedido pago com sucesso.");
        }
        else
        {
            Console.WriteLine("Pagamento falhou.");
        }

        pedido.ExibirDetalhes(); // Exibe o status de pagamento atualizado
    }
}
