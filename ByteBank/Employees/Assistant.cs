using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Employees
{
    public class Assistant : Employee
    {
        public Assistant(string cpf) : base(2000, cpf)
        {
            //Aqui já colocamos os valores acima
        }
        public override void AumentarSalario()
        {
            Salario *= 1.1;
        }

        public override double GetBonus()
        {
            return Salario * 0.2;
        }
    }
}
