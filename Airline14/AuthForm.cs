using MySql.Data.MySqlClient;
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
    public partial class AuthForm : BaseForm
    {
        public AuthForm()
        {
            InitializeComponent();
        }



        private void SinginButton_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection;
            sqlConnection = new SqlConnection(connectionPath);
            sqlConnection.Open();
            SqlDataReader sdr = null;
            SqlCommand cmdSelect = new SqlCommand("SELECT * FROM Users", sqlConnection);
            bool checklogin = false;

            try
            {
                sdr = cmdSelect.ExecuteReader();

                while (sdr.Read())
                {
                    Console.WriteLine(sdr["ID"]);
                    Console.WriteLine(sdr["Login"]);
                    Console.WriteLine(sdr["Password"]);
                    Console.WriteLine(sdr["Role"]);



                    if (LoginTB.Text == Convert.ToString(sdr["Login"]))
                    {
                        checklogin = true;

                        if (PasswordTB.Text == Convert.ToString(sdr["Password"]))
                        {
                            BaseForm.idCurrentUser = Convert.ToInt32(Convert.ToString(sdr["ID"]));

                            switch (Convert.ToString(sdr["Role"]))
                            {
                                case "admin":
                                    AdminAllUsersForm admForm = new AdminAllUsersForm();
                                    admForm.Show();
                                    this.Hide();
                                    break;

                                case "engineer":
                                    EngineerMainForm engineer = new EngineerMainForm();
                                    engineer.Show();
                                    this.Hide();
                                    break;

                                case "salesman":
                                    SalesmanMainForm salesman = new SalesmanMainForm();
                                    salesman.Show();
                                    this.Hide();
                                    break;

                                case "manager":
                                    ManagerMainForm managerForm = new ManagerMainForm();
                                    managerForm.Show();
                                    this.Hide();
                                    break;
                            }
                        }
                        else
                        {
                            PasswordTB.Text = "";
                            MessageBox.Show("Введеный пароль некорректный. Попробуйте еще раз.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                    }
                }

                if (checklogin == false)
                {
                    MessageBox.Show("Введеный логин некорректный. Попробуйте еще раз.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void AuthForm_Load(object sender, EventArgs e)
        {
            SqlConnection sqlConnection;
            sqlConnection = new SqlConnection(connectionPath);
            sqlConnection.Open();
            SqlDataReader sdr = null;
            SqlCommand cmdSelect = new SqlCommand("SELECT * FROM Users", sqlConnection);
            sdr = cmdSelect.ExecuteReader();

            while (sdr.Read())
            {
                Console.WriteLine($"{sdr["ID"]} {sdr["Login"]} {sdr["Password"]} {sdr["Role"]}");
            }

            sdr.Close();

            SqlDataAdapter adapter2 = new SqlDataAdapter("SELECT * FROM Users", sqlConnection);

            DataSet ds = new DataSet();
            adapter2.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            foreach (DataTable dt in ds.Tables)
            {
                Console.WriteLine(dt.TableName); // название таблицы
                                                 // перебор всех столбцов
                foreach (DataColumn column in dt.Columns)
                    Console.Write("\t{0}", column.ColumnName);
                Console.WriteLine();
                // перебор всех строк таблицы
                foreach (DataRow row in dt.Rows)
                {
                    // получаем все ячейки строки
                    var cells = row.ItemArray;
                    foreach (object cell in cells)
                        Console.Write("\t{0}", cell);
                    Console.WriteLine();
                }
            }
        }

            private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
