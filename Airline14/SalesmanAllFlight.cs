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
    public partial class SalesmanAllFlight : BaseForm
    {
        public SalesmanAllFlight()
        {
            InitializeComponent();
        }

        private void SalesmanAllFlight_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'airlineDBDataSet2.Flights' table. You can move, or remove it, as needed.
            this.flightsTableAdapter.Fill(this.airlineDBDataSet2.Flights);

        }

        private void создатьАвирейсToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesmanAddTicketForm salesmanAddTicket = new SalesmanAddTicketForm();
            salesmanAddTicket.Show();
            this.Hide();
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exitMenuStrip();
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

        private void списрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesmanAllUsersForm salesmanAllUsers = new SalesmanAllUsersForm();
            salesmanAllUsers.Show();
            this.Hide();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutProgramForm aboutProgram = new AboutProgramForm();
            aboutProgram.Show();
        }
    }
}
