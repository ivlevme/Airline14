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
    public partial class SalesmanAllUsersForm : BaseForm
    {
        public SalesmanAllUsersForm()
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

        private void сформироватьОтчетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesmanAddUserForm salesmanAddUser = new SalesmanAddUserForm();
            salesmanAddUser.Show();
            this.Hide();
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            saveRecord();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void SalesmanAllUsersForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'airlineDBDataSet2.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.airlineDBDataSet2.Users);

        }
    }
}
