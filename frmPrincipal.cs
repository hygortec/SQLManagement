using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics;

namespace SQLManagement
{
    public partial class frmPrincipal : MetroFramework.Forms.MetroForm
    {
        bool isDebug = false;
        SqlConnection Conexao;
        DataTable Dados;
        DataTable Estrutura;
        DataTable EstruturaTabelaFiltro;
        string NomeTabelaSelecionada;

        public frmPrincipal()
        {
            InitializeComponent();
            ConfiguraDebug();
        }


        public DataTable ExecultaConsulta(string query)
        {
            try
            {
                if (Conexao != null ? Conexao.State != ConnectionState.Open : true)
                    throw new Exception("Conexão fechada");

                SqlCommand command = new SqlCommand(query, Conexao);
                var table = new DataTable();

                SqlDataReader reader = command.ExecuteReader();
                table.Load(reader);

                command.CommandText = query;

                reader = command.ExecuteReader(CommandBehavior.KeyInfo);
                Estrutura = reader.GetSchemaTable();

                reader.Close();
                return table;
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

        private void CarregaGrid(DataTable dados)
        {
            gridResultado.DataSource = dados;
        }

        private bool ConectarBanco()
        {

            if (Conexao != null ? Conexao.State == ConnectionState.Open : false)
                return true;

            string connectionString = GetConnectionString();

            Conexao = new SqlConnection();
            Conexao.ConnectionString = connectionString;
            Conexao.Open();
            return true;
        }

        private string GetConnectionString()
        {
            var str = String.Format("Persist Security Info=False; User ID = {0}; Password = {1}; Initial Catalog = {2}; Server = {3}",
                         txtUsuario.Text, txtSenha.Text, txtBanco.Text, txtServidor.Text);
            return str;
        }

        private void teste()
        {

            SqlCommand cmd = new SqlCommand();

            DataTable schemaTable;
            SqlDataReader myReader;

            //Retrieve records from the Employees table into a DataReader.
            cmd.Connection = Conexao;
            cmd.CommandText = txtQuery.Text;

            myReader = cmd.ExecuteReader(CommandBehavior.KeyInfo);

            //Retrieve column schema into a DataTable.
            schemaTable = myReader.GetSchemaTable();

            gridSchema.DataSource = schemaTable;

            //For each field in the table...
            //foreach (DataRow myField in schemaTable.Rows)
            //{
            //    //For each property of the field...
            //    foreach (DataColumn myProperty in schemaTable.Columns)
            //    {
            //        //Display the field name and value.
            //        Console.WriteLine(myProperty.ColumnName + " = " + myField[myProperty].ToString());
            //    }
            //    Console.WriteLine();

            //    //Pause.
            //    Console.ReadLine();
            //}

            //Always close the DataReader and connection.
            myReader.Close();

        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ConectarBanco())
                {
                    txtStatusConexao.Text = "Conectado";
                    status.BackColor = Color.CornflowerBlue;

                    ListaTabelas(null);
                }
                else
                {
                    txtStatusConexao.Text = "Desconectado";
                    status.BackColor = Color.Red;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message.ToString());
            }
        }

        private void btnExecultar_Click(object sender, EventArgs e)
        {
            try
            {
                Dados = ExecultaConsulta(txtQuery.Text);
                CarregaGrid(Dados);
                gridSchema.DataSource = Estrutura;

                this.Cursor = Cursors.Arrow;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message.ToString());
            }
        }

        private void gridResultado_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //var NomeColuna = gridResultado.Columns[e.ColumnIndex].HeaderText;
            //var DadosColuna = this.gridResultado.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
        }

        private void ListaTabelas(string _Tabela, string _Campo)
        {
            var lista = BuscarTabelasCampos2(_Tabela, _Campo).AsEnumerable();

            var group = lista.GroupBy(p => p["Tabela"]);

            treeViewTabelas.Nodes.Clear();

            TreeNode nodePai = new TreeNode("Tabelas");

            foreach (var row in group)
            {
                TreeNode nodoTabelas = new TreeNode(row.Key.ToString());

                foreach (var o in row)
                {
                    var s = o["Coluna"];
                    nodoTabelas.Nodes.Add(s.ToString());
                }
                nodePai.Nodes.Add(nodoTabelas);
            }

            treeViewTabelas.Nodes.Add(nodePai);
            if (_Tabela != null && _Campo != null)
            {
                treeViewTabelas.ExpandAll();
                treeViewTabelas.SelectedNode = nodePai;
            }
        }

        private void ListaTabelas(string str)
        {
            ListaTabelas(str, str);
        }

        private DataTable BuscarTabelasCampos(string _Tabela, string _Campo)
        {
            if (_Tabela == null)
                _Tabela = "";
            if (_Campo == null)
                _Campo = "";
            
            // var query = "SELECT T.NAME AS TABELA, T.XTYPE AS TIPO FROM sys.sysobjects AS T (NOLOCK) WHERE T.XTYPE in('U','V') ORDER BY T.NAME";
            var query = "SELECT T.NAME AS Tabela, T.TYPE AS Tipo, C.NAME AS Coluna " +
                         "FROM sys.sysobjects AS T(NOLOCK) " +
                         "INNER JOIN sys.all_columns AS C(NOLOCK) ON T.id = C.object_id AND T.XTYPE IN('U') " +
                         String.Format("WHERE T.NAME like '%{0}%' OR C.NAME like '%{1}%'", _Tabela, _Campo) +
                         "ORDER BY T.NAME ASC, C.NAME";

            SqlCommand command = new SqlCommand(query, Conexao);
            DataTable Campos = new DataTable();

            SqlDataReader reader = command.ExecuteReader();
            Campos.Load(reader);

            return Campos;
        }

        private DataTable BuscarTabelasCampos2(string _Tabela, string _Campo)
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

            foreach(DataRow row in Tabelas.Rows)
            {
                var obj = Campos.Select().FirstOrDefault(p => p["Tabela"].ToString() == row["Tabela"].ToString());
                if(obj == null)
                {

                    DataRow dt = Campos.NewRow();
                    dt["Tabela"] = row["Tabela"].ToString();
                    dt["Coluna"] = "";
                    Campos.Rows.Add(dt);
                }
            }
            return Campos;
        }

        private DataTable BuscarCampos(string _Tabela)
        {
            if (_Tabela == null)
                _Tabela = "";

            var query = "SELECT T.NAME AS Tabela, C.NAME AS Coluna " +
                         "FROM sys.sysobjects AS T(NOLOCK) " +
                         "INNER JOIN sys.all_columns AS C(NOLOCK) ON T.id = C.object_id AND T.XTYPE IN('U') " +
                         String.Format("WHERE T.NAME = '{0}'", _Tabela) +
                         " ORDER BY C.column_id";



            SqlCommand command = new SqlCommand(query, Conexao);
            DataTable table = new DataTable();

            SqlDataReader reader = command.ExecuteReader();
            table.Load(reader);

            return table;
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void treeViewTabelas_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                if (e.Node.Parent != null ? e.Node.Parent.Text.Equals("Tabelas") : false)
                {
                    var dt = BuscarCampos(e.Node.Text);
                    dt.Columns.Add("Filtro", typeof(String));
                    //dt.Columns.Add("OU", typeof(String));

                    gridTabela.DataSource = dt;

                    NomeTabelaSelecionada = dt.Select().GroupBy(p => p["Tabela"].ToString()).First().Key;
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            catch(Exception ex1)
            {
                MessageBox.Show(ex1.Message.ToString());
            }
        }

        private void tabQuery_Click(object sender, EventArgs e)
        {

        }

        private void txtPesquisaNome_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (txtPesquisaNome.Text.Equals(""))
                        ListaTabelas(null);
                    else
                        ListaTabelas(txtPesquisaNome.Text);

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message.ToString());
            }
        }

        private void btnBuscarCriteiro_Click(object sender, EventArgs e)
        {
            try
            {
                if (NomeTabelaSelecionada == null)
                    return;

                string query = "SELECT * FROM " + NomeTabelaSelecionada;
                string where = String.Empty;

                SqlCommand command = new SqlCommand(query, Conexao);
                var table = new DataTable();

                SqlDataReader reader = command.ExecuteReader(CommandBehavior.KeyInfo);
                EstruturaTabelaFiltro = reader.GetSchemaTable();
                reader.Close();

                foreach (DataGridViewRow row in gridTabela.Rows)
                {
                    if (row.Cells["Filtro"].Value != null ? !row.Cells["Filtro"].Value.ToString().Equals("") : false)
                    {
                        if (where.Length > 0)
                            where += " AND ";

                        var stringtipo = EstruturaTabelaFiltro.Select().FirstOrDefault(p => p["ColumnName"].ToString() == row.Cells["Coluna"].Value.ToString())["DataType"].ToString();
                        var tipo = Type.GetType(stringtipo);
                        if (tipo == typeof(String))
                            where += row.Cells["Coluna"].Value.ToString() + " = '" + row.Cells["Filtro"].Value.ToString() + "'";
                        else
                            where += row.Cells["Coluna"].Value.ToString() + " = " + row.Cells["Filtro"].Value.ToString();
                    }
                }

                if (where.Length > 0)
                    query += " WHERE " + where;

                gridResultadoFiltro.DataSource = this.ExecultaConsulta(query);

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message.ToString());
            }
        }

        private void gridResultadoFiltro_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                
                if (e.RowIndex == gridResultadoFiltro.Rows.Count - 1)
                    return;

                string sql = string.Empty;
                string where = string.Empty;
                var GridRow = gridResultadoFiltro.Rows[e.RowIndex];
                var ListaChaves = EstruturaTabelaFiltro.Select().Where(p => p.Field<bool>("IsKey") == true);
                var TipoCampoAlterar = Type.GetType(EstruturaTabelaFiltro.Select().FirstOrDefault(p => p["ColumnName"].ToString() == gridResultadoFiltro.Columns[e.ColumnIndex].Name)["DataType"].ToString());
                foreach (DataRow chave in ListaChaves)
                {
                    var valorChave = GridRow.Cells[chave["ColumnName"].ToString()].Value;

                    if (where.Length > 0)
                        where += " AND ";

                    var tipo = Type.GetType(chave["DataType"].ToString());
                    if (tipo == typeof(String))
                        where += chave["ColumnName"].ToString() + " = '" + valorChave + "'";
                    else
                        where += chave["ColumnName"].ToString() + " = " + valorChave;
                }

                sql = "UPDATE " + NomeTabelaSelecionada + " SET " + gridResultadoFiltro.Columns[e.ColumnIndex].Name + " = ";

                if (TipoCampoAlterar == typeof(String))
                {
                    var valor = gridResultadoFiltro.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                    sql += "'" + valor + "'";
                }
                else
                    sql += e.ToString();

                sql += " WHERE " + where;

                SqlCommand command = new SqlCommand(sql, Conexao);
                var table = new DataTable();

                SqlDataReader reader = command.ExecuteReader();
                table.Load(reader);

               // btnBuscarCriteiro_Click(null, null);
            }
            catch (SqlException ex)
            {                
                MessageBox.Show(ex.Message.ToString());
            }
            catch (Exception ex1)
            {
                gridResultadoFiltro.CancelEdit();
                MessageBox.Show(ex1.Message.ToString());
            }
        }

        private void MudarCorTexto(RichTextBox m_rtb, string texto, Color cor)
        {
            int varStart = 0;
            int varIndex = 0;
            int varCursor = m_rtb.SelectionStart;

            m_rtb.SelectionColor = Color.Black;

            while ((varIndex != -1) && (varStart < m_rtb.Text.Length))
            {
                varIndex = m_rtb.Find(texto, varStart, RichTextBoxFinds.None);
                if (varIndex != -1)
                {
                    m_rtb.SelectionColor = cor;
                    m_rtb.SelectedText = texto;

                    varStart = varIndex + texto.Length;
                }
            }
            m_rtb.SelectionStart = varCursor;
            m_rtb.SelectionColor = Color.Black;
        }

        private void MudarCorTexto2(RichTextBox m_rtb, string[] texto, Color cor)
        {
            int varStart = 0;
            int varIndex = 0;
            int varCursor = m_rtb.SelectionStart;

            m_rtb.SelectionColor = Color.Black;

            foreach (var str in texto)
            {
                varIndex = m_rtb.Find(str, 0, RichTextBoxFinds.None);
                if (varIndex != -1)
                {
                    m_rtb.SelectionColor = cor;
                    m_rtb.SelectedText = str;

                    varStart = varIndex + texto.Length;
                }
            }

            
            m_rtb.SelectionStart = m_rtb.Text.Length;
            m_rtb.SelectionColor = Color.Black;
        }

        private void txtQuery1_TextChanged(object sender, EventArgs e)
        {
            if (txtQuery1.Text.Length > 0)
                MudarCorTexto(txtQuery1, " select " , Color.Blue);
            // MudarCorTexto2(txtQuery1, new string[] { " select ", " update "}, Color.Blue);
        }

        //Evento TextChanged
        //private void richTextBox1_TextChanged(object sender, EventArgs e)
        //{
        //    if (richTextBox1.Text.Length > 0)
        //        MudarCorTexto(richTextBox1, "void", Color.Red);
        //}

        private void ConfiguraDebug()
        {
            #if DEBUG
                isDebug = true;
            #else
                isDebug = false;
            #endif

            if (!isDebug)
            {
                tabControl.TabPages.Remove(tabDebug);
            }

            if (Environment.MachineName.Equals("DESKTOP-7TMT1VQ"))
            {
                txtServidor.Text = "DESKTOP-7TMT1VQ";
                txtBanco.Text = "BD_COOPERSAG_DEBUG";
                txtUsuario.Text = "SA";
                txtSenha.Text = "zeus@cronos";

                txtQuery.Text = "SELECT * from T003_NotaFiscal INNER JOIN T004_NotaFiscalItem ON T003_NotaFiscal.T003_ID = T004_NotaFiscalItem.T003_IDNota WHERE T003_ID IN(7, 8)";
            }




        }
    }
}
