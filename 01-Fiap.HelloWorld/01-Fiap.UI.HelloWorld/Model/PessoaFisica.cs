using System;
using System.Collections.Generic;
using System.Text;

namespace _01_Fiap.UI.HelloWorld.Model
{
    class PessoaFisica : Pessoa, ITrabalhador
    {
        //Métodos
        public override void PagarImposto(decimal dinheiro)
        {
            Console.WriteLine("Imposto: " + dinheiro * 0.27m);
        }

        //sobrescrever o comportamento do método do pai
        public override void Investir(decimal dinheiro)
        {
            Console.WriteLine("PF investindo");
        }

        public void Trabalhar()
        {
            Console.WriteLine("Trabalhando");
        }

        //Construtor
        public PessoaFisica()
        {

        }

        public PessoaFisica(string nome) : base(nome)
        {
            
        }

        //Propriedades - Gets/Sets
        public Genero Sexo { get; set; }
        public string Cpf { get; set; }
        public int Idade { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
