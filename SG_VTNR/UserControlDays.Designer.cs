namespace SG_VTNR
{
    partial class UserControlDays
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblDays = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.agendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarProprietarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Location = new System.Drawing.Point(30, 28);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(51, 20);
            this.lblDays.TabIndex = 0;
            this.lblDays.Text = "label1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agendaToolStripMenuItem,
            this.horárioToolStripMenuItem,
            this.adicionarPacienteToolStripMenuItem,
            this.adicionarProprietarioToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(258, 165);
            // 
            // agendaToolStripMenuItem
            // 
            this.agendaToolStripMenuItem.Name = "agendaToolStripMenuItem";
            this.agendaToolStripMenuItem.Size = new System.Drawing.Size(257, 32);
            this.agendaToolStripMenuItem.Text = "Agendar";
            this.agendaToolStripMenuItem.Click += new System.EventHandler(this.agendaToolStripMenuItem_Click);
            // 
            // horárioToolStripMenuItem
            // 
            this.horárioToolStripMenuItem.Name = "horárioToolStripMenuItem";
            this.horárioToolStripMenuItem.Size = new System.Drawing.Size(228, 32);
            this.horárioToolStripMenuItem.Text = "Horário";
            // 
            // adicionarPacienteToolStripMenuItem
            // 
            this.adicionarPacienteToolStripMenuItem.Name = "adicionarPacienteToolStripMenuItem";
            this.adicionarPacienteToolStripMenuItem.Size = new System.Drawing.Size(257, 32);
            this.adicionarPacienteToolStripMenuItem.Text = "Adicionar Animal";
            this.adicionarPacienteToolStripMenuItem.Click += new System.EventHandler(this.adicionarPacienteToolStripMenuItem_Click);
            // 
            // adicionarProprietarioToolStripMenuItem
            // 
            this.adicionarProprietarioToolStripMenuItem.Name = "adicionarProprietarioToolStripMenuItem";
            this.adicionarProprietarioToolStripMenuItem.Size = new System.Drawing.Size(257, 32);
            this.adicionarProprietarioToolStripMenuItem.Text = "Adicionar Proprietario";
            // 
            // UserControlDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.lblDays);
            this.Name = "UserControlDays";
            this.Size = new System.Drawing.Size(190, 70);
            this.Load += new System.EventHandler(this.UserControlDays_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem agendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarProprietarioToolStripMenuItem;
    }
}
