namespace SG_VTNR
{
    partial class frmUsuario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuario));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlCadastrar = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.pnlEndereco = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.dgvFuncionario = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtPesquisarFuncionario = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnGuardar = new Guna.UI2.WinForms.Guna2Button();
            this.btnNovo = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditar = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.guna2ShadowPanel3 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.cmbPerfil = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtSenha = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeUsuario = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ShadowPanel2 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.label39 = new System.Windows.Forms.Label();
            this.guna2Button7 = new Guna.UI2.WinForms.Guna2Button();
            this.txtNomeFuncionario = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtIDFuncionario = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCodigo = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.dgvDadosUsuario = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ColDeletar = new System.Windows.Forms.DataGridViewImageColumn();
            this.colEditar = new System.Windows.Forms.DataGridViewImageColumn();
            this.colImprimir = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtPesquisar = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlCadastrar.SuspendLayout();
            this.pnlEndereco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).BeginInit();
            this.guna2ShadowPanel3.SuspendLayout();
            this.guna2ShadowPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCadastrar
            // 
            this.pnlCadastrar.BackColor = System.Drawing.Color.Transparent;
            this.pnlCadastrar.Controls.Add(this.pnlEndereco);
            this.pnlCadastrar.Controls.Add(this.txtPesquisarFuncionario);
            this.pnlCadastrar.Controls.Add(this.btnGuardar);
            this.pnlCadastrar.Controls.Add(this.btnNovo);
            this.pnlCadastrar.Controls.Add(this.btnCancelar);
            this.pnlCadastrar.Controls.Add(this.btnEditar);
            this.pnlCadastrar.Controls.Add(this.label4);
            this.pnlCadastrar.Controls.Add(this.label3);
            this.pnlCadastrar.Controls.Add(this.label15);
            this.pnlCadastrar.Controls.Add(this.guna2ShadowPanel3);
            this.pnlCadastrar.Controls.Add(this.guna2ShadowPanel2);
            this.pnlCadastrar.Controls.Add(this.txtNomeFuncionario);
            this.pnlCadastrar.Controls.Add(this.txtIDFuncionario);
            this.pnlCadastrar.Controls.Add(this.txtCodigo);
            this.pnlCadastrar.FillColor = System.Drawing.Color.White;
            this.pnlCadastrar.Location = new System.Drawing.Point(188, 32);
            this.pnlCadastrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlCadastrar.Name = "pnlCadastrar";
            this.pnlCadastrar.Radius = 5;
            this.pnlCadastrar.ShadowColor = System.Drawing.Color.Black;
            this.pnlCadastrar.ShadowShift = 3;
            this.pnlCadastrar.Size = new System.Drawing.Size(1272, 533);
            this.pnlCadastrar.TabIndex = 4;
            this.pnlCadastrar.Visible = false;
            this.pnlCadastrar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCadastrar_Paint);
            // 
            // pnlEndereco
            // 
            this.pnlEndereco.BackColor = System.Drawing.Color.Transparent;
            this.pnlEndereco.Controls.Add(this.dgvFuncionario);
            this.pnlEndereco.FillColor = System.Drawing.Color.White;
            this.pnlEndereco.Location = new System.Drawing.Point(752, 158);
            this.pnlEndereco.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlEndereco.Name = "pnlEndereco";
            this.pnlEndereco.Radius = 2;
            this.pnlEndereco.ShadowColor = System.Drawing.Color.Black;
            this.pnlEndereco.ShadowDepth = 50;
            this.pnlEndereco.Size = new System.Drawing.Size(507, 235);
            this.pnlEndereco.TabIndex = 59;
            this.pnlEndereco.Visible = false;
            // 
            // dgvFuncionario
            // 
            this.dgvFuncionario.AllowUserToAddRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dgvFuncionario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvFuncionario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFuncionario.BackgroundColor = System.Drawing.Color.White;
            this.dgvFuncionario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFuncionario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvFuncionario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFuncionario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvFuncionario.ColumnHeadersHeight = 4;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFuncionario.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvFuncionario.EnableHeadersVisualStyles = false;
            this.dgvFuncionario.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvFuncionario.Location = new System.Drawing.Point(7, 15);
            this.dgvFuncionario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvFuncionario.Name = "dgvFuncionario";
            this.dgvFuncionario.RowHeadersVisible = false;
            this.dgvFuncionario.RowHeadersWidth = 62;
            this.dgvFuncionario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFuncionario.Size = new System.Drawing.Size(484, 206);
            this.dgvFuncionario.TabIndex = 56;
            this.dgvFuncionario.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvFuncionario.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvFuncionario.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvFuncionario.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvFuncionario.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvFuncionario.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvFuncionario.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvFuncionario.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvFuncionario.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvFuncionario.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvFuncionario.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvFuncionario.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvFuncionario.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvFuncionario.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvFuncionario.ThemeStyle.ReadOnly = false;
            this.dgvFuncionario.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvFuncionario.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvFuncionario.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvFuncionario.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvFuncionario.ThemeStyle.RowsStyle.Height = 22;
            this.dgvFuncionario.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvFuncionario.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvFuncionario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFuncionario_CellContentClick);
            // 
            // txtPesquisarFuncionario
            // 
            this.txtPesquisarFuncionario.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPesquisarFuncionario.BorderRadius = 5;
            this.txtPesquisarFuncionario.BorderThickness = 2;
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
            this.txtPesquisarFuncionario.Location = new System.Drawing.Point(752, 96);
            this.txtPesquisarFuncionario.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtPesquisarFuncionario.Name = "txtPesquisarFuncionario";
            this.txtPesquisarFuncionario.PasswordChar = '\0';
            this.txtPesquisarFuncionario.PlaceholderText = "";
            this.txtPesquisarFuncionario.SelectedText = "";
            this.txtPesquisarFuncionario.ShadowDecoration.Parent = this.txtPesquisarFuncionario;
            this.txtPesquisarFuncionario.Size = new System.Drawing.Size(504, 57);
            this.txtPesquisarFuncionario.TabIndex = 58;
            this.txtPesquisarFuncionario.TextChanged += new System.EventHandler(this.txtMostrarFuncionario_TextChanged);
            this.txtPesquisarFuncionario.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtPesquisarFuncionario_MouseClick);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BorderRadius = 5;
            this.btnGuardar.CheckedState.Parent = this.btnGuardar;
            this.btnGuardar.CustomImages.Parent = this.btnGuardar;
            this.btnGuardar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(146)))), ((int)(((byte)(254)))));
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.HoverState.Parent = this.btnGuardar;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(434, 446);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.ShadowDecoration.Parent = this.btnGuardar;
            this.btnGuardar.Size = new System.Drawing.Size(172, 49);
            this.btnGuardar.TabIndex = 56;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.BorderRadius = 5;
            this.btnNovo.CheckedState.Parent = this.btnNovo;
            this.btnNovo.CustomImages.Parent = this.btnNovo;
            this.btnNovo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(146)))), ((int)(((byte)(254)))));
            this.btnNovo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNovo.ForeColor = System.Drawing.Color.White;
            this.btnNovo.HoverState.Parent = this.btnNovo;
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.Location = new System.Drawing.Point(71, 446);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.ShadowDecoration.Parent = this.btnNovo;
            this.btnNovo.Size = new System.Drawing.Size(172, 49);
            this.btnNovo.TabIndex = 53;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BorderRadius = 5;
            this.btnCancelar.CheckedState.Parent = this.btnCancelar;
            this.btnCancelar.CustomImages.Parent = this.btnCancelar;
            this.btnCancelar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.HoverState.Parent = this.btnCancelar;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(616, 446);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.ShadowDecoration.Parent = this.btnCancelar;
            this.btnCancelar.Size = new System.Drawing.Size(172, 49);
            this.btnCancelar.TabIndex = 55;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BorderRadius = 5;
            this.btnEditar.CheckedState.Parent = this.btnEditar;
            this.btnEditar.CustomImages.Parent = this.btnEditar;
            this.btnEditar.FillColor = System.Drawing.Color.Green;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.HoverState.Parent = this.btnEditar;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(252, 446);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.ShadowDecoration.Parent = this.btnEditar;
            this.btnEditar.Size = new System.Drawing.Size(172, 49);
            this.btnEditar.TabIndex = 54;
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(442, 80);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Funcionário";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(197, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Func. ID";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(56, 80);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 20);
            this.label15.TabIndex = 17;
            this.label15.Text = "código";
            // 
            // guna2ShadowPanel3
            // 
            this.guna2ShadowPanel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel3.Controls.Add(this.cmbPerfil);
            this.guna2ShadowPanel3.Controls.Add(this.label16);
            this.guna2ShadowPanel3.Controls.Add(this.txtSenha);
            this.guna2ShadowPanel3.Controls.Add(this.label2);
            this.guna2ShadowPanel3.Controls.Add(this.label1);
            this.guna2ShadowPanel3.Controls.Add(this.txtNomeUsuario);
            this.guna2ShadowPanel3.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel3.Location = new System.Drawing.Point(21, 169);
            this.guna2ShadowPanel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2ShadowPanel3.Name = "guna2ShadowPanel3";
            this.guna2ShadowPanel3.Radius = 2;
            this.guna2ShadowPanel3.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel3.ShadowDepth = 20;
            this.guna2ShadowPanel3.Size = new System.Drawing.Size(683, 224);
            this.guna2ShadowPanel3.TabIndex = 13;
            // 
            // cmbPerfil
            // 
            this.cmbPerfil.BackColor = System.Drawing.Color.Transparent;
            this.cmbPerfil.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbPerfil.BorderRadius = 5;
            this.cmbPerfil.BorderThickness = 2;
            this.cmbPerfil.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPerfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPerfil.FocusedColor = System.Drawing.Color.Empty;
            this.cmbPerfil.FocusedState.Parent = this.cmbPerfil;
            this.cmbPerfil.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbPerfil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbPerfil.FormattingEnabled = true;
            this.cmbPerfil.HoverState.Parent = this.cmbPerfil;
            this.cmbPerfil.ItemHeight = 30;
            this.cmbPerfil.Items.AddRange(new object[] {
            "Admin",
            "Usuario"});
            this.cmbPerfil.ItemsAppearance.Parent = this.cmbPerfil;
            this.cmbPerfil.Location = new System.Drawing.Point(15, 149);
            this.cmbPerfil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbPerfil.Name = "cmbPerfil";
            this.cmbPerfil.ShadowDecoration.Parent = this.cmbPerfil;
            this.cmbPerfil.Size = new System.Drawing.Size(160, 36);
            this.cmbPerfil.TabIndex = 38;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(33, 124);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 20);
            this.label16.TabIndex = 21;
            this.label16.Text = "Perfil";
            // 
            // txtSenha
            // 
            this.txtSenha.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSenha.BorderRadius = 5;
            this.txtSenha.BorderThickness = 2;
            this.txtSenha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSenha.DefaultText = "";
            this.txtSenha.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSenha.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSenha.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSenha.DisabledState.Parent = this.txtSenha;
            this.txtSenha.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSenha.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSenha.FocusedState.Parent = this.txtSenha;
            this.txtSenha.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSenha.HoverState.Parent = this.txtSenha;
            this.txtSenha.Location = new System.Drawing.Point(353, 50);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '\0';
            this.txtSenha.PlaceholderText = "";
            this.txtSenha.SelectedText = "";
            this.txtSenha.ShadowDecoration.Parent = this.txtSenha;
            this.txtSenha.Size = new System.Drawing.Size(316, 57);
            this.txtSenha.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(364, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Senha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nome Usuário";
            // 
            // txtNomeUsuario
            // 
            this.txtNomeUsuario.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNomeUsuario.BorderRadius = 5;
            this.txtNomeUsuario.BorderThickness = 2;
            this.txtNomeUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNomeUsuario.DefaultText = "";
            this.txtNomeUsuario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNomeUsuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNomeUsuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNomeUsuario.DisabledState.Parent = this.txtNomeUsuario;
            this.txtNomeUsuario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNomeUsuario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNomeUsuario.FocusedState.Parent = this.txtNomeUsuario;
            this.txtNomeUsuario.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNomeUsuario.HoverState.Parent = this.txtNomeUsuario;
            this.txtNomeUsuario.Location = new System.Drawing.Point(16, 50);
            this.txtNomeUsuario.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtNomeUsuario.Name = "txtNomeUsuario";
            this.txtNomeUsuario.PasswordChar = '\0';
            this.txtNomeUsuario.PlaceholderText = "";
            this.txtNomeUsuario.SelectedText = "";
            this.txtNomeUsuario.ShadowDecoration.Parent = this.txtNomeUsuario;
            this.txtNomeUsuario.Size = new System.Drawing.Size(332, 57);
            this.txtNomeUsuario.TabIndex = 13;
            // 
            // guna2ShadowPanel2
            // 
            this.guna2ShadowPanel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel2.Controls.Add(this.label39);
            this.guna2ShadowPanel2.Controls.Add(this.guna2Button7);
            this.guna2ShadowPanel2.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel2.Location = new System.Drawing.Point(0, 6);
            this.guna2ShadowPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2ShadowPanel2.Name = "guna2ShadowPanel2";
            this.guna2ShadowPanel2.Radius = 2;
            this.guna2ShadowPanel2.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel2.ShadowDepth = 50;
            this.guna2ShadowPanel2.Size = new System.Drawing.Size(1272, 69);
            this.guna2ShadowPanel2.TabIndex = 12;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.ForeColor = System.Drawing.Color.DimGray;
            this.label39.Location = new System.Drawing.Point(28, 25);
            this.label39.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(288, 29);
            this.label39.TabIndex = 54;
            this.label39.Text = "CADASTRAR USUÁRIO";
            // 
            // guna2Button7
            // 
            this.guna2Button7.BorderRadius = 5;
            this.guna2Button7.CheckedState.Parent = this.guna2Button7;
            this.guna2Button7.CustomImages.Parent = this.guna2Button7;
            this.guna2Button7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(146)))), ((int)(((byte)(254)))));
            this.guna2Button7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button7.ForeColor = System.Drawing.Color.DimGray;
            this.guna2Button7.HoverState.Parent = this.guna2Button7;
            this.guna2Button7.Location = new System.Drawing.Point(1214, 14);
            this.guna2Button7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Button7.Name = "guna2Button7";
            this.guna2Button7.ShadowDecoration.Parent = this.guna2Button7;
            this.guna2Button7.Size = new System.Drawing.Size(42, 42);
            this.guna2Button7.TabIndex = 53;
            this.guna2Button7.Text = "X";
            this.guna2Button7.Click += new System.EventHandler(this.guna2Button7_Click);
            // 
            // txtNomeFuncionario
            // 
            this.txtNomeFuncionario.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNomeFuncionario.BorderRadius = 5;
            this.txtNomeFuncionario.BorderThickness = 2;
            this.txtNomeFuncionario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNomeFuncionario.DefaultText = "Prenc. Automatico";
            this.txtNomeFuncionario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNomeFuncionario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNomeFuncionario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNomeFuncionario.DisabledState.Parent = this.txtNomeFuncionario;
            this.txtNomeFuncionario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNomeFuncionario.Enabled = false;
            this.txtNomeFuncionario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNomeFuncionario.FocusedState.Parent = this.txtNomeFuncionario;
            this.txtNomeFuncionario.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNomeFuncionario.HoverState.Parent = this.txtNomeFuncionario;
            this.txtNomeFuncionario.Location = new System.Drawing.Point(446, 105);
            this.txtNomeFuncionario.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtNomeFuncionario.Name = "txtNomeFuncionario";
            this.txtNomeFuncionario.PasswordChar = '\0';
            this.txtNomeFuncionario.PlaceholderText = "";
            this.txtNomeFuncionario.SelectedText = "";
            this.txtNomeFuncionario.SelectionStart = 17;
            this.txtNomeFuncionario.ShadowDecoration.Parent = this.txtNomeFuncionario;
            this.txtNomeFuncionario.Size = new System.Drawing.Size(223, 55);
            this.txtNomeFuncionario.TabIndex = 8;
            // 
            // txtIDFuncionario
            // 
            this.txtIDFuncionario.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDFuncionario.BorderRadius = 5;
            this.txtIDFuncionario.BorderThickness = 2;
            this.txtIDFuncionario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIDFuncionario.DefaultText = "Prenc. Automatico";
            this.txtIDFuncionario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIDFuncionario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIDFuncionario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDFuncionario.DisabledState.Parent = this.txtIDFuncionario;
            this.txtIDFuncionario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDFuncionario.Enabled = false;
            this.txtIDFuncionario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDFuncionario.FocusedState.Parent = this.txtIDFuncionario;
            this.txtIDFuncionario.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDFuncionario.HoverState.Parent = this.txtIDFuncionario;
            this.txtIDFuncionario.Location = new System.Drawing.Point(201, 105);
            this.txtIDFuncionario.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtIDFuncionario.Name = "txtIDFuncionario";
            this.txtIDFuncionario.PasswordChar = '\0';
            this.txtIDFuncionario.PlaceholderText = "";
            this.txtIDFuncionario.SelectedText = "";
            this.txtIDFuncionario.SelectionStart = 17;
            this.txtIDFuncionario.ShadowDecoration.Parent = this.txtIDFuncionario;
            this.txtIDFuncionario.Size = new System.Drawing.Size(223, 55);
            this.txtIDFuncionario.TabIndex = 8;
            // 
            // txtCodigo
            // 
            this.txtCodigo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCodigo.BorderRadius = 5;
            this.txtCodigo.BorderThickness = 2;
            this.txtCodigo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodigo.DefaultText = "Prenc. Automatico";
            this.txtCodigo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCodigo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCodigo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCodigo.DisabledState.Parent = this.txtCodigo;
            this.txtCodigo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCodigo.Enabled = false;
            this.txtCodigo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCodigo.FocusedState.Parent = this.txtCodigo;
            this.txtCodigo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCodigo.HoverState.Parent = this.txtCodigo;
            this.txtCodigo.Location = new System.Drawing.Point(36, 105);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.PasswordChar = '\0';
            this.txtCodigo.PlaceholderText = "";
            this.txtCodigo.SelectedText = "";
            this.txtCodigo.SelectionStart = 17;
            this.txtCodigo.ShadowDecoration.Parent = this.txtCodigo;
            this.txtCodigo.Size = new System.Drawing.Size(130, 55);
            this.txtCodigo.TabIndex = 8;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 5;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(18, 87);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(154, 55);
            this.guna2Button1.TabIndex = 14;
            this.guna2Button1.Text = "adicionar";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // dgvDadosUsuario
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.dgvDadosUsuario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvDadosUsuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDadosUsuario.BackgroundColor = System.Drawing.Color.White;
            this.dgvDadosUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDadosUsuario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDadosUsuario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDadosUsuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvDadosUsuario.ColumnHeadersHeight = 30;
            this.dgvDadosUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColDeletar,
            this.colEditar,
            this.colImprimir});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDadosUsuario.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvDadosUsuario.EnableHeadersVisualStyles = false;
            this.dgvDadosUsuario.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDadosUsuario.Location = new System.Drawing.Point(18, 170);
            this.dgvDadosUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvDadosUsuario.Name = "dgvDadosUsuario";
            this.dgvDadosUsuario.RowHeadersVisible = false;
            this.dgvDadosUsuario.RowHeadersWidth = 62;
            this.dgvDadosUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDadosUsuario.Size = new System.Drawing.Size(1612, 609);
            this.dgvDadosUsuario.TabIndex = 13;
            this.dgvDadosUsuario.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvDadosUsuario.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDadosUsuario.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDadosUsuario.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDadosUsuario.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDadosUsuario.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDadosUsuario.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvDadosUsuario.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDadosUsuario.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvDadosUsuario.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDadosUsuario.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvDadosUsuario.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDadosUsuario.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDadosUsuario.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvDadosUsuario.ThemeStyle.ReadOnly = false;
            this.dgvDadosUsuario.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDadosUsuario.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDadosUsuario.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvDadosUsuario.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDadosUsuario.ThemeStyle.RowsStyle.Height = 22;
            this.dgvDadosUsuario.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDadosUsuario.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDadosUsuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellContentClick);
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
            // txtPesquisar
            // 
            this.txtPesquisar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPesquisar.BorderRadius = 5;
            this.txtPesquisar.BorderThickness = 2;
            this.txtPesquisar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPesquisar.DefaultText = "";
            this.txtPesquisar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPesquisar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPesquisar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPesquisar.DisabledState.Parent = this.txtPesquisar;
            this.txtPesquisar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPesquisar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPesquisar.FocusedState.Parent = this.txtPesquisar;
            this.txtPesquisar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPesquisar.HoverState.Parent = this.txtPesquisar;
            this.txtPesquisar.Location = new System.Drawing.Point(1312, 87);
            this.txtPesquisar.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.PasswordChar = '\0';
            this.txtPesquisar.PlaceholderText = "";
            this.txtPesquisar.SelectedText = "";
            this.txtPesquisar.ShadowDecoration.Parent = this.txtPesquisar;
            this.txtPesquisar.Size = new System.Drawing.Size(318, 55);
            this.txtPesquisar.TabIndex = 15;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1648, 866);
            this.Controls.Add(this.pnlCadastrar);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.dgvDadosUsuario);
            this.Controls.Add(this.txtPesquisar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUsuario";
            this.Text = "frmUsuario";
            this.Load += new System.EventHandler(this.frmUsuario_Load);
            this.pnlCadastrar.ResumeLayout(false);
            this.pnlCadastrar.PerformLayout();
            this.pnlEndereco.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).EndInit();
            this.guna2ShadowPanel3.ResumeLayout(false);
            this.guna2ShadowPanel3.PerformLayout();
            this.guna2ShadowPanel2.ResumeLayout(false);
            this.guna2ShadowPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel pnlCadastrar;
        private Guna.UI2.WinForms.Guna2Button btnGuardar;
        private Guna.UI2.WinForms.Guna2Button btnNovo;
        private Guna.UI2.WinForms.Guna2Button btnCancelar;
        private Guna.UI2.WinForms.Guna2Button btnEditar;
        private System.Windows.Forms.Label label15;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel3;
        private System.Windows.Forms.Label label16;
        private Guna.UI2.WinForms.Guna2TextBox txtSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtNomeUsuario;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel2;
        private System.Windows.Forms.Label label39;
        private Guna.UI2.WinForms.Guna2Button guna2Button7;
        private Guna.UI2.WinForms.Guna2TextBox txtCodigo;
        private Guna.UI2.WinForms.Guna2ComboBox cmbPerfil;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDadosUsuario;
        private System.Windows.Forms.DataGridViewImageColumn ColDeletar;
        private System.Windows.Forms.DataGridViewImageColumn colEditar;
        private System.Windows.Forms.DataGridViewImageColumn colImprimir;
        private Guna.UI2.WinForms.Guna2TextBox txtPesquisar;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlEndereco;
        private Guna.UI2.WinForms.Guna2DataGridView dgvFuncionario;
        public Guna.UI2.WinForms.Guna2TextBox txtPesquisarFuncionario;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtIDFuncionario;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtNomeFuncionario;
    }
}