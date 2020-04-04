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
    public partial class AdminAddUserForm : BaseForm
    {
        public AdminAddUserForm()
        {
            InitializeComponent();
        }

        public void SinginBtn_Click(object sender, EventArgs e)
        {
            if (LoginTB.Text == "" || PasswordTB.Text == "" || RoleCB.SelectedIndex == -1)
            {
                ErrorMessageBox();
            }
            else
            {
                if (checkRepeatDataBase())
                {
                    MessageBox.Show("Данные успешно добавлены!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                } else
                {
                    ErrorMessageBox();
                }
            }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutProgramForm aboutProgram = new AboutProgramForm();
            aboutProgram.Show();
        }

        private void вернутьсяНаГлавнуюСтраницуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminMainForm admForm = new AdminMainForm();
            admForm.Show();
            this.Hide();
        }

        private bool checkRepeatDataBase()
        {
            return true;
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exitMenuStrip();
        }

        private void просмотрВсехПользователейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminAllUsersForm admAllUsersForm = new AdminAllUsersForm();
            admAllUsersForm.Show();
            this.Hide();
        }
    }
}
