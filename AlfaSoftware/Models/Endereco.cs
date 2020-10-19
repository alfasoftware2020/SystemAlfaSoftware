using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AlfaSoftware.Models
{
    public class Endereco
    {
        [Key]
        public int EndId { get; set; }
        public string Cep { get; set; }
        public string Rua { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }

        //FK
        public int ClientePFId { get; set; }

        //Associação
        public ClientePF ClientePF { get; set; }
        
        public Endereco() { 
        }

        public Endereco(int endId, string cep, string rua, string complemento, string bairro, string cidade, ClientePF clientePF)
        {
            EndId = endId;
            Cep = cep;
            Rua = rua;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            ClientePF = clientePF;
        }
    }
}
