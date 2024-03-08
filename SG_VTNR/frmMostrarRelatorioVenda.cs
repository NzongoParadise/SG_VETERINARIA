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
    public partial class frmMostrarRelatorioVenda : Form
    {
        int codigo;
        public frmMostrarRelatorioVenda(int cod)
        {
            this.codigo = cod;
            InitializeComponent();
        }

        private void frmMostrarRelatorioVenda_Load(object sender, EventArgs e)
        {

         
            this.obterDadosVendaTableAdapter.Fill(this.bD_VeterinariaDataSet.ObterDadosVenda, codigo);
            this.reportViewer1.RefreshReport();
          }
    }
}
