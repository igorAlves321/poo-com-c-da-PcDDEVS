using Exercicio02Livros;

Livro livro = new Livro("Java como programar", "não me recordo", 2009);
livro.ExibirInformacoes();
livro.Emprestar(true);
Console.WriteLine($"Disponibilidade: {livro.VerificarDisponibilidade()}");
Console.WriteLine($"Anos desde publicação: {livro.AnosDesdePublicacao(DateTime.Now.Year)}");
