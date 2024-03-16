namespace SG_VTNR
{
    partial class frmRelatorioFuncionario
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bD_VeterinariaDataSet9 = new SG_VTNR.BD_VeterinariaDataSet9();
            this.oterDadosFuncionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oterDadosFuncionarioTableAdapter = new SG_VTNR.BD_VeterinariaDataSet9TableAdapters.OterDadosFuncionarioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bD_VeterinariaDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oterDadosFuncionarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetObterDadosFuncionario";
            reportDataSource1.Value = this.oterDadosFuncionarioBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SG_VTNR.relatorioCadastroFuncionario.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // bD_VeterinariaDataSet9
            // 
            this.bD_VeterinariaDataSet9.DataSetName = "BD_VeterinariaDataSet9";
            this.bD_VeterinariaDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oterDadosFuncionarioBindingSource
            // 
            this.oterDadosFuncionarioBindingSource.DataMember = "OterDadosFuncionario";
            this.oterDadosFuncionarioBindingSource.DataSource = this.bD_VeterinariaDataSet9;
            // 
            // oterDadosFuncionarioTableAdapter
            // 
            this.oterDadosFuncionarioTableAdapter.ClearBeforeFill = true;
            // 
            // frmRelatorioFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmRelatorioFuncionario";
            this.Text = "frmRelatorioFuncionario";
            this.Load += new System.EventHandler(this.frmRelatorioFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bD_VeterinariaDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oterDadosFuncionarioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource oterDadosFuncionarioBindingSource;
        private BD_VeterinariaDataSet9 bD_VeterinariaDataSet9;
        private BD_VeterinariaDataSet9TableAdapters.OterDadosFuncionarioTableAdapter oterDadosFuncionarioTableAdapter;
    }
}