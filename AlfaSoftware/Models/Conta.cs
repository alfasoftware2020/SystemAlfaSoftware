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
        //FK
        public int ClientePFId { get; set; }
        //Associação
        public ClientePF ClientePF { get; set; }
        public SaldoConta SaldoConta { get; set; }
        public Conta() { }
        public Conta(double saldocontaId, decimal saldo, Conta conta, bool nrConta, string tipoDaConta, decimal saldoAtual, ClientePF clientePF, SaldoConta saldoConta) 
            : base (saldocontaId, saldo, conta)
        {
            NrConta = nrConta;
            TipoDaConta = tipoDaConta;
            SaldoAtual = saldoAtual;
            ClientePF = clientePF;
            SaldoConta = saldoConta;
        }
        


    }
}
