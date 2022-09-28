using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoPOO.Dominio
{
    public class Moeda //classe
    {
    
        public double ConverterValor(float real, float dolar)
        {
            var resultado = real * dolar;
            return resultado;
        }
    }


 


    
}
