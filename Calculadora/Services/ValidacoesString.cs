using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Services
{
    public class ValidacoesString
    {
        public int ContarCaracteres(string texto)
        {
            int numeroDeCaracteres = texto.Length;
            return numeroDeCaracteres;
        }
    }
}