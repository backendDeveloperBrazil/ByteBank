using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Employees
{
    public abstract class Employee //Por ser abstract, ele não pode ser diretamente instanciado
    {
        public static int TotalEmployees { get; private set; }

        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }
        

        public Employee(double salario, string cpf)
        {
            Console.WriteLine("Criando Funcionário!");

            Salario = salario;
            CPF = cpf;

            TotalEmployees++;
        }

        public abstract void AumentarSalario();


        public abstract double GetBonus();
        
    }
}
