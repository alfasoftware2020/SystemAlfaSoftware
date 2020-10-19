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
        public ClientePF ClientePF { get; set; }

        public Login() { }

        public Login(int loginId, string senha, string loginCliente, ClientePF clientePF)
        {
            LoginId = loginId;
            Senha = senha;
            LoginCliente = loginCliente;
            ClientePF = clientePF;
        }
    }
}
