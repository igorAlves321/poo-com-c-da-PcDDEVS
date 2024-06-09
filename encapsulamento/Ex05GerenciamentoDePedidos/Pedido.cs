using System;

namespace Ex05GerenciamentoDePedidos
{
    public class Pedido
    {
        public string NumeroDoPedido { get; set; }
        public string Cliente { get; set; }
        public double ValorTotal { get; set; }
        public bool Pago { get; private set; }

        public Pedido(string numeroDoPedido, string cliente, double valorTotal)
        {
            NumeroDoPedido = numeroDoPedido;
            Cliente = cliente;
            ValorTotal = valorTotal;
            Pago = false;
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"Olá, senhor {Cliente}, o número de seu pedido é: {NumeroDoPedido}");
            Console.WriteLine($"Valor Total: {ValorTotal}");
            Console.WriteLine($"Status do Pedido: {(Pago ? "Pago" : "Não Pago")}");
        }

        public void AtualizarValor(double valor)
        {
            ValorTotal += valor;
            Console.WriteLine($"Valor atualizado. Novo valor total: {ValorTotal}");
        }

        public bool VerificarPagamento()
        {
            return Pago;
        }

        public bool ProcessarPagamento(double valor)
        {
            if (valor >= ValorTotal)
            {
                Pago = true;
                Console.WriteLine("Pagamento processado com sucesso.");
                return true;
            }
            else
            {
                Console.WriteLine("Valor insuficiente para processar o pagamento.");
                return false;
            }
        }
    }
}
