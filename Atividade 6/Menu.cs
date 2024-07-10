using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_6
{
    public class Menu
    {
        public int num1 { get; set; } 
        public int num2 { get; set; }
        public int num3 { get; set; }

        public void ExibirMenu()
        {
            Console.WriteLine("Digite um número");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("1- Adição \n2- Subtração \n3- Multiplicação \n4- Divisao");
            int acao = int.Parse(Console.ReadLine());
            if(acao == 1)
            {
                num3 = num1 + num2;
                Console.WriteLine(num3);
            }
            else if (acao == 2)
            {
                num3= num1  - num2;
                Console.WriteLine(num3);    
            }
            else if (acao == 3)
            {
                num3 = num1 * num2;
                Console.WriteLine(num3);
            }
            else if (acao == 4)
            {
                num3 = num1 / num2;
                Console.WriteLine(num3);
            }
        }

    }
}
