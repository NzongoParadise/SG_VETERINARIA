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
    public partial class frmFaturaVenda : Form
    {
        int codigoVenda;
        public frmFaturaVenda(int cod)
        {
            InitializeComponent();
            codigoVenda = cod;
        }

        private void frmFaturaVenda_Load(object sender, EventArgs e)
        {
            this.obterDadosVendaTableAdapter.Fill(this.bD_VeterinariaDataSet.ObterDadosVenda, codigoVenda);


            this.reportViewer1.RefreshReport();
        }
    }
}
