using Microsoft.Reporting.WinForms;
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
    public partial class ManagerDoneReportForm : BaseForm
    {
        public ManagerDoneReportForm()
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
        }

        private void просмотрВсехАвиарейсовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagerAllFlightForm managerAllFlight = new ManagerAllFlightForm();
            managerAllFlight.Show();
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

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutProgramForm aboutProgram = new AboutProgramForm();
            aboutProgram.Show();
        }

        private void ManagerDoneReportForm_Load(object sender, EventArgs e)
        {

            //dataGridView1.Rows.Add("1", "65", (65 * 200).ToString() + "$");
            //dataGridView1.Rows.Add("2", "35", (35 * 200).ToString() + "$");
            //dataGridView1.Rows.Add("3", "100", (35 * 200).ToString() + "$");
            //dataGridView1.Rows.Add("4", "200", (35 * 200).ToString() + "$");
            //dataGridView1.Rows.Add("5", "234", (35 * 200).ToString() + "$");

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                MessageBox.Show(dataGridView1.SelectedCells[0].RowIndex.ToString());
            }
        }

        private void ManagerDoneReportForm_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'AirlineDBDataSet2.Tickets' table. You can move, or remove it, as needed.
            this.TicketsTableAdapter.Fill(this.AirlineDBDataSet2.Tickets);
        }
    }
}
