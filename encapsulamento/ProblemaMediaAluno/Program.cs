using System;

        
namespace ProblemaMediaAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
            Console.Write("Digite o nome do aluno: ");
            aluno.nome = Console.ReadLine();
            Console.Write("Digite a nota do primeiro trimestre: ");
            aluno.nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota do segundo trimestre: ");
            aluno.nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota do terceiro trimestre: ");
            aluno.nota3 = double.Parse(Console.ReadLine());

            aluno.verificarAprovacao();
            Console.ReadKey();
        }
    }
}
