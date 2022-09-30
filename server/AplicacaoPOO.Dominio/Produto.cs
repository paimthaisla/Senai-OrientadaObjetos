using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoPOO.Dominio
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }

        public List<Produto> ListaProdutosFakes()
        {
            var listaProdutos = new List<Produto>();
            listaProdutos.Add(new Produto()
            {
                Codigo = 1,
                Nome = "Motor",
                Valor = 100.00m,

            });
            listaProdutos.Add(new Produto()
            {
                Codigo = 2,
                Nome = "Pneu",
                Valor = 36.00m,

            });
            listaProdutos.Add(new Produto()
            {
                Codigo = 3,
                Nome = "Corrente",
                Valor = 30.00m,

            });
            return listaProdutos;
        }
    }
}
