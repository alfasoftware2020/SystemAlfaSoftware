using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AlfaSoftware.Models
{
    public class Carteitra
    {
        [Key]
        public int CarteiraId { get; set; }
        public decimal SaldoCarteira { get; set; }
        public decimal UltimoDeposito { get; set; }
        public decimal UltimoSaque { get; set; }
        public decimal Extrato { get; set; }
        public DateTime DataTransacao { get; set; }
        //Associação
        public ClientePF ClientePF { get; set; }
        //FK
        public int ClientePFId { get; set; }


        public Carteitra() { }

        public Carteitra(int carteiraId, decimal saldoCarteira, decimal ultimoDeposito, decimal ultimoSaque, decimal extrato, DateTime dataTransacao, ClientePF clientePF)
        {
            CarteiraId = carteiraId;
            SaldoCarteira = saldoCarteira;
            UltimoDeposito = ultimoDeposito;
            UltimoSaque = ultimoSaque;
            Extrato = extrato;
            DataTransacao = dataTransacao;
            ClientePF = clientePF;
        }
    }
}
