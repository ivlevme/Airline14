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
    public partial class ManagerAllFlightForm : BaseForm
    {
        public ManagerAllFlightForm()
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

        private void создатьАвирейсToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagerAddFlightForm addFlightForm = new ManagerAddFlightForm();
            addFlightForm.Show();
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

        string[] aeroTypes = new string[100];
        int[] aeroTypesID = new int[100];

        string[] destTypes = new string[100];
        int[] destTypesID = new int[100];


        DateTime RoundUp(DateTime dt, TimeSpan d)
        {
            return new DateTime(((dt.Ticks - d.Ticks + 1) / d.Ticks) * d.Ticks + d.Ticks);
        }



        private void fillComboBoxes()
        {
            SqlConnection connection = new SqlConnection(connectionPath);

            SqlCommand aeroSelect = new SqlCommand("SELECT ID, Name FROM Aerotechnics", connection);
            SqlCommand destSelect = new SqlCommand("SELECT ID, Name FROM Destination", connection);

            connection.Open();

            sdr = aeroSelect.ExecuteReader();

            int indexAero = 0;
            int indexDest = 0;


            while (sdr.Read())
            {
                AerotechnicCB.Items.Add(sdr["Name"].ToString());
                aeroTypes[indexAero] = sdr["Name"].ToString();
                aeroTypesID[indexAero] = int.Parse(sdr["ID"].ToString());
                indexAero++;
            }

            connection.Close();

            connection.Open();

            sdr = destSelect.ExecuteReader();

            while (sdr.Read())
            {
                DestinationCB.Items.Add(sdr["Name"].ToString());
                destTypes[indexDest] = sdr["Name"].ToString();
                destTypesID[indexDest] = int.Parse(sdr["ID"].ToString());
                indexDest++;
            }

            connection.Close();

        }

        private void ManagerAllFlightForm_Load(object sender, EventArgs e)
        {
            this.flightsTableAdapter.Fill(this.airlineDBDataSet2.Flights);

            dataGridView1.CurrentRow.Selected = false;

            DisplayReadOnlyManagerFlight();

            fillComboBoxes();

            AddFlightBtn.Visible = false;
            dateTimePicker3.Enabled = false;

            NumberFlightTB.DataBindings.Add(new Binding("Text", dataSource: flightsBindingSource, dataMember: "Number"));
        }

        bool isBinding = false;
        bool appEditMode = false;

        private void DisplayReadOnlyManagerFlight() {
            AerotechnicCB.Enabled = false;
            DestinationCB.Enabled = false;
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
            FlightDateTimePicker.Enabled = false;

            createToolStripButton.Enabled = true;
            saveToolStripButton.Enabled = false;
            editToolStripButton.Enabled = true;
            UnDoToolStripButton.Enabled = false;

            editFlightToolStripMenuItem.Enabled = true;
            editToolStripMenuItem.Enabled = true;

            createFlightToolStripMenuItem.Enabled = true;

            dateTimePicker1.DataBindings.Add(new Binding("Text", dataSource: flightsBindingSource, dataMember: "Departure time"));
            dateTimePicker2.DataBindings.Add(new Binding("Text", dataSource: flightsBindingSource, dataMember: "Arrivial time"));
            dateTimePicker3.DataBindings.Add(new Binding("Text", dataSource: flightsBindingSource, dataMember: "Time flight"));

            AerotechnicCB.DataBindings.Add(new Binding("Text", dataSource: flightsBindingSource, dataMember: "Name"));
            DestinationCB.DataBindings.Add(new Binding("Text", dataSource: flightsBindingSource, dataMember: "Expr1"));

            FlightDateTimePicker.DataBindings.Add(new Binding("Text", dataSource: flightsBindingSource, dataMember: "Date flight"));

            isBinding = true;
            appEditMode = false;
        }

        private void DisplayEditManagerFlight()
        {
            AerotechnicCB.Enabled = true;
            DestinationCB.Enabled = true;
            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = true;
            FlightDateTimePicker.Enabled = true;

            createToolStripButton.Enabled = false;
            saveToolStripButton.Enabled = true;
            editToolStripButton.Enabled = false;
            UnDoToolStripButton.Enabled = true;

            editFlightToolStripMenuItem.Enabled = false;
            editToolStripMenuItem.Enabled = false;

            createFlightToolStripMenuItem.Enabled = false;
            appEditMode = true;

        }

        private void fillByTestToolStripButton_Click(object sender, EventArgs e)
        {
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            if (checkFlightCorrectData() == true)
            {

            };
        }

        private DateTime startDateTime = DateTime.Now;

        private void createToolStripButton_Click(object sender, EventArgs e)
        {

            dateTimePicker1.DataBindings.Clear();
            dateTimePicker2.DataBindings.Clear();
            dateTimePicker3.DataBindings.Clear();

            AerotechnicCB.DataBindings.Clear();
            DestinationCB.DataBindings.Clear();
            FlightDateTimePicker.DataBindings.Clear();
            isBinding = false;





            dataGridView1.CurrentRow.Selected = false;

            DisplayEditManagerFlight();
            AddFlightBtn.Visible = true;

            NumberFlightTB.Text = "";
            AerotechnicCB.Text = "";
            DestinationCB.Text = "";

            dateTimePicker1.Value = startDateTime;
            dateTimePicker2.Value = startDateTime;
            FlightDateTimePicker.Value = startDateTime;
        }

        private void saveFlight ()
        {
            if (checkFlightCorrectData() == true)
            {

                int indexAero = Array.IndexOf(aeroTypes, AerotechnicCB.SelectedItem);
                int idAero = aeroTypesID[indexAero];

                int indexDest = Array.IndexOf(destTypes, DestinationCB.SelectedItem);
                int idDest = destTypesID[indexDest];


                int idCurrentFlight = int.Parse(NumberFlightTB.Text);


                SqlConnection connection = new SqlConnection(connectionPath);

                SqlCommand flightUpdate = new SqlCommand("UPDATE Flights SET [ID Aerotechnic] = @IDAerotechnic, [ID Destination] = @IDDestination, [Departure time] = @Departuretime, [Time flight] = @Timeflight, [Date flight] = @Dateflight, [Arrivial time] = @Arrivialtime, [ID Manager] = @IDManager WHERE Number = @Number", connection);



                connection.Open();
                try
                {
                    flightUpdate.Parameters.AddWithValue("Number", idCurrentFlight);
                    flightUpdate.Parameters.AddWithValue("IDAerotechnic", idAero);
                    flightUpdate.Parameters.AddWithValue("IDDestination", idDest);
                    flightUpdate.Parameters.AddWithValue("Departuretime", dateTimePicker1.Value);
                    flightUpdate.Parameters.AddWithValue("Timeflight", RoundUp(dateTimePicker3.Value, TimeSpan.FromSeconds(1)));
                    flightUpdate.Parameters.AddWithValue("Dateflight", FlightDateTimePicker.Value);
                    flightUpdate.Parameters.AddWithValue("Arrivialtime", dateTimePicker2.Value);
                    flightUpdate.Parameters.AddWithValue("IDManager", idCurrentUser);


                    flightUpdate.ExecuteNonQuery();

                    MessageBox.Show("Данные успешно обновлены!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.flightsTableAdapter.Fill(this.airlineDBDataSet2.Flights);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                connection.Close();

                DisplayReadOnlyManagerFlight();
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            saveFlight();
        }

        public void editFlight ()
        {
            dateTimePicker1.DataBindings.Clear();
            dateTimePicker2.DataBindings.Clear();
            dateTimePicker3.DataBindings.Clear();

            AerotechnicCB.DataBindings.Clear();
            DestinationCB.DataBindings.Clear();
            FlightDateTimePicker.DataBindings.Clear();

            isBinding = false;

            DisplayEditManagerFlight();
        }

        private void editToolStripButton_Click(object sender, EventArgs e)
        {
            editFlight();
        }

        private void editFlightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editFlight();
        }

        private void UnDoToolStripButton_Click(object sender, EventArgs e)
        {
            DisplayReadOnlyManagerFlight();
        }

        private void culcTimeFlight ()
        {

            System.TimeSpan limitTime = DateTime.Now - DateTime.Now;

            if (dateTimePicker2.Value >= dateTimePicker1.Value)
            {
                System.TimeSpan diffTime = dateTimePicker2.Value - dateTimePicker1.Value;

                if (diffTime >= limitTime)
                {
                    dateTimePicker3.Value = DateTime.Parse((dateTimePicker2.Value - dateTimePicker1.Value).ToString());
                }
            } else
            {
                dateTimePicker3.Value = DateTime.Parse((limitTime).ToString());
            }
        }

        bool isError = false;

        private void AddFlightBtn_Click(object sender, EventArgs e)
        {

            int indexAero = Array.IndexOf(aeroTypes, AerotechnicCB.SelectedItem);
            int idAero = aeroTypesID[indexAero];

            int indexDest = Array.IndexOf(destTypes, DestinationCB.SelectedItem);
            int idDest = destTypesID[indexDest];

            isError = false;


            if (checkFlightCorrectData() == true)
            {
                string connectionPath = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\79266\source\repos\Airline14\Airline14\AirlineDB.mdf;Integrated Security=True;Connect Timeout=30";

                SqlConnection connection = new SqlConnection(connectionPath);
                SqlCommand newFlightInsert = new SqlCommand("INSERT INTO[dbo].[Flights] ([ID Aerotechnic], [ID Destination], [Departure time], [Time flight], [Date flight], [Sold Count], [Arrivial time], [ID Manager])" +
                    "VALUES(@IDAerotechnic, @IDDestination, @Departuretime, @Timeflight, @Dateflight, @Soldcount, @Arrivialtime, @IDManager);", connection);

                connection.Open();

                newFlightInsert.Parameters.AddWithValue("IDAerotechnic", idAero);
                newFlightInsert.Parameters.AddWithValue("IDDestination", idDest);
                newFlightInsert.Parameters.AddWithValue("Departuretime", dateTimePicker1.Value);
                newFlightInsert.Parameters.AddWithValue("Timeflight", RoundUp(dateTimePicker3.Value, TimeSpan.FromSeconds(1)));
                newFlightInsert.Parameters.AddWithValue("Dateflight", FlightDateTimePicker.Value);
                newFlightInsert.Parameters.AddWithValue("Soldcount", 0);
                newFlightInsert.Parameters.AddWithValue("Arrivialtime", dateTimePicker2.Value);
                newFlightInsert.Parameters.AddWithValue("IDManager", idCurrentUser);


                try
                {
                    newFlightInsert.ExecuteNonQuery();
                    isError = true;
                    MessageBox.Show("Авиарейс добавлен успешно!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                catch (Exception ex)
                {
                    isError = true;
                    MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                connection.Close();

                this.flightsTableAdapter.Fill(this.airlineDBDataSet2.Flights);


                AddFlightBtn.Visible = false;

                DisplayReadOnlyManagerFlight();
            } else
            {
                if (isError == false)
                {
                    ErrorMessageBox();
                }
            }
        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            culcTimeFlight();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            culcTimeFlight();
        }

        private bool checkFlightCorrectData()
        {
            if (AerotechnicCB.SelectedIndex != -1 && DestinationCB.SelectedIndex != -1)
            {
                System.TimeSpan diffTime = dateTimePicker2.Value - dateTimePicker1.Value;
                System.TimeSpan limitTime = DateTime.Now - DateTime.Now;

                if (diffTime > limitTime)
                {
                    if (FlightDateTimePicker.Value >= DateTime.Today)
                    {
                        return true;
                    } else
                    {
                        isError = true;
                        MessageBox.Show("Дата авиарейса не может быть позже сегодня", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } else
                {
                    isError = true;

                    MessageBox.Show("Время полета не может быть отрицательным", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            return false;
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {


            if (dataGridView1.SelectedRows.Count >= 1)
            {
                int indexCurrenRow = dataGridView1.SelectedCells[0].RowIndex;

                if (isBinding == false)
                {
                    AerotechnicCB.SelectedItem = dataGridView1.Rows[indexCurrenRow].Cells[1].Value.ToString();
                    DestinationCB.SelectedItem = dataGridView1.Rows[indexCurrenRow].Cells[2].Value.ToString();
                    FlightDateTimePicker.Value = DateTime.Parse(dataGridView1.Rows[indexCurrenRow].Cells[3].Value.ToString());
                    dateTimePicker1.Value = DateTime.Parse(dataGridView1.Rows[indexCurrenRow].Cells[4].Value.ToString());
                    dateTimePicker3.Value = DateTime.Parse(dataGridView1.Rows[indexCurrenRow].Cells[5].Value.ToString());
                    dateTimePicker2.Value = DateTime.Parse(dataGridView1.Rows[indexCurrenRow].Cells[7].Value.ToString());
                }
            }

        }

        private void removeToolStripButton_Click(object sender, EventArgs e)
        {
            if (appEditMode == true)
            {

                int idCurrentFlight = int.Parse(NumberFlightTB.Text);


                SqlConnection connection = new SqlConnection(connectionPath);

                SqlCommand flightDelete = new SqlCommand("DELETE FROM [Flights] WHERE [Number] =@Number", connection);

                connection.Open();

                DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить запись?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        flightDelete.Parameters.AddWithValue("Number", idCurrentFlight);


                        flightDelete.ExecuteNonQuery();

                        MessageBox.Show("Запись удалена успешно!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        DisplayReadOnlyManagerFlight();

                        this.flightsTableAdapter.Fill(this.airlineDBDataSet2.Flights);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Необходимо подтвердить удаление!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
