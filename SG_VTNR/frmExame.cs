using BLL;
using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SG_VTNR
{
    public partial class frmExame : Form
    {
        List<ModeloExame> ListaDeExames = new List<ModeloExame>();
        int usuarioID;
        public frmExame()
        {
            InitializeComponent();

            //usuarioID=frmLogin.get
        }

        private void pnlCadastrar_Paint(object sender, PaintEventArgs e)
        {

        }
        public void atualizarDvgCarrinho()
        {
            var dadosParaExibir = ListaDeExames.Select(d => new
            {
                d.tipoExame,
                d.funcionarioID,

            }).ToList();
            dgvCarrinho.DataSource = dadosParaExibir;
            dgvCarrinho.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvCarrinho.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvCarrinho.AutoResizeRows();
            dgvCarrinho.Columns["tipoExame"].HeaderText = "Exame Realizado";
            dgvCarrinho.Columns["funcionarioID"].HeaderText = "Veterinario";

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

            // Adicionar diferença visual na cor das linhas
            dgvCarrinho.RowsDefaultCellStyle.BackColor = Color.LightGray;
            dgvCarrinho.AlternatingRowsDefaultCellStyle.BackColor = Color.White;



        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
        }

        private void btnAdicionarCarrinho_Click(object sender, EventArgs e)
        {

            ModeloExame dadosExame = new ModeloExame
            {
                ObsGeral = txtObsGeral.Text,
                tipoExame = cmbTipoExame.Text,
                observacoesItemExame = txtObsExame.Text,
                funcionarioID = Convert.ToInt32(txtCodFuncionario.Text),
                animalID=Convert.ToInt32(txtCodAnimal.Text),
                condicaoAtualAnimal = txtCondicaoAnimal.Text,
                diagnosticoPeliminar = txtDiagnosticoPreliminar.Text,
                instrucoesProprietario = txtInstrucoes.Text,
                acomanhamentoNecessario = cmbAcompNecessario.Text,
                statusExame=cmbStatusExame.Text,
            
                        //public int usuarioID { get; set; }


    };
            ListaDeExames.Add(dadosExame);
            atualizarDvgCarrinho();


        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (
            pnlCadastrar.Visible == false)
            {

                pnlCadastrar.Visible = true;
            }
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            if (
            pnlCadastrar.Visible == true)
            {

                pnlCadastrar.Visible = false;
            }
        }
        public void PesquisarFuncionariocomChave(string nome)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLFuncionario bll = new BLLFuncionario(cx);

            dgvMostrarFuncionario.DataSource = bll.PesquisarFuncionariosComChaveVacina(nome);

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


        private void txtPesquisarFucionario_TextChanged(object sender, EventArgs e)
        {

            txtPesquisarAgendamento.Text = "";
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

        private void txtPesquisarAnimal_TextChanged(object sender, EventArgs e)
        {

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
                    PesquisarAnimalcomChaveExame();

                }


            }

        }
        public void PesquisarAnimalcomChaveExame()
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLAnimal bll = new BLLAnimal(cx);
            dgvMostrarAnimal.DataSource = bll.PesquisarAnimalcomChaveExame(txtPesquisarAnimal.Text);


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



        private void guna2ShadowPanel3_Paint(object sender, PaintEventArgs e)
        {

        }


        private void dgvMostrarAnimal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtenha os valores das células do DataGridView
                txtEspecie.Text = dgvMostrarAnimal.Rows[e.RowIndex].Cells["Espécie"].Value.ToString();
                txtNomeAnimal.Text = dgvMostrarAnimal.Rows[e.RowIndex].Cells["Nome do Animal"].Value.ToString();
                txtEstado.Text = dgvMostrarAnimal.Rows[e.RowIndex].Cells["Estado"].Value.ToString();
                txtRaca.Text = dgvMostrarAnimal.Rows[e.RowIndex].Cells["Raça"].Value.ToString();
                txtPorte.Text = dgvMostrarAnimal.Rows[e.RowIndex].Cells["Porte"].Value.ToString();
                txtSexo.Text = dgvMostrarAnimal.Rows[e.RowIndex].Cells["Sexo"].Value.ToString();
                txtPeso.Text = dgvMostrarAnimal.Rows[e.RowIndex].Cells["Peso"].Value.ToString();
                txtCodAnimal.Text = dgvMostrarAnimal.Rows[e.RowIndex].Cells["Código do Animal"].Value.ToString();
                txtICor.Text = dgvMostrarAnimal.Rows[e.RowIndex].Cells["Cor"].Value.ToString();
                txtNomeCompletoProp.Text = dgvMostrarAnimal.Rows[e.RowIndex].Cells["Nome Completo"].Value.ToString();
                txtProvincia.Text = dgvMostrarAnimal.Rows[e.RowIndex].Cells["Província"].Value.ToString();
                txtCodigoProp.Text = dgvMostrarAnimal.Rows[e.RowIndex].Cells["Código Proprietário"].Value.ToString();

                txtMunicipio.Text = dgvMostrarAnimal.Rows[e.RowIndex].Cells["Município"].Value.ToString();

                txtCidade.Text = dgvMostrarAnimal.Rows[e.RowIndex].Cells["Cidade"].Value.ToString();
                txtBairro.Text = dgvMostrarAnimal.Rows[e.RowIndex].Cells["Bairro"].Value.ToString();
                txtRua.Text = dgvMostrarAnimal.Rows[e.RowIndex].Cells["Rua"].Value.ToString();
                txtEmail.Text = dgvMostrarAnimal.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                DateTime nascimento = Convert.ToDateTime(dgvMostrarAnimal.Rows[e.RowIndex].Cells["Data Nascimento"].Value.ToString());
                TimeSpan diferenca = DateTime.Now - nascimento;
                int idadeEmAnos = (int)(diferenca.TotalDays / 365.25);
                int idadeEmMeses = (int)((diferenca.TotalDays % 365.25) / 30.44); // Aproximadamente 30.44 dias em um mês
                txtIdade.Text = idadeEmAnos == 0 ? $"{idadeEmMeses} Meses" : $"{idadeEmAnos} Ano(s)";


                if (pnlMostrarAnimal.Visible == true)
                {
                    pnlMostrarAnimal.Visible = false;
                }
                if (dgvMostrarAnimal.Visible == false)
                {
                    dgvMostrarAnimal.Visible = true;
                    txtPesquisarAnimal.Text = "";
                }



            }

        }

        private void guna2ShadowPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvMostrarProprietario01_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {





        }

        private void dgvMostrarFuncionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNomeFuncionario.Text = dgvMostrarFuncionario.Rows[e.RowIndex].Cells["Nome Completo"].Value.ToString();
            txtEspecialidade.Text = dgvMostrarFuncionario.Rows[e.RowIndex].Cells["Especialidade"].Value.ToString();
            txtCodFuncionario.Text = dgvMostrarFuncionario.Rows[e.RowIndex].Cells["Código do Veterinário"].Value.ToString();
            if (pnlMostrarFuncionario.Visible == true)
            {
                pnlMostrarFuncionario.Visible = false;
                txtPesquisarFuncionario.Text = "";
            }
        }
        public void mostrarConsultasAgendadas(int cod)
        {
            DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCadastarConsultaAgendada bll = new BLLCadastarConsultaAgendada(conexao);
            dgvMostrarConsultasAgendadas.DataSource = bll.mostrarConsultasAgendadasExame(cod);

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
                    // Verificar se a célula contém um valor
                    if (row.Cells["Data Marcada"].Value != null)
                    {
                        // Tentar converter o valor da célula para DateTime
                        if (DateTime.TryParse(row.Cells["Data Marcada"].Value.ToString(), out DateTime dataMarcada))
                        {
                            // Comparar a data sem considerar a hora
                            if (dataMarcada.Date == teste)
                            {
                                row.Cells["Data Marcada"].Style.BackColor = Color.LightGreen; // Definir a cor de fundo da célula como verde
                            }
                        }
                    }
                }



            }
            catch (Exception ex)
            {

                Debug.WriteLine($"erro ao comparar as datas:{ex.Message}");
            }

        }


        private void txtPesquisarMarcacao_TextChanged(object sender, EventArgs e)
        {

            txtPesquisarFuncionario.Text = "";
            if (string.IsNullOrWhiteSpace(txtPesquisarAgendamento.Text) || string.IsNullOrEmpty(txtPesquisarAgendamento.Text))
            {
                if (pnlMostrarConsultaAgendada.Visible == true)
                {
                    pnlMostrarConsultaAgendada.Visible = false;
                }

            }
            else
            {
                if (int.TryParse(txtPesquisarAgendamento.Text, out int codigo))
                {
                    if (pnlMostrarConsultaAgendada.Visible == false)
                    {
                        pnlMostrarConsultaAgendada.Visible = true;

                        mostrarConsultasAgendadas(codigo);
                    }
                }
            }
        }

        private void dgvMostrarConsultasAgendadas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtenha os valores das células do DataGridView
                string codigo = dgvMostrarConsultasAgendadas.Rows[e.RowIndex].Cells["Código"].Value.ToString();
                string codigoAnimal = dgvMostrarConsultasAgendadas.Rows[e.RowIndex].Cells["Código Animal"].Value.ToString();
                string codigoVeterinario = dgvMostrarConsultasAgendadas.Rows[e.RowIndex].Cells["Código Veterinário"].Value.ToString();
                string nomeVeterinario = dgvMostrarConsultasAgendadas.Rows[e.RowIndex].Cells["Veterinário"].Value.ToString();
                string dataMarcada = dgvMostrarConsultasAgendadas.Rows[e.RowIndex].Cells["Data Marcada"].Value.ToString();
                string tipo = dgvMostrarConsultasAgendadas.Rows[e.RowIndex].Cells["Tipo"].Value.ToString();
                string situacao = dgvMostrarConsultasAgendadas.Rows[e.RowIndex].Cells["Situação"].Value.ToString();
                string gravidade = dgvMostrarConsultasAgendadas.Rows[e.RowIndex].Cells["Gravidade"].Value.ToString();
                string inicio = dgvMostrarConsultasAgendadas.Rows[e.RowIndex].Cells["Início"].Value.ToString();
                string fim = dgvMostrarConsultasAgendadas.Rows[e.RowIndex].Cells["Fim"].Value.ToString();
                string contacto = dgvMostrarConsultasAgendadas.Rows[e.RowIndex].Cells["Contacto"].Value.ToString();
                string duracao = dgvMostrarConsultasAgendadas.Rows[e.RowIndex].Cells["Duração(minutos)"].Value.ToString();
                string periodo = dgvMostrarConsultasAgendadas.Rows[e.RowIndex].Cells["Período"].Value.ToString();
                string diasRestante = dgvMostrarConsultasAgendadas.Rows[e.RowIndex].Cells["Dias Restante"].Value.ToString();

                // Crie um DataTable com as colunas desejadas
                DataTable dt = new DataTable();
                dt.Columns.Add("Código");
                dt.Columns.Add("Código Animal");
                dt.Columns.Add("Código Veterinário");
                dt.Columns.Add("Veterinário");
                dt.Columns.Add("Data Marcada");
                dt.Columns.Add("Tipo");
                dt.Columns.Add("Situação");
                dt.Columns.Add("Gravidade");
                dt.Columns.Add("Início");
                dt.Columns.Add("Fim");
                dt.Columns.Add("Contacto");
                dt.Columns.Add("Duração(minutos)");
                dt.Columns.Add("Período");
                dt.Columns.Add("Dias Restante");
               

                //criacao de um datatable

                // Adicione uma nova linha ao DataTable
                DataRow novaLinha = dt.NewRow();
                novaLinha["Código"] = codigo;
                novaLinha["Código Animal"] =codigoAnimal;
                novaLinha["Código Veterinário"] = codigoVeterinario;
                novaLinha["Veterinário"] = nomeVeterinario;
                novaLinha["Data Marcada"] = dataMarcada;
                novaLinha["Tipo"] = tipo;
                novaLinha["Situação"] = situacao;
                novaLinha["Gravidade"] = gravidade;
                novaLinha["Início"] = inicio;
                novaLinha["Fim"] = fim;
                novaLinha["Contacto"] = contacto;
                novaLinha["Duração(minutos)"] = duracao;
                novaLinha["Período"] = periodo;
                novaLinha["Dias Restante"] = diasRestante;
                dt.Rows.Add(novaLinha);
                //atribuicao de alguns valores no combobox
                cmbStatusExame.Text = situacao;
                cmbTipoExame.Text = tipo;
                //atribuicao dos valores no outro datagriview
                dgvDadosMarcacao.DataSource = dt;
                // Permitir que as colunas sejam redimensionadas pelos usuários
                dgvDadosMarcacao.AllowUserToResizeColumns = true;

                // Ajustar o tamanho das colunas automaticamente para exibir todo o conteúdo
                dgvDadosMarcacao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                // Configurar o DataGridView para quebrar as linhas
                dgvDadosMarcacao.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

                // Ajustar o estilo do cabeçalho para que possa envolver o texto
                foreach (DataGridViewColumn column in dgvDadosMarcacao.Columns)
                {
                    column.HeaderCell.Style.WrapMode = DataGridViewTriState.True;
                }

                // Definir altura das linhas para acomodar o conteúdo completo
                dgvDadosMarcacao.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);

                // Definir o tamanho das linhas do cabeçalho
                dgvDadosMarcacao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                dgvDadosMarcacao.ColumnHeadersHeight = 40; // Ajuste o valor conforme desejado

                // Aumentar o tamanho das outras linhas
                dgvDadosMarcacao.RowTemplate.Height = 30; // Ajuste o valor conforme desejado para outras linhas

                // Adicionar diferença visual na cor das linhas
                dgvDadosMarcacao.RowsDefaultCellStyle.BackColor = Color.LightGray;
                dgvDadosMarcacao.AlternatingRowsDefaultCellStyle.BackColor = Color.White;

               
                // Esconda o painel se estiver visível
                if (pnlMostrarConsultaAgendada.Visible == true)
                {
                    pnlMostrarConsultaAgendada.Visible = false;
                }
               


            }
    }
}
}
