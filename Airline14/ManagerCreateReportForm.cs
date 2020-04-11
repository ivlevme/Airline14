using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
                string connectionPath = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\79266\source\repos\Airline14\Airline14\AirlineDB.mdf;Integrated Security=True;Connect Timeout=30";
                SqlConnection connection = new SqlConnection(connectionPath);
                SqlCommand selectForReports = new SqlCommand($"DECLARE @datePast DATETIME; DECLARE @dateFuture DATETIME; SET @datePast = CONVERT(DATETIME, '{PastDateTimePicker.Value.ToString("dd.MM.yyy")}', 104); SET @dateFuture = CONVERT(DATETIME, '{FutureDateTimePicker.Value.ToString("dd.MM.yyy")}', 104); SELECT [Date], [Number Flight], COUNT(*) AS Test FROM Tickets WHERE [Date] >= @datePast AND [Date] <= @dateFuture GROUP BY [Number Flight], Date", connection);


                ManagerDoneReportForm managerDoneReport = new ManagerDoneReportForm();

                connection.Open();

                try
                {
                    bool isRespEmpty = true;
                    sdr = selectForReports.ExecuteReader();
                    while (sdr.Read())
                    {
                        isRespEmpty = false;
                        managerDoneReport.FirstDateLabel.Text = PastDateTimePicker.Value.ToString("dd.MM.yyy");
                        managerDoneReport.LastDateLabel.Text = FutureDateTimePicker.Value.ToString("dd.MM.yyy");

                        managerDoneReport.dataGridView1.Rows.Add(sdr["Number Flight"].ToString(), sdr["Test"].ToString(), (int.Parse(sdr["Test"].ToString()) * 65).ToString() +" $", sdr["Date"].ToString());
                    }

                    sdr.Close();

                    if (isRespEmpty == true)
                    {
                        MessageBox.Show("За выбранный период данные отсутствуют, попробуйте выбрать другой диапазон дат", "Данные отсутствуют", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    } else
                    {
                        managerDoneReport.Show();
                        this.Hide();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
