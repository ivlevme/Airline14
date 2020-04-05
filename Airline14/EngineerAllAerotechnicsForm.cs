﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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



            NameAerotechnicTB.DataBindings.Add(new Binding("Text", dataSource: aerotechnicsBindingSource, dataMember: "Name"));
            CapacityTB.DataBindings.Add(new Binding("Text", dataSource: aerotechnicsBindingSource, dataMember: "Capacity"));
            CrewTB.DataBindings.Add(new Binding("Text", dataSource: aerotechnicsBindingSource, dataMember: "Crew Count"));
        }

        private bool appModeEdit = false;
        public void DisplayReadOnlyEngineer()
        {
            NameAerotechnicTB.Enabled = false;
            CapacityTB.Enabled = false;
            CrewTB.Enabled = false;

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

        public void DisplayEditEngineer()
        {
            NameAerotechnicTB.Enabled = true;
            CapacityTB.Enabled = true;
            CrewTB.Enabled = true;

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
    }
}
