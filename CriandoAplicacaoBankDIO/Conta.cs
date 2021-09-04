using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriandoAplicacaoBankDIO
{
    public class Conta
    {
        private string nome { get; set; };
        private TipoConta TipoConta { get; set; };
        private double saldo { get; set; };
        private double Credito { get; set; };

        public Conta(TipoConta TipoConta, double saldo, double credito, string nome,);
        {
            this.TipoConta = TipoConta;
            this.saldo = saldo;
            this.credito = credito;
            this.nome = nome;
        }
    }
}
