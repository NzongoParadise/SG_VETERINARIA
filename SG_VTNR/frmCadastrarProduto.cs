using BLL;
using DAL;
using Ferramenta;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SG_VTNR
{
    public partial class frmCadastrarProduto : Form
    {
        public frmCadastrarProduto()
        {
            InitializeComponent();
        }

        private void cmbTipoPropduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipoProduto = cmbTipoPropduto.SelectedItem?.ToString();
            if (tipoProduto == "Vacina")
            {
                cmbItervaloTempo.Enabled = true;
            }
            else
            {
                cmbItervaloTempo.Enabled = false;
            }
        }

        private void limparCampos()
        {
            txtNomeFornecedor.Text = "";
            txtNomeProduto.Text = "";
            txtDosage.Text = "";
            txtFabricante.Text = "";
            txtFormaFarmaceutica.Text = "";
            txtObs.Text = "";
            txtPesquisarFornecedor.Text = "";
            txtxConcentracao.Text = "";
            cmbCategoria.SelectedIndex = 0;
            cmbItervaloTempo.SelectedIndex= 0;
            cmbTipoPropduto.SelectedIndex = 0;
            
        }

        private void btnCdastrarProduto_Click(object sender, EventArgs e)
        {
            CadProduto();
     

        }
        private int intervaloTempo()
        {
            int intervalo = 1;
            if (cmbItervaloTempo.SelectedValue=="6 Meses")
            {
                intervalo = 016;
            }
            else if (cmbItervaloTempo.SelectedValue == "1 Ano ")
            {
                intervalo = 1;

            }
            else if (cmbItervaloTempo.SelectedValue == "2 Anos")
            {
                intervalo = 2;

            }
            else if (cmbItervaloTempo.SelectedValue == "3 Anos")
            {
                intervalo = 3;

            }
            else if (cmbItervaloTempo.SelectedValue == "4 Anos")
            {
                intervalo = 4;

            }
            else if (cmbItervaloTempo.SelectedValue == "5 Anos")
            {
                intervalo = 5;

            }
            else if (cmbItervaloTempo.SelectedValue == "6 Anos")
            {
                intervalo = 6;

            }
            else if (cmbItervaloTempo.SelectedValue == "7 Anos")
            {
                intervalo = 7;

            }
            else if (cmbItervaloTempo.SelectedValue == "8 Anos")
            {
                intervalo = 8;

            }
            else if (cmbItervaloTempo.SelectedValue == "9 Anos")
            {
                intervalo = 9;

            }
            else if (cmbItervaloTempo.SelectedValue == "10 Anos")
            {
                intervalo = 10;

            }
            else if (cmbItervaloTempo.SelectedValue == "Indeterminado")
            {
                intervalo = 100;

            }
            return intervalo;
        }
        public void CadProduto()
        {
            
            try
            {
                ModeloProduto modelo = new ModeloProduto();
                modelo.NomeFornecedor = txtNomeFornecedor.Text;
                modelo.NomeProduto = txtNomeProduto.Text;
                modelo.CodFornecedor = Convert.ToInt32(txtCodFornecedor.Text);
                modelo.Concentracao = txtxConcentracao.Text;
                modelo.Dosagem = txtDosage.Text;
                modelo.TipoProduto = cmbTipoPropduto.Text;
                modelo.CategoriaProduto = cmbCategoria.Text;
                modelo.FormaFarmaceutica = txtFormaFarmaceutica.Text;
                modelo.Obs = txtObs.Text;
                modelo.eestadoProduto = false;
                modelo.Fabricante = txtFabricante.Text;
                modelo.intervaloAplicacao = intervaloTempo();
              
                if (rbComercial.Checked==true)
                {
                   
                    modelo.finalidadeProduto = "Comercial";
                }
                else if (rbGratuita.Checked==true)
                {
                  
                    modelo.finalidadeProduto = "Entrega Gratuita";
                }
                else if (rbUsoInterno.Checked==true)
                {
                    modelo.finalidadeProduto = "Uso Interno";
                }
              
                modelo.dataExpiracao = DateTime.MaxValue;
                modelo.CodigodeBara = txtCodigodeBarra.Text;

                if (modelo.finalidadeProduto != "Comercial")
                {
                   modelo.situacaCusto = "Isento a Custos";
                }
                else
                {
                    modelo.situacaCusto = "Não Isento a Custos";
                }
                //metedoPagamento =cmbMetodoPagamento.Text,
                modelo.DataCadastro = DateTime.Now;
                modelo.UsuarioID = SessaoUsuario.Session.Instance.UsuID;
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLProduto bll = new BLLProduto(cx);
                //inserir os dados
                bll.CadastrarProduto(modelo);

                MessageBox.Show(modelo.produtoID.ToString() + "\n \n Produto Cadastrado com Sucesso!", "Confirmação", MessageBoxButtons.OK);

                limparCampos();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possivel Realizar a Operação!!! \n\nContate o Administrador do Sistema!!!\n\nErro Ocorrido:" + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Stop);


                //MessageBox.Show("Erro ao incluir os dados:","Aviso" + erro.Message);
            }
        }

        public void pesquisarFornecedorcomChave()
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCompra bll = new BLLCompra(cx);
            dgvFornecedor.DataSource = bll.PesquisarFornecedorComChavenaCompra(txtPesquisarFornecedor.Text);
            // Vincular DataTable ao DataGridView
            dgvFornecedor.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvFornecedor.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvFornecedor.AutoResizeRows();
            dgvFornecedor.Columns["FornecedorID"].HeaderText = "Códgo do Fornecedor";
            dgvFornecedor.Columns["NomeFornecedor"].HeaderText = "Nome do Fornecedor";

            // Permitir que as colunas sejam redimensionadas pelos usuários
            dgvFornecedor.AllowUserToResizeColumns = true;

            // Ajustar o tamanho das colunas automaticamente para exibir todo o conteúdo
            dgvFornecedor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // Configurar o DataGridView para quebrar as linhas
            dgvFornecedor.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // Ajustar o estilo do cabeçalho para que possa envolver o texto
            foreach (DataGridViewColumn column in dgvFornecedor.Columns)
            {
                column.HeaderCell.Style.WrapMode = DataGridViewTriState.True;
            }

            // Definir altura das linhas para acomodar o conteúdo completo
            dgvFornecedor.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);

            // Definir o tamanho das linhas do cabeçalho
            dgvFornecedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFornecedor.ColumnHeadersHeight = 40; // Ajuste o valor conforme desejado

            // Aumentar o tamanho das outras linhas
            dgvFornecedor.RowTemplate.Height = 30; // Ajuste o valor conforme desejado para outras linhas

            // Definir cores alternadas para melhorar a visualização
            dgvFornecedor.RowsDefaultCellStyle.BackColor = Color.LightGray;
            dgvFornecedor.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
        }
    
        private void txtPesquisarFornecedor_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtPesquisarFornecedor.Text) || string.IsNullOrWhiteSpace(txtPesquisarFornecedor.Text))
            {
                //if (pnlFornecedor.Visible == true)
                //{
                pnlFornecedor.Visible = false;
            }
            else
            {
                if (pnlFornecedor.Visible == false)
                {
                    pnlFornecedor.Visible = true;
                    pesquisarFornecedorcomChave();
                }
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

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNomeFornecedor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
