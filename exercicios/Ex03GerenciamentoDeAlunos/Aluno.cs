namespace Ex03GerenciamentoDeAlunos;

public class Aluno
{
    public string Nome { get; set; }
    public string Matricula { get; set; }
    public double Nota1 { get; set; }
    public double Nota2 { get; set; }

    public Aluno(string nome, string matricula, double nota1, double nota2)
    {
        Nome = nome;
        Matricula = matricula;
        Nota1 = nota1;
        Nota2 = nota2;
    }

    public void ExibirInformacoies()
    {
        Console.WriteLine(Nome);
        Console.WriteLine(Matricula);
        Console.WriteLine(Nota1);
        Console.WriteLine(Nota2);
    }

    public void AtualizarNota(double notaAtualizada1)
    {
        Nota1 = notaAtualizada1;
        Console.WriteLine(Nota1);
    }

    public double CalcularMedia()
    {
    return Nota1 + Nota2 /2;
    }

    public string AtualizarNome(string novoNome)
    {
    Nome = novoNome;
        return Nome;
    }   
}
