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

        public List<Dependente> VetDp { get; set; }
        
        public Funcionario(int codigo, string nome, double salario)
        {
            Codigo = codigo;
            Nome = nome;
            Salario = salario;
            VetDp = new List<Dependente>(); // Inicializando a lista aqui
        }

        public virtual void Mostrar()
        {
            Console.WriteLine("Código: " + Codigo + "\tNome: " + Nome + "\tSalário: " + Salario);
        }

        public abstract double CalcularSalario(int diasUteis);

        public void Adicionar(Dependente d)
        {
            VetDp.Add(d);
        }

        public void ListarDependente()
        {
            Console.WriteLine("\nListagem do funcionário: " + Nome);
            foreach (Dependente d in VetDp)
                d.Mostrar();
        }

        public void Excluir(int codigo)
        {
            for (int i = 0; i < VetDp.Count; i++)
            {
                Dependente d = VetDp.ElementAt(i);
                if (d.Codigo == codigo)
                {
                    VetDp.Remove(d);
                    break;
                }
            }
        }

        public int CalcularTotalDependentes()
        {
            int totalDependentes = 0;

            foreach (var dependente in VetDp)
            {
                totalDependentes++;
            }

            Console.WriteLine(totalDependentes);
            return totalDependentes;
        }
    }
}
