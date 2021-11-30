using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Funcionario
    {
        public static int TotalFuncionarios { get; private set; }

        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; set; }

        internal double GetTotalBonus()
        {
            throw new NotImplementedException();
        }

        public Funcionario(string cpf)
        {
            Console.WriteLine("Criando Funcionário!");

            CPF = cpf;
            
            TotalFuncionarios++;
        }

        public virtual double GetBonus()
        {
            return Salario * 0.10;
        }
    }
}
