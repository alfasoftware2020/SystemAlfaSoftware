using AlfaSoftware.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AlfaSoftware.Models
{
    public class Investimentos : TipoInvestimento
    {

        public int InvestId { get; set; }
        public int Quantidade { get; set; }
        //FK
        public int ClientePFId { get; set; }
        public int TransacaoId { get; set; }
        //Associação
        public ClientePF ClientePF { get; set; }
        //public ClientesPF ClientesPF { get; set; }
        public TipoInvestimento TipoInvestimento { get; set; }
        public decimal ValorInvestimento { get; set; }


        public Investimentos() { }

        public Investimentos(ClientePF clientePF, int tpId, string modInvestimento, int nmInvestimento, int investId, int quantidade, ClientePF clientesPF, TipoInvestimento tipoInvestimento, decimal valorInvestimento)
            : base ( tpId, modInvestimento, nmInvestimento)

        {
            InvestId = investId;
            Quantidade = quantidade;
            TipoInvestimento = tipoInvestimento;
            ValorInvestimento = valorInvestimento;
            ClientePF = clientePF;
        }




       /* public void AddClientesPF(ClientesPF clientesPF) //Esse metodo faz com que adicione um investimento ao cliente 
        {
            ClientesPF.Add(clientesPF);
        }

        public void RemoveInvestimentos(ClientesPF clientesPF)// Esse 
        {
            ClientesPF.Remove(clientesPF);
        }*/

    }

}
