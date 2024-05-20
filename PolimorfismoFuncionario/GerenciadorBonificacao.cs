using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolimorfismoFuncionario
{
    public class GerenciadorBonificacao 
    {
        public double TotalBonificacao { get; private set; }

        public void TotalizadorBonificacao(Funcionario funcionario)
        {
            TotalBonificacao += funcionario.CalcularBonificacao();
        }
        public void TotalizadorBonificacao(Secretario secretario)
        {
            TotalBonificacao += secretario.CalcularBonificacao();
        }

        public void TotalizadorBonificacao(Diretor diretor)
        {
            TotalBonificacao += diretor.CalcularBonificacao();
        }

        public void TotalizadorBonificacao(Gerente gerente)
        {
            TotalBonificacao += gerente.CalcularBonificacao();
        }

        

    }
}