
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
        
    }
}
