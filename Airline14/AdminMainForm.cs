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
    public partial class AdminMainForm : BaseForm
    {
        public AdminMainForm()
        {
            InitializeComponent();
        }

        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            AdminAddUserForm admAddUserForm = new AdminAddUserForm();
            admAddUserForm.Show();
            this.Hide();
        }

        private void AllUsersButton_Click(object sender, EventArgs e)
        {
            AdminAllUsersForm admAllUsersForm = new AdminAllUsersForm();
            admAllUsersForm.Show();
            this.Hide();
        }

        private void оПрограммеToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AboutProgramForm aboutProgram = new AboutProgramForm();
            aboutProgram.Show();
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exitMenuStrip();
        }

        private void просмотрВсехПользователейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminAllUsersForm admAllUsers = new AdminAllUsersForm();
            admAllUsers.Show();
            this.Hide();
        }

        private void добавитьНовогоПользователяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminAddUserForm admAddUsers = new AdminAddUserForm();
            admAddUsers.Show();
            this.Hide();
        }

        private void AdminMainForm_Load(object sender, EventArgs e)
        {
        }
    }
}
