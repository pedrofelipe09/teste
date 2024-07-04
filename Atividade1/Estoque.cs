using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade1
{
    public class Estoque
    {
        public int QuantidadeMinima { get; set; }
        public int QuantidadeMaxima { get; set; }
        public Estoque(int quantiamax, int quantiamin) 
        {
            QuantidadeMinima = quantiamin;
            QuantidadeMaxima = quantiamax;
        }

        public void CalcularEstoque()
        {
            int EstoqueMedio;
            EstoqueMedio = (QuantidadeMinima + QuantidadeMaxima) /2;
            Console.WriteLine(EstoqueMedio);
        }
    }
}
