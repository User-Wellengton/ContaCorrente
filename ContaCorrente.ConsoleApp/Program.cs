﻿using System;

namespace ContaCorrente.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta1 = new ContaCorrente();
            conta1.saldo = 0;
            conta1.numero = 0;
            conta1.limite = 0;
            conta1.ehEspecial = true;
           

            conta1.Saque(200);
            conta1.Deposito(100);
            conta1.Deposito(500);
            conta1.Saque(200);


            ContaCorrente conta2 = new ContaCorrente();
            conta2.saldo = 0;
            conta2.numero = 0;
            conta2.limite = 0;
            conta2.ehEspecial = true;
            



            conta1.TransferirPara(conta2, 400);

            conta1.ExibirExtrato();
        }
    }
}