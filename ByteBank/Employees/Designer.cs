using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Employees
{
    public class Designer : Employee
    {
        public Designer(string cpf) : base(3000, cpf)
        { 
            //Aqui já colocamos os valores acima
        }
        public override void AumentarSalario()
        { 
            Salario *= 1.11;
        }

        public override double GetBonus()
        {
            return Salario * 0.17;
        }
    }
}
