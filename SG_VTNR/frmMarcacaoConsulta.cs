using BLL;
using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SG_VTNR
{
    public partial class frmMarcacaoConsulta : Form
    {
        public static int static_month;
        public static int static_year;
        int month;
        int year;
        int animalID;
        int funcionarioID;

        public frmMarcacaoConsulta()
        {
            InitializeComponent();
            mostrarConsultasAgendadas();
        }
        public void mostrarConsultasAgendadas()
        {
            DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCadastarConsultaAgendada bll = new BLLCadastarConsultaAgendada(conexao);
            dgvMostrarConsultasAgendadas.DataSource = bll.mostrarConsultasAgendadas();

            // Permitir que as colunas sejam redimensionadas pelos usuários
            dgvMostrarConsultasAgendadas.AllowUserToResizeColumns = true;

            // Ajustar o tamanho das colunas automaticamente para exibir todo o conteúdo
            dgvMostrarConsultasAgendadas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // Configurar o DataGridView para quebrar as linhas
            dgvMostrarConsultasAgendadas.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // Ajustar o estilo do cabeçalho para que possa envolver o texto
            foreach (DataGridViewColumn column in dgvMostrarConsultasAgendadas.Columns)
            {
                column.HeaderCell.Style.WrapMode = DataGridViewTriState.True;
            }

            // Definir altura das linhas para acomodar o conteúdo completo
            dgvMostrarConsultasAgendadas.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);

            // Definir o tamanho das linhas do cabeçalho
            dgvMostrarConsultasAgendadas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMostrarConsultasAgendadas.ColumnHeadersHeight = 40; // Ajuste o valor conforme desejado

            // Aumentar o tamanho das outras linhas
            dgvMostrarConsultasAgendadas.RowTemplate.Height = 30; // Ajuste o valor conforme desejado para outras linhas

            // Adicionar diferença visual na cor das linhas
            dgvMostrarConsultasAgendadas.RowsDefaultCellStyle.BackColor = Color.LightGray;
            dgvMostrarConsultasAgendadas.AlternatingRowsDefaultCellStyle.BackColor = Color.White;

            // Destacar consultas marcadas para a data atual com cor verde
            try
            {
                DateTime teste = DateTime.Now.Date;
                foreach (DataGridViewRow row in dgvMostrarConsultasAgendadas.Rows)
                {
                    // Verificar se a célula contém um valor e se esse valor é uma data válida
                    if (row.Cells["Data Marcada"].Value != null && DateTime.TryParse(row.Cells["Data Marcada"].Value.ToString(), out DateTime dataMarcada))
                    {

                        // Comparar apenas a parte da data (ignorando a hora)
                        if (dataMarcada.Date == teste)
                        {
                            row.Cells["Data Marcada"].Style.BackColor = Color.LightGreen; // Definir a cor de fundo da célula como verde
                        }
                    }

                }
            }
            catch (Exception ex)
            {

                Debug.WriteLine($"erro ao comparar as datas:{ex.Message}");
            }


        }


        private void dgvMostrarConsultasAgendadas_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            // Definir cores diferentes para cada linha
            if (e.RowIndex % 2 == 0)
            {
                // Definir cor para linhas pares
                dgvMostrarConsultasAgendadas.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGray;
            }
            else
            {
                // Definir cor para linhas ímpares
                dgvMostrarConsultasAgendadas.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            }
        }

        //public void mostrarConsultasAgendadas()
        //{

        //    DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
        //    BLLCadastarConsultaAgendada bll = new BLLCadastarConsultaAgendada(conexao);
        //    dgvMostrarConsultasAgendadas.DataSource=bll.mostrarConsultasAgendadas();

        //    // Configurar o DataGridView para quebrar as linhas
        //    dgvMostrarConsultasAgendadas.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        //    dgvMostrarConsultasAgendadas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        //    dgvMostrarConsultasAgendadas.AutoResizeRows();

        //    // Ajustar a altura da linha de cabeçalho
        //    dgvMostrarConsultasAgendadas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        //}

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmMarcacaoConsulta_Load(object sender, EventArgs e)
        {
            displaDay();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {

        }

        private void btnMarcarConsulta_Click(object sender, EventArgs e)
        {


        }

        private void guna2Button14_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
        private void guna2DateTimePicker2_ValueChanged_1(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();
            // Para extrair o ano selecionado
            year = dateTimePicker2.Value.Year;

            // Para extrair o mês selecionado
            month = dateTimePicker2.Value.Month;

            static_month = month;
            static_year = year;

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lblDate.Text = monthname + " " + year;
            //Lets get the first day of the month
            DateTime startofthemonth = new DateTime(year, month, 1);
            //get the count of daays of month
            int days = DateTime.DaysInMonth(year, month);
            //convert the startofthemonth to integer
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            //first lest create a blank usercontrol
            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlDays ucblank = new UserControlDays();
                daycontainer.Controls.Add(ucblank);
            }
            // now lets create usercontrol for days
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }

        private void displaDay()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lblDate.Text = monthname + " " + year;

            static_month = month;
            static_year = year;

            //Lets get the first day of the month
            DateTime startofthemonth = new DateTime(year, month, 1);
            //get the count of daays of month
            int days = DateTime.DaysInMonth(year, month);
            //convert the startofthemonth to integer
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            //first lest create a blank usercontrol
            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlDays ucblank = new UserControlDays();
                daycontainer.Controls.Add(ucblank);
            }
            // now lets create usercontrol for days
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);

            }
        }

        private void btnPrevios_Click(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();
            //decrement month to go to prevous month
            month--;

            static_month = month;
            static_year = year;

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lblDate.Text = monthname + " " + year;
            //Lets get the first day of the month
            DateTime startofthemonth = new DateTime(year, month, 1);
            //get the count of daays of month
            int days = DateTime.DaysInMonth(year, month);
            //convert the startofthemonth to integer
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            //first lest create a blank usercontrol
            for (int i = 1; i <= dayoftheweek; i++)
            {
                UserControlDays ucblank = new UserControlDays();
                daycontainer.Controls.Add(ucblank);
            }
            // now lets create usercontrol for days
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }

        }

        private void btnNext_Click(object sender, EventArgs e)
        {

        }

        private void btnNext_Click_1(object sender, EventArgs e)
        {
            // clear container
            daycontainer.Controls.Clear();
            //increment month to go to next month
            month++;

            static_month = month;
            static_year = year;

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lblDate.Text = monthname + " " + year;
            //Lets get the first day of the month
            DateTime startofthemonth = new DateTime(year, month, 1);
            //get the count of daays of month
            int days = DateTime.DaysInMonth(year, month);
            //convert the startofthemonth to integer
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            //first lest create a blank usercontrol
            for (int i = 1; i <= dayoftheweek; i++)
            {
                UserControlDays ucblank = new UserControlDays();
                daycontainer.Controls.Add(ucblank);
            }
            // now lets create usercontrol for days
            for (int i = 1; i < days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }

        private void btnPrevios_Click_1(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();
            //decrement month to go to prevous month
            month--;

            static_month = month;
            static_year = year;

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lblDate.Text = monthname + " " + year;
            //Lets get the first day of the month
            DateTime startofthemonth = new DateTime(year, month, 1);
            //get the count of daays of month
            int days = DateTime.DaysInMonth(year, month);
            //convert the startofthemonth to integer
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            //first lest create a blank usercontrol
            for (int i = 1; i <= dayoftheweek; i++)
            {
                UserControlDays ucblank = new UserControlDays();
                daycontainer.Controls.Add(ucblank);
            }
            // now lets create usercontrol for days
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }

        }

        private void gunaShadowPanel2_Paint(object sender, PaintEventArgs e)
        {

        }


        //este metodo peqmite pesquisar os dados do animal com base ao codigo do animal que esta na linha selecionada 
        public void PesquisarAnimal()
        {

        }
        private void PreencherFormulario(ModeloCadastrarConsultaAgendada modelo)
        {
            frmCadastrarAgendamentoConsulta frm = new frmCadastrarAgendamentoConsulta();
            //      
            // Preencher os controles do formulário com os dados do modelo
            frm.txtCodAgendamento.Text = modelo.agendamentoID.ToString();
            //frm.txtUsuarioID.Text = modelo.UsuarioID.ToString();
            //frm.txtProprietarioID.Text = modelo.ProprietarioID.ToString();
            //frm.txtFuncionarioID.Text = modelo.funcionarioID.ToString();
            //frm.txtAnimalID.Text = modelo.animalID.ToString();
            frm.cbmTipoAgendamento.Text = modelo.tipoAgendamento;
            frm.txtObservacao.Text = modelo.Obs;
            frm.cbmStatus.Text = modelo.status;
            frm.cmbGravidade.Text = modelo.gravidade;
            //frm.dtHoraInicial.Value = modelo.horaInicial;
            //frm.dtHoraFinal.Value = modelo.horaFinal;
            //frm.dtDataAgendada.Value = modelo.dataMarcada;
            //        if (modelo.horaInicial != DateTime.MinValue &&
            //modelo.horaInicial >= frm.dtHoraInicial.MinDate &&
            //modelo.horaInicial <= frm.dtHoraInicial.MaxDate)
            //        {
            //            frm.dtHoraInicial.Value = modelo.horaInicial;
            //        }
            //        else
            //        {
            //            frm.dtHoraInicial.Value = frm.dtHoraInicial.MinDate;
            //        }

            //        if (modelo.horaFinal != DateTime.MinValue &&
            //            modelo.horaFinal >= frm.dtHoraFinal.MinDate &&
            //            modelo.horaFinal <= frm.dtHoraFinal.MaxDate)
            //        {
            //            frm.dtHoraFinal.Value = modelo.horaFinal;
            //        }
            //        else
            //        {
            //            frm.dtHoraFinal.Value = frm.dtHoraFinal.MinDate;
            //        }

        }
        public void PesquisarFuncionariocomChave(int codigo)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLFuncionario bll = new BLLFuncionario(cx);
            frmCadastrarAgendamentoConsulta frm = new frmCadastrarAgendamentoConsulta();
            frm.txtDadosFuncionario.Text = Convert.ToString(bll.BusacarFuncionarioMarcacaoConsulta(codigo));
        }

        private void dgvMostrarConsultasAgendadas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            frmCadastrarAgendamentoConsulta frm = new frmCadastrarAgendamentoConsulta();

            if (e.RowIndex >= 0 && e.ColumnIndex == dgvMostrarConsultasAgendadas.Columns["colEditar"].Index)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLConsultasMarcadas bll = new BLLConsultasMarcadas(cx);

                int codAgendamento = Convert.ToInt32(dgvMostrarConsultasAgendadas.Rows[e.RowIndex].Cells["Código"].Value.ToString());
                this.animalID = Convert.ToInt32(dgvMostrarConsultasAgendadas.Rows[e.RowIndex].Cells["Código Animal"].Value.ToString());
                frm.animalID = this.animalID;
                ModeloCadastrarConsultaAgendada modelo = bll.BusacarConsultaComChave(codAgendamento);

                if (modelo != null)
                {
                    //PreencherFormulario(modelo);
                    // Preencher os controles do formulário com os dados do modelo
                    frm.txtCodAgendamento.Text = modelo.agendamentoID.ToString();
                    frm.cbmTipoAgendamento.Text = modelo.tipoAgendamento;
                    frm.txtObservacao.Text = modelo.Obs;
                    frm.cbmStatus.Text = modelo.status;
                    frm.cmbGravidade.Text = modelo.gravidade;
                    this.funcionarioID = modelo.funcionarioID;
                    frm.UpdateMaskedTextBoxTextFinalteste(modelo.horaFinal.ToString("HH:mm"));
                    frm.UpdateMaskedTextBoxTextInicialteste(modelo.horaInicial.ToString("HH:mm"));
                    //frm.dtHoraFinal.Value = modelo.horaFinal;
                    frm.dtDataAgendada.Value = modelo.dataMarcada;

                    //PesquisarFuncionariocomChave(funcionarioID);-----------------------------------------
                    //DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLFuncionario bllFuncionario = new BLLFuncionario(cx);
                    //frmCadastrarAgendamentoConsulta frm = new frmCadastrarAgendamentoConsulta();
                    bllFuncionario.BusacarFuncionarioMarcacaoConsulta(this.funcionarioID);
                    //frm.txtDadosFuncionario.Text= modelo.nomeFuncionario.ToString();

                    ModeloCadastrarConsultaAgendada modelo02 = bllFuncionario.BusacarFuncionarioMarcacaoConsulta(this.funcionarioID);
                    if (modelo02 != null)
                    {
                        frm.txtDadosFuncionario.Text = "Código: " + this.funcionarioID + "        Nome: " + modelo02.nomeFuncionario.ToString();
                        frm.FuncionarioID = this.funcionarioID;
                    }
                    else
                    {
                        // Trate o caso em que nenhum funcionário foi encontrado com o código especificado
                        frm.txtDadosFuncionario.Text = "Funcionário não encontrado";
                    }

                    //este metodo peqmite pesquisar os dados do animal com base ao codigo do animal que esta na linha
                    PesquisarAnimal();
                    //frmCadastrarAgendamentoConsulta frm = new frmCadastrarAgendamentoConsulta();

                    BLLAnimal bllAnimal = new BLLAnimal(cx);
                    frm.dgvMostrarDadosAnimal.DataSource = bllAnimal.PesquisarAnimalcomChave(this.animalID.ToString());
                    // Renomear os cabeçalhos das colunas diretamente no DataGridView
                    frm.dgvMostrarDadosAnimal.Columns["AnimalID"].HeaderText = "Código";
                    frm.dgvMostrarDadosAnimal.Columns["Nome"].HeaderText = "Nome";
                    frm.dgvMostrarDadosAnimal.Columns["Especie"].HeaderText = "Espécie";
                    frm.dgvMostrarDadosAnimal.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                    frm.dgvMostrarDadosAnimal.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                    frm.dgvMostrarDadosAnimal.AutoResizeRows();

                    // Ajustar a altura da linha de cabeçalho
                    frm.dgvMostrarDadosAnimal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

                    // Exibir o formulário para edição
                    Boolean perInserir = false; Boolean perAlterar = false; Boolean perExcluir = false; Boolean perImprimir = false;
                    frm.alteraBotoes(3, perInserir, perAlterar, perExcluir, perImprimir);
                    frm.Show();
                }
            }
        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            mostrarConsultaAgendadaPorData();
        }

        private void cmbGravidade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void mostrarConsultaAgendadaPorData()
        {
            DateTime dataInicial1 = dataInicial.Value;
            DateTime dataFinal1 = dataFinal.Value.Date.AddDays(1).AddSeconds(-1);
            if (dataFinal.Value < dataInicial.Value)
            {
                MessageBox.Show("A data Inicial tem de ser Menor que a data Final","Informação",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            if (dataFinal.Value >= dataInicial.Value)
            {
                DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCadastarConsultaAgendada bll = new BLLCadastarConsultaAgendada(conexao);
                dgvMostrarConsultasAgendadas.DataSource = bll.mostrarConsultasAgendadasPorData(dataInicial1, dataFinal1);

                // Permitir que as colunas sejam redimensionadas pelos usuários
                dgvMostrarConsultasAgendadas.AllowUserToResizeColumns = true;

                // Ajustar o tamanho das colunas automaticamente para exibir todo o conteúdo
                dgvMostrarConsultasAgendadas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                // Configurar o DataGridView para quebrar as linhas
                dgvMostrarConsultasAgendadas.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

                // Ajustar o estilo do cabeçalho para que possa envolver o texto
                foreach (DataGridViewColumn column in dgvMostrarConsultasAgendadas.Columns)
                {
                    column.HeaderCell.Style.WrapMode = DataGridViewTriState.True;
                }

                // Definir altura das linhas para acomodar o conteúdo completo
                dgvMostrarConsultasAgendadas.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);

                // Definir o tamanho das linhas do cabeçalho
                dgvMostrarConsultasAgendadas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                dgvMostrarConsultasAgendadas.ColumnHeadersHeight = 40; // Ajuste o valor conforme desejado

                // Aumentar o tamanho das outras linhas
                dgvMostrarConsultasAgendadas.RowTemplate.Height = 30; // Ajuste o valor conforme desejado para outras linhas

                // Adicionar diferença visual na cor das linhas
                dgvMostrarConsultasAgendadas.RowsDefaultCellStyle.BackColor = Color.LightGray;
                dgvMostrarConsultasAgendadas.AlternatingRowsDefaultCellStyle.BackColor = Color.White;

                // Destacar consultas marcadas para a data atual com cor verde
                try
                {
                    DateTime teste = DateTime.Now.Date;
                    foreach (DataGridViewRow row in dgvMostrarConsultasAgendadas.Rows)
                    {
                        // Verificar se a célula contém um valor e se esse valor é uma data válida
                        if (row.Cells["Data Marcada"].Value != null && DateTime.TryParse(row.Cells["Data Marcada"].Value.ToString(), out DateTime dataMarcada))
                        {

                            // Comparar apenas a parte da data (ignorando a hora)
                            if (dataMarcada.Date == teste)
                            {
                                row.Cells["Data Marcada"].Style.BackColor = Color.LightGreen; // Definir a cor de fundo da célula como verde
                            }
                        }

                    }
                }
                catch (Exception ex)
                {

                    Debug.WriteLine($"erro ao comparar as datas:{ex.Message}");
                }
            }
        }
        public void mostrarConsultasPorVeterinario(int codigo)
        {
            
            DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCadastarConsultaAgendada bll = new BLLCadastarConsultaAgendada(conexao);
            dgvMostrarConsultasAgendadas.DataSource = bll.mostrarConsultasAgendadasPorVeterinario(codigo);

            // Permitir que as colunas sejam redimensionadas pelos usuários
            dgvMostrarConsultasAgendadas.AllowUserToResizeColumns = true;

            // Ajustar o tamanho das colunas automaticamente para exibir todo o conteúdo
            dgvMostrarConsultasAgendadas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // Configurar o DataGridView para quebrar as linhas
            dgvMostrarConsultasAgendadas.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // Ajustar o estilo do cabeçalho para que possa envolver o texto
            foreach (DataGridViewColumn column in dgvMostrarConsultasAgendadas.Columns)
            {
                column.HeaderCell.Style.WrapMode = DataGridViewTriState.True;
            }

            // Definir altura das linhas para acomodar o conteúdo completo
            dgvMostrarConsultasAgendadas.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);

            // Definir o tamanho das linhas do cabeçalho
            dgvMostrarConsultasAgendadas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMostrarConsultasAgendadas.ColumnHeadersHeight = 40; // Ajuste o valor conforme desejado

            // Aumentar o tamanho das outras linhas
            dgvMostrarConsultasAgendadas.RowTemplate.Height = 30; // Ajuste o valor conforme desejado para outras linhas

            // Adicionar diferença visual na cor das linhas
            dgvMostrarConsultasAgendadas.RowsDefaultCellStyle.BackColor = Color.LightGray;
            dgvMostrarConsultasAgendadas.AlternatingRowsDefaultCellStyle.BackColor = Color.White;

            // Destacar consultas marcadas para a data atual com cor verde
            try
            {
                DateTime teste = DateTime.Now.Date;
                foreach (DataGridViewRow row in dgvMostrarConsultasAgendadas.Rows)
                {
                    // Verificar se a célula contém um valor e se esse valor é uma data válida
                    if (row.Cells["Data Marcada"].Value != null && DateTime.TryParse(row.Cells["Data Marcada"].Value.ToString(), out DateTime dataMarcada))
                    {

                        // Comparar apenas a parte da data (ignorando a hora)
                        if (dataMarcada.Date == teste)
                        {
                            row.Cells["Data Marcada"].Style.BackColor = Color.LightGreen; // Definir a cor de fundo da célula como verde
                        }
                    }

                }
            }
            catch (Exception ex)
            {

                Debug.WriteLine($"erro ao comparar as datas:{ex.Message}");
            }
        }
        public void mostrarConsultasSoMarcadas()
        {

            DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCadastarConsultaAgendada bll = new BLLCadastarConsultaAgendada(conexao);
            dgvMostrarConsultasAgendadas.DataSource = bll.mostrarConsultasAgendadasSoMarcadas();

            // Permitir que as colunas sejam redimensionadas pelos usuários
            dgvMostrarConsultasAgendadas.AllowUserToResizeColumns = true;

            // Ajustar o tamanho das colunas automaticamente para exibir todo o conteúdo
            dgvMostrarConsultasAgendadas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // Configurar o DataGridView para quebrar as linhas
            dgvMostrarConsultasAgendadas.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // Ajustar o estilo do cabeçalho para que possa envolver o texto
            foreach (DataGridViewColumn column in dgvMostrarConsultasAgendadas.Columns)
            {
                column.HeaderCell.Style.WrapMode = DataGridViewTriState.True;
            }

            // Definir altura das linhas para acomodar o conteúdo completo
            dgvMostrarConsultasAgendadas.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);

            // Definir o tamanho das linhas do cabeçalho
            dgvMostrarConsultasAgendadas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMostrarConsultasAgendadas.ColumnHeadersHeight = 40; // Ajuste o valor conforme desejado

            // Aumentar o tamanho das outras linhas
            dgvMostrarConsultasAgendadas.RowTemplate.Height = 30; // Ajuste o valor conforme desejado para outras linhas

            // Adicionar diferença visual na cor das linhas
            dgvMostrarConsultasAgendadas.RowsDefaultCellStyle.BackColor = Color.LightGray;
            dgvMostrarConsultasAgendadas.AlternatingRowsDefaultCellStyle.BackColor = Color.White;

            // Destacar consultas marcadas para a data atual com cor verde
            try
            {
                DateTime teste = DateTime.Now.Date;
                foreach (DataGridViewRow row in dgvMostrarConsultasAgendadas.Rows)
                {
                    // Verificar se a célula contém um valor e se esse valor é uma data válida
                    if (row.Cells["Data Marcada"].Value != null && DateTime.TryParse(row.Cells["Data Marcada"].Value.ToString(), out DateTime dataMarcada))
                    {

                        // Comparar apenas a parte da data (ignorando a hora)
                        if (dataMarcada.Date == teste)
                        {
                            row.Cells["Data Marcada"].Style.BackColor = Color.LightGreen; // Definir a cor de fundo da célula como verde
                        }
                    }

                }
            }
            catch (Exception ex)
            {

                Debug.WriteLine($"erro ao comparar as datas:{ex.Message}");
            }
        }

        public void mostrarConsultasCanceladas()
        {
            DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCadastarConsultaAgendada bll = new BLLCadastarConsultaAgendada(conexao);
            dgvMostrarConsultasAgendadas.DataSource = bll.mostrarConsultasCanceladas();

            // Permitir que as colunas sejam redimensionadas pelos usuários
            dgvMostrarConsultasAgendadas.AllowUserToResizeColumns = true;

            // Ajustar o tamanho das colunas automaticamente para exibir todo o conteúdo
            dgvMostrarConsultasAgendadas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // Configurar o DataGridView para quebrar as linhas
            dgvMostrarConsultasAgendadas.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // Ajustar o estilo do cabeçalho para que possa envolver o texto
            foreach (DataGridViewColumn column in dgvMostrarConsultasAgendadas.Columns)
            {
                column.HeaderCell.Style.WrapMode = DataGridViewTriState.True;
            }

            // Definir altura das linhas para acomodar o conteúdo completo
            dgvMostrarConsultasAgendadas.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);

            // Definir o tamanho das linhas do cabeçalho
            dgvMostrarConsultasAgendadas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMostrarConsultasAgendadas.ColumnHeadersHeight = 40; // Ajuste o valor conforme desejado

            // Aumentar o tamanho das outras linhas
            dgvMostrarConsultasAgendadas.RowTemplate.Height = 30; // Ajuste o valor conforme desejado para outras linhas

            // Adicionar diferença visual na cor das linhas
            dgvMostrarConsultasAgendadas.RowsDefaultCellStyle.BackColor = Color.LightGray;
            dgvMostrarConsultasAgendadas.AlternatingRowsDefaultCellStyle.BackColor = Color.White;

            // Destacar consultas marcadas para a data atual com cor verde
            try
            {
                DateTime teste = DateTime.Now.Date;
                foreach (DataGridViewRow row in dgvMostrarConsultasAgendadas.Rows)
                {
                    // Verificar se a célula contém um valor e se esse valor é uma data válida
                    if (row.Cells["Data Marcada"].Value != null && DateTime.TryParse(row.Cells["Data Marcada"].Value.ToString(), out DateTime dataMarcada))
                    {

                        // Comparar apenas a parte da data (ignorando a hora)
                        if (dataMarcada.Date == teste)
                        {
                            row.Cells["Data Marcada"].Style.BackColor = Color.LightGreen; // Definir a cor de fundo da célula como verde
                        }
                    }

                }
            }
            catch (Exception ex)
            {

                Debug.WriteLine($"erro ao comparar as datas:{ex.Message}");
            }
        }

        private void cbmSelecionarTipoPesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipoPesquisa = cbmSelecionarTipoPesquisa.SelectedItem?.ToString();
            if (tipoPesquisa!=null)
            {
            switch (tipoPesquisa)
            {
                case "Pesquisar por data":
                    mostrarConsultaAgendadaPorData();
                    txtCodFuncionario.Text = "";
                    txtNomeFuncionario.Text = "";
                    txtPesquisarFuncionario.Text = "";
                    break;
                case "Conusultas Canceladas":
                    mostrarConsultasCanceladas();
                    txtCodFuncionario.Text = "";
                    txtNomeFuncionario.Text = "";
                    txtPesquisarFuncionario.Text = "";
                    break;
                case "Pesquisar por Veterinário":
                    if (string.IsNullOrEmpty(txtCodFuncionario.Text))
                    {
                        MessageBox.Show("Por favor, informa o Código do veterinario para proceguir com a pesquisa!","Informação",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            cbmSelecionarTipoPesquisa.SelectedIndex = -1;
                            return;
                    }
                    int codigoFuncionario = Convert.ToInt32(txtCodFuncionario.Text);
                    mostrarConsultasPorVeterinario(codigoFuncionario);
                    break;
                case "Consultas Marcadas":
                    txtCodFuncionario.Text = "";
                    txtNomeFuncionario.Text = "";
                    txtPesquisarFuncionario.Text = "";
                    mostrarConsultasSoMarcadas();
                    break;
            }

            }

        }

        private void dataInicial_ValueChanged(object sender, EventArgs e)
        {
            mostrarConsultaAgendadaPorData();
        }

        private void dataFinal_ValueChanged(object sender, EventArgs e)
        {
            mostrarConsultaAgendadaPorData();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

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



        private void txtPesquisarFuncionario_TextChanged(object sender, EventArgs e)
        {
           
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

        private void dgvMostrarFuncionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvMostrarFuncionario.Rows[e.RowIndex];

                txtCodFuncionario.Text =dgvMostrarFuncionario.Rows[e.RowIndex].Cells["FuncionarioID"].Value.ToString();
                string nome = dgvMostrarFuncionario.Rows[e.RowIndex].Cells["Nome Completo"].Value.ToString();
                //this.FuncionarioID = Convert.ToInt32(dgvMostrarFuncionario.Rows[e.RowIndex].Cells["FuncionarioID"].Value.ToString());
                txtNomeFuncionario.Text = nome;
                if (pnlMostrarFuncionario.Visible == true)
                {
                    pnlMostrarFuncionario.Visible = false;
                    cbmSelecionarTipoPesquisa.SelectedIndex = -1;
                }

            }
        }

        private void txtCodFuncionario_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtCodFuncionario.Text, out int cod))
            {
               
                mostrarConsultasPorVeterinario(cod);
            }
           
        }
    }
}


