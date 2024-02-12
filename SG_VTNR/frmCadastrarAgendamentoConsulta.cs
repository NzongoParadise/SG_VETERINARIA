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
    public partial class frmCadastrarAgendamentoConsulta : Form
    {
        private int FuncionarioID;
        public frmCadastrarAgendamentoConsulta()
        {
            InitializeComponent();
            var m = new ModeloCadastrarAgendamento();
            m.UsuarioID = SessaoUsuario.Session.Instance.UsuID;
            SessaoUsuario sessao = new SessaoUsuario();


            txtPesquisarAnimal.Enabled = false;
            txtPesquisarFuncionario.Enabled = false;
            cmbGravidade.Enabled = false;
            dtDataAgendada.Enabled = false;
            cbmStatus.Enabled = false;
            cbmTipoAgendamento.Enabled = false;

        }

        private void guna2Button13_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCadastrarAgendamentoConsulta_Load(object sender, EventArgs e)
        {
            dtDataAgendada.Text = UserControlDays.static_day + "/" + frmMarcacaoConsulta.static_month + "/" + frmMarcacaoConsulta.static_year;
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
           
            //dgvMostrarAnimal.Columns["Especie"].HeaderText = "Espécie";

            dgvMostrarFuncionario.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvMostrarFuncionario.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvMostrarFuncionario.AutoResizeRows();

            // Ajustar a altura da linha de cabeçalho
            dgvMostrarFuncionario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;



        }

        private void txtPesquisarFuncionariob_TextChanged(object sender, EventArgs e)
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
                //txtCodigo.Text = animalID.ToString();
                //txtPesquisarRegistroPeso.Text = animalID;

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
                //string prop = this.proprietarioAnimal;
                //novaLinha["proprietario"] = prop;
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

                this.FuncionarioID = Convert.ToInt32(dgvMostrarFuncionario.Rows[e.RowIndex].Cells["FuncionarioID"].Value.ToString());
                string nome = dgvMostrarFuncionario.Rows[e.RowIndex].Cells["Nome Completo"].Value.ToString();
                //this.FuncionarioID = Convert.ToInt32(dgvMostrarFuncionario.Rows[e.RowIndex].Cells["FuncionarioID"].Value.ToString());
                txtDadosFuncionario.Text = " Codigo:    "+ FuncionarioID+   "          Nome: " + nome;
                if (pnlMostrarFuncionario.Visible == true)
                {
                    pnlMostrarFuncionario.Visible = false;
                }

            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            alteraBotoes(2, perInserir, perAlterar, perExcluir, perImprimir);
          
        }
        Boolean perInserir = false; Boolean perAlterar = false; Boolean perExcluir = false; Boolean perImprimir = false;
        public void alteraBotoes(int op, Boolean perInserir, Boolean perAlterar, Boolean perExcluir, Boolean perImprimir)
        {
            btnGuardar.Enabled = false;
            btnEditar.Enabled = false;
            btnCancelar.Enabled = false;

            if (op == 1)
            {
                btnGuardar.Enabled = perInserir;
                btnEditar.Enabled = false;
                btnCancelar.Enabled = false;
                btnNovo.Enabled = true;

                txtPesquisarAnimal.Enabled = false;
                txtPesquisarFuncionario.Enabled = false;
                cmbGravidade.Enabled = false;
                dtDataAgendada.Enabled = false;
                cbmStatus.Enabled = false;
                cbmTipoAgendamento.Enabled = false;
            }

            if (op == 2)
            {
                btnEditar.Enabled = false;
                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
                

                txtPesquisarAnimal.Enabled = true;
                txtPesquisarFuncionario.Enabled = true;
                cmbGravidade.Enabled = true;
                dtDataAgendada.Enabled = true;
                cbmStatus.Enabled = true;
                cbmTipoAgendamento.Enabled = true;
            }
            if (op == 3)
            {
                //btnEditar.Enabled = perAlterar;
                btnEditar.Enabled = true;
                btnCancelar.Enabled = true;
                btnNovo.Enabled = true;
                txtPesquisarAnimal.Enabled = true;
                txtPesquisarFuncionario.Enabled = true;
                cmbGravidade.Enabled = true;
                dtDataAgendada.Enabled = true;
                cbmStatus.Enabled = true;
                cbmTipoAgendamento.Enabled = true;
            }

        }
}
}
