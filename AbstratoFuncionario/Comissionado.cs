using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratoFuncionario
{
    public class Comissionado : Funcionario
    {
        public double Porcentagem { get; set; }

        public Comissionado(int codigo, string nome, double salario, double porcentagem) 
            : base(codigo, nome, salario)
        {
            Porcentagem = porcentagem;
        }

        public override double CalcularSalario(int diasUteis)
        {
            return Salario + (Salario * Porcentagem / 100);
        }

        public override void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine("Porcentagem: " + Porcentagem);
        }
    }
}
