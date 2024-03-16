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
    public partial class frmRelatorioProprietario : Form
    {
        int codUsua;
        int codProp;
        public frmRelatorioProprietario(int cod1, int cd2)
        {
            
            InitializeComponent();
            codProp= cod1;
            codUsua= cd2;
        }

        private void frmRelatorioProprietario_Load(object sender, EventArgs e)
        {
            this.oterDadosProprietarioTableAdapter.Fill(bD_VeterinariaDataSet7.OterDadosProprietario, codProp, codUsua);
            this.reportViewer1.RefreshReport();
        }
    }
}
