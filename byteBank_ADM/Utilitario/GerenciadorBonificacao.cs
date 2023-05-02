using byteBank_ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBank_ADM.Utilitario
{
    public class GerenciadorBonificacao
    {
        public double TotalBonificacoes { get; private set; }

        public void Registrar(Funcionario funcionario)
        {
            this.TotalBonificacoes += funcionario.GetBonificacao();
        }
    }
}
