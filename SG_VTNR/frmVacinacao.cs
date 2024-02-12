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
        ModeloVacina m;
        private List<ModeloVacina> listaDeDados = new List<ModeloVacina>();
        private string proprietarioAnimal;
        private string codAnimalDgvMostrarDado;
       
        public frmVacinacao()
        {
            InitializeComponent();
            m = new ModeloVacina();
            m.UsuarioID = SessaoUsuario.Session.Instance.UsuID;


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


        public void PesquisarAnimalcomChave()
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLAnimal bll = new BLLAnimal(cx);
            dgvMostrarAnimal.DataSource = bll.PesquisarAnimalcomChaveVacina(txtPesquisarAnimal.Text);

            // Renomear os cabeçalhos das colunas diretamente no DataGridView
            dgvMostrarAnimal.Columns["AnimalID"].HeaderText = "Código";
            dgvMostrarAnimal.Columns["Nome"].HeaderText = "Nome";
            dgvMostrarAnimal.Columns["Especie"].HeaderText = "Espécie";

            dgvMostrarAnimal.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvMostrarAnimal.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvMostrarAnimal.AutoResizeRows();

            // Ajustar a altura da linha de cabeçalho
            dgvMostrarAnimal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;


        }
        private void txtPesquisarAnimal_TextChanged(object sender, EventArgs e)
        {
            txtPesquisarFuncionario.Text = "";
            if (string.IsNullOrWhiteSpace(txtPesquisarAnimal.Text) || string.IsNullOrEmpty(txtPesquisarAnimal.Text))
            {
                if (pnlMostrarAnimal.Visible == true)
                {
                    pnlMostrarAnimal.Visible = false;
                }

            }
            else
            {
                if (pnlMostrarAnimal.Visible == false)
                {
                    pnlMostrarAnimal.Visible = true;
                    PesquisarAnimalcomChave();
                }



            }


        }


        public void PesquisarFuncionariocomChave()
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLFuncionario bll = new BLLFuncionario(cx);
            dgvMostrarFuncionario.DataSource = bll.PesquisarFuncionariosComChaveVacina(txtPesquisarFuncionario.Text);
            // Renomear os cabeçalhos das colunas diretamente no DataGridView
            dgvMostrarFuncionario.Columns["FuncionarioID"].HeaderText = "Código";
            dgvMostrarFuncionario.Columns["Nome"].HeaderText = "Nome";
            //dgvMostrarAnimal.Columns["Especie"].HeaderText = "Espécie";

            dgvMostrarFuncionario.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvMostrarFuncionario.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvMostrarFuncionario.AutoResizeRows();

            // Ajustar a altura da linha de cabeçalho
            dgvMostrarFuncionario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;



        }

        private void btnfechararevacinacao_Click(object sender, EventArgs e)
        {

            DialogResult dialogo = MessageBox.Show("Desejas guardar as alterações do foruário?", "Aviso", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (dialogo.ToString() == "Yes")
            {
                tabControl1.SelectTab(tabPage3);
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
            if (dgvSuspensoDadosAnimal.Visible==true)
            {
                dgvSuspensoDadosAnimal.Visible = false;
            }
            if (pnlMostrarFuncionario.Visible == true)
            {
                pnlMostrarFuncionario.Visible = false;
            }
            if (pnlMostrarAnimal.Visible == true)
            {
                pnlMostrarAnimal.Visible = false;
            }
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






        private void txtPesquisarFuncionario_TextChanged(object sender, EventArgs e)
        {
            txtPesquisarAnimal.Text = "";
            if (string.IsNullOrWhiteSpace(txtPesquisarFuncionario.Text) || string.IsNullOrEmpty(txtPesquisarFuncionario.Text))
            {
                if (pnlMostrarFuncionario.Visible == true)
                {
                    pnlMostrarFuncionario.Visible = false;
                }

            }
            else
            {
                if (pnlMostrarFuncionario.Visible == false)
                {
                    pnlMostrarFuncionario.Visible = true;
                    PesquisarFuncionariocomChave();
                }

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

                // Obtenha os valores das células do DataGridView
                string especie = dgvMostrarAnimal.Rows[e.RowIndex].Cells["Especie"].Value.ToString();
                string nome = dgvMostrarAnimal.Rows[e.RowIndex].Cells["Nome"].Value.ToString();
                string estado = dgvMostrarAnimal.Rows[e.RowIndex].Cells["Estado"].Value.ToString();
                string raca = dgvMostrarAnimal.Rows[e.RowIndex].Cells["Raca"].Value.ToString();
                string porte = dgvMostrarAnimal.Rows[e.RowIndex].Cells["Porte"].Value.ToString();
                string sexo = dgvMostrarAnimal.Rows[e.RowIndex].Cells["Sexo"].Value.ToString();
                string peso = dgvMostrarAnimal.Rows[e.RowIndex].Cells["Peso"].Value.ToString();
                string animalID = dgvMostrarAnimal.Rows[e.RowIndex].Cells["AnimalID"].Value.ToString();
 
                
                DateTime nascimento = Convert.ToDateTime(dgvMostrarAnimal.Rows[e.RowIndex].Cells["DataNascimento"].Value.ToString());
                TimeSpan diferenca = DateTime.Now - nascimento;
                int idadeEmAnos = (int)(diferenca.TotalDays / 365.25);
                int idadeEmMeses = (int)((diferenca.TotalDays % 365.25) / 30.44); // Aproximadamente 30.44 dias em um mês

                // Crie um DataTable com as colunas desejadas
                DataTable dt = new DataTable();
                dt.Columns.Add("AnimalID");
                dt.Columns.Add("Nome");
                dt.Columns.Add("Especie");
                dt.Columns.Add("Estado");
                dt.Columns.Add("Raca");
                dt.Columns.Add("Porte");
                dt.Columns.Add("Sexo");
                dt.Columns.Add("Peso");
                dt.Columns.Add("Idade");
                dt.Columns.Add("proprietario");

                // Adicione uma nova linha ao DataTable
                DataRow novaLinha = dt.NewRow();
                novaLinha["AnimalID"] = animalID;
                novaLinha["Nome"] = nome;
                novaLinha["Especie"] = especie;
                novaLinha["Estado"] = estado;
                novaLinha["Raca"] = raca;
                novaLinha["Porte"] = porte;
                novaLinha["Sexo"] = sexo;
                novaLinha["Peso"] = peso;
                
                novaLinha["Idade"] = idadeEmAnos == 0 ? $"{idadeEmMeses} Meses" : $"{idadeEmAnos} Ano(s)";
               

                dt.Rows.Add(novaLinha);

                // Limpando qualquer fonte de dados existente no DataGridView
                dgvSuspensoDadosAnimal.DataSource = null;

                // Vincule o DataTable ao DataGridView
                dgvSuspensoDadosAnimal.DataSource = dt;
                string prop = this.proprietarioAnimal;
                novaLinha["proprietario"] = prop;
                dgvSuspensoDadosAnimal.DataSource = dt;
                m.UsuarioID = SessaoUsuario.Session.Instance.UsuID;

                // Configurar o DataGridView para quebrar as linhas
                dgvSuspensoDadosAnimal.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dgvSuspensoDadosAnimal.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dgvSuspensoDadosAnimal.AutoResizeRows();

                // Ajustar a altura da linha de cabeçalho
                dgvSuspensoDadosAnimal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

                // Esconda o painel se estiver visível
                if (pnlMostrarAnimal.Visible == true)
                {
                    pnlMostrarAnimal.Visible = false;
                }
                if (dgvSuspensoDadosAnimal.Visible == false)
                {
                    dgvSuspensoDadosAnimal.Visible = true;
                }
                RenomearCabecalhos();

            }
        }
        private void RenomearCabecalhos()
        {
            // Renomear os cabeçalhos das colunas diretamente no DataGridView
            dgvSuspensoDadosAnimal.Columns["Especie"].HeaderText = "Espécie";
            dgvSuspensoDadosAnimal.Columns["Nome"].HeaderText = "Nome";
            dgvSuspensoDadosAnimal.Columns["Estado"].HeaderText = "Estado";
            dgvSuspensoDadosAnimal.Columns["Raca"].HeaderText = "Raça";
            dgvSuspensoDadosAnimal.Columns["Porte"].HeaderText = "Porte";
            dgvSuspensoDadosAnimal.Columns["Sexo"].HeaderText = "Sexo";
            dgvSuspensoDadosAnimal.Columns["Peso"].HeaderText = "Peso";
            dgvSuspensoDadosAnimal.Columns["AnimalID"].HeaderText = "Código";
            dgvSuspensoDadosAnimal.Columns["Idade"].HeaderText = "Idade";
            dgvSuspensoDadosAnimal.Columns["proprietario"].HeaderText = "Proprietario";
        }
        
        private void dgvMostrarDadosFuncionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvMostrarFuncionario.Rows[e.RowIndex];

                this.FuncionarioID = Convert.ToInt32(dgvMostrarFuncionario.Rows[e.RowIndex].Cells["FuncionarioID"].Value.ToString());
                string nome = dgvMostrarFuncionario.Rows[e.RowIndex].Cells["Nome"].Value.ToString();
                string sobreNome = dgvMostrarFuncionario.Rows[e.RowIndex].Cells["Sobrenome"].Value.ToString();
                string apelido = dgvMostrarFuncionario.Rows[e.RowIndex].Cells["Apelido"].Value.ToString();
                txtFuncionarioID.Text = FuncionarioID.ToString();               
                txtResPesqFuncionario.Text = nome + " " + sobreNome + " " + apelido;
                if (pnlMostrarFuncionario.Visible==true)
                {
                    pnlMostrarFuncionario.Visible = false;
                }

            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        //este metodo com base o evento textchange do codigo do animal.ele vai produrarna na tabela proprietario
        //em funcao do id do proprietario que esta na tabela animal o nome do proprietario
        public void ProcurarNomeProprietarioVacina(int cod)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLAnimal bll = new BLLAnimal(cx);
            proprietarioAnimal = bll.PesquisarNomeProprietarioVacinaComCodigo(Convert.ToInt32(cod));
            
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

            dgvMostrarVacinasPesquisa.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvMostrarVacinasPesquisa.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvMostrarVacinasPesquisa.AutoResizeRows();

            // Ajustar a altura da linha de cabeçalho
            dgvMostrarVacinasPesquisa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
           //renomeando o datagridview
            dgvMostrarVacinasPesquisa.Columns["IDProduto"].HeaderText = "Código Produto";
            dgvMostrarVacinasPesquisa.Columns["NomeProduto"].HeaderText = "Nome Produto";
            dgvMostrarVacinasPesquisa.Columns["Qtd"].HeaderText = "Quantidade Disponivel";
            dgvMostrarVacinasPesquisa.Columns["ValorVenda"].HeaderText = "Custo Unitari";
            dgvMostrarVacinasPesquisa.Columns["TipoProduto"].HeaderText = "Tipo Poroduto";
            dgvMostrarVacinasPesquisa.Columns["FinalidadeProduto"].HeaderText = "Finalidade";
      
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

                lblFinal.Text= dgvMostrarVacinasPesquisa.Rows[e.RowIndex].Cells["FinalidadeProduto"].Value.ToString();
                if (lblFinal.Text!="Comercial")
                {
                    txtcustoTotalCompra.Text = "Isento a Custo";
                    txtCustoUnitarioVacina.Text = "Inseto a Custo";
                    lblIsentoCusto.Text = "Inseto a Custo";

                    txtcustoTotalCompra.Enabled=false;
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
        private void btnAdicionarCarrinho_Click(object sender, EventArgs e)
        {
            IncluiriVacinacao();

        }


        public void IncluiriVacinacao()
        {
            try
            {
                if (validarCampos())
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
                            string vacinacaoComplet=cmbVacinaoCompleta.Text;
                            bool resVacinacaCompleta=false;
                            if (vacinacaoComplet=="Sim")
                            {
                                resVacinacaCompleta = true;
                            }
                            else
                            {
                                resVacinacaCompleta = false;
                            }
                            //condicao para verficar se o produto esta isento a custo ou nao
                            if (lblFinal.Text != "Comercial")
                            {

                                ModeloVacina novoProduto = new ModeloVacina
                                {
                                    FuncionarioID =Convert.ToInt32(txtFuncionarioID.Text),
                                    AnimalID = Convert.ToInt32(codAnimalDgvMostrarDado),
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
                                    dataProximaDataVacinacao = dataProximaVacinacao.Value,
                                    IsentoCusto = lblIsentoCusto.Text,
                                    LoteVacina=txtLotevacina.Text,  
                                    VacinacaoCompleta=resVacinacaCompleta,
                                    dataVacinacao = DateTime.Now,
                                    dataValidadeVacina = DataValidade.Value,
                                    NotasObservacoes=txtNotasObservacoes.Text,
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
                                    AnimalID = Convert.ToInt32(codAnimalDgvMostrarDado),
                                    //FuncionarioID = this.FuncionarioID,
                                    FuncionarioID = Convert.ToInt32(txtFuncionarioID.Text),
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
                                    dataProximaDataVacinacao = dataProximaVacinacao.Value,
                                    IsentoCusto = lblIsentoCusto.Text,
                                    LoteVacina = txtLotevacina.Text,
                                    VacinacaoCompleta = resVacinacaCompleta,
                                    dataVacinacao = DateTime.Now,
                                    dataValidadeVacina = DataValidade.Value,
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

           
          
        }
        public bool validarCampos()
        {
            if (string.IsNullOrEmpty(codAnimalDgvMostrarDado) || string.IsNullOrWhiteSpace(codAnimalDgvMostrarDado))
            {
                tabControl1.SelectTab(tabPage1);
                MessageBox.Show("Informe o codigo do do Animal.");
                txtPesquisarAnimal.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(txtResPesqFuncionario.Text) || string.IsNullOrWhiteSpace(txtResPesqFuncionario.Text))
            {
                tabControl1.SelectTab(tabPage1);
                MessageBox.Show("Informe o nome do Funcionário qua vai vacinar o animal.");
                txtPesquisarFuncionario.Focus();
                return false;
            }

            else if (string.IsNullOrEmpty(txtCodVacinaEsquema.Text) || string.IsNullOrWhiteSpace(txtCodVacinaEsquema.Text))
            {
                tabControl1.SelectTab(tabPage2);
                MessageBox.Show("Informe o código da Vacina.");
                txtCodVacinaEsquema.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(txtReacoesAdversas.Text) || (string.IsNullOrWhiteSpace(txtReacoesAdversas.Text)))
            {
                tabControl1.SelectTab(tabPage2);
                MessageBox.Show("Informe as Reações Adversas da Vacina.");
                txtReacoesAdversas.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(txtQuantidadeAplicada.Text) || (string.IsNullOrWhiteSpace(txtQuantidadeAplicada.Text)))
            {
                tabControl1.SelectTab(tabPage2);
                MessageBox.Show("Informe a quantidade de dose que será aplicada.");
                txtQuantidadeAplicada.Focus();
                return false;
            }
            else if (cbmViaAdmin.SelectedItem == null)
            {
                tabControl1.SelectTab(tabPage2);
                MessageBox.Show("Informe a via que foi administrada a Vacina.");
                cbmViaAdmin.Focus();
                return false;
            }
            if (cmbLocalAdmin.Text == "")
            {
                tabControl1.SelectTab(tabPage2);
                MessageBox.Show("Informe o local onde foi administrada a Vacina.");
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

        private void guna2DataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

            if (dgvSuspensoDadosAnimal.Rows.Count > 0)
            {
                int valorCelula =Convert.ToInt32(dgvSuspensoDadosAnimal.Rows[0].Cells[0].Value.ToString());
                ProcurarNomeProprietarioVacina(valorCelula);
                codAnimalDgvMostrarDado= dgvSuspensoDadosAnimal.Rows[0].Cells[0].Value.ToString();
            }
        


    }

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

        
    }
}


   