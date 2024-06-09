using Ex04ContaBancaria;
using static System.Net.Mime.MediaTypeNames;

Banco banco = new Banco("abcd", "Igor");
banco.ExibirEnformacoes();
banco.Depositar(11111);
bool saqueRealizado = banco.Sacar(222);
if (saqueRealizado)
{
    Console.WriteLine($"Saque realizado. Saldo atual: {banco.ObterSaldo():C}");
}
else
{
    Console.WriteLine($"Saque não realizado. Saldo atual: {banco.ObterSaldo():C}");
}