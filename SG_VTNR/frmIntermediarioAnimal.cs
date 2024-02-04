using BLL;
using DAL;
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
    public partial class frmIntermediarioAnimal : Form
    {
        public frmIntermediarioAnimal()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            frmCadastrarAnimalteste frm = new frmCadastrarAnimalteste();
            frm.ShowDialog();   
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            PesquisarAnimalcomChave();
        }
        public void PesquisarAnimalcomChave()
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLAnimal bll = new BLLAnimal(cx);
            dgvExibirAnimal.DataSource = bll.PesquisarAnimalcomChave(txtPesquisarAnimal.Text);

        }
    }
}
