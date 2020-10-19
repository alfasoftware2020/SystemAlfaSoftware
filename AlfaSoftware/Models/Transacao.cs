
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.ComponentModel.DataAnnotations;

namespace AlfaSoftware.Models
{
    public class Transacao
    {
        [Key]
        public int Idtran{ get; set; }
        public DateTime DataEnviou { get; set; }
        public DateTime DataEntrega { get; set; }
        public string TipoTransacao { get; set; }
        //FK
        public int ClientePFId { get; set; }
        public int CarteiraId { get; set; }
        //Associação
        public ClientePF ClientesPF { get; set; }

        public Transacao(int idtran, DateTime dataEnviou, DateTime dataEntrega, string tipoTransacao)
        {
            Idtran = idtran;
            DataEnviou = dataEnviou;
            DataEntrega = dataEntrega;
            TipoTransacao = tipoTransacao;
           
        }
    }
}
