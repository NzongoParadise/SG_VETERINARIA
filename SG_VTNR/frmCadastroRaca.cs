using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Modelo;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;
using System.Data.SqlClient;
using System.IO;

namespace SG_VTNR
{
    public partial class frmCadastroRaca : Form

    {
        private int  idracaselecionado=0;
        public frmCadastroRaca()
        {
            InitializeComponent();
        }

        private void pnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
                    }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (GboxCadastrarRaca.Visible==false)
            {
                GboxCadastrarRaca.Visible = true;
            }
            txtNomeRaca.Focus();
        }

        private void frmCadastroRaca_Load(object sender, EventArgs e)
        {
            if (GboxCadastrarRaca.Visible == true)
            {
                GboxCadastrarRaca.Visible = false;
            }

            selecionanarTodasRacas();
        }
        public void selecionanarTodasRacas()
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLRacaAnimal bll = new BLLRacaAnimal(cx);
            dgvMostarRaca.DataSource = bll.selecionanarTodasRacas();

            
        }

        private void btnCadastrarRaca_Click(object sender, EventArgs e)
        {
            
        }
        public void limparCampos()
        {
            txtNomeRaca.Text = "";
            txtDecsricao.Text = "";
        }
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                ModeloRacaAnimal modelo = new ModeloRacaAnimal();
                DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLRacaAnimal bll = new BLLRacaAnimal(conexao);
                modelo.nomeRaca = txtNomeRaca.Text;
                modelo.Descricao = txtDecsricao.Text;
                bll.incluirRaca(modelo);
            
           
            MessageBox.Show("\n \n Raça Cadastrada com Sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //ethis.Alert("Código: " + modelo.PropietarioId.ToString() + "\n Cadastrado com sucesso!", frmAlert.enmType.Success);
                selecionanarTodasRacas();
                limparCampos();

            }
            catch (Exception erro)
            {

                MessageBox.Show("Não foi possivel Realizar a Operação!!! \n\nContate o Administrador do Sistema!!!\n\nErro Ocorrido:" + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }


}

       
      
        private void btnFrcharformularioRaca_MouseEnter(object sender, EventArgs e)
        {
            btnFrcharformularioRaca.FillColor = Color.Red;

        }

        private void btnFrcharformularioRaca_MouseLeave(object sender, EventArgs e)
        {
            string corHexadecimal = "82; 146; 254";

            // Dividindo os valores e convertendo para int
            string[] valores = corHexadecimal.Split(';');
            int red = int.Parse(valores[0]);
            int green = int.Parse(valores[1]);
            int blue = int.Parse(valores[2]);

            // Criando um objeto Color
            Color cor = Color.FromArgb(red, green, blue);

            // Agora você pode usar a variável 'cor' conforme necessário

            // Altera a cor de fundo quando o mouse entra no botão
            btnFrcharformularioRaca.FillColor = cor;
        }

        private void btnFrcharformularioRaca_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFecharGBoxCadRaca_Click(object sender, EventArgs e)
        {
            if (GboxCadastrarRaca.Visible == true)
            {
                GboxCadastrarRaca.Visible = false;
            }
        }

        private void btnFecharGBoxCadRaca_MouseLeave(object sender, EventArgs e)
        {
            string corHexadecimal = "82; 146; 254";

            // Dividindo os valores e convertendo para int
            string[] valores = corHexadecimal.Split(';');
            int red = int.Parse(valores[0]);
            int green = int.Parse(valores[1]);
            int blue = int.Parse(valores[2]);

            // Criando um objeto Color
            Color cor = Color.FromArgb(red, green, blue);

            // Agora você pode usar a variável 'cor' conforme necessário

            // Altera a cor de fundo quando o mouse entra no botão
            btnFecharGBoxCadRaca.FillColor = cor;
        }

        private void btnFecharGBoxCadRaca_MouseEnter(object sender, EventArgs e)
        {
            btnFecharGBoxCadRaca.FillColor = Color.Red;
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            PesquisarRacacomChave();

        }
        public void PesquisarRacacomChave()
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLRacaAnimal bll = new BLLRacaAnimal(cx);
            dgvMostarRaca.DataSource = bll.PesquisarRacacomChave(txtPesquisarRaca.Text);

            // Renomear os cabeçalhos das colunas diretamente no DataGridView
            dgvMostarRaca.Columns["IDRaca"].HeaderText = "Código";
            dgvMostarRaca.Columns["NomeRaca"].HeaderText = "Nome";
            dgvMostarRaca.Columns["Descricao"].HeaderText = "Descricao";

        }

        private void dgvMostarRaca_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvMostarRaca.Columns[e.ColumnIndex].Name;
            if (colName == "colEditar")
            {
                txtNomeRaca.Text = dgvMostarRaca.Rows[e.RowIndex].Cells["NomeRaca"].Value.ToString();
                txtDecsricao.Text = dgvMostarRaca.Rows[e.RowIndex].Cells["Descricao"].Value.ToString();
                txtID.Text = dgvMostarRaca.Rows[e.RowIndex].Cells["IDRaca"].Value.ToString();

                if (GboxCadastrarRaca.Visible == false)
                {
                   
                    GboxCadastrarRaca.Visible = true;
                }

            }
            //if (colName == "ColDeletar")
            //{
            //    try
            //    {
            //        DialogResult d = MessageBox.Show("desejas realmente excluir os dados?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            //        if (d.ToString() == "Yes")
            //        {
            //            //alteraBotoes(1, perInserir, perAlterar, perExcluir, perImprimir);
            //            int col = Convert.ToInt32(dgvMostarRaca.CurrentRow.Cells["IDRaca"].Value);
            //            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            //            BLLRacaAnimal bll = new BLLRacaAnimal(cx);
            //            bll.EliminarRaca(Convert.ToInt32(col));
            //            DialogResult = MessageBox.Show("Raça eliminados com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            //            frmCadastroRaca frm = new frmCadastroRaca();
            //            frm.ShowDialog();
            //            GboxCadastrarRaca.Visible=true;
            //            selecionanarTodasRacas();
            //        }
            //    }
            //    catch (Exception)
            //    {

            //        throw;
            //    }

            //}
            // Fora do loop de exclusão, antes de entrar no DataGridView
          

            if (colName == "ColDeletar")
            {

                int col = Convert.ToInt32(dgvMostarRaca.CurrentRow.Cells["IDRaca"].Value);
                idracaselecionado = col;
                eliminarRaca(col);
            }

        }
        private void eliminarRaca(int col)
        {
            try
            {
                DialogResult d = MessageBox.Show("Desejas realmente excluir os dados?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                if (d.ToString() == "Yes")
                {
                   
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLRacaAnimal bll = new BLLRacaAnimal(cx);
                    bll.EliminarRaca(Convert.ToInt32(col));
                    DialogResult = MessageBox.Show("Raça eliminada com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    // Mostrar o formulário existente como diálogo modal                        
                    selecionanarTodasRacas();
                }
            }
            catch (Exception erro)
            {
                throw new Exception("erro na exlusar:" + erro.Message);
            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            
                try
                {
                    ModeloRacaAnimal modelo = new ModeloRacaAnimal();
                    modelo.IDRaca = Convert.ToInt32(txtID.Text);
                    modelo.nomeRaca = (txtNomeRaca.Text);
                    modelo.Descricao = txtDecsricao.Text;

                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLRacaAnimal bll = new BLLRacaAnimal(cx);
                    bll.atualizarrRaca(modelo);
                    MessageBox.Show("\n Dados da Raça Actualizados com Sucesso!","Confirmação");
                    limparCampos();
                    selecionanarTodasRacas();
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Não foi possivel Realizar a Operação!!! \n\nContate o Administrador do Sistema!!!\n\nErro Ocorrido:" + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            eliminarRaca(idracaselecionado);
        }
    }
    }

