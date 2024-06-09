namespace Ex04ContaBancaria;

public class Banco
{
    public string NumeroDaconta { get; set; }
    public string Titular { get; set; }
    public double Saldo { get; private set; }

    public Banco(string numeroDaconta, string titular)
    {
        NumeroDaconta = numeroDaconta;
        Titular = titular;
        Saldo = 0;
    }

    public void ExibirEnformacoes()
    {
        Console.WriteLine($"olá {Titular}");
        Console.WriteLine($"o número da sua conta é {NumeroDaconta}");
        Console.WriteLine($"e o saldo que você tem é dê {Saldo}");
    }

    public void Depositar(double deposito)
    {
    Saldo += deposito;
        Console.WriteLine($"Com esse depósito de {deposito} O seu saldo Agora é dê {Saldo}");
    }

    public bool Sacar(double valor)
    {
        if (valor > Saldo)
        {
            Console.WriteLine("Saldo insuficiente.");
            return false;
        }
        else
        {
            Saldo -= valor;
            Console.WriteLine($"Saque de {valor:C} realizado com sucesso. Saldo atual: {Saldo:C}");
            return true;
        }
    }

    public double ObterSaldo()
    {
        return Saldo;
    }
}