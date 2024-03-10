namespace SG_VTNR
{
    partial class frmFaturaVendaTeste
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
            this.bD_VeterinariaDataSet3 = new SG_VTNR.BD_VeterinariaDataSet3();
            this.obterDadosVendatesteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.obterDadosVendatesteTableAdapter = new SG_VTNR.BD_VeterinariaDataSet3TableAdapters.ObterDadosVendatesteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bD_VeterinariaDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obterDadosVendatesteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetObterDadosVendaTeste";
            reportDataSource1.Value = this.obterDadosVendatesteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SG_VTNR.faturaVendaTeste.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // bD_VeterinariaDataSet3
            // 
            this.bD_VeterinariaDataSet3.DataSetName = "BD_VeterinariaDataSet3";
            this.bD_VeterinariaDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // obterDadosVendatesteBindingSource
            // 
            this.obterDadosVendatesteBindingSource.DataMember = "ObterDadosVendateste";
            this.obterDadosVendatesteBindingSource.DataSource = this.bD_VeterinariaDataSet3;
            // 
            // obterDadosVendatesteTableAdapter
            // 
            this.obterDadosVendatesteTableAdapter.ClearBeforeFill = true;
            // 
            // frmFaturaVendaTeste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmFaturaVendaTeste";
            this.Text = "frmFaturaVendaTeste";
            this.Load += new System.EventHandler(this.frmFaturaVendaTeste_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bD_VeterinariaDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obterDadosVendatesteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource obterDadosVendatesteBindingSource;
        private BD_VeterinariaDataSet3 bD_VeterinariaDataSet3;
        private BD_VeterinariaDataSet3TableAdapters.ObterDadosVendatesteTableAdapter obterDadosVendatesteTableAdapter;
    }
}