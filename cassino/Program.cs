using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace cassino
{
    internal class Program
    {
        static Random rnd = new Random();
        static string nome = "";
        static int saldo = 100;

        static void Main(string[] args)
        {
            Console.WriteLine("Qual o seu nome?");
            nome = Console.ReadLine();

            int op = 1;
            while(op != 0)
            {
                Console.WriteLine("Bem vindo, " + nome + "!" + "\t Saldo: " + saldo);
                Console.WriteLine("Escolha uma das seguintes opções: ");
                Console.WriteLine("1-Loteria");
                Console.WriteLine("2-Raspadinhas");
                Console.WriteLine("3-Saques/Depósitos");
                Console.WriteLine("0-Sair");
                op = int.Parse(Console.ReadLine());

                switch (op) { 
                case 0:
                        break;

                case 1:
                        Loteria();
                        break;

                case 2:
                        Raspadinhas();
                        break;

                    case 3:
                        Banca();
                        break;

                    default:
                        Console.WriteLine("Opção inválida!!!!!");
                        Console.ReadKey();
                        break;
                }

            }
        }

        private static void Banca()
        {
            int op = 1;
            while (op != 0)
            {
                Console.Clear();
                Console.WriteLine("Bem vindo, " + nome + "!" + "\t Saldo: " + saldo);
                Console.WriteLine("Escolha uma opção: ");
                Console.WriteLine("1- Saque");
                Console.WriteLine("2-Depósito");
                Console.WriteLine("0- Voltar ao menu anterior");
                op = int.Parse(Console.ReadLine());

                switch(op) {
                    case 0:
                        break;

                    case 1:
                        Saque();
                        break;

                    case 2:
                        Deposito();
                        break;

                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }   
            }
        }

        private static void Deposito()
        {
            Console.Clear();

            Console.WriteLine("Saldo atual: " + saldo);
            Console.WriteLine("Qual o valor que quer depositar?");
            int valor = int.Parse(Console.ReadLine());

            saldo += valor;

            Console.WriteLine("Depósito realizado com sucesso, novo salvo: " + saldo);
        }

        private static void Saque()
        {
            Console.Clear();

            Console.WriteLine("Saldo atual: " + saldo);
            Console.WriteLine("Qual o valor quer sacar??");
            int valor = int.Parse(Console.ReadLine());

            if (saldo - valor < 0)
            {
                Console.WriteLine("Saldo insuficiente");
            }

            else
            {
                saldo -= valor;

                Console.WriteLine("Depósito realizado com sucesso, novo salvo: " + saldo);
            }
           
        }

        private static void Loteria()
        {
            Console.Clear();
            if(saldo - 5 < 0)
            {
                Console.WriteLine("Saldo insuficiente! Realize um deposito antes de jogar.");
                Console.ReadKey();
                return;
            }

            saldo -= 5;

            int npremiado = rnd.Next(1000,10000);
            Console.WriteLine("Bhilhete premiado é: " + npremiado);
            int njogador = 0;

            while(njogador <1000 || njogador > 9999)
            {
                Console.WriteLine("Qual o número que quer jogar na loteria? (1000-9999)");
                njogador = int.Parse(Console.ReadLine());
            }

            if (npremiado == njogador)
            {
                Console.WriteLine("Você ganhou o primeiro premio!!!");
                saldo += 10000;
            }

            else if (npremiado % 1000 == njogador % 1000)
            {
                Console.WriteLine("Você ganhou o segundo premio!!!");
                saldo += 1000;
            }

            else if (npremiado % 100 == njogador % 100)
            {
                Console.WriteLine("Você ganhou o terceiro premio!!!");
                saldo += 100;
            }

            else
            {
                Console.WriteLine("Você não ganhou dessa vez!!");
            }
           
        }

        private static void Raspadinhas()
        {
            int op = 6;
            while (op != 0)
            {
                Console.Clear();
                Console.WriteLine("Menu Raspadinhas");
                Console.WriteLine("1-Raspadinha A");
                Console.WriteLine("2-Raspadinha B");
                Console.WriteLine("0-Voltar ao menu anterior");
                op = int.Parse(Console.ReadLine());

                if (op == 1) {

                    RaspadinhaA();
                }

                else if (op == 2) {

                    RaspadinhaB();
                }

                else if (op != 0){

                    Console.WriteLine("Opção inválida");
                    Console.ReadKey(); }    
                }
            }

        private static void RaspadinhaA()
        {
            Console.Clear();

            if (saldo - 2 < 0)
            {
                Console.WriteLine("Saldo insuficiente! Realize um deposito antes de jogar.");
                Console.ReadKey();
                return;
            }

            saldo -= 2;

            int nprincipal = rnd.Next(1, 10);
            int n1 = rnd.Next(1,10);    int p1 = rnd.Next(1, 10);
            int n2 = rnd.Next(1,10);    int p2 = rnd.Next(1, 10);
            int n3 = rnd.Next(1, 10);   int p3 = rnd.Next(1, 10);
            int n4 = rnd.Next(1, 10);   int p4 = rnd.Next(1, 10);
            int n5 = rnd.Next(1, 10);   int p5 = rnd.Next(1, 10);

            Console.WriteLine("Número principal: " + nprincipal);
            Console.WriteLine("1° número: " + n1 + "("+  p1 +")");
            Console.WriteLine("2° número: " + n2 + "(" + p2 + ")");
            Console.WriteLine("3° número: " + n3 + "(" + p3 + ")");
            Console.WriteLine("4° número: " + n4 + "(" + p4 + ")");
            Console.WriteLine("5° número: " + n5 + "(" + p5 + ")");

            int premio = 0;
            if (n1 == nprincipal) premio += p1;
            if (n2 == nprincipal) premio += p2;
            if (n3 == nprincipal) premio += p3;
            if (n4 == nprincipal) premio += p4;
            if (n5 == nprincipal) premio += p5;

            Console.WriteLine("O valor do seu prêmio é: " + premio);
            saldo += premio;

            Console.ReadKey();
        }

        private static void RaspadinhaB()
        {
            Console.Clear();

            if (saldo - 2 < 0)
            {
                Console.WriteLine("Saldo insuficiente! Realize um deposito antes de jogar.");
                Console.ReadKey();
                return;
            }

            saldo -= 2;

            int nprincipal = rnd.Next(1, 10);
            int premio = rnd.Next(1, 100);

            int n1 = rnd.Next(1, 10);
            int n2 = rnd.Next(1, 10);
            int n3 = rnd.Next(1, 10);
            int n4 = rnd.Next(1, 10);
            int n5 = rnd.Next(1, 10);
            int n6 = rnd.Next(1, 10);
            int n7 = rnd.Next(1, 10);
            int n8 = rnd.Next(1, 10);
            int n9 = rnd.Next(1, 10);

            int cont = 0;

            if (nprincipal == n1) cont++;
            if (nprincipal == n2) cont++;
            if (nprincipal == n3) cont++;
            if (nprincipal == n4) cont++;
            if (nprincipal == n5) cont++;
            if (nprincipal == n6) cont++;
            if (nprincipal == n7) cont++;
            if (nprincipal == n8) cont++;
            if (nprincipal == n9) cont++;

            Console.WriteLine("Número principal: " + nprincipal + " Premio: " + premio);
            Console.WriteLine(n1 + " " + n2 + " " + n3);
            Console.WriteLine(n4 + " " + n5 + " " + n6);
            Console.WriteLine(n7 + " " + n8 + " " + n9);

            if(cont >= 3)
            {
                Console.WriteLine("Parábens você foi premiado!!!! Ganhou: " + premio);
                saldo += premio;
            }

            else
            {
                Console.WriteLine("Raspadinha não premiada!");
            }

            Console.ReadKey();

        }
    }

}
