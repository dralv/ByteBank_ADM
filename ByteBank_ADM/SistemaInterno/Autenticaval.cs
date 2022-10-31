﻿using ByteBank_ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_ADM.SistemaInterno
{
    public abstract class Autenticaval:Funcionario
    {
        public string Senha { get; set; }
        public abstract bool Autenticar(string senha);
        
        public Autenticaval(string cpf, double salario):base(cpf, salario)
        {

        }

        

     
    }
}