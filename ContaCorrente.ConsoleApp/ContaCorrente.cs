using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaCorrente.ConsoleApp
{
    public class ContaCorrente
    {
        private double _saldo;
        private int _numero;
        private double _limite;
        private bool _ehEspecial;
        private Movimentacoes[] movimentacao = new Movimentacoes[10];
        private int contador = 0;



        public double Saldo
        {
            set { _saldo = value; }
        }

        public int Numero
        {
            set { _numero = value; }
        }

        public double Limite
        {
            set { _limite = value; }
        }

        public bool EhEspecial
        {
            set { _ehEspecial = value; }
        }

        public double Saque(double saldoSaque)
        {
            movimentacao[contador] = new Movimentacoes();


            if (saldoSaque > _saldo + _limite)
            {
                Console.WriteLine("Não é possivel fazer o saque, seu saldo é insuficiente!!!");
            }
            else
            {
                movimentacao[contador].Tipo = Movimentacoes.TipoMovimentacao.Saque;

                movimentacao[contador].Valor = saldoSaque;

                movimentacao[contador].Saldo = _saldo;

                contador++;
                Console.WriteLine("Saque efetuado com sucesso!!!");
            }


            return _saldo;
        }


        public double Deposito(double saldoDeposito)
        {
            _saldo += saldoDeposito;

            movimentacao[contador] = new Movimentacoes();

            movimentacao[contador].Tipo = Movimentacoes.TipoMovimentacao.Deposito;

            movimentacao[contador].Valor = saldoDeposito;

            movimentacao[contador].Saldo = _saldo;
            
            contador++;
            return _saldo;
        }

        public void TransferirPara(ContaCorrente conta, double tranferencia)
        {

            movimentacao[contador] = new Movimentacoes();

            _saldo -= tranferencia;
            conta._saldo += tranferencia;

            movimentacao[contador].Tipo = Movimentacoes.TipoMovimentacao.Tranferencia;

            movimentacao[contador].Valor = tranferencia;

            movimentacao[contador].Saldo = _saldo;

            contador++;

        }

        public void ExibirExtrato()
        {

            if (_ehEspecial == true)
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
                Console.WriteLine("O tipo é: " + movimentacao[i].Tipo);
                Console.WriteLine("O saldo da conta é: " + movimentacao[i].Saldo);
                Console.WriteLine("O valor é: R$" + movimentacao[i].Valor);

            }


            
        }





    }
}
