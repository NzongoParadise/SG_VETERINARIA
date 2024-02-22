namespace SG_VTNR
{
    partial class frmIntermediarioAnimal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIntermediarioAnimal));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPesquisarAnimal = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvExibirAnimal = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ColDeletar = new System.Windows.Forms.DataGridViewImageColumn();
            this.colEditar = new System.Windows.Forms.DataGridViewImageColumn();
            this.colImprimir = new System.Windows.Forms.DataGridViewImageColumn();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExibirAnimal)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SG_VTNR.Properties.Resources.search_500px1;
            this.pictureBox1.Location = new System.Drawing.Point(1694, 169);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 118;
            this.pictureBox1.TabStop = false;
            // 
            // txtPesquisarAnimal
            // 
            this.txtPesquisarAnimal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPesquisarAnimal.BorderRadius = 5;
            this.txtPesquisarAnimal.BorderThickness = 2;
            this.txtPesquisarAnimal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPesquisarAnimal.DefaultText = "";
            this.txtPesquisarAnimal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPesquisarAnimal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPesquisarAnimal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPesquisarAnimal.DisabledState.Parent = this.txtPesquisarAnimal;
            this.txtPesquisarAnimal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPesquisarAnimal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPesquisarAnimal.FocusedState.Parent = this.txtPesquisarAnimal;
            this.txtPesquisarAnimal.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPesquisarAnimal.HoverState.Parent = this.txtPesquisarAnimal;
            this.txtPesquisarAnimal.Location = new System.Drawing.Point(1253, 169);
            this.txtPesquisarAnimal.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtPesquisarAnimal.Name = "txtPesquisarAnimal";
            this.txtPesquisarAnimal.PasswordChar = '\0';
            this.txtPesquisarAnimal.PlaceholderText = "";
            this.txtPesquisarAnimal.SelectedText = "";
            this.txtPesquisarAnimal.ShadowDecoration.Parent = this.txtPesquisarAnimal;
            this.txtPesquisarAnimal.Size = new System.Drawing.Size(492, 55);
            this.txtPesquisarAnimal.TabIndex = 117;
            this.txtPesquisarAnimal.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // dgvExibirAnimal
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvExibirAnimal.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvExibirAnimal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvExibirAnimal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExibirAnimal.BackgroundColor = System.Drawing.Color.White;
            this.dgvExibirAnimal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvExibirAnimal.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvExibirAnimal.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExibirAnimal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvExibirAnimal.ColumnHeadersHeight = 30;
            this.dgvExibirAnimal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColDeletar,
            this.colEditar,
            this.colImprimir});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvExibirAnimal.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvExibirAnimal.EnableHeadersVisualStyles = false;
            this.dgvExibirAnimal.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvExibirAnimal.Location = new System.Drawing.Point(3, 237);
            this.dgvExibirAnimal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvExibirAnimal.Name = "dgvExibirAnimal";
            this.dgvExibirAnimal.RowHeadersVisible = false;
            this.dgvExibirAnimal.RowHeadersWidth = 62;
            this.dgvExibirAnimal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExibirAnimal.Size = new System.Drawing.Size(1858, 619);
            this.dgvExibirAnimal.TabIndex = 116;
            this.dgvExibirAnimal.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvExibirAnimal.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvExibirAnimal.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvExibirAnimal.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvExibirAnimal.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvExibirAnimal.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvExibirAnimal.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvExibirAnimal.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvExibirAnimal.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvExibirAnimal.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvExibirAnimal.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvExibirAnimal.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvExibirAnimal.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvExibirAnimal.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvExibirAnimal.ThemeStyle.ReadOnly = false;
            this.dgvExibirAnimal.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvExibirAnimal.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvExibirAnimal.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvExibirAnimal.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvExibirAnimal.ThemeStyle.RowsStyle.Height = 22;
            this.dgvExibirAnimal.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvExibirAnimal.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
            // guna2Button2
            // 
            this.guna2Button2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.guna2Button2.BorderRadius = 15;
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Location = new System.Drawing.Point(13, 169);
            this.guna2Button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(225, 56);
            this.guna2Button2.TabIndex = 119;
            this.guna2Button2.Text = "Adicionar Animal";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // frmIntermediarioAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1909, 845);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPesquisarAnimal);
            this.Controls.Add(this.dgvExibirAnimal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmIntermediarioAnimal";
            this.Text = "frmIntermediarioAnimal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExibirAnimal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        public Guna.UI2.WinForms.Guna2TextBox txtPesquisarAnimal;
        private Guna.UI2.WinForms.Guna2DataGridView dgvExibirAnimal;
        private System.Windows.Forms.DataGridViewImageColumn ColDeletar;
        private System.Windows.Forms.DataGridViewImageColumn colEditar;
        private System.Windows.Forms.DataGridViewImageColumn colImprimir;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
    }
}