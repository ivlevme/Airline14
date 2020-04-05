using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline14
{
    public partial class BaseForm : Form
    {

        public string connectionPath = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\79266\source\repos\Airline14\Airline14\AirlineDB.mdf;Integrated Security=True;Connect Timeout=30";

        public SqlDataReader sdr;
        public BaseForm()
        {
            InitializeComponent();
            this.Size = new Size(950, 600);
        }

        protected virtual void BaseForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public void ExitButton_Click(object sender, EventArgs e)
        {
            exitMenuStrip();
        }

        public void ErrorMessageBox() 
        {
            MessageBox.Show("Введенные данные некорректные!", "Что-то пошло не так...", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void delRecord()
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить запись?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes) { MessageBox.Show("Пользовать удалён успешно!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
            else { MessageBox.Show("Необходимо подтвердить удаление!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        public void saveRecord()
        {
            MessageBox.Show("Успешно!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        public void exitMenuStrip()
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите выйти?", "Подтверждение выхода", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                AuthForm auth = new AuthForm();
                auth.Show();
            }

            else
            {
                MessageBox.Show("Необходимо подтвердить выход!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {

        }
    }
}
