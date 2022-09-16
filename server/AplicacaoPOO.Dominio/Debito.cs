using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoPOO.Dominio
{
    public class Debito  //debitar valores: Como? 
    {
        Pagamento Pagamento { get; set; }
        double Desconto { get; set; }

        //metodo , nome da função, (oque ela vai receber)
        public double DebitarValor(double saldo, double desconto)
        {
            var resultado = saldo - desconto;
            return resultado;   //não precisa do igual
        }
        
       
    
    }
}
