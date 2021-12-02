using ByteBank.Employees;
using ByteBank.Systems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Program program = new Program(); //Este é um outro meio de chamar CalcularBonus(); Assim como o método acima
            program.CalcularBonus();

            Este modelo acima e também abaixo é um método de instância.
            */

            // CalcularBonus(); //Para funcionar, devemos tornar o objeto public void CalcularBonus() Static 

            UsarSistema();

            Console.ReadLine();
        }

        public static void UsarSistema()
        {
            InternalSystem sistemaInterno = new InternalSystem();

            Director yanne = new Director("655.333.777.10");
            yanne.Nome = "Yanne Lagarde";
            yanne.Senha = "123";

            AccountManager shiela = new AccountManager("890.098.890-89");
            shiela.Nome = "Shiela Lagarde";
            shiela.Senha = "abc";

            //Designer junior = new Designer("555.333.777.10");
            //junior.Nome = "Junior Lagarde";

            sistemaInterno.Log(yanne, "123");
            sistemaInterno.Log(shiela, "abc");
            
            //sistemaInterno.Log(junior, "abc123");


        }

        public static void CalcularBonus()
        {
            GerenciadorBonus gerenciadorBonus = new GerenciadorBonus();

            Director yanne = new Director("655.333.777.10");
            yanne.Nome = "Yanne Lagarde";

            AccountManager shiela = new AccountManager("890.098.890-89");
            shiela.Nome = "Shiela Lagarde";

            Designer junior = new Designer("555.333.777.10");
            junior.Nome = "Junior Lagarde";

            Assistant gisele = new Assistant("777.789.777-70");
            gisele.Nome = "Gisele Freitas";

            Developer edemir = new Developer("011.011.011-10");
            edemir.Nome = "Edemir";

            gerenciadorBonus.Registrar(edemir);
            gerenciadorBonus.Registrar(yanne);
            gerenciadorBonus.Registrar(shiela);
            gerenciadorBonus.Registrar(junior);
            gerenciadorBonus.Registrar(gisele);

            Console.WriteLine("Total de bonus do mês " + gerenciadorBonus.GetTotalBonus());
        }
    }
}







/* ----------------- Código antigo para referência -----------------
 
GerenciadorBonus gerenciador = new GerenciadorBonus();

            Funcionario yanne = new Funcionario(2000, "015.015.015-15");
            gerenciador.Registrar(yanne);
            yanne.Nome = "Yanne Lagarde";
            //yanne.CPF = ; 
            



            yanne.AumentarSalario(); // <<< AUMENTAR SALARIO
            Console.WriteLine("Novo salário da Yanne " + yanne.Salario);



            Console.WriteLine(Funcionario.TotalFuncionarios);



            Console.WriteLine(yanne.Nome);
            Console.WriteLine("Salário R$ " + yanne.Salario);
            Console.WriteLine("Total de bonus: " + yanne.GetBonus());
            
            //Console.WriteLine("Total de bonus: " + gerenciador.GetTotalBonus());

            //=================================================================

            Funcionario kolob = new Diretor("454.658.148-3");
            gerenciador.Registrar(kolob);

            kolob.Nome = "Kolob Lagarde";
            //kolob.CPF = ;
            



            kolob.AumentarSalario();  // <<< AUMENTAR SALARIO
            Console.WriteLine("Novo salário da Kolob " + kolob.Salario);



            Console.WriteLine(Funcionario.TotalFuncionarios);



            Console.WriteLine(kolob.Nome);
            Console.WriteLine("Salário R$ " + kolob.Salario);
            Console.WriteLine("Total de bonus: " + kolob.GetBonus());
            
            //Console.WriteLine("Total de bonus: " + gerenciador.GetTotalBonus());
 
 */