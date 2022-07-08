using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SQLManagement
{
    public class Data
    {
        SqlConnection Conexao;    

        private string GetConnectionString(string _Servidor, string _Banco, string _Usuario, string _Senha)
        {
            var str = String.Format("Persist Security Info=False; User ID = {0}; Password = {1}; Initial Catalog = {2}; Server = {3}",
                         _Usuario, _Senha, _Banco, _Servidor);

            return str;
        }

        public bool isConnected()
        {
            if (Conexao != null ? Conexao.State == ConnectionState.Open : false)
                return true;

            return false;
        }

        public SqlConnection getConexao()
        {
            return Conexao;
        }

        public bool ConectarBanco(string _Servidor, string _Banco, string _Usuario, string _Senha)
        {
            if (isConnected())
                Conexao.Close();

            string connectionString = GetConnectionString(_Servidor, _Banco, _Usuario, _Senha);

            Conexao = new SqlConnection();
            Conexao.ConnectionString = connectionString;
            Conexao.Open();
            return true;
        }

        private DataTable BuscarTabelas(string _Tabela, string _Campo)
        {
            if (_Tabela == null)
                _Tabela = "";
            if (_Campo == null)
                _Campo = "";

            // var query = "SELECT T.NAME AS TABELA, T.XTYPE AS TIPO FROM sys.sysobjects AS T (NOLOCK) WHERE T.XTYPE in('U','V') ORDER BY T.NAME";
            var query = "SELECT T.NAME AS Tabela, '' AS Coluna " +
                         "FROM sys.sysobjects AS T(NOLOCK) " +
                         String.Format("WHERE T.XTYPE IN('U') AND T.NAME like '%{0}%'", _Tabela) +
                         "ORDER BY T.NAME ASC";

            SqlCommand command = new SqlCommand(query, Conexao);
            DataTable Tabelas = new DataTable();

            SqlDataReader reader = command.ExecuteReader();
            Tabelas.Load(reader);

            query = "SELECT T.NAME AS Tabela, C.NAME AS Coluna " +
                        "FROM sys.sysobjects AS T(NOLOCK) " +
                        "INNER JOIN sys.all_columns AS C(NOLOCK) ON T.id = C.object_id AND T.XTYPE IN('U') " +
                        String.Format("WHERE C.NAME like '%{0}%'", _Campo) +
                        "ORDER BY T.NAME ASC, C.NAME";

            command = new SqlCommand(query, Conexao);
            DataTable Campos = new DataTable();

            reader = command.ExecuteReader();
            Campos.Load(reader);

            foreach (DataRow row in Tabelas.Rows)
            {
                var obj = Campos.Select().FirstOrDefault(p => p["Tabela"].ToString() == row["Tabela"].ToString());
                if (obj == null)
                {

                    DataRow dt = Campos.NewRow();
                    dt["Tabela"] = row["Tabela"].ToString();
                    dt["Coluna"] = "";
                    Campos.Rows.Add(dt);
                }
            }
            return Campos;
        }

        public DataTable BuscarTodos()
        {
            DataTable Tabelas = new DataTable();

            var query = "SELECT T.name AS Tabela, T.XTYPE AS TipoTabela, C.name AS Coluna " +
                        "FROM sys.sysobjects AS T(NOLOCK) " +
                        "INNER JOIN sys.all_columns AS C(NOLOCK) ON T.id = C.object_id AND T.XTYPE IN('U', 'V') " +
                        "ORDER BY T.name ASC";

            SqlCommand command = new SqlCommand(query, Conexao);
            

            SqlDataReader reader = command.ExecuteReader();
            Tabelas.Load(reader);          

            return Tabelas;
        }

        public DataTable BuscarTabelasOuCampos(string _Tabela, string _Campo)
        {
            if (_Tabela == null)
                _Tabela = "";
            if (_Campo == null)
                _Campo = "";

            var query = "SELECT T.name AS Tabela, T.XTYPE AS TipoTabela, C.name AS Coluna " +
                        "FROM sys.sysobjects AS T(NOLOCK) INNER JOIN sys.all_columns AS C(NOLOCK) ON T.id = C.object_id AND T.XTYPE IN('U', 'V') " +
                        String.Format("WHERE C.NAME LIKE '%{0}%' OR T.name LIKE '%{1}%' ", _Tabela, _Campo) +
                        "ORDER BY T.name ASC";

            SqlCommand command = new SqlCommand(query, Conexao);
            DataTable Tabela = new DataTable();

            SqlDataReader reader = command.ExecuteReader();
            Tabela.Load(reader);

            return Tabela;
        }

        public DataTable BuscarCampos(string _NomePai, bool _isTabela = true)
        {
            if (_NomePai == null)
                _NomePai = "";

            string query;
            if (_isTabela)
            {
                query = "SELECT T.NAME AS Tabela, C.NAME AS Coluna " +
                             "FROM sys.sysobjects AS T(NOLOCK) " +
                             "INNER JOIN sys.all_columns AS C(NOLOCK) ON T.id = C.object_id AND T.XTYPE IN('U') " +
                             String.Format("WHERE T.NAME = '{0}'", _NomePai) +
                             " ORDER BY C.column_id";
            }
            else
            {
                query = "SELECT T.NAME AS Tabela, C.NAME AS Coluna " +
                            "FROM sys.sysobjects AS T(NOLOCK) " +
                            "INNER JOIN sys.all_columns AS C(NOLOCK) ON T.id = C.object_id AND T.XTYPE IN('V') " +
                            String.Format("WHERE T.NAME = '{0}'", _NomePai) +
                            " ORDER BY C.column_id";
            }

            SqlCommand command = new SqlCommand(query, Conexao);
            DataTable table = new DataTable();

            SqlDataReader reader = command.ExecuteReader();
            table.Load(reader);

            return table;
        }

        public DataTablesConsulta ExecultaConsulta(string query)
        {
            try
            {
                DataTablesConsulta retono = new DataTablesConsulta();


                if (Conexao != null ? Conexao.State != ConnectionState.Open : true)
                    throw new Exception("Conexão fechada");

                SqlCommand command = new SqlCommand(query, Conexao);
                var table = new DataTable();

                SqlDataReader reader = command.ExecuteReader();
                retono.Resultado.Load(reader);

                command.CommandText = query;

                reader = command.ExecuteReader(CommandBehavior.KeyInfo);
                retono.Estrutura = reader.GetSchemaTable();

                reader.Close();

                return retono;
            }
            catch (SqlException erro)
            {
                throw erro;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }

    public class DataTablesConsulta
    {
        public DataTable Resultado;
        public DataTable Estrutura;

        public DataTablesConsulta()
        {
            Estrutura = Resultado = new DataTable();
        }
    }




}
