using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint_01
{
    class ContaCorrente : ContaBancaria
    {
        public decimal Saque { get; set; }
        public decimal Taxa { get; set; }

        public ContaCorrente(decimal saldo, decimal saque, decimal taxa) 
        {
            Saldo = saldo;
            Saque = saque;
            Taxa = taxa;

            taxa = 5.20m;
            saque = saldo - taxa;
        }

        public ContaCorrente()
        {
        }

        public void ExibirSaque()
        {

        }
    }
}
