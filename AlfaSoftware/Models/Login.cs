using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AlfaSoftware.Models
{
    public class Login
    {
        [Key]
        public int LoginId { get; set; }
        public string Senha { get; set; }
        public string LoginCliente { get; set; }

        //FK
        public int ClientePFId { get; set; }
        public int ClientePJId { get; set; }
        //Associação
       
       


        public Login() { }

        public Login(string senha, string loginCliente)
        {
            Senha = senha;
            LoginCliente = loginCliente;
        }
    }
}
