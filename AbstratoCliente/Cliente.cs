using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratoCliente
{
    public abstract class  Cliente //não pode ser instanciado
    {
        protected int codigo;
        protected string nome;
        protected string endereco;

        protected int idade;
       

        public abstract void AvaliaIdade();
        
        public Cliente()
        {            
        }
        public Cliente(int codigo, string nome, string endereco, int idade)
        {
            Codigo = codigo;
            Nome = nome;
            Endereco = endereco;
            Idade = idade;
        }
        public abstract void Mostrar(); // a função nao possui corpo por ser abstrata
        public int Codigo{
            get { return codigo;}
            set { codigo = value;}
        }
        public string Nome{
            get { return nome;}
            set { nome = value;}
        }
        public string Endereco{
            get { return endereco;}
            set { endereco = value;}
        }
        
        public int  Idade
        {
            get { return idade; }
            set { idade = value; }
        }

    }
}