using System;

namespace Exercício_Deposito_e_Saque
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;


            Console.Write("Entre o número da conta: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá valor inicial de depósito (s/n)? ");
            char resposta = Convert.ToChar(Console.ReadLine());

            if (resposta == 's' || resposta == 'S')
            {
                Console.Write("Entre o valor do depósito inicial: ");
                double DepositoInicial = Convert.ToDouble(Console.ReadLine());
                conta = new ContaBancaria(numero, titular, DepositoInicial);
            }
            else
                conta = new ContaBancaria(numero, titular);

            Console.WriteLine("");
            Console.WriteLine("Dados da conta: ");
            Console.Write(conta.ToString());

            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("Entre um valor para depósito: ");
            conta.AdicionarDeposito(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("");
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta.ToString());

            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("Entre um valor para saque:");
            conta.Saque(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("");
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta.ToString());
        }
    }
}
