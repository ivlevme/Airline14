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
    public partial class EngineerAllReportsForm : BaseForm
    {
        public EngineerAllReportsForm()
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
            EngineerMainForm engMain = new EngineerMainForm();
            engMain.Show();
            this.Hide();
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exitMenuStrip();
        }

        private void добавитьНовогоПользователяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EngineerAddReportsForm engAddreports = new EngineerAddReportsForm();
            engAddreports.Show();
            this.Hide();
        }

        private void добавитьАэротехнкикуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EngineerAddAerotechnicsForm engineerAddAerotechnics = new EngineerAddAerotechnicsForm();
            engineerAddAerotechnics.Show();
            this.Hide();
        }

        private void списокВсейАэротехнкикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EngineerAllAerotechnicsForm engAllAero = new EngineerAllAerotechnicsForm();
            engAllAero.Show();
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

        private void EngineerAllReportsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'airlineDBDataSet2.Reports' table. You can move, or remove it, as needed.
            this.reportsTableAdapter.Fill(this.airlineDBDataSet2.Reports);

        }
    }
}
