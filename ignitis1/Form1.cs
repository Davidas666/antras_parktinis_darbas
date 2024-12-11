using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace ignitis1
{


    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void login_button_Click(object sender, EventArgs e)
        {
            string email = email_txt.Text;
            string hashedPassword = HashPassword.Hash(password_txt.Text);

            try
            {
                if (dbconnector.Connectiondb())
                {
                    string query = "SELECT RoleID, UserID, FirstName, LastName, Email, username, Grupe_id, BirthDate FROM users WHERE email = @Email AND Password = @Password";
                    MySqlCommand cmd = new MySqlCommand(query, dbconnector.GetConnection());
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", hashedPassword);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        int roleID = reader.GetInt32("RoleID");
                        int id = reader.GetInt32("UserID");
                        MessageBox.Show($"Login successful! Role ID: {roleID}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        person zmogus = new person
                        {
                            UserID = reader.GetInt32("UserID"),
                            FirstName = reader.GetString("FirstName"),
                            LastName = reader.GetString("LastName"),
                            username = reader.GetString("username"),
                            grupe = reader.GetInt32("Grupe_id"),
                            Email = reader.GetString("Email"),
                            RoleID = reader.GetInt32("RoleID"),
                            BirthDate = reader.GetDateTime("BirthDate"),
                            password = hashedPassword
                        };
                        if (roleID == 3)
                        {
                            this.Hide();
                            adminpanel adminpanel = new adminpanel(zmogus);
                            adminpanel.Show();

                        }
                        else if (roleID == 2)
                        {
                            this.Hide();
                            main lol = new main(zmogus);
                            lol.Show();
                        }
                        else if (roleID == 4)
                        {
                            this.Hide();
                            vadybininkas lol = new vadybininkas();
                            lol.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid email or password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    reader.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error logging in: {ex.Message}", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbconnector.CloseDB();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
