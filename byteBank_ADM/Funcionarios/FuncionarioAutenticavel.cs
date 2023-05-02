﻿using byteBank_ADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBank_ADM.Funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        public FuncionarioAutenticavel(string cpf, double salario) : base(cpf, salario)
        {
        }

        public string Login { get; set; }
        public string Senha { get; set; }
        public bool Autenticar(string login, string senha)
        {
            return this.Login == login;
            return this.Senha == senha;
        }
    }
}
