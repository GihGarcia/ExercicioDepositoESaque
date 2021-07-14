using System;
using System.Collections.Generic;
using System.Text;

namespace Exercício_Deposito_e_Saque
{
    class ContaBancaria
    {
        public int Numero { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numero, string nome, double saldo)
        {
            Numero = numero;
            Nome = nome;
            Saldo = saldo;
        }

        public ContaBancaria(int numero, string nome)
        {
            Nome = nome;
            Numero = numero;
        }

        public void AdicionarDeposito(double acrescimo)
        {
            Saldo = Saldo + acrescimo;
        }

        public void Saque(double saque)
        {
            Saldo = Saldo - saque - 5;
        }

        public override string ToString()
        {
            return "conta: " + Numero + ", titular: " + Nome + ", saldo: $ " + Saldo;
        }
    }
}
