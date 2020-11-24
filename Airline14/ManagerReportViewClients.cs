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
            // TODO: This line of code loads data into the 'dataSet1.Passengers' table. You can move, or remove it, as needed.
            this.passengersTableAdapter.Fill(this.dataSet1.Passengers);
            //// TODO: This line of code loads data into the 'dataSet1.Passengers' table. You can move, or remove it, as needed.
            this.passengersTableAdapter.Fill(this.dataSet1.Passengers);

            ReportDataSource datasource = new ReportDataSource("DataSet1", this.dataSet1.Tables["Passengers"]);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportPath = "../../Report1.rdlc";
            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            reportViewer1.LocalReport.DataSources.Add(datasource);

            reportViewer1.RefreshReport();

            foreach (DataTable dt in this.dataSet1.Tables)
            {
                Console.WriteLine(dt.TableName); // название таблицы
                                                 // перебор всех столбцов
                foreach (DataColumn column in dt.Columns)
                    Console.Write("\t{0}", column.ColumnName);
                Console.WriteLine();
                // перебор всех строк таблицы
                foreach (DataRow row in dt.Rows)
                {
                    // получаем все ячейки строки
                    var cells = row.ItemArray;
                    foreach (object cell in cells)
                        Console.Write("\t{0}", cell);
                    Console.WriteLine();
                }
            }
        }
    }
}
