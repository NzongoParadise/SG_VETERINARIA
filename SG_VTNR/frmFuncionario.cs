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
    public partial class frmFuncionario : Form
    {
        private string foto;
        public frmFuncionario()
        {
            InitializeComponent();
        }

        public void ExibirFuncionario()
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLFuncionario bll = new BLLFuncionario(cx);
            dgvDadosFuncionario.DataSource= bll.ExibirFuncionario(txtPesquisarFuncionario.Text);

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
                modelo.NumIdentificacao= txtNumIdentificacao.Text;
                modelo.EnderecoID = Convert.ToInt16(txtCodeEndereco.Text);

                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLFuncionario bll = new BLLFuncionario(cx);
                bll.Incluir(modelo);
                MessageBox.Show(modelo.FuncionarioID.ToString() + "\n Funcionário Cadastrado com Sucesso!");
                
                ExibirFuncionario();

            }
            catch(Exception erro)
            {
                MessageBox.Show("Não foi possivel Realizar a Operação!!! \n\nContate o Administrador do Sistema!!!\n\nErro Ocorrido:" + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Stop);

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
            pnlCadastrar.Visible = false;
        }

        private void frmFuncionario_Load(object sender, EventArgs e)
        {
            ExibirFuncionario();
        }
    }
}
