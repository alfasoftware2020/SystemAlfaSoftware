using AlfaSoftware.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
namespace AlfaSoftware.Models
{
    [Table("TB_ClientePF")]
    public class ClientePF 
    {
        public int Id { get; set; }
        
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public int Telefone { get; set; }
        public string Email { get; set; }
        public Status Status { get; set; }
        public DateTime Data { get; set; }

        //FK
        public int LoginId { get; set; }
        public ICollection<Investimentos> Investimento { get; set; } = new List<Investimentos>();
        public ICollection<Transacao> Transacao { get; set; } = new List<Transacao>();
        
        public ClientePF() { }

        public ClientePF(int id, string nome, string email, int telefone, Status status, DateTime data)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Telefone = telefone;
            Status = status;
            Data = data;
        }

        public void AddInvestimento(Investimentos investimentos) //Esse metodo faz com que adicione um investimento ao cliente 
        {
            Investimento.Add(investimentos);
        }
        
        public void RemoveInvestimentos(Investimentos investimentos)// Esse 
        {
            Investimento.Remove(investimentos);
        }
        public void AddTransacao(Transacao transacao) //Esse metodo faz com que adicione um investimento ao cliente 
        {
            Transacao.Add(transacao);
        }

        public void RemoveTransacao(Transacao transacao)// Esse 
        {
            Transacao.Remove(transacao);
        }
        /*public double TotalIvestimentos(DateTime initial, DateTime final) //Vai retornar o total investido
        {
            return Sales.Where(sr => sr.Date >= initial && sr.Date <= final).Sum(sr => sr.Amount);
        }*/


    }
}
