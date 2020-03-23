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
    public partial class AuthForm : BaseForm
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        private void SinginButton_Click(object sender, EventArgs e)
        {
            if (LoginTB.Text == "admin" && PasswordTB.Text == "adm")
            {
                AdminMainForm admForm = new AdminMainForm();
                admForm.Show();
                this.Hide();
            }
            else
            {
                ErrorMessageBox();
            }
        }

        private void PasswordTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
