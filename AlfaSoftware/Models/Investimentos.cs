using AlfaSoftware.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AlfaSoftware.Models
{
    public class Investimentos
    {
        [Key]
        public int InvestId { get; set; }
        public TipoInvestimento TipoInvestimento { get; set; }
        public int Quantidade { get; set; }
        public ClientePFModels ClientePf { get; set; }
        public ClientePJ ClientePj{ get; set; }
        
        /*
          FK
          public int ClientePFId { get; set; }*/

        public decimal ValorInvestimento { get; set; }

        public Investimentos() { }

        public Investimentos(int quantidade, decimal valorInvestimento)
        {
            Quantidade = quantidade;
            ValorInvestimento = valorInvestimento;
        }
    }

}
