namespace SG_VTNR
{
    partial class frmMedicamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMedicamento));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlCadastrar = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.btnGuardar = new Guna.UI2.WinForms.Guna2Button();
            this.btnNovo = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditar = new Guna.UI2.WinForms.Guna2Button();
            this.label15 = new System.Windows.Forms.Label();
            this.guna2ShadowPanel3 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAbreviacao = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDescricao = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtInstrucoes = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDosagem = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFabricante = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtFormaFarmac = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtConcentracao = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNomeMedicamento = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ShadowPanel2 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.label39 = new System.Windows.Forms.Label();
            this.guna2Button7 = new Guna.UI2.WinForms.Guna2Button();
            this.txtCodigo = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ShadowPanel6 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.dgvDados = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ColDeletar = new System.Windows.Forms.DataGridViewImageColumn();
            this.colEditar = new System.Windows.Forms.DataGridViewImageColumn();
            this.colImprimir = new System.Windows.Forms.DataGridViewImageColumn();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.txtPesquisar = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbTipoMed = new Guna.UI2.WinForms.Guna2ComboBox();
            this.pnlCadastrar.SuspendLayout();
            this.guna2ShadowPanel3.SuspendLayout();
            this.guna2ShadowPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCadastrar
            // 
            this.pnlCadastrar.BackColor = System.Drawing.Color.Transparent;
            this.pnlCadastrar.Controls.Add(this.btnGuardar);
            this.pnlCadastrar.Controls.Add(this.btnNovo);
            this.pnlCadastrar.Controls.Add(this.btnCancelar);
            this.pnlCadastrar.Controls.Add(this.btnEditar);
            this.pnlCadastrar.Controls.Add(this.label15);
            this.pnlCadastrar.Controls.Add(this.guna2ShadowPanel3);
            this.pnlCadastrar.Controls.Add(this.guna2ShadowPanel2);
            this.pnlCadastrar.Controls.Add(this.txtCodigo);
            this.pnlCadastrar.FillColor = System.Drawing.Color.White;
            this.pnlCadastrar.Location = new System.Drawing.Point(211, 72);
            this.pnlCadastrar.Name = "pnlCadastrar";
            this.pnlCadastrar.Radius = 5;
            this.pnlCadastrar.ShadowColor = System.Drawing.Color.Black;
            this.pnlCadastrar.ShadowShift = 3;
            this.pnlCadastrar.Size = new System.Drawing.Size(714, 395);
            this.pnlCadastrar.TabIndex = 4;
            this.pnlCadastrar.Visible = false;
            this.pnlCadastrar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCadastrar_Paint);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BorderRadius = 5;
            this.btnGuardar.CheckedState.Parent = this.btnGuardar;
            this.btnGuardar.CustomImages.Parent = this.btnGuardar;
            this.btnGuardar.Enabled = false;
            this.btnGuardar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(146)))), ((int)(((byte)(254)))));
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.HoverState.Parent = this.btnGuardar;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(447, 346);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.ShadowDecoration.Parent = this.btnGuardar;
            this.btnGuardar.Size = new System.Drawing.Size(115, 32);
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
            this.btnNovo.Location = new System.Drawing.Point(205, 346);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.ShadowDecoration.Parent = this.btnNovo;
            this.btnNovo.Size = new System.Drawing.Size(115, 32);
            this.btnNovo.TabIndex = 53;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BorderRadius = 5;
            this.btnCancelar.CheckedState.Parent = this.btnCancelar;
            this.btnCancelar.CustomImages.Parent = this.btnCancelar;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.HoverState.Parent = this.btnCancelar;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(569, 346);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.ShadowDecoration.Parent = this.btnCancelar;
            this.btnCancelar.Size = new System.Drawing.Size(115, 32);
            this.btnCancelar.TabIndex = 55;
            this.btnCancelar.Text = "Cancelar";
            // 
            // btnEditar
            // 
            this.btnEditar.BorderRadius = 5;
            this.btnEditar.CheckedState.Parent = this.btnEditar;
            this.btnEditar.CustomImages.Parent = this.btnEditar;
            this.btnEditar.Enabled = false;
            this.btnEditar.FillColor = System.Drawing.Color.Green;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.HoverState.Parent = this.btnEditar;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(326, 346);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.ShadowDecoration.Parent = this.btnEditar;
            this.btnEditar.Size = new System.Drawing.Size(115, 32);
            this.btnEditar.TabIndex = 54;
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(37, 52);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 13);
            this.label15.TabIndex = 17;
            this.label15.Text = "código";
            // 
            // guna2ShadowPanel3
            // 
            this.guna2ShadowPanel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel3.Controls.Add(this.cmbTipoMed);
            this.guna2ShadowPanel3.Controls.Add(this.label13);
            this.guna2ShadowPanel3.Controls.Add(this.label11);
            this.guna2ShadowPanel3.Controls.Add(this.label14);
            this.guna2ShadowPanel3.Controls.Add(this.label17);
            this.guna2ShadowPanel3.Controls.Add(this.label8);
            this.guna2ShadowPanel3.Controls.Add(this.label2);
            this.guna2ShadowPanel3.Controls.Add(this.txtAbreviacao);
            this.guna2ShadowPanel3.Controls.Add(this.txtDescricao);
            this.guna2ShadowPanel3.Controls.Add(this.txtInstrucoes);
            this.guna2ShadowPanel3.Controls.Add(this.txtDosagem);
            this.guna2ShadowPanel3.Controls.Add(this.label7);
            this.guna2ShadowPanel3.Controls.Add(this.label1);
            this.guna2ShadowPanel3.Controls.Add(this.txtFabricante);
            this.guna2ShadowPanel3.Controls.Add(this.txtFormaFarmac);
            this.guna2ShadowPanel3.Controls.Add(this.txtConcentracao);
            this.guna2ShadowPanel3.Controls.Add(this.txtNomeMedicamento);
            this.guna2ShadowPanel3.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel3.Location = new System.Drawing.Point(14, 110);
            this.guna2ShadowPanel3.Name = "guna2ShadowPanel3";
            this.guna2ShadowPanel3.Radius = 2;
            this.guna2ShadowPanel3.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel3.ShadowDepth = 20;
            this.guna2ShadowPanel3.Size = new System.Drawing.Size(683, 215);
            this.guna2ShadowPanel3.TabIndex = 13;
            this.guna2ShadowPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2ShadowPanel3_Paint);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(498, 8);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 13);
            this.label13.TabIndex = 92;
            this.label13.Text = "forma farmaceutica";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(260, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 13);
            this.label11.TabIndex = 91;
            this.label11.Text = "concentração";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(23, 64);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 13);
            this.label14.TabIndex = 90;
            this.label14.Text = "fabricante";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(488, 67);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(60, 13);
            this.label17.TabIndex = 89;
            this.label17.Text = "abreviação";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(245, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 62;
            this.label8.Text = "Instruções";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(468, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 61;
            this.label2.Text = "descrição";
            // 
            // txtAbreviacao
            // 
            this.txtAbreviacao.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAbreviacao.BorderRadius = 5;
            this.txtAbreviacao.BorderThickness = 2;
            this.txtAbreviacao.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAbreviacao.DefaultText = "";
            this.txtAbreviacao.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAbreviacao.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAbreviacao.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAbreviacao.DisabledState.Parent = this.txtAbreviacao;
            this.txtAbreviacao.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAbreviacao.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAbreviacao.FocusedState.Parent = this.txtAbreviacao;
            this.txtAbreviacao.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAbreviacao.HoverState.Parent = this.txtAbreviacao;
            this.txtAbreviacao.Location = new System.Drawing.Point(481, 82);
            this.txtAbreviacao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAbreviacao.Name = "txtAbreviacao";
            this.txtAbreviacao.PasswordChar = '\0';
            this.txtAbreviacao.PlaceholderText = "";
            this.txtAbreviacao.SelectedText = "";
            this.txtAbreviacao.ShadowDecoration.Parent = this.txtAbreviacao;
            this.txtAbreviacao.Size = new System.Drawing.Size(189, 37);
            this.txtAbreviacao.TabIndex = 60;
            // 
            // txtDescricao
            // 
            this.txtDescricao.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescricao.BorderRadius = 5;
            this.txtDescricao.BorderThickness = 2;
            this.txtDescricao.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescricao.DefaultText = "";
            this.txtDescricao.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDescricao.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDescricao.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescricao.DisabledState.Parent = this.txtDescricao;
            this.txtDescricao.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescricao.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescricao.FocusedState.Parent = this.txtDescricao;
            this.txtDescricao.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescricao.HoverState.Parent = this.txtDescricao;
            this.txtDescricao.Location = new System.Drawing.Point(457, 144);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.PasswordChar = '\0';
            this.txtDescricao.PlaceholderText = "";
            this.txtDescricao.SelectedText = "";
            this.txtDescricao.ShadowDecoration.Parent = this.txtDescricao;
            this.txtDescricao.Size = new System.Drawing.Size(218, 64);
            this.txtDescricao.TabIndex = 59;
            // 
            // txtInstrucoes
            // 
            this.txtInstrucoes.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInstrucoes.BorderRadius = 5;
            this.txtInstrucoes.BorderThickness = 2;
            this.txtInstrucoes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInstrucoes.DefaultText = "";
            this.txtInstrucoes.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtInstrucoes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtInstrucoes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInstrucoes.DisabledState.Parent = this.txtInstrucoes;
            this.txtInstrucoes.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInstrucoes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInstrucoes.FocusedState.Parent = this.txtInstrucoes;
            this.txtInstrucoes.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInstrucoes.HoverState.Parent = this.txtInstrucoes;
            this.txtInstrucoes.Location = new System.Drawing.Point(232, 144);
            this.txtInstrucoes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInstrucoes.Name = "txtInstrucoes";
            this.txtInstrucoes.PasswordChar = '\0';
            this.txtInstrucoes.PlaceholderText = "";
            this.txtInstrucoes.SelectedText = "";
            this.txtInstrucoes.ShadowDecoration.Parent = this.txtInstrucoes;
            this.txtInstrucoes.Size = new System.Drawing.Size(218, 66);
            this.txtInstrucoes.TabIndex = 58;
            // 
            // txtDosagem
            // 
            this.txtDosagem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDosagem.BorderRadius = 5;
            this.txtDosagem.BorderThickness = 2;
            this.txtDosagem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDosagem.DefaultText = "";
            this.txtDosagem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDosagem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDosagem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDosagem.DisabledState.Parent = this.txtDosagem;
            this.txtDosagem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDosagem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDosagem.FocusedState.Parent = this.txtDosagem;
            this.txtDosagem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDosagem.HoverState.Parent = this.txtDosagem;
            this.txtDosagem.Location = new System.Drawing.Point(10, 144);
            this.txtDosagem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDosagem.Name = "txtDosagem";
            this.txtDosagem.PasswordChar = '\0';
            this.txtDosagem.PlaceholderText = "";
            this.txtDosagem.SelectedText = "";
            this.txtDosagem.ShadowDecoration.Parent = this.txtDosagem;
            this.txtDosagem.Size = new System.Drawing.Size(217, 64);
            this.txtDosagem.TabIndex = 57;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "dosagem";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "nome de medicamento";
            // 
            // txtFabricante
            // 
            this.txtFabricante.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFabricante.BorderRadius = 5;
            this.txtFabricante.BorderThickness = 2;
            this.txtFabricante.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFabricante.DefaultText = "";
            this.txtFabricante.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFabricante.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFabricante.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFabricante.DisabledState.Parent = this.txtFabricante;
            this.txtFabricante.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFabricante.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFabricante.FocusedState.Parent = this.txtFabricante;
            this.txtFabricante.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFabricante.HoverState.Parent = this.txtFabricante;
            this.txtFabricante.Location = new System.Drawing.Point(9, 82);
            this.txtFabricante.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFabricante.Name = "txtFabricante";
            this.txtFabricante.PasswordChar = '\0';
            this.txtFabricante.PlaceholderText = "";
            this.txtFabricante.SelectedText = "";
            this.txtFabricante.ShadowDecoration.Parent = this.txtFabricante;
            this.txtFabricante.Size = new System.Drawing.Size(225, 37);
            this.txtFabricante.TabIndex = 13;
            // 
            // txtFormaFarmac
            // 
            this.txtFormaFarmac.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFormaFarmac.BorderRadius = 5;
            this.txtFormaFarmac.BorderThickness = 2;
            this.txtFormaFarmac.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFormaFarmac.DefaultText = "";
            this.txtFormaFarmac.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFormaFarmac.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFormaFarmac.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFormaFarmac.DisabledState.Parent = this.txtFormaFarmac;
            this.txtFormaFarmac.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFormaFarmac.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFormaFarmac.FocusedState.Parent = this.txtFormaFarmac;
            this.txtFormaFarmac.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFormaFarmac.HoverState.Parent = this.txtFormaFarmac;
            this.txtFormaFarmac.Location = new System.Drawing.Point(481, 22);
            this.txtFormaFarmac.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFormaFarmac.Name = "txtFormaFarmac";
            this.txtFormaFarmac.PasswordChar = '\0';
            this.txtFormaFarmac.PlaceholderText = "";
            this.txtFormaFarmac.SelectedText = "";
            this.txtFormaFarmac.ShadowDecoration.Parent = this.txtFormaFarmac;
            this.txtFormaFarmac.Size = new System.Drawing.Size(189, 37);
            this.txtFormaFarmac.TabIndex = 13;
            // 
            // txtConcentracao
            // 
            this.txtConcentracao.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtConcentracao.BorderRadius = 5;
            this.txtConcentracao.BorderThickness = 2;
            this.txtConcentracao.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConcentracao.DefaultText = "";
            this.txtConcentracao.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtConcentracao.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtConcentracao.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConcentracao.DisabledState.Parent = this.txtConcentracao;
            this.txtConcentracao.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConcentracao.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtConcentracao.FocusedState.Parent = this.txtConcentracao;
            this.txtConcentracao.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtConcentracao.HoverState.Parent = this.txtConcentracao;
            this.txtConcentracao.Location = new System.Drawing.Point(248, 22);
            this.txtConcentracao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtConcentracao.Name = "txtConcentracao";
            this.txtConcentracao.PasswordChar = '\0';
            this.txtConcentracao.PlaceholderText = "";
            this.txtConcentracao.SelectedText = "";
            this.txtConcentracao.ShadowDecoration.Parent = this.txtConcentracao;
            this.txtConcentracao.Size = new System.Drawing.Size(221, 37);
            this.txtConcentracao.TabIndex = 13;
            // 
            // txtNomeMedicamento
            // 
            this.txtNomeMedicamento.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNomeMedicamento.BorderRadius = 5;
            this.txtNomeMedicamento.BorderThickness = 2;
            this.txtNomeMedicamento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNomeMedicamento.DefaultText = "";
            this.txtNomeMedicamento.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNomeMedicamento.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNomeMedicamento.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNomeMedicamento.DisabledState.Parent = this.txtNomeMedicamento;
            this.txtNomeMedicamento.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNomeMedicamento.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNomeMedicamento.FocusedState.Parent = this.txtNomeMedicamento;
            this.txtNomeMedicamento.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNomeMedicamento.HoverState.Parent = this.txtNomeMedicamento;
            this.txtNomeMedicamento.Location = new System.Drawing.Point(10, 22);
            this.txtNomeMedicamento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNomeMedicamento.Name = "txtNomeMedicamento";
            this.txtNomeMedicamento.PasswordChar = '\0';
            this.txtNomeMedicamento.PlaceholderText = "";
            this.txtNomeMedicamento.SelectedText = "";
            this.txtNomeMedicamento.ShadowDecoration.Parent = this.txtNomeMedicamento;
            this.txtNomeMedicamento.Size = new System.Drawing.Size(221, 37);
            this.txtNomeMedicamento.TabIndex = 13;
            // 
            // guna2ShadowPanel2
            // 
            this.guna2ShadowPanel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel2.Controls.Add(this.label39);
            this.guna2ShadowPanel2.Controls.Add(this.guna2Button7);
            this.guna2ShadowPanel2.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel2.Location = new System.Drawing.Point(0, 4);
            this.guna2ShadowPanel2.Name = "guna2ShadowPanel2";
            this.guna2ShadowPanel2.Radius = 2;
            this.guna2ShadowPanel2.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel2.ShadowDepth = 50;
            this.guna2ShadowPanel2.Size = new System.Drawing.Size(714, 45);
            this.guna2ShadowPanel2.TabIndex = 12;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.ForeColor = System.Drawing.Color.DimGray;
            this.label39.Location = new System.Drawing.Point(19, 16);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(242, 20);
            this.label39.TabIndex = 54;
            this.label39.Text = "CADASTRAR MEDICAMENTO";
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
            this.guna2Button7.Location = new System.Drawing.Point(673, 9);
            this.guna2Button7.Name = "guna2Button7";
            this.guna2Button7.ShadowDecoration.Parent = this.guna2Button7;
            this.guna2Button7.Size = new System.Drawing.Size(28, 27);
            this.guna2Button7.TabIndex = 53;
            this.guna2Button7.Text = "X";
            this.guna2Button7.Click += new System.EventHandler(this.guna2Button7_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCodigo.BorderRadius = 5;
            this.txtCodigo.BorderThickness = 2;
            this.txtCodigo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodigo.DefaultText = "";
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
            this.txtCodigo.Location = new System.Drawing.Point(24, 68);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.PasswordChar = '\0';
            this.txtCodigo.PlaceholderText = "";
            this.txtCodigo.SelectedText = "";
            this.txtCodigo.ShadowDecoration.Parent = this.txtCodigo;
            this.txtCodigo.Size = new System.Drawing.Size(99, 36);
            this.txtCodigo.TabIndex = 8;
            // 
            // guna2ShadowPanel6
            // 
            this.guna2ShadowPanel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2ShadowPanel6.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel6.Location = new System.Drawing.Point(0, 0);
            this.guna2ShadowPanel6.Name = "guna2ShadowPanel6";
            this.guna2ShadowPanel6.Radius = 2;
            this.guna2ShadowPanel6.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel6.ShadowDepth = 50;
            this.guna2ShadowPanel6.Size = new System.Drawing.Size(1113, 44);
            this.guna2ShadowPanel6.TabIndex = 56;
            // 
            // dgvDados
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvDados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDados.BackgroundColor = System.Drawing.Color.White;
            this.dgvDados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDados.ColumnHeadersHeight = 30;
            this.dgvDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColDeletar,
            this.colEditar,
            this.colImprimir});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDados.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDados.EnableHeadersVisualStyles = false;
            this.dgvDados.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDados.Location = new System.Drawing.Point(12, 139);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.RowHeadersVisible = false;
            this.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDados.Size = new System.Drawing.Size(1089, 368);
            this.dgvDados.TabIndex = 57;
            this.dgvDados.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvDados.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDados.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDados.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDados.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDados.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDados.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvDados.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDados.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvDados.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDados.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvDados.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDados.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDados.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvDados.ThemeStyle.ReadOnly = false;
            this.dgvDados.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDados.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDados.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvDados.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDados.ThemeStyle.RowsStyle.Height = 22;
            this.dgvDados.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDados.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // ColDeletar
            // 
            this.ColDeletar.HeaderText = "DELETAR";
            this.ColDeletar.Image = ((System.Drawing.Image)(resources.GetObject("ColDeletar.Image")));
            this.ColDeletar.Name = "ColDeletar";
            // 
            // colEditar
            // 
            this.colEditar.HeaderText = "EDITAR";
            this.colEditar.Image = ((System.Drawing.Image)(resources.GetObject("colEditar.Image")));
            this.colEditar.Name = "colEditar";
            // 
            // colImprimir
            // 
            this.colImprimir.HeaderText = "IMPRIMIR";
            this.colImprimir.Image = ((System.Drawing.Image)(resources.GetObject("colImprimir.Image")));
            this.colImprimir.Name = "colImprimir";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 5;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(12, 88);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(103, 36);
            this.guna2Button1.TabIndex = 58;
            this.guna2Button1.Text = "adicionar";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
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
            this.txtPesquisar.Location = new System.Drawing.Point(888, 88);
            this.txtPesquisar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.PasswordChar = '\0';
            this.txtPesquisar.PlaceholderText = "";
            this.txtPesquisar.SelectedText = "";
            this.txtPesquisar.ShadowDecoration.Parent = this.txtPesquisar;
            this.txtPesquisar.Size = new System.Drawing.Size(212, 36);
            this.txtPesquisar.TabIndex = 59;
            // 
            // cmbTipoMed
            // 
            this.cmbTipoMed.BackColor = System.Drawing.Color.Transparent;
            this.cmbTipoMed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTipoMed.BorderRadius = 5;
            this.cmbTipoMed.BorderThickness = 2;
            this.cmbTipoMed.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTipoMed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoMed.FocusedColor = System.Drawing.Color.Empty;
            this.cmbTipoMed.FocusedState.Parent = this.cmbTipoMed;
            this.cmbTipoMed.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbTipoMed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbTipoMed.FormattingEnabled = true;
            this.cmbTipoMed.HoverState.Parent = this.cmbTipoMed;
            this.cmbTipoMed.ItemHeight = 21;
            this.cmbTipoMed.Items.AddRange(new object[] {
            "Cash",
            "Multicaixa",
            "Transferência Bancaria"});
            this.cmbTipoMed.ItemsAppearance.Parent = this.cmbTipoMed;
            this.cmbTipoMed.Location = new System.Drawing.Point(248, 82);
            this.cmbTipoMed.Name = "cmbTipoMed";
            this.cmbTipoMed.ShadowDecoration.Parent = this.cmbTipoMed;
            this.cmbTipoMed.Size = new System.Drawing.Size(221, 27);
            this.cmbTipoMed.TabIndex = 93;
            // 
            // frmMedicamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 512);
            this.Controls.Add(this.guna2ShadowPanel6);
            this.Controls.Add(this.pnlCadastrar);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.dgvDados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMedicamento";
            this.Text = "frmMedicamento";
            this.pnlCadastrar.ResumeLayout(false);
            this.pnlCadastrar.PerformLayout();
            this.guna2ShadowPanel3.ResumeLayout(false);
            this.guna2ShadowPanel3.PerformLayout();
            this.guna2ShadowPanel2.ResumeLayout(false);
            this.guna2ShadowPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtNomeMedicamento;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel2;
        private System.Windows.Forms.Label label39;
        private Guna.UI2.WinForms.Guna2Button guna2Button7;
        private Guna.UI2.WinForms.Guna2TextBox txtCodigo;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel6;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDados;
        private System.Windows.Forms.DataGridViewImageColumn ColDeletar;
        private System.Windows.Forms.DataGridViewImageColumn colEditar;
        private System.Windows.Forms.DataGridViewImageColumn colImprimir;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2TextBox txtPesquisar;
        private Guna.UI2.WinForms.Guna2TextBox txtFabricante;
        private Guna.UI2.WinForms.Guna2TextBox txtFormaFarmac;
        private Guna.UI2.WinForms.Guna2TextBox txtConcentracao;
        private Guna.UI2.WinForms.Guna2TextBox txtDosagem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtAbreviacao;
        private Guna.UI2.WinForms.Guna2TextBox txtDescricao;
        private Guna.UI2.WinForms.Guna2TextBox txtInstrucoes;
        private Guna.UI2.WinForms.Guna2ComboBox cmbTipoMed;
    }
}