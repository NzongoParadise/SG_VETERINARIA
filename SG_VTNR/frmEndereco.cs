﻿using BLL;
using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SG_VTNR
{
    public partial class frmAdicionarEndereco : Form
    {
        public string id_endereco = "";
        public string mostrare_endereco = "";

        public frmAdicionarEndereco()
        {
            InitializeComponent();
            exibir();
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
                txtCidade.Enabled = false;
                txtBairro.Enabled = false;
                txtEmail.Enabled = false;
                txtMunicipio.Enabled = false;
                txtComuna.Enabled = false;
                txtRua.Enabled = false;
                txtTelfone2.Enabled = false;
                txtTelefone1.Enabled = false;


            }

            if (op == 2)
            {
                btnGuardar.Enabled = true;
                btnEditar.Enabled = false;
                btnCancelar.Enabled = true;
                btnNovo.Enabled = true;
                txtCidade.Enabled = true;
                txtBairro.Enabled = true;
                txtEmail.Enabled = true;
                txtTelfone2.Enabled = true;
                txtTelefone1.Enabled = true;
                txtMunicipio.Enabled = true;
                txtComuna.Enabled = true;
                txtRua.Enabled = true;
                txtProvincia.Enabled = true;


            }
            if (op == 3)
            {

                btnEditar.Enabled = true;
                btnCancelar.Enabled = true;
                btnNovo.Enabled = true;
                btnGuardar.Enabled = false;

                txtCidade.Enabled = true;
                txtBairro.Enabled = true;
                txtEmail.Enabled = true;
                txtTelfone2.Enabled = true;
                txtTelefone1.Enabled = true;
                txtMunicipio.Enabled = true;
                txtComuna.Enabled = true;
                txtRua.Enabled = true;
                txtProvincia.Enabled = true;


            }

        }

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (pnlCadastarEndreco.Visible == false)
            {
                pnlCadastarEndreco.Visible = true;
            }
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            pnlCadastarEndreco.Visible = false;
        }
        private void LimparTela()
        {
            txtRua.Text = " ";
            txtBairro.Clear();
            txtCidade.Clear();
            txtComuna.Clear();
            txtEmail.Clear();
            txtPesquisar.Clear();
            txtTelefone1.Clear();
            txtTelfone2.Clear();
            txtMunicipio.Clear();
            txtProvincia.Clear();
            txtMunicipio.Clear();

        }
        private void frmEndereco_Load(object sender, EventArgs e)
        {
            if (pnlCadastarEndreco.Visible == true)
            {
                pnlCadastarEndreco.Visible = false;
            }
        }
        public void exibir()
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLEndereco bll = new BLLEndereco(cx);
            dgvDados.DataSource = bll.Localizar(txtPesquisar.Text);
            //CarregarTituloDgv();
            //FormatandoDGV.
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            alteraBotoes(2, perInserir, perAlterar, perExcluir, perImprimir);
            LimparTela();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //try
            //{
            ModeloEndereco modelo = new ModeloEndereco();
            modelo.Bairro1 = txtBairro.Text;
            modelo.Cidade1 = txtCidade.Text;
            modelo.Email1 = txtEmail.Text;
            modelo.Rua1 = txtRua.Text;
            modelo.Comuna1 = txtComuna.Text;
            modelo.Municipio1 = txtMunicipio.Text;
            modelo.Telefone11 = txtTelefone1.Text;
            modelo.Telefone21 = txtTelfone2.Text;
            modelo.Provincia1 = txtProvincia.Text;
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLEndereco bll = new BLLEndereco(cx);
            //inserir os dados
            bll.Incluir(modelo);
            MessageBox.Show("Cadastrado com sucesso ", modelo.EndrecoID1.ToString());
            //ethis.Alert("Código: " + modelo.PropietarioId.ToString() + "\n Cadastrado com sucesso!", frmAlert.enmType.Success);
            LimparTela();
            exibir();

            //}
            //catch (Exception)
            //{

            //    /*    {
            //            MessageBox.Show("Não foi possivel Realizar a Operação!!! \n\nContate o Administrador do Sistema!!!\n\nErro Ocorrido:" + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //        }*/
            //}
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                ModeloEndereco modelo = new ModeloEndereco();
                modelo.EndrecoID1 =Convert.ToInt32( txtEnderecoID.Text);
                modelo.Bairro1 = txtBairro.Text;
                modelo.Cidade1 = txtCidade.Text;
                modelo.Email1 = txtEmail.Text;
                modelo.Rua1 = txtRua.Text;
                modelo.Comuna1 = txtComuna.Text;
                modelo.Municipio1 = txtMunicipio.Text;
                modelo.Telefone11 = txtTelefone1.Text;
                modelo.Telefone21 = txtTelfone2.Text;
                modelo.Provincia1 = txtProvincia.Text;
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLEndereco bll = new BLLEndereco(cx);
                //inserir os dados
                bll.Alterar(modelo);
                MessageBox.Show("Dados Alterados com Sucesso", modelo.EndrecoID1.ToString());
               
                //ethis.Alert("Código: " + modelo.PropietarioId.ToString() + "\n Cadastrado com sucesso!", frmAlert.enmType.Success);
                LimparTela();
                exibir();

            }
            catch (Exception)
            {


                throw;
            }
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            exibir();
        }

        private void txtMunicipio_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void dgvDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvDados.Columns[e.ColumnIndex].Name;

            if (colName == "btnDeletar" && e.RowIndex >= 0)
            {
                try
                {
                    DialogResult d = MessageBox.Show("Deseja realmente excluir os dados?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                    if (d == DialogResult.Yes)
                    {
                        int col = Convert.ToInt32(dgvDados.CurrentRow.Cells["EnderecoID"].Value);
                        DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                        BLLEndereco bll = new BLLEndereco(cx);
                        bll.EliminarEndereco(Convert.ToInt32(col));

                        MessageBox.Show("Dados eliminados com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        frmAdicionarEndereco fr = new frmAdicionarEndereco();
                        fr.ShowDialog();
                        // Atualizar a exibição dos dados na DataGridView
                        exibir();
                    }
                    else if (d == DialogResult.No)
                    {
                        frmAdicionarEndereco fr = new frmAdicionarEndereco();
                        fr.ShowDialog();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao excluir: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (colName == "btnEdit")
            {
                txtEnderecoID.Text = dgvDados.Rows[e.RowIndex].Cells["EnderecoID"].Value.ToString();
                txtBairro.Text = dgvDados.Rows[e.RowIndex].Cells["Bairro"].Value.ToString();
                txtCidade.Text = dgvDados.Rows[e.RowIndex].Cells["Cidade"].Value.ToString();
                txtRua.Text = dgvDados.Rows[e.RowIndex].Cells["Rua"].Value.ToString();
                txtEmail.Text = dgvDados.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                txtTelefone1.Text = dgvDados.Rows[e.RowIndex].Cells["Telefone1"].Value.ToString();
                txtTelfone2.Text = dgvDados.Rows[e.RowIndex].Cells["Telefone2"].Value.ToString();
               
                txtMunicipio.Text = dgvDados.Rows[e.RowIndex].Cells["Municipio"].Value.ToString();
                txtComuna.Text = dgvDados.Rows[e.RowIndex].Cells["Comuna"].Value.ToString();
                txtProvincia.Text = dgvDados.Rows[e.RowIndex].Cells["Provincia"].Value.ToString();
                alteraBotoes(3, perInserir, perAlterar, perExcluir, perImprimir);
                if (pnlCadastarEndreco.Visible == false)
                {
                    pnlCadastarEndreco.Visible = true;
                }

            }

            // Verifica se alguma linha está selecionada
            //if (dgvDados.SelectedRows.Count > 0)
            //{
            //    DataGridViewRow selectedRow = dgvDados.SelectedRows[0];

            //    // Captura os dados da linha selecionada
            //    this.id_endereco = selectedRow.Cells["EnderecoID"].Value.ToString();
            //    string Cidade = selectedRow.Cells["Cidade"].Value.ToString();
            //    string Bairro = selectedRow.Cells["Bairro"].Value.ToString();
            //    string Rua = selectedRow.Cells["Rua"].Value.ToString();
            //    this.mostrare_endereco = Cidade + " " + Bairro + " " + Rua;

            //    this.Close();

            //}                   

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparTela();
        }
    }
}
