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
    public partial class frmCompra : Form
    {
        private DataTable FornecdorDT = new DataTable();
        private DataTable TransacaoDT = new DataTable();
        public frmCompra()
        {
            InitializeComponent();
        }


        private void guna2TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        //private void txtPesquisar_TextChanged(object sender, EventArgs e)
        //{
        //    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
        //    BLLFornecedor bll = new BLLFornecedor(cx);
        //    if (pnlFornecedor.Visible == false)
        //    {
        //        pnlFornecedor.Visible = true;
        //    }
        //    FornecdorDT.Rows.Add(bll.PesquisarFornecedorComChavenaCompra(txtPesquisarFornecedor.Text));
        //    dgvFornecedor.DataSource = FornecdorDT;

        //}

        //private void frmCompra_Load(object sender, EventArgs e)
        //{
        //    if (pnlFornecedor.Visible==true)
        //    {
        //        pnlFornecedor.Visible = false;
        //    }
        //    FornecdorDT.Columns.Add("Código Fornecedor");
        //    FornecdorDT.Columns.Add("Nome do Forncedor");
        //}


        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLFornecedor bll = new BLLFornecedor(cx);

            if (pnlFornecedor.Visible == false)
            {
                pnlFornecedor.Visible = true;
            }

            FornecdorDT = bll.PesquisarFornecedorComChavenaCompra(txtPesquisarFornecedor.Text);

            // Vincular DataTable ao DataGridView
            dgvFornecedor.DataSource = FornecdorDT;
        }



        private void frmCompra_Load(object sender, EventArgs e)
        {
            if (pnlFornecedor.Visible)
            {
                pnlFornecedor.Visible = false;
            }

            // Limpar as colunas existentes, se houver
            FornecdorDT.Columns.Clear();
            // Adicionar colunas com nomes específicos
            FornecdorDT.Columns.Add("FornecedorID", typeof(int)).ColumnName = "Código Fornecedor";
            FornecdorDT.Columns.Add("NomeFornecedor").ColumnName = "Nome do Fornecedor";
            dgvFornecedor.DataSource = FornecdorDT;
            rbComercial.Checked = true;
            // Adicionar colunas com nomes NO DATA GRID VIW ITENS COMPRA
            TransacaoDT.Columns.Add("Nome do produto");
            TransacaoDT.Columns.Add("Fornecedor");
            TransacaoDT.Columns.Add("Valor de Compra");
            TransacaoDT.Columns.Add("Valor de Venda");
            //TransacaoDT.Columns.Add("Categoria");
            TransacaoDT.Columns.Add("Tipo Produto");
            TransacaoDT.Columns.Add("Quantidade");
            TransacaoDT.Columns.Add("Total");

        }
        public void limparCampos()
        {
            txtNomeProduto.Text = "";
            txtCodFornecedor.Text = "";
            txtQtd.Text = "";
            txtValorCompr.Text = "";
            txtValorVenda.Text = "";
            txtxConcentracao.Text = "";
            txtDosage.Text = "";
            cmbTipoPropduto.SelectedIndex = -1;
            cmbCategoria.SelectedIndex= -1;
            cmbCategoria.Text = "";
            txtCodFornecedor.Text = "";
            txtFormaFarmaceutica.Text = "";
            txtObs.Text = "";
            txtNomeFornecedor.Text = "";
        }
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            string finalidade="";
            if (rbComercial.Checked = true)
            {
                if ((txtNomeProduto.Text == "") || (txtCodFornecedor.Text == "") || (txtQtd.Text == "") || (txtValorCompr.Text == "")
                    || (txtValorVenda.Text == "") || (txtxConcentracao.Text == "") || (txtDosage.Text == "") || (cmbTipoPropduto.Text == "")
                    || (cmbCategoria.Text == "") || (txtCodFornecedor.Text == "") || (txtFormaFarmaceutica.Text == "") || (txtNomeFornecedor.Text == "")
                    )
                {
                    MessageBox.Show("Preencha os Campos Obrigatórios");
                }
                else
                {
                    finalidade = "Comercial";
                    string produto = txtNomeProduto.Text;
                    string fornecedor = txtNomeFornecedor.Text;
                    int qtd = int.Parse(txtQtd.Text);
                    decimal vc = decimal.Parse(txtValorCompr.Text);
                    decimal total = qtd * vc;
                    decimal subtotal = decimal.Parse(txtSubTotal.Text);
                    subtotal = subtotal + total;

                    TransacaoDT.Rows.Add(produto, vc, cmbTipoPropduto.SelectedItem, qtd, total);
                    dgvCarinho.DataSource = TransacaoDT;
                    txtSubTotal.Text = subtotal.ToString();
                    //limparCampos();
                }


            }
            else if (rbGratuita.Checked = true)
            {

                if ((txtNomeProduto.Text == "") || (txtCodFornecedor.Text == "") || (txtQtd.Text == "") || (txtValorCompr.Text == "")
                    || (txtxConcentracao.Text == "") || (txtDosage.Text == "") || (cmbTipoPropduto.Text == "")
                    || (cmbCategoria.Text == "") || (txtCodFornecedor.Text == "") || (txtFormaFarmaceutica.Text == "") || (txtNomeFornecedor.Text == "")
                    )
                {
                    MessageBox.Show("Preencha os Campos Obrigatórios");
                }
                else
                {
                     finalidade = "Gratuito";
                    string produto = txtNomeProduto.Text;
                    string fornecedor = txtNomeFornecedor.Text;
                    int qtd = int.Parse(txtQtd.Text);
                    decimal vc = decimal.Parse(txtValorCompr.Text);
                    decimal total = qtd * vc;
                    decimal subtotal = decimal.Parse(txtSubTotal.Text);
                    subtotal = subtotal + total;

                    TransacaoDT.Rows.Add(produto, vc, cmbTipoPropduto.SelectedItem, qtd, total);
                    dgvCarinho.DataSource = TransacaoDT;
                    txtSubTotal.Text = subtotal.ToString();
                    //limparCampos();
                }

            }
            else if (rbUsoInterno.Checked = true)
            {
                if ((txtNomeProduto.Text == "") || (txtCodFornecedor.Text == "") || (txtQtd.Text == "") || (txtValorCompr.Text == "")
                    || (txtxConcentracao.Text == "") || (txtDosage.Text == "") || (cmbTipoPropduto.Text == "")
                    || (cmbCategoria.Text == "") || (txtCodFornecedor.Text == "") || (txtFormaFarmaceutica.Text == "") || (txtNomeFornecedor.Text == "")
                    )
                {
                    MessageBox.Show("Preencha os Campos Obrigatórios");
                }
                else
                {
                    finalidade = "UsoInterno";
                    string produto = txtNomeProduto.Text;
                    string fornecedor = txtNomeFornecedor.Text;
                    int qtd = int.Parse(txtQtd.Text);
                    decimal vc = decimal.Parse(txtValorCompr.Text);
                    decimal total = qtd * vc;
                    decimal subtotal = decimal.Parse(txtSubTotal.Text);
                    subtotal = subtotal + total;

                    TransacaoDT.Rows.Add(produto, vc, cmbTipoPropduto.SelectedItem, qtd, total);
                    dgvCarinho.DataSource = TransacaoDT;
                    txtSubTotal.Text = subtotal.ToString();
                    //limparCampos();
                }


            }
            lblFinalidade.Text = finalidade;
        }

            private void RedimensionarColunasDataGridView()
        {
            // Iterar sobre as colunas e ajustar automaticamente a largura com base no conteúdo
            foreach (DataGridViewColumn column in dgvFornecedor.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }


        private void dgvFornecedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodFornecedor.Text = dgvFornecedor.Rows[e.RowIndex].Cells["FornecedorID"].Value.ToString();
            txtNomeFornecedor.Text = dgvFornecedor.Rows[e.RowIndex].Cells["NomeFornecedor"].Value.ToString();

            if (pnlFornecedor.Visible)
            {
                pnlFornecedor.Visible = false;
            }
        }

        private void rbGratuita_CheckedChanged(object sender, EventArgs e)
        {
            if (rbGratuita.Checked)
            {
                txtValorCompr.Enabled = false;
                txtValorVenda.Enabled = false;
                txtValorCompr.Text = "";
                txtValorVenda.Text = "";
            }
        }

        private void rbUsoInterno_CheckedChanged(object sender, EventArgs e)
        {
            txtValorCompr.Enabled = false;
            txtValorVenda.Enabled = false;
            txtValorCompr.Text = "";
            txtValorVenda.Text = "";
        }

        private void rbComercial_CheckedChanged(object sender, EventArgs e)
        {
            txtValorCompr.Enabled = true;
            txtValorVenda.Enabled = true;

            txtValorCompr.Text = "";
            txtValorVenda.Text = "";
        }

        private void gunaShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button4_Click_1(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void dgvCarinho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string collname = dgvCarinho.Columns[e.ColumnIndex].Name;
            if (collname == "ColDeletar")
            {
                if (dgvCarinho.SelectedRows.Count>0)
                {
                    int linhaselecionada = dgvCarinho.SelectedRows[0].Index;
                    TransacaoDT.Rows.RemoveAt(linhaselecionada);
                }
            }else if()
        }
    }
}
