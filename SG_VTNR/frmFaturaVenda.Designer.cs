namespace SG_VTNR
{
    partial class frmFaturaVenda
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
            this.bD_VeterinariaDataSet = new SG_VTNR.BD_VeterinariaDataSet();
            this.obterDadosVendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.obterDadosVendaTableAdapter = new SG_VTNR.BD_VeterinariaDataSetTableAdapters.ObterDadosVendaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bD_VeterinariaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obterDadosVendaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetObterDadosVenda";
            reportDataSource1.Value = this.obterDadosVendaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SG_VTNR.faturadeVenda.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // bD_VeterinariaDataSet
            // 
            this.bD_VeterinariaDataSet.DataSetName = "BD_VeterinariaDataSet";
            this.bD_VeterinariaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // obterDadosVendaBindingSource
            // 
            this.obterDadosVendaBindingSource.DataMember = "ObterDadosVenda";
            this.obterDadosVendaBindingSource.DataSource = this.bD_VeterinariaDataSet;
            // 
            // obterDadosVendaTableAdapter
            // 
            this.obterDadosVendaTableAdapter.ClearBeforeFill = true;
            // 
            // frmFaturaVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmFaturaVenda";
            this.Text = "frmFaturaVenda";
            this.Load += new System.EventHandler(this.frmFaturaVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bD_VeterinariaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obterDadosVendaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource obterDadosVendaBindingSource;
        private BD_VeterinariaDataSet bD_VeterinariaDataSet;
        private BD_VeterinariaDataSetTableAdapters.ObterDadosVendaTableAdapter obterDadosVendaTableAdapter;
    }
}