using AlfaSoftware.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
namespace AlfaSoftware.Models
{
    public class ClientePFModels : ClientePJ
    {
        public int Id { get; set; }
        
        public string Nome { get; set; }
        public DateTime Date { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Profissao { get; set; }
        //Associação
        public Conta Conta { get; set; }
        public Login Login { get; set; }
        public Endereco Endereco { get; }
        /*FK 
        public ClientePJ ClientePJId { get; set; }*/

        public ICollection<Investimentos> Investimentos { get; set; } = new List<Investimentos>();
        public ICollection<Transacao> Transacao { get; set; } = new List<Transacao>();
        public ClientePFModels() { }

        public ClientePFModels(int id, Endereco endereco, string nome, DateTime date, string cpf, string email, string profissao)
        {
            Id = id;
            Endereco = endereco;
            Nome = nome;
            Date = date;
            Cpf = cpf;
            Email = email;
            Profissao = profissao;
            
        }
    }
}
