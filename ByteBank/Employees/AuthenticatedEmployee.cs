using ByteBank.Systems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Employees
{
    public abstract class AuthenticatedEmployee : Employee, IAuthenticatable
    {
        public string Senha { get; set; }
        public AuthenticatedEmployee(double salario, string cpf)
            : base(salario, cpf)
        {

        }

        public bool Authenticate(string senha)
        {
            return Senha == senha;
        }
    }
}
//Para deixar claro na convencao, de que Authenticatable, é uma interface