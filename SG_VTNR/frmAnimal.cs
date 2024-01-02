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
    public partial class frmAnimal : Form
    {
        public frmAnimal()
        {
            InitializeComponent();
        }

        private void frmAnimal_Load(object sender, EventArgs e)
        {

        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

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
                txtCodigo.Enabled = false;
                cbmEspecie.Enabled = false;
                txtMostrarEndereco.Enabled = false;
                dataNascimento.Enabled = false;
                btnAdicionarfoto.Enabled = false;
                btnExcluir.Enabled = false;
                btnAdcEndereco.Enabled = false;
                txtMostrarEndereco.Enabled = false;
               txtObs.Enabled = false;
                txtNomeProp.Enabled = false;
                cbmRaca.Enabled = false;
                cbmEstado.Enabled = false;
                cbmCor.Enabled = false;
                cbmRaca.Enabled = false;
                txtPeso.Enabled = false;
                cbmGenero.Enabled = false;
                
            }

            if (op == 2)
            {
                btnEditar.Enabled = false;
                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;

                cbmRaca.Enabled = true;
                cbmEstado.Enabled = true;
                cbmCor.Enabled = true;
                cbmRaca.Enabled = true;

                //btnGuardar.Enabled = perInserir;
                //btnEditar.Enabled = true;
                txtNomeProp.Enabled = false;
                btnCancelar.Enabled = true;
                btnNovo.Enabled = true;
                txtNome.Enabled = true;
                txtCodigo.Enabled = false;
                cbmEspecie.Enabled = true;
                txtMostrarEndereco.Enabled = true;
                dataNascimento.Enabled = true;
                btnAdicionarfoto.Enabled = true;
                btnExcluir.Enabled = true;
                btnAdcEndereco.Enabled = true;
                txtMostrarEndereco.Enabled = true;
                txtObs.Enabled = true;
                txtPeso.Enabled = true;
                cbmGenero.Enabled = true;

            }
            if (op == 3)
            {
                //btnEditar.Enabled = perAlterar;
                btnEditar.Enabled = true;
                btnCancelar.Enabled = true;
                btnNovo.Enabled = false;


                btnGuardar.Enabled = perInserir;
                btnEditar.Enabled = true;
                btnCancelar.Enabled = true;
                btnNovo.Enabled = true;
                txtNome.Enabled = true;
                txtCodigo.Enabled = false;
                cbmEspecie.Enabled = true;
                txtNomeProp.Enabled = false;
                txtMostrarEndereco.Enabled = true;
                dataNascimento.Enabled = true;
                btnAdicionarfoto.Enabled = true;
                btnExcluir.Enabled = true;
                btnAdcEndereco.Enabled = true;
                txtMostrarEndereco.Enabled = true;
                txtObs.Enabled = true;
                txtPeso.Enabled = true;
                cbmRaca.Enabled = true;
                cbmEstado.Enabled = true;
                cbmCor.Enabled = true;
                cbmRaca.Enabled = true;
                cbmGenero.Enabled = true;
             
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

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (pnlCadastrar.Visible == false)
            {
                alteraBotoes(1, perInserir, perAlterar, perExcluir, perImprimir);
                pnlCadastrar.Visible = true;
            }

        }

        private void guna2ShadowPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            alteraBotoes(2, perInserir, perAlterar, perExcluir, perImprimir);
            LimparTela();
        }
        private void LimparTela()
        { 
            txtNome.Text = "";
            txtNomeProp.Text ="";
            txtMostrarEndereco.Text = "";
            txtObs.Text = "";
            txtPeso.Text = "";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                ModeloAnimal modelo = new ModeloAnimal();

                modelo.Nome1 =(txtNome.Text);
                modelo.Especie1 = Convert.ToString((cbmEspecie.SelectedValue));
                modelo.Raca1 = Convert.ToString(cbmRaca.SelectedValue);
                modelo.Cor1 = Convert.ToString(cbmCor.SelectedValue);
                modelo.Peso1 = Convert.ToDouble(txtPeso.Text);
                modelo.Estado1 = Convert.ToString(cbmEstado.SelectedValue);
                modelo.DataNascimento1 = Convert.ToDateTime(dataNascimento.Text);
                modelo.Porte1 = Convert.ToString(cbmPorte.SelectedValue);
                modelo.ProprietarioID1 = Convert.ToInt16(txtIDProp.Text);
                modelo.Observacao =(txtObs.Text);

                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLAnimal bll = new BLLAnimal(cx);
                //inserir os dados
                bll.incluir(modelo);
                MessageBox.Show(modelo.AnimalID1.ToString());
                //ethis.Alert("Código: " + modelo.PropietarioId.ToString() + "\n Cadastrado com sucesso!", frmAlert.enmType.Success);
                LimparTela();
                //exibir();

            }
            catch (Exception erro)
            {

                MessageBox.Show("Não foi possivel Realizar a Operação!!! \n\nContate o Administrador do Sistema!!!\n\nErro Ocorrido:" + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
