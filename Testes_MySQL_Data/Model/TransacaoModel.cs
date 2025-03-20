using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Testes_MySQL_Data.DAO;

namespace Testes_MySQL_Data.Model
{

    public class TransacaoModel
    {

        public int id { get; set; } = 0;

        public string? descricao { get; set; } = "";

        public double valor { get; set; } = 0.00;

        public string? tipo { get; set; } = "Despesa";

        public int fk_pessoa { get; set; } = 0;

        public TransacaoModel(string descricao, double valor, string tipo, int fk_pessoa)
        {

            this.descricao = descricao;

            this.valor = valor;

            this.tipo = tipo;

            this.fk_pessoa = fk_pessoa;

        }

        public bool Save()
        {

            return (new TransacaoDAO()).Insert(this);

        }

    }

}