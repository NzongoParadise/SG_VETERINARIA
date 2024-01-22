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
            if (string.IsNullOrWhiteSpace(txtQuantidade.Text)||(string.IsNullOrEmpty(txtPrecoUnitario.Text)))
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
            txtNomeProduto.Text = dgvMostrarProduto.Rows[e.RowIndex].Cells["NomeProduto"].Value.ToString();
            txtCodProduto.Text = dgvMostrarProduto.Rows[e.RowIndex].Cells["IDProduto"].Value.ToString();
            txtPrecoUnitario.Text = dgvMostrarProduto.Rows[e.RowIndex].Cells["ValorVenda"].Value.ToString();
            panelMostrarProduto.Visible=false;
            txtPesquisarProduto.Text = "";
        }

        private void frmVenda_Load(object sender, EventArgs e)
        {
            panelMostrarProduto.Visible = false;
        }
       public void  PesquisarProduto()
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLVenda bll = new BLLVenda(cx);
            DataTable dt= new DataTable();
           dt= bll.PesquisarProduto(txtPesquisarProduto.Text);
            dgvMostrarProduto.DataSource = dt;

        }
        private void rxrPesquisarProduto_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPesquisarProduto.Text)){
                panelMostrarProduto.Visible = false;

            }
            else
            {
                PesquisarProduto();
                panelMostrarProduto.Visible = true;
            }
            
        }
        

        private List<ModeloVenda> listaDeDados = new List<ModeloVenda>();
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodProduto.Text)||string.IsNullOrEmpty(txtNomeCliente.Text)||string.IsNullOrEmpty(txtNomeProduto.Text)
                ||(string.IsNullOrEmpty(txtQuantidade.Text)))
            {
                MessageBox.Show("Preencha os campos obrigatórios!!!");

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
                    //totalGeral = decimal.Parse(txtTotalGeral.Text),
                    
                    dataVenda=DateTime.Now,
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
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCarinho.Rows.Count == 0)
                {
                    throw new Exception("Adicione produtos ao carrinho antes de confirmar a Venda.!!!");
                }

                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLVenda bll = new BLLVenda(cx);

                // Calcular o totalGeral para toda a venda
                decimal totalGeral = decimal.Parse(txtSubtotal.Text) + decimal.Parse(txtImposto.Text);

                // Adicionar o totalGeral à venda
                foreach (var item in listaDeDados)
                {
                    item.totalGeral = totalGeral;
                }

                // Inserir os dados
                bll.incluirVendaItem(listaDeDados);
                MessageBox.Show("\n \n Venda realizada com Sucesso!", "Confirmação", MessageBoxButtons.OK);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possível Realizar a Operação!!! \n\nContate o Administrador do Sistema!!!\n\nErro Ocorrido:" + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        //private void guna2Button2_Click(object sender, EventArgs e)
        //{

        //    try
        //    {
        //        if (dgvCarinho.Rows.Count == 0)
        //        {
        //            throw new Exception("Adicione produtos ao carrinho antes de confirmar a Venda.!!!");

        //        }

        //        DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
        //        BLLVenda bll = new BLLVenda(cx);

        //        //inserir os dados
        //        bll.incluirVendaItem(listaDeDados);
        //        MessageBox.Show("\n \n Venda realizada com Sucesso!", "Confirmação", MessageBoxButtons.OK);

        //    }
        //    catch (Exception erro)
        //    {

        //        MessageBox.Show("Não foi possivel Realizar a Operação!!! \n\nContate o Administrador do Sistema!!!\n\nErro Ocorrido:" + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Stop);

        //    }

        //}

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
    }
    }

