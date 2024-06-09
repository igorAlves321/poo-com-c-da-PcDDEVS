using System;

namespace ProblemaMediaAluno
{
    class Aluno
    {
        public string nome;
        public double nota1, nota2, nota3;

        public double calcular()
        {
            return nota1 * 0.3 + nota2 * 0.35 + nota3 * 0.35;
        }

        public void verificarAprovacao()
        {
            double final = calcular();
            Console.WriteLine($"A nota final do {nome} é {final}.");

            if (final >= 60)
            {
                Console.WriteLine($"{nome} está APROVADO.");
            }
            else
            {
                double faltam = 60 - final;
                Console.WriteLine($"{nome} está REPROVADO.");
                Console.WriteLine($"Faltam {faltam} pontos para ser aprovado.");
            }
        }
    }
}
