using BLL;
using DAL;
using Modelo;
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
    public partial class frmFornecedor : Form
    {
       
       
        public frmFornecedor()
        {
            InitializeComponent();
            dgvMostrarEndereco.SelectionMode=DataGridViewSelectionMode.FullRowSelect;
            dgvMostrarEndereco.CellContentClick += dgvMostrarEndereco_CellContentClick;
            dgvMostrarEndereco.MultiSelect=false;

            
        }

        private void pnlCadastrar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (pnlCadastrarFornecedor.Visible==false)
            {
                pnlCadastrarFornecedor.Visible = true;
                alteraBotoes(1, perInserir, perAlterar, perExcluir, perImprimir);
                LimparCampos();
            }
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            if (pnlCadastrarFornecedor.Visible == true)
            {
                pnlCadastrarFornecedor.Visible = false;
            }
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            PesquisarFornecedorComChave();
        }
        public void PesquisarFornecedorComChave()
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLFornecedor bll = new BLLFornecedor(cx);
            dgvDados.DataSource = bll.PesquisarFornecedorComChave(txtPesquisarFornecedor.Text);
        }
        public void CarregarFornecedores()
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLFornecedor bll = new BLLFornecedor(cx);
            dgvDados.DataSource = bll.MostrarFornecedores();
        }
        public void PesquisarEnderecoComChave()
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLFornecedor bll = new BLLFornecedor(cx);
            dgvMostrarEndereco.DataSource = bll.PesquisarEnderecoComChave(txtPesquisarEndreco.Text);
        }
        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            PesquisarEnderecoComChave();
           
        }

        private void frmFornecedor_Load(object sender, EventArgs e)
        {
            
            CarregarFornecedores();
        }

        private void pnlEndereco_Paint(object sender, PaintEventArgs e)
        {

        }
        

        private void dgvMostrarEndereco_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0)
            {
                //DataGridViewRow linhaselecionada = dgvMostrarEndereco.Rows[e.RowIndex];
                txtCodigoEndereco.Text = Convert.ToString(dgvMostrarEndereco.Rows[e.RowIndex].Cells["EnderecoID"].Value);
               
            }
            
        }
        public void LimparCampos()
        {
            txtCodigo.Text = "";
            txtCodigoEndereco.Text = "";
            txtNome.Text = "";
            txtObs.Text = "";
            txtPesquisarEndreco.Text = "";
            cmbTipoServico.SelectedItem = null;
        }

        private void btnAdcEndereco_Click(object sender, EventArgs e)
        {
            frmAdicionarEndereco fr = new frmAdicionarEndereco();
            fr.Show();
        }

        private void dgvDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
      

            string colname = dgvDados.Columns[e.ColumnIndex].Name;
            if (colname== "colEditar")
            {
                txtCodigo.Text = dgvDados.Rows[e.RowIndex].Cells["FornecedorID"].Value.ToString();
                txtNome.Text = dgvDados.Rows[e.RowIndex].Cells["NomeFornecedor"].Value.ToString();
                //cmbTipoServico.Text = dgvDados.Rows[e.RowIndex].Cells["TipoServico"].Value.ToString();
                try
                {
                    cmbTipoServico.Text = dgvDados.Rows[e.RowIndex].Cells["TipoServico"].Value?.ToString();
                }
                catch (Exception ex)
                {
                    // Tratar exceção, você pode imprimir a mensagem de erro ou tomar outras medidas adequadas.
                    Console.WriteLine($"Erro ao obter valor da célula: {ex.Message}");
                }

                txtCodigoEndereco.Text = dgvDados.Rows[e.RowIndex].Cells["EnderecoID"].Value.ToString();
                txtObs.Text = dgvDados.Rows[e.RowIndex].Cells["Observacao"].Value.ToString();
                if (pnlCadastrarFornecedor.Visible==false)
                {
                    pnlCadastrarFornecedor.Visible = true;
                    alteraBotoes(3, perInserir, perAlterar, perExcluir, perImprimir);
                }
            }
            if (colname == "ColDeletar")
            {
                try
                {
                    DialogResult d = MessageBox.Show("desejas realmente excluir os dados?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                    if (d.ToString() == "Yes")
                    {
                        int col = Convert.ToInt32(dgvDados.CurrentRow.Cells["FornecedorID"].Value);
                        DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                        BLLFornecedor bll = new BLLFornecedor(cx);
                        bll.DeletarFornecedor(col);
                        MessageBox.Show("Dados eliminados com Sucesso!!"," Confirmação");
                        CarregarFornecedores();
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Falha na Remoção do Dados" + ex.Message);
                }
               


            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
        Boolean perInserir=false, perAlterar=false, perExcluir=false, perImprimir=false;

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                ModeloFornecedor modelo = new ModeloFornecedor();
                modelo.fornecedorID = Convert.ToInt32(txtCodigo.Text);
                modelo.enderecoID = Convert.ToInt32(txtCodigoEndereco.Text);
                modelo.tipoServico = cmbTipoServico.Text;
                modelo.nomeFornecedor = txtNome.Text;
                modelo.Observacao = txtObs.Text;
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLFornecedor bll = new BLLFornecedor(cx);
                bll.AlterarFornecedor(modelo);
                MessageBox.Show("Dados Alterados  com Sucesso");
                CarregarFornecedores();
                LimparCampos();


            }
            catch (Exception erro)
            {

                MessageBox.Show("Não foi possivel Realizar a Operação!!! \n\nContate o Administrador do Sistema!!!\n\nErro Ocorrido:" + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                ModeloFornecedor modelo = new ModeloFornecedor();
                modelo.enderecoID = Convert.ToInt32(txtCodigoEndereco.Text);
                modelo.tipoServico = cmbTipoServico.Text;
                modelo.nomeFornecedor = txtNome.Text;
                modelo.Observacao = txtObs.Text;
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLFornecedor bll = new BLLFornecedor(cx);
                bll.Incluir(modelo);
                MessageBox.Show("Dados Cadastrados com Sucesso");
                CarregarFornecedores();
                LimparCampos();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possivel Realizar a Operação!!! \n\nContate o Administrador do Sistema!!!\n\nErro Ocorrido:" + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Stop);


            }
        }

        public void alteraBotoes(int op, bool perInserir ,bool  perAlterar, bool perExcluir, bool perImprimir)
        {
           
            btnGuardar.Enabled = false;
            btnEditar.Enabled = false;
            btnCancelar.Enabled = false;

            if (op==1)
            {
                btnNovo.Enabled = true;
                btnGuardar.Enabled = false;
                btnEditar.Enabled = false;
                btnCancelar.Enabled = false;

                txtCodigo.Enabled = false;
                txtCodigoEndereco.Enabled=false;
                txtNome.Enabled=false;
                txtObs.Enabled=false;
                txtPesquisarEndreco.Enabled = false;
                cmbTipoServico.Enabled = false;
                btnAdcEndereco.Enabled = false;
            }
            if (op  == 2)
            {
                btnNovo.Enabled = true;
                btnGuardar.Enabled = true;
                btnEditar.Enabled= false;
                btnCancelar.Enabled = true;

                // Definindo propriedades como true
                txtCodigo.Enabled = true;
                txtCodigoEndereco.Enabled = true;
                txtNome.Enabled = true;
                txtObs.Enabled = true;
                txtPesquisarEndreco.Enabled = true;
                cmbTipoServico.Enabled = true;
                btnAdcEndereco.Enabled = true;

            }
            if (op == 3)
            {
                btnGuardar.Enabled = false;
                btnEditar.Enabled= true;
                btnNovo.Visible = true;
                btnCancelar.Enabled = true;

                // Definindo propriedades como true
                txtCodigo.Enabled = true;
                txtCodigoEndereco.Enabled = true;
                txtNome.Enabled = true;
                txtObs.Enabled = true;
                txtPesquisarEndreco.Enabled = true;
                cmbTipoServico.Enabled = true;
                btnAdcEndereco.Enabled = true;
            }

        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
             alteraBotoes(2, perInserir, perAlterar, perExcluir, perImprimir);
            LimparCampos();
        }
    }
}
