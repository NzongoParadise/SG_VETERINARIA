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
       private string foto;
        //int codigoProp;

        public frmAnimal()
        {
            InitializeComponent();
            dgvMostrarProp.SelectionMode=DataGridViewSelectionMode.FullRowSelect;
            dgvMostrarProp.MultiSelect = false;
            dgvMostrarProp.CellClick += dgvMostrarProp_CellContentClick;
            
        }
       
        public void ExibirAnimal()
        {
        
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLAnimal bll = new BLLAnimal(cx);
            dgvExibirAnimal.DataSource = bll.SelecionarTodosAnimal();


        }
        private void frmAnimal_Load(object sender, EventArgs e)
        {
            ExibirAnimal();
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
                //comboBox1.Enabled = false;
                txtPesquisarProp.Enabled = false;
                dataNascimento.Enabled = false;
                btnAdicionarfoto.Enabled = false;
                btnExcluir.Enabled = false;
                btnAdcEndereco.Enabled = false;
                txtPesquisarProp.Enabled = false;
               txtObs.Enabled = false;
                txtNomeProp.Enabled = false;
                cbmRaca.Enabled = false;
                cbmEstado.Enabled = false;
                cbmCor.Enabled = false;
                cbmRaca.Enabled = false;
                txtPeso.Enabled = false;
                cbmGenero.Enabled = false;
                pnlFuncionario.Visible = false;
          
                cbmEspecie.Enabled = false;
                cbmPorte.Enabled = false;
                
              
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



                
              
                cbmEspecie.Enabled = true;
                cbmPorte.Enabled = true;

                //btnGuardar.Enabled = perInserir;
                //btnEditar.Enabled = true;
                txtNomeProp.Enabled = false;
                btnCancelar.Enabled = true;
                btnNovo.Enabled = true;
                txtNome.Enabled = true;
                txtCodigo.Enabled = false;
                //comboBox1.Enabled = true;
                txtPesquisarProp.Enabled = true;
                dataNascimento.Enabled = true;
                btnAdicionarfoto.Enabled = true;
                btnExcluir.Enabled = true;
                btnAdcEndereco.Enabled = true;
                txtPesquisarProp.Enabled = true;
                txtObs.Enabled = true;
                txtPeso.Enabled = true;
                cbmGenero.Enabled = true;

                pnlFuncionario.Visible = true;


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
                //comboBox1.Enabled = true;
                txtNomeProp.Enabled = false;
                txtPesquisarProp.Enabled = true;
                dataNascimento.Enabled = true;
                btnAdicionarfoto.Enabled = true;
                btnExcluir.Enabled = true;
                btnAdcEndereco.Enabled = true;
                txtPesquisarProp.Enabled = true;
                txtObs.Enabled = true;
                txtPeso.Enabled = true;
                cbmRaca.Enabled = true;
                cbmEstado.Enabled = true;
                cbmCor.Enabled = true;
                cbmRaca.Enabled = true;
                cbmGenero.Enabled = true;
            cbmEspecie.Enabled = true;
                cbmPorte.Enabled = true;
                
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
            txtPesquisarProp.Text = "";
            txtObs.Text = "";
            txtPeso.Text = "";
            txtIDProp.Text = "";
            cbmGenero.SelectedIndex = -1;
            cbmEspecie.SelectedIndex = -1;
            cbmRaca.SelectedIndex = -1;
            cbmEstado.SelectedIndex = -1;
            cbmCor.SelectedIndex = -1;
            cbmPorte.SelectedIndex = -1;
            pctAnimal.Image = null;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           

            try
            {
                ModeloAnimal modelo = new ModeloAnimal();

                modelo.Nome1 =(txtNome.Text);

              
                modelo.Raca1 = cbmRaca.Text;
                modelo.Cor1 = cbmCor.Text;
                modelo.Peso1 = Convert.ToDouble(txtPeso.Text);
                modelo.Estado1 = cbmEstado.Text;
                modelo.DataNascimento1 = Convert.ToDateTime(dataNascimento.Text);
                modelo.Porte1 = cbmPorte.Text;
                modelo.ProprietarioID1 = Convert.ToInt16(txtIDProp.Text);
                modelo.Observacao =(txtObs.Text);
                modelo.Especie1 = cbmEspecie.Text;
                modelo.sexo1= cbmGenero.Text;
                modelo.CarregaImage(this.foto);
                
                //modelo.Foto=
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLAnimal bll = new BLLAnimal(cx);
                //inserir os dados
                bll.incluir(modelo);
                MessageBox.Show(modelo.AnimalID1.ToString()+"\n \n Animal Cadastrado com Sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //ethis.Alert("Código: " + modelo.PropietarioId.ToString() + "\n Cadastrado com sucesso!", frmAlert.enmType.Success);
                LimparTela();
                ExibirAnimal();
              

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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                ModeloAnimal modelo = new ModeloAnimal();
                modelo.AnimalID1 =Convert.ToInt32( txtCodigo.Text);
                modelo.Nome1 = (txtNome.Text);
                modelo.Raca1 = cbmRaca.Text;
                modelo.sexo1 = cbmGenero.Text;
                modelo.Cor1 = cbmCor.Text;
                modelo.Peso1 = Convert.ToDouble(txtPeso.Text);
                modelo.Estado1 = cbmEstado.Text;
                modelo.DataNascimento1 = Convert.ToDateTime(dataNascimento.Text);
                modelo.Porte1 = cbmPorte.Text;
                modelo.ProprietarioID1 = Convert.ToInt16(txtIDProp.Text);
                modelo.Observacao = (txtObs.Text);
                modelo.Especie1 = cbmEspecie.Text;
                modelo.sexo1 = cbmGenero.Text;
                modelo.CarregaImage(this.foto);
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLAnimal bll = new BLLAnimal(cx);
                bll.AtualizarAnimal(modelo);
                MessageBox.Show(modelo.AnimalID1.ToString() + "\n Dados do Animal Actualizado com Sucesso!");
                LimparTela();
                ExibirAnimal();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possivel Realizar a Operação!!! \n\nContate o Administrador do Sistema!!!\n\nErro Ocorrido:" + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparTela();
        }

        private void btnAdicionarfoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog od= new OpenFileDialog();
            od.ShowDialog();
            if(!string.IsNullOrEmpty(od.FileName))
            {
                this.foto=od.FileName;
                pctAnimal.Load(this.foto);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            this.foto = "";
            pctAnimal.Image = null;
        }
       

        private void dgvDados_CellContentClick(object sender, DataGridViewCellEventArgs e)

        {
            string colName = dgvExibirAnimal.Columns[e.ColumnIndex].Name;
            if (colName == "colEditar")
            {
                txtCodigo.Text = dgvExibirAnimal.Rows[e.RowIndex].Cells["AnimalID"].Value.ToString();
                txtNome.Text = dgvExibirAnimal.Rows[e.RowIndex].Cells["Nome"].Value.ToString();
                cbmEspecie.Text = dgvExibirAnimal.Rows[e.RowIndex].Cells["Especie"].Value.ToString();
                cbmRaca.Text = dgvExibirAnimal.Rows[e.RowIndex].Cells["Raca"].Value.ToString();
                cbmCor.Text = dgvExibirAnimal.Rows[e.RowIndex].Cells["Cor"].Value.ToString();
                txtPeso.Text = dgvExibirAnimal.Rows[e.RowIndex].Cells["Peso"].Value.ToString();
                cbmEstado.Text = dgvExibirAnimal.Rows[e.RowIndex].Cells["Estado"].Value.ToString();
                dataNascimento.Text = dgvExibirAnimal.Rows[e.RowIndex].Cells["DataNascimento"].Value.ToString();
                cbmPorte.Text = dgvExibirAnimal.Rows[e.RowIndex].Cells["Porte"].Value.ToString();
                txtIDProp.Text = dgvExibirAnimal.Rows[e.RowIndex].Cells["ProprietarioID"].Value.ToString();
                pctAnimal.Text = dgvExibirAnimal.Rows[e.RowIndex].Cells["foto"].Value.ToString();
                txtObs.Text = dgvExibirAnimal.Rows[e.RowIndex].Cells["observacao"].Value.ToString();
                cbmGenero.Text = dgvExibirAnimal.Rows[e.RowIndex].Cells["sexo"].Value.ToString();

                //codigoProp =Convert.ToInt32( txtIDProp.Text = dgvExibirAnimal.Rows[e.RowIndex].Cells["ProprietarioID"].Value.ToString());
                //txtNomeProp.Text = BuscarNomeProp();

                if (pnlCadastrar.Visible ==false)
                {
                    alteraBotoes(3, perInserir, perAlterar, perExcluir, perImprimir);
                    pnlCadastrar.Visible = true;
                }

            }
            if (colName == "ColDeletar")
            {
                try
                {
                    DialogResult d = MessageBox.Show("desejas realmente excluir os dados?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                    if (d.ToString() == "Yes")
                    {
                        //alteraBotoes(1, perInserir, perAlterar, perExcluir, perImprimir);
                        int col = Convert.ToInt32(dgvExibirAnimal.CurrentRow.Cells["AnimalID"].Value);
                        DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                        BLLAnimal bll = new BLLAnimal(cx);
                        bll.EliminarAnimal(Convert.ToInt32(col));
                        DialogResult  = MessageBox.Show("Dados eliminados com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        ExibirAnimal();
                    }
                }
                catch (Exception)
                {

                    throw;
                }

            }
        }
        public void PesquisarAnimalcomChave()
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLAnimal bll = new BLLAnimal(cx);
            dgvExibirAnimal.DataSource = bll.PesquisarAnimalcomChave(txtPesquisarAnimal.Text);

        }
        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {
            PesquisarAnimalcomChave();
        }
        public void PesquisarProprietario()
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLProprietario bll = new BLLProprietario(cx);

            DataTable dt = bll.PesquisarProprietarioComChave(txtPesquisarProp.Text);
            dgvMostrarProp.AutoGenerateColumns = true; // Ativa a geração automática de colunas
            dgvMostrarProp.DataSource = dt;

            // Renomear os cabeçalhos das colunas diretamente no DataGridView
            dgvMostrarProp.Columns["Nome"].HeaderText = "Nome";
            dgvMostrarProp.Columns["Sobrenome"].HeaderText = "Sobrenome";
            dgvMostrarProp.Columns["ProprietarioID"].HeaderText = "ID";
        }

        //public void PesquisarProprietario()
        //{
        //    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
        //    BLLProprietario bll=new BLLProprietario(cx);
        //    //dgvMostrarProp.DataSource = bll.PesquisarProprietarioComChave(txtPesquisarProp.Text);
        //    DataTable dt = bll.PesquisarProprietarioComChave(txtPesquisarProp.Text);

        //    dgvMostrarProp.DataSource = dt;
        //    dgvMostrarProp.AutoGenerateColumns = false;
        //    dgvMostrarProp.Columns["Nome"].HeaderText = "Nome";
        //    dgvMostrarProp.Columns["Sobrenome"].HeaderText = "Sobrenome";
        //    dgvMostrarProp.Columns["ProprietarioID"].HeaderText = "ID";
        //}
        private void txtPesquisarProp_TextChanged(object sender, EventArgs e)
        {
            PesquisarProprietario();
        }

        private void dgvMostrarProp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex>=0)
            {
                DataGridViewRow linhaSelecionada = dgvMostrarProp.Rows[e.RowIndex];

              
                txtIDProp.Text = Convert.ToString(dgvMostrarProp.Rows[e.RowIndex].Cells[2].Value.ToString());
                txtNomeProp.Text = Convert.ToString(dgvMostrarProp.Rows[e.RowIndex].Cells[0].Value.ToString());

            }
          



        }
    }
}
