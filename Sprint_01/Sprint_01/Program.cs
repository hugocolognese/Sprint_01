namespace Sprint_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta = new ContaBancaria("teste", 123456);
            conta.Saldo = 15.50m;
            conta.Depositar();
        }
    }
}
