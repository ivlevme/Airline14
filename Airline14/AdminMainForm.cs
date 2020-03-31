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
    }
}
