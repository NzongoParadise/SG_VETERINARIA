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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SG_VTNR
{
    public partial class frmPesagem : Form
    {
         private int FuncionarioID;
      
        private string proprietarioAnimal;


        public frmPesagem()
        {
            InitializeComponent();
           var m = new ModeloPesagem();
            m.usuarioID = SessaoUsuario.Session.Instance.UsuID;
            SessaoUsuario sessao = new SessaoUsuario();
            

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
            dgvMostrarAnimal.RowsDefaultCellStyle.BackColor = Color.LightGray;
            dgvMostrarAnimal.AlternatingRowsDefaultCellStyle.BackColor = Color.White;



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
            dgvMostrarFuncionario.DataSource = bll.PesquisarFuncionariosComChavePesagem(txtPesquisarFuncionario.Text);
            // Renomear os cabeçalhos das colunas diretamente no DataGridView
            dgvMostrarFuncionario.Columns["Código Funcionário"].HeaderText = "Código";

            // Permitir que as colunas sejam redimensionadas pelos usuários
            dgvMostrarFuncionario.AllowUserToResizeColumns = true;

            // Ajustar o tamanho das colunas automaticamente para exibir todo o conteúdo
            dgvMostrarFuncionario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // Configurar o DataGridView para quebrar as linhas
            dgvMostrarFuncionario.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // Ajustar o estilo do cabeçalho para que possa envolver o texto
            foreach (DataGridViewColumn column in dgvMostrarFuncionario.Columns)
            {
                column.HeaderCell.Style.WrapMode = DataGridViewTriState.True;
            }

            // Definir altura das linhas para acomodar o conteúdo completo
            dgvMostrarFuncionario.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);

            // Definir o tamanho das linhas do cabeçalho
            dgvMostrarFuncionario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMostrarFuncionario.ColumnHeadersHeight = 40; // Ajuste o valor conforme desejado

            // Aumentar o tamanho das outras linhas
            dgvMostrarFuncionario.RowTemplate.Height = 30; // Ajuste o valor conforme desejado para outras linhas

            // Adicionar diferença visual na cor das linhas
            dgvMostrarFuncionario.RowsDefaultCellStyle.BackColor = Color.LightGray;
            dgvMostrarFuncionario.AlternatingRowsDefaultCellStyle.BackColor = Color.White;


        }

        private void txtPesquisaFuncionario_TextChanged(object sender, EventArgs e)

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

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

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
                txtCodigo.Text = animalID.ToString();
                txtPesquisarRegistroPeso.Text = animalID;

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
                dgvMostrarDadosAnimal.DataSource = null;

                // Vincule o DataTable ao DataGridView
                dgvMostrarDadosAnimal.DataSource = dt;
                string prop = this.proprietarioAnimal;
                novaLinha["proprietario"] = prop;
                dgvMostrarDadosAnimal.DataSource = dt;
               
                // Configurar o DataGridView para quebrar as linhas
                dgvMostrarDadosAnimal.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dgvMostrarDadosAnimal.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dgvMostrarDadosAnimal.AutoResizeRows();

                // Ajustar a altura da linha de cabeçalho
                dgvMostrarDadosAnimal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

                // Esconda o painel se estiver visível
                if (pnlMostrarAnimal.Visible == true)
                {
                    pnlMostrarAnimal.Visible = false;
                }
                if (dgvMostrarDadosAnimal.Visible == false)
                {
                    dgvMostrarDadosAnimal.Visible = true;
                }
                RenomearCabecalhos();

            }
        }
        private void RenomearCabecalhos()
        {
            // Renomear os cabeçalhos das colunas diretamente no DataGridView
            dgvMostrarDadosAnimal.Columns["Especie"].HeaderText = "Espécie";
            dgvMostrarDadosAnimal.Columns["Nome"].HeaderText = "Nome";
            dgvMostrarDadosAnimal.Columns["Estado"].HeaderText = "Estado";
            dgvMostrarDadosAnimal.Columns["Raca"].HeaderText = "Raça";
            dgvMostrarDadosAnimal.Columns["Porte"].HeaderText = "Porte";
            dgvMostrarDadosAnimal.Columns["Sexo"].HeaderText = "Sexo";
            dgvMostrarDadosAnimal.Columns["Peso"].HeaderText = "Peso";
            dgvMostrarDadosAnimal.Columns["AnimalID"].HeaderText = "Código";
            dgvMostrarDadosAnimal.Columns["Idade"].HeaderText = "Idade";
            dgvMostrarDadosAnimal.Columns["proprietario"].HeaderText = "Proprietario";
        }

        private void dgvMostrarFuncionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvMostrarFuncionario.Rows[e.RowIndex];

                this.FuncionarioID = Convert.ToInt32(dgvMostrarFuncionario.Rows[e.RowIndex].Cells["Código Funcionário"].Value.ToString());
                string nome = dgvMostrarFuncionario.Rows[e.RowIndex].Cells["Nome Completo"].Value.ToString();
                //this.FuncionarioID = Convert.ToInt32(dgvMostrarFuncionario.Rows[e.RowIndex].Cells["FuncionarioID"].Value.ToString());
                txtDadosFuncionario.Text = nome;
                if (pnlMostrarFuncionario.Visible == true)
                {
                    pnlMostrarFuncionario.Visible = false;
                }

            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
            var modelo= new ModeloPesagem();
            modelo.AnimalID = Convert.ToInt16(txtCodigo.Text);
          
            modelo.obs=txtObs.Text;
            modelo.peso =Convert.ToDecimal(txtPeso.Text);
            modelo.FuncionarioID = this.FuncionarioID;

            modelo.usuarioID = SessaoUsuario.Session.Instance.UsuID;
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLPesagem bll = new BLLPesagem(cx);
            bll.IncluirPesagem(modelo);

            MessageBox.Show("Registro de Pesagem realizada com  sucesso!", "Confirmação", MessageBoxButtons.OK);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show($"Erro ao confirmar o registro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao confirmar o registro de pesagem. Contate o Administrador do Sistema.\n\nDetalhes do Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void txtPesquisarRegistroPeso_TextChanged(object sender, EventArgs e)
        {
            
            pesquisarHistoricoPesagem();

        }
        public void pesquisarHistoricoPesagem()
        {
            pesquisarHistoricoPesagemNomesIdade(txtPesquisarRegistroPeso.Text);
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLPesagem bll = new BLLPesagem(cx);
            dgvExibirHistoricoPesagem.DataSource = bll.PesquisarPesoComChave(txtPesquisarRegistroPeso.Text);
            
            lblNumerodevezes.Text =((dgvExibirHistoricoPesagem.RowCount)-1).ToString();
            // Ajustar o tamanho das colunas automaticamente para exibir todo o conteúdo
            dgvExibirHistoricoPesagem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // Permitir que as colunas sejam redimensionadas pelos usuários
            dgvExibirHistoricoPesagem.AllowUserToResizeColumns = true;

            // Configurar o DataGridView para quebrar as linhas
            dgvExibirHistoricoPesagem.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // Ajustar o estilo do cabeçalho para que possa envolver o texto
            foreach (DataGridViewColumn column in dgvExibirHistoricoPesagem.Columns)
            {
                column.HeaderCell.Style.WrapMode = DataGridViewTriState.True;
            }

            // Definir altura das linhas para acomodar o conteúdo completo
            dgvExibirHistoricoPesagem.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);

            // Definir o tamanho das linhas do cabeçalho
            dgvExibirHistoricoPesagem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExibirHistoricoPesagem.ColumnHeadersHeight = 40; // Ajuste o valor conforme desejado

            // Aumentar o tamanho das outras linhas
            dgvExibirHistoricoPesagem.RowTemplate.Height = 30; // Ajuste o valor conforme desejado para outras linhas

            // Adicionar diferença visual na cor das linhas
            dgvExibirHistoricoPesagem.RowsDefaultCellStyle.BackColor = Color.LightGray;
            dgvExibirHistoricoPesagem.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
        }
        public void pesquisarHistoricoPesagemNomesIdade(string nome)
        {
         
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLPesagem bll = new BLLPesagem(cx);
          
            DataTable dt = bll.PesquisarPesoComChaveNomesIdade(nome);

            if (dt.Rows.Count > 0)
            {
                // Supondo que você tenha labels lblNomeAnimal, lblProprietarioAnimal e lblDataNascimento
                lblNomeAnimal.Text = dt.Rows[0]["Nome do Animal"].ToString();
                lblProprietario.Text = dt.Rows[0]["Proprietário do Animal"].ToString();
                DateTime dataNacimento =Convert.ToDateTime(dt.Rows[0]["Data Nascimento"]);

                TimeSpan diferenca = DateTime.Now - dataNacimento;
                int idadeEmAnos = (int)(diferenca.TotalDays / 365.25);
                int idadeEmMeses = (int)((diferenca.TotalDays % 365.25) / 30.44); // Aproximadamente 30.44 dias em um mês

                lblIdade.Text = idadeEmAnos == 0 ? $"{idadeEmMeses} Meses" : $"{idadeEmAnos} Ano(s)";


            }
            else
            {
                // Limpar os labels se nenhum resultado for encontrado
                lblNomeAnimal.Text = "";
                lblProprietario.Text = "";
                lblIdade.Text = "";
            }
        }


        private void dgvExibirHistoricoPesagem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pnlMostrarFuncionario_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

      
        }
    }


