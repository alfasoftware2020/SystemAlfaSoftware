using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AlfaSoftware.Models
{
    public class Conta : SaldoConta
    {
        [Key]
        public bool NrConta { get; set; }
        public string TipoDaConta { get; set; }
        public decimal SaldoAtual { get; set; }
        public decimal Depositar { get; set; }
        public decimal Saque { get; set; }


        public Conta() { }
        public Conta( bool nrConta, string tipoDaConta, decimal saldoAtual)
        {
          
            NrConta = nrConta;
            TipoDaConta = tipoDaConta;
            SaldoAtual = saldoAtual;
        }

       
    }
}
