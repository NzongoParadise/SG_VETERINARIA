using Ferramenta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SG_VTNR
{
    public partial class frmPrincipal : Form
    {
        //configuração da hora 
        DateTime data = new DateTime();
        CultureInfo cultura = new CultureInfo("pt-BR");
        public frmPrincipal()
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
        private void guna2Button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button7_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (pnlMenu.Visible == false)
            {
                pnlMenu.Visible = true;
            }
            else
            {
                pnlMenu.Visible = false;
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
          
            if (pnlMenu.Visible == true)
            {
                pnlMenu.Visible = false;
                container(new frmInicio());
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            
            if (pnlMenu.Visible == true)
            {
                pnlMenu.Visible = false;
                container(new frmProprietario());
            }
           
        }

        private void horaTmr_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss");
            string diaDaSemana = cultura.DateTimeFormat.GetDayName(data.DayOfWeek);
            lblDia.Text = diaDaSemana;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            container(new frmInicio());
            lblUtilizador.Text = SessaoUsuario.Session.Instance.UsuNome;
            lblPerfil.Text = SessaoUsuario.Session.Instance.perfil;
        }

        private void pnlContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            container(new frmMedicamento());
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            
            if (pnlMenu.Visible == true)
            {
                pnlMenu.Visible = false;
                container(new frmAnimal());
            }
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            
            if (pnlMenu.Visible == true)
            {
                pnlMenu.Visible = false;
                container(new frmServicos());
            }
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            
        }

        private void guna2Button15_Click(object sender, EventArgs e)
        {
            if (pnlMenu.Visible == true)
            {
                pnlMenu.Visible = false;
                container(new frmUsuario());
            }
        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            if (pnlMenu.Visible == true)
            {
                pnlMenu.Visible = false;
                container(new frmFuncionario());
            }
        }

        private void guna2Button12_Click(object sender, EventArgs e)
        {
            if (pnlMenu.Visible==true)
            {
                pnlMenu.Visible = false;
                container(new frmFornecedor());
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void guna2Button14_Click(object sender, EventArgs e)
        {
            if (pnlMenu.Visible==true)
            {
                pnlMenu.Visible = false;
                container(new frmVenda());

            }
        }

        private void guna2Button16_Click(object sender, EventArgs e)
        {
            if (pnlMenu.Visible==true)
            {
                pnlMenu.Visible = false;
                container(new frmCompra());
            }
        }
    }
}
