using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Xsl;

namespace Airline14
{
    public partial class ManagerReportXMLClients : Airline14.BaseForm
    {
        public ManagerReportXMLClients()
        {
            InitializeComponent();
        }

        private void NameLabel_Click(object sender, EventArgs e)
        {

        }

        private void ManagerReportXMLClients_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.Passengers' table. You can move, or remove it, as needed.
            this.PassengersTableAdapter.Fill(this.DataSet1.Passengers);

            ReportDataSource datasource = new ReportDataSource("DataSet1", this.DataSet1.Tables["Passengers"]);

            DataSet1.WriteXml("XMLFile1.xml", XmlWriteMode.WriteSchema);

            // создание специального объекта- xslt-преобразователя

            XslCompiledTransform xslt = new XslCompiledTransform();

            // загрузка файла с xslt-преобразованием

           xslt.Load("../../XMLFileClient.xslt");

            // выполнение преобразования и генерация на основе xml-файла

            //html-файла представления данных

            xslt.Transform("XMLFileClient1.xml", "D:\\XMLFileClient.html");

            // загрузка полученного html_файла в элемент управления WebBrowser

            webBrowser1.Navigate("D:\\XMLFileClient.html");
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

            

        }
    }
}
