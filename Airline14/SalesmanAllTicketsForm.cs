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
    public partial class SalesmanAllTicketsForm : BaseForm
    {
        public SalesmanAllTicketsForm()
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

        private void сформироватьОтчетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesmanAddUserForm salesmanAddUser = new SalesmanAddUserForm();
            salesmanAddUser.Show();
            this.Hide();
        }

        private void списрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesmanAllUsersForm salesmanAllUsers = new SalesmanAllUsersForm();
            salesmanAllUsers.Show();
            this.Hide();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveRecord();
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            saveRecord();
        }

        private void toolStripButtonRemove_Click(object sender, EventArgs e)
        {
            delRecord();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            delRecord();
        }

        private void SalesmanAllTicketsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'airlineDBDataSet2.Tickets' table. You can move, or remove it, as needed.
            this.ticketsTableAdapter.Fill(this.airlineDBDataSet2.Tickets);
            // TODO: This line of code loads data into the 'airlineDBDataSet2.Tickets' table. You can move, or remove it, as needed.
            this.ticketsTableAdapter.Fill(this.airlineDBDataSet2.Tickets);

        }

        private void просмотретьВсеАвиарейсыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesmanAllFlight salesmanAllFlight = new SalesmanAllFlight();
            salesmanAllFlight.Show();
            this.Hide();
        }
    }
}
