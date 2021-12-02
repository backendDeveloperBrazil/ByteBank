using ByteBank.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Systems
{
    public abstract class Autenticatable : Employee
    {
        public string Senha { get; set; }

        public Autenticatable(double salario, string cpf) : base(salario, cpf)
        {

        }

        public bool Autenticate(string senha)
        {
            return Senha == senha;
        }
    }
}
