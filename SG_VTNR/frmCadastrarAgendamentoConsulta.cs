using BLL;
using DAL;
using Ferramenta;
using Guna.UI2.WinForms.Suite;
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
        // variaveis criadas para auxiliar no uso de todo o codigo---> na area de verificacao de data,
        // hora inicial e hora final  e se a consulta vai durar quanto tempo
        DateTime horaInicial;
        DateTime horaFinal;

        public int FuncionarioID;
        private int ProprietarioID;
        public int animalID;
        //esta linha permite com que se faca perceber se o clique esta a vir do datagrid ou entao do calendario marcar consulta
       public string vindoDe;
        public frmCadastrarAgendamentoConsulta()
        {
            InitializeComponent();

            txtDadosFuncionario.Enabled = false;
            txtObservacao.Enabled = false;
            inicialMaskedTextBox1.Enabled = false;
            inicialNumericUpDownHours.Enabled = false;
            inicialNumericUpDownMinutes.Enabled = false;

            finallNumericUpDownHours.Enabled = false;
            finalNumericUpDownMinutes.Enabled = false;
            finalMaskedTextBox1.Enabled = false;
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
            if (!string.IsNullOrEmpty(UserControlDays.static_day) &&
                !string.IsNullOrEmpty(frmMarcacaoConsulta.static_month.ToString()) &&
                !string.IsNullOrEmpty(frmMarcacaoConsulta.static_year.ToString()))
            {
                dtDataAgendada.Text = UserControlDays.static_day + "/" + frmMarcacaoConsulta.static_month + "/" + frmMarcacaoConsulta.static_year;
            }
            //// Configurar os valores mínimos e máximos para as horas e minutos
            //inicialNumericUpDownHours.Minimum = 0;
            //inicialNumericUpDownHours.Maximum = 24;
            //inicialNumericUpDownMinutes.Minimum = 0;
            //inicialNumericUpDownMinutes.Maximum = 59;

            //// Definir os valores iniciais para as horas e minutos
            //DateTime currentTime = DateTime.Now;
            //inicialNumericUpDownHours.Value = currentTime.Hour;
            //inicialNumericUpDownMinutes.Value = currentTime.Minute;
            //UpdateMaskedTextBoxTextInicial();

            ////--------------
            //// Configurar os valores mínimos e máximos para as horas e minutos final
            //finallNumericUpDownHours.Minimum = 0;
            //finallNumericUpDownHours.Maximum = 24;
            //finalNumericUpDownMinutes.Minimum = 0;
            //finalNumericUpDownMinutes.Maximum = 59;

            //// Definir os valores iniciais para as horas e minutos
            ////DateTime currentTime = DateTime.Now;
            //finallNumericUpDownHours.Value = currentTime.Hour;
            //finalNumericUpDownMinutes.Value = currentTime.Minute;
            //UpdateMaskedTextBoxTextFinal();
            // Configura os valores mínimos e máximos para as horas e minutos
            inicialNumericUpDownHours.Minimum = 0;
            inicialNumericUpDownHours.Maximum = 24;
            inicialNumericUpDownMinutes.Minimum = 0;
            inicialNumericUpDownMinutes.Maximum = 59;

            finallNumericUpDownHours.Minimum = 0;
            finallNumericUpDownHours.Maximum = 24;
            finalNumericUpDownMinutes.Minimum = 0;
            finalNumericUpDownMinutes.Maximum = 59;

            //// Definir os valores iniciais para as horas e minutos
            //if (!string.IsNullOrEmpty(horaInicio))
            //{
            //    string[] partsInicio = horaInicio.Split(':');
            //    inicialNumericUpDownHours.Value = int.Parse(partsInicio[0]);
            //    inicialNumericUpDownMinutes.Value = int.Parse(partsInicio[1]);
            //}

            //if (!string.IsNullOrEmpty(horaFim))
            //{
            //    string[] partsFim = horaFim.Split(':');
            //    finallNumericUpDownHours.Value = int.Parse(partsFim[0]);
            //    finalNumericUpDownMinutes.Value = int.Parse(partsFim[1]);
            //}

            //UpdateMaskedTextBoxTextInicial();
            //UpdateMaskedTextBoxTextFinal();


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

        public void PesquisarFuncionariocomChave(string nome)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLFuncionario bll = new BLLFuncionario(cx);

            dgvMostrarFuncionario.DataSource = bll.PesquisarFuncionariosComChaveVacina(nome);
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


                    PesquisarFuncionariocomChave(txtPesquisarFuncionario.Text);
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
                this.animalID = Convert.ToInt32(animalID);


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
                txtDadosFuncionario.Text =nome;
                txtCodVeterinario.Text= FuncionarioID.ToString();
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
                txtDadosFuncionario.Enabled = false;
                txtObservacao.Enabled = false;

                inicialMaskedTextBox1.Enabled = false;
                inicialNumericUpDownHours.Enabled = false;
                inicialNumericUpDownMinutes.Enabled = false;

                finallNumericUpDownHours.Enabled = false;
                finalNumericUpDownMinutes.Enabled = false;
                finalMaskedTextBox1.Enabled = false;

            }

            if (op == 2)
            {
                btnEditar.Enabled = false;
                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;

                txtDadosFuncionario.Enabled = true;
                txtObservacao.Enabled = true;

                txtPesquisarAnimal.Enabled = true;
                txtPesquisarFuncionario.Enabled = true;
                cmbGravidade.Enabled = true;
                dtDataAgendada.Enabled = true;
                cbmStatus.Enabled = true;
                cbmTipoAgendamento.Enabled = true;

                inicialMaskedTextBox1.Enabled = true;
                inicialNumericUpDownHours.Enabled = true;
                inicialNumericUpDownMinutes.Enabled = true;

                finallNumericUpDownHours.Enabled = true;
                finalNumericUpDownMinutes.Enabled = true;
                finalMaskedTextBox1.Enabled = true;
            }
            if (op == 3)
            {
                //btnEditar.Enabled = perAlterar;

                btnEditar.Enabled = true;
                btnCancelar.Enabled = true;
                btnNovo.Enabled = true;

                txtDadosFuncionario.Enabled = true;
                txtObservacao.Enabled = true;

                inicialMaskedTextBox1.Enabled = true;
                inicialNumericUpDownHours.Enabled = true;
                inicialNumericUpDownMinutes.Enabled = true;

                finallNumericUpDownHours.Enabled = true;
                finalNumericUpDownMinutes.Enabled = true;
                finalMaskedTextBox1.Enabled = true;

                txtPesquisarAnimal.Enabled = true;
                txtPesquisarFuncionario.Enabled = true;
                cmbGravidade.Enabled = true;
                dtDataAgendada.Enabled = true;
                cbmStatus.Enabled = true;
                cbmTipoAgendamento.Enabled = true;
            }

        }

        private void pnlCadastrar_Paint(object sender, PaintEventArgs e)
        {

        }
        public void limparTela()
        {
            txtCodAgendamento.Text = "";
            txtDadosFuncionario.Text = "";
            txtObservacao.Text = "";
            cbmStatus.SelectedIndex = -1;
            cbmTipoAgendamento.SelectedIndex = -1;
            cmbGravidade.SelectedIndex = -1;
            dgvMostrarDadosAnimal.DataSource = null;
            dgvMostrarDadosAnimal.Rows.Clear();
            dgvMostrarDadosAnimal.Columns.Clear();

            // Definir os valores iniciais para as horas e minutos
            DateTime currentTime = DateTime.Now;
            inicialNumericUpDownHours.Value = currentTime.Hour;
            inicialNumericUpDownMinutes.Value = currentTime.Minute;
            UpdateMaskedTextBoxTextInicial();
            // Definir os valores iniciais para as horas e minutos
            //DateTime currentTime = DateTime.Now;
            finallNumericUpDownHours.Value = currentTime.Hour;
            finalNumericUpDownMinutes.Value = currentTime.Minute;
            UpdateMaskedTextBoxTextFinal();
        }
        private bool VerificarHorarioValido()
        {
            // Obter os valores dos MaskedTextBox
            string horaInicialText = inicialMaskedTextBox1.Text;
            string horaFinalText = finalMaskedTextBox1.Text;


            if (!DateTime.TryParse(horaInicialText, out horaInicial) || !DateTime.TryParse(horaFinalText, out horaFinal))
            {

                return false;
            }

            // Verificar se o horário final é maior que o horário inicial
            if (horaFinal <= horaInicial)
            {
                return false;
            }


            return true;
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //verifica a hora de funcionamento da clinica
            // Obter as horas iniciais e finais das caixas de texto
            TimeSpan horaInicialHorario = TimeSpan.Parse(inicialMaskedTextBox1.Text);
            TimeSpan horaFinalHorario = TimeSpan.Parse(finalMaskedTextBox1.Text);

            // Verificar se a hora inicial é antes das 8h ou a hora final é após as 15h
            if (horaInicialHorario < TimeSpan.Parse("08:00:00") || horaFinalHorario > TimeSpan.Parse("15:00:00"))
            {
                MessageBox.Show("A clínica funciona das 8h às 15h. Por favor, escolha um horário dentro deste intervalo.", "Horário Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            { 

            if (VerificarHorarioValido() == false || (dtDataAgendada.Value < DateTime.Today))
            {
                MessageBox.Show("Horário ou Data inválidos \n O horário final deve ser maior que o horário inicial \ne\n A data agendada deve ser maior que a data actual.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; // Retorna para interromper o fluxo do método
            }
            // Verificar se a duração é maior ou igual a 30 minutos
            if ((horaFinal - horaInicial).TotalMinutes < 30)
            {
                MessageBox.Show("A duração da consulta deve ser maior que 30 minutos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCadastarConsultaAgendada bll = new BLLCadastarConsultaAgendada(conexao);
                ModeloCadastrarConsultaAgendada modelo = new ModeloCadastrarConsultaAgendada();
                modelo.dataMarcada = dtDataAgendada.Value.Date;
                modelo.funcionarioID = this.FuncionarioID;
                modelo.UsuarioID = SessaoUsuario.Session.Instance.UsuID;
                modelo.animalID = this.animalID;
                modelo.tipoAgendamento = cbmTipoAgendamento.Text;
                modelo.Obs = txtObservacao.Text;
                modelo.status = cbmStatus.Text;
                modelo.gravidade = cmbGravidade.Text;
                DateTime dataBase = new DateTime(2022, 1, 1);

                DateTime horaInicial;
                DateTime horaFinal;

                string[] timePartsInicial = inicialMaskedTextBox1.Text.Split(':');
                if (timePartsInicial.Length == 2 && int.TryParse(timePartsInicial[0], out int hoursInicial) && int.TryParse(timePartsInicial[1], out int minutesInicial))
                {
                    horaInicial = dataBase.Add(new TimeSpan(hoursInicial, minutesInicial, 0));
                    modelo.horaInicial = horaInicial;
                }

                string[] timePartsFinal = finalMaskedTextBox1.Text.Split(':');
                if (timePartsFinal.Length == 2 && int.TryParse(timePartsFinal[0], out int hoursFinal) && int.TryParse(timePartsFinal[1], out int minutesFinal))
                {
                    horaFinal = dataBase.Add(new TimeSpan(hoursFinal, minutesFinal, 0));
                    modelo.horaFinal = horaFinal;
                }
                bool teste = bll.VerificarDisponibilidadeConsulta(modelo);
                if (teste)
                {
                    bll.CadastarConsultaAgendada(modelo);
                    MessageBox.Show("\n \n Agendamento  Cadastrado com Sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //ataualizando o datagrid na tela de marcacao de consulta
                    frmMarcacaoConsulta frmMarcacao = new frmMarcacaoConsulta();
                    frmMarcacao.mostrarConsultasAgendadas();
                    limparTela();

                }
                else
                {
                    MessageBox.Show("O horário selecionado para este Veterinário já está ocupado. Por favor, escolha outro horário.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }

            catch (Exception erro)
            {

                MessageBox.Show("Não foi possivel Realizar a Operação!!! \n\nContate o Administrador do Sistema!!!\n\nErro Ocorrido:" + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
        }
            }
            public void UpdateMaskedTextBoxTextInicial()
            {
                inicialMaskedTextBox1.Text = $"{inicialNumericUpDownHours.Value:00}:{inicialNumericUpDownMinutes.Value:00}";
            }
            public void UpdateMaskedTextBoxTextFinalteste(string hora)
            {
                finalMaskedTextBox1.Text = hora;
            }
            public void UpdateMaskedTextBoxTextInicialteste(string hora)
            {
                inicialMaskedTextBox1.Text = hora;
            }


            public void UpdateMaskedTextBoxTextFinal()
            {
                finalMaskedTextBox1.Text = $"{finallNumericUpDownHours.Value:00}:{finalNumericUpDownMinutes.Value:00}";
            }
            private void numericUpDownHours_ValueChanged(object sender, EventArgs e)
            {
                if (inicialNumericUpDownHours.Value == 24)
                {
                    inicialNumericUpDownHours.Value = 0;
                }

                UpdateMaskedTextBoxTextInicial();
            }

            private void numericUpDownMinutes_ValueChanged(object sender, EventArgs e)

            {
                if (inicialNumericUpDownMinutes.Value == 59)
                {
                    inicialNumericUpDownMinutes.Value = 0;
                    inicialNumericUpDownHours.Value++;
                }

                UpdateMaskedTextBoxTextInicial();
            }

            private void finallNumericUpDownHours_ValueChanged(object sender, EventArgs e)
            {
                if (finallNumericUpDownHours.Value == 24)
                {
                    finallNumericUpDownHours.Value = 0;
                }

                UpdateMaskedTextBoxTextFinal();
            }

            private void finalNumericUpDownMinutes_ValueChanged(object sender, EventArgs e)
            {
                if (finalNumericUpDownMinutes.Value == 59)
                {
                    finalNumericUpDownMinutes.Value = 0;
                    finallNumericUpDownHours.Value++;
                }

                UpdateMaskedTextBoxTextFinal();
            }
            public void EditarConsultaNomal()
            {
                if (VerificarHorarioValido() == false || (dtDataAgendada.Value < DateTime.Today))
                {
                    MessageBox.Show("Horário ou Data inválidos \n O horário final deve ser maior que o horário inicial \ne\n A data agendada deve ser maior que a data actual.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return; // Retorna para interromper o fluxo do método
                }
                // Verificar se a duração é maior ou igual a 30 minutos
                if ((horaFinal - horaInicial).TotalMinutes < 30)
                {
                    MessageBox.Show("A duração da consulta deve ser maior que 30 minutos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                try
                {
                    DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLCadastarConsultaAgendada bll = new BLLCadastarConsultaAgendada(conexao);
                    ModeloCadastrarConsultaAgendada modelo = new ModeloCadastrarConsultaAgendada();

                    modelo.dataMarcada = dtDataAgendada.Value.Date;
                    modelo.funcionarioID = this.FuncionarioID;
                    modelo.UsuarioID = SessaoUsuario.Session.Instance.UsuID;
                    modelo.animalID = this.animalID;
                    modelo.tipoAgendamento = cbmTipoAgendamento.Text;
                    modelo.Obs = txtObservacao.Text;
                    modelo.status = cbmStatus.Text;
                    modelo.gravidade = cmbGravidade.Text;
                    DateTime dataBase = new DateTime(2022, 1, 1);
                    modelo.agendamentoID = Convert.ToInt32(txtCodAgendamento.Text);

                    DateTime horaInicial;
                    DateTime horaFinal;

                    string[] timePartsInicial = inicialMaskedTextBox1.Text.Split(':');
                    if (timePartsInicial.Length == 2 && int.TryParse(timePartsInicial[0], out int hoursInicial) && int.TryParse(timePartsInicial[1], out int minutesInicial))
                    {
                        horaInicial = dataBase.Add(new TimeSpan(hoursInicial, minutesInicial, 0));
                        modelo.horaInicial = horaInicial;
                    }

                    string[] timePartsFinal = finalMaskedTextBox1.Text.Split(':');
                    if (timePartsFinal.Length == 2 && int.TryParse(timePartsFinal[0], out int hoursFinal) && int.TryParse(timePartsFinal[1], out int minutesFinal))
                    {
                        horaFinal = dataBase.Add(new TimeSpan(hoursFinal, minutesFinal, 0));
                        modelo.horaFinal = horaFinal;
                    }

                    bll.updateConsultaAgendada(modelo);
                    MessageBox.Show("\n \n Actualização sem reagendamento realizada com Sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //ataualizando o datagrid na tela de marcacao de consulta
                    frmMarcacaoConsulta frmMarcacao = new frmMarcacaoConsulta();
                    frmMarcacao.mostrarConsultasAgendadas();
                    limparTela();
                }
                catch (Exception erro)
                {

                    MessageBox.Show("Não foi possivel Realizar a Operação!!! \n\nContate o Administrador do Sistema!!!\n\nErro Ocorrido:" + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                }

            }
            public void editarConsultaReagendada()
            {
                if (VerificarHorarioValido() == false || (dtDataAgendada.Value < DateTime.Today))
                {
                    MessageBox.Show("Horário ou Data inválidos \n O horário final deve ser maior que o horário inicial \ne\n A data agendada deve ser maior que a data actual.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return; // Retorna para interromper o fluxo do método
                }
                // Verificar se a duração é maior ou igual a 30 minutos
                if ((horaFinal - horaInicial).TotalMinutes < 30)
                {
                    MessageBox.Show("A duração da consulta deve ser maior que 30 minutos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                try
                {
                    DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLCadastarConsultaAgendada bll = new BLLCadastarConsultaAgendada(conexao);
                    ModeloCadastrarConsultaAgendada modelo = new ModeloCadastrarConsultaAgendada();

                    modelo.dataMarcada = dtDataAgendada.Value.Date;
                    modelo.funcionarioID = this.FuncionarioID;
                    modelo.UsuarioID = SessaoUsuario.Session.Instance.UsuID;
                    modelo.animalID = this.animalID;
                    modelo.tipoAgendamento = cbmTipoAgendamento.Text;
                    modelo.Obs = txtObservacao.Text;
                    modelo.status = cbmStatus.Text;
                    modelo.gravidade = cmbGravidade.Text;
                    DateTime dataBase = new DateTime(2022, 1, 1);
                    modelo.agendamentoID = Convert.ToInt32(txtCodAgendamento.Text);

                    DateTime horaInicial;
                    DateTime horaFinal;

                    string[] timePartsInicial = inicialMaskedTextBox1.Text.Split(':');
                    if (timePartsInicial.Length == 2 && int.TryParse(timePartsInicial[0], out int hoursInicial) && int.TryParse(timePartsInicial[1], out int minutesInicial))
                    {
                        horaInicial = dataBase.Add(new TimeSpan(hoursInicial, minutesInicial, 0));
                        modelo.horaInicial = horaInicial;
                    }

                    string[] timePartsFinal = finalMaskedTextBox1.Text.Split(':');
                    if (timePartsFinal.Length == 2 && int.TryParse(timePartsFinal[0], out int hoursFinal) && int.TryParse(timePartsFinal[1], out int minutesFinal))
                    {
                        horaFinal = dataBase.Add(new TimeSpan(hoursFinal, minutesFinal, 0));
                        modelo.horaFinal = horaFinal;
                    }
                    bool teste = bll.VerificarDisponibilidadeConsulta(modelo);
                    if (teste)
                    {
                        bll.updateConsultaAgendada(modelo);
                        MessageBox.Show("\n \n Actualização com reagendamento realizada com Sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        //ataualizando o datagrid na tela de marcacao de consulta
                        frmMarcacaoConsulta frmMarcacao = new frmMarcacaoConsulta();
                        frmMarcacao.mostrarConsultasAgendadas();
                        limparTela();

                    }

                    else
                    {
                        MessageBox.Show("O horário selecionado para este Veterinário já está ocupado. Por favor, escolha outro horário.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                catch (Exception erro)
                {

                    MessageBox.Show("Não foi possivel Realizar a Operação!!! \n\nContate o Administrador do Sistema!!!\n\nErro Ocorrido:" + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                }


            }

            private void btnEditar_Click(object sender, EventArgs e)
            {
                string status = cbmStatus.SelectedItem?.ToString();
                if (status == "Reagendada")
                {
                    editarConsultaReagendada();
                }
                else
                {
                    EditarConsultaNomal();
                }

            }

            private void btnCancelar_Click(object sender, EventArgs e)
            {
                limparTela();
                alteraBotoes(2, perInserir, perAlterar, perExcluir, perImprimir);
            }

            private void cbmStatus_SelectedIndexChanged(object sender, EventArgs e)
            {
            if (vindoDe == "Editar")
            {
                string status = cbmStatus.SelectedItem?.ToString();
                if (status == "Reagendada")
                {
                    inicialMaskedTextBox1.Enabled = true;
                    inicialNumericUpDownHours.Enabled = true;
                    inicialNumericUpDownMinutes.Enabled = true;

                    finallNumericUpDownHours.Enabled = true;
                    finalNumericUpDownMinutes.Enabled = true;
                    finalMaskedTextBox1.Enabled = true;
                    dtDataAgendada.Enabled = true;

                }
                else
                {
                    inicialMaskedTextBox1.Enabled = false;
                    inicialNumericUpDownHours.Enabled = false;
                    inicialNumericUpDownMinutes.Enabled = false;

                    finallNumericUpDownHours.Enabled = false;
                    finalNumericUpDownMinutes.Enabled = false;
                    finalMaskedTextBox1.Enabled = false;
                    dtDataAgendada.Enabled = false;
                }
            }
            else
            {
                inicialMaskedTextBox1.Enabled = true;
                inicialNumericUpDownHours.Enabled = true;
                inicialNumericUpDownMinutes.Enabled = true;

                finallNumericUpDownHours.Enabled = true;
                finalNumericUpDownMinutes.Enabled = true;
                finalMaskedTextBox1.Enabled = true;
                dtDataAgendada.Enabled = true;

            }

            }

        private void guna2ShadowPanel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

