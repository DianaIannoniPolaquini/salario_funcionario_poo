using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace FUNCIONARIO_SALARIO_POO
{
    internal class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return (SalarioBruto - Imposto);
        }
        public override string ToString()
        {
            return Nome + ", $ " + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }

        public void AumentarSalario(double porcent)
        {
            SalarioBruto = SalarioBruto + (SalarioBruto * porcent/100.0);
        }
    }
}
