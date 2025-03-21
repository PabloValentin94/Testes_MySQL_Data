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

        public int id { get; set; }

        public string? nome { get; set; }

        public int idade { get; set; }

        public PessoaModel(int id = 0, string nome = "", int idade = 0)
        {

            this.id = id;

            this.nome = nome;

            this.idade = idade;

        }

        public bool Save()
        {

            PessoaDAO dao = new PessoaDAO();

            return (this.id == 0) ? dao.Insert(this) : dao.Update(this);

        }

        public static bool Erase(int id)
        {

            return (new PessoaDAO()).Delete(id);

        }

        public static List<PessoaModel> List()
        {

            return (new PessoaDAO()).Select();

        }

        public static PessoaModel? Find(int id)
        {

            return (new PessoaDAO()).Search(id);

        }

    }

}