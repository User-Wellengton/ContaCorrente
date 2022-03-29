using System;

namespace ContaCorrente.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta1 = new ContaCorrente();
            conta1.Saldo = 1000;
            conta1.Numero = 11;
            conta1.Limite = 0;
            conta1.EhEspecial = true;
           

            conta1.Saque(200);
            conta1.Deposito(100);
            conta1.Deposito(500);
            conta1.Saque(200);


            ContaCorrente conta2 = new ContaCorrente();
            conta2.Saldo = 300;
            conta2.Numero = 10;
            conta2.Limite = 0;
            conta2.EhEspecial = true;
            



            conta1.TransferirPara(conta2, 400);

            conta1.ExibirExtrato();


            Console.ReadLine();
        }
    }
}
