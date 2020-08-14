using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class ContaCorrente
    {
        public static int TotalDeContasCriadas { get; set; }
        public Cliente Titular { get; set; }
        public int Agencia { get; set; }
        public int Numero { get; set; }

        private double _saldo;

        public ContaCorrente(int agencia, int conta)
        {
            Agencia = agencia;
            Numero = conta;

            TotalDeContasCriadas++;
        }

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {

                }

                _saldo = value;
            }
        }

        public string Sacar(double valor)
        {
            if (_saldo < valor)
            {
                return "Saldo insuficiente!";
            }
            else
            {
                _saldo -= valor;
                return "Saque realizado com sucesso!";
            }   
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public string Transferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
            {
                return "Saldo insufuciente!";
            }
            else
            {
                _saldo -= valor;
                contaDestino.Depositar(valor);
                return "Transferencia efetuado com sucesso!";
            }
        }
    }
}
