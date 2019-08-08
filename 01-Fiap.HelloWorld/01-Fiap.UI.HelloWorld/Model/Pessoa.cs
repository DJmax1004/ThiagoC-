using System;
using System.Collections.Generic;
using System.Text;

namespace _01_Fiap.UI.HelloWorld.Model
{
    abstract class Pessoa
    {
        //métodos
        public abstract void PagarImposto(decimal dinheiro);

        public virtual void Investir(decimal dinheiro)
        {
            Console.WriteLine("Investindo " + dinheiro);
        }

        //Construtor //ctor
        public Pessoa()
        {

        }
        public Pessoa(string nome)
        {
            Nome = nome;            
        }

        //Atributo - Field/Campos
        private string _nome;

        //Métodos Gets/Sets - Propriedades
        public int Codigo { get; set; }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
    }
}
