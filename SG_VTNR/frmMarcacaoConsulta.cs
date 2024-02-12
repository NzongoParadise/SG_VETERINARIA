using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SG_VTNR
{
    public partial class frmMarcacaoConsulta : Form
    {
        public static int static_month;
        public static int static_year;
        int month;
        int year;


        public frmMarcacaoConsulta()
        {
            InitializeComponent();

        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmMarcacaoConsulta_Load(object sender, EventArgs e)
        {
            displaDay();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            
        }

        private void btnMarcarConsulta_Click(object sender, EventArgs e)
        {


        }

        private void guna2Button14_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
        private void guna2DateTimePicker2_ValueChanged_1(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();
            // Para extrair o ano selecionado
            year = dateTimePicker2.Value.Year;

            // Para extrair o mês selecionado
            month = dateTimePicker2.Value.Month;

            static_month = month;
            static_year = year;

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lblDate.Text = monthname + " " + year;
            //Lets get the first day of the month
            DateTime startofthemonth = new DateTime(year, month, 1);
            //get the count of daays of month
            int days = DateTime.DaysInMonth(year, month);
            //convert the startofthemonth to integer
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            //first lest create a blank usercontrol
            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlDays ucblank = new UserControlDays();
                daycontainer.Controls.Add(ucblank);
            }
            // now lets create usercontrol for days
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }

        private void displaDay()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lblDate.Text = monthname + " " + year;

            static_month = month;
            static_year = year;

            //Lets get the first day of the month
            DateTime startofthemonth = new DateTime(year, month, 1);
            //get the count of daays of month
            int days = DateTime.DaysInMonth(year, month);
            //convert the startofthemonth to integer
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            //first lest create a blank usercontrol
            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlDays ucblank = new UserControlDays();
                daycontainer.Controls.Add(ucblank);
            }
            // now lets create usercontrol for days
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);

            }
        }

        private void btnPrevios_Click(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();
            //decrement month to go to prevous month
            month--;

            static_month = month;
            static_year = year;

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lblDate.Text = monthname + " " + year;
            //Lets get the first day of the month
            DateTime startofthemonth = new DateTime(year, month, 1);
            //get the count of daays of month
            int days = DateTime.DaysInMonth(year, month);
            //convert the startofthemonth to integer
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            //first lest create a blank usercontrol
            for (int i = 1; i <= dayoftheweek; i++)
            {
                UserControlDays ucblank = new UserControlDays();
                daycontainer.Controls.Add(ucblank);
            }
            // now lets create usercontrol for days
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }

        }

        private void btnNext_Click(object sender, EventArgs e)
        {

        }

        private void btnNext_Click_1(object sender, EventArgs e)
        {
            // clear container
            daycontainer.Controls.Clear();
            //increment month to go to next month
            month++;

            static_month = month;
            static_year = year;

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lblDate.Text = monthname + " " + year;
            //Lets get the first day of the month
            DateTime startofthemonth = new DateTime(year, month, 1);
            //get the count of daays of month
            int days = DateTime.DaysInMonth(year, month);
            //convert the startofthemonth to integer
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            //first lest create a blank usercontrol
            for (int i = 1; i <= dayoftheweek; i++)
            {
                UserControlDays ucblank = new UserControlDays();
                daycontainer.Controls.Add(ucblank);
            }
            // now lets create usercontrol for days
            for (int i = 1; i < days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }

        private void btnPrevios_Click_1(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();
            //decrement month to go to prevous month
            month--;

            static_month = month;
            static_year = year;

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lblDate.Text = monthname + " " + year;
            //Lets get the first day of the month
            DateTime startofthemonth = new DateTime(year, month, 1);
            //get the count of daays of month
            int days = DateTime.DaysInMonth(year, month);
            //convert the startofthemonth to integer
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            //first lest create a blank usercontrol
            for (int i = 1; i <= dayoftheweek; i++)
            {
                UserControlDays ucblank = new UserControlDays();
                daycontainer.Controls.Add(ucblank);
            }
            // now lets create usercontrol for days
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }

        }
    }
}
