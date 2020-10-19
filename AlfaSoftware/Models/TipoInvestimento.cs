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

        //Fk 
        public int Investimento { get; set; }



        public TipoInvestimento() { }

        public TipoInvestimento(int tpId, string modInvestimento, int nmInvestimento)
        {
            TpId = tpId;
            ModInvestimento = modInvestimento;
            NmInvestimento = nmInvestimento;
            
        }
    }


}
