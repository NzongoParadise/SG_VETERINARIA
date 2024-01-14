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
    public partial class frmServicos : Form
    {
        public frmServicos()
        {
            InitializeComponent();
        }
        private void container(object _form)
        {
            if (pnlContainer.Controls.Count > 0) pnlContainer.Controls.Clear();

            Form fm = _form as Form;
            fm.TopLevel = false;
            fm.FormBorderStyle = FormBorderStyle.None;
            fm.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(fm);
            pnlContainer.Tag = fm;
            fm.Show();
        }
        private void frmConsulta_Load(object sender, EventArgs e)
        {

        }

        private void dgvDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSobrenome_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            

            if (pnlContainer.Visible == false )
            {
                pnlContainer.Visible = true;
                container(new frmMarcacaoConsulta());
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            
            if (pnlContainer.Visible == false)
            {
                pnlContainer.Visible = true;
                container(new frmTratamento());
            }
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            
            if (pnlContainer.Visible == false)
            {
                pnlContainer.Visible = true;
                container(new frmExame());
            }
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {

        }
    }
}
