﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoPOO.Dominio
{
    private class Credito 
    {
        Pagamento Pagamento { get; set; }
        int Parcelas { get; set; }
        float Juros { get; set; }

    public double DebitarValor(double saldo, double desconto)
    {
        var resultado = saldo - desconto;
        return resultado;   //não precisa do igual
    }

    }
}

