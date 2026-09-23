namespace Sprint_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria informacoesConta = new ContaBancaria();

            informacoesConta.Titular = "Hugo";
            informacoesConta.NumeroConta = 123456;
            informacoesConta.Saldo = 15.50m;
            informacoesConta.ExibirDados();

            ContaCorrente saqueContaCorrente = new ContaCorrente();

            saqueContaCorrente.ExibirSaque();
        }
    }
}
