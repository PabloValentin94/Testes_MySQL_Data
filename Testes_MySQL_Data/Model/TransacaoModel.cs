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

        public int id { get; set; }

        public string? descricao { get; set; }

        public double valor { get; set; }

        public string? tipo { get; set; }

        public int fk_pessoa { get; set; }

        public TransacaoModel(int id = 0, string descricao = "", double valor = 0.00, string tipo = "Despesa", int fk_pessoa = 0)
        {

            this.id = id;

            this.descricao = descricao;

            this.valor = valor;

            this.tipo = tipo;

            this.fk_pessoa = fk_pessoa;

        }

        public bool Save()
        {

            TransacaoDAO dao = new TransacaoDAO();

            return (this.id == 0) ? dao.Insert(this) : dao.Update(this);

        }

        public static List<TransacaoModel> List()
        {

            return (new TransacaoDAO()).Select();

        }

    }

}