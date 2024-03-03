using BLL;
using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SG_VTNR
{
    public partial class frmCadastrarAnimalteste : Form
    {
        private string foto;
        public frmCadastrarAnimalteste()
        {
            InitializeComponent();
            if (pnlProprietario.Visible == false)
            {
                pnlProprietario.Visible = true;
            }
            PreencherComboBoxRacas();
        }
        public void PreencherComboBoxRacas()
        {
            try
            {

                //public DataTable SelecionarTodosAnimais()
                //{
                DataTable dt = new DataTable();
                DataSet ds = new DataSet();

                //SqlDataAdapter da = new SqlDataAdapter("select * from Animal", conexao.ObjectoConexao);
                //da.Fill(ds);
                cbmCor.DataSource = ds.Tables[0];
                cbmCor.DisplayMember = "NomeRaca";
                //da.Dispose();
                // return dt;

            }
            catch (Exception)
            {

               
            }
        }
        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validarCampos())

                try
                {
                    ModeloAnimal modelo = new ModeloAnimal();
                    modelo.Nome1 = (txtNomeAnimal.Text);
                    modelo.Raca1 = cbmCor.Text;
                    modelo.Cor1 = cmbRaca.Text;
                    modelo.Peso1 = Convert.ToDouble(txtPeso.Text);
                    modelo.Estado1 = cbmEstado.Text;
                    modelo.DataNascimento1 = Convert.ToDateTime(dataNascimento.Text);
                    modelo.Porte1 = cbmPorte.Text;
                    modelo.ProprietarioID1 = Convert.ToInt16(txtIDProp.Text);
                    modelo.Observacao = (txtObs.Text);
                    modelo.Especie1 = cbmEspecie.Text;
                    modelo.sexo1 = cbmGenero.Text;
                    modelo.CarregaImage(this.foto);

                    //modelo.Foto=
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLAnimal bll = new BLLAnimal(cx);
                    //inserir os dados
                    bll.incluir(modelo);
                    MessageBox.Show(modelo.AnimalID1.ToString() + "\n \n Animal Cadastrado com Sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //ethis.Alert("Código: " + modelo.PropietarioId.ToString() + "\n Cadastrado com sucesso!", frmAlert.enmType.Success);



                }
                catch (Exception erro)
                {

                    MessageBox.Show("Não foi possivel Realizar a Operação!!! \n\nContate o Administrador do Sistema!!!\n\nErro Ocorrido:" + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                }
           
        }
        public bool validarCampos()
        {
            if (txtIDProp.Text == "")
            {
                tabControl1.SelectTab(tabPage1);
                MessageBox.Show("Informe o codigo do Proprietario.");
                txtIDProp.Focus();
                return false;
            }

            else if (txtNomeProp.Text == "")
            {
                tabControl1.SelectTab(tabPage1);
                MessageBox.Show("Informe o nome do Proprietário.");
                txtNomeProp.Focus();
                return false;
            }
            else if (txtNomeAnimal.Text == "")
            {
                tabControl1.SelectTab(tabPage2);
                MessageBox.Show("Informe o Nome do animal.");
                txtNomeAnimal.Focus();
                return false;
            }
            else if (cmbRaca.SelectedItem == null)
            {
                tabControl1.SelectTab(tabPage2);
                MessageBox.Show("Informe a cor do animal.");
                cmbRaca.Focus();
                return false;
            }
            else if (cbmGenero.SelectedItem == null)
            {
                tabControl1.SelectTab(tabPage2);
                MessageBox.Show("Informe o genero do animal.");
                cbmGenero.Focus();
                return false;
            }
            if (cbmEstado.Text == "")
            {
                tabControl1.SelectTab(tabPage2);
                MessageBox.Show("Informe o Estado do Animal.");
                cbmEstado.Focus();
                return false;
            }
            else if (cbmPorte.SelectedItem == null)
            {
                tabControl1.SelectTab(tabPage2);
                MessageBox.Show("Informe o porte do animal.");
                cbmPorte.Focus();
                return false;
            }
            else if (cbmCor.SelectedItem == null)
            {
                tabControl1.SelectTab(tabPage2);
                MessageBox.Show("Informe a raça do animal.");
                cmbRaca.Focus();
                return false;
            }
            else
            {
                return true;
            }


        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            this.Close();
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
                txtNomeAnimal.Enabled = false;
                txtCodigo.Enabled = false;
                //comboBox1.Enabled = false;
                txtPesquisarProp.Enabled = false;
                dataNascimento.Enabled = false;
                btnAdicionarfoto.Enabled = false;
                btnExcluir.Enabled = false;

                txtPesquisarProp.Enabled = false;
                txtObs.Enabled = false;
                txtNomeProp.Enabled = false;
                cbmCor.Enabled = false;
                cbmEstado.Enabled = false;
                cmbRaca.Enabled = false;
                cbmCor.Enabled = false;
                txtPeso.Enabled = false;
                cbmGenero.Enabled = false;
                pnlProprietario.Visible = false;
                cbmEspecie.Enabled = false;
                cbmPorte.Enabled = false;
            }

            if (op == 2)
            {
                btnEditar.Enabled = false;
                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;

                cbmCor.Enabled = true;
                cbmEstado.Enabled = true;
                cmbRaca.Enabled = true;
                cbmCor.Enabled = true;
                cbmEspecie.Enabled = true;
                cbmPorte.Enabled = true;

                //btnGuardar.Enabled = perInserir;
                //btnEditar.Enabled = true;
                txtNomeProp.Enabled = false;
                btnCancelar.Enabled = true;
                btnNovo.Enabled = true;
                txtNomeAnimal.Enabled = true;
                txtCodigo.Enabled = false;
                //comboBox1.Enabled = true;
                txtPesquisarProp.Enabled = true;
                dataNascimento.Enabled = true;
                btnAdicionarfoto.Enabled = true;
                btnExcluir.Enabled = true;

                txtPesquisarProp.Enabled = true;
                txtObs.Enabled = true;
                txtPeso.Enabled = true;
                cbmGenero.Enabled = true;

                pnlProprietario.Visible = true;
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
                txtNomeAnimal.Enabled = true;
                txtCodigo.Enabled = false;
                //comboBox1.Enabled = true;
                txtNomeProp.Enabled = false;
                txtPesquisarProp.Enabled = true;
                dataNascimento.Enabled = true;
                btnAdicionarfoto.Enabled = true;
                btnExcluir.Enabled = true;
                txtPesquisarProp.Enabled = true;
                txtObs.Enabled = true;
                txtPeso.Enabled = true;
                cbmCor.Enabled = true;
                cbmEstado.Enabled = true;
                cmbRaca.Enabled = true;
                cbmCor.Enabled = true;
                cbmGenero.Enabled = true;
                cbmEspecie.Enabled = true;
                cbmPorte.Enabled = true;

            }

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            alteraBotoes(2, perInserir, perAlterar, perExcluir, perImprimir);

        }
        private void frmCadastrarAnimalteste_Load(object sender, EventArgs e)
        {

        }
private void pictureBox3_Click(object sender, EventArgs e)
        {
            frmCadastroRaca frm = new frmCadastroRaca();
            frm.ShowDialog();

        }

        private void txtPesquisarProp_TextChanged(object sender, EventArgs e)
        {
            
            PesquisarProprietario();
        }
        public void PesquisarProprietario()
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLProprietario bll = new BLLProprietario(cx);

            DataTable dt = bll.PesquisarProprietarioComChave(txtPesquisarProp.Text);
            dgvMostrarProp.AutoGenerateColumns = true; // Ativa a geração automática de colunas
            dgvMostrarProp.DataSource = dt;

            // Permitir que as colunas sejam redimensionadas pelos usuários
            dgvMostrarProp.AllowUserToResizeColumns = true;

            // Ajustar o tamanho das colunas automaticamente para exibir todo o conteúdo
            dgvMostrarProp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // Configurar o DataGridView para quebrar as linhas
            dgvMostrarProp.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // Ajustar o estilo do cabeçalho para que possa envolver o texto
            foreach (DataGridViewColumn column in dgvMostrarProp.Columns)
            {
                column.HeaderCell.Style.WrapMode = DataGridViewTriState.True;
            }

            // Definir altura das linhas para acomodar o conteúdo completo
            dgvMostrarProp.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);

            // Definir o tamanho das linhas do cabeçalho
            dgvMostrarProp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMostrarProp.ColumnHeadersHeight = 40; // Ajuste o valor conforme desejado

            // Aumentar o tamanho das outras linhas
            dgvMostrarProp.RowTemplate.Height = 30; // Ajuste o valor conforme desejado para outras linhas

            // Adicionar diferença visual na cor das linhas
            dgvMostrarProp.RowsDefaultCellStyle.BackColor = Color.LightGray;
            dgvMostrarProp.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
        }

        private void dgvMostrarProp01_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow linhaSelecionada = dgvMostrarProp.Rows[e.RowIndex];
                txtIDProp.Text = Convert.ToString(dgvMostrarProp.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtNomeProp.Text = Convert.ToString(dgvMostrarProp.Rows[e.RowIndex].Cells[2].Value.ToString());

            }
        }
        public void PesquisarAnimalcomChave()
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLAnimal bll = new BLLAnimal(cx);
            dgvExibirAnimal.DataSource = bll.PesquisarAnimalcomChave(txtPesquisarAnimal.Text);
            // Alterar a fonte para toda a DataGridView
            dgvExibirAnimal.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);

            //// Ou, se quiser alterar apenas para uma coluna específica (por exemplo, a primeira coluna)
            //dataGridView1.Columns[0].DefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Regular);

            // Permitir que as colunas sejam redimensionadas pelos usuários
            dgvExibirAnimal.AllowUserToResizeColumns = true;

            // Ajustar o tamanho das colunas automaticamente para exibir todo o conteúdo
            dgvExibirAnimal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // Configurar o DataGridView para quebrar as linhas
            dgvExibirAnimal.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // Ajustar o estilo do cabeçalho para que possa envolver o texto
            foreach (DataGridViewColumn column in dgvExibirAnimal.Columns)
            {
                column.HeaderCell.Style.WrapMode = DataGridViewTriState.True;
            }

            // Definir altura das linhas para acomodar o conteúdo completo
            dgvExibirAnimal.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);

            // Definir o tamanho das linhas do cabeçalho
            dgvExibirAnimal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExibirAnimal.ColumnHeadersHeight = 40; // Ajuste o valor conforme desejado

            // Aumentar o tamanho das outras linhas
            dgvExibirAnimal.RowTemplate.Height = 30; // Ajuste o valor conforme desejado para outras linhas

            // Adicionar diferença visual na cor das linhas
            dgvExibirAnimal.RowsDefaultCellStyle.BackColor = Color.LightGray;
            dgvExibirAnimal.AlternatingRowsDefaultCellStyle.BackColor = Color.White;




        }

        public void ExibirAnimal()
        {

            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLAnimal bll = new BLLAnimal(cx);
            dgvExibirAnimal.DataSource = bll.SelecionarTodosAnimal();


        }

        private void txtPesquisarAnimal_TextChanged(object sender, EventArgs e)
        {
            PesquisarAnimalcomChave();
        }

        private void btnAdicionarfoto_Click(object sender, EventArgs e)
        {
            this.foto = "";
            pctAnimal.Image = null;
            OpenFileDialog od = new OpenFileDialog();
            od.ShowDialog();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            this.foto = "";
            pctAnimal.Image = null;

        }

        private void dataNascimento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dgvExibirAnimal_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            


                string colName = dgvExibirAnimal.Columns[e.ColumnIndex].Name;
                if (colName == "colEditar")
                {
             
                txtCodigo.Text = dgvExibirAnimal.Rows[e.RowIndex].Cells["Código do Animal"].Value.ToString();
                    txtNomeAnimal.Text = dgvExibirAnimal.Rows[e.RowIndex].Cells["Nome do Animal"].Value.ToString();
                    cbmEspecie.Text = dgvExibirAnimal.Rows[e.RowIndex].Cells["Espécie"].Value.ToString();
                    cmbRaca.Text = dgvExibirAnimal.Rows[e.RowIndex].Cells["Raça"].Value.ToString();
                    cbmCor.Text = dgvExibirAnimal.Rows[e.RowIndex].Cells["Cor"].Value.ToString();
                    txtPeso.Text = dgvExibirAnimal.Rows[e.RowIndex].Cells["Peso"].Value.ToString();
                    cbmEstado.Text = dgvExibirAnimal.Rows[e.RowIndex].Cells["Estado"].Value.ToString();
                    dataNascimento.Text = dgvExibirAnimal.Rows[e.RowIndex].Cells["Data de Nascimento"].Value.ToString();
                    cbmPorte.Text = dgvExibirAnimal.Rows[e.RowIndex].Cells["Porte"].Value.ToString();
                    txtIDProp.Text = dgvExibirAnimal.Rows[e.RowIndex].Cells["Código do Proprietário"].Value.ToString();
                    //pctAnimal.Text = dgvExibirAnimal.Rows[e.RowIndex].Cells["foto"].Value.ToString();
                    txtObs.Text = dgvExibirAnimal.Rows[e.RowIndex].Cells["Observação"].Value.ToString();
                    cbmGenero.Text = dgvExibirAnimal.Rows[e.RowIndex].Cells["Sexo"].Value.ToString();

                    //codigoProp =Convert.ToInt32( txtIDProp.Text = dgvExibirAnimal.Rows[e.RowIndex].Cells["ProprietarioID"].Value.ToString());
                    //txtNomeProp.Text = BuscarNomeProp();
                    alteraBotoes(3, perInserir, perAlterar, perExcluir, perImprimir);
                    tabControl1.SelectTab(tabPage1);
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
                            DialogResult = MessageBox.Show("Dados eliminados com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            frmCadastrarAnimalteste frm = new frmCadastrarAnimalteste();
                            frm.ShowDialog();
                            tabControl1.SelectTab(tabPage3);
                            txtPesquisarAnimal.Focus();
                            ExibirAnimal();
                        }
                    }
                    catch (Exception)
                    {

                        throw;
                    }

                }
            }

        }
    
}
