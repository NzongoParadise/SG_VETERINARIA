namespace SG_VTNR
{
    partial class frmMarcacaoConsulta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMarcacaoConsulta));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gunaShadowPanel2 = new Guna.UI.WinForms.GunaShadowPanel();
            this.dgvMostrarConsultasAgendadas = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ColDeletar = new System.Windows.Forms.DataGridViewImageColumn();
            this.colEditar = new System.Windows.Forms.DataGridViewImageColumn();
            this.colImprimir = new System.Windows.Forms.DataGridViewImageColumn();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button6 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.guna2Button14 = new Guna.UI2.WinForms.Guna2Button();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.btnPrevios = new Guna.UI2.WinForms.Guna2Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.daycontainer = new System.Windows.Forms.FlowLayoutPanel();
            this.lblDate = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtNomeFuncionario = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbmSelecionarTipoPesquisa = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dataInicial = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dataFinal = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtCodFuncionario = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlMostrarFuncionario = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.dgvMostrarFuncionario = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtPesquisarFuncionario = new Guna.UI2.WinForms.Guna2TextBox();
            this.userControlDays1 = new SG_VTNR.UserControlDays();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gunaShadowPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarConsultasAgendadas)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.guna2ShadowPanel1.SuspendLayout();
            this.daycontainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlMostrarFuncionario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-1, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1651, 764);
            this.tabControl1.TabIndex = 66;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pnlMostrarFuncionario);
            this.tabPage1.Controls.Add(this.gunaShadowPanel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1643, 731);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ver Consultas Agendadas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gunaShadowPanel2
            // 
            this.gunaShadowPanel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel2.BaseColor = System.Drawing.Color.White;
            this.gunaShadowPanel2.Controls.Add(this.label2);
            this.gunaShadowPanel2.Controls.Add(this.label3);
            this.gunaShadowPanel2.Controls.Add(this.label1);
            this.gunaShadowPanel2.Controls.Add(this.dataFinal);
            this.gunaShadowPanel2.Controls.Add(this.dataInicial);
            this.gunaShadowPanel2.Controls.Add(this.cbmSelecionarTipoPesquisa);
            this.gunaShadowPanel2.Controls.Add(this.pictureBox2);
            this.gunaShadowPanel2.Controls.Add(this.txtCodFuncionario);
            this.gunaShadowPanel2.Controls.Add(this.txtPesquisarFuncionario);
            this.gunaShadowPanel2.Controls.Add(this.txtNomeFuncionario);
            this.gunaShadowPanel2.Controls.Add(this.dgvMostrarConsultasAgendadas);
            this.gunaShadowPanel2.Controls.Add(this.guna2Button3);
            this.gunaShadowPanel2.Controls.Add(this.guna2Button6);
            this.gunaShadowPanel2.Controls.Add(this.guna2Button2);
            this.gunaShadowPanel2.Controls.Add(this.guna2Button1);
            this.gunaShadowPanel2.Controls.Add(this.guna2Button5);
            this.gunaShadowPanel2.Controls.Add(this.guna2Button4);
            this.gunaShadowPanel2.Location = new System.Drawing.Point(6, 5);
            this.gunaShadowPanel2.Name = "gunaShadowPanel2";
            this.gunaShadowPanel2.ShadowColor = System.Drawing.Color.Black;
            this.gunaShadowPanel2.Size = new System.Drawing.Size(1533, 730);
            this.gunaShadowPanel2.TabIndex = 22;
            this.gunaShadowPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaShadowPanel2_Paint);
            // 
            // dgvMostrarConsultasAgendadas
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.dgvMostrarConsultasAgendadas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvMostrarConsultasAgendadas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMostrarConsultasAgendadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMostrarConsultasAgendadas.BackgroundColor = System.Drawing.Color.White;
            this.dgvMostrarConsultasAgendadas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMostrarConsultasAgendadas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMostrarConsultasAgendadas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMostrarConsultasAgendadas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvMostrarConsultasAgendadas.ColumnHeadersHeight = 30;
            this.dgvMostrarConsultasAgendadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColDeletar,
            this.colEditar,
            this.colImprimir});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMostrarConsultasAgendadas.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvMostrarConsultasAgendadas.EnableHeadersVisualStyles = false;
            this.dgvMostrarConsultasAgendadas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMostrarConsultasAgendadas.Location = new System.Drawing.Point(4, 162);
            this.dgvMostrarConsultasAgendadas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvMostrarConsultasAgendadas.Name = "dgvMostrarConsultasAgendadas";
            this.dgvMostrarConsultasAgendadas.RowHeadersVisible = false;
            this.dgvMostrarConsultasAgendadas.RowHeadersWidth = 62;
            this.dgvMostrarConsultasAgendadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMostrarConsultasAgendadas.Size = new System.Drawing.Size(1525, 578);
            this.dgvMostrarConsultasAgendadas.TabIndex = 22;
            this.dgvMostrarConsultasAgendadas.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvMostrarConsultasAgendadas.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMostrarConsultasAgendadas.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvMostrarConsultasAgendadas.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvMostrarConsultasAgendadas.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvMostrarConsultasAgendadas.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvMostrarConsultasAgendadas.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvMostrarConsultasAgendadas.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMostrarConsultasAgendadas.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvMostrarConsultasAgendadas.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMostrarConsultasAgendadas.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvMostrarConsultasAgendadas.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvMostrarConsultasAgendadas.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvMostrarConsultasAgendadas.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvMostrarConsultasAgendadas.ThemeStyle.ReadOnly = false;
            this.dgvMostrarConsultasAgendadas.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMostrarConsultasAgendadas.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMostrarConsultasAgendadas.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvMostrarConsultasAgendadas.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvMostrarConsultasAgendadas.ThemeStyle.RowsStyle.Height = 22;
            this.dgvMostrarConsultasAgendadas.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMostrarConsultasAgendadas.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvMostrarConsultasAgendadas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMostrarConsultasAgendadas_CellContentClick);
            // 
            // ColDeletar
            // 
            this.ColDeletar.HeaderText = "DELETAR";
            this.ColDeletar.Image = ((System.Drawing.Image)(resources.GetObject("ColDeletar.Image")));
            this.ColDeletar.MinimumWidth = 8;
            this.ColDeletar.Name = "ColDeletar";
            // 
            // colEditar
            // 
            this.colEditar.HeaderText = "EDITAR";
            this.colEditar.Image = ((System.Drawing.Image)(resources.GetObject("colEditar.Image")));
            this.colEditar.MinimumWidth = 8;
            this.colEditar.Name = "colEditar";
            // 
            // colImprimir
            // 
            this.colImprimir.HeaderText = "IMPRIMIR";
            this.colImprimir.Image = ((System.Drawing.Image)(resources.GetObject("colImprimir.Image")));
            this.colImprimir.MinimumWidth = 8;
            this.colImprimir.Name = "colImprimir";
            // 
            // guna2Button3
            // 
            this.guna2Button3.BorderRadius = 5;
            this.guna2Button3.CheckedState.Parent = this.guna2Button3;
            this.guna2Button3.CustomImages.Parent = this.guna2Button3;
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.HoverState.Parent = this.guna2Button3;
            this.guna2Button3.Location = new System.Drawing.Point(872, 37);
            this.guna2Button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.ShadowDecoration.Parent = this.guna2Button3;
            this.guna2Button3.Size = new System.Drawing.Size(154, 55);
            this.guna2Button3.TabIndex = 4;
            this.guna2Button3.Text = "Mês";
            // 
            // guna2Button6
            // 
            this.guna2Button6.BorderRadius = 5;
            this.guna2Button6.CheckedState.Parent = this.guna2Button6;
            this.guna2Button6.CustomImages.Parent = this.guna2Button6;
            this.guna2Button6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button6.ForeColor = System.Drawing.Color.White;
            this.guna2Button6.HoverState.Parent = this.guna2Button6;
            this.guna2Button6.Location = new System.Drawing.Point(206, 37);
            this.guna2Button6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Button6.Name = "guna2Button6";
            this.guna2Button6.ShadowDecoration.Parent = this.guna2Button6;
            this.guna2Button6.Size = new System.Drawing.Size(78, 55);
            this.guna2Button6.TabIndex = 4;
            this.guna2Button6.Text = "Hoje";
            // 
            // guna2Button2
            // 
            this.guna2Button2.BorderRadius = 5;
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Location = new System.Drawing.Point(1034, 37);
            this.guna2Button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(154, 55);
            this.guna2Button2.TabIndex = 3;
            this.guna2Button2.Text = "Semana";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 5;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(1196, 37);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(154, 55);
            this.guna2Button1.TabIndex = 2;
            this.guna2Button1.Text = "Dia";
            // 
            // guna2Button5
            // 
            this.guna2Button5.BorderRadius = 5;
            this.guna2Button5.CheckedState.Parent = this.guna2Button5;
            this.guna2Button5.CustomImages.Parent = this.guna2Button5;
            this.guna2Button5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button5.ForeColor = System.Drawing.Color.White;
            this.guna2Button5.HoverState.Parent = this.guna2Button5;
            this.guna2Button5.Location = new System.Drawing.Point(106, 37);
            this.guna2Button5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Button5.Name = "guna2Button5";
            this.guna2Button5.ShadowDecoration.Parent = this.guna2Button5;
            this.guna2Button5.Size = new System.Drawing.Size(78, 55);
            this.guna2Button5.TabIndex = 4;
            this.guna2Button5.Text = "Seg.";
            // 
            // guna2Button4
            // 
            this.guna2Button4.BorderRadius = 5;
            this.guna2Button4.CheckedState.Parent = this.guna2Button4;
            this.guna2Button4.CustomImages.Parent = this.guna2Button4;
            this.guna2Button4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.HoverState.Parent = this.guna2Button4;
            this.guna2Button4.Location = new System.Drawing.Point(20, 37);
            this.guna2Button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.ShadowDecoration.Parent = this.guna2Button4;
            this.guna2Button4.Size = new System.Drawing.Size(78, 55);
            this.guna2Button4.TabIndex = 4;
            this.guna2Button4.Text = "Anter.";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.guna2Button14);
            this.tabPage2.Controls.Add(this.btnNext);
            this.tabPage2.Controls.Add(this.btnPrevios);
            this.tabPage2.Controls.Add(this.dateTimePicker2);
            this.tabPage2.Controls.Add(this.guna2ShadowPanel1);
            this.tabPage2.Controls.Add(this.daycontainer);
            this.tabPage2.Controls.Add(this.lblDate);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1643, 731);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Marcar Consulta";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // guna2Button14
            // 
            this.guna2Button14.BorderRadius = 5;
            this.guna2Button14.CheckedState.Parent = this.guna2Button14;
            this.guna2Button14.CustomImages.Parent = this.guna2Button14;
            this.guna2Button14.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button14.ForeColor = System.Drawing.Color.White;
            this.guna2Button14.HoverState.Parent = this.guna2Button14;
            this.guna2Button14.Location = new System.Drawing.Point(741, 578);
            this.guna2Button14.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Button14.Name = "guna2Button14";
            this.guna2Button14.ShadowDecoration.Parent = this.guna2Button14;
            this.guna2Button14.Size = new System.Drawing.Size(124, 55);
            this.guna2Button14.TabIndex = 5;
            this.guna2Button14.Text = "Hoje";
            // 
            // btnNext
            // 
            this.btnNext.BorderRadius = 5;
            this.btnNext.CheckedState.Parent = this.btnNext;
            this.btnNext.CustomImages.Parent = this.btnNext;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.HoverState.Parent = this.btnNext;
            this.btnNext.Location = new System.Drawing.Point(603, 578);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNext.Name = "btnNext";
            this.btnNext.ShadowDecoration.Parent = this.btnNext;
            this.btnNext.Size = new System.Drawing.Size(124, 55);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Seg.";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click_1);
            // 
            // btnPrevios
            // 
            this.btnPrevios.BorderRadius = 5;
            this.btnPrevios.CheckedState.Parent = this.btnPrevios;
            this.btnPrevios.CustomImages.Parent = this.btnPrevios;
            this.btnPrevios.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPrevios.ForeColor = System.Drawing.Color.White;
            this.btnPrevios.HoverState.Parent = this.btnPrevios;
            this.btnPrevios.Location = new System.Drawing.Point(462, 578);
            this.btnPrevios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPrevios.Name = "btnPrevios";
            this.btnPrevios.ShadowDecoration.Parent = this.btnPrevios;
            this.btnPrevios.Size = new System.Drawing.Size(124, 58);
            this.btnPrevios.TabIndex = 7;
            this.btnPrevios.Text = "Anter.";
            this.btnPrevios.Click += new System.EventHandler(this.btnPrevios_Click_1);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(19, 15);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.label15);
            this.guna2ShadowPanel1.Controls.Add(this.label14);
            this.guna2ShadowPanel1.Controls.Add(this.label11);
            this.guna2ShadowPanel1.Controls.Add(this.label12);
            this.guna2ShadowPanel1.Controls.Add(this.label10);
            this.guna2ShadowPanel1.Controls.Add(this.label9);
            this.guna2ShadowPanel1.Controls.Add(this.label8);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(19, 43);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.ShadowDepth = 10;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(1383, 42);
            this.guna2ShadowPanel1.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1178, 12);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 20);
            this.label15.TabIndex = 0;
            this.label15.Text = "Sábado";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1046, 12);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 20);
            this.label14.TabIndex = 0;
            this.label14.Text = "Sexta Feira";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(862, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Quinta Feira";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(654, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Quarta Feira";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(464, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Terça Feira";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(244, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Segunda Feira";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Domingo";
            // 
            // daycontainer
            // 
            this.daycontainer.Controls.Add(this.userControlDays1);
            this.daycontainer.Location = new System.Drawing.Point(19, 91);
            this.daycontainer.Name = "daycontainer";
            this.daycontainer.Size = new System.Drawing.Size(1383, 453);
            this.daycontainer.TabIndex = 0;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(1180, 21);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(39, 20);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Mês";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SG_VTNR.Properties.Resources.search_500px1;
            this.pictureBox2.Location = new System.Drawing.Point(813, 54);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 132;
            this.pictureBox2.TabStop = false;
            // 
            // txtNomeFuncionario
            // 
            this.txtNomeFuncionario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNomeFuncionario.DefaultText = "";
            this.txtNomeFuncionario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNomeFuncionario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNomeFuncionario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNomeFuncionario.DisabledState.Parent = this.txtNomeFuncionario;
            this.txtNomeFuncionario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNomeFuncionario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNomeFuncionario.FocusedState.Parent = this.txtNomeFuncionario;
            this.txtNomeFuncionario.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNomeFuncionario.HoverState.Parent = this.txtNomeFuncionario;
            this.txtNomeFuncionario.Location = new System.Drawing.Point(522, 114);
            this.txtNomeFuncionario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNomeFuncionario.Name = "txtNomeFuncionario";
            this.txtNomeFuncionario.PasswordChar = '\0';
            this.txtNomeFuncionario.PlaceholderText = "";
            this.txtNomeFuncionario.SelectedText = "";
            this.txtNomeFuncionario.ShadowDecoration.Parent = this.txtNomeFuncionario;
            this.txtNomeFuncionario.Size = new System.Drawing.Size(342, 46);
            this.txtNomeFuncionario.TabIndex = 24;
            // 
            // cbmSelecionarTipoPesquisa
            // 
            this.cbmSelecionarTipoPesquisa.BackColor = System.Drawing.Color.Transparent;
            this.cbmSelecionarTipoPesquisa.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbmSelecionarTipoPesquisa.BorderRadius = 5;
            this.cbmSelecionarTipoPesquisa.BorderThickness = 2;
            this.cbmSelecionarTipoPesquisa.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbmSelecionarTipoPesquisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmSelecionarTipoPesquisa.FocusedColor = System.Drawing.Color.Empty;
            this.cbmSelecionarTipoPesquisa.FocusedState.Parent = this.cbmSelecionarTipoPesquisa;
            this.cbmSelecionarTipoPesquisa.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbmSelecionarTipoPesquisa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbmSelecionarTipoPesquisa.FormattingEnabled = true;
            this.cbmSelecionarTipoPesquisa.HoverState.Parent = this.cbmSelecionarTipoPesquisa;
            this.cbmSelecionarTipoPesquisa.ItemHeight = 20;
            this.cbmSelecionarTipoPesquisa.Items.AddRange(new object[] {
            "Pesquisar por data",
            "Pesquisar por Veterinário",
            "Pesquisa po proprietário",
            "Pesquisar por Intervalo de Horário",
            "Pesquisar por Status da consulta",
            "Consultas Regulares",
            "Conusultas Canceladas",
            "Consultas Marcadas",
            "Consultas em Andamento",
            "Não Compareceu",
            "Em espera",
            "Reagendada",
            "Concluída"});
            this.cbmSelecionarTipoPesquisa.ItemsAppearance.Parent = this.cbmSelecionarTipoPesquisa;
            this.cbmSelecionarTipoPesquisa.Location = new System.Drawing.Point(872, 126);
            this.cbmSelecionarTipoPesquisa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbmSelecionarTipoPesquisa.Name = "cbmSelecionarTipoPesquisa";
            this.cbmSelecionarTipoPesquisa.ShadowDecoration.Parent = this.cbmSelecionarTipoPesquisa;
            this.cbmSelecionarTipoPesquisa.Size = new System.Drawing.Size(360, 26);
            this.cbmSelecionarTipoPesquisa.TabIndex = 133;
            this.cbmSelecionarTipoPesquisa.SelectedIndexChanged += new System.EventHandler(this.cbmSelecionarTipoPesquisa_SelectedIndexChanged);
            // 
            // dataInicial
            // 
            this.dataInicial.CheckedState.Parent = this.dataInicial;
            this.dataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dataInicial.HoverState.Parent = this.dataInicial;
            this.dataInicial.Location = new System.Drawing.Point(4, 110);
            this.dataInicial.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dataInicial.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dataInicial.Name = "dataInicial";
            this.dataInicial.ShadowDecoration.Parent = this.dataInicial;
            this.dataInicial.Size = new System.Drawing.Size(221, 42);
            this.dataInicial.TabIndex = 134;
            this.dataInicial.Value = new System.DateTime(2024, 2, 17, 4, 24, 21, 280);
            this.dataInicial.ValueChanged += new System.EventHandler(this.dataInicial_ValueChanged);
            // 
            // dataFinal
            // 
            this.dataFinal.CheckedState.Parent = this.dataFinal;
            this.dataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dataFinal.HoverState.Parent = this.dataFinal;
            this.dataFinal.Location = new System.Drawing.Point(253, 110);
            this.dataFinal.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dataFinal.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dataFinal.Name = "dataFinal";
            this.dataFinal.ShadowDecoration.Parent = this.dataFinal;
            this.dataFinal.Size = new System.Drawing.Size(221, 42);
            this.dataFinal.TabIndex = 135;
            this.dataFinal.Value = new System.DateTime(2024, 2, 17, 4, 24, 24, 62);
            this.dataFinal.ValueChanged += new System.EventHandler(this.dataFinal_ValueChanged);
            // 
            // txtCodFuncionario
            // 
            this.txtCodFuncionario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodFuncionario.DefaultText = "";
            this.txtCodFuncionario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCodFuncionario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCodFuncionario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCodFuncionario.DisabledState.Parent = this.txtCodFuncionario;
            this.txtCodFuncionario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCodFuncionario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCodFuncionario.FocusedState.Parent = this.txtCodFuncionario;
            this.txtCodFuncionario.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCodFuncionario.HoverState.Parent = this.txtCodFuncionario;
            this.txtCodFuncionario.Location = new System.Drawing.Point(399, 46);
            this.txtCodFuncionario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCodFuncionario.Name = "txtCodFuncionario";
            this.txtCodFuncionario.PasswordChar = '\0';
            this.txtCodFuncionario.PlaceholderText = "";
            this.txtCodFuncionario.SelectedText = "";
            this.txtCodFuncionario.ShadowDecoration.Parent = this.txtCodFuncionario;
            this.txtCodFuncionario.Size = new System.Drawing.Size(115, 46);
            this.txtCodFuncionario.TabIndex = 24;
            this.txtCodFuncionario.TextChanged += new System.EventHandler(this.txtCodFuncionario_TextChanged);
            // 
            // pnlMostrarFuncionario
            // 
            this.pnlMostrarFuncionario.BackColor = System.Drawing.Color.Transparent;
            this.pnlMostrarFuncionario.Controls.Add(this.dgvMostrarFuncionario);
            this.pnlMostrarFuncionario.FillColor = System.Drawing.Color.White;
            this.pnlMostrarFuncionario.Location = new System.Drawing.Point(0, 167);
            this.pnlMostrarFuncionario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlMostrarFuncionario.Name = "pnlMostrarFuncionario";
            this.pnlMostrarFuncionario.Radius = 2;
            this.pnlMostrarFuncionario.ShadowColor = System.Drawing.Color.Black;
            this.pnlMostrarFuncionario.ShadowDepth = 50;
            this.pnlMostrarFuncionario.Size = new System.Drawing.Size(1531, 174);
            this.pnlMostrarFuncionario.TabIndex = 136;
            this.pnlMostrarFuncionario.Visible = false;
            // 
            // dgvMostrarFuncionario
            // 
            this.dgvMostrarFuncionario.AllowUserToAddRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            this.dgvMostrarFuncionario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvMostrarFuncionario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMostrarFuncionario.BackgroundColor = System.Drawing.Color.White;
            this.dgvMostrarFuncionario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMostrarFuncionario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMostrarFuncionario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMostrarFuncionario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvMostrarFuncionario.ColumnHeadersHeight = 4;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMostrarFuncionario.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvMostrarFuncionario.EnableHeadersVisualStyles = false;
            this.dgvMostrarFuncionario.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMostrarFuncionario.Location = new System.Drawing.Point(-5, 14);
            this.dgvMostrarFuncionario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvMostrarFuncionario.Name = "dgvMostrarFuncionario";
            this.dgvMostrarFuncionario.ReadOnly = true;
            this.dgvMostrarFuncionario.RowHeadersVisible = false;
            this.dgvMostrarFuncionario.RowHeadersWidth = 62;
            this.dgvMostrarFuncionario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMostrarFuncionario.Size = new System.Drawing.Size(1532, 155);
            this.dgvMostrarFuncionario.TabIndex = 56;
            this.dgvMostrarFuncionario.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvMostrarFuncionario.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMostrarFuncionario.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvMostrarFuncionario.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvMostrarFuncionario.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvMostrarFuncionario.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvMostrarFuncionario.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvMostrarFuncionario.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMostrarFuncionario.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvMostrarFuncionario.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMostrarFuncionario.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvMostrarFuncionario.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvMostrarFuncionario.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvMostrarFuncionario.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvMostrarFuncionario.ThemeStyle.ReadOnly = true;
            this.dgvMostrarFuncionario.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMostrarFuncionario.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMostrarFuncionario.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvMostrarFuncionario.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dgvMostrarFuncionario.ThemeStyle.RowsStyle.Height = 22;
            this.dgvMostrarFuncionario.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMostrarFuncionario.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvMostrarFuncionario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMostrarFuncionario_CellContentClick);
            // 
            // txtPesquisarFuncionario
            // 
            this.txtPesquisarFuncionario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPesquisarFuncionario.DefaultText = "";
            this.txtPesquisarFuncionario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPesquisarFuncionario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPesquisarFuncionario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPesquisarFuncionario.DisabledState.Parent = this.txtPesquisarFuncionario;
            this.txtPesquisarFuncionario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPesquisarFuncionario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPesquisarFuncionario.FocusedState.Parent = this.txtPesquisarFuncionario;
            this.txtPesquisarFuncionario.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPesquisarFuncionario.HoverState.Parent = this.txtPesquisarFuncionario;
            this.txtPesquisarFuncionario.Location = new System.Drawing.Point(522, 46);
            this.txtPesquisarFuncionario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPesquisarFuncionario.Name = "txtPesquisarFuncionario";
            this.txtPesquisarFuncionario.PasswordChar = '\0';
            this.txtPesquisarFuncionario.PlaceholderText = "";
            this.txtPesquisarFuncionario.SelectedText = "";
            this.txtPesquisarFuncionario.ShadowDecoration.Parent = this.txtPesquisarFuncionario;
            this.txtPesquisarFuncionario.Size = new System.Drawing.Size(342, 46);
            this.txtPesquisarFuncionario.TabIndex = 24;
            this.txtPesquisarFuncionario.TextChanged += new System.EventHandler(this.txtPesquisarFuncionario_TextChanged);
            // 
            // userControlDays1
            // 
            this.userControlDays1.Location = new System.Drawing.Point(3, 3);
            this.userControlDays1.Name = "userControlDays1";
            this.userControlDays1.Size = new System.Drawing.Size(190, 70);
            this.userControlDays1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(403, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 136;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(518, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 20);
            this.label2.TabIndex = 136;
            this.label2.Text = "Pesquisar Veterinário";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(522, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 136;
            this.label3.Text = "Nome Veterinário";
            // 
            // frmMarcacaoConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1560, 876);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMarcacaoConsulta";
            this.Text = "frmMarcacaoConsulta";
            this.Load += new System.EventHandler(this.frmMarcacaoConsulta_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gunaShadowPanel2.ResumeLayout(false);
            this.gunaShadowPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarConsultasAgendadas)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            this.daycontainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlMostrarFuncionario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarFuncionario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel2;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button6;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private System.Windows.Forms.TabPage tabPage2;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.FlowLayoutPanel daycontainer;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private Guna.UI2.WinForms.Guna2Button guna2Button14;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private Guna.UI2.WinForms.Guna2Button btnPrevios;
        private UserControlDays userControlDays1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvMostrarConsultasAgendadas;
        private System.Windows.Forms.DataGridViewImageColumn ColDeletar;
        private System.Windows.Forms.DataGridViewImageColumn colEditar;
        private System.Windows.Forms.DataGridViewImageColumn colImprimir;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2TextBox txtNomeFuncionario;
        public Guna.UI2.WinForms.Guna2ComboBox cbmSelecionarTipoPesquisa;
        private Guna.UI2.WinForms.Guna2DateTimePicker dataFinal;
        private Guna.UI2.WinForms.Guna2DateTimePicker dataInicial;
        private Guna.UI2.WinForms.Guna2TextBox txtCodFuncionario;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlMostrarFuncionario;
        private Guna.UI2.WinForms.Guna2DataGridView dgvMostrarFuncionario;
        private Guna.UI2.WinForms.Guna2TextBox txtPesquisarFuncionario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}