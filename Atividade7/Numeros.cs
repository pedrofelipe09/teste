using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade7
{
    public class Numeros
    {
        public int num1 { get; set; }
        public int num2 { get; set; }

        public void Menu()
        {
            Console.WriteLine("Digite um número");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro número");
            num2= int.Parse(Console.ReadLine());

            Console.WriteLine("1-Verificar se um dos números lidos é ou não múltiplo do outro" +
                "\n2 - verfica se um dos números lidos é par" +
                "\n3- Verifica se a média dos dois números é maior ou igual a 7.\n4- Sair");
            int acao = int.Parse(Console.ReadLine());
            int media = num1 + num2 / 2;

            if(acao == 1)
            {
                if(num1 % num2 == 0)
                {
                    Console.WriteLine("Eles são Múltiplos");
                }
                else if(num2 % num1 ==0) 
                {
                    Console.WriteLine("Eles são Múltiplos");
                }
                else
                {
                    Console.WriteLine("Eles não são Múltiplos");
                }
            }
            if(acao == 2)
            {
                if(num1%2 == 0 && num2%2 == 0)
                {
                    Console.WriteLine("Os dois são pares");
                }
                else
                {
                    Console.WriteLine("Não são pares");
                }
            }
            else if(acao == 3)
            {
                if(media >= 7)
                {
                    Console.WriteLine("A média é maior");
                }
                else if (media < 7)
                {
                    Console.WriteLine("A média é menor");
                }
            }
            if(acao == 0)
            {
                Console.WriteLine("Sair");
            }

        }
    }
}
