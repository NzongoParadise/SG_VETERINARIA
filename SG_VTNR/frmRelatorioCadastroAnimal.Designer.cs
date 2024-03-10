namespace SG_VTNR
{
    partial class frmRelatorioCadastroAnimal
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
            this.bD_VeterinariaDataSet4 = new SG_VTNR.BD_VeterinariaDataSet4();
            this.obterDadosAnimalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.obterDadosAnimalTableAdapter = new SG_VTNR.BD_VeterinariaDataSet4TableAdapters.ObterDadosAnimalTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bD_VeterinariaDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obterDadosAnimalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetObterDadosAnimal";
            reportDataSource1.Value = this.obterDadosAnimalBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SG_VTNR.relatorioCadastroAnimal.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(871, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // bD_VeterinariaDataSet4
            // 
            this.bD_VeterinariaDataSet4.DataSetName = "BD_VeterinariaDataSet4";
            this.bD_VeterinariaDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // obterDadosAnimalBindingSource
            // 
            this.obterDadosAnimalBindingSource.DataMember = "ObterDadosAnimal";
            this.obterDadosAnimalBindingSource.DataSource = this.bD_VeterinariaDataSet4;
            // 
            // obterDadosAnimalTableAdapter
            // 
            this.obterDadosAnimalTableAdapter.ClearBeforeFill = true;
            // 
            // frmRelatorioCadastroAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmRelatorioCadastroAnimal";
            this.Text = "frmRelatorioCadastroAnimal";
            this.Load += new System.EventHandler(this.frmRelatorioCadastroAnimal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bD_VeterinariaDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obterDadosAnimalBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource obterDadosAnimalBindingSource;
        private BD_VeterinariaDataSet4 bD_VeterinariaDataSet4;
        private BD_VeterinariaDataSet4TableAdapters.ObterDadosAnimalTableAdapter obterDadosAnimalTableAdapter;
    }
}