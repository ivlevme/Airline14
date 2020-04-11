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
    public partial class ManagerAllDestionationForm : BaseForm
    {
        public ManagerAllDestionationForm()
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

        private void просмотрВсехАвиарейсовToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void сформироватьОтчетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagerCreateReportForm managerCreateReport = new ManagerCreateReportForm();
            managerCreateReport.Show();
            this.Hide();
        }

        private void просмотрВсехПунктовНазначенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createButton();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            removeCurrentDestination();
        }

        private void toolStripButtonRemove_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int indexCurrentRow = dataGridView1.SelectedCells[0].RowIndex;

                DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить запись?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes) {
                    dataGridView1.Rows.Remove(dataGridView1.Rows[indexCurrentRow]);
                    MessageBox.Show("Пользовать удалён успешно!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else { MessageBox.Show("Необходимо подтвердить удаление!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else
            {
                MessageBox.Show("Ничего не выбранно!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            saveRecord();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveRecord();
        }

        private void ManagerAllDestionationForm_Load(object sender, EventArgs e)
        {

            this.destinationTableAdapter.Fill(this.airlineDBDataSet2.Destination);

            DisplayReadOnlyManagerDestination();

            AddDestinationBtn.Visible = false;
        }

        private bool appModeEdit = false;

        private void DisplayReadOnlyManagerDestination()
        {
            nameDestinationTB.Enabled = false;

            createToolStripButton.Enabled = true;
            addToolStripMenuItem.Enabled = true;
            createDestToolStripMenuItem.Enabled = true;

            editDestToolStripMenuItem.Enabled = true;
            editToolStripButton.Enabled = true;
            editToolStripMenuItem.Enabled = true;

            saveToolStripButton.Enabled = false;

            UnDoToolStripButton.Enabled = false;

            appModeEdit = false;

            AddDestinationBtn.Visible = false;

            enableChangeSortMode(false);

            addBingings();
        }

        private void DisplayEditManagerDestination()
        {
            nameDestinationTB.Enabled = true;

            createToolStripButton.Enabled = false;
            addToolStripMenuItem.Enabled = false;
            createDestToolStripMenuItem.Enabled = false;

            editDestToolStripMenuItem.Enabled = false;
            editToolStripButton.Enabled = false;
            editToolStripMenuItem.Enabled = false;

            saveToolStripButton.Enabled = true;

            UnDoToolStripButton.Enabled = true;

            appModeEdit = true;

            idCurrentDestinationTB.DataBindings.Clear();
            nameDestinationTB.DataBindings.Clear();
            isBinding = false;

        }

        private void списокВсехАвиарейсовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagerAllFlightForm managerAllFlight = new ManagerAllFlightForm();
            managerAllFlight.Show();
            this.Hide();
        }


        private void createButton ()
        {
            DisplayEditManagerDestination();

            AddDestinationBtn.Visible = true;

            nameDestinationTB.Text = "";
        }

        bool isBinding = false;

        private void addBingings()
        {
            if (isBinding == false)
            {
                idCurrentDestinationTB.DataBindings.Add(new Binding("Text", dataSource: destinationBindingSource, dataMember: "ID"));
                nameDestinationTB.DataBindings.Add(new Binding("Text", dataSource: destinationBindingSource, dataMember: "Name"));

                isBinding = true;
            }
        }

        private void createToolStripButton_Click(object sender, EventArgs e)
        {
            createButton();
        }

        int indexCurrentRow;

        private void editToolStripButton_Click(object sender, EventArgs e)
        {
            DisplayEditManagerDestination();

            indexCurrentRow = dataGridView1.SelectedCells[0].RowIndex;

            enableChangeSortMode(false);
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
            DisplayReadOnlyManagerDestination();
        }

        private void removeCurrentDestination () {
            if (appModeEdit == true)
            {

                addBingings();

                idCurrentDestinationTB.Visible = true;
                int idCurrentDestination = int.Parse(idCurrentDestinationTB.Text);
                idCurrentDestinationTB.Visible = false;


                SqlConnection connection = new SqlConnection(connectionPath);

                SqlCommand destDelete = new SqlCommand("DELETE FROM [Destination] WHERE [ID] =@ID", connection);

                connection.Open();

                DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить запись?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        destDelete.Parameters.AddWithValue("ID", idCurrentDestination);


                        destDelete.ExecuteNonQuery();

                        MessageBox.Show("Запись удалена успешно!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        DisplayReadOnlyManagerDestination();

                        this.destinationTableAdapter.Fill(this.airlineDBDataSet2.Destination);
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


        private void removeToolStripButton_Click(object sender, EventArgs e)
        {
            removeCurrentDestination();
        }

            private void saveToolStripButton_Click(object sender, EventArgs e)
            {
            idCurrentDestinationTB.Visible = true;
            int idCurrentDestination = int.Parse(idCurrentDestinationTB.Text);
            idCurrentDestinationTB.Visible = false;


            SqlConnection connection = new SqlConnection(connectionPath);

            SqlCommand destUpdate = new SqlCommand("UPDATE [Destination] SET [Name] = @Name WHERE [ID] =@ID", connection);



            connection.Open();
            try
            {
                destUpdate.Parameters.AddWithValue("ID", idCurrentDestination);
                destUpdate.Parameters.AddWithValue("Name", nameDestinationTB.Text);

                destUpdate.ExecuteNonQuery();

                MessageBox.Show("Данные успешно обновлены!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.destinationTableAdapter.Fill(this.airlineDBDataSet2.Destination);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            connection.Close();

            DisplayReadOnlyManagerDestination();
        }

        private void AddDestinationBtn_Click(object sender, EventArgs e)
        {
            if (nameDestinationTB.Text != "")
            {
                string connectionPath = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\79266\source\repos\Airline14\Airline14\AirlineDB.mdf;Integrated Security=True;Connect Timeout=30";

                SqlConnection connection = new SqlConnection(connectionPath);
                SqlCommand newDestInsert = new SqlCommand("INSERT INTO[dbo].[Destination] ([Name]) VALUES(@Name);", connection);

                connection.Open();

                newDestInsert.Parameters.AddWithValue("Name", nameDestinationTB.Text);

                try
                {
                    newDestInsert.ExecuteNonQuery();

                    MessageBox.Show("Пункт назначения добавлен успешно!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                connection.Close();

                this.destinationTableAdapter.Fill(this.airlineDBDataSet2.Destination);

                AddDestinationBtn.Visible = false;

                DisplayReadOnlyManagerDestination();
            }
            else
            {
                ErrorMessageBox();
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayEditManagerDestination();
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            removeCurrentDestination();
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
