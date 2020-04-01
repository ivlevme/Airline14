using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline14
{
    public partial class SalesmanAddUserForm : BaseForm
    {
        public SalesmanAddUserForm()
        {
            InitializeComponent();
        }

        private void оПрограммеToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AboutProgramForm aboutProgram = new AboutProgramForm();
            aboutProgram.Show();
        }

        private void вернутьсяНаГлавнуюСтраницуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesmanMainForm salesmanMain = new SalesmanMainForm();
            salesmanMain.Show();
            this.Hide();
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exitMenuStrip();
        }

        private void создатьАвирейсToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesmanAddTicketForm salesmanAddTicket = new SalesmanAddTicketForm();
            salesmanAddTicket.Show();
            this.Hide();
        }

        private void просмотрВсехАвиарейсовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesmanAllTicketsForm salesmanAllTicketsForm = new SalesmanAllTicketsForm();
            salesmanAllTicketsForm.Show();
            this.Hide();
        }

        private void списрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesmanAllUsersForm salesmanAllUsers = new SalesmanAllUsersForm();
            salesmanAllUsers.Show();
            this.Hide();
        }
    }
}
