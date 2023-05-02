using byteBank_ADM.Comercial;
using byteBank_ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBank_ADM.SistemaInterno
{
    public class SistemaInterno
    {
        public bool Logar(IAutenticavel funcionario, string senha, string login)
        {
            bool usuarioAutenticado = funcionario.Autenticar(senha, login);
            if (usuarioAutenticado)
            {
                Console.WriteLine("Boas Vindas ao Sistema!");
                return true;
            }
            else
            {
                Console.WriteLine("Senha ou Usuário Incorretos!");
                return false;
            }
        }
    }
}
