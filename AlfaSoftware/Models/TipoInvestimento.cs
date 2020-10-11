using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace AlfaSoftware.Models.ViewModels
{
    public class TipoInvestimento 
    {
        [Key]
        public int TpId { get; set; }
        public string ModInvestimento { get; set; }
        public int NmInvestimento { get; set; }
        /*FK
        public int InvestimentosId { get; set; }*/
        public TipoInvestimento() { }

        public TipoInvestimento(string modInvestimento, int nmInvestimento)
        {  
            ModInvestimento = modInvestimento;
            NmInvestimento = nmInvestimento;
        }
    }


}
