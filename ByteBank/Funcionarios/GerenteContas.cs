using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class GerenteContas : Funcionario
    {
        public GerenteContas(string cpf) : base(4000, cpf)
        {
            //Aqui já colocamos os valores acima
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
