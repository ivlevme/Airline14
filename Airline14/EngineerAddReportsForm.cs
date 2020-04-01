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
    public partial class EngineerAddReportsForm : BaseForm
    {
        public EngineerAddReportsForm()
        {
            InitializeComponent();
        }

        private void SinginBtn_Click(object sender, EventArgs e)
        {

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

        private void просмотрВсехПользователейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EngineerAllReportsForm engAllReports = new EngineerAllReportsForm();
            engAllReports.Show();
            this.Hide();
        }

        private void списокВсейАэротехнкикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EngineerAllAerotechnicsForm engAllAero = new EngineerAllAerotechnicsForm();
            engAllAero.Show();
            this.Hide();
        }

        private void добавитьАэротехникуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EngineerAddAerotechnicsForm engineerAddAerotechnics =  new EngineerAddAerotechnicsForm();
            engineerAddAerotechnics.Show();
            this.Hide();
        }
    }
}
