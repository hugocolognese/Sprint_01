using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint_01
{
    class ContaBancaria
    {
        public int NumeroConta { get; set; }
        public string Titular { get; set; }
        public decimal Saldo { get; set; }

        public void ExibirDados()
        {
            Console.WriteLine($"titular da conta: {Titular}");
            Console.WriteLine($"numero da conta: {NumeroConta}");
            Console.WriteLine($"saldo: {Saldo}");
        }
    }
}
