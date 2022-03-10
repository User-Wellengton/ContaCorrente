using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaCorrente.ConsoleApp
{
    public class ContaCorrente
    {
        public double saldo;
        public int numero;
        public double limite;
        public bool ehEspecial;
        public Movimentacoes[] movimentacao = new Movimentacoes[10];
        int contador = 0;



        public double Saque(double saldoSaque)
        {
            movimentacao[contador] = new Movimentacoes();


            if (saldoSaque > saldo + limite)
            {
                Console.WriteLine("Não é possivel fazer o saque, seu saldo é insuficiente!!!");
            }
            else
            {
                movimentacao[contador].tipo = Movimentacoes.TipoMovimentacao.Saque;

                movimentacao[contador].valor = saldoSaque;

                movimentacao[contador].saldo = saldo;

                contador++;
                Console.WriteLine("Saque efetuado com sucesso!!!");
            }


            return saldo;
        }


        public double Deposito(double saldoDeposito)
        {
            saldo += saldoDeposito;

            movimentacao[contador] = new Movimentacoes();

            movimentacao[contador].tipo = Movimentacoes.TipoMovimentacao.Deposito;

            movimentacao[contador].valor = saldoDeposito;

            movimentacao[contador].saldo = saldo;
            
            contador++;
            return saldo;
        }

        public void TransferirPara(ContaCorrente conta, double tranferencia)
        {

            movimentacao[contador] = new Movimentacoes();

            saldo -= tranferencia;
            conta.saldo += tranferencia;

            movimentacao[contador].tipo = Movimentacoes.TipoMovimentacao.Tranferencia;

            movimentacao[contador].valor = tranferencia;

            movimentacao[contador].saldo = saldo;

            contador++;

        }

        public void ExibirExtrato()
        {

            if (ehEspecial == true)
            {
                Console.WriteLine("Conta especial.");
            }
            else
            {
                Console.WriteLine("Conta não especial");
            }

            for (int i = 0; i < contador; i++)
            {
                Console.WriteLine("----------------------------------------------------------");
                Console.WriteLine("O tipo é: " + movimentacao[i].tipo);
                Console.WriteLine("O saldo da conta é: " + movimentacao[i].saldo);
                Console.WriteLine("O valor é: R$" + movimentacao[i].valor);


            }


            
        }





    }
}
