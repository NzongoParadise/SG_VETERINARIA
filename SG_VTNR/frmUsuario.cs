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
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
            dgvFuncionario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFuncionario.MultiSelect = false;
             // Adiciona o evento CellClick para manipular o clique na célula
    dgvFuncionario.CellClick += dgvFuncionario_CellContentClick;
        }

        DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
        private void btnAdcEndereco_Click(object sender, EventArgs e)
        {

        }
        #region permicao de ativar os botoes
        //Boolean perInserir = false; Boolean perAlterar = false; Boolean perExcluir = false; Boolean perImprimir = false;
        public void alteraBotoes(int op, Boolean perInserir, Boolean perAlterar, Boolean perExcluir, Boolean perImprimir)
        {

            btnGuardar.Enabled = false;
            btnEditar.Enabled = false;
            btnCancelar.Enabled = false;
            btnNovo.Enabled = true;

            if (op == 1)
            {
                btnGuardar.Enabled = true;
                btnEditar.Enabled = false;
                btnCancelar.Enabled = true;


                txtNomeUsuario.Enabled = true;
                txtSenha.Enabled = true;
                cmbPerfil.Enabled = true;
            }

            if (op == 2)
            {
                btnEditar.Enabled = false;
                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;

                txtNomeUsuario.Enabled = true;
                txtSenha.Enabled = true;
                cmbPerfil.Enabled = true;

            }
            if (op == 3)
            {
                ////btnEditar.Enabled = perAlterar;
                //btnEditar.Enabled = true;
                //btnCancelar.Enabled = true;
                //btnNovo.Enabled = false;

                //txtNomeUsuario.Enabled = true;
                //txtSenha.Enabled = true;
                //cmbPerfil.Enabled = true;

            }

        }
        #endregion fim permicao activar botos

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (pnlCadastrar.Visible == false)
            {
                pnlCadastrar.Visible = true;
            }
        }

        private void pnlCadastrar_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void dgvDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvDadosUsuario.Columns[e.ColumnIndex].Name;
            if (colName == "colEditar")
            {
                txtCodigo.Text = dgvDadosUsuario.Rows[e.RowIndex].Cells["UsuarioID"].Value.ToString();
                txtIDFuncionario.Text = dgvDadosUsuario.Rows[e.RowIndex].Cells["FuncionarioID"].Value.ToString();
                txtNomeFuncionario.Text = dgvDadosUsuario.Rows[e.RowIndex].Cells["NomeFuncionario"].Value.ToString();
                txtNomeUsuario.Text = dgvDadosUsuario.Rows[e.RowIndex].Cells["NomeUsuario"].Value.ToString();
                txtSenha.Text = dgvDadosUsuario.Rows[e.RowIndex].Cells["Senha"].Value.ToString();
                cmbPerfil.Text = dgvDadosUsuario.Rows[e.RowIndex].Cells["Perfil"].Value.ToString();

                if (pnlCadastrar.Visible == false)
                {
                    pnlCadastrar.Visible = true;
                    //alteraBotoes(3, perInserir, perAlterar, perExcluir, perImprimir);
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
                        int col = Convert.ToInt32(dgvDadosUsuario.CurrentRow.Cells["UsuarioID"].Value);
                        DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                        BLLUsuario bll = new BLLUsuario(cx);
                        bll.Excluir(Convert.ToInt32(col));
                        exibir();
                        
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Falha na Remoção do Dados"+ ex.Message);
                }
            }


        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {

            pnlCadastrar.Visible = false;
        }



        private void frmUsuario_Load(object sender, EventArgs e)
        {
            exibir();
        

        }
        private void LimparTela()
        {
            txtCodigo.Clear();
            txtIDFuncionario.Clear();
            txtPesquisarFuncionario.Clear();
            txtNomeUsuario.Clear();
            txtPesquisar.Clear();
            txtSenha.Clear();
        }
        public void exibir()
        {
           
            BLLUsuario bll = new BLLUsuario(cx);
            dgvDadosUsuario.DataSource = bll.Localizar(txtPesquisar.Text);
            //CarregarTituloDgv();
            //FormatandoDGV.
        }
        //public void exibirFuncionario()
        //{
        //    BLLUsuario bll = new BLLUsuario(cx);
        //    dgvFuncionario.DataSource = bll.LocalizarFuncionario(txtPesquisarFuncionario.Text);
        //}

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
            ModeloUsuario modelo= new ModeloUsuario();

            modelo.FuncionarioID = Convert.ToInt32(txtIDFuncionario.Text);
            modelo.NomeUsuario= txtNomeUsuario.Text;
            modelo.Senha = txtSenha.Text;
            modelo.Perfil= cmbPerfil.Text;
            modelo.NomeFuncionario = txtNomeFuncionario.Text;

            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLUsuario bll = new BLLUsuario(cx);
            bll.Incluir(modelo);
            MessageBox.Show(modelo.UsuarioID.ToString() + "\n Proprietário Cadastrado com Sucesso!");
            //ethis.Alert("Código: " + modelo.PropietarioId.ToString() + "\n Cadastrado com sucesso!", frmAlert.enmType.Success);
            LimparTela();
              exibir();
            }
        
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possivel Realizar a Operação!!! \n\nContate o Administrador do Sistema!!!\n\nErro Ocorrido:" + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }




}

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            exibir();
        }

        private void txtMostrarFuncionario_TextChanged(object sender, EventArgs e)
        {
            exibirFuncionario();
        }
        public void exibirFuncionario()
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLFuncionario bll = new BLLFuncionario(cx);
            dgvFuncionario.DataSource = bll.PesquisarFuncionariosComChave(txtPesquisarFuncionario.Text);
            //CarregarTituloDgv();
            //FormatandoDGV.
        }
        private void txtPesquisarFuncionario_MouseClick(object sender, MouseEventArgs e)
        {
            if (pnlEndereco.Visible == false)
            {
                pnlEndereco.Visible = true;                
            }
        }

        private void dgvFuncionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (pnlEndereco.Visible == true)
            {
                pnlEndereco.Visible = false;
            }

            if (e.RowIndex >= 0) // Verifica se uma linha válida foi clicada
            {
                DataGridViewRow linhaSelecionada = dgvFuncionario.Rows[e.RowIndex];

                // Preenche as TextBoxes com os dados da linha selecionada
                txtNomeFuncionario.Text = linhaSelecionada.Cells["Nome"].Value.ToString(); // Substitua "NomeColuna" pelo nome da coluna no DataGridView
                txtIDFuncionario.Text = linhaSelecionada.Cells["FuncionarioID"].Value.ToString(); // Substitua "IdadeColuna" pelo nome da coluna no DataGridView
                //textBoxCargo.Text = linhaSelecionada.Cells["CargoColuna"].Value.ToString(); // Substitua "CargoColuna" pelo nome da coluna no DataGridView
            }
            

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ModeloUsuario modelo= new ModeloUsuario();
            modelo.Senha = cmbPerfil.Text;
            modelo.NomeUsuario=txtNomeUsuario.Text;
            modelo.Perfil=cmbPerfil.Text;
            modelo.NomeFuncionario= txtNomeFuncionario.Text;
            modelo.UsuarioID =Convert.ToInt32(txtCodigo.Text);
            modelo.FuncionarioID = Convert.ToInt32(txtIDFuncionario.Text);
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLUsuario bll = new BLLUsuario(cx);
            //Alterar os dados
            bll.AlterarUsuario(modelo);

            MessageBox.Show("alterado com sucesso");

           

        }
    }
}
