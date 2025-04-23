using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número: \n");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: \n");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Olá, qual tipo de cálculo deseja fazer?");
            Console.WriteLine("(1)Soma, (2)Subtração, (3)Multiplicação, (4)Divisão: \n");
            int op = int.Parse(Console.ReadLine());

            Soma soma = new Soma();
            Subtração subtracao = new Subtração();
            Multiplicação multiplicacao = new Multiplicação();
            Divisão divisao = new Divisão();

            if (op == 1)
            {
                soma.Somar(n1, n2);
                Console.ReadKey();
            }

            else if(op == 2)
            {

                subtracao.Subtrair(n1, n2);
                Console.ReadKey();

            }

            else if( op == 3)
            {
                multiplicacao.Multiplicar(n1, n2);
                Console.ReadKey();
            }

            else if (op == 4)
            {
                divisao.Dividir(n1, n2);
                Console.ReadKey();
            }

            else
            {
                Console.WriteLine("A opção é inválida.");
            }

        }
    }
}
