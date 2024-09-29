using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculadora.Services;

namespace CalculadoraTestes
{
    public class ValidacoesStringTests
    {
        private ValidacoesString _validacoes;

        public ValidacoesStringTests()
        {
            _validacoes = new ValidacoesString();
        }

        [Fact]
        public void DeveContar5CaracteresNoNomeLucasERetornar5()
        {
            //arrange

            string texto = "Lucas";

            //Act
            int retorno = _validacoes.ContarCaracteres(texto);

            //Assert
            Assert.Equal(5, retorno);
        }

        
    }
}