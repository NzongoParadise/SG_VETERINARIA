using BLL;
using DAL;
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
    public partial class frmIntermediarioAnimal : Form
    {
        public frmIntermediarioAnimal()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            frmCadastrarAnimalteste frm = new frmCadastrarAnimalteste();
            frm.ShowDialog();   
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            PesquisarAnimalcomChave();
        }
        public void PesquisarAnimalcomChave()
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLAnimal bll = new BLLAnimal(cx);
            dgvExibirAnimal.DataSource = bll.PesquisarAnimalcomChave(txtPesquisarAnimal.Text);

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
}
}
