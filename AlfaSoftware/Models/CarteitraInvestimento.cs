using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AlfaSoftware.Models
{
    public class CarteitraInvestimento
    {
        [Key]
        public int NrCarteira { get; set; }
        public string Investir { get; set; }
        /*FK
        public int InvestimentosId { get; set; }
        public int ClientePFId { get; set; }
        public int LoginId { get; set; }*/

        public CarteitraInvestimento() { }

        public CarteitraInvestimento(int nrCarteira, string investir)
        {
            
            NrCarteira = nrCarteira;
            Investir = investir;
        }
    }
}
