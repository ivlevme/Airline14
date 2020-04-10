﻿using System;
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
    public partial class EngineerAllAerotechnicsForm : BaseForm
    {
        public EngineerAllAerotechnicsForm()
        {
            InitializeComponent();
        }

        private void оПрограммеToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AboutProgramForm aboutProgram = new AboutProgramForm();
            aboutProgram.Show();
        }

        private void просмотрВсехПользователейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EngineerAllReportsForm engAllReports = new EngineerAllReportsForm();
            engAllReports.Show();
            this.Hide();
        }

        private void добавитьНовогоПользователяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EngineerAddReportsForm engAddReports = new EngineerAddReportsForm();
            engAddReports.Show();
            this.Hide();
        }

        private void добавитьАэротехнкикуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EngineerAddAerotechnicsForm engineerAddAerotechnics = new EngineerAddAerotechnicsForm();
            engineerAddAerotechnics.Show();
            this.Hide();
        }

        private void вернутьсяНаГлавнуюСтраницуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EngineerMainForm engMain = new EngineerMainForm();
            engMain.Show();
            this.Hide();
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exitMenuStrip();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveRecord();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            delRecord();
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            saveRecord();
        }

        private void toolStripButtonRemove_Click(object sender, EventArgs e)
        {
            delRecord();
        }


        private void EngineerAllAerotechnicsForm_Load(object sender, EventArgs e)
        {
            this.aerotechnicsTableAdapter.Fill(this.airlineDBDataSet2.Aerotechnics);
            dataGridView1.CurrentRow.Selected = false;

            DisplayReadOnlyEngineer();

            AddAeroBtn.Visible = false;



            NameAerotechnicTB.DataBindings.Add(new Binding("Text", dataSource: aerotechnicsBindingSource, dataMember: "Name"));
            CapacityTB.DataBindings.Add(new Binding("Text", dataSource: aerotechnicsBindingSource, dataMember: "Capacity"));
            CrewTB.DataBindings.Add(new Binding("Text", dataSource: aerotechnicsBindingSource, dataMember: "Crew Count"));
            ReportTB.DataBindings.Add(new Binding("Text", dataSource: aerotechnicsBindingSource, dataMember: "Content"));
            idCurrentAeroTB.DataBindings.Add(new Binding("Text", dataSource: aerotechnicsBindingSource, dataMember: "ID"));
            idCurrentReportTB.DataBindings.Add(new Binding("Text", dataSource: aerotechnicsBindingSource, dataMember: "ID Report"));

        }

        private bool appModeEdit = false;
        private void DisplayReadOnlyEngineer()
        {
            NameAerotechnicTB.Enabled = false;
            CapacityTB.Enabled = false;
            CrewTB.Enabled = false;
            ReportTB.Enabled = false;

            createToolStripButton.Enabled = true;
            addAeroToolStripMenuItem.Enabled = true;
            createToolStripMenuItem.Enabled = true;


            editAeroToolStripMenuItem.Enabled = true;
            editToolStripMenuItem.Enabled = true;
            editToolStripButton.Enabled = true;



            removeAeroToolStripMenuItem.Enabled = true;
            removeToolStripButton.Enabled = true;
            removeToolStripMenuItem.Enabled = true;



            saveToolStripButton.Enabled = false;
            UnDoToolStripButton.Enabled = false;

            appModeEdit = false;
        }

        private void DisplayEditEngineer()
        {
            NameAerotechnicTB.Enabled = true;
            CapacityTB.Enabled = true;
            CrewTB.Enabled = true;
            ReportTB.Enabled = true;


            createToolStripButton.Enabled = false;
            addAeroToolStripMenuItem.Enabled = false;
            createToolStripMenuItem.Enabled = false;


            editAeroToolStripMenuItem.Enabled = true;
            editToolStripMenuItem.Enabled = true;
            editToolStripButton.Enabled = true;



            removeAeroToolStripMenuItem.Enabled = true;
            removeToolStripButton.Enabled = true;
            removeToolStripMenuItem.Enabled = true;



            saveToolStripButton.Enabled = true;
            UnDoToolStripButton.Enabled = true;

            appModeEdit = true;
        }

        private void editToolStripButton_Click(object sender, EventArgs e)
        {
            DisplayEditEngineer();
        }

        private void UnDoToolStripButton_Click(object sender, EventArgs e)
        {
            DisplayReadOnlyEngineer();
        }

        private void AddReportBtn_Click(object sender, EventArgs e)
        {
            if (NameAerotechnicTB.Text != "" && CrewTB.Text != "" && CapacityTB.Text != "" && ReportTB.Text != "")
            {
                string connectionPath = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\79266\source\repos\Airline14\Airline14\AirlineDB.mdf;Integrated Security=True;Connect Timeout=30";

                SqlConnection connection = new SqlConnection(connectionPath);
                SqlCommand newUserInsert = new SqlCommand("INSERT INTO[dbo].[Aerotechnics] ([Name], [Capacity], [Crew Count], [ID Report]) VALUES(@Name, @Capacity, @Crew, @IDReport);", connection);

                SqlCommand newReportInsert = new SqlCommand("INSERT INTO[dbo].[Reports] ([Date], [Content], [ID engineer]) VALUES(@Date, @Content, @IDengineer);", connection);

                SqlCommand selectLastIdReport = new SqlCommand("select max(id) from Reports", connection);

                connection.Open();

                newReportInsert.Parameters.AddWithValue("Date", DateTime.Now);
                newReportInsert.Parameters.AddWithValue("Content", ReportTB.Text);
                newReportInsert.Parameters.AddWithValue("IDengineer", idCurrentUser);


                try
                {
                    newReportInsert.ExecuteNonQuery();
                    var lastId = Convert.ToInt32(selectLastIdReport.ExecuteScalar());
                    

                    newUserInsert.Parameters.AddWithValue("Name", NameAerotechnicTB.Text);
                    newUserInsert.Parameters.AddWithValue("Capacity", int.Parse(CapacityTB.Text));
                    newUserInsert.Parameters.AddWithValue("Crew", int.Parse(CrewTB.Text));
                    newUserInsert.Parameters.AddWithValue("IDReport", int.Parse(lastId.ToString()));

                    newUserInsert.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                connection.Close();

                this.aerotechnicsTableAdapter.Fill(this.airlineDBDataSet2.Aerotechnics);

                MessageBox.Show("Аэротехника добавлена успешно!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                AddAeroBtn.Visible = false;

                DisplayReadOnlyEngineer();
            }
            else
            {
                ErrorMessageBox();
            }
        }

        private void createToolStripButton_Click(object sender, EventArgs e)
        {
            DisplayEditEngineer();
            AddAeroBtn.Visible = true;

            NameAerotechnicTB.Text = "";
            CapacityTB.Text = "";
            CrewTB.Text = "";
            ReportTB.Text = "";
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            idCurrentAeroTB.Visible = true;
            int idCurrentAero = int.Parse(idCurrentAeroTB.Text);
            idCurrentAeroTB.Visible = false;

            idCurrentReportTB.Visible = true;
            int idCurrentReport = int.Parse(idCurrentReportTB.Text);
            idCurrentReportTB.Visible = false;


            SqlConnection connection = new SqlConnection(connectionPath);

            SqlCommand aeroUpdate = new SqlCommand("UPDATE [Aerotechnics] SET [Name] = @Name, [Capacity] = @Capacity, [Crew Count] = @Crew WHERE [ID] =@ID", connection);

            SqlCommand reportUpdate = new SqlCommand("UPDATE [Reports] SET [Content] = @Content WHERE [ID] =@ID", connection);



            connection.Open();
            try
            {
                aeroUpdate.Parameters.AddWithValue("ID", idCurrentAero);
                aeroUpdate.Parameters.AddWithValue("Name", NameAerotechnicTB.Text);
                aeroUpdate.Parameters.AddWithValue("Capacity", int.Parse(CapacityTB.Text));
                aeroUpdate.Parameters.AddWithValue("Crew", int.Parse(CrewTB.Text));

                reportUpdate.Parameters.AddWithValue("ID", idCurrentReport);
                reportUpdate.Parameters.AddWithValue("Content", ReportTB.Text);

                aeroUpdate.ExecuteNonQuery();
                reportUpdate.ExecuteNonQuery();

                MessageBox.Show("Данные успешно обновлены!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.aerotechnicsTableAdapter.Fill(this.airlineDBDataSet2.Aerotechnics);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            connection.Close();

            DisplayReadOnlyEngineer();
        }

        private void removeToolStripButton_Click(object sender, EventArgs e)
        {
            if (appModeEdit == true)
            {

                idCurrentAeroTB.Visible = true;
                int idCurrentAero = int.Parse(idCurrentAeroTB.Text);
                idCurrentAeroTB.Visible = false;

                idCurrentReportTB.Visible = true;
                int idCurrentReport = int.Parse(idCurrentReportTB.Text);
                idCurrentReportTB.Visible = false;

                SqlConnection connection = new SqlConnection(connectionPath);

                SqlCommand aeroDelete = new SqlCommand("DELETE FROM [Aerotechnics] WHERE [ID] =@ID", connection);
                SqlCommand reportDelete = new SqlCommand("DELETE FROM [Reports] WHERE [ID] =@ID", connection);

                connection.Open();

                DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить запись?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        aeroDelete.Parameters.AddWithValue("ID", idCurrentAero);
                        reportDelete.Parameters.AddWithValue("ID", idCurrentReport);


                        aeroDelete.ExecuteNonQuery();
                        reportDelete.ExecuteNonQuery();

                        MessageBox.Show("Запись удалена успешно!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);



                        this.aerotechnicsTableAdapter.Fill(this.airlineDBDataSet2.Aerotechnics);
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
