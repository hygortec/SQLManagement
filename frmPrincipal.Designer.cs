namespace SQLManagement
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Tabelas");
            this.status = new System.Windows.Forms.StatusStrip();
            this.txtStatusConexao = new System.Windows.Forms.ToolStripStatusLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtServidor = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtBanco = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtUsuario = new MetroFramework.Controls.MetroTextBox();
            this.txtSenha = new MetroFramework.Controls.MetroTextBox();
            this.btnConectar = new MetroFramework.Controls.MetroButton();
            this.tabControl = new MetroFramework.Controls.MetroTabControl();
            this.tabPrincipal = new MetroFramework.Controls.MetroTabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.gridResultadoFiltro = new System.Windows.Forms.DataGridView();
            this.txtPesquisaNome = new MetroFramework.Controls.MetroTextBox();
            this.treeViewTabelas = new System.Windows.Forms.TreeView();
            this.gridTabela = new System.Windows.Forms.DataGridView();
            this.btnBuscarCriteiro = new MetroFramework.Controls.MetroButton();
            this.tabQuery = new MetroFramework.Controls.MetroTabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlConsulta = new MetroFramework.Controls.MetroPanel();
            this.btnExecultar = new MetroFramework.Controls.MetroButton();
            this.txtQuery = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.pnlQueryResult = new MetroFramework.Controls.MetroPanel();
            this.gridResultado = new System.Windows.Forms.DataGridView();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.tabDebug = new MetroFramework.Controls.MetroTabPage();
            this.txtQuery1 = new System.Windows.Forms.RichTextBox();
            this.gridSchema = new System.Windows.Forms.DataGridView();
            this.pnlConexao = new MetroFramework.Controls.MetroPanel();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.status.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPrincipal.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridResultadoFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTabela)).BeginInit();
            this.tabQuery.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlConsulta.SuspendLayout();
            this.pnlQueryResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridResultado)).BeginInit();
            this.tabDebug.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSchema)).BeginInit();
            this.pnlConexao.SuspendLayout();
            this.SuspendLayout();
            // 
            // status
            // 
            this.status.BackColor = System.Drawing.Color.Red;
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtStatusConexao});
            this.status.Location = new System.Drawing.Point(20, 391);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(860, 22);
            this.status.TabIndex = 10;
            this.status.Text = "statusStrip1";
            // 
            // txtStatusConexao
            // 
            this.txtStatusConexao.Name = "txtStatusConexao";
            this.txtStatusConexao.Size = new System.Drawing.Size(82, 17);
            this.txtStatusConexao.Text = "Desconectado";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(12, 16);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(59, 19);
            this.metroLabel1.TabIndex = 15;
            this.metroLabel1.Text = "Servidor";
            // 
            // txtServidor
            // 
            // 
            // 
            // 
            this.txtServidor.CustomButton.Image = null;
            this.txtServidor.CustomButton.Location = new System.Drawing.Point(112, 1);
            this.txtServidor.CustomButton.Name = "";
            this.txtServidor.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtServidor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtServidor.CustomButton.TabIndex = 1;
            this.txtServidor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtServidor.CustomButton.UseSelectable = true;
            this.txtServidor.CustomButton.Visible = false;
            this.txtServidor.Lines = new string[0];
            this.txtServidor.Location = new System.Drawing.Point(77, 15);
            this.txtServidor.MaxLength = 32767;
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.PasswordChar = '\0';
            this.txtServidor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtServidor.SelectedText = "";
            this.txtServidor.SelectionLength = 0;
            this.txtServidor.SelectionStart = 0;
            this.txtServidor.ShortcutsEnabled = true;
            this.txtServidor.Size = new System.Drawing.Size(134, 23);
            this.txtServidor.TabIndex = 16;
            this.txtServidor.UseSelectable = true;
            this.txtServidor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtServidor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(217, 16);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(45, 19);
            this.metroLabel2.TabIndex = 17;
            this.metroLabel2.Text = "Banco";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(381, 16);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(53, 19);
            this.metroLabel3.TabIndex = 18;
            this.metroLabel3.Text = "Usuario";
            // 
            // txtBanco
            // 
            // 
            // 
            // 
            this.txtBanco.CustomButton.Image = null;
            this.txtBanco.CustomButton.Location = new System.Drawing.Point(90, 1);
            this.txtBanco.CustomButton.Name = "";
            this.txtBanco.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBanco.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBanco.CustomButton.TabIndex = 1;
            this.txtBanco.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBanco.CustomButton.UseSelectable = true;
            this.txtBanco.CustomButton.Visible = false;
            this.txtBanco.Lines = new string[0];
            this.txtBanco.Location = new System.Drawing.Point(263, 15);
            this.txtBanco.MaxLength = 32767;
            this.txtBanco.Name = "txtBanco";
            this.txtBanco.PasswordChar = '\0';
            this.txtBanco.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBanco.SelectedText = "";
            this.txtBanco.SelectionLength = 0;
            this.txtBanco.SelectionStart = 0;
            this.txtBanco.ShortcutsEnabled = true;
            this.txtBanco.Size = new System.Drawing.Size(112, 23);
            this.txtBanco.TabIndex = 20;
            this.txtBanco.UseSelectable = true;
            this.txtBanco.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBanco.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(550, 16);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(44, 19);
            this.metroLabel4.TabIndex = 21;
            this.metroLabel4.Text = "Senha";
            // 
            // txtUsuario
            // 
            // 
            // 
            // 
            this.txtUsuario.CustomButton.Image = null;
            this.txtUsuario.CustomButton.Location = new System.Drawing.Point(82, 1);
            this.txtUsuario.CustomButton.Name = "";
            this.txtUsuario.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUsuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUsuario.CustomButton.TabIndex = 1;
            this.txtUsuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUsuario.CustomButton.UseSelectable = true;
            this.txtUsuario.CustomButton.Visible = false;
            this.txtUsuario.Lines = new string[0];
            this.txtUsuario.Location = new System.Drawing.Point(440, 15);
            this.txtUsuario.MaxLength = 32767;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PasswordChar = '\0';
            this.txtUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsuario.SelectedText = "";
            this.txtUsuario.SelectionLength = 0;
            this.txtUsuario.SelectionStart = 0;
            this.txtUsuario.ShortcutsEnabled = true;
            this.txtUsuario.Size = new System.Drawing.Size(104, 23);
            this.txtUsuario.TabIndex = 22;
            this.txtUsuario.UseSelectable = true;
            this.txtUsuario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUsuario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtSenha
            // 
            // 
            // 
            // 
            this.txtSenha.CustomButton.Image = null;
            this.txtSenha.CustomButton.Location = new System.Drawing.Point(82, 1);
            this.txtSenha.CustomButton.Name = "";
            this.txtSenha.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSenha.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSenha.CustomButton.TabIndex = 1;
            this.txtSenha.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSenha.CustomButton.UseSelectable = true;
            this.txtSenha.CustomButton.Visible = false;
            this.txtSenha.Lines = new string[0];
            this.txtSenha.Location = new System.Drawing.Point(600, 15);
            this.txtSenha.MaxLength = 32767;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSenha.SelectedText = "";
            this.txtSenha.SelectionLength = 0;
            this.txtSenha.SelectionStart = 0;
            this.txtSenha.ShortcutsEnabled = true;
            this.txtSenha.Size = new System.Drawing.Size(104, 23);
            this.txtSenha.TabIndex = 23;
            this.txtSenha.UseSelectable = true;
            this.txtSenha.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSenha.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(716, 15);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(75, 23);
            this.btnConectar.TabIndex = 24;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseSelectable = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // tabControl
            // 
            this.tabControl.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl.Controls.Add(this.tabPrincipal);
            this.tabControl.Controls.Add(this.tabQuery);
            this.tabControl.Controls.Add(this.tabDebug);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(20, 109);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(860, 282);
            this.tabControl.TabIndex = 25;
            this.tabControl.UseSelectable = true;
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.Controls.Add(this.tableLayoutPanel2);
            this.tabPrincipal.HorizontalScrollbarBarColor = true;
            this.tabPrincipal.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPrincipal.HorizontalScrollbarSize = 10;
            this.tabPrincipal.Location = new System.Drawing.Point(4, 41);
            this.tabPrincipal.Name = "tabPrincipal";
            this.tabPrincipal.Size = new System.Drawing.Size(852, 237);
            this.tabPrincipal.TabIndex = 0;
            this.tabPrincipal.Text = "Principal";
            this.tabPrincipal.VerticalScrollbarBarColor = true;
            this.tabPrincipal.VerticalScrollbarHighlightOnWheel = false;
            this.tabPrincipal.VerticalScrollbarSize = 10;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.93427F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.06573F));
            this.tableLayoutPanel2.Controls.Add(this.gridResultadoFiltro, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtPesquisaNome, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.treeViewTabelas, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.gridTabela, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnBuscarCriteiro, 1, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.62718F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.37282F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(852, 237);
            this.tableLayoutPanel2.TabIndex = 2;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // gridResultadoFiltro
            // 
            this.gridResultadoFiltro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridResultadoFiltro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridResultadoFiltro.Location = new System.Drawing.Point(245, 168);
            this.gridResultadoFiltro.Name = "gridResultadoFiltro";
            this.gridResultadoFiltro.Size = new System.Drawing.Size(594, 56);
            this.gridResultadoFiltro.TabIndex = 27;
            this.gridResultadoFiltro.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridResultadoFiltro_CellValueChanged);
            // 
            // txtPesquisaNome
            // 
            this.txtPesquisaNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtPesquisaNome.CustomButton.Image = null;
            this.txtPesquisaNome.CustomButton.Location = new System.Drawing.Point(204, 1);
            this.txtPesquisaNome.CustomButton.Name = "";
            this.txtPesquisaNome.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPesquisaNome.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPesquisaNome.CustomButton.TabIndex = 1;
            this.txtPesquisaNome.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPesquisaNome.CustomButton.UseSelectable = true;
            this.txtPesquisaNome.CustomButton.Visible = false;
            this.txtPesquisaNome.Lines = new string[0];
            this.txtPesquisaNome.Location = new System.Drawing.Point(13, 14);
            this.txtPesquisaNome.MaxLength = 32767;
            this.txtPesquisaNome.Name = "txtPesquisaNome";
            this.txtPesquisaNome.PasswordChar = '\0';
            this.txtPesquisaNome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPesquisaNome.SelectedText = "";
            this.txtPesquisaNome.SelectionLength = 0;
            this.txtPesquisaNome.SelectionStart = 0;
            this.txtPesquisaNome.ShortcutsEnabled = true;
            this.txtPesquisaNome.Size = new System.Drawing.Size(226, 23);
            this.txtPesquisaNome.TabIndex = 21;
            this.txtPesquisaNome.UseSelectable = true;
            this.txtPesquisaNome.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPesquisaNome.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPesquisaNome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPesquisaNome_KeyDown);
            // 
            // treeViewTabelas
            // 
            this.treeViewTabelas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewTabelas.Location = new System.Drawing.Point(13, 43);
            this.treeViewTabelas.Name = "treeViewTabelas";
            treeNode2.Name = "nodeTabelas";
            treeNode2.Text = "Tabelas";
            this.treeViewTabelas.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.tableLayoutPanel2.SetRowSpan(this.treeViewTabelas, 3);
            this.treeViewTabelas.Size = new System.Drawing.Size(226, 181);
            this.treeViewTabelas.TabIndex = 16;
            this.treeViewTabelas.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewTabelas_NodeMouseDoubleClick);
            // 
            // gridTabela
            // 
            this.gridTabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTabela.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridTabela.Location = new System.Drawing.Point(245, 13);
            this.gridTabela.Name = "gridTabela";
            this.tableLayoutPanel2.SetRowSpan(this.gridTabela, 2);
            this.gridTabela.Size = new System.Drawing.Size(594, 118);
            this.gridTabela.TabIndex = 15;
            // 
            // btnBuscarCriteiro
            // 
            this.btnBuscarCriteiro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarCriteiro.Location = new System.Drawing.Point(764, 139);
            this.btnBuscarCriteiro.Name = "btnBuscarCriteiro";
            this.btnBuscarCriteiro.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarCriteiro.TabIndex = 26;
            this.btnBuscarCriteiro.Text = "Buscar";
            this.btnBuscarCriteiro.UseSelectable = true;
            this.btnBuscarCriteiro.Click += new System.EventHandler(this.btnBuscarCriteiro_Click);
            // 
            // tabQuery
            // 
            this.tabQuery.Controls.Add(this.tableLayoutPanel1);
            this.tabQuery.HorizontalScrollbarBarColor = true;
            this.tabQuery.HorizontalScrollbarHighlightOnWheel = false;
            this.tabQuery.HorizontalScrollbarSize = 10;
            this.tabQuery.Location = new System.Drawing.Point(4, 41);
            this.tabQuery.Name = "tabQuery";
            this.tabQuery.Size = new System.Drawing.Size(852, 237);
            this.tabQuery.TabIndex = 1;
            this.tabQuery.Text = "Query";
            this.tabQuery.VerticalScrollbarBarColor = true;
            this.tabQuery.VerticalScrollbarHighlightOnWheel = false;
            this.tabQuery.VerticalScrollbarSize = 10;
            this.tabQuery.Click += new System.EventHandler(this.tabQuery_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 458F));
            this.tableLayoutPanel1.Controls.Add(this.pnlConsulta, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlQueryResult, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(852, 237);
            this.tableLayoutPanel1.TabIndex = 28;
            // 
            // pnlConsulta
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.pnlConsulta, 2);
            this.pnlConsulta.Controls.Add(this.btnExecultar);
            this.pnlConsulta.Controls.Add(this.txtQuery);
            this.pnlConsulta.Controls.Add(this.metroLabel5);
            this.pnlConsulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlConsulta.HorizontalScrollbarBarColor = true;
            this.pnlConsulta.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlConsulta.HorizontalScrollbarSize = 10;
            this.pnlConsulta.Location = new System.Drawing.Point(13, 13);
            this.pnlConsulta.Name = "pnlConsulta";
            this.pnlConsulta.Size = new System.Drawing.Size(826, 80);
            this.pnlConsulta.TabIndex = 14;
            this.pnlConsulta.VerticalScrollbarBarColor = true;
            this.pnlConsulta.VerticalScrollbarHighlightOnWheel = false;
            this.pnlConsulta.VerticalScrollbarSize = 10;
            // 
            // btnExecultar
            // 
            this.btnExecultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExecultar.Location = new System.Drawing.Point(748, 54);
            this.btnExecultar.Name = "btnExecultar";
            this.btnExecultar.Size = new System.Drawing.Size(75, 23);
            this.btnExecultar.TabIndex = 25;
            this.btnExecultar.Text = "Execultar";
            this.btnExecultar.UseSelectable = true;
            this.btnExecultar.Click += new System.EventHandler(this.btnExecultar_Click);
            // 
            // txtQuery
            // 
            this.txtQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtQuery.CustomButton.Image = null;
            this.txtQuery.CustomButton.Location = new System.Drawing.Point(792, 2);
            this.txtQuery.CustomButton.Name = "";
            this.txtQuery.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtQuery.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtQuery.CustomButton.TabIndex = 1;
            this.txtQuery.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtQuery.CustomButton.UseSelectable = true;
            this.txtQuery.CustomButton.Visible = false;
            this.txtQuery.Lines = new string[] {
        "metroTextBox1"};
            this.txtQuery.Location = new System.Drawing.Point(5, 20);
            this.txtQuery.MaxLength = 32767;
            this.txtQuery.Multiline = true;
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.PasswordChar = '\0';
            this.txtQuery.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtQuery.SelectedText = "";
            this.txtQuery.SelectionLength = 0;
            this.txtQuery.SelectionStart = 0;
            this.txtQuery.ShortcutsEnabled = true;
            this.txtQuery.Size = new System.Drawing.Size(818, 28);
            this.txtQuery.TabIndex = 14;
            this.txtQuery.Text = "metroTextBox1";
            this.txtQuery.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtQuery.UseSelectable = true;
            this.txtQuery.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtQuery.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(7, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(46, 19);
            this.metroLabel5.TabIndex = 26;
            this.metroLabel5.Text = "Query";
            // 
            // pnlQueryResult
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.pnlQueryResult, 2);
            this.pnlQueryResult.Controls.Add(this.gridResultado);
            this.pnlQueryResult.Controls.Add(this.metroLabel6);
            this.pnlQueryResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlQueryResult.HorizontalScrollbarBarColor = true;
            this.pnlQueryResult.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlQueryResult.HorizontalScrollbarSize = 10;
            this.pnlQueryResult.Location = new System.Drawing.Point(13, 99);
            this.pnlQueryResult.Name = "pnlQueryResult";
            this.pnlQueryResult.Size = new System.Drawing.Size(826, 125);
            this.pnlQueryResult.TabIndex = 26;
            this.pnlQueryResult.VerticalScrollbarBarColor = true;
            this.pnlQueryResult.VerticalScrollbarHighlightOnWheel = false;
            this.pnlQueryResult.VerticalScrollbarSize = 10;
            // 
            // gridResultado
            // 
            this.gridResultado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridResultado.Location = new System.Drawing.Point(3, 29);
            this.gridResultado.Name = "gridResultado";
            this.gridResultado.Size = new System.Drawing.Size(820, 93);
            this.gridResultado.TabIndex = 15;
            this.gridResultado.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridResultado_CellValueChanged);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(7, 6);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(84, 19);
            this.metroLabel6.TabIndex = 27;
            this.metroLabel6.Text = "Query Result";
            // 
            // tabDebug
            // 
            this.tabDebug.Controls.Add(this.txtQuery1);
            this.tabDebug.Controls.Add(this.gridSchema);
            this.tabDebug.HorizontalScrollbarBarColor = true;
            this.tabDebug.HorizontalScrollbarHighlightOnWheel = false;
            this.tabDebug.HorizontalScrollbarSize = 10;
            this.tabDebug.Location = new System.Drawing.Point(4, 41);
            this.tabDebug.Name = "tabDebug";
            this.tabDebug.Size = new System.Drawing.Size(852, 237);
            this.tabDebug.TabIndex = 2;
            this.tabDebug.Text = "Debug";
            this.tabDebug.VerticalScrollbarBarColor = true;
            this.tabDebug.VerticalScrollbarHighlightOnWheel = false;
            this.tabDebug.VerticalScrollbarSize = 10;
            // 
            // txtQuery1
            // 
            this.txtQuery1.Location = new System.Drawing.Point(8, 111);
            this.txtQuery1.Name = "txtQuery1";
            this.txtQuery1.Size = new System.Drawing.Size(841, 96);
            this.txtQuery1.TabIndex = 16;
            this.txtQuery1.Text = "";
            this.txtQuery1.TextChanged += new System.EventHandler(this.txtQuery1_TextChanged);
            // 
            // gridSchema
            // 
            this.gridSchema.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSchema.Location = new System.Drawing.Point(8, 8);
            this.gridSchema.Name = "gridSchema";
            this.gridSchema.Size = new System.Drawing.Size(841, 97);
            this.gridSchema.TabIndex = 15;
            // 
            // pnlConexao
            // 
            this.pnlConexao.Controls.Add(this.btnConectar);
            this.pnlConexao.Controls.Add(this.txtServidor);
            this.pnlConexao.Controls.Add(this.txtSenha);
            this.pnlConexao.Controls.Add(this.metroLabel1);
            this.pnlConexao.Controls.Add(this.txtUsuario);
            this.pnlConexao.Controls.Add(this.metroLabel2);
            this.pnlConexao.Controls.Add(this.metroLabel4);
            this.pnlConexao.Controls.Add(this.metroLabel3);
            this.pnlConexao.Controls.Add(this.txtBanco);
            this.pnlConexao.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlConexao.HorizontalScrollbarBarColor = true;
            this.pnlConexao.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlConexao.HorizontalScrollbarSize = 10;
            this.pnlConexao.Location = new System.Drawing.Point(20, 60);
            this.pnlConexao.Name = "pnlConexao";
            this.pnlConexao.Size = new System.Drawing.Size(860, 49);
            this.pnlConexao.TabIndex = 28;
            this.pnlConexao.VerticalScrollbarBarColor = true;
            this.pnlConexao.VerticalScrollbarHighlightOnWheel = false;
            this.pnlConexao.VerticalScrollbarSize = 10;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 433);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.status);
            this.Controls.Add(this.pnlConexao);
            this.Name = "frmPrincipal";
            this.Text = "SQL ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPrincipal.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridResultadoFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTabela)).EndInit();
            this.tabQuery.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlConsulta.ResumeLayout(false);
            this.pnlConsulta.PerformLayout();
            this.pnlQueryResult.ResumeLayout(false);
            this.pnlQueryResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridResultado)).EndInit();
            this.tabDebug.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSchema)).EndInit();
            this.pnlConexao.ResumeLayout(false);
            this.pnlConexao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.ToolStripStatusLabel txtStatusConexao;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtServidor;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtBanco;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtUsuario;
        private MetroFramework.Controls.MetroTextBox txtSenha;
        private MetroFramework.Controls.MetroButton btnConectar;
        private MetroFramework.Controls.MetroTabControl tabControl;
        private MetroFramework.Controls.MetroTabPage tabPrincipal;
        private MetroFramework.Controls.MetroTabPage tabQuery;
        private MetroFramework.Controls.MetroPanel pnlConsulta;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroPanel pnlQueryResult;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroButton btnExecultar;
        private MetroFramework.Controls.MetroTextBox txtQuery;
        private MetroFramework.Controls.MetroPanel pnlConexao;
        private System.Windows.Forms.DataGridView gridResultado;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView gridTabela;
        private System.Windows.Forms.TreeView treeViewTabelas;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private MetroFramework.Controls.MetroTextBox txtPesquisaNome;
        private MetroFramework.Controls.MetroButton btnBuscarCriteiro;
        private System.Windows.Forms.DataGridView gridResultadoFiltro;
        private MetroFramework.Controls.MetroTabPage tabDebug;
        private System.Windows.Forms.DataGridView gridSchema;
        private System.Windows.Forms.RichTextBox txtQuery1;
    }
}

