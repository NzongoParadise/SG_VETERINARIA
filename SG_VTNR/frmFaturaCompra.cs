using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SG_VTNR
{
    public partial class frmFaturaCompra : Form
    {
        int codCompra;
        public frmFaturaCompra(int cod)
        {
            InitializeComponent();
            this.codCompra = cod;
        }

        private void frmFaturaCompra_Load(object sender, EventArgs e)
        {
            this.obterDadosCompraTableAdapter.Fill(this.bD_VeterinariaDataSet2.ObterDadosCompra, codCompra);

            this.reportViewer1.RefreshReport();
        }
    }
}
