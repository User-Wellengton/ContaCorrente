using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaCorrente.ConsoleApp
{
    public class Movimentacoes
    {
        private double _saldo;
        private double _valor;
        private TipoMovimentacao _tipo;


        public double Saldo
        {
            get { return _saldo; }
            set { _saldo = value; }
        }

        public double Valor
        {
            get { return _valor; }
            set { _valor = value; }
        }

        public TipoMovimentacao Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }

        public enum TipoMovimentacao
        {
            Saque, Deposito, Tranferencia
        }




    }
}
