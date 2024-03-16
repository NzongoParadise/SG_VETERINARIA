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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SG_VTNR
{
    public partial class frmProprietario : Form
    {
        public string foto;
        public string teste;
        public frmProprietario()
        {
            InitializeComponent();
            exibir();
            txtApelido.Text = "teste---" ;
            exibirEndereco();
         
        }
        #region permicao de ativar os botoes
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

                txtNome.Enabled = false;
                txtSobrenome.Enabled = false;
                cbmGenero.Enabled = false;
                txtNumIdentificacao.Enabled = false;
                dataNascimento.Enabled = false;
                //btnAdicionarfoto.Enabled = false;
                //btnExcluir.Enabled = false;
                btnAdcEndereco.Enabled = false;
                txtMostrarEndereco.Enabled = false;
                txtApelido.Enabled = false;
                txtCodigo.Enabled = false;
                //txtComuna.Enabled = false;
                //txtMunicipio.Enabled = false;
                txtNomePia.Enabled = false;
                txtObs.Enabled = false;
                txtNomeMae.Enabled = false;
                txtCodeEndereco.Enabled = false;
                dataEmissao.Enabled = false;
                DataValidade.Enabled = false;
                txtNacionalidade.Enabled = false;
                cmbTipoDoc.Enabled = false;

            }

            if (op == 2)
            {
                btnEditar.Enabled = false;
                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;

                txtNome.Enabled = true;
                cmbTipoDoc.Enabled = true;
                txtSobrenome.Enabled = true;
                cbmGenero.Enabled = true;
                txtNumIdentificacao.Enabled = true;
                dataNascimento.Enabled = true;
                //btnAdicionarfoto.Enabled = true;
                //btnExcluir.Enabled = true;
                btnAdcEndereco.Enabled = true;
                txtMostrarEndereco.Enabled = true;
                txtApelido.Enabled = true;
                txtCodigo.Enabled = false;
                //txtComuna.Enabled = true;
                //txtMunicipio.Enabled = true;
                txtNomePia.Enabled = true;
                txtObs.Enabled = true;
                txtNomeMae.Enabled = true;
                txtCodeEndereco.Enabled = true;
                dataEmissao.Enabled = true;
                DataValidade.Enabled = true;
                txtNacionalidade.Enabled = true;
            }
            if (op == 3)
            {
                //btnEditar.Enabled = perAlterar;
                btnEditar.Enabled = true;
                btnCancelar.Enabled = true;
                btnNovo.Enabled = true;

                txtCodigo.Enabled = false;
                txtNome.Enabled = true;
                cmbTipoDoc.Enabled = true;
                txtSobrenome.Enabled = true;
                cbmGenero.Enabled = true;
                txtNumIdentificacao.Enabled = true;
                dataNascimento.Enabled = true;
                //btnAdicionarfoto.Enabled = true;
                //btnExcluir.Enabled = true;
                btnAdcEndereco.Enabled = true;
                txtMostrarEndereco.Enabled = true;
                txtApelido.Enabled = true;
                txtCodigo.Enabled = false;
                //txtComuna.Enabled = true;
                //txtMunicipio.Enabled = true;
                txtNomePia.Enabled = true;
                txtObs.Enabled = true;
                txtNomeMae.Enabled = true;
                txtCodeEndereco.Enabled = true;
                dataEmissao.Enabled = true;
                DataValidade.Enabled = true;
                txtNacionalidade.Enabled = true;

            }

        }
        #endregion fim permicao activar botos
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (pnlCadastrar.Visible == false)
            {
                pnlCadastrar.Visible = true;
             
                LimparTela();
                //guna2Button1.Enabled = false;
                //dgvDados.Enabled = false;
                //txtPesquisar.Enabled = false;
            }
        }
        public void AtualizarEndereco(string provincia, string municipio, string bairro, string rua)
        {
            txtMostrarEndereco.Text = $"{provincia} {municipio} {bairro} {rua}";
           // txtApelido.Text = "teste"+provincia;
            //   MessageBox.Show("vou mostrar a provincia taqui" + provincia);
        }
        
        
        private void guna2Button7_Click(object sender, EventArgs e)
        {
            if (pnlCadastrar.Visible == true)
            {
                alteraBotoes(1, perInserir, perAlterar, perExcluir, perImprimir);
                pnlCadastrar.Visible = false;
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            

        }
        private void LimparTela()
        {
            txtCodigo.Clear();
            txtApelido.Clear();
            txtCodigo.Clear();
            //txtComuna.Clear();
            //txtMunicipio.Clear();
            txtNomePia.Clear();
            cbmGenero.SelectedValue = "-1";
            cmbTipoDoc.SelectedValue = "-1";
            txtObs.Clear();
            txtNomeMae.Clear();
            txtCodeEndereco.Clear();
            txtNacionalidade.Clear();
            txtNome.Clear();
            txtNumIdentificacao.Clear();
            txtSobrenome.Clear();
            txtMostrarEndereco.Clear();

        }
        private void frmProprietario_Load(object sender, EventArgs e)
        {

            alteraBotoes(1, perInserir, perAlterar, perExcluir, perImprimir);
        }
        public void CarregarTituloDgv()
        {

        }
        public void exibir()
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLProprietario bll = new BLLProprietario(cx);
            dgvDados.DataSource = bll.Localizar(txtPesquisar.Text);

            // Permitir que as colunas sejam redimensionadas pelos usuários
            dgvDados.AllowUserToResizeColumns = true;

            // Ajustar o tamanho das colunas automaticamente para exibir todo o conteúdo
            dgvDados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // Configurar o DataGridView para quebrar as linhas
            dgvDados.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // Ajustar o estilo do cabeçalho para que possa envolver o texto
            foreach (DataGridViewColumn column in dgvDados.Columns)
            {
                column.HeaderCell.Style.WrapMode = DataGridViewTriState.True;
            }

            // Definir altura das linhas para acomodar o conteúdo completo
            dgvDados.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);

            // Definir o tamanho das linhas do cabeçalho
            dgvDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDados.ColumnHeadersHeight = 40; // Ajuste o valor conforme desejado

            // Aumentar o tamanho das outras linhas
            dgvDados.RowTemplate.Height = 30; // Ajuste o valor conforme desejado para outras linhas

            // Adicionar diferença visual na cor das linhas
            dgvDados.RowsDefaultCellStyle.BackColor = Color.LightGray;
            dgvDados.AlternatingRowsDefaultCellStyle.BackColor = Color.White;



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
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvDados.Columns[e.ColumnIndex].Name;
            if (colName == "colEditar")
            {
                txtCodigo.Text = dgvDados.Rows[e.RowIndex].Cells["ProprietarioID"].Value.ToString();
                txtNome.Text = dgvDados.Rows[e.RowIndex].Cells["Nome"].Value.ToString();
                cbmGenero.Text = dgvDados.Rows[e.RowIndex].Cells["sexo"].Value.ToString();
                txtCodeEndereco.Text = dgvDados.Rows[e.RowIndex].Cells["EnderecoID"].Value.ToString();
                txtSobrenome.Text = dgvDados.Rows[e.RowIndex].Cells["sobrenome"].Value.ToString();
                cmbTipoDoc.Text = dgvDados.Rows[e.RowIndex].Cells["TipoDocumento"].Value.ToString();
                txtNumIdentificacao.Text = dgvDados.Rows[e.RowIndex].Cells["NumIdent"].Value.ToString();
                txtApelido.Text = dgvDados.Rows[e.RowIndex].Cells["apelido"].Value.ToString();
                dataEmissao.Text = dgvDados.Rows[e.RowIndex].Cells["DataEmisao"].Value.ToString();
                DataValidade.Text = dgvDados.Rows[e.RowIndex].Cells["DataEmisao"].Value.ToString();
                //txtMunicipio.Text = dgvDados.Rows[e.RowIndex].Cells["Municipio"].Value.ToString();
                //txtComuna.Text = dgvDados.Rows[e.RowIndex].Cells["Comuna"].Value.ToString();
                txtNomeMae.Text = dgvDados.Rows[e.RowIndex].Cells["NomeMae"].Value.ToString();
                txtNomePia.Text = dgvDados.Rows[e.RowIndex].Cells["NomePai"].Value.ToString();
                txtNacionalidade.Text = dgvDados.Rows[e.RowIndex].Cells["Nacionalidade"].Value.ToString();
                txtObs.Text = dgvDados.Rows[e.RowIndex].Cells["descricao"].Value.ToString();


                if (pnlCadastrar.Visible == false)
                {
                    pnlCadastrar.Visible = true;
                    alteraBotoes(3, perInserir, perAlterar, perExcluir, perImprimir);
                }
            }
            else if (colName == "ColDeletar")
            {
                int col = Convert.ToInt32(dgvDados.CurrentRow.Cells["ProprietarioID"].Value);
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLProprietario bll = new BLLProprietario(cx);
                //esta verificacao serve para detetar se este proprietario testa vinculado a um animal ou nao
                //caso sim nao sera possivel elimnai o proprietario para respeitar a integridade referencial
                if (bll.verificarProprietarioAnimal(col))
                {
                    MessageBox.Show("Não é possível excluir este proprietário pois existem animais associados a ele.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                try
                {
                    DialogResult d = MessageBox.Show("desejas realmente excluir os dados?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                    if (d.ToString() == "Yes")
                    {
                          bll.Excluir(Convert.ToInt32(col));
                          exibir();
                       
                      }
                }
                catch (Exception)
                {

                    throw;
                }
            }else if (colName=="colImprimir")
            {
                int codProp = Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells["ProprietarioID"].Value.ToString());
                int usuarioID = SessaoUsuario.Session.Instance.UsuID;
                frmRelatorioProprietario frm = new frmRelatorioProprietario(codProp,usuarioID);
                frm.ShowDialog();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                ModeloProprietario modelo = new ModeloProprietario();
                modelo.Nome = txtNome.Text;
                modelo.Sobrenome = txtSobrenome.Text;
                modelo.Apelido = txtApelido.Text;
                modelo.NomePai = txtNomePia.Text;
                modelo.EnderecoID = Convert.ToInt32(txtCodeEndereco.Text);
                modelo.NomeMae = txtNomeMae.Text;
                modelo.NumIdnt = txtNumIdentificacao.Text;
                modelo.Tipodocumento = cmbTipoDoc.Text;
                modelo.Descricao = txtObs.Text;
                modelo.DataEmissao = Convert.ToDateTime(dataEmissao.Text);
                modelo.Datanascimento = Convert.ToDateTime(dataNascimento.Text);
                modelo.Sexo = cbmGenero.Text;
                modelo.Nacionalidade = txtNacionalidade.Text;
            
                modelo.usuarioID = SessaoUsuario.Session.Instance.UsuID;
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLProprietario bll = new BLLProprietario(cx);
                //chamada de inserir os dados
                bll.Incluir(modelo);
                MessageBox.Show(modelo.PropietarioId.ToString() + "\n Proprietário Cadastrado com Sucesso!");
                //ethis.Alert("Código: " + modelo.PropietarioId.ToString() + "\n Cadastrado com sucesso!", frmAlert.enmType.Success);
                frmRelatorioProprietario frm = new frmRelatorioProprietario(modelo.PropietarioId, modelo.usuarioID);
                frm.ShowDialog();
                LimparTela();
                exibir();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possivel Realizar a Operação!!! \n\nContate o Administrador do Sistema!!!\n\nErro Ocorrido:" + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
            ModeloProprietario modelo = new ModeloProprietario();
            modelo.PropietarioId = Convert.ToInt32(txtCodigo.Text);
            modelo.Nome = txtNome.Text;
            modelo.Sobrenome = txtSobrenome.Text;
            modelo.Apelido = txtApelido.Text;
            modelo.NomePai = txtNomePia.Text;
            modelo.EnderecoID = Convert.ToInt32(txtCodeEndereco.Text);
            modelo.NomeMae = txtNomeMae.Text;
            modelo.NumIdnt = txtNumIdentificacao.Text;
            modelo.Tipodocumento = Convert.ToString(cmbTipoDoc.Text);
            modelo.Descricao = txtObs.Text;
            modelo.DataEmissao = Convert.ToDateTime(dataEmissao.Text);
            modelo.Datanascimento = Convert.ToDateTime(dataNascimento.Text);
            modelo.Genero = cbmGenero.Text;
            modelo.Nacionalidade = txtNacionalidade.Text;

            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLProprietario bll = new BLLProprietario(cx);
            //Alterar os dados
            bll.UpdateProprietario(modelo);

            MessageBox.Show("Código:"+modelo.PropietarioId.ToString()+"\n Dados Altedos com sucesso!","Confirmação", MessageBoxButtons.OK);

            int usuarioID = SessaoUsuario.Session.Instance.UsuID;
            frmRelatorioProprietario frm = new frmRelatorioProprietario(modelo.PropietarioId, usuarioID);
            frm.ShowDialog();

            LimparTela();
            exibir();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possivel Realizar a Operação!!! \n\nContate o Administrador do Sistema!!!\n\nErro Ocorrido:" + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnNovo_Click_1(object sender, EventArgs e)
        {

            alteraBotoes(2, perInserir, perAlterar, perExcluir, perImprimir);
            LimparTela();
        }

        //private void btnAdicionarfoto_Click(object sender, EventArgs e)
        //{
        //    OpenFileDialog openfile = new OpenFileDialog();
        //    openfile.Filter = "arquivo de imagem|*.jpg;*jphjieg;*png;.gif|todos aquivos|*.*";
        //    if (openfile.ShowDialog()==DialogResult.OK)
        //    {
        //        string caminhodaImagem = openfile.FileName;
        //        pctProprietario.Image = new Bitmap(caminhodaImagem);

        //        pctProprietario.SizeMode = PictureBoxSizeMode.Zoom;
        //    }

        //}

        //private void btnExcluir_Click(object sender, EventArgs e)
        //{
        //    this.foto = "";
        //    pctProprietario.Image = null;
        //}

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            exibir();

        }

        private void btnAdcEndereco_Click(object sender, EventArgs e)
        {
            frmAdicionarEndereco frm = new frmAdicionarEndereco();
            frm.vindoDE = "Proprietario";
            frm.ShowDialog();
        }

        private void pnlCadastrar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtMostrarEndereco_MouseClick(object sender, MouseEventArgs e)
        {
            if (pnlEndereco.Visible == false)
            {
                pnlEndereco.Visible = true;
            }
        }


        private void txtMostrarEndereco_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtMostrarEndereco.Text) || string.IsNullOrWhiteSpace(txtMostrarEndereco.Text))
            {
                pnlEndereco.Visible = false;

                if (pnlEndereco.Visible == true)
                {
                    pnlEndereco.Visible = false;
                }
            }
            else
            {
                if (pnlEndereco.Visible == false)
                {
                    pnlEndereco.Visible = true;
                    exibirEndereco();
                }
            }

        }

        private void dgvEndereco_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodeEndereco.Text = Convert.ToString(dgvMostraEndereco.Rows[e.RowIndex].Cells["EnderecoID"].Value);
            string bairro = Convert.ToString(dgvMostraEndereco.Rows[e.RowIndex].Cells["Bairro"].Value);
            string cidade= Convert.ToString(dgvMostraEndereco.Rows[e.RowIndex].Cells["Cidade"].Value);
            string rua = Convert.ToString(dgvMostraEndereco.Rows[e.RowIndex].Cells["Rua"].Value);
            string provincia = Convert.ToString(dgvMostraEndereco.Rows[e.RowIndex].Cells["Provincia"].Value);
           string municipio=Convert.ToString(dgvMostraEndereco.Rows[e.RowIndex].Cells["Municipio"].Value);
            //txtMostrarEndereco.Text =$"{bairro},{rua},{cidade}";
            AtualizarEndereco(provincia,municipio, bairro,rua);
            if (pnlEndereco.Visible == true)
            {
                pnlEndereco.Visible = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparTela();
            frmRelatorioProprietario frm = new frmRelatorioProprietario(3, 1005);
            frm.ShowDialog();

        }

        private void txtCodeEndereco_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
