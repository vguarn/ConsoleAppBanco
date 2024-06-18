using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace ConsoleAppBanco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string resposta = "SIM";
            double saldo = 0;
            Console.WriteLine("Qual é o seu saldo disponível? ");
         
            Console.WriteLine("Qual operação você deseja realizar? 1- Efetuar depósito, 2- Efetuar saque, 3- Efetuar pagamento, 4- Consultar saldo ");
            int operacao = int.Parse(Console.ReadLine());

            switch (operacao)
            {
                case 1:
                    Deposito();
                    break;
                case 2:
                    Saque();
                    break;
                case 3:
                    Pagamento();
                    break;
                case 4:
                    Console.WriteLine("O saldo disponível é de R$" + saldo);
                    break;
            }

            Console.WriteLine("Deseja continuar? ");
            resposta = Console.ReadLine().ToUpper();
        }

        static void Deposito()
        {
            double saldo = 0;
            Console.WriteLine("Qual é o seu saldo disponível? ");
            saldo++;
            Console.WriteLine("Qual o valor que você deseja depositar? ");
            double deposito = double.Parse(Console.ReadLine());
            double saldodeposito = saldo + deposito;
            Console.WriteLine("O valor foi depositado! ");
            Console.WriteLine("Seu saldo atual é de R$" + saldodeposito);
        }
        static void Saque()
        {
            double saldo = 0;
            Console.WriteLine("Qual é o seu saldo disponível? ");
            saldo++;
            Console.WriteLine("Qual o valor que você deseja sacar? ");
            double vs = double.Parse(Console.ReadLine());
            if (vs < saldo)
            {
               double saldosaque = saldo - vs;
                Console.WriteLine("O saque de R$" + vs + " foi realizado com sucesso!");
                Console.WriteLine("O saldo disponível é de R$" + saldosaque);
            }
            else
            {
                Console.WriteLine("Não foi possível realizar o saque. Saldo indisponível ");
            }
        }
        static void Pagamento()
        {
            double saldo = 0;
            Console.WriteLine("Qual é o seu saldo disponível? ");
            saldo++;
            Console.WriteLine("Qual o valor que você deseja pagar? ");
            double vp = double.Parse(Console.ReadLine());
            if (vp < saldo)
            {
                double saldopagamento = saldo - vp;
                Console.WriteLine("O pagamento de R$" + vp + " foi realizado com sucesso!");
                Console.WriteLine("O saldo disponível é de R$" + saldopagamento);
            }
            else
            {
                Console.WriteLine("Não foi possível realizar o saque. Saldo indisponível ");
            }
        }
    }
}
