using System.Security.Principal;

namespace Exercicio01Carros;

public class Carro
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Ano { get; set; }
    public string Cor { get; set; }
    public bool Ligado { get; private set; }

    public Carro(string marca, string modelo, int ano, string cor)
    {
        Marca = marca;
        Modelo = modelo;
        Ano = ano;
        Cor = cor;
        Ligado = false;
    }

    public void Ligar()
    {
        Ligado = true;
        Console.WriteLine("o carro está ligado");
    }

    public void Desligar()
    {
        Ligado = false;
        Console.WriteLine("carro desligado");
    }

    public void Acelerar()
    {
        if(Ligado)
        {
            Console.WriteLine("o carro está ligado, então vamos lá!");
        }else
        {
            Console.WriteLine("o carro está desligado, não podemos acelerar.");
        }
    }
}
