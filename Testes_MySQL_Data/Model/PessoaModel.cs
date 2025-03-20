using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Testes_MySQL_Data.DAO;

namespace Testes_MySQL_Data.Model
{

    public class PessoaModel
    {

        public int id { get; set; } = 0;

        public string? nome { get; set; } = "";

        public int idade { get; set; } = 0;

        public PessoaModel(string nome, int idade)
        {

            this.nome = nome;

            this.idade = idade;

        }

        public bool Save()
        {

            return (new PessoaDAO()).Insert(this);

        }

    }

}