using System;

namespace SaldoBanco
{
    class Program
    {
        static void Main(string[] args)
        {

            saldoBanco c = new saldoBanco();

            Console.Write("Entre numero da conta:");
            c.numeroConta = int.Parse(Console.ReadLine());
            //Console.WriteLine();
            Console.Write("Entre o titular da conta:");
            //Console.WriteLine();
            c.nomeUsuario = Console.ReadLine();
            Console.Write("Havera deposito inicial (s/n)?");

            string depositoInicial = Console.ReadLine();

            if (depositoInicial == "s")
            {
                Console.Write("Entre o valor de deposito inicial: ");
                c.valorDeposito = double.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine(c);

            Console.Write("Entre um valor para deposito: ");
            int valorMovimento = int.Parse(Console.ReadLine());
            c.AdicionarDeposito(valorMovimento);
            Console.WriteLine(c);

            Console.Write("Entre um valor para saque: ");
            valorMovimento = int.Parse(Console.ReadLine());
            c.RemoverValor(valorMovimento);
            Console.WriteLine(c);
        }
    }
}
