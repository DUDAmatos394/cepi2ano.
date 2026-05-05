using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eduarda_matos
{
    internal class funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - imposto;
        }

        public void AumentarSalario (double porcentagem)
        {
            SalarioBruto = SalarioBruto +(SalarioBruto * porcentagem / 100.00);
        }

        public override string ToString()
        {
            return Nome
            + ",R$"
            + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }

}
