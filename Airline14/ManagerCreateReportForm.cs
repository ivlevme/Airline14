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
    public partial class ManagerCreateReportForm : BaseForm
    {
        public ManagerCreateReportForm()
        {
            InitializeComponent();
        }

        private void оПрограммеToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AboutProgramForm aboutProgram = new AboutProgramForm();
            aboutProgram.Show();
        }

        private void вернутьсяНаГлавнуюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagerMainForm managerMain = new ManagerMainForm();
            managerMain.Show();
            this.Hide();
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exitMenuStrip();
        }

        private void создатьАвирейсToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagerAddFlightForm addFlightForm = new ManagerAddFlightForm();
            addFlightForm.Show();
            this.Hide();
        }

        private void просмотрВсехАвиарейсовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagerAllFlightForm managerAllFlight = new ManagerAllFlightForm();
            managerAllFlight.Show();
            this.Hide();
        }

        private void сформироватьОтчетToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void всеПToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagerAllDestionationForm managerAllDestionation = new ManagerAllDestionationForm();
            managerAllDestionation.Show();
            this.Hide();
        }

        private void добавлениеПунктаНазначенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagerAddDestinationForm managerAddDestination = new ManagerAddDestinationForm();
            managerAddDestination.Show();
            this.Hide();
        }

        private void MakeReportBTN_Click(object sender, EventArgs e)
        {
            if (checkdate())
            {
                ManagerDoneReportForm managerDoneReport = new ManagerDoneReportForm();
                managerDoneReport.Show();
                this.Hide();
            } else
            {
                ErrorMessageBox();
            }

        }

        private bool checkdate()
        {
            if (PastDateTimePicker.Value <= FutureDateTimePicker.Value)
            {
                return true;
            }

            return false;
        }

        private void ManagerCreateReportForm_Load(object sender, EventArgs e)
        {
            DateTime currentDateTime = DateTime.Now;
            PastDateTimePicker.Value = currentDateTime;
            FutureDateTimePicker.Value = currentDateTime;
        }
    }
}
