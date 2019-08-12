using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.Banco.Model
{
    abstract class Conta
    {
        //Propriedades
        public int Agencia { get; set; }
        public int Numero { get; set; }

        public DateTime DataAbertura { get; set; }
        public decimal Saldo { get; set; }

        //Metodos
        public abstract void Retirar(decimal valor);
        public abstract void Depositar(decimal valor);
    }
}
