using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint_01
{
    class ContaBancaria
    {
        public int NumeroConta { get; set; }
        public string Titular { get; set; }
        public decimal Saldo { get; protected set; }
        
        public ContaBancaria(string titular, int numeroConta)
        {
            Titular = titular;
            NumeroConta = numeroConta;
            Saldo = 0;
        }

        public void Depositar(decimal valor)
        {
            Saldo = valor + Saldo;
        }

        public void Sacar(decimal valor)
        {
            Saldo = Saldo - valor;
        }
    }
}
