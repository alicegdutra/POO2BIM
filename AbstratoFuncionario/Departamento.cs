using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratoFuncionario
{
    public class Departamento
    {
        public int Codigo { get; set; }

        public string Nome { get; set; }

        public List<Funcionario> VetF { get; set; }

        public Departamento(int codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
        }

        public void Admitir(Funcionario f)
        {
            VetF.Add(f);
        }

        public void ListarFuncionarios()
        {
            System.Console.WriteLine("\nListagem do departamento: " +  Nome);
            foreach (Funcionario f in VetF)
                f.Mostrar();
        }

        public void Demitir(int codigo)
        {
            for (int i = 0; i < VetF.Count; i ++)
            {
                Funcionario f = VetF.ElementAt<Funcionario>(i); //pega o elemento que esta em uma determinada pos no vetor
                if (f.Codigo == codigo)
                    VetF.Remove(f);
            }
        }

        public double CalcularFolha(int diasUteis)
        {
            double folha = 0;
            for (int i = 0; i < VetF.Count; i ++)
            {
                Funcionario f = VetF.ElementAt<Funcionario>(i); //pega o elemento que esta em uma determinada pos no vetor
                folha += f.CalcularSalario(diasUteis);
            }

            return folha;
        }
    }
}