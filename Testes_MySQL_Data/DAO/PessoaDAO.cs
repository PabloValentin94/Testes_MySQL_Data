using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Testes_MySQL_Data.Model;

using MySql.Data.MySqlClient;

namespace Testes_MySQL_Data.DAO
{

    public class PessoaDAO : MySQL_Connection
    {

        public PessoaDAO() : base() {  }

        public bool Insert(PessoaModel model)
        {

            try
            {

                string sql = $"INSERT INTO Pessoa(nome, idade) VALUES('{model.nome}', {model.idade})";

                MySqlCommand stmt = new MySqlCommand(sql, base.conexao);

                base.Abrir_Conexao();

                return (stmt.ExecuteNonQuery() > 0);

            }

            catch (Exception ex)
            {

                throw new Exception(ex.Message);

            }

            finally
            {

                base.Fechar_Conexao();

            }

        }

    }

}