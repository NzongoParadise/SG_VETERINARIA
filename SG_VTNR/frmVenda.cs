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
    public partial class frmVenda : Form
    {
        public frmVenda()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //vamos implementar o cancelamento da venda
            //alterar o campo status da tabela venda
            //retornar os itens para o estoque
            //develver o dinheiro para o comprador (Não iremos trabalhar, 
            //o nosso sistema não possui caixa)
            DialogResult d = MessageBox.Show("Deseja cancelar o registro?", "Aviso", MessageBoxButtons.YesNo);
            if (d.ToString() == "Yes")
            {
                //DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                //BLLVenda bll = new BLLVenda(cx);
                //if (bll.CancelarVenda(Convert.ToInt32(txtVenCodigo.Text)) == true)
                //{
                //    MessageBox.Show("Venda Cancelada");
                //}
                //else
                //{
                //    MessageBox.Show("Não foi possível cancelar a venda. \nContate o seu desenvolvedor.");
                //}
            }
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvEndereco_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmVenda_Load(object sender, EventArgs e)
        {

        }
    }
}
