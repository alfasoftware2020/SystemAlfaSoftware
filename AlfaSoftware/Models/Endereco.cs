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
       /*FK
        public int ClientePFId { get; set; }*/
        public ClientePFModels ClientePFModels { get; set; }
        public Endereco() { 
        }

        public Endereco(string cep, string rua, string complemento, string bairro, string cidade)  {
                       
            Cep = cep;
            Rua = rua;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
        }
    }
}
