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
    public partial class ManagerMainForm : BaseForm
    {
        public ManagerMainForm()
        {
            InitializeComponent();
        }

        private void AddFlightBtn_Click(object sender, EventArgs e)
        {
        }

        private void AllFlightBtn_Click(object sender, EventArgs e)
        {
            ManagerAllFlightForm managerAllFlight = new ManagerAllFlightForm();
            managerAllFlight.Show();
            this.Hide();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutProgramForm aboutProgram = new AboutProgramForm();
            aboutProgram.Show();
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exitMenuStrip();
        }

        private void создатьАвирейсToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void просмотрВсехАвиарейсовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagerAllFlightForm managerAllFlight = new ManagerAllFlightForm();
            managerAllFlight.Show();
            this.Hide();
        }

        private void сформироватьОтчетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagerCreateReportForm managerCreateReport = new ManagerCreateReportForm();
            managerCreateReport.Show();
            this.Hide();
        }

        private void всеПToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagerAllDestionationForm managerAllDestionation = new ManagerAllDestionationForm();
            managerAllDestionation.Show();
            this.Hide();
        }

        private void добавлениеПунктаНазначенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void createReportBTN_Click(object sender, EventArgs e)
        {
            ManagerCreateReportForm managerCreateReport = new ManagerCreateReportForm();
            managerCreateReport.Show();
            this.Hide();
        }

        private void AllDestinationBTN_Click(object sender, EventArgs e)
        {
            ManagerAllDestionationForm managerAllDestionation = new ManagerAllDestionationForm();
            managerAllDestionation.Show();
            this.Hide();
        }

        private void AddDestinationBTN_Click(object sender, EventArgs e)
        {
        }

        private void createReportViewBTN_Click(object sender, EventArgs e)
        {
            ManagerReportView managerReportView = new ManagerReportView();
            managerReportView.Show();
            this.Hide();
        }
    }
}
