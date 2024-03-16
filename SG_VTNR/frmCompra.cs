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
        private ModeloCompra m;
        ModeloCompra ModeloDadosCompra = new ModeloCompra();
        private List <ModeloCompra> listaDeDados =new List<ModeloCompra>();
        public frmCompra()
        {
            InitializeComponent();
             
        m = new ModeloCompra();
        m.UsuarioID = SessaoUsuario.Session.Instance.UsuID;
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
        public void pesquisarFornecedorcomChave()
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCompra bll = new BLLCompra(cx);
            FornecdorDT = bll.PesquisarFornecedorComChavenaCompra(txtPesquisarFornecedor.Text);
                    // Vincular DataTable ao DataGridView
                    dgvFornecedor.DataSource = FornecdorDT;
            dgvFornecedor.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvFornecedor.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvFornecedor.AutoResizeRows();
            dgvFornecedor.Columns["FornecedorID"].HeaderText = "Códgo do Fornecedor";
            dgvFornecedor.Columns["NomeFornecedor"].HeaderText = "Nome do Fornecedor";
            // Ajustar a altura da linha de cabeçalho
            dgvFornecedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

        }
        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtPesquisarFornecedor.Text)|| string.IsNullOrWhiteSpace(txtPesquisarFornecedor.Text))
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

           
        



        private void frmCompra_Load(object sender, EventArgs e)
        {
            if (pnlFornecedor.Visible==true)
            {
                pnlFornecedor.Visible = false;
            }
            if (pnlMostrarProduto.Visible == true)
            {
                pnlMostrarProduto.Visible = false;
            }
            


            if (pnlCadastrarProduto.Visible==true)
            {
                pnlCadastrarProduto.Visible = false;
            }

            

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
            txtCodProdutoCompra.Text = "";
            txtNomeProdutoCompra.Text = "";
            txtTipoProduto.Text = "";
            txtCategoria.Text = "";
        }
        public void CadProduto()
        {
            try
            {
                ModeloCompra modelo = new ModeloCompra();
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
                modelo.finalidadeProduto = lblFinalidade.Text;
                modelo.dataExpiracao = DateTime.MaxValue;
                modelo.CodigodeBara = txtCodigodeBarra.Text;
                modelo.finalidadeProduto = finalidade;
                if (finalidade!="Comercial")
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
                BLLCompra bll = new BLLCompra(cx);
                //inserir os dados
                bll.CadastrarProduto(modelo);

                MessageBox.Show(modelo.produtoID.ToString() + "\n \n Produto Cadastrado com Sucesso!", "Confirmação", MessageBoxButtons.OK);


            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possivel Realizar a Operação!!! \n\nContate o Administrador do Sistema!!!\n\nErro Ocorrido:" + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Stop);


                //MessageBox.Show("Erro ao incluir os dados:","Aviso" + erro.Message);
            }
           }
        public void AtualizarDataGridView()
        {
            //criando uma lista temporaria contendo os atribusto para exibir no data grid view
            var dadosParaExibir = listaDeDados.Select(d => new
            {
                d.produtoID,
                d.NomeProduto,
                d.Qtd,
                d.precoCompraUnitario,
                d.precoUnitarioVenda,
                d.CategoriaProduto,
                d.TipoProduto,
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
                //lblFinalidade.Text = "Entrega Gratuita";
                finalidade = "Entrega Gratuita";
                //txtValorCompr.Text = "";
                txtValorVenda.Text = "";
            }
        }

        private void rbUsoInterno_CheckedChanged(object sender, EventArgs e)
        {
            txtValorCompr.Enabled = false;
            txtValorVenda.Enabled = false;
            //lblFinalidade.Text = "Uso Interno";
            finalidade = "Uso Interno";
            //txtValorCompr.Text = "";
            txtValorVenda.Text = "";
        }

        private void rbComercial_CheckedChanged(object sender, EventArgs e)
        {
            txtValorCompr.Enabled = true;
            txtValorVenda.Enabled = true;
            //lblFinalidade.Text = "Comercial";
            finalidade = "Comercial";
            txtValorCompr.Text = "";
            txtValorVenda.Text = "";
        }

        private void gunaShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button4_Click_1(object sender, EventArgs e)
        {
            CadProduto();
            //limparCampos();
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
                    txtCodProdutoCompra.Text = itemSelecionado.produtoID.ToString();
                    txtNomeProdutoCompra.Text = itemSelecionado.NomeProduto;
                    txtValorCompr.Text = itemSelecionado.precoCompraUnitario.ToString();
                    txtQtd.Text = itemSelecionado.Qtd.ToString();

                    txtValorVenda.Text = itemSelecionado.precoUnitarioVenda.ToString();
                    
                    txtTotqtd.Text = itemSelecionado.Total.ToString();
                    txtCategoria.Text = itemSelecionado.CategoriaProduto.ToString();
                    txtTipoProduto.Text = itemSelecionado.TipoProduto.ToString();

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
                    throw new InvalidOperationException("Adicione produtos ao carrinho antes de confirmar a compra.");
                }

                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCompra bll = new BLLCompra(cx);
                // Calcular o totalGeral para toda a venda
                decimal totalGeral = decimal.Parse(txtSubTotal.Text) + decimal.Parse(txtImposto.Text);

                //ModeloCompra tot = new ModeloCompra();
                //tot.totalGeral = totalGeral;
                //tot.UsuarioID = m.UsuarioID;
                // Adicionar o totalGeral à venda
                foreach (var item in listaDeDados)
                {
                    item.totalGeral = totalGeral;
                    item.UsuarioID = m.UsuarioID;
                    item.formaPagamento = cmbMetodoPagamento.Text;
                    item.imposto = decimal.Parse(txtImposto.Text);
                    item.desconto = decimal.Parse(txtDesconto.Text);
                    item.valorEntregue =decimal.Parse(txtValorEntregue.Text);
                    item.troco = decimal.Parse(txtTroco.Text);
                }
                //inserir os dados
                int  compraID=bll.updateProdutoCompra(listaDeDados);

                MessageBox.Show("Compra realizada com sucesso!", "Confirmação", MessageBoxButtons.OK);
                frmFaturaCompra frm = new frmFaturaCompra(compraID);
                frm.ShowDialog();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show($"Erro ao confirmar a compra: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao confirmar a compra. Contate o Administrador do Sistema.\n\nDetalhes do Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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

        public void PesquisarProduto()
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCompra bll = new BLLCompra(cx);
            DataTable dt = new DataTable();
            dt=bll.PesquisarProdutoComChave(txtPesquisarProduto.Text);
            dgvMostrarProduto.DataSource= dt;
            dgvMostrarProduto.Columns["IdProduto"].HeaderText = "Código do Produto";
            dgvMostrarProduto.Columns["NomeProduto"].HeaderText = "Nome do Produto";
            dgvMostrarProduto.Columns["TipoProduto"].HeaderText = "Tipo de Produto";
            dgvMostrarProduto.Columns["CategoriaProduto"].HeaderText = "Categoria do Produto";
            dgvMostrarProduto.Columns["FinalidadeProduto"].HeaderText = "Finalidade do Produto";
            dgvMostrarProduto.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvMostrarProduto.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvMostrarProduto.AutoResizeRows();

            // Ajustar a altura da linha de cabeçalho
            dgvMostrarProduto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;


        }
        private void txtPesquisarProduto_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPesquisarProduto.Text)||string.IsNullOrWhiteSpace(txtPesquisarProduto.Text))
            {
                pnlMostrarProduto.Visible = false;

            }
            else
            {
                if (pnlMostrarProduto.Visible == false)
                {
                    pnlMostrarProduto.Visible = true;
                    PesquisarProduto();
                }
            }
           
           
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //if (pnlCadastrarProduto.Visible==false)
            //{
            //    pnlCadastrarProduto.Visible = true;
            //}
            frmCadastrarProduto frm = new frmCadastrarProduto();
            frm.ShowDialog();
        }

        private void guna2Button7_Click_1(object sender, EventArgs e)
        {

        }
        private void btnAdicionarCarrinhoCompra_Click(object sender, EventArgs e)
        {
             if (dataProducao.Value.Date.AddYears(1)<dataValidade.Value.Date)
            {
                try
                {
                    // verifica o a finalidade do produto
                    if (lblFinalidade.Text != "Comercial")
                    {
                        if (string.IsNullOrEmpty(txtNomeProdutoCompra.Text) ||
                       string.IsNullOrEmpty(txtQtd.Text) || string.IsNullOrEmpty(txtValorCompr.Text))
                        {
                            MessageBox.Show("Preencha os Campos Obrigatórios");
                        }
                        else
                        {
                            int produtoID = Convert.ToInt32(txtCodProdutoCompra.Text);
                            // Verifica se o produto já está no carrinho
                            ModeloCompra produtoExistente = listaDeDados.FirstOrDefault(p => p.produtoID == produtoID);
                            if (produtoExistente != null)
                            {
                                MessageBox.Show("Não foi possível adicionar o produto ao carrinho novamente. Por favor, edite ou remova o produto existente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {

                                int qtdFormulario = Convert.ToInt32(txtQtd.Text);
                                //verifica se o valor que esta no txtQuantidade no formulario eh maior que zero 
                                if (qtdFormulario > 0)
                                {
                                    ModeloCompra novoProduto = new ModeloCompra
                                    {
                                        NomeProduto = txtNomeProdutoCompra.Text,
                                        produtoID = Convert.ToInt32(txtCodProdutoCompra.Text),
                                        Qtd = Convert.ToInt32(txtQtd.Text),
                                        precoUnitarioVenda = 0,
                                        precoCompraUnitario = decimal.Parse(txtValorCompr.Text),
                                        dataProducao = dataProducao.Value,
                                        dataExpiracao = dataValidade.Value,
                                        Total = decimal.Parse(txtTotqtd.Text),
                                        TipoProduto = txtTipoProduto.Text,
                                        CategoriaProduto = txtCategoria.Text,
                                        UsuarioID = m.UsuarioID,
                                        eestadoProduto = true,
                                        DataCompra = DateTime.Now
                                    };
                                    decimal subtotal = Decimal.Parse(txtSubTotal.Text);
                                    subtotal += novoProduto.Total;
                                    txtSubTotal.Text = subtotal.ToString();
                                    this.listaDeDados.Add(novoProduto);
                                    AtualizarDataGridView();
                                    limparCampos();
                                }
                                else
                                {
                                    MessageBox.Show("Quantidade Inválida!!!");
                                }
                            }
                        }
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(txtNomeProdutoCompra.Text) ||
                       string.IsNullOrEmpty(txtQtd.Text) || string.IsNullOrEmpty(txtValorCompr.Text) ||
                       string.IsNullOrEmpty(txtValorVenda.Text))
                        {
                            MessageBox.Show("Preencha os Campos Obrigatórios");
                        }
                        else
                        {
                            int produtoID = Convert.ToInt32(txtCodProdutoCompra.Text);
                            // Verifica se o produto já está no carrinho
                            ModeloCompra produtoExistente = listaDeDados.FirstOrDefault(p => p.produtoID == produtoID);
                            if (produtoExistente != null)
                            {
                                MessageBox.Show("Não foi possível adicionar o produto ao carrinho novamente. Por favor, edite ou remova o produto existente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                int qtdFormulario = Convert.ToInt32(txtQtd.Text);
                                //verifica se o valor que esta no txtQuantidade no formulario eh maior que zero 
                                if (qtdFormulario > 0)
                                {
                                    ModeloCompra novoProduto = new ModeloCompra
                                    {
                                        NomeProduto = txtNomeProdutoCompra.Text,
                                        produtoID = Convert.ToInt32(txtCodProdutoCompra.Text),
                                        Qtd = Convert.ToInt32(txtQtd.Text),
                                        precoUnitarioVenda = decimal.Parse(txtValorVenda.Text),
                                        precoCompraUnitario = decimal.Parse(txtValorCompr.Text),
                                        dataProducao = dataProducao.Value,
                                        dataExpiracao = dataValidade.Value,
                                        Total = decimal.Parse(txtTotqtd.Text),
                                        TipoProduto = txtTipoProduto.Text,
                                        CategoriaProduto = txtCategoria.Text,
                                        UsuarioID = m.UsuarioID,
                                        eestadoProduto = true,
                                        DataCompra = DateTime.Now

                                    };
                                    decimal subtotal = Decimal.Parse(txtSubTotal.Text);
                                    subtotal += novoProduto.Total;
                                    txtSubTotal.Text = subtotal.ToString();
                                    this.listaDeDados.Add(novoProduto);
                                    AtualizarDataGridView();
                                    limparCampos();
                                }
                                else
                                {
                                    MessageBox.Show("Quantidade Inválida!!!");
                                }
                            }


                        }
                    }

                }
                catch (Exception erro)
                {

                    throw new Exception("Erro ao incluir os dados:" + erro.Message);
                }



            }
            else { 
            MessageBox.Show("A data de produção tem de superior a 1 ano amail que a data de válidade", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            if (pnlCadastrarProduto.Visible==true)
            {
                pnlCadastrarProduto.Visible = false;
            }
        }

        private void dgvMostrarProduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNomeProdutoCompra.Text = dgvMostrarProduto.Rows[e.RowIndex].Cells["NomeProduto"].Value.ToString();
            txtCodProdutoCompra.Text = dgvMostrarProduto.Rows[e.RowIndex].Cells["IdProduto"].Value.ToString();
            txtCategoria.Text = dgvMostrarProduto.Rows[e.RowIndex].Cells["CategoriaProduto"].Value.ToString();
            txtTipoProduto.Text = dgvMostrarProduto.Rows[e.RowIndex].Cells["TipoProduto"].Value.ToString();
            string finalidad= dgvMostrarProduto.Rows[e.RowIndex].Cells["FinalidadeProduto"].Value.ToString();
            lblFinalidade.Text = finalidad;
           if (finalidad == "Comercial")
            {
                txtValorVenda.Enabled = true;
            }
            else
            {
                txtValorVenda.Enabled = false;

            }
            txtPesquisarProduto.Text ="";
            if (pnlMostrarProduto.Visible == true)
            {
                pnlMostrarProduto.Visible = false;

            }

        }

        private void txtQtd_TextChanged(object sender, EventArgs e)
        {
            if (lblFinalidade.Text != "Comercial")
            {
                if (string.IsNullOrWhiteSpace(txtQtd.Text))
                {
                    txtTotqtd.Text = "";
                }
                else
                {
                    if (decimal.TryParse(txtQtd.Text, out decimal quantidadeaceite))
                    {
                        txtTotqtd.Text = ((Decimal.Parse(txtValorCompr.Text)) * (Convert.ToInt16(txtQtd.Text))).ToString();
                    }
                    else
                    {
                        // Se o texto não puder ser convertido, informa ao usuário ou toma a ação apropriada
                        MessageBox.Show("O valor entregue não é válido. Insira um valor numérico.");
                        // Ou pode fazer alguma outra ação, como limpar a TextBox ou definir o txtTroco.Text para vazio, etc.
                        txtTotqtd.Text = "";
                    }
                }

            }
            else
            {
                if (string.IsNullOrWhiteSpace(txtQtd.Text) || (string.IsNullOrEmpty(txtValorCompr.Text)))
                {
                    txtTotqtd.Text = "";
                }
                else
                {
                    if (decimal.TryParse(txtQtd.Text, out decimal quantidadeaceite))
                    {
                        txtTotqtd.Text = ((Decimal.Parse(txtValorCompr.Text)) * (Convert.ToInt16(txtQtd.Text))).ToString();
                    }
                    else
                    {
                        // Se o texto não puder ser convertido, informa ao usuário ou toma a ação apropriada
                        MessageBox.Show("O valor entregue não é válido. Insira um valor numérico.");
                        // Ou pode fazer alguma outra ação, como limpar a TextBox ou definir o txtTroco.Text para vazio, etc.
                        txtTotqtd.Text = "";
                    }
                }

            }

        }

        private void txtSubTotal_TextChanged(object sender, EventArgs e)
        {
            txtvalorpagargeral.Text = (decimal.Parse(txtSubTotal.Text) + decimal.Parse(txtImposto.Text)).ToString();
            
            decimal subtotal = decimal.Parse(txtSubTotal.Text);
            decimal imposto = decimal.Parse(txtImposto.Text);
            decimal totalGeral = subtotal + imposto;

            // Adicione logs para depuração
            Console.WriteLine($"Subtotal: {subtotal}, Imposto: {imposto}, Total Geral: {totalGeral}");

            txtvalorpagargeral.Text = totalGeral.ToString();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {

        }

        private void guna2ShadowPanel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
