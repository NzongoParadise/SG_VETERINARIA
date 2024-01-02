using System;
using Modelo;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

using DAL;


namespace SG_VTNR
{
    public partial class frmMedicamento : Form
    {
        public frmMedicamento()
        {
            InitializeComponent();
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
                txtCodigo.Enabled = false;

                txtNomeMedicamento.Enabled = false;
                txtFabricante.Enabled = false;
                txtConcentracao.Enabled = false;
                //dataExpiracao.Enabled = false;
                //dataFabrico.Enabled = false;
                txtDosagem.Enabled = false;
                txtFormaFarmac.Enabled = false;
                txtConcentracao.Enabled = false;
                //btnAdicionarfoto.Enabled = false;
                //btnExcluir.Enabled = false;


            }

            if (op == 2)
            {
                btnEditar.Enabled = false;
                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
                txtCodigo.Enabled = false;

                txtNomeMedicamento.Enabled = true;
                txtFabricante.Enabled = true;
                txtConcentracao.Enabled = true;
                //dataExpiracao.Enabled = true;
                //dataFabrico.Enabled = true;
                txtDosagem.Enabled = true;
                txtFormaFarmac.Enabled = true;
                txtConcentracao.Enabled = true;
                //btnAdicionarfoto.Enabled = true;
                //btnExcluir.Enabled = true;

            }
            if (op == 3)
            {
                //btnEditar.Enabled = perAlterar;
                btnEditar.Enabled = true;
                btnCancelar.Enabled = true;
                btnNovo.Enabled = false;

                txtCodigo.Enabled = false;
                txtNomeMedicamento.Enabled = true;
                txtFabricante.Enabled = true;
                txtConcentracao.Enabled = true;
                //dataExpiracao.Enabled = true;
                //dataFabrico.Enabled = true;
                txtDosagem.Enabled = true;
                txtFormaFarmac.Enabled = true;
                txtConcentracao.Enabled = true;
                //btnAdicionarfoto.Enabled = true;
                //btnExcluir.Enabled = true;

            }

        }
        private void txtNomePia_TextChanged(object sender, EventArgs e)
        {

        }
       

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                ModeloMedicamento modelo = new ModeloMedicamento();
                modelo.NomeMedicamento = txtNomeMedicamento.Text;
                modelo.TipoProduto = cmbTipoMed.Text;
                modelo.FormaFarmaceutica = txtFormaFarmac.Text;
                modelo.DosagemMedicamento = txtFabricante.Text;
                modelo.Instrucoes = txtInstrucoes.Text;
                modelo.Fabricante = txtFabricante.Text;
                modelo.Concentracao = txtConcentracao.Text;
                modelo.Descricao = txtDescricao.Text;

                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLMedicamento bll = new BLLMedicamento(cx);
                bll.incluir(modelo);            

                MessageBox.Show("Cadastrado com suicesso ", modelo.CodeMedicamento.ToString());
                //ethis.Alert("Código: " + modelo.PropietarioId.ToString() + "\n Cadastrado com sucesso!", frmAlert.enmType.Success);
               

            }
            catch (Exception)
            {
                /* 
                 MessageBox.Show("Não foi possivel Realizar a Operação!!! \n\nContate o Administrador do Sistema!!!\n\nErro Ocorrido:" + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                */
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

        private void pnlCadastrar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdicionarfoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Filter = "arquivo de imagem|*.jpg;*jphjieg;*png;.gif|todos aquivos|*.*";
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                string caminhodaImagem = openfile.FileName;
                //pctProprietario.Image = new Bitmap(caminhodaImagem);

                //pctProprietario.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
           
        }

        private void guna2ShadowPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                ModeloMedicamento modelo = new ModeloMedicamento();
                modelo.CodeMedicamento = Convert.ToInt32(txtCodigo.Text);
                modelo.NomeMedicamento = txtNomeMedicamento.Text;
                modelo.TipoProduto = cmbTipoMed.Text;
                modelo.FormaFarmaceutica = txtFormaFarmac.Text;
                modelo.DosagemMedicamento = txtFabricante.Text;
                modelo.Instrucoes = txtInstrucoes.Text;
                modelo.Fabricante = txtFabricante.Text;
                modelo.Concentracao = txtConcentracao.Text;
                modelo.Descricao = txtDescricao.Text;

                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLMedicamento bll = new BLLMedicamento(cx);
                bll.alterar(modelo);

                MessageBox.Show("Editado com sucesso ", modelo.CodeMedicamento.ToString());
                //ethis.Alert("Código: " + modelo.PropietarioId.ToString() + "\n Cadastrado com sucesso!", frmAlert.enmType.Success);


            }
            catch (Exception)
            {
                /* 
                 MessageBox.Show("Não foi possivel Realizar a Operação!!! \n\nContate o Administrador do Sistema!!!\n\nErro Ocorrido:" + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                */
            }
        }
    }
}
