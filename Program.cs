using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(123, 12345678);
            Cliente cliente = new Cliente();

            cliente.Nome = "Davi";
            cliente.CPF = "452.846.388-16";
            cliente.Profissao = "Desevolvedor .NET";

            conta.Saldo = 500;
            conta.Titular = cliente;

            Console.WriteLine(conta.Titular.Nome);
            Console.WriteLine($"Agencia: {conta.Agencia}");
            Console.WriteLine($"Conta: {conta.Numero}");
            Console.WriteLine($"Saldo: {conta.Saldo}");
            Console.WriteLine($"Total de contas do banco ByteBank: {ContaCorrente.TotalDeContasCriadas}");

            Console.ReadLine();
        }
    }
}
