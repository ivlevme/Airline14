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
            } else if (LoginTB.Text == "manager" && PasswordTB.Text == "mng") {
                ManagerMainForm managerForm = new ManagerMainForm();
                managerForm.Show();
                this.Hide();
            } else if (LoginTB.Text == "salesman" && PasswordTB.Text == "sls")
            {
                SalesmanMainForm salesman = new SalesmanMainForm();
                salesman.Show();
                this.Hide();
            }
            else if (LoginTB.Text == "engineer" && PasswordTB.Text == "eng")
            {
                EngineerMainForm engineer = new EngineerMainForm();
                engineer.Show();
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

        private void оПрограммеToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AboutProgramForm aboutProgram = new AboutProgramForm();
            aboutProgram.Show();
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
