using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline14
{
    public partial class ManagerMainForm : BaseForm
    {
        public ManagerMainForm()
        {
            InitializeComponent();
        }

        private void AddFlightBtn_Click(object sender, EventArgs e)
        {
        }

        private void AllFlightBtn_Click(object sender, EventArgs e)
        {
            ManagerAllFlightForm managerAllFlight = new ManagerAllFlightForm();
            managerAllFlight.Show();
            this.Hide();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutProgramForm aboutProgram = new AboutProgramForm();
            aboutProgram.Show();
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
        }

        private void createReportBTN_Click(object sender, EventArgs e)
        {
            ManagerCreateReportForm managerCreateReport = new ManagerCreateReportForm();
            managerCreateReport.Show();
            this.Hide();
        }

        private void AllDestinationBTN_Click(object sender, EventArgs e)
        {
            ManagerAllDestionationForm managerAllDestionation = new ManagerAllDestionationForm();
            managerAllDestionation.Show();
            this.Hide();
        }

        private void AddDestinationBTN_Click(object sender, EventArgs e)
        {
        }

        private void createReportViewBTN_Click(object sender, EventArgs e)
        {
            ManagerReportViewClients managerReportView = new ManagerReportViewClients();
            managerReportView.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManageReportViewMoney manageReportViewMoney = new ManageReportViewMoney();
            manageReportViewMoney.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManagerReportXMLClients managerReportXMLClients = new ManagerReportXMLClients();
            managerReportXMLClients.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection;
            sqlConnection = new SqlConnection(connectionPath);
            sqlConnection.Open();

            SqlDataReader sdr = null;

            DataSet ds = new DataSet();

            string defineStatusFlight(DateTime timeFlight)
            {
                DateTime borderTime = new DateTime(2020, 1, 1, 12, 0, 0);
                Console.WriteLine(borderTime.Hour);
                Console.WriteLine(timeFlight);

                if (borderTime.Hour < timeFlight.Hour) { 
                    return "Afternoon";
                } else
                {
                    return "Morning";
                }
            }

            List<int> getAllPassengers (int numberFlight)
            {
                SqlCommand cmdTest = new SqlCommand($"SELECT [ID Passenger] FROM Tickets Where [Number Flight] = {numberFlight}", sqlConnection);
                List<int> results = new List<int>();

                SqlDataReader sdrPass = cmdTest.ExecuteReader();

                while (sdrPass.Read())
                {
                    results.Add(Int32.Parse(sdr["ID Passenger"].ToString()));
                    Console.WriteLine($"PASSENGERS ID: {sdr["ID Passenger"]} ");
                }

                sdrPass.Close();
                return results;
            }



            DateTime testTime = new DateTime(2020, 1, 1, 13, 0, 0);
            Console.WriteLine(defineStatusFlight(testTime));

           

            //SqlCommand cmdSelectFlight = new SqlCommand("SELECT Number, [ID Aerotechnic] FROM Flights", sqlConnection);
            //sdr = cmdSelectFlight.ExecuteReader();

            // загрузка таблицы полётов
            SqlDataAdapter adapterFlights = new SqlDataAdapter("SELECT Number, [ID Aerotechnic], [Departure time] FROM Flights", sqlConnection);
            adapterFlights.Fill(ds, "Flights");

            // загрузка таблицы полётов
            SqlDataAdapter adapterTickets = new SqlDataAdapter("SELECT [ID Passenger], [Number Flight] FROM Tickets", sqlConnection);
            adapterTickets.Fill(ds, "Tickets");

            sqlConnection.Close();

            foreach (DataTable dt in ds.Tables) 
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

            StreamWriter tf = new StreamWriter(new FileStream("C:\\Users\\79266\\Documents\\ВУЗ\\БД лабы\\10Лаб\\Results.csv", FileMode.Create));
            // запись строки заголовка таблицы.
            // Для вывода кавычек используется \”
            tf.WriteLine("\"NumberFlight\";\"IDAerotechnics\";\"IDPassengers\";\"TypeFlight\";\"CountPassengers\"");

            //Генерация данных

            // цикл перебора всех полетов
            foreach (DataRow flight in ds.Tables["Flights"].Rows)
            {
                int currentFlightNumber = Int32.Parse(flight.ItemArray[0].ToString());
                int currentFlightAerotechnics = Int32.Parse(flight.ItemArray[1].ToString());
                // определение статуса полета
                string currentFlightStatus = defineStatusFlight(DateTime.Parse(flight.ItemArray[2].ToString()));

                // Подсчет количества пассажиров
                int countFlightPassenger = 0;

                foreach (DataRow ticket in ds.Tables["Tickets"].Rows)
                {
                    if (Int32.Parse(ticket.ItemArray[1].ToString()) == currentFlightNumber)
                    {
                        countFlightPassenger = countFlightPassenger + 1;
                    }
                }

                Console.WriteLine($"currentFlightNumber = {currentFlightNumber}");
                Console.WriteLine($"currentFlightStatus = {currentFlightStatus}");
                Console.WriteLine($"countFlightPassenger = {countFlightPassenger}");

                // Определение ID пассажира
                foreach (DataRow ticket in ds.Tables["Tickets"].Rows)
                {
                    int currentNumberFlightTicket = Int32.Parse(ticket.ItemArray[1].ToString());
                    if (currentNumberFlightTicket == currentFlightNumber)
                    {
                        Console.WriteLine($"currentPassenger = {ticket.ItemArray[0]}");
                        tf.WriteLine("{0};{1};{2};{3};{4}",
                            currentFlightNumber,
                            currentFlightAerotechnics,
                            ticket.ItemArray[0],
                            currentFlightStatus,
                            countFlightPassenger);
                    } 
                }

            }    

                tf.Close();
            MessageBox.Show("Данные были успешно сгенерированы!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
