using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AlfaSoftware.Models
{
    public class SaldoConta 
    {
        
        public double SaldocontaId{ get; set; }
        public decimal Saldo { get; set; }
        public Conta Conta { get; set; }
        //FK
        public int ContaId { get; set; }
        public SaldoConta() { }

        public SaldoConta(double saldocontaId, decimal saldo, Conta conta)
        {
            SaldocontaId = saldocontaId;
            Saldo = saldo;
            Conta = conta;
        }
    }
}
