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
    public partial class frmFaturaVendaTeste : Form
    {
        int codigoVenda;
        public frmFaturaVendaTeste(int cod)
        {
            
            InitializeComponent();
            codigoVenda = cod;
        }

        private void frmFaturaVendaTeste_Load(object sender, EventArgs e)
        {
            this.obterDadosVendatesteTableAdapter.Fill(this.bD_VeterinariaDataSet3.ObterDadosVendateste, codigoVenda);

            this.reportViewer1.RefreshReport();
        }
    }
}
