﻿using ByteBank_ADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_ADM.Funcionarios
{
    public class Diretor:Autenticaval
    {
        public override double GetBonificacao()
        {
            return this.Salario *0.5;
        }

        public Diretor(string cpf):base(cpf,5000)
        {
            //Console.WriteLine("Criando um diretor.");
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.15;
        }

        public override bool Autenticar(string senha)
        {
            return this.Senha == senha;
        }
    }
}
