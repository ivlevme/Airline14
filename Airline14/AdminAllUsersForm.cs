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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exitMenuStrip();
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayEditAdmin();
            AddUserBtn.Visible = true;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveRecord();
        }

        private void delToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleteUser();
        }

        bool delete = false;
        int[] idDeletedUser = new int [1000];
        int currentIndexUser = 0;


        private void toolStripButtonRemove_Click(object sender, EventArgs e)
        {
            deleteUser();
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            DisplayEditAdmin();
            AddUserBtn.Visible = true;
            AddUserBtn.Text = "Создать пользователя";

            LoginTB.Text = "";
            PasswordTB.Text = "";
            RoleCB.SelectedIndex = -1;
        }

        bool appModeEdit = false;

        public void AdminAllUsersForm_Load(object sender, EventArgs e)
        {

            this.UsersTableAdapter.Fill(this.airlineDBDataSet2.Users);

            MessageBox.Show(idCurrentUser.ToString());

            int countUsers = usersDataGridView.Rows.Count;

            usersDataGridView.CurrentRow.Selected = false;

            DisplayReadOnlyAdmin();
            this.RoleCB.Items.AddRange(new object[] { "admin", "manager", "engineer", "salesman"});

            contextMenuStrip1.Enabled = true;



            LoginTB.DataBindings.Add(new Binding("Text", dataSource: usersBindingSource2, dataMember: "Login"));
            PasswordTB.DataBindings.Add(new Binding("Text", dataSource: usersBindingSource2, dataMember: "Password"));
            RoleCB.DataBindings.Add(new Binding("Text", dataSource: usersBindingSource2, dataMember: "Role"));
        }

        private void delUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleteUser();
        }

        public void deleteUser() 
        {
            if (appModeEdit == true)
            {
                if (usersDataGridView.SelectedRows.Count > 0)
                {
                    DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить запись?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (result == DialogResult.Yes)
                    {
                        idDeletedUser[currentIndexUser] = int.Parse(usersDataGridView.SelectedRows[0].Cells[0].Value.ToString());
                        currentIndexUser++;
                        usersDataGridView.Rows.RemoveAt(usersDataGridView.SelectedCells[0].RowIndex);
                        delete = true;

                        MessageBox.Show("Пользовать удалён! Необходимо сохранить внесенные изменения!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("Необходимо подтвердить удаление!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public void DisplayReadOnlyAdmin()
        {
            LoginTB.Enabled = false;
            PasswordTB.Enabled = false;
            RoleCB.Enabled = false;

            createToolStripButton.Enabled = true;
            addNewUserToolStripMenuItem.Enabled = true;
            createToolStripMenuItem.Enabled = true;


            editUserToolStripMenuItem.Enabled = false;
            editCurrentUserToolStripMenuItem.Enabled = true;


            delUserToolStripMenuItem.Enabled = false;
            delCurrentUserToolStripMenuItem.Enabled = false;
            removeToolStripButton.Enabled = true;


            saveToolStripButton.Enabled = false;
            UnDoToolStripButton.Enabled = false;

            appModeEdit = false;
        }

        public void DisplayEditAdmin()
        {
            LoginTB.Enabled = true;
            PasswordTB.Enabled = true;
            RoleCB.Enabled = true;

            createToolStripButton.Enabled = false;
            addNewUserToolStripMenuItem.Enabled = false;
            createToolStripMenuItem.Enabled = false;


            editUserToolStripMenuItem.Enabled = true;
            editCurrentUserToolStripMenuItem.Enabled = false;


            delCurrentUserToolStripMenuItem.Enabled = true;
            delUserToolStripMenuItem.Enabled = true;
            removeToolStripButton.Enabled = true;


            saveToolStripButton.Enabled = true;
            UnDoToolStripButton.Enabled = true;

            appModeEdit = true;
        }

        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
            DisplayEditAdmin();
            AddUserBtn.Text = "Обновить данные";
        }

        private void UnDotoolStripButton_Click(object sender, EventArgs e)
        {
            DisplayReadOnlyAdmin();
            this.UsersTableAdapter.Fill(this.airlineDBDataSet2.Users);

            int countUsers = usersDataGridView.Rows.Count;
            currentIndexUser = 0;
        }

        private void editUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (usersDataGridView.SelectedRows.Count > 0)
            {
                DisplayEditAdmin();
            } else
            {
                MessageBox.Show("Выберете пользователя!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            bool showSuccessModal = true;
            if (delete == true)
            {
                foreach (int id in idDeletedUser)
                {
                    this.UsersTableAdapter.Delete(id);
                }
            }
            else
            {
                if (checkRepeatLogin(LoginTB.Text) == true)
                {
                    usersDataGridView.CurrentCell = usersDataGridView.Rows[0].Cells[0];
                    this.UsersTableAdapter.Update(this.airlineDBDataSet2.Users);
                } else
                {
                    showSuccessModal = false;
                }
            }

            this.UsersTableAdapter.Fill(this.airlineDBDataSet2.Users);
            if (showSuccessModal == true)
            {
                MessageBox.Show("Данные успешно обновлены!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            DisplayReadOnlyAdmin();
        }

        private void editCurrentUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayEditAdmin();

        }

        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            if (LoginTB.Text != "" && PasswordTB.Text != "" && RoleCB.SelectedIndex != -1)
            {
                if (checkRepeatLogin(LoginTB.Text) == true)
                {
                    string connectionPath = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\79266\source\repos\Airline14\Airline14\AirlineDB.mdf;Integrated Security=True;Connect Timeout=30";

                    SqlConnection connection = new SqlConnection(connectionPath);
                    SqlCommand newUserInsert = new SqlCommand("INSERT INTO[dbo].[Users] ([Login], [Password], [Role]) VALUES(@Login, @Password, @Role);", connection);

                    connection.Open();
                    newUserInsert.Parameters.AddWithValue("Login", LoginTB.Text);
                    newUserInsert.Parameters.AddWithValue("Password", PasswordTB.Text);
                    newUserInsert.Parameters.AddWithValue("Role", RoleCB.Text);

                    try
                    {
                        newUserInsert.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    connection.Close();
                    this.UsersTableAdapter.Fill(this.airlineDBDataSet2.Users);

                    MessageBox.Show("Пользовать добавлен успешно!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    AddUserBtn.Visible = false;

                    DisplayReadOnlyAdmin();
                }
            } else
            {
                ErrorMessageBox();
            }
        }

        public bool checkRepeatLogin(string login)
        {
            string connectionPath = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\79266\source\repos\Airline14\Airline14\AirlineDB.mdf;Integrated Security=True;Connect Timeout=30";

            SqlConnection connection = new SqlConnection(connectionPath);
            SqlCommand selectLogin = new SqlCommand("Select [Login] FROM [Users];", connection);

            connection.Open();

            sdr = selectLogin.ExecuteReader();
            bool result = true;
            while (sdr.Read())
            {
                if (login == sdr["Login"].ToString())
                {
                    MessageBox.Show("Такой логин уже есть!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    result = false;
                    break;
                }
            }
            connection.Close();
            return result;
        }

        private void LoginTB_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void LoginTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
