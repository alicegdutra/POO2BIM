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
        public double Salario { get; set; }

        public List<Dependente> VetD { get; set; }
        public Funcionario(int codigo, string nome, double salario)
        {
            Codigo = codigo;
            Nome = nome;
            Salario = salario;
        }
        public virtual void Mostrar()
        {
            Console.WriteLine("Código: " + Codigo + "\tNome: " + Nome + "\tSalário: " + Salario);
        }
        public abstract double CalcularSalario(int diasUteis);
        //assinatura de método sabemos o que o método faz pelo nome dele, sabemos se precisa de valor externo para a atender o desenvolvimento da lógica (parâmetro) e se ocorrerá saída de valor (return)

        public void Adicionar(Dependente d)
        {
            VetD.Add(d);
        }
        public void ListarDependente()
        {
            Console.WriteLine("\nListagem do funcionário: " + Nome);
            foreach (Dependente d in VetD)
                d.Mostrar();
        }
        public void Excluir(int codigo)
        {
            for(int i = 0; i < VetD.Count; i++)
            {
                Dependente d = VetD.ElementAt<Dependente>(i);
                if (d.Codigo == codigo)
                    VetD.Remove(d);
            }
        }

        public int CalcularTotaldependentes()
        {
            Console.WriteLine(VetD.Count);
            return VetD.Count;
        }

    }
}