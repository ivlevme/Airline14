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
            if (usersDataGridView.SelectedRows.Count > 0)
            {
                delRecord();
            }
            else
            {
                MessageBox.Show("Выберете пользователя!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DisplayReadOnlyAdmin()
        {
            createToolStripButton.Enabled = true;
            removeToolStripButton.Enabled = false;
            editUserToolStripMenuItem.Enabled = false;
            delUserToolStripMenuItem.Enabled = false;
            addNewUserToolStripMenuItem.Enabled = true;
            UnDoToolStripButton.Enabled = false;
            delCurrentUserToolStripMenuItem.Enabled = false;
            editCurrentUserToolStripMenuItem.Enabled = false;
            createToolStripMenuItem.Enabled = true;
            saveToolStripButton.Enabled = false;
        }

        public void DisplayEditAdmin()
        {
            createToolStripButton.Enabled = false;
            removeToolStripButton.Enabled = true;
            editUserToolStripMenuItem.Enabled = true;
            delUserToolStripMenuItem.Enabled = true;
            addNewUserToolStripMenuItem.Enabled = false;
            UnDoToolStripButton.Enabled = true;
            delCurrentUserToolStripMenuItem.Enabled = true;
            editCurrentUserToolStripMenuItem.Enabled = true;
            createToolStripMenuItem.Enabled = false;
            saveToolStripButton.Enabled = true;
        }

        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
            DisplayEditAdmin();
        }

        private void UnDotoolStripButton_Click(object sender, EventArgs e)
        {
            DisplayReadOnlyAdmin();
        }
        AdminAddUserForm adminAddUser = new AdminAddUserForm();

        private void editUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (usersDataGridView.SelectedRows.Count > 0)
            {
                MessageBox.Show(usersDataGridView.SelectedCells[0].RowIndex.ToString());

                adminAddUser.LoginTB.Text = usersDataGridView.SelectedRows[0].Cells[1].Value.ToString();
                adminAddUser.PasswordTB.Text = usersDataGridView.SelectedRows[0].Cells[2].Value.ToString();
                adminAddUser.RoleCB.SelectedItem = usersDataGridView.SelectedRows[0].Cells[3].Value.ToString();


                adminAddUser.HeaderLabel.Text = "Редактирование пользователя";
                adminAddUser.HeaderLabel.Location = new Point(250, 55);
                adminAddUser.AddUserBtn.Text = "Изменить данные пользователя";
                adminAddUser.AddUserBtn.Click -= adminAddUser.SinginBtn_Click;
                adminAddUser.AddUserBtn.Click += CloseEditUserAdminForm;

                adminAddUser.Show();
            } else
            {
                MessageBox.Show("Выберете пользователя!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CloseEditUserAdminForm(object sender, EventArgs e)
        {
            MessageBox.Show(usersDataGridView.SelectedRows[0].Cells[3].Value.ToString());

            usersDataGridView.SelectedRows[0].Cells[1].Value = adminAddUser.PasswordTB.Text;
            usersDataGridView.SelectedRows[0].Cells[2].Value = adminAddUser.PasswordTB.Text;
            usersDataGridView.SelectedRows[0].Cells[3].Value = adminAddUser.RoleCB.SelectedItem;

            adminAddUser.Hide();
        }
    }
}
