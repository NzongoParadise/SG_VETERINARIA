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
    public partial class frmProprietario : Form
    {
        public string foto;
        public frmProprietario()
        {
            InitializeComponent();
            exibir();
            exibirEndereco();
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
                txtComuna.Enabled = false;
                txtMunicipio.Enabled = false;
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
                txtComuna.Enabled = true;
                txtMunicipio.Enabled = true;
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
                btnNovo.Enabled = false;

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
                txtComuna.Enabled = true;
                txtMunicipio.Enabled = true;
                txtNomePia.Enabled = true;
                txtObs.Enabled = true;
                txtNomeMae.Enabled = true;
                txtCodeEndereco.Enabled = true;
                dataEmissao.Enabled = true;
                DataValidade.Enabled = true;
                txtNacionalidade.Enabled = true;

            }

        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (pnlCadastrar.Visible == false)
            {
                pnlCadastrar.Visible = true;
            }
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
            txtComuna.Clear();
            txtMunicipio.Clear();
            txtNomePia.Clear();
            txtObs.Clear();
            txtNomeMae.Clear();
            txtCodeEndereco.Clear();
            txtNacionalidade.Clear();
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
            //CarregarTituloDgv();
            //FormatandoDGV.
        }
        public void exibirEndereco()
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLProprietario bll = new BLLProprietario(cx);
            dgvEndereco.DataSource = bll.LocalizarEndereco(txtMostrarEndereco.Text);
            //CarregarTituloDgv();
            //FormatandoDGV.
        }
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvDados.Columns[e.ColumnIndex].Name;
            if (colName=="colEditar")
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
                
                if (pnlCadastrar.Visible==false)
                {
                    pnlCadastrar.Visible = true;
                    alteraBotoes(3, perInserir, perAlterar, perExcluir, perImprimir);
                }
            }else if (colName == "ColDeletar")
            {
                try
                {
                    DialogResult d = MessageBox.Show("desejas realmente excluir os dados?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                    if (d.ToString()=="Yes")
                    {
                        alteraBotoes(1, perInserir, perAlterar, perExcluir, perImprimir);
                        int col = Convert.ToInt32(dgvDados.CurrentRow.Cells["ProprietarioID"].Value);
                        DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                        BLLProprietario bll = new BLLProprietario(cx);
                        bll.Excluir(Convert.ToInt32(col));
                        exibir();
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                ModeloProprietario modelo = new ModeloProprietario();
                modelo.Nome = txtNome.Text;
                modelo.Sobrenome =txtSobrenome.Text;
                modelo.Apelido = txtApelido.Text;
                modelo.NomePai =txtNomePia.Text;
                modelo.EnderecoID = Convert.ToInt32(txtCodeEndereco.Text);
                modelo.NomeMae = txtNomeMae.Text;
                modelo.NumIdnt= txtNumIdentificacao.Text;
                modelo.Tipodocumento = Convert.ToString((cmbTipoDoc.SelectedValue));
                modelo.Descricao = txtObs.Text;
                modelo.DataEmissao = Convert.ToDateTime(dataEmissao.Text);
                modelo.Datanascimento = Convert.ToDateTime(dataNascimento.Text);
                modelo.Genero=  cbmGenero.Text;
                //modelo.Municipio = txtMunicipio.Text;
                modelo.Nacionalidade = txtNacionalidade.Text;

                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLProprietario bll = new BLLProprietario(cx);
                //inserir os dados
                bll.Incluir(modelo);
                MessageBox.Show(modelo.PropietarioId.ToString()+ "\n Proprietário Cadastrado com Sucesso!");
                //ethis.Alert("Código: " + modelo.PropietarioId.ToString() + "\n Cadastrado com sucesso!", frmAlert.enmType.Success);
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
            //try
            //{
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
                bll.Alterar(modelo);

                MessageBox.Show("alterado com sucesso");

                LimparTela();
                exibir();

            //}
            //catch (Exception erro)
            //{
            //    MessageBox.Show("Não foi possivel Realizar a Operação!!! \n\nContate o Administrador do Sistema!!!\n\nErro Ocorrido:" + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //}
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
            frmEndereco frm = new frmEndereco();
            frm.ShowDialog();
        }

        private void pnlCadastrar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtMostrarEndereco_MouseClick(object sender, MouseEventArgs e)
        {
            if (pnlEndereco.Visible == false)
            {
                pnlEndereco.Visible=true;
            }
        }

        private void txtMostrarEndereco_TextChanged(object sender, EventArgs e)
        {
            exibirEndereco();
        }

        private void dgvEndereco_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodeEndereco.Text = Convert.ToString(dgvEndereco.Rows[e.RowIndex].Cells[0].Value);
            txtMostrarEndereco.Text = Convert.ToString(dgvEndereco.Rows[e.RowIndex].Cells[1].Value);
            if (pnlEndereco.Visible == true)
            {
                pnlEndereco.Visible = false;
            }
        }
    }
}
