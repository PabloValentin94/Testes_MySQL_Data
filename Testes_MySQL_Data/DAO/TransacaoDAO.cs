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

    }

}