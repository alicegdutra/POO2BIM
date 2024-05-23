using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratoFuncionario
{
    public abstract class Funcionario
    {
        public int Codigo { get; set; }

        public string Nome { get; set; }

        public double Salario {get; set;}

        public Funcionario(int codigo, string nome, double salario)
    
        {
            Codigo = codigo;
            Nome = nome;
            Salario = salario;
        }

        public virtual void Mostrar() // n abstrato
        {
            System.Console.WriteLine(" Código: " + Codigo + " Nome: " + Nome + " Salário: " + Salario);

        }

        public abstract double CalcularSalario(int diasUteis); // abstrato passa por reaproveitamento de código
        //assinatura de método (se aplica ao método abstrato)- sabemos o que o método faz pelo nome dele, sabemos se precisa de valor externo para atender o desenvolvimento da lógica (parâmetro)
        // e se  ocorrerá saída de valor (return)

        public void Adicionar(Dependente d)
        {
            VetDep.Add(d);
        }
        public void ListarDependente()
        {
            Console.WriteLine("\nListagem do funcionário: " + Nome);
            foreach (Dependente d in VetDep)
                d.Mostrar();
        }
        public void Excluir(int codigo)
        {
            for(int i = 0; i < VetDep.Count; i++)
            {
                Dependente d = VetDep.ElementAt<Dependente>(i);
                if (d.Codigo == codigo)
                    VetDep.Remove(d);
            }
        }

        public int CalcularTotaldependentes()
        {
            Console.WriteLine(VetDep.Count);
            return VetDep.Count;
        }
    }
}