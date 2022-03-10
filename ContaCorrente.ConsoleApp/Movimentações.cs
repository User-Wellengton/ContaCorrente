using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaCorrente.ConsoleApp
{
    public class Movimentacoes
    {
        public double saldo;
        public double valor;
        public TipoMovimentacao tipo;
        

        public enum TipoMovimentacao
        {
            Saque, Deposito, Tranferencia
        }




    }
}
