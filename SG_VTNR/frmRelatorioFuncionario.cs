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
    public partial class frmRelatorioFuncionario : Form
    {
        int codUsuario;
        int codFuncionario;
        public frmRelatorioFuncionario( int codFunc,int  codUsu)
        {
            InitializeComponent();
            this.codFuncionario = codFunc;
            this.codUsuario = codUsu;
        }

    private void frmRelatorioFuncionario_Load(object sender, EventArgs e)
        {
            oterDadosFuncionarioTableAdapter.Fill(this.bD_VeterinariaDataSet9.OterDadosFuncionario, this.codFuncionario, this.codUsuario);
            this.reportViewer1.RefreshReport();
        }
    }
}
