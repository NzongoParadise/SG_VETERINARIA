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
    public partial class UserControlDays : UserControl
    {
        public static string static_day;
        public UserControlDays()
        {
            InitializeComponent();
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {
            static_day=lblDays.Text;
        }
        public void days(int numDay)
        {
            lblDays.Text= numDay.ToString();

        }

        private void adicionarPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void agendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            static_day = lblDays.Text;
            frmCadastrarAgendamentoConsulta frm=new frmCadastrarAgendamentoConsulta();
            frm.ShowDialog();
        }
    }
}
