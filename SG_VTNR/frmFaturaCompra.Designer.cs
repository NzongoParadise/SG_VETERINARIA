﻿namespace SG_VTNR
{
    partial class frmFaturaCompra
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
            this.bD_VeterinariaDataSet2 = new SG_VTNR.BD_VeterinariaDataSet2();
            this.obterDadosCompraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.obterDadosCompraTableAdapter = new SG_VTNR.BD_VeterinariaDataSet2TableAdapters.ObterDadosCompraTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bD_VeterinariaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obterDadosCompraBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetObbterDadosCompra";
            reportDataSource1.Value = this.obterDadosCompraBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SG_VTNR.faturaCompra.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // bD_VeterinariaDataSet2
            // 
            this.bD_VeterinariaDataSet2.DataSetName = "BD_VeterinariaDataSet2";
            this.bD_VeterinariaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // obterDadosCompraBindingSource
            // 
            this.obterDadosCompraBindingSource.DataMember = "ObterDadosCompra";
            this.obterDadosCompraBindingSource.DataSource = this.bD_VeterinariaDataSet2;
            // 
            // obterDadosCompraTableAdapter
            // 
            this.obterDadosCompraTableAdapter.ClearBeforeFill = true;
            // 
            // frmFaturaCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmFaturaCompra";
            this.Text = "frmFaturaCompra";
            this.Load += new System.EventHandler(this.frmFaturaCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bD_VeterinariaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obterDadosCompraBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource obterDadosCompraBindingSource;
        private BD_VeterinariaDataSet2 bD_VeterinariaDataSet2;
        private BD_VeterinariaDataSet2TableAdapters.ObterDadosCompraTableAdapter obterDadosCompraTableAdapter;
    }
}