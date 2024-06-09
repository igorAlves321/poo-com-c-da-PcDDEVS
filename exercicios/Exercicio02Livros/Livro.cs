namespace Exercicio02Livros
{
    public class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int AnoPublicacao { get; set; }
        public bool Disponivel { get; private set; }

        public Livro(string titulo, string autor, int anoPublicacao)
        {
            Titulo = titulo;
            Autor = autor;
            AnoPublicacao = anoPublicacao;
            Disponivel = true;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Título: {Titulo}");
            Console.WriteLine($"Autor: {Autor}");
            Console.WriteLine($"Ano de Publicação: {AnoPublicacao}");
            Console.WriteLine($"Disponível: {Disponivel}");
        }

        public void Emprestar(bool emprestimo)
        {
            if (Disponivel && emprestimo)
            {
                Disponivel = false;
                Console.WriteLine("Livro disponível, emprestado com sucesso.");
            }
            else
            {
                Console.WriteLine("Livro não disponível para empréstimo.");
            }
        }

        public bool VerificarDisponibilidade()
        {
            return Disponivel;
        }

        public int AnosDesdePublicacao(int anoAtual)
        {
            return anoAtual - AnoPublicacao;
        }
    }
}
