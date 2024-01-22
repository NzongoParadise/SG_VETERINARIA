using BLL;
using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SG_VTNR
{
    public partial class frmCompra : Form
    {
        private DataTable FornecdorDT = new DataTable();
        private DataTable TransacaoDT = new DataTable();
        string finalidade;
        ModeloCompra ModeloDadosCompra = new ModeloCompra();
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
            TransacaoDT.Columns.Add("Fornecedor");
            TransacaoDT.Columns.Add("Nome do produto");
            TransacaoDT.Columns.Add("Quantidade");
            //TransacaoDT.Columns.Add("Fornecedor");
            TransacaoDT.Columns.Add("Valor de Compra");
            TransacaoDT.Columns.Add("Valor de Venda");
            //TransacaoDT.Columns.Add("Categoria");
            TransacaoDT.Columns.Add("Tipo Produto");
            TransacaoDT.Columns.Add("Categoria Produto");

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
            cmbCategoria.SelectedIndex = -1;
            cmbCategoria.Text = "";
            txtCodFornecedor.Text = "";
            txtFormaFarmaceutica.Text = "";
            txtObs.Text = "";
            txtNomeFornecedor.Text = "";
        }

        private List <ModeloCompra> listaDeDados = new List <ModeloCompra>();
        private void guna2Button4_Click(object sender, EventArgs e)
        {
           
            
            if (string.IsNullOrEmpty(txtNomeProduto.Text) || string.IsNullOrEmpty(txtCodFornecedor.Text) ||
                string.IsNullOrEmpty(txtQtd.Text) || string.IsNullOrEmpty(txtValorCompr.Text) ||
                string.IsNullOrEmpty(txtValorVenda.Text) || string.IsNullOrEmpty(txtxConcentracao.Text) ||
                string.IsNullOrEmpty(txtDosage.Text) || string.IsNullOrEmpty(cmbTipoPropduto.Text) ||
                string.IsNullOrEmpty(cmbCategoria.Text) || string.IsNullOrEmpty(txtCodFornecedor.Text) ||
                string.IsNullOrEmpty(txtFormaFarmaceutica.Text) || string.IsNullOrEmpty(txtNomeFornecedor.Text)||string.IsNullOrEmpty(txtFabricante.Text))
            {
                MessageBox.Show("Preencha os Campos Obrigatórios");
            }
            else
            {
                // Adiciona os dados à lista
                ModeloCompra novoProduto = new ModeloCompra

                {
                    NomeFornecedor = txtNomeFornecedor.Text,
                    NomeProduto = txtNomeProduto.Text,
                    CodFornecedor = Convert.ToInt32(txtCodFornecedor.Text),
                    Qtd = Convert.ToInt32(txtQtd.Text),
                    precoCompraUnitario = Decimal.Parse(txtValorCompr.Text),
                    precoUnitarioVenda = Decimal.Parse(txtValorVenda.Text),
                    Concentracao = txtxConcentracao.Text,
                    Dosagem = txtDosage.Text,
                    TipoProduto = cmbTipoPropduto.Text,
                    CategoriaProduto = cmbCategoria.Text,
                    FormaFarmaceutica = txtFormaFarmaceutica.Text,
                    Obs = txtObs.Text,
                    Fabricante = txtFabricante.Text,
                    Total = Convert.ToInt32(txtQtd.Text) * Decimal.Parse(txtValorCompr.Text),
                    dataProducao = Convert.ToDateTime(dataProducao.Text),
                    dataExpiracao = Convert.ToDateTime(DataExpiracao.Text),
                    finalidadeProduto=lblFinalidade.Text,
                    metedoPagamento=cmbMetodoPagamento.Text,
                    DataCompra=DateTime.Now,
                    

                };

                listaDeDados.Add(novoProduto);
                // Atualiza o SubTotal somando o Total do novo produto
                decimal subtotal = Decimal.Parse(txtSubTotal.Text);
                subtotal += novoProduto.Total;
                txtSubTotal.Text = subtotal.ToString();
                // Atualiza o DataGridView
                AtualizarDataGridView();

            }
        }

        public void AtualizarDataGridView()
        {
            //criando uma lista temporaria contendo os atribusto para exibir no data grid view
            var dadosParaExibir = listaDeDados.Select(d => new
            {
                d.NomeFornecedor,
                d.NomeProduto,
                d.Qtd,
                d.precoCompraUnitario,
                d.precoUnitarioVenda,
                d.Total,
            }).ToList();
            // Atualiza o DataSource do DataGridView com a listaDeDados
            dgvCarinho.DataSource = null;  // Limpa qualquer fonte de dados existente
            dgvCarinho.DataSource = dadosParaExibir;
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
                lblFinalidade.Text = "Entrega Gratuita";
                finalidade = Convert.ToString(lblFinalidade.Text);
                txtValorCompr.Text = "";
                txtValorVenda.Text = "";
            }
        }

        private void rbUsoInterno_CheckedChanged(object sender, EventArgs e)
        {
            txtValorCompr.Enabled = false;
            txtValorVenda.Enabled = false;
            lblFinalidade.Text = "Uso Interno";
            finalidade = Convert.ToString(lblFinalidade.Text);
            txtValorCompr.Text = "";
            txtValorVenda.Text = "";
        }

        private void rbComercial_CheckedChanged(object sender, EventArgs e)
        {
            txtValorCompr.Enabled = true;
            txtValorVenda.Enabled = true;
            lblFinalidade.Text = "Comercial";
            finalidade = Convert.ToString(lblFinalidade.Text);
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
        public void EliminarColSelecionada()
        {
            if (dgvCarinho.SelectedRows.Count > 0)
            {
                // Obtém o índice da linha selecionada
                int rowIndex = dgvCarinho.SelectedRows[0].Index;


                // Obtém o item correspondente na listaDeDados usando o índice
                ModeloCompra itemRemovido = listaDeDados[rowIndex];


                // Remove o item correspondente na listaDeDados usando o índice
                listaDeDados.RemoveAt(rowIndex);
                // Subtrai o Total do item removido do subtotal
                decimal subtotal = Decimal.Parse(txtSubTotal.Text);
                subtotal -= itemRemovido.Total;
                txtSubTotal.Text = subtotal.ToString();


                // Atualiza o DataSource do DataGridView
                AtualizarDataGridView();

            }
        }

        private void dgvCarinho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string collname = dgvCarinho.Columns[e.ColumnIndex].Name;
            if (collname == "ColDeletar")
            {

                EliminarColSelecionada();

            }
            else
            {
                    // Verifica se o clique ocorreu na coluna correspondente ao botão de editar
                    if (e.RowIndex >= 0 && e.ColumnIndex == dgvCarinho.Columns["colEditar"].Index)
                    {
                        // Obtém o índice da linha selecionada
                        int rowIndex = e.RowIndex;

                    // Obtém o item correspondente na listaDeDados usando o índice
                    ModeloCompra itemSelecionado = listaDeDados[rowIndex];

                        // Carrega as informações do item nas TextBoxes
                        txtNomeProduto.Text = itemSelecionado.NomeProduto;
                        txtCodFornecedor.Text = itemSelecionado.CodFornecedor.ToString();
                        txtQtd.Text = itemSelecionado.Qtd.ToString();
                        txtValorCompr.Text = itemSelecionado.precoCompraUnitario.ToString();

                        txtValorVenda.Text = itemSelecionado.precoUnitarioVenda.ToString();
                        txtxConcentracao.Text = itemSelecionado.Concentracao;
                        txtDosage.Text = itemSelecionado.Dosagem;
                        cmbTipoPropduto.Text = itemSelecionado.TipoProduto;
                        cmbCategoria.Text = itemSelecionado.CategoriaProduto;
                        txtFormaFarmaceutica.Text = itemSelecionado.FormaFarmaceutica;
                        txtObs.Text = itemSelecionado.Obs;
                    txtNomeFornecedor.Text = itemSelecionado.NomeFornecedor;
                        // Carregue outras TextBoxes conforme necessário

                    // ... Restante do seu código para carregar outras TextBoxes ...

                    // Pode ser útil armazenar o índice da linha selecionada para referência futura
                    // Pode ser usado em conjunto com o botão de "Salvar" no seu formulário de edição
                    // para atualizar os dados na listaDeDados na posição correta
                    this.Tag = rowIndex;
                    EliminarColSelecionada();
                }

            }
        }

        private void lblFinalidade_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
           
            try
            {
                if (dgvCarinho.Rows.Count == 0)
                {
                    throw new Exception("Adicione produtos ao carrinho antes de confirmar a compra.!!!");
                    
                }
                
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCompra bll = new BLLCompra(cx);
                //inserir os dados
                bll.incluirProdutoCompra(listaDeDados);
                MessageBox.Show("\n \n Compra realizada com Sucesso!", "Confirmação", MessageBoxButtons.OK);

            }
            catch (Exception erro)
            {

                MessageBox.Show("Não foi possivel Realizar a Operação!!! \n\nContate o Administrador do Sistema!!!\n\nErro Ocorrido:" + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }


        
        }

        private void txtTotalGeral_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtValorEntregue.Text))
            {
                txtTroco.Text = "";
            }
            else
            {
                // Verifica se o texto pode ser convertido para decimal
                if (decimal.TryParse(txtValorEntregue.Text, out decimal valorEntregue))
                {
                    decimal subtotal = decimal.Parse(txtSubTotal.Text);
                    txtTroco.Text = (valorEntregue - subtotal).ToString();
                }
                else
                {
                    // Se o texto não puder ser convertido, informa ao usuário ou toma a ação apropriada
                    MessageBox.Show("O valor entregue não é válido. Insira um valor numérico.");
                    // Ou pode fazer alguma outra ação, como limpar a TextBox ou definir o txtTroco.Text para vazio, etc.
                    txtTroco.Text = "";
                }
            }
        }

    }
}
