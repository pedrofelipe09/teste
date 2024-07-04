using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividades2
{
    public class Cota
    {
        public double cotacaodolar { get; set; }
        public double valor { get; set; }
        public double valorconvertido { get; set; }
        
        public void Conversor()
        {
            Console.WriteLine("Qual é a cotação do dolar?");
            cotacaodolar= double .Parse(Console.ReadLine());

            Console.WriteLine("Qual o seu saldo para conversão?");
            valor = double.Parse(Console.ReadLine());

            valorconvertido= cotacaodolar* valor;
            Console.WriteLine($"O valor convertido {valorconvertido}");

        }

    }
}
