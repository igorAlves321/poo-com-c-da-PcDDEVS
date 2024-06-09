using System;

namespace ProblemaDescontoProduto
{
    public class Produto
    {
        // Propriedades
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }
        public double ValorTotal { get; private set; }
        public double Desconto { get; private set; }

        // Construtor
        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public void CalcularDesconto()
        {
            ValorTotal = Preco * Quantidade;
            if (Quantidade <= 10)
            {
                Desconto = 0;
            }
            else if (Quantidade <= 20)
            {
                Desconto = 0.1;
            }
            else if (Quantidade <= 50)
            {
                Desconto = 0.2;
            }
            else
            {
                Desconto = 0.25;
            }
            ValorTotal *= (1 - Desconto);
        }
    }
}
