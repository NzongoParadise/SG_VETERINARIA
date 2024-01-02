using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferramenta
{
    class FormatandoDGV
    {
        public static string formatarGridView(DataGridView nomedgv)
        {
            //nomedgv.AutoGenerateColumns = false;
            nomedgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            nomedgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            nomedgv.RowHeadersVisible = false; //desabilita a coluna que mostra o status, coluna automatica
            //altera a cor das linhas alternadas no grid
            nomedgv.RowsDefaultCellStyle.BackColor = System.Drawing.Color.MintCream;
            nomedgv.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.Gainsboro;
            //seleciona a linha inteira
            nomedgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //não permite seleção de multiplas linhas
            nomedgv.MultiSelect = false;
            // exibe nulos formatados
            nomedgv.DefaultCellStyle.NullValue = " - ";
            //permite que o texto maior que célula não seja truncado(... apos o tamanho da celular)
            nomedgv.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            return "";
        }

    }
}
