using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace Testes_MySQL_Data.DAO
{

    public abstract class MySQL_Connection
    {

        protected MySqlConnection? conexao = null;

        public MySQL_Connection()
        {

            string host = "localhost";

            string port = "3306";

            string user = "root";

            string password = "";

            string database_name = "db_controle_gastos_residenciais";

            string dsn = $"datasource={host};port={port};username={user};password={password};database={database_name}";

            this.conexao = new MySqlConnection(dsn);

        }

        public void Abrir_Conexao()
        {

            if (this.conexao != null)
            {

                this.conexao.Open();

            }

        }

        public void Fechar_Conexao()
        {

            if (this.conexao != null)
            {

                this.conexao.Close();

            }

        }

    }

}