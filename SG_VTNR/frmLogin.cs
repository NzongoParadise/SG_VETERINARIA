using BLL;
using DAL;
using Ferramenta;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            frmPrincipal frm = new frmPrincipal();
            frm.ShowDialog();
            this.Hide();
        } 

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Trim().Length == 0 || txtSenha.Text.Trim().Length == 0)
            {
                MessageBox.Show("preencha os campos senha ou usuario", "erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Focus();
                return;
            }
            else
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLUsuario bll = new BLLUsuario(cx);
                DataTable dt = new DataTable();
                dt = bll.LocalizarUsuarioLogin(txtUsuario.Text, txtSenha.Text);
                if (dt.Rows.Count == 1)
                {
                    SessaoUsuario.Session.Instance.UsuID = Convert.ToInt32(dt.Rows[0][0].ToString());
                    SessaoUsuario.Session.Instance.UsuNome = dt.Rows[0][1].ToString();
                    SessaoUsuario.Session.Instance.perfil = dt.Rows[0][3].ToString();
                    frmPrincipal frm = new frmPrincipal();
                    this.Hide();
                    frm.Show();

                }
                else
                {
                    MessageBox.Show("Usuario Inexistente");
                    return;
                }
                {

                }
            }
        }

        private void guna2CustomCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckMostrarSenha.Checked)
            {
                txtSenha.PasswordChar = '\u0000';

            }
            else
            {
                txtSenha.PasswordChar = 'X';
            }
        }

        private void linkLabel13_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }
    }
}
