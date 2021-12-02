using ByteBank.Systems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Employees
{
    public class AccountManager : Autenticatable
    {
        public AccountManager(string cpf) : base(4000, cpf)
        {
            Console.WriteLine("Criando Gerente de Contas");
        }

        public override void AumentarSalario()
        {
            Salario *= 1.05;
        }

        public override double GetBonus()
        {
            return Salario * 0.25;
        }
    }
}
