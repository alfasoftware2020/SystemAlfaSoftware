using System;
using System.ComponentModel.DataAnnotations;
using AlfaSoftware.Models.Enums;
using System.Linq;
using System.Threading.Tasks;

namespace AlfaSoftware.Models
{
    public class ClientePJ : ClientePF 
    {
        [Key]
        public int ClientePjId { get; set; }
        public string Cnpj { get; set; }
        public string NomeEmpresa { get; set; }
        //FK
        public int ClientePFId { get; set; }
        //Associação
        public ClientePF ClientePF { get; set; }



        public ClientePJ() { }
        public ClientePJ(ClientePF clientesPF,int id, string nome, DateTime data, string cpf, string email, int telefone, Endereco endereco, Status status, string cnpj, string nomeEmpresa)
            : base (id, nome, email, telefone, status, data)
        {
            ClientePF = clientesPF;
            Cnpj = cnpj;
            NomeEmpresa = nomeEmpresa;

        }
    }
}


   





