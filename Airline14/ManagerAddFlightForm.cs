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
    public partial class ManagerAddFlightForm : BaseForm
    {
        public ManagerAddFlightForm()
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
            ManagerAddDestinationForm managerAddDestination = new ManagerAddDestinationForm();
            managerAddDestination.Show();
            this.Hide();
        }

        private void ManagerAddFlightForm_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker1.ShowUpDown = true;

            dateTimePicker2.Format = DateTimePickerFormat.Time;
            dateTimePicker2.ShowUpDown = true;
        }

        private void AddFlightBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Проверка даты, чтобы не была позднее настоящей даты!");
        }
    }
}
