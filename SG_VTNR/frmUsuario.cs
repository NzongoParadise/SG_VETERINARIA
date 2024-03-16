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
        string senhaOriginal;
        public frmUsuario()
        {
            InitializeComponent();
            dgvFuncionario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFuncionario.MultiSelect = false;
            PesquisarTodosFuncionarios();
             // Adiciona o evento CellClick para manipular o clique na célula
    dgvFuncionario.CellClick += dgvFuncionario_CellContentClick;
        }
        
        DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
        private void btnAdcEndereco_Click(object sender, EventArgs e)
        {

        }
     
        //#region permicao de ativar os botoes
        ////Boolean perInserir = false; Boolean perAlterar = false; Boolean perExcluir = false; Boolean perImprimir = false;
        //public void alteraBotoes(int op, Boolean perInserir, Boolean perAlterar, Boolean perExcluir, Boolean perImprimir)
        //{

        //    btnGuardar.Enabled = false;
        //    btnEditar.Enabled = false;
        //    btnCancelar.Enabled = false;
        //    btnNovo.Enabled = true;

        //    if (op == 1)
        //    {
        //        btnGuardar.Enabled = true;
        //        btnEditar.Enabled = false;
        //        btnCancelar.Enabled = true;


        //        txtNomeUsuario.Enabled = true;
        //        txtSenha.Enabled = true;
        //        cmbPerfil.Enabled = true;
        //    }

        //    if (op == 2)
        //    {
        //        btnEditar.Enabled = false;
        //        btnGuardar.Enabled = true;
        //        btnCancelar.Enabled = true;

        //        txtNomeUsuario.Enabled = true;
        //        txtSenha.Enabled = true;
        //        cmbPerfil.Enabled = true;

        //    }
        //    if (op == 3)
        //    {
        //        ////btnEditar.Enabled = perAlterar;
        //        //btnEditar.Enabled = true;
        //        //btnCancelar.Enabled = true;
        //        //btnNovo.Enabled = false;

        //        //txtNomeUsuario.Enabled = true;
        //        //txtSenha.Enabled = true;
        //        //cmbPerfil.Enabled = true;

        //    }

        //}
        //#endregion fim permicao activar botos

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (pnlCadastrar.Visible == false)
            {
                pnlCadastrar.Visible = true;
            }
            PesquisarTodosFuncionarios();
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
                txtNomeUsuario.Text = dgvDadosUsuario.Rows[e.RowIndex].Cells["NomeUsuario"].Value.ToString();
                // senhaOriginal =  dgvDadosUsuario.Rows[e.RowIndex].Cells["Senha"].Value.ToString();
               // txtSenha.Text = dgvDadosUsuario.Rows[e.RowIndex].Cells["Senha"].Value.ToString();
                txtNomeFuncionario.Text = dgvDadosUsuario.Rows[e.RowIndex].Cells["NomeFuncionario"].Value.ToString();

                cmbPerfil.Text = dgvDadosUsuario.Rows[e.RowIndex].Cells["Perfil"].Value.ToString();

                if (pnlCadastrar.Visible == false)
                {
                    pnlCadastrar.Visible = true;
                    //alteraBotoes(3, perInserir, perAlterar, perExcluir, perImprimir);
                }

            }
            if (colName == "ColDeletar")
            {
                //alteraBotoes(1, perInserir, perAlterar, perExcluir, perImprimir);
                int col = Convert.ToInt32(dgvDadosUsuario.CurrentRow.Cells["UsuarioID"].Value);
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLUsuario bll = new BLLUsuario(cx);
                if (bll.verificarAsociacoesUsuario(col))
                {
                    MessageBox.Show("Não é possível excluir este Usuário pois existem informações associados a ele.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                catch (Exception ex)
                {

                    MessageBox.Show("Falha na Remoção do Dados"+ ex.Message);
                }
            }


        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {

            this.Close();
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

            // Permitir que as colunas sejam redimensionadas pelos usuários
            dgvDadosUsuario.AllowUserToResizeColumns = true;

            // Ajustar o tamanho das colunas automaticamente para exibir todo o conteúdo
            dgvDadosUsuario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // Configurar o DataGridView para quebrar as linhas
            dgvDadosUsuario.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // Ajustar o estilo do cabeçalho para que possa envolver o texto
            foreach (DataGridViewColumn column in dgvDadosUsuario.Columns)
            {
                column.HeaderCell.Style.WrapMode = DataGridViewTriState.True;
            }

            // Definir altura das linhas para acomodar o conteúdo completo
            dgvDadosUsuario.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);

            // Definir o tamanho das linhas do cabeçalho
            dgvDadosUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDadosUsuario.ColumnHeadersHeight = 40; // Ajuste o valor conforme desejado

            // Aumentar o tamanho das outras linhas
            dgvDadosUsuario.RowTemplate.Height = 30; // Ajuste o valor conforme desejado para outras linhas

            // Adicionar diferença visual na cor das linhas
            dgvDadosUsuario.RowsDefaultCellStyle.BackColor = Color.LightGray;
            dgvDadosUsuario.AlternatingRowsDefaultCellStyle.BackColor = Color.White;


        }


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
            bll.cadastrarUsuario(modelo);
            MessageBox.Show(modelo.UsuarioID.ToString() + "\n Usuário Cadastrado com Sucesso!");
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
        public void PesquisarTodosFuncionarios()
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLFuncionario bll = new BLLFuncionario(cx);
            dgvFuncionario.DataSource = bll.PesquisarTodosFuncionarios();
            // Permitir que as colunas sejam redimensionadas pelos usuários
            dgvFuncionario.AllowUserToResizeColumns = true;

            // Ajustar o tamanho das colunas automaticamente para exibir todo o conteúdo
            dgvFuncionario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // Configurar o DataGridView para quebrar as linhas
            dgvFuncionario.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // Ajustar o estilo do cabeçalho para que possa envolver o texto
            foreach (DataGridViewColumn column in dgvFuncionario.Columns)
            {
                column.HeaderCell.Style.WrapMode = DataGridViewTriState.True;
            }

            // Definir altura das linhas para acomodar o conteúdo completo
            dgvFuncionario.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);

            // Definir o tamanho das linhas do cabeçalho
            dgvFuncionario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFuncionario.ColumnHeadersHeight = 40; // Ajuste o valor conforme desejado

            // Aumentar o tamanho das outras linhas
            dgvDadosUsuario.RowTemplate.Height = 30; // Ajuste o valor conforme desejado para outras linhas

            // Adicionar diferença visual na cor das linhas
            dgvFuncionario.RowsDefaultCellStyle.BackColor = Color.LightGray;
            dgvFuncionario.AlternatingRowsDefaultCellStyle.BackColor = Color.White;


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
            // Permitir que as colunas sejam redimensionadas pelos usuários
            dgvFuncionario.AllowUserToResizeColumns = true;

            // Ajustar o tamanho das colunas automaticamente para exibir todo o conteúdo
            dgvFuncionario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // Configurar o DataGridView para quebrar as linhas
            dgvFuncionario.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // Ajustar o estilo do cabeçalho para que possa envolver o texto
            foreach (DataGridViewColumn column in dgvFuncionario.Columns)
            {
                column.HeaderCell.Style.WrapMode = DataGridViewTriState.True;
            }

            // Definir altura das linhas para acomodar o conteúdo completo
            dgvFuncionario.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);

            // Definir o tamanho das linhas do cabeçalho
            dgvFuncionario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFuncionario.ColumnHeadersHeight = 40; // Ajuste o valor conforme desejado

            // Aumentar o tamanho das outras linhas
            dgvDadosUsuario.RowTemplate.Height = 30; // Ajuste o valor conforme desejado para outras linhas

            // Adicionar diferença visual na cor das linhas
            dgvFuncionario.RowsDefaultCellStyle.BackColor = Color.LightGray;
            dgvFuncionario.AlternatingRowsDefaultCellStyle.BackColor = Color.White;


        }
       

        private void dgvFuncionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          

            if (e.RowIndex >= 0) // Verifica se uma linha válida foi clicada
            {
                DataGridViewRow linhaSelecionada = dgvFuncionario.Rows[e.RowIndex];

                // Preenche as TextBoxes com os dados da linha selecionada
                txtNomeFuncionario.Text = linhaSelecionada.Cells["Nome Completo"].Value.ToString(); // Substitua "NomeColuna" pelo nome da coluna no DataGridView
                txtIDFuncionario.Text = linhaSelecionada.Cells["Código"].Value.ToString(); // Substitua "IdadeColuna" pelo nome da coluna no DataGridView
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

        private void btnDesemcriptarSenha_Click(object sender, EventArgs e)
        {

            txtSenha.Text = senhaOriginal;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (pnlCadastrar.Visible==true)
            {
                pnlCadastrar.Visible = false;

            }
        }
    }
}
