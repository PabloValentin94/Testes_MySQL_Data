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

                string sql = "INSERT INTO Pessoa(nome, idade) VALUES(@nome, @idade)";

                MySqlCommand stmt = new MySqlCommand(sql, base.conexao);

                base.Abrir_Conexao();

                stmt.Parameters.AddWithValue("@nome", model.nome);

                stmt.Parameters.AddWithValue("@idade", model.idade);

                stmt.Prepare();

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

        public bool Update(PessoaModel model)
        {

            try
            {

                string sql = "UPDATE Pessoa SET nome = @nome, idade = @idade WHERE id = @id";

                MySqlCommand stmt = new MySqlCommand(sql, base.conexao);

                base.Abrir_Conexao();

                stmt.Parameters.AddWithValue("@nome", model.nome);

                stmt.Parameters.AddWithValue("@idade", model.idade);

                stmt.Parameters.AddWithValue("@id", model.id);

                stmt.Prepare();

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

        public bool Delete(int id)
        {

            try
            {

                string sql = "DELETE FROM Pessoa WHERE id = @id";

                MySqlCommand stmt = new MySqlCommand(sql, base.conexao);

                base.Abrir_Conexao();

                stmt.Parameters.AddWithValue("@id", id);

                stmt.Prepare();

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

                string sql = "SELECT * FROM Pessoa ORDER BY id ASC";

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

        public PessoaModel? Search(int id)
        {

            try
            {

                PessoaModel? pessoa_retornada = null;

                string sql = "SELECT * FROM Pessoa WHERE id = @id";

                MySqlCommand stmt = new MySqlCommand(sql, base.conexao);

                base.Abrir_Conexao();

                stmt.Parameters.AddWithValue("@id", id);

                stmt.Prepare();

                MySqlDataReader reader = stmt.ExecuteReader();

                while (reader.Read())
                {

                    pessoa_retornada = new PessoaModel(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2));

                }

                return pessoa_retornada;

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