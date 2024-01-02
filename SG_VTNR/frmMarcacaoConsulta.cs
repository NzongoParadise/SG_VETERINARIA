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
    public partial class frmMarcacaoConsulta : Form
    {
        public frmMarcacaoConsulta()
        {
            InitializeComponent();
        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmMarcacaoConsulta_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            if (pnlCadastrar.Visible == false)
            {
                pnlCadastrar.Visible = true;
            }
            else
            {
                pnlCadastrar.Visible = false;
            }
        }
    }
}
