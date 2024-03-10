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
    public partial class frmRelatorioCadastroAnimal : Form
    {
        int codigoAnimal;
        public frmRelatorioCadastroAnimal(int cod)
        {
            InitializeComponent();
            codigoAnimal = cod;
        }

        private void frmRelatorioCadastroAnimal_Load(object sender, EventArgs e)
        {
            this.obterDadosAnimalTableAdapter.Fill(this.bD_VeterinariaDataSet4.ObterDadosAnimal, codigoAnimal);
            this.reportViewer1.RefreshReport();
        }
    }
}
