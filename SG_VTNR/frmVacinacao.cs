using BLL;
using DAL;
using Ferramenta;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SG_VTNR
{
    public partial class frmVacinacao : Form
    {

        //esta declaracao vai armazenar o id do funcionario nao vai ser necessario mostrar no formulario
        //mas quando tivermos para cadastrar o funcionario que realizou a vacinacao sera muito util para a identificacao
        private int FuncionarioID;
        ModeloVacina m = new ModeloVacina();
        private List<ModeloVacina> listaDeDados = new List<ModeloVacina>();
        private string proprietarioAnimal;
        private string codAnimalDgvMostrarDado;

        public frmVacinacao()
        {
            InitializeComponent();

            m.UsuarioID = SessaoUsuario.Session.Instance.UsuID;
            if (pnlMostrarAnimal.Visible == false)
            {
                pnlMostrarAnimal.Visible = true;
                MostrarTodosAnimais();
            }

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void pnlProduto_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        public void MostrarTodosAnimaisnaochamado()
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLAnimal bll = new BLLAnimal(cx);
            dgvMostrarAnimal.DataSource = bll.MostrarTodosAnimais();

            // Renomear os cabeçalhos das colunas diretamente no DataGridView
            dgvMostrarAnimal.Columns["AnimalID"].HeaderText = "Código";
            dgvMostrarAnimal.Columns["Nome"].HeaderText = "Nome";
            dgvMostrarAnimal.Columns["Especie"].HeaderText = "Espécie";

            // Permitir que as colunas sejam redimensionadas pelos usuários
            dgvMostrarAnimal.AllowUserToResizeColumns = true;

            // Ajustar o tamanho das colunas automaticamente para exibir todo o conteúdo
            dgvMostrarAnimal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // Configurar o DataGridView para quebrar as linhas
            dgvMostrarAnimal.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // Ajustar o estilo do cabeçalho para que possa envolver o texto
            foreach (DataGridViewColumn column in dgvMostrarAnimal.Columns)
            {
                column.HeaderCell.Style.WrapMode = DataGridViewTriState.True;
            }

            // Definir altura das linhas para acomodar o conteúdo completo
            dgvMostrarAnimal.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);

            // Definir o tamanho das linhas do cabeçalho
            dgvMostrarAnimal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMostrarAnimal.ColumnHeadersHeight = 40; // Ajuste o valor conforme desejado

            // Aumentar o tamanho das outras linhas
            dgvMostrarAnimal.RowTemplate.Height = 30; // Ajuste o valor conforme desejado para outras linhas

            // Adicionar diferença visual na cor das linhas
            dgvMostrarAnimal.AlternatingRowsDefaultCellStyle.BackColor = Color.White;


        }
        public void MostrarTodosAnimais()
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLAnimal bll = new BLLAnimal(cx);
            dgvMostrarAnimal.DataSource = bll.MostrarTodosAnimais();

            // Renomear os cabeçalhos das colunas diretamente no DataGridView
            dgvMostrarAnimal.Columns["AnimalID"].HeaderText = "Código";
            dgvMostrarAnimal.Columns["Nome"].HeaderText = "Nome";
            dgvMostrarAnimal.Columns["Especie"].HeaderText = "Espécie";

            // Permitir que as colunas sejam redimensionadas pelos usuários
            dgvMostrarAnimal.AllowUserToResizeColumns = true;

            // Ajustar o tamanho das colunas automaticamente para exibir todo o conteúdo
            dgvMostrarAnimal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // Configurar o DataGridView para quebrar as linhas
            dgvMostrarAnimal.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // Ajustar o estilo do cabeçalho para que possa envolver o texto
            foreach (DataGridViewColumn column in dgvMostrarAnimal.Columns)
            {
                column.HeaderCell.Style.WrapMode = DataGridViewTriState.True;
            }

            // Definir altura das linhas para acomodar o conteúdo completo
            dgvMostrarAnimal.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);

            // Definir o tamanho das linhas do cabeçalho
            dgvMostrarAnimal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMostrarAnimal.ColumnHeadersHeight = 40; // Ajuste o valor conforme desejado

            // Aumentar o tamanho das outras linhas
            dgvMostrarAnimal.RowTemplate.Height = 30; // Ajuste o valor conforme desejado para outras linhas

            // Definir cores alternadas para melhorar a visualização
            dgvMostrarAnimal.RowsDefaultCellStyle.BackColor = Color.LightGray;
            dgvMostrarAnimal.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
        }

        public void PesquisarAnimalcomChave()
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLAnimal bll = new BLLAnimal(cx);
            dgvMostrarAnimal.DataSource = bll.PesquisarAnimalcomChaveVacina(txtPesquisarAnimal.Text);

            // Renomear os cabeçalhos das colunas diretamente no DataGridView
            dgvMostrarAnimal.Columns["AnimalID"].HeaderText = "Código";
            dgvMostrarAnimal.Columns["Nome"].HeaderText = "Nome";
            dgvMostrarAnimal.Columns["Especie"].HeaderText = "Espécie";

            // Permitir que as colunas sejam redimensionadas pelos usuários
            dgvMostrarAnimal.AllowUserToResizeColumns = true;

            // Ajustar o tamanho das colunas automaticamente para exibir todo o conteúdo
            dgvMostrarAnimal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // Configurar o DataGridView para quebrar as linhas
            dgvMostrarAnimal.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // Ajustar o estilo do cabeçalho para que possa envolver o texto
            foreach (DataGridViewColumn column in dgvMostrarAnimal.Columns)
            {
                column.HeaderCell.Style.WrapMode = DataGridViewTriState.True;
            }

            // Definir altura das linhas para acomodar o conteúdo completo
            dgvMostrarAnimal.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);

            // Definir o tamanho das linhas do cabeçalho
            dgvMostrarAnimal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMostrarAnimal.ColumnHeadersHeight = 40; // Ajuste o valor conforme desejado

            // Aumentar o tamanho das outras linhas
            dgvMostrarAnimal.RowTemplate.Height = 30; // Ajuste o valor conforme desejado para outras linhas

            // Adicionar diferença visual na cor das linhas
            dgvMostrarAnimal.AlternatingRowsDefaultCellStyle.BackColor = Color.White;


        }
        private void txtPesquisarAnimal_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtPesquisarAnimal.Text) || string.IsNullOrEmpty(txtPesquisarAnimal.Text))
            {
                //if (pnlMostrarAnimal.Visible == true)
                //{
                //    pnlMostrarAnimal.Visible = false;
                //}
                MostrarTodosAnimais();

            }
            else
            {
                //if (pnlMostrarAnimal.Visible == false)
                //{
                //pnlMostrarAnimal.Visible = true;
                PesquisarAnimalcomChave();
                //}



            }


        }




        private void btnfechararevacinacao_Click(object sender, EventArgs e)
        {

            DialogResult dialogo = MessageBox.Show("Desejas guardar as alterações do foruário?", "Aviso", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (dialogo.ToString() == "Yes")
            {
                tabControl1.SelectTab(tabPage2);
                btnGravar.Focus();
            }


            else if (dialogo.ToString() == "No")
            {
                this.Close();
            }

        }

        private void dgvMostrarDado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmVacinacao_Load(object sender, EventArgs e)
        {


            //if (pnlMostrarAnimal.Visible == true)
            //{
            //    pnlMostrarAnimal.Visible = false;
            //}
            lblVacinasSelecionadas.Visible = false;

            if (pnlCarrinho.Visible == true)
            {
                pnlCarrinho.Visible = false;
            }

            if (pnlMostrarProduto.Visible == true)
            {
                pnlMostrarProduto.Visible = false;
            }


        }







        private void pnlMostrarDadosPesquisa_Paint(object sender, PaintEventArgs e)
        {

        }

        //private void dgvMostrarAnimal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{


        //    if (e.RowIndex >= 0)
        //    {
        //        // Crie um DataTable com as colunas desejadas
        //        DataTable dt = new DataTable();
        //        dt.Columns.Add("Especie");
        //        dt.Columns.Add("Nome");
        //        dt.Columns.Add("Estado");
        //        dt.Columns.Add("Raca");
        //        dt.Columns.Add("Porte");
        //        dt.Columns.Add("Sexo");
        //        dt.Columns.Add("Peso");
        //        dt.Columns.Add("AnimalID");
        //        dt.Columns.Add("Idade");

        //        // Obtenha os valores das células do DataGridView
        //        string especie = dgvMostrarAnimal.Rows[e.RowIndex].Cells["Especie"].Value.ToString();
        //        string nome = dgvMostrarAnimal.Rows[e.RowIndex].Cells["Nome"].Value.ToString();
        //        string estado = dgvMostrarAnimal.Rows[e.RowIndex].Cells["Estado"].Value.ToString();
        //        string raca = dgvMostrarAnimal.Rows[e.RowIndex].Cells["Raca"].Value.ToString();
        //        string porte = dgvMostrarAnimal.Rows[e.RowIndex].Cells["Porte"].Value.ToString();
        //        string sexo = dgvMostrarAnimal.Rows[e.RowIndex].Cells["Sexo"].Value.ToString();
        //        string peso = dgvMostrarAnimal.Rows[e.RowIndex].Cells["Peso"].Value.ToString();
        //        string animalID = dgvMostrarAnimal.Rows[e.RowIndex].Cells["AnimalID"].Value.ToString();

        //        DateTime nascimento = Convert.ToDateTime(dgvMostrarAnimal.Rows[e.RowIndex].Cells["DataNascimento"].Value.ToString());
        //        TimeSpan diferenca = DateTime.Now - nascimento;
        //        int idadeEmAnos = (int)(diferenca.TotalDays / 365.25);
        //        int idadeEmMeses = (int)((diferenca.TotalDays % 365.25) / 30.44);

        //        // Adicione uma nova linha ao DataTable
        //        DataRow novaLinha = dt.NewRow();
        //        novaLinha["Especie"] = especie;
        //        novaLinha["Nome"] = nome;
        //        novaLinha["Estado"] = estado;
        //        novaLinha["Raca"] = raca;
        //        novaLinha["Porte"] = porte;
        //        novaLinha["Sexo"] = sexo;
        //        novaLinha["Peso"] = peso;
        //        novaLinha["AnimalID"] = animalID;
        //        novaLinha["Idade"] = idadeEmAnos == 0 ? $"{idadeEmMeses} Meses" : $"{idadeEmAnos} Ano(s)";

        //        dt.Rows.Add(novaLinha);

        //        // Vincule o DataTable ao DataGridView
        //        guna2DataGridView1.DataSource = dt;

        //        //DataGridViewRow row = dgvMostrarAnimal.Rows[e.RowIndex];
        //        //txtEspecie.Text = dgvMostrarAnimal.Rows[e.RowIndex].Cells["Especie"].Value.ToString();
        //        //txtResPesqAnimal.Text = dgvMostrarAnimal.Rows[e.RowIndex].Cells["Nome"].Value.ToString();
        //        //txtEstado.Text = dgvMostrarAnimal.Rows[e.RowIndex].Cells["Estado"].Value.ToString();
        //        //txtRaca.Text = dgvMostrarAnimal.Rows[e.RowIndex].Cells["Raca"].Value.ToString();
        //        //txtPorte.Text = dgvMostrarAnimal.Rows[e.RowIndex].Cells["Porte"].Value.ToString();
        //        //txtSexo.Text = dgvMostrarAnimal.Rows[e.RowIndex].Cells["Sexo"].Value.ToString();
        //        //txtPeso.Text = dgvMostrarAnimal.Rows[e.RowIndex].Cells["Peso"].Value.ToString();
        //        //txtCodigoAnimal.Text = dgvMostrarAnimal.Rows[e.RowIndex].Cells["AnimalID"].Value.ToString();

        //        //DateTime nascimento = Convert.ToDateTime(dgvMostrarAnimal.Rows[e.RowIndex].Cells["DataNascimento"].Value.ToString());

        //        //// Calcula a diferença entre a data atual e a data de nascimento
        //        //TimeSpan diferenca = DateTime.Now - nascimento;
        //        //int idadeEmAnos = (int)(diferenca.TotalDays / 365.25);
        //        //int idadeEmMeses = (int)((diferenca.TotalDays % 365.25) / 30.44); // Aproximadamente 30.44 dias em um mês

        //        //if (idadeEmAnos == 0)
        //        //{
        //        //    txtIdade.Text = $"{idadeEmMeses} Meses";

        //        //}
        //        //else
        //        //{
        //        //    txtIdade.Text = $"{idadeEmAnos} Ano(s)";

        //        //}


        //        if (pnlMostrarAnimal.Visible == true)
        //        {
        //            pnlMostrarAnimal.Visible = false;
        //        }
        //    }
        //}
        //private void dgvMostrarAnimal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{

        private void dgvMostrarAnimal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtEspecie.Text = dgvMostrarAnimal.Rows[e.RowIndex].Cells["Especie"].Value.ToString();
                txtNomeAnimal.Text = dgvMostrarAnimal.Rows[e.RowIndex].Cells["Nome"].Value.ToString();
                txtEstado.Text = dgvMostrarAnimal.Rows[e.RowIndex].Cells["Estado"].Value.ToString();
                txtRaca.Text = dgvMostrarAnimal.Rows[e.RowIndex].Cells["Raca"].Value.ToString();
                txtPorte.Text = dgvMostrarAnimal.Rows[e.RowIndex].Cells["Porte"].Value.ToString();
                txtCor.Text = dgvMostrarAnimal.Rows[e.RowIndex].Cells["Cor"].Value.ToString();
                txtSexo.Text = dgvMostrarAnimal.Rows[e.RowIndex].Cells["Sexo"].Value.ToString();
                txtPeso.Text = dgvMostrarAnimal.Rows[e.RowIndex].Cells["Peso"].Value.ToString();
                int codAnimal = Convert.ToInt32(txtCodAnimal.Text = dgvMostrarAnimal.Rows[e.RowIndex].Cells["AnimalID"].Value.ToString());
                DateTime nascimento = Convert.ToDateTime(dgvMostrarAnimal.Rows[e.RowIndex].Cells["DataNascimento"].Value.ToString());
                TimeSpan diferenca = DateTime.Now - nascimento;
                int idadeEmAnos = (int)(diferenca.TotalDays / 365.25);
                int idadeEmMeses = (int)((diferenca.TotalDays % 365.25) / 30.44); // Aproximadamente 30.44 dias em um mês
                txtIdade.Text = idadeEmAnos == 0 ? $"{idadeEmMeses} Meses" : $"{idadeEmAnos} Ano(s)";
                txtNomeprop.Text = ProcurarNomeProprietarioVacina(codAnimal);




            }
        }
        private void RenomearCabecalhos()
        {
            //// Renomear os cabeçalhos das colunas diretamente no DataGridView
            //dgvSuspensoDadosAnimal.Columns["Especie"].HeaderText = "Espécie";
            //dgvSuspensoDadosAnimal.Columns["Nome"].HeaderText = "Nome";
            //dgvSuspensoDadosAnimal.Columns["Estado"].HeaderText = "Estado";
            //dgvSuspensoDadosAnimal.Columns["Raca"].HeaderText = "Raça";
            //dgvSuspensoDadosAnimal.Columns["Porte"].HeaderText = "Porte";
            //dgvSuspensoDadosAnimal.Columns["Sexo"].HeaderText = "Sexo";
            //dgvSuspensoDadosAnimal.Columns["Peso"].HeaderText = "Peso";
            //dgvSuspensoDadosAnimal.Columns["AnimalID"].HeaderText = "Código";
            //dgvSuspensoDadosAnimal.Columns["Idade"].HeaderText = "Idade";
            //dgvSuspensoDadosAnimal.Columns["proprietario"].HeaderText = "Proprietario";
        }


        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        //este metodo com base o evento textchange do codigo do animal.ele vai produrarna na tabela proprietario
        //em funcao do id do proprietario que esta na tabela animal o nome do proprietario
        public string ProcurarNomeProprietarioVacina(int cod)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLAnimal bll = new BLLAnimal(cx);
            //proprietarioAnimal = bll.PesquisarNomeProprietarioVacinaComCodigo(cod);
            return bll.PesquisarNomeProprietarioVacinaComCodigo(cod);


        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            //este metodo com base o evento textchange do codigo do animal.ele vai produrarna na tabela proprietario
            //em funcao do id do proprietario que esta na tabela animal o nome do proprietario


        }

        private void txtPesquisarVacina_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPesquisarVacina.Text) || string.IsNullOrWhiteSpace(txtPesquisarVacina.Text))
            {
                if (pnlMostrarProduto.Visible == true)
                {
                    pnlMostrarProduto.Visible = false;
                }
            }
            else
            {

                if (pnlMostrarProduto.Visible == false)
                {
                    pnlMostrarProduto.Visible = true;
                    PesquisarProdutoVacina();
                }

            }

        }

        public void PesquisarProdutoVacina()
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLProduto bll = new BLLProduto(cx);
            DataTable dt = new DataTable();
            dt = bll.PesquisarProdutoVacinaComChave(txtPesquisarVacina.Text);

            dgvMostrarVacinasPesquisa.DataSource = dt;
            // Ajustar a altura da linha de cabeçalho
            dgvMostrarVacinasPesquisa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            //renomeando o datagridview
            dgvMostrarVacinasPesquisa.Columns["IDProduto"].HeaderText = "Código Produto";
            dgvMostrarVacinasPesquisa.Columns["NomeProduto"].HeaderText = "Nome Produto";
            dgvMostrarVacinasPesquisa.Columns["Qtd"].HeaderText = "Quantidade Disponivel";
            dgvMostrarVacinasPesquisa.Columns["ValorVenda"].HeaderText = "Custo Unitari";
            dgvMostrarVacinasPesquisa.Columns["TipoProduto"].HeaderText = "Tipo Poroduto";
            dgvMostrarVacinasPesquisa.Columns["FinalidadeProduto"].HeaderText = "Finalidade";



            // Permitir que as colunas sejam redimensionadas pelos usuários
            dgvMostrarVacinasPesquisa.AllowUserToResizeColumns = true;

            // Ajustar o tamanho das colunas automaticamente para exibir todo o conteúdo
            dgvMostrarVacinasPesquisa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // Configurar o DataGridView para quebrar as linhas
            dgvMostrarVacinasPesquisa.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // Ajustar o estilo do cabeçalho para que possa envolver o texto
            foreach (DataGridViewColumn column in dgvMostrarVacinasPesquisa.Columns)
            {
                column.HeaderCell.Style.WrapMode = DataGridViewTriState.True;
            }

            // Definir altura das linhas para acomodar o conteúdo completo
            dgvMostrarVacinasPesquisa.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);

            // Definir o tamanho das linhas do cabeçalho
            dgvMostrarVacinasPesquisa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMostrarVacinasPesquisa.ColumnHeadersHeight = 40; // Ajuste o valor conforme desejado

            // Aumentar o tamanho das outras linhas
            dgvMostrarVacinasPesquisa.RowTemplate.Height = 30; // Ajuste o valor conforme desejado para outras linhas

            // Definir cores alternadas para melhorar a visualização
            dgvMostrarVacinasPesquisa.RowsDefaultCellStyle.BackColor = Color.LightGray;
            dgvMostrarVacinasPesquisa.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
        }

        private void dgvMostrarVacinasPesquisa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvMostrarVacinasPesquisa.Rows[e.RowIndex];
                txtCodVacinaEsquema.Text = dgvMostrarVacinasPesquisa.Rows[e.RowIndex].Cells["IdProduto"].Value.ToString();
                txtCustoUnitarioVacina.Text = dgvMostrarVacinasPesquisa.Rows[e.RowIndex].Cells["ValorVenda"].Value.ToString();
                txtTipoVacina.Text = dgvMostrarVacinasPesquisa.Rows[e.RowIndex].Cells["TipoProduto"].Value.ToString();
                txtNomeVacina.Text = dgvMostrarVacinasPesquisa.Rows[e.RowIndex].Cells["NomeProduto"].Value.ToString();

                lblFinal.Text = dgvMostrarVacinasPesquisa.Rows[e.RowIndex].Cells["FinalidadeProduto"].Value.ToString();
                if (lblFinal.Text != "Comercial")
                {
                    txtcustoTotalCompra.Text = "Isento a Custo";
                    txtCustoUnitarioVacina.Text = "Inseto a Custo";
                    lblIsentoCusto.Text = "Inseto a Custo";

                    txtcustoTotalCompra.Enabled = false;
                    txtCustoUnitarioVacina.Enabled = false;
                    lblIsentoCusto.Enabled = false;



                }
                else
                {

                    txtcustoTotalCompra.Enabled = true;
                    txtCustoUnitarioVacina.Enabled = true;
                    lblIsentoCusto.Enabled = true;
                }
            }
            if (pnlMostrarProduto.Visible == true)
            {
                pnlMostrarProduto.Visible = false;
                txtPesquisarVacina.Text = "";
            }
        }

        private void txtReacoesAdversas_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvCarrinho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void limparCampos()
        {
            txtCustoUnitarioVacina.Text = "";

            txtCodVacinaEsquema.Text = "";
            txtNomeVacina.Text = "";
            txtTipoVacina.Text = "";
            txtReacoesAdversas.Text = "";
            cbmViaAdmin.SelectedIndex = -1;
            cmbLocalAdmin.SelectedIndex = -1;
            txtcustoTotalCompra.Text = "";
            txtQuantidadeAplicada.Text = "";
            txtCustoUnitarioVacina.Text = "";
        }
        public bool VerificarVacinaVencida()
        {

            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLVacina bll = new BLLVacina(cx);
            int animalID = Convert.ToInt32(txtCodAnimal.Text);
            int produtoID = Convert.ToInt32(txtCodVacinaEsquema.Text);
            return bll.VerificarVacinaVencida(animalID, produtoID);
        }

        private void btnAdicionarCarrinho_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                if (VerificarVacinaVencida())
                {
                    IncluiriVacinacao();
                }
                else
                {
                    MessageBox.Show("Desculpe, esta vacina ainda nao se encontra vencida para este animal. Por favor, consulta o cerftificado da última vaciação.", "Vacina Vencida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


        private DateTime buscarDataProximaVacinacao(int codProduto)
        {
            DateTime dataProximaVacinacao = DateTime.Today.Date.AddMonths(1);
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLVacina bll = new BLLVacina(cx);
            int intevaloDias = bll.intervaloTempo(codProduto);
            if (intevaloDias == 016)
            {
                dataProximaVacinacao = DateTime.Today.Date.AddMonths(6);
            }
            else if (intevaloDias == 1)
            {
                dataProximaVacinacao = DateTime.Today.Date.AddYears(1);

            }
            else if (intevaloDias == 2)
            {
                dataProximaVacinacao = DateTime.Today.Date.AddYears(2);
            }
            else if (intevaloDias == 3)
            {
                dataProximaVacinacao = DateTime.Today.Date.AddYears(3);
            }
            else if (intevaloDias == 4)
            {
                dataProximaVacinacao = DateTime.Today.Date.AddYears(4);
            }
            else if (intevaloDias == 5)
            {
                dataProximaVacinacao = DateTime.Today.Date.AddYears(5);
            }
            else if (intevaloDias == 6)
            {
                dataProximaVacinacao = DateTime.Today.Date.AddYears(6);
            }
            else if (intevaloDias == 7)
            {
                dataProximaVacinacao = DateTime.Today.Date.AddYears(7);
            }
            else if (intevaloDias == 8)
            {
                dataProximaVacinacao = DateTime.Today.Date.AddYears(8);
            }
            else if (intevaloDias == 9)
            {
                dataProximaVacinacao = DateTime.Today.Date.AddYears(9);
            }
            else if (intevaloDias == 10)
            {
                dataProximaVacinacao = DateTime.Today.Date.AddYears(10);
            }
            else if (intevaloDias == 100)
            {
                dataProximaVacinacao = DateTime.Today.Date.AddYears(50);
            }
            return dataProximaVacinacao;
        }
        public void IncluiriVacinacao()
        {
            try
            {
                int produtoID = Convert.ToInt32(txtCodVacinaEsquema.Text);
                // Verifica se o produto já está no carrinho
                ModeloVacina produtoExistente = listaDeDados.FirstOrDefault(p => p.IdVacina == produtoID);
                if (produtoExistente != null)
                {
                    MessageBox.Show("Não foi possível a vacina ao esquema.Por favor escolha outra vacina ou remova o a vacina existente no esquema.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //if (decimal.TryParse(txtQuantidadeAplicada.Text, out decimal qtdAplicada)) { 


                    //decimal qtdFormulario =decimal.TryParse(txtQuantidadeAplicada.Text, out decimal quantidade) && quantidade< 0)
                    //verifica se o valor que esta no txtQuantidade no formulario eh maior que zero 
                    if (decimal.TryParse(txtQuantidadeAplicada.Text, out decimal quantidade) && quantidade >= 0.1m)
                    {
                        decimal custoZero = 0;
                        decimal totalZero = 0;
                        //string vacinacaoComplet=cmbVacinaoCompleta.Text;
                        //bool resVacinacaCompleta=false;
                        //if (vacinacaoComplet=="Sim")
                        //{
                        //    resVacinacaCompleta = true;
                        //}
                        //else
                        //{
                        //    resVacinacaCompleta = false;
                        //}
                        //condicao para verficar se o produto esta isento a custo ou nao
                        if (lblFinal.Text != "Comercial")
                        {

                            ModeloVacina novoProduto = new ModeloVacina
                            {

                                AnimalID = Convert.ToInt32(txtCodAnimal.Text),
                                NomeVacina = txtNomeVacina.Text,
                                IdVacina = Convert.ToInt32(txtCodVacinaEsquema.Text),
                                tipoVacina = txtTipoVacina.Text,
                                qtdAdministrada = quantidade,
                                ReacoesAdversas = txtReacoesAdversas.Text,
                                finalidade = lblFinal.Text,
                                LocalAdministracao = cmbLocalAdmin.Text,
                                ViaAdministracao = cbmViaAdmin.Text,
                                custoUnitarioVacina = custoZero,
                                custoTotalCompra = totalZero,

                                dataProximaDataVacinacao =  buscarDataProximaVacinacao(produtoID),
                                IsentoCusto = lblIsentoCusto.Text,
                                LoteVacina = txtLotevacina.Text,
                                //VacinacaoCompleta=resVacinacaCompleta,
                                dataVacinacao = DateTime.Now,
                                NotasObservacoes = txtNotasObservacoes.Text,
                            };
                            decimal subtotal = Decimal.Parse(txtSubTotal.Text);
                            subtotal += novoProduto.custoTotalCompra;
                            txtSubTotal.Text = subtotal.ToString();
                            this.listaDeDados.Add(novoProduto);
                        }
                        //caso o produto for comercial entao nao sera isento a custo e total entao podera recerber os valores que estao no formulario

                        else
                        {
                            ModeloVacina novoProduto = new ModeloVacina
                            {
                                AnimalID = Convert.ToInt32(txtCodAnimal.Text),
                                //FuncionarioID = this.FuncionarioID,
                                NomeVacina = txtNomeVacina.Text,
                                IdVacina = Convert.ToInt32(txtCodVacinaEsquema.Text),
                                tipoVacina = txtTipoVacina.Text,
                                qtdAdministrada = quantidade,
                                ReacoesAdversas = txtReacoesAdversas.Text,
                                finalidade = lblFinal.Text,
                                LocalAdministracao = cmbLocalAdmin.Text,
                                ViaAdministracao = cbmViaAdmin.Text,
                                custoUnitarioVacina = decimal.Parse(txtCustoUnitarioVacina.Text),
                                custoTotalCompra = decimal.Parse(txtcustoTotalCompra.Text),
                                dataProximaDataVacinacao = buscarDataProximaVacinacao(produtoID),
                                IsentoCusto = lblIsentoCusto.Text,
                                LoteVacina = txtLotevacina.Text,
                                //VacinacaoCompleta = resVacinacaCompleta,
                                dataVacinacao = DateTime.Now,
                                NotasObservacoes = txtNotasObservacoes.Text,
                            };
                            decimal subtotal = Decimal.Parse(txtSubTotal.Text);
                            subtotal += novoProduto.custoTotalCompra;
                            txtSubTotal.Text = subtotal.ToString();
                            this.listaDeDados.Add(novoProduto);


                        }

                        AtualizarDataGridView();
                        if (pnlCarrinho.Visible == false)
                        {
                            pnlCarrinho.Visible = true;
                            lblVacinasSelecionadas.Visible = true;
                            limparCampos();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Quantidade Inválida!!!");
                    }
                }



            }

            catch (Exception ex)
            {

                MessageBox.Show("Não foi possivel Realizar a Operação!!! \n\nContate o Administrador do Sistema!!!\n\nErro Ocorrido:" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Stop);


            }
        }

        public void AtualizarDataGridView()
        {
            //criando uma lista temporaria contendo os atribusto para exibir no data grid view
            var dadosParaExibir = listaDeDados.Select(d => new
            {
                d.IdVacina,
                d.NomeVacina,
                d.qtdAdministrada,
                d.tipoVacina,
                d.custoUnitarioVacina,
                d.custoTotalCompra,
                d.IsentoCusto,
            }).ToList();
            dgvCarrinho.DataSource = dadosParaExibir;
            dgvCarrinho.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvCarrinho.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvCarrinho.AutoResizeRows();

            // Ajustar a altura da linha de cabeçalho
            dgvCarrinho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            // Atualiza o DataSource do DataGridView com a listaDeDados
            //dgvCarrinho.DataSource = null;  // Limpa qualquer fonte de dados existente
            dgvCarrinho.Columns["IdVacina"].HeaderText = "Código Vacina";
            dgvCarrinho.Columns["NomeVacina"].HeaderText = "Noma da Vacina";
            dgvCarrinho.Columns["tipoVacina"].HeaderText = "Tipo Vacina";
            dgvCarrinho.Columns["qtdAdministrada"].HeaderText = "Dose Administ.";
            dgvCarrinho.Columns["custoUnitarioVacina"].HeaderText = "Custo unitário";
            dgvCarrinho.Columns["custoTotalCompra"].HeaderText = "Total";
            dgvCarrinho.Columns["IsentoCusto"].HeaderText = "Custo Compra";


            // Permitir que as colunas sejam redimensionadas pelos usuários
            dgvCarrinho.AllowUserToResizeColumns = true;

            // Ajustar o tamanho das colunas automaticamente para exibir todo o conteúdo
            dgvCarrinho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // Configurar o DataGridView para quebrar as linhas
            dgvCarrinho.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // Ajustar o estilo do cabeçalho para que possa envolver o texto
            foreach (DataGridViewColumn column in dgvCarrinho.Columns)
            {
                column.HeaderCell.Style.WrapMode = DataGridViewTriState.True;
            }

            // Definir altura das linhas para acomodar o conteúdo completo
            dgvCarrinho.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);

            // Definir o tamanho das linhas do cabeçalho
            dgvCarrinho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarrinho.ColumnHeadersHeight = 40; // Ajuste o valor conforme desejado

            // Aumentar o tamanho das outras linhas
            dgvCarrinho.RowTemplate.Height = 30; // Ajuste o valor conforme desejado para outras linhas

            // Definir cores alternadas para melhorar a visualização
            dgvCarrinho.RowsDefaultCellStyle.BackColor = Color.LightGray;
            dgvCarrinho.AlternatingRowsDefaultCellStyle.BackColor = Color.White;





        }
        public bool validarCampos()
        {
            if (string.IsNullOrEmpty(txtCodAnimal.Text) || string.IsNullOrWhiteSpace(txtCodAnimal.Text))
            {
                tabControl1.SelectTab(tabPage1);
                MessageBox.Show("Informe o codigo do do Animal.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodAnimal.Focus();
                return false;
            }


            else if (string.IsNullOrEmpty(txtCodVacinaEsquema.Text) || string.IsNullOrWhiteSpace(txtCodVacinaEsquema.Text))
            {
                tabControl1.SelectTab(tabPage2);
                MessageBox.Show("Informe o código da Vacina.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodVacinaEsquema.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(txtReacoesAdversas.Text) || (string.IsNullOrWhiteSpace(txtReacoesAdversas.Text)))
            {
                tabControl1.SelectTab(tabPage2);
                MessageBox.Show("Informe as Reações Adversas da Vacina.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtReacoesAdversas.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(txtQuantidadeAplicada.Text) || (string.IsNullOrWhiteSpace(txtQuantidadeAplicada.Text)))
            {
                tabControl1.SelectTab(tabPage2);
                MessageBox.Show("Informe a quantidade de dose que será aplicada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuantidadeAplicada.Focus();
                return false;
            }
            else if (cbmViaAdmin.SelectedItem == null)
            {
                tabControl1.SelectTab(tabPage2);
                MessageBox.Show("Informe a via que foi administrada a Vacina.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbmViaAdmin.Focus();
                return false;
            }
            if (cmbLocalAdmin.Text == "")
            {
                tabControl1.SelectTab(tabPage2);
                MessageBox.Show("Informe o local onde foi administrada a Vacina.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbLocalAdmin.Focus();
                return false;
            }
            else
            {
                return true;
            }

        }
        private void txtQuantidadeAplicada_TextChanged(object sender, EventArgs e)
        {

            if (lblFinal.Text == "Comercial")
            {
                if (string.IsNullOrWhiteSpace(txtQuantidadeAplicada.Text))
                {
                    txtcustoTotalCompra.Text = "";
                }
                else
                {
                    if ((decimal.TryParse(txtCustoUnitarioVacina.Text, out decimal custoUnitario)))
                    {

                        if (decimal.TryParse(txtQuantidadeAplicada.Text, out decimal quantidadeaceite))
                        {
                            txtcustoTotalCompra.Text = ((Decimal.Parse(txtCustoUnitarioVacina.Text)) * (Decimal.Parse(txtQuantidadeAplicada.Text))).ToString();
                        }
                        else
                        {
                            // Se o texto não puder ser convertido, informa ao usuário ou toma a ação apropriada
                            MessageBox.Show("A quanitdade que desejas aplicar é inválida. Insira um valor numérico válido.");
                            // Ou pode fazer alguma outra ação, como limpar a TextBox ou definir o txtTroco.Text para vazio, etc.
                            txtQuantidadeAplicada.Text = "";
                        }
                    }
                    else
                    {
                        // Se o texto não puder ser convertido, informa ao usuário ou toma a ação apropriada
                        MessageBox.Show("O Custo da Vacina é inválida. Insira um valor válido.");
                        // Ou pode fazer alguma outra ação, como limpar a TextBox ou definir o txtTroco.Text para vazio, etc.
                        txtcustoTotalCompra.Text = "";
                    }





                }

            }
            else
            {

            }
        }

        //    private void guna2DataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        //    {

        //        if (dgvSuspensoDadosAnimal.Rows.Count > 0)
        //        {
        //            int valorCelula =Convert.ToInt32(dgvSuspensoDadosAnimal.Rows[0].Cells[0].Value.ToString());
        //            ProcurarNomeProprietarioVacina(valorCelula);
        //            codAnimalDgvMostrarDado= dgvSuspensoDadosAnimal.Rows[0].Cells[0].Value.ToString();
        //        }
        //}

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {

                if (dgvCarrinho.Rows.Count == 0)
                {
                    throw new InvalidOperationException("Adicione Vacinas ao carrinho antes de confirmar a compra.");
                }
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLVacina bll = new BLLVacina(cx);
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
                }
                //inserir os dados
                bll.incluirVacinacao(listaDeDados);

                MessageBox.Show("Compra realizada com sucesso!", "Confirmação", MessageBoxButtons.OK);
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

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void btnMostrarDetalhes_Click(object sender, EventArgs e)
        {
            if (pnlMostrarDetalhesPagamento.Visible == false)
            {
                pnlMostrarDetalhesPagamento.Visible = true;
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            pnlMostrarDetalhesPagamento.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnGravar_Click_1(object sender, EventArgs e)
        {
            var modelo = new ModeloVacina();
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLVacina bll = new BLLVacina(cx);
            try
            {
                if (dgvCarrinho.Rows.Count == 0)
                {
                    throw new Exception("Adicione produtos ao carrinho antes de confirmar a Venda.!!!");
                }

                if (listaDeDados.Count == 0)
                {
                    throw new Exception("Adicione produtos ao carrinho antes de confirmar a Venda.!!!");
                }

                // Calcular o totalGeral para toda a venda
                decimal totalGeral = decimal.Parse(txtSubTotal.Text) + decimal.Parse(txtImposto.Text);
                foreach (var item in listaDeDados)
                {
                    item.totalGeral = totalGeral;
                    item.UsuarioID = m.UsuarioID;
                    item.imposto = decimal.Parse(txtImposto.Text);
                    item.desconto = decimal.Parse(txtDesconto.Text);
                    item.troco = decimal.Parse(txtTroco.Text);
                    item.formaPagamento = cmbFormaPagamento.Text;
                    item.valorEntregue = decimal.Parse(txtValorEntregue.Text);
                }

                if (string.IsNullOrWhiteSpace(cmbFormaPagamento.Text))
                {
                    throw new Exception("Escolha o método de pagamento utilizado.");
                }

                // Inserir os dados
                bll.incluirVacinacao(listaDeDados);
                //int vendaID = bll.incluirVacinacao(listaDeDados);

                // Atualizar o vendaID no último item da listaDeDados
                //listaDeDados.Last().vendaID = vendaID;

                MessageBox.Show(modelo.RegistroVacinacaoID.ToString() + "\n \n Venda realizada com Sucesso!", "Confirmação", MessageBoxButtons.OK);

                //frmFaturaVenda frm = new frmFaturaVenda(vendaID);
                //frm.ShowDialog();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possível Realizar a Operação!!! \n\nContate o Administrador do Sistema!!!\n\nErro Ocorrido:" + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }


        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {

        }

        private void txtValorEntregue_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtValorEntregue.Text) || !string.IsNullOrWhiteSpace(txtValorEntregue.Text))
            {
                if (decimal.TryParse(txtValorEntregue.Text, out decimal valorEntregue) &&
                    (decimal.TryParse(txtTotalGeral.Text, out decimal totalGeral)))
                {
                    valorEntregue = Convert.ToDecimal(txtValorEntregue.Text);
                    totalGeral = Convert.ToDecimal(txtTotalGeral.Text);
                    decimal troco = valorEntregue - totalGeral;
                    txtTroco.Text = troco.ToString();
                }

            }
        }

        private void txtImposto_TextChanged(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(txtImposto.Text) || string.IsNullOrWhiteSpace(txtImposto.Text) ||
                string.IsNullOrEmpty(txtDesconto.Text) || string.IsNullOrWhiteSpace(txtDesconto.Text)))
            {
                if (decimal.TryParse(txtImposto.Text, out decimal imposto) && decimal.TryParse(txtDesconto.Text, out decimal desconto))
                {
                    txtTotalGeral.Text = " ";
                    decimal subtotal = decimal.Parse(txtSubTotal.Text);
                    imposto = decimal.Parse(txtImposto.Text);
                    desconto = decimal.Parse(txtDesconto.Text);

                    decimal totalGeral = (subtotal + (subtotal * imposto / 100)) - (subtotal * desconto / 100);

                    txtTotalGeral.Text = totalGeral.ToString();

                }
            }
        }

        private void txtDesconto_TextChanged(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(txtImposto.Text) || string.IsNullOrWhiteSpace(txtImposto.Text) ||
                string.IsNullOrEmpty(txtDesconto.Text) || string.IsNullOrWhiteSpace(txtDesconto.Text)))
            {
                if (decimal.TryParse(txtImposto.Text, out decimal imposto) && decimal.TryParse(txtDesconto.Text, out decimal desconto))
                {
                    txtTotalGeral.Text = " ";
                    decimal subtotal = decimal.Parse(txtSubTotal.Text);
                    imposto = decimal.Parse(txtImposto.Text);
                    desconto = decimal.Parse(txtDesconto.Text);

                    decimal totalGeral = (subtotal + (subtotal * imposto / 100)) - (subtotal * desconto / 100);

                    txtTotalGeral.Text = totalGeral.ToString();

                }
            }

        }

        private void txtSubTotal_TextChanged(object sender, EventArgs e)
        {
            {
                if (!(string.IsNullOrEmpty(txtImposto.Text) || string.IsNullOrWhiteSpace(txtImposto.Text) ||
                    string.IsNullOrEmpty(txtDesconto.Text) || string.IsNullOrWhiteSpace(txtDesconto.Text)))
                {
                    if (decimal.TryParse(txtImposto.Text, out decimal imposto) && decimal.TryParse(txtDesconto.Text, out decimal desconto))
                    {
                        txtTotalGeral.Text = " ";
                        decimal subtotal = decimal.Parse(txtSubTotal.Text);
                        imposto = decimal.Parse(txtImposto.Text);
                        desconto = decimal.Parse(txtDesconto.Text);

                        decimal totalGeral = (subtotal + (subtotal * imposto / 100)) - (subtotal * desconto / 100);

                        txtTotalGeral.Text = totalGeral.ToString();

                    }
                }

            }
        }
    }
}


