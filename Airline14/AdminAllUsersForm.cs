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
            createButton();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createButton();
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

        private void createButton ()
        {
            DisplayEditAdmin();
            AddUserBtn.Visible = true;
            AddUserBtn.Text = "Создать пользователя";

            LoginTB.Text = "";
            PasswordTB.Text = "";
            RoleCB.SelectedIndex = -1;

            LoginTB.DataBindings.Clear();
            PasswordTB.DataBindings.Clear();
            RoleCB.DataBindings.Clear();

            editToolStripButton.Enabled = false;
            editCurrentUserToolStripMenuItem.Enabled = false;
            editUserToolStripMenuItem.Enabled = false;

            isBinding = false;

            enableChangeSortMode(false);
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            createButton();
        }

        bool appModeEdit = false;

        public void AdminAllUsersForm_Load(object sender, EventArgs e)
        {

            this.UsersTableAdapter.Fill(this.airlineDBDataSet2.Users);

            int countUsers = usersDataGridView.Rows.Count;

            this.RoleCB.Items.AddRange(new object[] { "admin", "manager", "engineer", "salesman"});

            contextMenuStrip1.Enabled = true;

            currentIDUser.DataBindings.Add(new Binding("Text", dataSource: usersBindingSource2, dataMember: "ID"));

            DisplayReadOnlyAdmin();
        }

        bool isBinding = false;
        private void addBindings ()
        {
            if (isBinding == false)
            {
                LoginTB.DataBindings.Add(new Binding("Text", dataSource: usersBindingSource2, dataMember: "Login"));
                PasswordTB.DataBindings.Add(new Binding("Text", dataSource: usersBindingSource2, dataMember: "Password"));
                RoleCB.DataBindings.Add(new Binding("Text", dataSource: usersBindingSource2, dataMember: "Role"));

                isBinding = true;
            }
        }

        private void delUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleteUser();
        }

        public void deleteUser() 
        {
            if (appModeEdit == true)
            {
                DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить запись?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    currentIDUser.Visible = true;
                    int currentUserID = int.Parse(currentIDUser.Text);
                    currentIDUser.Visible = false;


                    SqlConnection connection = new SqlConnection(connectionPath);

                    SqlCommand passDelete = new SqlCommand("DELETE FROM [Users] WHERE [ID] =@ID", connection);

                    connection.Open();

                    passDelete.Parameters.AddWithValue("ID", currentUserID);
                    try
                    {
                        passDelete.ExecuteNonQuery();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                    MessageBox.Show("Запись удалена успешно!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DisplayReadOnlyAdmin();
                }
                else
                {
                    MessageBox.Show("Необходимо подтвердить удаление!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


            editUserToolStripMenuItem.Enabled = true;
            editCurrentUserToolStripMenuItem.Enabled = true;


            delUserToolStripMenuItem.Enabled = false;
            delCurrentUserToolStripMenuItem.Enabled = true;
            removeToolStripButton.Enabled = true;


            saveToolStripButton.Enabled = false;
            UnDoToolStripButton.Enabled = false;

            addBindings();

            enableChangeSortMode(true);

            this.UsersTableAdapter.Fill(this.airlineDBDataSet2.Users);

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
            editCurrentUserToolStripMenuItem.Enabled = true;


            delCurrentUserToolStripMenuItem.Enabled = true;
            delUserToolStripMenuItem.Enabled = true;
            removeToolStripButton.Enabled = true;


            saveToolStripButton.Enabled = true;
            UnDoToolStripButton.Enabled = true;

            appModeEdit = true;
        }

        private void editButton ()
        {
            DisplayEditAdmin();

            indexCurrentRow = usersDataGridView.SelectedCells[0].RowIndex;

            enableChangeSortMode(false);
        }

        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
            editButton();
        }

        private void enableChangeSortMode(bool mode)
        {
            if (mode == true)
            {
                foreach (DataGridViewColumn column in usersDataGridView.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.Automatic;
                }
            }
            else
            {
                foreach (DataGridViewColumn column in usersDataGridView.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
            }
        }

        private void UnDotoolStripButton_Click(object sender, EventArgs e)
        {
            DisplayReadOnlyAdmin();
        }

        private void editUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editButton();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (LoginTB.Text != "" && PasswordTB.Text != "" && RoleCB.SelectedIndex != -1 && LoginTB.TextLength <= 40 && PasswordTB.TextLength <= 40)
            {
                currentIDUser.Visible = true;
                int currentUserID = int.Parse(currentIDUser.Text);
                currentIDUser.Visible = false;


                SqlConnection connection = new SqlConnection(connectionPath);

                SqlCommand usersUpdate = new SqlCommand("UPDATE [Users] SET [Login] = @Login, [Password] = @Password, [Role] = @Role WHERE [ID] =@ID", connection);


                connection.Open();
                try
                {
                    usersUpdate.Parameters.AddWithValue("Login", LoginTB.Text);
                    usersUpdate.Parameters.AddWithValue("Password", PasswordTB.Text);
                    usersUpdate.Parameters.AddWithValue("Role", RoleCB.SelectedItem.ToString());

                    usersUpdate.Parameters.AddWithValue("ID", currentUserID);


                    usersUpdate.ExecuteNonQuery();

                    MessageBox.Show("Данные успешно обновлены!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                connection.Close();

                DisplayReadOnlyAdmin();
            }
            else
            {
                ErrorMessageBox();
            }
        }

        private void editCurrentUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editButton();
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
        int indexCurrentRow;
        private void usersDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (usersDataGridView.SelectedRows.Count > 0)
            {
                if (appModeEdit == true)
                {
                    if (MouseButtons != System.Windows.Forms.MouseButtons.None)
                        ((DataGridView)sender).CurrentCell = usersDataGridView.Rows[indexCurrentRow].Cells[0];
                }
            }
        }
    }
}
