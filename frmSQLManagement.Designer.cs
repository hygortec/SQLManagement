namespace SQLManagement
{
    partial class frmSQLManagement
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Tabelas");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSQLManagement));
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
            this.pnlPrincipal = new MetroFramework.Controls.MetroPanel();
            this.spConteiner1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txtPesquisaNome = new MetroFramework.Controls.MetroTextBox();
            this.treeViewTabelas = new System.Windows.Forms.TreeView();
            this.spConteiner2 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.gridTabela = new System.Windows.Forms.DataGridView();
            this.btnBuscarCriteiro = new MetroFramework.Controls.MetroButton();
            this.gridResultadoFiltro = new System.Windows.Forms.DataGridView();
            this.tabQuery = new MetroFramework.Controls.MetroTabPage();
            this.pnlQuery = new MetroFramework.Controls.MetroPanel();
            this.spConteiner3 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtQuery = new MetroFramework.Controls.MetroTextBox();
            this.btnExecultar = new MetroFramework.Controls.MetroButton();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.gridResultadoQuery = new System.Windows.Forms.DataGridView();
            this.tabDebug = new MetroFramework.Controls.MetroTabPage();
            this.txtQuery1 = new System.Windows.Forms.RichTextBox();
            this.gridSchema = new System.Windows.Forms.DataGridView();
            this.pnlConexao = new MetroFramework.Controls.MetroPanel();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.menuBotaoDireito = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.mnuFiltrar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditarLinhas = new System.Windows.Forms.ToolStripMenuItem();
            this.status.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPrincipal.SuspendLayout();
            this.pnlPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spConteiner1)).BeginInit();
            this.spConteiner1.Panel1.SuspendLayout();
            this.spConteiner1.Panel2.SuspendLayout();
            this.spConteiner1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spConteiner2)).BeginInit();
            this.spConteiner2.Panel1.SuspendLayout();
            this.spConteiner2.Panel2.SuspendLayout();
            this.spConteiner2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTabela)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridResultadoFiltro)).BeginInit();
            this.tabQuery.SuspendLayout();
            this.pnlQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spConteiner3)).BeginInit();
            this.spConteiner3.Panel1.SuspendLayout();
            this.spConteiner3.Panel2.SuspendLayout();
            this.spConteiner3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridResultadoQuery)).BeginInit();
            this.tabDebug.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSchema)).BeginInit();
            this.pnlConexao.SuspendLayout();
            this.menuBotaoDireito.SuspendLayout();
            this.SuspendLayout();
            // 
            // status
            // 
            this.status.BackColor = System.Drawing.Color.Red;
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtStatusConexao});
            this.status.Location = new System.Drawing.Point(20, 537);
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
            this.tabControl.SelectedIndex = 2;
            this.tabControl.Size = new System.Drawing.Size(860, 428);
            this.tabControl.TabIndex = 25;
            this.tabControl.UseSelectable = true;
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.Controls.Add(this.pnlPrincipal);
            this.tabPrincipal.HorizontalScrollbarBarColor = true;
            this.tabPrincipal.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPrincipal.HorizontalScrollbarSize = 10;
            this.tabPrincipal.Location = new System.Drawing.Point(4, 41);
            this.tabPrincipal.Name = "tabPrincipal";
            this.tabPrincipal.Size = new System.Drawing.Size(852, 383);
            this.tabPrincipal.TabIndex = 0;
            this.tabPrincipal.Text = "Principal";
            this.tabPrincipal.VerticalScrollbarBarColor = true;
            this.tabPrincipal.VerticalScrollbarHighlightOnWheel = false;
            this.tabPrincipal.VerticalScrollbarSize = 10;
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.spConteiner1);
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.HorizontalScrollbarBarColor = true;
            this.pnlPrincipal.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlPrincipal.HorizontalScrollbarSize = 10;
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Padding = new System.Windows.Forms.Padding(10);
            this.pnlPrincipal.Size = new System.Drawing.Size(852, 383);
            this.pnlPrincipal.TabIndex = 4;
            this.pnlPrincipal.VerticalScrollbarBarColor = true;
            this.pnlPrincipal.VerticalScrollbarHighlightOnWheel = false;
            this.pnlPrincipal.VerticalScrollbarSize = 10;
            // 
            // spConteiner1
            // 
            this.spConteiner1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spConteiner1.Location = new System.Drawing.Point(10, 10);
            this.spConteiner1.Name = "spConteiner1";
            // 
            // spConteiner1.Panel1
            // 
            this.spConteiner1.Panel1.Controls.Add(this.tableLayoutPanel3);
            // 
            // spConteiner1.Panel2
            // 
            this.spConteiner1.Panel2.Controls.Add(this.spConteiner2);
            this.spConteiner1.Size = new System.Drawing.Size(832, 363);
            this.spConteiner1.SplitterDistance = 208;
            this.spConteiner1.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.txtPesquisaNome, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.treeViewTabelas, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(208, 363);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // txtPesquisaNome
            // 
            this.txtPesquisaNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtPesquisaNome.CustomButton.Image = null;
            this.txtPesquisaNome.CustomButton.Location = new System.Drawing.Point(180, 1);
            this.txtPesquisaNome.CustomButton.Name = "";
            this.txtPesquisaNome.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPesquisaNome.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPesquisaNome.CustomButton.TabIndex = 1;
            this.txtPesquisaNome.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPesquisaNome.CustomButton.UseSelectable = true;
            this.txtPesquisaNome.CustomButton.Visible = false;
            this.txtPesquisaNome.Lines = new string[0];
            this.txtPesquisaNome.Location = new System.Drawing.Point(3, 9);
            this.txtPesquisaNome.MaxLength = 32767;
            this.txtPesquisaNome.Name = "txtPesquisaNome";
            this.txtPesquisaNome.PasswordChar = '\0';
            this.txtPesquisaNome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPesquisaNome.SelectedText = "";
            this.txtPesquisaNome.SelectionLength = 0;
            this.txtPesquisaNome.SelectionStart = 0;
            this.txtPesquisaNome.ShortcutsEnabled = true;
            this.txtPesquisaNome.Size = new System.Drawing.Size(202, 23);
            this.txtPesquisaNome.TabIndex = 21;
            this.txtPesquisaNome.UseSelectable = true;
            this.txtPesquisaNome.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPesquisaNome.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPesquisaNome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPesquisaNome_KeyDown);
            // 
            // treeViewTabelas
            // 
            this.treeViewTabelas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewTabelas.Location = new System.Drawing.Point(3, 38);
            this.treeViewTabelas.Name = "treeViewTabelas";
            treeNode1.Name = "nodeTabelas";
            treeNode1.Text = "Tabelas";
            this.treeViewTabelas.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.treeViewTabelas.Size = new System.Drawing.Size(202, 322);
            this.treeViewTabelas.TabIndex = 16;
            this.treeViewTabelas.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewTabelas_NodeMouseClick);
            // 
            // spConteiner2
            // 
            this.spConteiner2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spConteiner2.Location = new System.Drawing.Point(0, 0);
            this.spConteiner2.Name = "spConteiner2";
            this.spConteiner2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spConteiner2.Panel1
            // 
            this.spConteiner2.Panel1.Controls.Add(this.tableLayoutPanel4);
            // 
            // spConteiner2.Panel2
            // 
            this.spConteiner2.Panel2.Controls.Add(this.gridResultadoFiltro);
            this.spConteiner2.Size = new System.Drawing.Size(620, 363);
            this.spConteiner2.SplitterDistance = 239;
            this.spConteiner2.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.gridTabela, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnBuscarCriteiro, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(620, 239);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // gridTabela
            // 
            this.gridTabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTabela.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridTabela.Location = new System.Drawing.Point(3, 3);
            this.gridTabela.Name = "gridTabela";
            this.gridTabela.Size = new System.Drawing.Size(614, 204);
            this.gridTabela.TabIndex = 15;
            // 
            // btnBuscarCriteiro
            // 
            this.btnBuscarCriteiro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarCriteiro.Location = new System.Drawing.Point(542, 213);
            this.btnBuscarCriteiro.Name = "btnBuscarCriteiro";
            this.btnBuscarCriteiro.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarCriteiro.TabIndex = 26;
            this.btnBuscarCriteiro.Text = "Buscar";
            this.btnBuscarCriteiro.UseSelectable = true;
            this.btnBuscarCriteiro.Click += new System.EventHandler(this.btnBuscarCriteiro_Click);
            // 
            // gridResultadoFiltro
            // 
            this.gridResultadoFiltro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridResultadoFiltro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridResultadoFiltro.Location = new System.Drawing.Point(0, 0);
            this.gridResultadoFiltro.Name = "gridResultadoFiltro";
            this.gridResultadoFiltro.Size = new System.Drawing.Size(620, 120);
            this.gridResultadoFiltro.TabIndex = 27;
            this.gridResultadoFiltro.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridResultadoFiltro_CellValueChanged);
            // 
            // tabQuery
            // 
            this.tabQuery.Controls.Add(this.pnlQuery);
            this.tabQuery.HorizontalScrollbarBarColor = true;
            this.tabQuery.HorizontalScrollbarHighlightOnWheel = false;
            this.tabQuery.HorizontalScrollbarSize = 10;
            this.tabQuery.Location = new System.Drawing.Point(4, 41);
            this.tabQuery.Name = "tabQuery";
            this.tabQuery.Size = new System.Drawing.Size(852, 383);
            this.tabQuery.TabIndex = 1;
            this.tabQuery.Text = "Query";
            this.tabQuery.VerticalScrollbarBarColor = true;
            this.tabQuery.VerticalScrollbarHighlightOnWheel = false;
            this.tabQuery.VerticalScrollbarSize = 10;
            this.tabQuery.Click += new System.EventHandler(this.tabQuery_Click);
            // 
            // pnlQuery
            // 
            this.pnlQuery.Controls.Add(this.spConteiner3);
            this.pnlQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlQuery.HorizontalScrollbarBarColor = true;
            this.pnlQuery.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlQuery.HorizontalScrollbarSize = 10;
            this.pnlQuery.Location = new System.Drawing.Point(0, 0);
            this.pnlQuery.Name = "pnlQuery";
            this.pnlQuery.Padding = new System.Windows.Forms.Padding(10);
            this.pnlQuery.Size = new System.Drawing.Size(852, 383);
            this.pnlQuery.TabIndex = 29;
            this.pnlQuery.VerticalScrollbarBarColor = true;
            this.pnlQuery.VerticalScrollbarHighlightOnWheel = false;
            this.pnlQuery.VerticalScrollbarSize = 10;
            // 
            // spConteiner3
            // 
            this.spConteiner3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spConteiner3.Location = new System.Drawing.Point(10, 10);
            this.spConteiner3.Margin = new System.Windows.Forms.Padding(0);
            this.spConteiner3.Name = "spConteiner3";
            this.spConteiner3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spConteiner3.Panel1
            // 
            this.spConteiner3.Panel1.Controls.Add(this.tableLayoutPanel2);
            // 
            // spConteiner3.Panel2
            // 
            this.spConteiner3.Panel2.Controls.Add(this.tableLayoutPanel5);
            this.spConteiner3.Size = new System.Drawing.Size(832, 363);
            this.spConteiner3.SplitterDistance = 181;
            this.spConteiner3.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.txtQuery, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnExecultar, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(832, 181);
            this.tableLayoutPanel2.TabIndex = 3;
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
            this.txtQuery.CustomButton.Location = new System.Drawing.Point(682, 1);
            this.txtQuery.CustomButton.Name = "";
            this.txtQuery.CustomButton.Size = new System.Drawing.Size(143, 143);
            this.txtQuery.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtQuery.CustomButton.TabIndex = 1;
            this.txtQuery.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtQuery.CustomButton.UseSelectable = true;
            this.txtQuery.CustomButton.Visible = false;
            this.txtQuery.Lines = new string[0];
            this.txtQuery.Location = new System.Drawing.Point(3, 3);
            this.txtQuery.MaxLength = 32767;
            this.txtQuery.Multiline = true;
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.PasswordChar = '\0';
            this.txtQuery.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtQuery.SelectedText = "";
            this.txtQuery.SelectionLength = 0;
            this.txtQuery.SelectionStart = 0;
            this.txtQuery.ShortcutsEnabled = true;
            this.txtQuery.Size = new System.Drawing.Size(826, 145);
            this.txtQuery.TabIndex = 14;
            this.txtQuery.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtQuery.UseSelectable = true;
            this.txtQuery.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtQuery.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtQuery.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuery_KeyPress);
            // 
            // btnExecultar
            // 
            this.btnExecultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExecultar.Location = new System.Drawing.Point(754, 155);
            this.btnExecultar.Name = "btnExecultar";
            this.btnExecultar.Size = new System.Drawing.Size(75, 23);
            this.btnExecultar.TabIndex = 25;
            this.btnExecultar.Text = "Execultar";
            this.btnExecultar.UseSelectable = true;
            this.btnExecultar.Click += new System.EventHandler(this.btnExecultar_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.metroLabel6, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.gridResultadoQuery, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(832, 178);
            this.tableLayoutPanel5.TabIndex = 3;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(3, 0);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(84, 19);
            this.metroLabel6.TabIndex = 27;
            this.metroLabel6.Text = "Query Result";
            // 
            // gridResultadoQuery
            // 
            this.gridResultadoQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridResultadoQuery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridResultadoQuery.Location = new System.Drawing.Point(3, 24);
            this.gridResultadoQuery.Name = "gridResultadoQuery";
            this.gridResultadoQuery.Size = new System.Drawing.Size(826, 151);
            this.gridResultadoQuery.TabIndex = 15;
            this.gridResultadoQuery.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridResultadoQuery_CellValueChanged);
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
            this.tabDebug.Size = new System.Drawing.Size(852, 383);
            this.tabDebug.TabIndex = 2;
            this.tabDebug.Text = "Debug";
            this.tabDebug.VerticalScrollbarBarColor = true;
            this.tabDebug.VerticalScrollbarHighlightOnWheel = false;
            this.tabDebug.VerticalScrollbarSize = 10;
            // 
            // txtQuery1
            // 
            this.txtQuery1.ForeColor = System.Drawing.Color.Black;
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
            // menuBotaoDireito
            // 
            this.menuBotaoDireito.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFiltrar,
            this.mnuEditarLinhas});
            this.menuBotaoDireito.Name = "metroContextMenu1";
            this.menuBotaoDireito.Size = new System.Drawing.Size(142, 48);
            // 
            // mnuFiltrar
            // 
            this.mnuFiltrar.Name = "mnuFiltrar";
            this.mnuFiltrar.Size = new System.Drawing.Size(141, 22);
            this.mnuFiltrar.Text = "Filtrar";
            this.mnuFiltrar.Click += new System.EventHandler(this.mnuFiltrar_Click);
            // 
            // mnuEditarLinhas
            // 
            this.mnuEditarLinhas.Name = "mnuEditarLinhas";
            this.mnuEditarLinhas.Size = new System.Drawing.Size(141, 22);
            this.mnuEditarLinhas.Text = "Editar Linhas";
            this.mnuEditarLinhas.Click += new System.EventHandler(this.mnuEditarLinhas_Click);
            // 
            // frmSQLManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 579);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.status);
            this.Controls.Add(this.pnlConexao);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSQLManagement";
            this.Text = "SQL ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPrincipal.ResumeLayout(false);
            this.pnlPrincipal.ResumeLayout(false);
            this.spConteiner1.Panel1.ResumeLayout(false);
            this.spConteiner1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spConteiner1)).EndInit();
            this.spConteiner1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.spConteiner2.Panel1.ResumeLayout(false);
            this.spConteiner2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spConteiner2)).EndInit();
            this.spConteiner2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridTabela)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridResultadoFiltro)).EndInit();
            this.tabQuery.ResumeLayout(false);
            this.pnlQuery.ResumeLayout(false);
            this.spConteiner3.Panel1.ResumeLayout(false);
            this.spConteiner3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spConteiner3)).EndInit();
            this.spConteiner3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridResultadoQuery)).EndInit();
            this.tabDebug.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSchema)).EndInit();
            this.pnlConexao.ResumeLayout(false);
            this.pnlConexao.PerformLayout();
            this.menuBotaoDireito.ResumeLayout(false);
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
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroButton btnExecultar;
        private MetroFramework.Controls.MetroTextBox txtQuery;
        private MetroFramework.Controls.MetroPanel pnlConexao;
        private System.Windows.Forms.DataGridView gridResultadoQuery;
        private System.Windows.Forms.DataGridView gridTabela;
        private System.Windows.Forms.TreeView treeViewTabelas;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private MetroFramework.Controls.MetroTextBox txtPesquisaNome;
        private MetroFramework.Controls.MetroButton btnBuscarCriteiro;
        private System.Windows.Forms.DataGridView gridResultadoFiltro;
        private MetroFramework.Controls.MetroTabPage tabDebug;
        private System.Windows.Forms.DataGridView gridSchema;
        private System.Windows.Forms.RichTextBox txtQuery1;
        private MetroFramework.Controls.MetroContextMenu menuBotaoDireito;
        private System.Windows.Forms.ToolStripMenuItem mnuEditarLinhas;
        private System.Windows.Forms.SplitContainer spConteiner1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.SplitContainer spConteiner2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private MetroFramework.Controls.MetroPanel pnlPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnuFiltrar;
        private MetroFramework.Controls.MetroPanel pnlQuery;
        private System.Windows.Forms.SplitContainer spConteiner3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
    }
}

