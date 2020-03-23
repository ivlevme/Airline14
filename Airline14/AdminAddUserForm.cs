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

        private void SinginBtn_Click(object sender, EventArgs e)
        {
            if (PersonalTB.Text == "" || LoginTB.Text == "" || PasswordTB.Text == "" || RoleCB.SelectedIndex == -1)
            {
                ErrorMessageBox();
            }
            else
            {
                MessageBox.Show("Новый пользователь успешно создан!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
