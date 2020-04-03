using System;
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
    public partial class AdminAllUsersForm : BaseForm
    {
        public AdminAllUsersForm()
        {
            InitializeComponent();
        }

        private void AboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutProgramForm aboutProgram = new AboutProgramForm();
            aboutProgram.Show();
        }

        private void backToMainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminMainForm admForm = new AdminMainForm();
            admForm.Show();
            this.Hide();
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exitMenuStrip();
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminAddUserForm admAddUser = new AdminAddUserForm();
            admAddUser.Show();
            this.Hide();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveRecord();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            delRecord();
        }

        private void toolStripButtonRemove_Click(object sender, EventArgs e)
        {
            delRecord();
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            AdminAddUserForm admAddUser = new AdminAddUserForm();
            admAddUser.Show();
            this.Hide();
        }

        private void AdminAllUsersForm_Load(object sender, EventArgs e)
        {
            this.usersTableAdapter.Fill(this.airlineDBDataSet2.Users);
            DisplayReadOnlyAdmin();
        }

        private void удалитьПользователяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            delRecord();
        }

        public void DisplayReadOnlyAdmin()
        {
            toolStripButtonCreate.Enabled = true;
            toolStripButtonRemove.Enabled = false;
            editUserToolStripMenuItem.Enabled = false;
            delUserToolStripMenuItem.Enabled = false;
            addNewUserToolStripMenuItem.Enabled = true;
            UnDotoolStripButton.Enabled = false;
        }

        public void DisplayEditAdmin()
        {
            toolStripButtonCreate.Enabled = false;
            toolStripButtonRemove.Enabled = true;
            editUserToolStripMenuItem.Enabled = true;
            delUserToolStripMenuItem.Enabled = true;
            addNewUserToolStripMenuItem.Enabled = false;
            UnDotoolStripButton.Enabled = true;
        }

        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
            DisplayEditAdmin();
        }

        private void UnDotoolStripButton_Click(object sender, EventArgs e)
        {
            DisplayReadOnlyAdmin();
        }
    }
}
