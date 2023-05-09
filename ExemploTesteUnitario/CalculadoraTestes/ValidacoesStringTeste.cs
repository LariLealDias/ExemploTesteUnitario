using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculadora.Services;


namespace CalculadoraTestes
{
    public class ValidacoesStringTeste
    {
        private ValidacoesString _valid;
        public ValidacoesStringTeste()
        {
            _valid = new ValidacoesString();
        }

        [Fact]
        public void DeveContar3CaractresEmOlaERetornar3()
        {
            //arrange
            string texto = "Ola";

            //Act
            int resultado = _valid.ContarCaracteres(texto);

            //Asset
            Assert.Equal(3, resultado);
        }
    }
}