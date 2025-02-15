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
    public partial class EngineerAllReportsForm : BaseForm
    {
        public EngineerAllReportsForm()
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
            EngineerMainForm engMain = new EngineerMainForm();
            engMain.Show();
            this.Hide();
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exitMenuStrip();
        }

        private void добавитьНовогоПользователяToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void добавитьАэротехнкикуToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void списокВсейАэротехнкикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EngineerAllAerotechnicsForm engAllAero = new EngineerAllAerotechnicsForm();
            engAllAero.Show();
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

        private void EngineerAllReportsForm_Load(object sender, EventArgs e)
        {
            this.reportsTableAdapter.Fill(this.airlineDBDataSet2.Reports);


            DisplayReadOnlyEngineer();

            IDReportTB.Enabled = true;
            DateTimeTB.Enabled = true;



            IDReportTB.DataBindings.Add(new Binding("Text", dataSource: reportsBindingSource, dataMember: "ID"));
            DateTimeTB.DataBindings.Add(new Binding("Text", dataSource: reportsBindingSource, dataMember: "Date"));
            ContentReportTB.DataBindings.Add(new Binding("Text", dataSource: reportsBindingSource, dataMember: "Content"));
        }

        public bool appModeEdit = false;

        private void DisplayReadOnlyEngineer ()
        {
            ContentReportTB.Enabled = false;


            editToolStripButton.Enabled = true;
            editReportToolStripMenuItem.Enabled = true;
            editRepoToolStripMenuItem.Enabled = true;


            saveToolStripButton.Enabled = false;
            UnDoToolStripButton.Enabled = false;

            appModeEdit = false;

            enableChangeSortMode(true);
        }

        private void DisplayEditEngineer()
        {
            ContentReportTB.Enabled = true;

            editToolStripButton.Enabled = false;
            editReportToolStripMenuItem.Enabled = true;
            editRepoToolStripMenuItem.Enabled = true;


            saveToolStripButton.Enabled = true;
            UnDoToolStripButton.Enabled = true;

            appModeEdit = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        int indexCurrentRow = 1;

        private void editButton ()
        {
            DisplayEditEngineer();

            indexCurrentRow = dataGridView1.SelectedCells[0].RowIndex;

            enableChangeSortMode(false);
        }

        private void editToolStripButton_Click(object sender, EventArgs e)
        {
            editButton();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {

            int idCurrentReport = int.Parse(IDReportTB.Text);

            SqlConnection connection = new SqlConnection(connectionPath);

            SqlCommand reportUpdate = new SqlCommand("UPDATE [Reports] SET [Content] = @Content WHERE [ID] =@ID", connection);


            connection.Open();
            try
            {
                reportUpdate.Parameters.AddWithValue("ID", idCurrentReport);
                reportUpdate.Parameters.AddWithValue("Content", ContentReportTB.Text);

                reportUpdate.ExecuteNonQuery();

                MessageBox.Show("Данные успешно обновлены!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.reportsTableAdapter.Fill(this.airlineDBDataSet2.Reports);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            connection.Close();

            DisplayReadOnlyEngineer();
        }

        private void editRepoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editButton();
        }

        private void UnDoToolStripButton_Click(object sender, EventArgs e)
        {
            DisplayReadOnlyEngineer();
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

        private void editReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editButton();
        }
    }
}
