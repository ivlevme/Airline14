using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Airline14
{
    public partial class ManageReportViewMoney : Airline14.BaseForm
    {
        public ManageReportViewMoney()
        {
            InitializeComponent();
        }

        private void NameLabel_Click(object sender, EventArgs e)
        {

        }

        private void ManageReportViewMoney_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.Stats' table. You can move, or remove it, as needed.
            this.StatsTableAdapter.Fill(this.DataSet1.Stats);

            this.reportViewer1.RefreshReport();
        }
    }
}
