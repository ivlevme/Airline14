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
    public partial class SalesmanAllTicketsForm : BaseForm
    {
        public SalesmanAllTicketsForm()
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
            SalesmanMainForm salesmanMain = new SalesmanMainForm();
            salesmanMain.Show();
            this.Hide();
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exitMenuStrip();
        }


        private void списрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesmanAllUsersForm salesmanAllUsers = new SalesmanAllUsersForm();
            salesmanAllUsers.Show();
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

        private void SalesmanAllTicketsForm_Load(object sender, EventArgs e)
        {
            this.ticketsTableAdapter.Fill(this.airlineDBDataSet2.Tickets);

            dataGridView1.CurrentRow.Selected = false;

            DisplayReadOnlySalesmanTickets();

            AddTicketBtn.Visible = false;

            fillComboBoxs();



            ClientCB.DataBindings.Add(new Binding("Text", dataSource: ticketsBindingSource, dataMember: "Personal Information"));
            FlightCB.DataBindings.Add(new Binding("Text", dataSource: ticketsBindingSource, dataMember: "Number"));

            currentIDrecord.DataBindings.Add(new Binding("Text", dataSource: ticketsBindingSource, dataMember: "ID"));

        }

        string[] Pass = new string[100];
        int[] PassID = new int[100];

        private void fillComboBoxs ()
        {
            SqlConnection connection = new SqlConnection(connectionPath);

            SqlCommand passSelect = new SqlCommand("SELECT ID, [Personal information] FROM Passengers", connection);
            SqlCommand flightsSelect = new SqlCommand("SELECT Number FROM Flights", connection);

            connection.Open();

            sdr = passSelect.ExecuteReader();

            int indexPass = 0;


            while (sdr.Read())
            {
                ClientCB.Items.Add(sdr["Personal information"].ToString());
                Pass[indexPass] = sdr["Personal information"].ToString();
                PassID[indexPass] = int.Parse(sdr["ID"].ToString());
                indexPass++;
            }

            connection.Close();

            connection.Open();

            sdr = flightsSelect.ExecuteReader();

            while (sdr.Read())
            {
                FlightCB.Items.Add(sdr["Number"].ToString());
            }

            connection.Close();
        }

        bool appModeEdit = false;

        private void addBind()
        {
            if (dataBind == false)
            {
                ClientCB.DataBindings.Add(new Binding("Text", dataSource: ticketsBindingSource, dataMember: "Personal Information"));
                FlightCB.DataBindings.Add(new Binding("Text", dataSource: ticketsBindingSource, dataMember: "Number"));
            }
        }

        private void DisplayReadOnlySalesmanTickets ()
        {
            ClientCB.Enabled = false;
            AddNewClient.Enabled = false;
            FlightCB.Enabled = false;

            createToolStripButton.Enabled = true;
            createToolStripMenuItem.Enabled = true;
            createMenuToolStripMenuItem.Enabled = true;

            saveToolStripButton.Enabled = false;

            editToolStripButton.Enabled = true;
            editMenuToolStripMenuItem.Enabled = true;
            editToolStripMenuItem.Enabled = true;

            UnDoToolStripButton.Enabled = false;

            AddTicketBtn.Visible = false;

            appModeEdit = false;

            enableChangeSortMode(true);

            this.ticketsTableAdapter.Fill(this.airlineDBDataSet2.Tickets);
        }

        private void DisplayEditSalesmanTickets()
        {
            ClientCB.Enabled = true;
            AddNewClient.Enabled = true;
            FlightCB.Enabled = true;

            createToolStripButton.Enabled = false;
            createToolStripMenuItem.Enabled = false;
            createMenuToolStripMenuItem.Enabled = false;

            saveToolStripButton.Enabled = true;

            editToolStripButton.Enabled = false;
            editMenuToolStripMenuItem.Enabled = false;
            editToolStripMenuItem.Enabled = false;

            UnDoToolStripButton.Enabled = true;

            appModeEdit = true;
        }

        private void просмотретьВсеАвиарейсыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesmanAllFlight salesmanAllFlight = new SalesmanAllFlight();
            salesmanAllFlight.Show();
            this.Hide();
        }

        private void AddNewClient_Click(object sender, EventArgs e)
        {
            SalesmanAllUsersForm salesmanAllUsers = new SalesmanAllUsersForm();
            salesmanAllUsers.Show();
            this.Hide();
        }

        int indexCurrentRow;

        private void editButton ()
        {
            DisplayEditSalesmanTickets();

            indexCurrentRow = dataGridView1.SelectedCells[0].RowIndex;

            enableChangeSortMode(false);
        }

        private void editToolStripButton_Click(object sender, EventArgs e)
        {
            editButton();
        }

        private void enableChangeSortMode(bool mode)
        {
            if (mode == true)
            {
                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.Automatic;
                }
            }
            else
            {
                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
            }
        }

        private void UnDoToolStripButton_Click(object sender, EventArgs e)
        {
            DisplayReadOnlySalesmanTickets();

            addBind();
        }

        private void removeCurrentTicket ()
        {
            if (appModeEdit == true)
            {
                bool isDelSuccess = false;

                currentIDrecord.Visible = true;
                int currentRecordID = int.Parse(currentIDrecord.Text);
                currentIDrecord.Visible = false;

                int currentNumberFlight = int.Parse(FlightCB.SelectedItem.ToString());


                SqlConnection connection = new SqlConnection(connectionPath);

                SqlCommand ticketDelete = new SqlCommand("DELETE FROM [Tickets] WHERE [ID] =@ID", connection);

                connection.Open();

                DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить запись?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        ticketDelete.Parameters.AddWithValue("ID", currentRecordID);

                        currentNumberFlight = int.Parse(FlightCB.SelectedItem.ToString());

                        ticketDelete.ExecuteNonQuery();

                        MessageBox.Show("Запись удалена успешно!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        isDelSuccess = true;

                        DisplayReadOnlySalesmanTickets();

                        this.ticketsTableAdapter.Fill(this.airlineDBDataSet2.Tickets);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    connection.Close();
                    
                    if (isDelSuccess == true)
                    {

                        SqlCommand updateCountSoldTicket = new SqlCommand("UPDATE [dbo].[Flights] SET [Sold count] = [Sold count] - 1 WHERE Number = @Number;", connection);
                        connection.Open();

                        updateCountSoldTicket.Parameters.AddWithValue("Number", currentNumberFlight);

                        try
                        {
                            updateCountSoldTicket.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        connection.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Необходимо подтвердить удаление!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void removeToolStripButton_Click(object sender, EventArgs e)
        {
            removeCurrentTicket();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionPath);

            SqlCommand ticketUpdate = new SqlCommand("UPDATE [Tickets] SET [ID Passenger] = @IDPass, [Number Flight] = @NumberFlight, [Date] = @Date WHERE [ID] =@ID", connection);


            connection.Open();
            try
            {
                currentIDrecord.Visible = true;
                int currentRecordID = int.Parse(currentIDrecord.Text);
                currentIDrecord.Visible = false;


                int indexPass = Array.IndexOf(Pass, ClientCB.SelectedItem);
                int idPass = PassID[indexPass];

                int currentNumberFlight = int.Parse(FlightCB.SelectedItem.ToString());

                ticketUpdate.Parameters.AddWithValue("IDPass", idPass);
                ticketUpdate.Parameters.AddWithValue("NumberFlight", currentNumberFlight);
                ticketUpdate.Parameters.AddWithValue("Date", DateTime.Now);

                ticketUpdate.Parameters.AddWithValue("ID", currentRecordID);


                ticketUpdate.ExecuteNonQuery();

                MessageBox.Show("Данные успешно обновлены!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.ticketsTableAdapter.Fill(this.airlineDBDataSet2.Tickets);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            connection.Close();

            DisplayReadOnlySalesmanTickets();
        }

        bool dataBind = true;

        private void createButton ()
        {
            DisplayEditSalesmanTickets();

            ClientCB.DataBindings.Clear();
            FlightCB.DataBindings.Clear();
            dataBind = false;

            dataGridView1.CurrentRow.Selected = false;

            ClientCB.Text = "";
            FlightCB.Text = "";

            AddTicketBtn.Visible = true;
        }

        private void createToolStripButton_Click(object sender, EventArgs e)
        {
            createButton();
        }

        private void AddTicketBtn_Click(object sender, EventArgs e)
        {

            int indexPass = Array.IndexOf(Pass, ClientCB.SelectedItem);
            int idPass = PassID[indexPass];

            bool isAddSuccess = false;


            if (ClientCB.Text != "" && FlightCB.Text != "")
            {
                int currentNumberFlight = int.Parse(FlightCB.SelectedItem.ToString());

                string connectionPath = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\79266\source\repos\Airline14\Airline14\AirlineDB.mdf;Integrated Security=True;Connect Timeout=30";

                SqlConnection connection = new SqlConnection(connectionPath);
                SqlCommand newTicketInsert = new SqlCommand("INSERT INTO [dbo].[Tickets] ([ID Passenger], [Number Flight], [Date]) VALUES(@IDPass, @NumberFlight, @Date);", connection);
                


                connection.Open();

                newTicketInsert.Parameters.AddWithValue("IDPass", idPass);
                newTicketInsert.Parameters.AddWithValue("NumberFlight", currentNumberFlight);
                newTicketInsert.Parameters.AddWithValue("Date", DateTime.Now);



                try
                {
                    newTicketInsert.ExecuteNonQuery();
                    isAddSuccess = true;

                    MessageBox.Show("Билет добавлен успешно!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                connection.Close();

                if (isAddSuccess == true)
                {
                    SqlCommand updateCountSoldTicket = new SqlCommand("UPDATE [dbo].[Flights] SET [Sold count] = [Sold count] + 1 WHERE Number = @Number;", connection);
                    connection.Open();

                    updateCountSoldTicket.Parameters.AddWithValue("Number", currentNumberFlight);

                    try
                    {
                        updateCountSoldTicket.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                connection.Close();

                this.ticketsTableAdapter.Fill(this.airlineDBDataSet2.Tickets);

                AddNewClient.Visible = false;

                DisplayReadOnlySalesmanTickets();

                addBind();
            }
            else
            {
                ErrorMessageBox();
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (appModeEdit == true)
                {
                    if (MouseButtons != System.Windows.Forms.MouseButtons.None)
                        ((DataGridView)sender).CurrentCell = dataGridView1.Rows[indexCurrentRow].Cells[0];
                }
            }
        }

        private void createMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createButton();
        }

        private void editMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editButton();
        }

        private void удалитьВыбранныйБилетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            removeCurrentTicket();
        }
    }
}
