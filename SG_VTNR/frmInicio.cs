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
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void guna2ShadowPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ShadowPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ShadowPanel3_Paint_1(object sender, PaintEventArgs e)
        {


        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            DALLAnimal dall = new DALLAnimal(cx);
            int tot= dall.ObterTotalAnimaisCadastrados();
            lbltotalAnimal.Text=tot.ToString();
            DALProprietario dalp=new DALProprietario(cx);
            int totprop = dalp.ObterTotalProprietariosCadastrados();
            lblTotalProprietario.Text=totprop.ToString();
        }
    }
}
