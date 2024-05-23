using System;
using System.Collections.Generic;

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
            VetF = new List<Funcionario>(); // Inicializando a lista aqui
        }

        public void Admitir(Funcionario f)
        {
            VetF.Add(f);
        }

        public void Demitir(int codigo)
        {
            for (int i = 0; i < VetF.Count; i++)
            {
                if (VetF[i].Codigo == codigo)
                {
                    VetF.RemoveAt(i);
                    break; // sair do loop após remover o funcionário
                }
            }
        }

        public void ListarFuncionarios()
        {
            Console.WriteLine($"Listagem do departamento: {Nome}");
            foreach (Funcionario f in VetF)
            {
                f.Mostrar();
            }
        }

        public double CalcularFolha(int diasUteis)
        {
            double total = 0;
            foreach (Funcionario f in VetF)
            {
                total += f.CalcularSalario(diasUteis);
            }
            return total;
        }
    }
}

