using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Testes_MySQL_Data.Model;

using MySql.Data.MySqlClient;

namespace Testes_MySQL_Data.DAO
{

    public class TransacaoDAO : MySQL_Connection
    {

        public TransacaoDAO() : base() {  }

        public bool Insert(TransacaoModel model)
        {

            try
            {

                string sql = $"INSERT INTO Transacao(descricao, valor, tipo, fk_pessoa) VALUES('{model.descricao}', {model.valor}, '{model.tipo}', {model.fk_pessoa})";

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

        public List<TransacaoModel> Select()
        {

            try
            {

                List<TransacaoModel> lista_transacoes = new List<TransacaoModel>();

                string sql = "SELECT * FROM Transacao";

                MySqlCommand stmt = new MySqlCommand(sql, base.conexao);

                base.Abrir_Conexao();

                MySqlDataReader reader = stmt.ExecuteReader();

                while (reader.Read())
                {

                    lista_transacoes.Add(new TransacaoModel(reader.GetInt32(0), reader.GetString(1), reader.GetDouble(2), reader.GetString(3), reader.GetInt32(4)));

                }

                return lista_transacoes;

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