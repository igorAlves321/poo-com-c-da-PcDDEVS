using System;

namespace ProblemaRetangulo
{
    public class Retangulo
    {
        public double Altura { get; set; }
        public double Largura { get; set; }
        public string Cor { get; set; }

        public Retangulo(double altura, double largura, string cor) : this(altura, largura)
        {
            Cor = cor;
        }

        public Retangulo(double altura, double largura)
        {
            Altura = altura;
            Largura = largura;
        }

        public double CalcularArea()
        {
            return Altura * Largura;
        }

        public double CalcularPerimetro()
        {
            return 2 * (Altura + Largura);
        }

        public double CalcularDiagonal()
        {
            return Math.Sqrt(Altura * Altura + Largura * Largura);
        }

        public override string ToString()
        {
            return $"Retângulo: Altura = {Altura}, Largura = {Largura}, Cor = {Cor}, " +
                $"Área = {CalcularArea():F2}, Perímetro = {CalcularPerimetro():F2}, " +
                $"Diagonal = {CalcularDiagonal():F2}";
        }
    }
}
