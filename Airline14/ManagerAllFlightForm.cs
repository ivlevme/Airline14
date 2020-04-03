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
    public partial class ManagerAllFlightForm : BaseForm
    {
        public ManagerAllFlightForm()
        {
            InitializeComponent();
        }

        private void оПрограммеToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AboutProgramForm aboutProgram = new AboutProgramForm();
            aboutProgram.Show();
        }

        private void вернутьсяНаГлавнуюСтраницуМенеджераToolStripMenuItem_Click(object sender, EventArgs e)
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
            ManagerAddDestinationForm managerAddDestination = new ManagerAddDestinationForm();
            managerAddDestination.Show();
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

        private void ManagerAllFlightForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'airlineDBDataSet2.Flights' table. You can move, or remove it, as needed.
            this.flightsTableAdapter.Fill(this.airlineDBDataSet2.Flights);
            // TODO: This line of code loads data into the 'airlineDBDataSet2.Flights' table. You can move, or remove it, as needed.
            this.flightsTableAdapter.Fill(this.airlineDBDataSet2.Flights);
            // TODO: This line of code loads data into the 'airlineDBDataSet2.Flights' table. You can move, or remove it, as needed.
            this.flightsTableAdapter.Fill(this.airlineDBDataSet2.Flights);

        }

        private void fillByTestToolStripButton_Click(object sender, EventArgs e)
        {
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {

        }
    }
}
