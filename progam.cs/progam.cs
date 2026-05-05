using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eduarda_matos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            funcionario func = new funcionario();

            Console.Write("Nome: ");
            func.Nome = Console.ReadLine();
            Console.Write("Salario Bruto: ");
            func.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            func.imposto = double.Parse(Console.ReadLine(); CultureInfo.InvariantCulture);

            Console.Write("");
            Console.WriteLine("funcionario : " + func);

            Console.WriteLine("");
            Console.Write("deseja aumentar o salario em qual porcentagem");
            double parcent = double.Parse (Console.ReadLine(),CultureInfo.InvariantCulture);
            func.AumentarSalario(porcentagem);

            Console.WriteLine("");
            Console.WriteLine("Dados atualizados:" + func);

        }

    }
}
