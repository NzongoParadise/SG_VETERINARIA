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
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SG_VTNR
{
    public partial class frmVenda : Form
    {
        //variavel que recebe a quantidade disponivel do produto vindo da base de dados
        int qtdDisponivelBaseDados = 0;
        decimal totalGeral=0;
        private ModeloVenda m;

        public frmVenda()
        {
            InitializeComponent();

            m = new ModeloVenda();
            m.UsuarioID = SessaoUsuario.Session.Instance.UsuID;
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
               
            
                var frm = new frmFaturaVenda(6);
                frm.ShowDialog();
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

            if (string.IsNullOrWhiteSpace(txtQuantidade.Text) || (string.IsNullOrEmpty(txtPrecoUnitario.Text)))
            {
                txtTotal.Text = "";
            }
            else
            {
                if (decimal.TryParse(txtQuantidade.Text, out decimal quantidadeaceite))
                {


                    txtTotal.Text = ((Decimal.Parse(txtPrecoUnitario.Text)) * (Convert.ToInt16(txtQuantidade.Text))).ToString();

                }
                else
                {
                    // Se o texto não puder ser convertido, informa ao usuário ou toma a ação apropriada
                    MessageBox.Show("O valor entregue não é válido. Insira um valor numérico.");
                    // Ou pode fazer alguma outra ação, como limpar a TextBox ou definir o txtTroco.Text para vazio, etc.
                    txtTotal.Text = "";

                }
            }


        }



        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvEndereco_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            txtNomeProduto.Text = dgvMostrarProduto.Rows[e.RowIndex].Cells["Nome do Produto"].Value.ToString();
            txtCodProduto.Text = dgvMostrarProduto.Rows[e.RowIndex].Cells["Código Produto"].Value.ToString();
            txtPrecoUnitario.Text = dgvMostrarProduto.Rows[e.RowIndex].Cells["Valor de Venda"].Value.ToString();
            qtdDisponivelBaseDados = Convert.ToInt32(dgvMostrarProduto.Rows[e.RowIndex].Cells["Quantidade Disponivel"].Value.ToString());
            txtqtdDisponivelStock.Text = qtdDisponivelBaseDados.ToString();
            //panelMostrarProduto.Visible=false;
            txtPesquisarProduto.Text = "";

        }

        private void frmVenda_Load(object sender, EventArgs e)
        {
            panelMostrarProduto.Visible = false;
        }
        public void PesquisarProduto()
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLVenda bll = new BLLVenda(cx);
            DataTable dt = new DataTable();
            dt = bll.PesquisarProduto(txtPesquisarProduto.Text);
            dgvMostrarProduto.DataSource = dt;

            //atribuicao dos valores no outro datagriview
            dgvMostrarProduto.DataSource = dt;
            // Permitir que as colunas sejam redimensionadas pelos usuários
            dgvMostrarProduto.AllowUserToResizeColumns = true;

            // Ajustar o tamanho das colunas automaticamente para exibir todo o conteúdo
            dgvMostrarProduto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // Configurar o DataGridView para quebrar as linhas
            dgvMostrarProduto.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // Ajustar o estilo do cabeçalho para que possa envolver o texto
            foreach (DataGridViewColumn column in dgvMostrarProduto.Columns)
            {
                column.HeaderCell.Style.WrapMode = DataGridViewTriState.True;
            }

            // Definir altura das linhas para acomodar o conteúdo completo
            dgvMostrarProduto.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);

            // Definir o tamanho das linhas do cabeçalho
            dgvMostrarProduto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMostrarProduto.ColumnHeadersHeight = 40; // Ajuste o valor conforme desejado

            // Aumentar o tamanho das outras linhas
            dgvMostrarProduto.RowTemplate.Height = 30; // Ajuste o valor conforme desejado para outras linhas

            // Adicionar diferença visual na cor das linhas
            dgvMostrarProduto.RowsDefaultCellStyle.BackColor = Color.LightGray;
            dgvMostrarProduto.AlternatingRowsDefaultCellStyle.BackColor = Color.White;


        }
        private void rxrPesquisarProduto_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPesquisarProduto.Text) || string.IsNullOrEmpty(txtPesquisarProduto.Text))
            {

                panelMostrarProduto.Visible = false;

            }
            else
            {

                panelMostrarProduto.Visible = true;
                PesquisarProduto();
            }

        }


        public void InserirAoCarrinho()
        {

            try
            {
                if (string.IsNullOrEmpty(txtCodProduto.Text) || string.IsNullOrEmpty(txtNomeCliente.Text) || string.IsNullOrEmpty(txtNomeProduto.Text)
                       || (string.IsNullOrEmpty(txtQuantidade.Text)))
                {
                    MessageBox.Show("Preencha os campos obrigatórios!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    //craica da variavel local que recebe a quantidade que o produto quer comprar para verificar se eh menor ou igual com a quantidade disponivel
                    int qtdCompra = Convert.ToInt32(txtQuantidade.Text);
                    //verifica se o valor que esta no txtQuantidade no formulario eh maior que zero 
                    if (qtdCompra > 0)
                    {
                        // verifica se a quantidade no sistema eh maior com aque o usuario esta a inserir no txtQuantidade
                        if (this.qtdDisponivelBaseDados >= qtdCompra)
                        {
                            int produtoID = Convert.ToInt32(txtCodProduto.Text);
                            // Verifica se o produto já está no carrinho
                            ModeloVenda produtoExistente = listaDeDados.FirstOrDefault(p => p.produtoID == produtoID);
                            if (produtoExistente != null)
                            {
                                // Se o produto já existe, atualiza a quantidade
                                int novaQuantidade = Convert.ToInt32(txtQuantidade.Text);
                                produtoExistente.Qtd += novaQuantidade;

                                //produtoExistente.Total = produtoExistente.precoUnitario * produtoExistente.Qtd;
                                //produtoExistente.Total = produtoExistente.precoUnitario * novaQuantidade;
                                decimal novototal = produtoExistente.precoUnitario * novaQuantidade;
                              produtoExistente.Total += novototal; 
                           
                                // Atualiza o SubTotal somando o Total do novo produto
                                decimal subtotal = Decimal.Parse(txtSubtotal.Text);
                                subtotal = subtotal+novototal;
                                txtSubtotal.Text = subtotal.ToString();
                                AtualizarDataGridView();
                            }
                            else
                            {

                                ModeloVenda novoProduto = new ModeloVenda
                                {

                                    produtoID = Convert.ToInt32(txtCodProduto.Text),
                                    Qtd = Convert.ToInt32(txtQuantidade.Text),
                                    precoUnitario = decimal.Parse(txtPrecoUnitario.Text),
                                    Total = decimal.Parse(txtTotal.Text),
                                    nomeProduto = txtNomeProduto.Text,
                                    nomeCliente = txtNomeCliente.Text,

                                    //totalGeral = decimal.Parse(txtTotalGeral.Text),

                                    dataVenda = DateTime.Now,
                                };

                                listaDeDados.Add(novoProduto);
                                // Atualiza o SubTotal somando o Total do novo produto
                                decimal subtotal = Decimal.Parse(txtSubtotal.Text);
                                subtotal += novoProduto.Total;
                                txtSubtotal.Text = subtotal.ToString();

                                // Atualiza o DataGridView
                                AtualizarDataGridView();

                            }
                        }
                        else
                        {
                            MessageBox.Show($"Quantidade superior ao disponível no estoque.\nInforme uma quantidade menor ou igual que  {qtdDisponivelBaseDados}.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            txtQuantidade.Text = "";
                            txtTotal.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show($"A quantidade tem de ser maior que 0.\nInforme uma quantidade superio a 0", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);


                    }
                }

            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro:" + erro.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private List<ModeloVenda> listaDeDados = new List<ModeloVenda>();
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            InserirAoCarrinho();


        }
        public void AtualizarDataGridView()
        {
            //criando uma lista temporaria contendo os atribusto para exibir no data grid view
            var dadosParaExibir = listaDeDados.Select(d => new
            {
                d.nomeProduto,
                d.produtoID,
                d.Qtd,
                d.precoUnitario,
                d.Total,

            }).ToList();
            // Atualiza o DataSource do DataGridView com a listaDeDados
            dgvCarinho.DataSource = null;  // Limpa qualquer fonte de dados existente
            dgvCarinho.DataSource = dadosParaExibir;
            //RENOMEANDO O NOME DAS COLUNAS DO DATAGRIDVIEW
            dgvCarinho.Columns["nomeProduto"].HeaderText = "Nome do do Produto";
            dgvCarinho.Columns["produtoID"].HeaderText = "Código do Produto";
            dgvCarinho.Columns["Qtd"].HeaderText = "Quantidade Selecionada";
            dgvCarinho.Columns["precoUnitario"].HeaderText = "Preço Unitário";
            dgvCarinho.Columns["Total"].HeaderText = "Total";
            // Permitir que as colunas sejam redimensionadas pelos usuários
            dgvCarinho.AllowUserToResizeColumns = true;

            // Ajustar o tamanho das colunas automaticamente para exibir todo o conteúdo
            dgvCarinho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // Configurar o DataGridView para quebrar as linhas
            dgvCarinho.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // Ajustar o estilo do cabeçalho para que possa envolver o texto
            foreach (DataGridViewColumn column in dgvCarinho.Columns)
            {
                column.HeaderCell.Style.WrapMode = DataGridViewTriState.True;
            }

            // Definir altura das linhas para acomodar o conteúdo completo
            dgvCarinho.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);

            // Definir o tamanho das linhas do cabeçalho
            dgvCarinho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarinho.ColumnHeadersHeight = 40; // Ajuste o valor conforme desejado

            // Aumentar o tamanho das outras linhas
            dgvCarinho.RowTemplate.Height = 30; // Ajuste o valor conforme desejado para outras linhas

            // Adicionar diferença visual na cor das linhas
            dgvCarinho.RowsDefaultCellStyle.BackColor = Color.LightGray;
            dgvCarinho.AlternatingRowsDefaultCellStyle.BackColor = Color.White;


        }
        public void EliminarColSelecionada()
        {
            if (dgvCarinho.SelectedRows.Count > 0)
            {
                // Obtém o índice da linha selecionada
                int rowIndex = dgvCarinho.SelectedRows[0].Index;
                // Obtém o item correspondente na listaDeDados usando o índice
                ModeloVenda itemRemovido = listaDeDados[rowIndex];

                // Remove o item correspondente na listaDeDados usando o índice
                listaDeDados.RemoveAt(rowIndex);
                // Subtrai o Total do item removido do subtotal
                decimal subtotal = Decimal.Parse(txtSubtotal.Text);
                decimal teste = itemRemovido.Total;
                subtotal -= itemRemovido.Total;
                txtSubtotal.Text = subtotal.ToString();
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
                    ModeloVenda itemSelecionado = listaDeDados[rowIndex];

                    // Carrega as informações do item nas TextBoxes
                    txtNomeProduto.Text = itemSelecionado.nomeProduto;
                    txtCodProduto.Text = itemSelecionado.produtoID.ToString();
                    txtQuantidade.Text = itemSelecionado.Qtd.ToString();
                    txtTotal.Text = itemSelecionado.Total.ToString();
                  
                    this.Tag = rowIndex;
                    EliminarColSelecionada();
                }

            }
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            
                try
                {
                    ModeloVenda modelo = new ModeloVenda();
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLVenda bll = new BLLVenda(cx);

                    if (dgvCarinho.Rows.Count == 0)
                    {
                        throw new Exception("Adicione produtos ao carrinho antes de confirmar a Venda.!!!");
                    }

                    if (listaDeDados.Count == 0)
                    {
                        throw new Exception("Adicione produtos ao carrinho antes de confirmar a Venda.!!!");
                    }

                    // Calcular o totalGeral para toda a venda
                    decimal totalGeral = decimal.Parse(txtSubtotal.Text) + decimal.Parse(txtImposto.Text);
                    foreach (var item in listaDeDados)
                    {
                        item.totalGeral = totalGeral;
                        item.UsuarioID = m.UsuarioID;
                        item.imposto = decimal.Parse(txtImposto.Text);
                        item.desconto = decimal.Parse(txtDesconto.Text);
                        item.troco = decimal.Parse(txtTroco.Text);
                        item.formaPagamento = cmbFormaPagamento.Text;
                        item.valorentregue = decimal.Parse(txtValorEntregue.Text);
                    }

                    if (string.IsNullOrWhiteSpace(cmbFormaPagamento.Text))
                    {
                        throw new Exception("Escolha o método de pagamento utilizado.");
                    }

                    // Inserir os dados
                    int vendaID = bll.incluirVendaItem(listaDeDados);

                    // Atualizar o vendaID no último item da listaDeDados
                    listaDeDados.Last().vendaID = vendaID;

                    MessageBox.Show(vendaID.ToString() + "\n \n Venda realizada com Sucesso!", "Confirmação", MessageBoxButtons.OK);

                    frmFaturaVenda frm = new frmFaturaVenda(vendaID);
                    frm.ShowDialog();
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Não foi possível Realizar a Operação!!! \n\nContate o Administrador do Sistema!!!\n\nErro Ocorrido:" + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
        }

        private void txtSubtotal_TextChanged(object sender, EventArgs e)
        {
            txtTotalGeral.Text = (decimal.Parse(txtSubtotal.Text) + decimal.Parse(txtImposto.Text)).ToString();

            decimal subtotal = decimal.Parse(txtSubtotal.Text);
            decimal imposto = decimal.Parse(txtImposto.Text);
            decimal totalGeral = subtotal + imposto;

            // Adicione logs para depuração
            Console.WriteLine($"Subtotal: {subtotal}, Imposto: {imposto}, Total Geral: {totalGeral}");

            txtTotalGeral.Text = totalGeral.ToString();
        }

        private void txtValorEntregue_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtValorEntregue.Text) || !string.IsNullOrWhiteSpace(txtValorEntregue.Text))
            {
                decimal valorEntregue = Convert.ToDecimal(txtValorEntregue.Text);
                decimal totalGeral = Convert.ToDecimal(txtTotalGeral.Text);
                decimal troco = valorEntregue - totalGeral;
                txtTroco.Text = troco.ToString();
            }
            }

            private void panelMostrarProduto_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

