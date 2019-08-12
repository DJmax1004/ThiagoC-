using Fiap.Banco.Model;
using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            var cc = new ContaCorrente()
            {
                Agencia = 1,
                Numero = 1,
                Saldo = 100,
                Tipo = Model.TipoConta.Comum,
                DataAbertura = DateTime.Now
            };

            var cp = new ContaPoupanca(0.03m)
            {
                Agencia = 1,
                Numero = 2,
                Saldo = 100,
                DataAbertura = new DateTime(2019, 1, 20),
                Taxa = 1
            };

            cc.Retirar(200);
        }
    }
}
