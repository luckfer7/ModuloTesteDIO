using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Services
{
    public class CalculadoraImp
    {
        public int Somar (int num1, int num2)
        {
            return num1 + num2;
        }

        public int Subtrair (int num3, int num4)
        {
            return num3 - num4;
        }

        public bool EhPar (int num)
        {
            return num % 2 == 0;
        }
    }
}