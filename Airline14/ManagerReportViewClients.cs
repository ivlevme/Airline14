using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Airline14
{
    public partial class ManagerReportViewClients : Airline14.BaseForm
    {
        public ManagerReportViewClients()
        {
            InitializeComponent();
        }

        private void ManagerReportView_Load(object sender, EventArgs e)
        {
            this.passengersTableAdapter.Fill(this.dataSet1.Passengers);


            ReportDataSource datasource = new ReportDataSource("DataSet1", this.dataSet1.Tables["Passengers"]);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportPath = "../../Report1.rdlc";
            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            reportViewer1.LocalReport.DataSources.Add(datasource);

            reportViewer1.RefreshReport();
        }
    }
}
