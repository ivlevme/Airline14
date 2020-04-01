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
    public partial class BaseForm : Form
    {

        public String UserLogin = String.Empty;

        public BaseForm()
        {
            InitializeComponent();
            this.Size = new Size(950, 600);
        }

        protected virtual void BaseForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            exitMenuStrip();
        }

        public void ErrorMessageBox() 
        {
            MessageBox.Show("Введенные данные некорректные!", "Что-то пошло не так...", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void exitMenuStrip()
        {
            this.Hide();
            AuthForm auth = new AuthForm();
            auth.Show();
        } 
    }
}
