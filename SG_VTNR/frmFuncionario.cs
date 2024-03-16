using BLL;
using DAL;
using Ferramenta;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SG_VTNR
{
    public partial class frmFuncionario : Form
    {
        private string foto;
        public frmFuncionario()
        {
            InitializeComponent();
        }
        private void LimparCampos()
        {
            txtCodigo.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtSobrenome.Text = string.Empty;
            txtApelido.Text = string.Empty;
            txtNomePia.Text = string.Empty;
            txtNomeMae.Text = string.Empty;
            cmbCargo.SelectedIndex = -1;
            txtSalario.Text = string.Empty;
            dataContratacao.Value = DateTime.Today;
            dataNascimento.Value = DateTime.Today;
            cmbTipoDocumento.SelectedIndex = -1;
            dataEmissao.Value = DateTime.Today;
            DataExpiracaoBI.Value = DateTime.Today;
            txtNacionalidade.Text = string.Empty;
            pctProprietario = null;
            cmbGrauAcademico.SelectedIndex = -1;
            cmbEstadoCivil.SelectedIndex = -1;
            txtObs.Text = string.Empty;
            cbmSexo.SelectedIndex = -1;
            txtNumIdentificacao.Text = string.Empty;
            txtCodeEndereco.Text = string.Empty;
        }

        public void PesquisarFuncionariosComChave()
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLFuncionario bll = new BLLFuncionario(cx);
            dgvDadosFuncionario.DataSource = bll.PesquisarFuncionariosComChave(txtPesquisarFuncionario.Text);

            // Permitir que as colunas sejam redimensionadas pelos usuários
            dgvDadosFuncionario.AllowUserToResizeColumns = true;

            // Ajustar o tamanho das colunas automaticamente para exibir todo o conteúdo
            dgvDadosFuncionario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // Configurar o DataGridView para quebrar as linhas
            dgvDadosFuncionario.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // Ajustar o estilo do cabeçalho para que possa envolver o texto
            foreach (DataGridViewColumn column in dgvDadosFuncionario.Columns)
            {
                column.HeaderCell.Style.WrapMode = DataGridViewTriState.True;
            }

            // Definir altura das linhas para acomodar o conteúdo completo
            dgvDadosFuncionario.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);

            // Definir o tamanho das linhas do cabeçalho
            dgvDadosFuncionario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDadosFuncionario.ColumnHeadersHeight = 40; // Ajuste o valor conforme desejado

            // Aumentar o tamanho das outras linhas
            dgvDadosFuncionario.RowTemplate.Height = 30; // Ajuste o valor conforme desejado para outras linhas

            // Adicionar diferença visual na cor das linhas
            dgvDadosFuncionario.RowsDefaultCellStyle.BackColor = Color.LightGray;
            dgvDadosFuncionario.AlternatingRowsDefaultCellStyle.BackColor = Color.White;



        }
        public void ExibirTodosFuncionarios()
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLFuncionario bll = new BLLFuncionario(cx);
            dgvDadosFuncionario.DataSource = bll.ExibirTodosFuncionarios();

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                ModeloFuncionario modelo = new ModeloFuncionario();
                modelo.Nome = txtNome.Text;
                modelo.Sobrenome = txtSobrenome.Text;
                modelo.Apelido = txtApelido.Text;
                modelo.NomePai = txtNomePia.Text;
                modelo.NomeMae = txtNomeMae.Text;
                modelo.Cargo = cmbCargo.Text;
                modelo.Salario = Convert.ToDecimal(txtSalario.Text);
                modelo.DataContratacao = Convert.ToDateTime(dataContratacao.Text);
                modelo.DataNascimento = Convert.ToDateTime(dataNascimento.Text);
                modelo.TipoDocumento1 = cmbTipoDocumento.Text;
                modelo.DataEmissaoBI = Convert.ToDateTime(dataEmissao.Text);
                modelo.DataExpiracaoBI = Convert.ToDateTime(DataExpiracaoBI.Text);
                modelo.Nacionalidade = txtNacionalidade.Text;
                modelo.CarregaImage(this.foto);
                modelo.GrauAcademico = cmbGrauAcademico.Text;
                modelo.EstadoCivil = cmbEstadoCivil.Text;
                modelo.Observacao = txtObs.Text;
                modelo.Sexo = cbmSexo.Text;
                modelo.NumIdentificacao = txtNumIdentificacao.Text;
                modelo.EnderecoID = Convert.ToInt16(txtCodeEndereco.Text);
                modelo.usuarioID = SessaoUsuario.Session.Instance.UsuID;

                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLFuncionario bll = new BLLFuncionario(cx);
                bll.IncluirFuncionario(modelo);
                MessageBox.Show("Código: " + modelo.FuncionarioID.ToString() + "\n Funcionário Cadastrado com Sucesso!");
                ExibirTodosFuncionarios();

                frmRelatorioFuncionario frm = new frmRelatorioFuncionario(modelo.FuncionarioID, modelo.usuarioID);
                frm.ShowDialog();
                LimparCampos();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possivel Realizar a Operação!!! \n\nContate o Administrador do Sistema!!!\n\nErro Ocorrido:" + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }




        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (pnlCadastrar.Visible == false)
            {
                pnlCadastrar.Visible = true;
                alteraBotoes(1, perInserir, perAlterar, perExcluir, perImprimir);
            }
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            pnlCadastrar.Visible = false;

        }

        private void frmFuncionario_Load(object sender, EventArgs e)
        {
            ExibirTodosFuncionarios();

        }

        private void dgvDadosFuncionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvDadosFuncionario.Columns[e.ColumnIndex].Name;


            if (colName == "ColDeletar")
            {
                int col = Convert.ToInt32(dgvDadosFuncionario.CurrentRow.Cells["FuncionarioID"].Value);
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLFuncionario bll = new BLLFuncionario(cx);
                if (bll.verificarFuncionarioUsuario(col))
                {
                    MessageBox.Show("Não é possível excluir este Funcionário pois existem Usuários associados a ele.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                try
                {
                    DialogResult d = MessageBox.Show("Desejas realmente excluir este funcionário?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                    if (d.ToString() == "Yes")
                    {
                        bll.EliminarFuncionario(Convert.ToInt32(col));
                        DialogResult = MessageBox.Show("Funcionário eliminado com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        ExibirTodosFuncionarios();
                    }
                }
                catch (Exception)
                {

                    throw;
                }

            }
            if (colName == "colEditar")
            {
                txtCodigo.Text = dgvDadosFuncionario.Rows[e.RowIndex].Cells["FuncionarioID"].Value.ToString();
                txtNome.Text = dgvDadosFuncionario.Rows[e.RowIndex].Cells["Nome"].Value.ToString();
                txtSobrenome.Text = dgvDadosFuncionario.Rows[e.RowIndex].Cells["Sobrenome"].Value.ToString();
                txtApelido.Text = dgvDadosFuncionario.Rows[e.RowIndex].Cells["Apelido"].Value.ToString();
                txtNomePia.Text = dgvDadosFuncionario.Rows[e.RowIndex].Cells["NomePai"].Value.ToString();
                txtNomeMae.Text = dgvDadosFuncionario.Rows[e.RowIndex].Cells["NomeMae"].Value.ToString();
                cmbCargo.Text = dgvDadosFuncionario.Rows[e.RowIndex].Cells["Cargo"].Value.ToString();
                txtSalario.Text = dgvDadosFuncionario.Rows[e.RowIndex].Cells["Salario"].Value.ToString();
                dataContratacao.Text = dgvDadosFuncionario.Rows[e.RowIndex].Cells["DataContratacao"].Value.ToString();
                dataNascimento.Text = dgvDadosFuncionario.Rows[e.RowIndex].Cells["DataNascimento"].Value.ToString();
                cmbTipoDocumento.Text = dgvDadosFuncionario.Rows[e.RowIndex].Cells["TipoDocumento"].Value.ToString();
                txtNumIdentificacao.Text = dgvDadosFuncionario.Rows[e.RowIndex].Cells["NumIdentificacao"].Value.ToString();
                dataEmissao.Text = dgvDadosFuncionario.Rows[e.RowIndex].Cells["DataEmissaoBI"].Value.ToString();
                DataExpiracaoBI.Text = dgvDadosFuncionario.Rows[e.RowIndex].Cells["DataExpiracaoBI"].Value.ToString();
                txtNacionalidade.Text = dgvDadosFuncionario.Rows[e.RowIndex].Cells["Nacionalidade"].Value.ToString();
                cmbEstadoCivil.Text = dgvDadosFuncionario.Rows[e.RowIndex].Cells["EstadoCivil"].Value.ToString();
                //pctProprietario.Text = dgvDadosFuncionario.Rows[e.RowIndex].Cells["foto"].Value.ToString();
                if (dgvDadosFuncionario.Rows[e.RowIndex].Cells["foto"].Value != null)
                {
                    string imagemString = dgvDadosFuncionario.Rows[e.RowIndex].Cells["foto"].Value.ToString();

                    byte[] imagemBytes;
                    try
                    {
                        imagemBytes = Convert.FromBase64String(imagemString);
                    }
                    catch (FormatException)
                    {
                        // Caso a conversão de base64 para bytes falhe, pode tratar aqui, por exemplo, definindo uma imagem padrão ou mostrando uma mensagem de erro.
                        pctProprietario.Image = null; // Define uma imagem padrão ou limpa o controle PictureBox
                        //MessageBox.Show("A imagem fornecida é inválida.");
                        return;
                    }

                    using (MemoryStream ms = new MemoryStream(imagemBytes))
                    {
                        try
                        {
                            Image imagem = Image.FromStream(ms);
                            pctProprietario.Image = imagem;
                        }
                        catch (ArgumentException)
                        {
                            // Se ocorrer um erro ao tentar criar a imagem a partir do MemoryStream, pode tratar aqui (por exemplo, definir uma imagem padrão ou mostrar uma mensagem de erro).
                            //pctProprietario.Image = null; // Define uma imagem padrão ou limpa o controle PictureBox
                            //MessageBox.Show("A imagem fornecida é inválida.");
                        }
                    }
                }
                else
                {
                    pctProprietario.Image = null;
                }


                cmbGrauAcademico.Text = dgvDadosFuncionario.Rows[e.RowIndex].Cells["GrauAcademico"].Value.ToString();
                cmbEstadoCivil.Text = dgvDadosFuncionario.Rows[e.RowIndex].Cells["EstadoCivil"].Value.ToString();
                txtObs.Text = dgvDadosFuncionario.Rows[e.RowIndex].Cells["Observacao"].Value.ToString();
                txtCodeEndereco.Text = dgvDadosFuncionario.Rows[e.RowIndex].Cells["EnderecoID"].Value.ToString();
                cbmSexo.Text = dgvDadosFuncionario.Rows[e.RowIndex].Cells["sexo"].Value.ToString();
                alteraBotoes(3, perInserir, perAlterar, perExcluir, perImprimir);

                //codigoProp =Convert.ToInt32( txtIDProp.Text = dgvExibirAnimal.Rows[e.RowIndex].Cells["ProprietarioID"].Value.ToString());
                //txtNomeProp.Text = BuscarNomeProp();

                if (pnlCadastrar.Visible == false)
                {
                    //alteraBotoes(3, perInserir, perAlterar, perExcluir, perImprimir);
                    pnlCadastrar.Visible = true;
                }

            } else if (colName == "colImprimir")
            {
                int codFuncionario = Convert.ToInt32(dgvDadosFuncionario.Rows[e.RowIndex].Cells["FuncionarioID"].Value.ToString());
                int usuarioID = SessaoUsuario.Session.Instance.UsuID;
                var frm = new frmRelatorioFuncionario(codFuncionario, usuarioID);
                frm.ShowDialog();

            }
        }

        private void txtPesquisarFuncionario_TextChanged(object sender, EventArgs e)
        {
            PesquisarFuncionariosComChave();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {

                ModeloFuncionario modelo = new ModeloFuncionario();
                modelo.FuncionarioID = Convert.ToInt32(txtCodigo.Text);
                modelo.Nome = txtNome.Text;
                modelo.Sobrenome = txtSobrenome.Text;
                modelo.Apelido = txtApelido.Text;
                modelo.NomePai = txtNomePia.Text;
                modelo.NomeMae = txtNomeMae.Text;
                modelo.Cargo = cmbCargo.Text;
                modelo.Salario = Convert.ToDecimal(txtSalario.Text);
                modelo.DataContratacao = Convert.ToDateTime(dataContratacao.Text);
                modelo.DataNascimento = Convert.ToDateTime(dataNascimento.Text);
                modelo.TipoDocumento1 = cmbTipoDocumento.Text;
                modelo.DataEmissaoBI = Convert.ToDateTime(dataEmissao.Text);
                modelo.DataExpiracaoBI = Convert.ToDateTime(DataExpiracaoBI.Text);
                modelo.Nacionalidade = txtNacionalidade.Text;
                modelo.CarregaImage(this.foto);
                modelo.GrauAcademico = cmbGrauAcademico.Text;
                modelo.EstadoCivil = cmbEstadoCivil.Text;
                modelo.Observacao = txtObs.Text;
                modelo.Sexo = cbmSexo.Text;
                modelo.NumIdentificacao = txtNumIdentificacao.Text;
                modelo.EnderecoID = Convert.ToInt16(txtCodeEndereco.Text);
                modelo.usuarioID = SessaoUsuario.Session.Instance.UsuID;
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLFuncionario bll = new BLLFuncionario(cx);
                bll.ActualizarFuncionario(modelo);
                MessageBox.Show("Código: " + modelo.FuncionarioID.ToString() + "\n Dados do Funcionário Actualizados com Sucesso!", "Confirmação", MessageBoxButtons.OK);
                ExibirTodosFuncionarios();

                var frm = new frmRelatorioFuncionario(modelo.FuncionarioID, modelo.usuarioID);
                frm.ShowDialog();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possivel Realizar a Operação!!! \n\nContate o Administrador do Sistema!!!\n\nErro Ocorrido:" + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
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

                // Desativação de todos os campos do formulário
                txtNome.Enabled = false;
                txtSobrenome.Enabled = false;
                txtApelido.Enabled = false;
                txtNomePia.Enabled = false;
                txtNomeMae.Enabled = false;
                cmbCargo.Enabled = false;
                txtSalario.Enabled = false;
                dataContratacao.Enabled = false;
                dataNascimento.Enabled = false;
                cmbTipoDocumento.Enabled = false;
                dataEmissao.Enabled = false;
                DataExpiracaoBI.Enabled = false;
                txtNacionalidade.Enabled = false;
                //pctProprietario.Enabled = false;
                cmbGrauAcademico.Enabled = false;
                cmbEstadoCivil.Enabled = false;
                txtObs.Enabled = false;
                cbmSexo.Enabled = false;
                txtNumIdentificacao.Enabled = false;
                txtCodeEndereco.Enabled = false;
                btnExcluir.Enabled = false;
                btnAdicionarfoto.Enabled = false;
                btnAdcEndereco.Enabled = false;
                txtMostrarEndereco.Enabled = false;

            }

            if (op == 2)
            {
                btnEditar.Enabled = false;
                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;


                txtNome.Enabled = true;
                txtSobrenome.Enabled = true;
                txtApelido.Enabled = true;
                txtNomePia.Enabled = true;
                txtNomeMae.Enabled = true;
                cmbCargo.Enabled = true;
                txtSalario.Enabled = true;
                dataContratacao.Enabled = true;
                dataNascimento.Enabled = true;
                cmbTipoDocumento.Enabled = true;
                dataEmissao.Enabled = true;
                DataExpiracaoBI.Enabled = true;
                txtNacionalidade.Enabled = true;
                ///pctProprietario.Enabled = true;
                cmbGrauAcademico.Enabled = true;
                cmbEstadoCivil.Enabled = true;
                txtObs.Enabled = true;
                cbmSexo.Enabled = true;
                txtNumIdentificacao.Enabled = true;
                txtCodeEndereco.Enabled = true;
                btnExcluir.Enabled = true;
                btnAdicionarfoto.Enabled = true;
                btnAdcEndereco.Enabled = true;
                txtMostrarEndereco.Enabled = true;

            }
            if (op == 3)
            {
                //btnEditar.Enabled = perAlterar;
                btnEditar.Enabled = true;
                btnCancelar.Enabled = true;
                btnNovo.Enabled = true;


                // Desativação de todos os campos do formulário
                txtNome.Enabled = true;
                txtSobrenome.Enabled = true;
                txtApelido.Enabled = true;
                txtNomePia.Enabled = true;
                txtNomeMae.Enabled = true;
                cmbCargo.Enabled = true;
                txtSalario.Enabled = true;
                dataContratacao.Enabled = true;
                dataNascimento.Enabled = true;
                cmbTipoDocumento.Enabled = true;
                dataEmissao.Enabled = true;
                DataExpiracaoBI.Enabled = true;
                //txtNacionalidade.Enabled = true;
                //pctProprietario.Enabled = true;
                cmbGrauAcademico.Enabled = true;
                cmbEstadoCivil.Enabled = true;
                txtObs.Enabled = true;
                cbmSexo.Enabled = true;
                txtNumIdentificacao.Enabled = true;
                txtCodeEndereco.Enabled = true;
                btnExcluir.Enabled = true;
                btnAdicionarfoto.Enabled = true;
                btnAdcEndereco.Enabled = true;
                txtMostrarEndereco.Enabled = true;

            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            alteraBotoes(2, perInserir, perAlterar, perExcluir, perImprimir);
            LimparCampos();
        }
        public void AtualizarEndereco(string provincia, string municipio, string bairro, string rua)
        {
            txtMostrarEndereco.Text = $"{provincia} {municipio} {bairro} {rua}";
        }
        private void btnAdcEndereco_Click(object sender, EventArgs e)
        {
            frmAdicionarEndereco frm = new frmAdicionarEndereco();
            frm.vindoDE = "Funcionario";
            frm.ShowDialog();
        }
        public void exibirEndereco()
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLProprietario bll = new BLLProprietario(cx);
            dgvMostraEndereco.DataSource = bll.pesquisarEndereco(txtMostrarEndereco.Text);

            // Permitir que as colunas sejam redimensionadas pelos usuários
            dgvMostraEndereco.AllowUserToResizeColumns = true;

            // Ajustar o tamanho das colunas automaticamente para exibir todo o conteúdo
            dgvMostraEndereco.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // Configurar o DataGridView para quebrar as linhas
            dgvMostraEndereco.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // Ajustar o estilo do cabeçalho para que possa envolver o texto
            foreach (DataGridViewColumn column in dgvMostraEndereco.Columns)
            {
                column.HeaderCell.Style.WrapMode = DataGridViewTriState.True;
            }

            // Definir altura das linhas para acomodar o conteúdo completo
            dgvMostraEndereco.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);

            // Definir o tamanho das linhas do cabeçalho
            dgvMostraEndereco.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMostraEndereco.ColumnHeadersHeight = 40; // Ajuste o valor conforme desejado

            // Aumentar o tamanho das outras linhas
            dgvMostraEndereco.RowTemplate.Height = 30; // Ajuste o valor conforme desejado para outras linhas

            // Adicionar diferença visual na cor das linhas
            dgvMostraEndereco.RowsDefaultCellStyle.BackColor = Color.LightGray;
            dgvMostraEndereco.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
        }
        private void txtMostrarEndereco_TextChanged(object sender, EventArgs e)
        {
         
           if (string.IsNullOrEmpty(txtMostrarEndereco.Text) || string.IsNullOrWhiteSpace(txtMostrarEndereco.Text))
            {
                pnlMostrarEndereco.Visible = false;
            }
            else
            {
                if (pnlMostrarEndereco.Visible == false)
                {
                    pnlMostrarEndereco.Visible = true;
                    exibirEndereco();
                }
            }

        }

        private void dgvMostraEndereco_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodeEndereco.Text = Convert.ToString(dgvMostraEndereco.Rows[e.RowIndex].Cells["EnderecoID"].Value);
            string bairro = Convert.ToString(dgvMostraEndereco.Rows[e.RowIndex].Cells["Bairro"].Value);
            string cidade = Convert.ToString(dgvMostraEndereco.Rows[e.RowIndex].Cells["Cidade"].Value);
            string rua = Convert.ToString(dgvMostraEndereco.Rows[e.RowIndex].Cells["Rua"].Value);
            string provincia = Convert.ToString(dgvMostraEndereco.Rows[e.RowIndex].Cells["Provincia"].Value);
            string municipio = Convert.ToString(dgvMostraEndereco.Rows[e.RowIndex].Cells["Municipio"].Value);
            AtualizarEndereco(provincia, municipio, bairro, rua);
            if (pnlMostrarEndereco.Visible == true)
            {
                pnlMostrarEndereco.Visible = false;
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void cmbGrauAcademico_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    } 
    }
    

    

