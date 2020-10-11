using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AlfaSoftware.Models
{
    public class ClientePJ 
    {
        [Key]
        public int ClientePjId { get; set; }
        public string Cnpj { get; set; }
        public string NomeEmpresa { get; set; }
        
        /*FK
        public int ClientePFId { get; set; }*/
        
        public ClientePJ() { }
        public ClientePJ(string cnpj, string nomeEmpresa)
        {
          
            Cnpj = cnpj;
            NomeEmpresa = nomeEmpresa;
        }
    }

   




}
