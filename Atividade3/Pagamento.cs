using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade3
{
    public class Pagamento
    {
        public string Pessoa { get; set; }
        public int CodigoPeca { get; set; }
        public double PrecoUniDaPeca { get; set; }
        public int QuantidadeVendida { get; set; }
        public double VendaTotal { get; set; }
        public double comissao { get; set; }


        public void PagamentoDeComissao() 
        {


            Console.WriteLine("Qual o valor da peça?");
            PrecoUniDaPeca=int.Parse(Console.ReadLine());

            Console.WriteLine("Quantas foram vendidas?");
            QuantidadeVendida=int.Parse(Console.ReadLine());

            

            double cotacao = (PrecoUniDaPeca * QuantidadeVendida) * 0.05;

            Console.WriteLine($"O valor das peças é: {PrecoUniDaPeca}" +
                $"\n A Quantidade de peças vendidas:{QuantidadeVendida}" +
                $"\n A cotação será: {cotacao}");

        }

    }
}
