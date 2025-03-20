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

        public List<PessoaModel> Select()
        {

            try
            {

                List<PessoaModel> lista_pessoas = new List<PessoaModel>();

                string sql = "SELECT * FROM Pessoa";

                MySqlCommand stmt = new MySqlCommand(sql, base.conexao);

                base.Abrir_Conexao();

                MySqlDataReader reader = stmt.ExecuteReader();

                while (reader.Read())
                {

                    lista_pessoas.Add(new PessoaModel(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2)));

                }

                return lista_pessoas;

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