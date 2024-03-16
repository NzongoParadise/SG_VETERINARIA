namespace SG_VTNR
{
    partial class frmRelatorioProprietario
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
            this.bD_VeterinariaDataSet7 = new SG_VTNR.BD_VeterinariaDataSet7();
            this.oterDadosProprietarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oterDadosProprietarioTableAdapter = new SG_VTNR.BD_VeterinariaDataSet7TableAdapters.OterDadosProprietarioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bD_VeterinariaDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oterDadosProprietarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetObterDadosProprietario";
            reportDataSource1.Value = this.oterDadosProprietarioBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SG_VTNR.relatorioCadastroProprietario.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // bD_VeterinariaDataSet7
            // 
            this.bD_VeterinariaDataSet7.DataSetName = "BD_VeterinariaDataSet7";
            this.bD_VeterinariaDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oterDadosProprietarioBindingSource
            // 
            this.oterDadosProprietarioBindingSource.DataMember = "OterDadosProprietario";
            this.oterDadosProprietarioBindingSource.DataSource = this.bD_VeterinariaDataSet7;
            // 
            // oterDadosProprietarioTableAdapter
            // 
            this.oterDadosProprietarioTableAdapter.ClearBeforeFill = true;
            // 
            // frmRelatorioProprietario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmRelatorioProprietario";
            this.Text = "frmRelatorioProprietario";
            this.Load += new System.EventHandler(this.frmRelatorioProprietario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bD_VeterinariaDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oterDadosProprietarioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource oterDadosProprietarioBindingSource;
        private BD_VeterinariaDataSet7 bD_VeterinariaDataSet7;
        private BD_VeterinariaDataSet7TableAdapters.OterDadosProprietarioTableAdapter oterDadosProprietarioTableAdapter;
    }
}