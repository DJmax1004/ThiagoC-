using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.Banco.Model
{
    class ContaPoupanca : Conta, IContaInvestimento
    {

        //Propriedade
        public decimal Taxa { get; set; }

        //Campo (Atributo)
        private readonly decimal _rendimento;

        //Construtor - ctor
        public ContaPoupanca(decimal rend)
        {
            _rendimento = rend;
        }

        public ContaPoupanca()
        {
        }

        public decimal CalculaRetornoInvestimento()
        {
            return Saldo * _rendimento;
        }

        public override void Depositar(decimal valor)
        {
            Saldo += valor;
        }

        public override void Retirar(decimal valor)
        {
            if (Saldo - valor < 0)
            {
                throw new SaldoInvalidoException("Saldo insuficiente");
            }
            Saldo -= valor + Taxa;
        }
    }
}
