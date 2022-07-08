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
    public partial class frmSQLManagement : MetroFramework.Forms.MetroForm
    {
        bool isDebug = false;

        Data DataBase = new Data();

        SqlConnection Conexao;
        DataTable Dados;
        DataTable EstruturaConsulta;
        DataTable EstruturaTabelaFiltro;
        DataTable EstruturaTabelaQuery;
        string NomeTabelaSelecionada;

        public frmSQLManagement()
        {
            InitializeComponent();
            tabControl.Enabled = false;
            tabControl.SelectedTab = tabPrincipal;
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
                EstruturaConsulta = reader.GetSchemaTable();

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
            gridResultadoQuery.DataSource = dados;
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
                DataBase.ConectarBanco(txtServidor.Text, txtBanco.Text, txtUsuario.Text, txtSenha.Text);

                if (DataBase.isConnected())
                {
                    txtStatusConexao.Text = "Conectado";
                    status.BackColor = Color.CornflowerBlue;
                    CarregaTreeView(DataBase.BuscarTodos());

                    gridResultadoFiltro.DataSource = null;
                    gridResultadoQuery.DataSource = null;
                    gridTabela.DataSource = null;
                    tabControl.Enabled = true;
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

        private void CarregaTreeView(DataTable _Dados)
        {
            var group = _Dados.Select().GroupBy(p => p["TipoTabela"]).OrderBy(p => p.Key);

            treeViewTabelas.Nodes.Clear();

            foreach (var gpTipo in group)
            {
                TreeNode nodesTipo;
                if (gpTipo.Key.Equals("U "))
                {
                    nodesTipo = new TreeNode("Tabelas");
                    nodesTipo.Name = "Tabelas";
                }
                else
                {
                    nodesTipo = new TreeNode("Views");
                    nodesTipo.Name = "Views";
                }

                var groupTabelas = gpTipo.GroupBy(p => p["Tabela"]).OrderBy(p => p.Key);
                foreach (var gpTabela in groupTabelas)
                {
                    TreeNode nodoNomeTabela = new TreeNode(gpTabela.Key.ToString());

                    foreach (var Coluna in gpTabela)
                    {
                        var s = Coluna["Coluna"];
                        nodoNomeTabela.Nodes.Add(s.ToString());
                    }
                    nodesTipo.Nodes.Add(nodoNomeTabela);
                }
                treeViewTabelas.Nodes.Add(nodesTipo);
            }
        }

        private void btnExecultar_Click(object sender, EventArgs e)
        {
            try
            {
                var aux = DataBase.ExecultaConsulta(txtQuery.Text);
                gridResultadoQuery.DataSource = aux.Resultado;
                EstruturaTabelaQuery = aux.Estrutura; ;
                gridSchema.DataSource = aux.Estrutura;

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

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void treeViewTabelas_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {

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
                        CarregaTreeView(DataBase.BuscarTabelasOuCampos("", ""));
                    else
                    {
                        CarregaTreeView(DataBase.BuscarTabelasOuCampos(txtPesquisaNome.Text, txtPesquisaNome.Text));
                        treeViewTabelas.ExpandAll();
                    }
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

                SqlCommand command = new SqlCommand(query, DataBase.getConexao());
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
                        else if (tipo == typeof(decimal))
                            where += row.Cells["Coluna"].Value.ToString() + " = " + row.Cells["Filtro"].ToString().Replace(",", ".");
                        else if (tipo == typeof(DateTime))
                        {
                            var data1 = DateTime.Parse(row.Cells["Filtro"].ToString());
                            var data2 = data1.AddSeconds(1);
                            where += String.Format(row.Cells["Coluna"].Value.ToString() + " between CAST('{0}' AS datetime) AND CAST('{1}' AS datetime)", data1.ToString("yyyy-MM-dd HH:mm:ss.fff"), data2.ToString("yyyy-MM-dd HH:mm:ss.fff"));
                        }
                        else if (tipo == typeof(bool))
                            where += row.Cells["Coluna"].Value.ToString() + " = " + Convert.ToInt16(row.Cells["Filtro"]);
                        else
                            where += row.Cells["Coluna"].Value.ToString() + " = " + row.Cells["Filtro"].Value.ToString();
                    }
                }

                if (where.Length > 0)
                    query += " WHERE " + where;

                var aux = DataBase.ExecultaConsulta(query);
                gridResultadoFiltro.DataSource = aux.Resultado;
                EstruturaConsulta = aux.Estrutura;

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
                SalvaAlteracaoCelula(gridResultadoFiltro, e, EstruturaTabelaFiltro);
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

        private void gridResultadoQuery_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                SalvaAlteracaoCelula(gridResultadoQuery, e, EstruturaTabelaQuery);
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
            int varCursor = txtQuery1.SelectionStart;
            string[] linhas = txtQuery1.Lines;
            foreach (var item in linhas)
            {
                //System.Text.RegularExpressions.MatchCollection matchs = System.Text.RegularExpressions.Regex.Matches(item, this.PalavrasSQL());
                //foreach (System.Text.RegularExpressions.Match match in matchs)
                //int startpos = 0;
                foreach (string str in this.PalavrasSQLChar().Split('|'))
                {
                    string mystring = str;
                    int startpos = 0;

                    do
                    {
                        if ((startpos = txtQuery1.Find(mystring, startpos, RichTextBoxFinds.None)) >= 0)
                        {
                            txtQuery1.SelectionStart = startpos;
                            txtQuery1.SelectionLength = mystring.Length;
                            txtQuery1.SelectionColor = System.Drawing.SystemColors.Highlight;
                            txtQuery1.SelectionFont = new Font("Arial", 8, FontStyle.Bold);
                            startpos += mystring.Length;
                            //txtQuery1.SelectionColor = Color.Red;
                        }
                    } while (startpos < varCursor && startpos != -1);
                    
                    
                }
            }            
            txtQuery1.SelectionStart = varCursor;            
            txtQuery1.SelectionFont = new Font("Arial", 8, FontStyle.Regular);// Color.Black;            
        }
              
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

            if (Environment.MachineName.Equals("HIGOR-NOT"))
            {
                txtServidor.Text = "higor-not";
                txtBanco.Text = "BD_HIGOR";
                txtUsuario.Text = "SA";
                txtSenha.Text = "zeus@cronos";

                txtQuery.Text = "SELECT * from T003_NotaFiscal INNER JOIN T004_NotaFiscalItem ON T003_NotaFiscal.T003_ID = T004_NotaFiscalItem.T003_IDNota WHERE T003_ID IN(7, 8)";
            }
            else if (Environment.MachineName.Equals("DEV-01"))
            {
                txtServidor.Text = "DEV-01,3390";
                txtBanco.Text = "BD_COOPERSAG_DEBUG";
                txtUsuario.Text = "SGA";
                txtSenha.Text = "brd@t@";

                txtQuery.Text = "SELECT * from T003_NotaFiscal INNER JOIN T004_NotaFiscalItem ON T003_NotaFiscal.T003_ID = T004_NotaFiscalItem.T003_IDNota WHERE T003_ID IN(7, 8)";
            }





        }

        private void treeViewTabelas_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.Node.Parent != null)
                {
                    if (e.Node.Parent.Name.Equals("Tabelas") || e.Node.Parent.Name.Equals("Views"))
                    {

                        menuBotaoDireito.Show(treeViewTabelas.PointToScreen(new Point(e.X, e.Y)));
                    }
                }
            }
        }

        private void mnuEditarLinhas_Click(object sender, EventArgs e)
        {
            try
            {
                var node = treeViewTabelas.SelectedNode;

                if (node == null)
                    return;

                if (node.Parent != null)
                {
                    if (node.Parent.Name.Equals("Tabelas"))
                    {
                        spConteiner2.Panel1Collapsed = true;

                        var query = "SELECT TOP 200 * FROM " + node.Text;

                        NomeTabelaSelecionada = node.Text;
                        var aux = DataBase.ExecultaConsulta(query);
                        gridResultadoFiltro.DataSource = aux.Resultado;
                        EstruturaTabelaFiltro = aux.Estrutura;

                    }
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

        private void mnuFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                spConteiner2.Panel1Collapsed = false;

                var node = treeViewTabelas.SelectedNode;
                if (node.Parent != null)
                {
                    if (node.Parent.Text.Equals("Tabelas"))
                    {
                        var dt = DataBase.BuscarCampos(node.Text);
                        dt.Columns.Add("Filtro", typeof(String));

                        gridTabela.DataSource = dt;
                        NomeTabelaSelecionada = node.Text;
                    }
                    else
                    {
                        var dt = DataBase.BuscarCampos(node.Text, false);
                        dt.Columns.Add("Filtro", typeof(String));

                        gridTabela.DataSource = dt;
                        NomeTabelaSelecionada = node.Text;
                    }
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

        private void SalvaAlteracaoCelula(DataGridView Grid, DataGridViewCellEventArgs e, DataTable EstruturaTabela)
        {

            if (e.RowIndex == Grid.Rows.Count - 1)
                return;

            string sql = string.Empty;
            string set = string.Empty;
            string where = string.Empty;

            //Cria a condição where
            foreach (DataGridViewColumn col in Grid.Columns)
            {
                var ValorCelula = Grid.Rows[e.RowIndex].Cells[col.Index].Value;

                //Se for igual a coluna editada não entra no where
                if (col.Index == e.ColumnIndex)
                {
                    var stringtipo = EstruturaTabela.Select().FirstOrDefault(p => p["ColumnName"].ToString() == col.Name)["DataType"].ToString();
                    var tipo = Type.GetType(stringtipo);
                    if (tipo == typeof(String))
                        set += col.Name + " = '" + ValorCelula.ToString() + "'";
                    if (tipo == typeof(Decimal) || tipo == typeof(decimal))
                        set += col.Name + " = " + ValorCelula.ToString().Replace(",",".");
                    else
                        set += col.Name + " = " + ValorCelula.ToString();

                    continue;
                }

                if (where.Length > 0)
                    where += " AND ";

                if (ValorCelula == null || ValorCelula == System.DBNull.Value)
                    where += col.Name + " IS NUll";
                else
                {
                    var stringtipo = EstruturaTabela.Select().FirstOrDefault(p => p["ColumnName"].ToString() == col.Name)["DataType"].ToString();
                    var tipo = Type.GetType(stringtipo);
                    if (tipo == typeof(String))
                        where += col.Name + " = '" + ValorCelula.ToString() + "'";
                    else if (tipo == typeof(decimal))
                        where += col.Name + " = " + ValorCelula.ToString().Replace(",", ".");
                    else if (tipo == typeof(DateTime))
                    {
                        var data1 = DateTime.Parse(ValorCelula.ToString());
                        var data2 = data1.AddSeconds(1);
                        where += String.Format(col.Name + " between CAST('{0}' AS datetime) AND CAST('{1}' AS datetime)", data1.ToString("yyyy-MM-dd HH:mm:ss.fff"), data2.ToString("yyyy-MM-dd HH:mm:ss.fff"));
                    }
                    else if (tipo == typeof(bool))
                        where += col.Name + " = " + Convert.ToInt16(ValorCelula);
                    else
                        where += col.Name + " = " + ValorCelula.ToString();
                }
            }
            sql = "UPDATE " + NomeTabelaSelecionada + " SET " + set + " WHERE " + where;

            SqlCommand command = new SqlCommand(sql, DataBase.getConexao());
            var table = new DataTable();

            SqlDataReader reader = command.ExecuteReader();
            table.Load(reader);
        }

        private void txtQuery_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private string PalavrasSQL()
        {
            string str = @"ADD|
ALL|
ALTER|
AND|
ANY|
AS|
ASC|
AUTHORIZATION|
BACKUP|
BEGIN|
BETWEEN|
BREAK|
BROWSE|
BULK|
BY|
CASCADE|
CASE|
CHECK|
CHECKPOINT|
CLOSE|
CLUSTERED|
COALESCE|
COLLATE|
COLUMN|
COMMIT|
COMPUTE|
CONSTRAINT|
CONTAINS|
CONTAINSTABLE|
CONTINUE|
CONVERT|
CREATE|
CROSS|
CURRENT|
CURRENT_DATE|
CURRENT_TIME|
CURRENT_TIMESTAMP|
CURRENT_USER|
CURSOR|
DATABASE|
DBCC|
DEALLOCATE|
DECLARE|
DEFAULT|
DELETE|
DENY|
DESC|
DISK|
DISTINCT|
DISTRIBUTED|
DOUBLE|
DROP|
DUMP|
ELSE|
END|
ERRLVL|
ESCAPE|
EXCEPT|
EXEC|
EXECUTE|
EXISTS|
EXIT|
EXTERNAL|
FETCH|
FILE|
FILLFACTOR|
FOR|
FOREIGN|
FREETEXT|
FREETEXTTABLE|
FROM|
FULL|
FUNCTION|
GOTO|
GRANT|
GROUP|
HAVING|
HOLDLOCK|
IDENTITY|
IDENTITY_INSERT|
IDENTITYCOL|
IF|
IN|
INDEX|
INNER|
INSERT|
INTERSECT|
INTO|
IS|
JOIN|
KEY|
KILL|
LEFT|
LIKE|
LINENO|
LOAD|
MERGE|
NATIONAL|
NOCHECK|
NONCLUSTERED|
NOT|
NULL|
NULLIF|
OF|
OFF|
OFFSETS|
ON|
OPEN|
OPENDATASOURCE|
OPENQUERY|
OPENROWSET|
OPENXML|
OPÇÃO|
OR|
ORDER|
OUTER|
OVER|
PERCENT|
PIVOT|
PLAN|
PRECISION|
PRIMARY|
PRINT|
PROC|
PROCEDURE|
PUBLIC|
RAISERROR|
READ|
READTEXT|
RECONFIGURE|
REFERENCES|
REPLICATION|
RESTORE|
RESTRICT|
RETURN|
REVERT|
REVOKE|
RIGHT|
ROLLBACK|
ROWCOUNT|
ROWGUIDCOL|
RULE|
SAVE|
SCHEMA|
SECURITYAUDIT|
SELECT|
SEMANTICKEYPHRASETABLE|
SEMANTICSIMILARITYDETAILSTABLE|
SEMANTICSIMILARITYTABLE|
SESSION_USER|
SET|
SETUSER|
SHUTDOWN|
SOME|
STATISTICS|
SYSTEM_USER|
TABLE|
TABLESAMPLE|
TEXTSIZE|
THEN|
TO|
TOP|
TRAN|
TRANSACTION|
TRIGGER|
TRUNCATE|
TRY_CONVERT|
TSEQUAL|
UNION|
UNIQUE|
UNPIVOT|
UPDATE|
UPDATETEXT|
USE|
USER|
VALUES|
VARYING|
VIEW|
WAITFOR|
WHEN|
WHERE|
WHILE|
WITH|
WITHIN GROUP|
WRITETEXT";
            return str;
        }

        private string PalavrasSQLChar()
        {
            StringBuilder palavras = new StringBuilder();
            palavras.Append("ADD|");
            palavras.Append("ALL|");
            palavras.Append("ALTER|");
            palavras.Append("AND|");
            palavras.Append("ANY|");
            palavras.Append("AS|");
            palavras.Append("ASC|");
            palavras.Append("AUTHORIZATION|");
            palavras.Append("BACKUP|");
            palavras.Append("BEGIN|");
            palavras.Append("BETWEEN|");
            palavras.Append("BREAK|");
            palavras.Append("BROWSE|");
            palavras.Append("BULK|");
            palavras.Append("BY|");
            palavras.Append("CASCADE|");
            palavras.Append("CASE|");
            palavras.Append("CHECK|");
            palavras.Append("CHECKPOINT|");
            palavras.Append("CLOSE|");
            palavras.Append("CLUSTERED|");
            palavras.Append("COALESCE|");
            palavras.Append("COLLATE|");
            palavras.Append("COLUMN|");
            palavras.Append("COMMIT|");
            palavras.Append("COMPUTE|");
            palavras.Append("CONSTRAINT|");
            palavras.Append("CONTAINS|");
            palavras.Append("CONTAINSTABLE|");
            palavras.Append("CONTINUE|");
            palavras.Append("CONVERT|");
            palavras.Append("CREATE|");
            palavras.Append("CROSS|");
            palavras.Append("CURRENT|");
            palavras.Append("CURRENT_DATE|");
            palavras.Append("CURRENT_TIME|");
            palavras.Append("CURRENT_TIMESTAMP|");
            palavras.Append("CURRENT_USER|");
            palavras.Append("CURSOR|");
            palavras.Append("DATABASE|");
            palavras.Append("DBCC|");
            palavras.Append("DEALLOCATE|");
            palavras.Append("DECLARE|");
            palavras.Append("DEFAULT|");
            palavras.Append("DELETE|");
            palavras.Append("DENY|");
            palavras.Append("DESC|");
            palavras.Append("DISK|");
            palavras.Append("DISTINCT|");
            palavras.Append("DISTRIBUTED|");
            palavras.Append("DOUBLE|");
            palavras.Append("DROP|");
            palavras.Append("DUMP|");
            palavras.Append("ELSE|");
            palavras.Append("END|");
            palavras.Append("ERRLVL|");
            palavras.Append("ESCAPE|");
            palavras.Append("EXCEPT|");
            palavras.Append("EXEC|");
            palavras.Append("EXECUTE|");
            palavras.Append("EXISTS|");
            palavras.Append("EXIT|");
            palavras.Append("EXTERNAL|");
            palavras.Append("FETCH|");
            palavras.Append("FILE|");
            palavras.Append("FILLFACTOR|");
            palavras.Append("FOR|");
            palavras.Append("FOREIGN|");
            palavras.Append("FREETEXT|");
            palavras.Append("FREETEXTTABLE|");
            palavras.Append("FROM|");
            palavras.Append("FULL|");
            palavras.Append("FUNCTION|");
            palavras.Append("GOTO|");
            palavras.Append("GRANT|");
            palavras.Append("GROUP|");
            palavras.Append("HAVING|");
            palavras.Append("HOLDLOCK|");
            palavras.Append("IDENTITY|");
            palavras.Append("IDENTITY_INSERT|");
            palavras.Append("IDENTITYCOL|");
            palavras.Append("IF|");
            palavras.Append("IN|");
            palavras.Append("INDEX|");
            palavras.Append("INNER|");
            palavras.Append("INSERT|");
            palavras.Append("INTERSECT|");
            palavras.Append("INTO|");
            palavras.Append("IS|");
            palavras.Append("JOIN|");
            palavras.Append("KEY|");
            palavras.Append("KILL|");
            palavras.Append("LEFT|");
            palavras.Append("LIKE|");
            palavras.Append("LINENO|");
            palavras.Append("LOAD|");
            palavras.Append("MERGE|");
            palavras.Append("NATIONAL|");
            palavras.Append("NOCHECK|");
            palavras.Append("NONCLUSTERED|");
            palavras.Append("NOT|");
            palavras.Append("NULL|");
            palavras.Append("NULLIF|");
            palavras.Append("OF|");
            palavras.Append("OFF|");
            palavras.Append("OFFSETS|");
            palavras.Append("ON|");
            palavras.Append("OPEN|");
            palavras.Append("OPENDATASOURCE|");
            palavras.Append("OPENQUERY|");
            palavras.Append("OPENROWSET|");
            palavras.Append("OPENXML|");
            palavras.Append("OPÇÃO|");
            palavras.Append("OR|");
            palavras.Append("ORDER|");
            palavras.Append("OUTER|");
            palavras.Append("OVER|");
            palavras.Append("PERCENT|");
            palavras.Append("PIVOT|");
            palavras.Append("PLAN|");
            palavras.Append("PRECISION|");
            palavras.Append("PRIMARY|");
            palavras.Append("PRINT|");
            palavras.Append("PROC|");
            palavras.Append("PROCEDURE|");
            palavras.Append("PUBLIC|");
            palavras.Append("RAISERROR|");
            palavras.Append("READ|");
            palavras.Append("READTEXT|");
            palavras.Append("RECONFIGURE|");
            palavras.Append("REFERENCES|");
            palavras.Append("REPLICATION|");
            palavras.Append("RESTORE|");
            palavras.Append("RESTRICT|");
            palavras.Append("RETURN|");
            palavras.Append("REVERT|");
            palavras.Append("REVOKE|");
            palavras.Append("RIGHT|");
            palavras.Append("ROLLBACK|");
            palavras.Append("ROWCOUNT|");
            palavras.Append("ROWGUIDCOL|");
            palavras.Append("RULE|");
            palavras.Append("SAVE|");
            palavras.Append("SCHEMA|");
            palavras.Append("SECURITYAUDIT|");
            palavras.Append("SELECT|");
            palavras.Append("SEMANTICKEYPHRASETABLE|");
            palavras.Append("SEMANTICSIMILARITYDETAILSTABLE|");
            palavras.Append("SEMANTICSIMILARITYTABLE|");
            palavras.Append("SESSION_USER|");
            palavras.Append("SET|");
            palavras.Append("SETUSER|");
            palavras.Append("SHUTDOWN|");
            palavras.Append("SOME|");
            palavras.Append("STATISTICS|");
            palavras.Append("SYSTEM_USER|");
            palavras.Append("TABLE|");
            palavras.Append("TABLESAMPLE|");
            palavras.Append("TEXTSIZE|");
            palavras.Append("THEN|");
            palavras.Append("TO|");
            palavras.Append("TOP|");
            palavras.Append("TRAN|");
            palavras.Append("TRANSACTION|");
            palavras.Append("TRIGGER|");
            palavras.Append("TRUNCATE|");
            palavras.Append("TRY_CONVERT|");
            palavras.Append("TSEQUAL|");
            palavras.Append("UNION|");
            palavras.Append("UNIQUE|");
            palavras.Append("UNPIVOT|");
            palavras.Append("UPDATE|");
            palavras.Append("UPDATETEXT|");
            palavras.Append("USE|");
            palavras.Append("USER|");
            palavras.Append("VALUES|");
            palavras.Append("VARYING|");
            palavras.Append("VIEW|");
            palavras.Append("WAITFOR|");
            palavras.Append("WHEN|");
            palavras.Append("WHERE|");
            palavras.Append("WHILE|");
            palavras.Append("WITH|");
            palavras.Append("WITHINGROUP|");
            palavras.Append("WRITETEXT|");

            return palavras.ToString();
        }
        

    }
}
