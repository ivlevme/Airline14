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
    public partial class SalesmanAllUsersForm : BaseForm
    {
        public SalesmanAllUsersForm()
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

        private void создатьАвирейсToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesmanAddTicketForm salesmanAddTicket = new SalesmanAddTicketForm();
            salesmanAddTicket.Show();
            this.Hide();
        }

        private void просмотрВсехАвиарейсовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesmanAllTicketsForm salesmanAllTicketsForm = new SalesmanAllTicketsForm();
            salesmanAllTicketsForm.Show();
            this.Hide();
        }

        private void сформироватьОтчетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesmanAddUserForm salesmanAddUser = new SalesmanAddUserForm();
            salesmanAddUser.Show();
            this.Hide();
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            saveRecord();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
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
        bool appModeEdit = false;
        public void DisplayReadOnlySalesmanUsers()
        {
            createToolStripButton.Enabled = true;
            createUserMenuToolStripMenuItem.Enabled = true;
            createToolStripMenuItem.Enabled = true;

            editToolStripButton.Enabled = true;
            editUserMenuToolStripMenuItem.Enabled = true;
            editUserToolStripMenuItem.Enabled = true;

            saveToolStripButton.Enabled = false;
            UnDoToolStripButton.Enabled = false;

            FioTB.Enabled = false;
            PassportTB.Enabled = false;

            AddClientBtn.Visible = false;

            appModeEdit = false;

            enableChangeSortMode(true);

            this.passengersTableAdapter.Fill(this.airlineDBDataSet2.Passengers);
        }

        public void DisplayEditSalesmanUsers()
        {
            createToolStripButton.Enabled = false;
            createUserMenuToolStripMenuItem.Enabled = false;
            createToolStripMenuItem.Enabled = false;

            editToolStripButton.Enabled = false;
            editUserMenuToolStripMenuItem.Enabled = false;
            editUserToolStripMenuItem.Enabled = false;

            saveToolStripButton.Enabled = true;
            UnDoToolStripButton.Enabled = true;

            FioTB.Enabled = true;
            PassportTB.Enabled = true;

            appModeEdit = true;
        }

        private void SalesmanAllUsersForm_Load(object sender, EventArgs e)
        {
            this.passengersTableAdapter.Fill(this.airlineDBDataSet2.Passengers);

            dataGridView1.CurrentRow.Selected = false;

            DisplayReadOnlySalesmanUsers();

            AddClientBtn.Visible = false;

            currentIDReport.DataBindings.Add(new Binding("Text", dataSource: passengersBindingSource, dataMember: "ID"));
            FioTB.DataBindings.Add(new Binding("Text", dataSource: passengersBindingSource, dataMember: "Personal Information"));
            PassportTB.DataBindings.Add(new Binding("Text", dataSource: passengersBindingSource, dataMember: "Passport Information"));
        }

        private void просмотретьВсеАвиарейсыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesmanAllFlight salesmanAllFlight = new SalesmanAllFlight();
            salesmanAllFlight.Show();
            this.Hide();
        }

        private void UnDoToolStripButton_Click(object sender, EventArgs e)
        {
            DisplayReadOnlySalesmanUsers();
            addBind();
        }

        bool dataBind = true;

        private void createToolStripButton_Click(object sender, EventArgs e)
        {
            DisplayEditSalesmanUsers();

            dataGridView1.CurrentRow.Selected = false;

            FioTB.DataBindings.Clear();
            PassportTB.DataBindings.Clear();
            dataBind = false;



            saveToolStripButton.Enabled = false;

            FioTB.Text = "";
            PassportTB.Text = "";

            AddClientBtn.Visible = true;
        }

        private void AddClientBtn_Click(object sender, EventArgs e)
        {
            if (FioTB.Text != "" && PassportTB.Text != "")
            {
                string connectionPath = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\79266\source\repos\Airline14\Airline14\AirlineDB.mdf;Integrated Security=True;Connect Timeout=30";

                SqlConnection connection = new SqlConnection(connectionPath);
                SqlCommand addPassengerInsert = new SqlCommand("INSERT INTO [dbo].[Passengers] ([Personal information], [Passport information]) VALUES(@PersInf, @PassInf);", connection);



                connection.Open();

                addPassengerInsert.Parameters.AddWithValue("PersInf", FioTB.Text);
                addPassengerInsert.Parameters.AddWithValue("PassInf", PassportTB.Text);



                try
                {
                    addPassengerInsert.ExecuteNonQuery();

                    MessageBox.Show("Клиент добавлен успешно!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                DisplayReadOnlySalesmanUsers();

                addBind();
            }
        }

        private void addBind ()
        {
            if (dataBind == false)
            {
                FioTB.DataBindings.Add(new Binding("Text", dataSource: passengersBindingSource, dataMember: "Personal Information"));
                PassportTB.DataBindings.Add(new Binding("Text", dataSource: passengersBindingSource, dataMember: "Passport Information"));
            }
        }
        int indexCurrentRow;
        private void editToolStripButton_Click(object sender, EventArgs e)
        {
            DisplayEditSalesmanUsers();
            indexCurrentRow = dataGridView1.SelectedCells[0].RowIndex;

            enableChangeSortMode(false);
        }

        private void enableChangeSortMode (bool mode)
        {
            if (mode == true)
            {
                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.Automatic;
                }
            } else
            {
                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {

            currentIDReport.Visible = true;
            int currentReportID = int.Parse(currentIDReport.Text);
            currentIDReport.Visible = false;

            SqlConnection connection = new SqlConnection(connectionPath);

            SqlCommand ticketUpdate = new SqlCommand("UPDATE [Passengers] SET [Personal information] = @PersInf, [Passport information] = @PassInf WHERE [ID] =@ID", connection);


            connection.Open();
            try
            {
                ticketUpdate.Parameters.AddWithValue("PersInf", FioTB.Text);
                ticketUpdate.Parameters.AddWithValue("PassInf", PassportTB.Text);
                ticketUpdate.Parameters.AddWithValue("ID", currentReportID);


                ticketUpdate.ExecuteNonQuery();

                MessageBox.Show("Данные успешно обновлены!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            connection.Close();

            DisplayReadOnlySalesmanUsers();
        }

        private void removeToolStripButton_Click(object sender, EventArgs e)
        {
            if (appModeEdit == true)
            {

                currentIDReport.Visible = true;
                int currentReportID = int.Parse(currentIDReport.Text);
                currentIDReport.Visible = false;

                SqlConnection connection = new SqlConnection(connectionPath);

                SqlCommand passDelete = new SqlCommand("DELETE FROM [Passengers] WHERE [ID] =@ID", connection);

                connection.Open();

                DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить запись?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        passDelete.Parameters.AddWithValue("ID", currentReportID);


                        passDelete.ExecuteNonQuery();

                        MessageBox.Show("Запись удалена успешно!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        DisplayReadOnlySalesmanUsers();
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
    }
}
