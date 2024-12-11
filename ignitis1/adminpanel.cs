using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ignitis1
{
    public partial class adminpanel : Form
    {
        private person zmogus;
        public adminpanel(person person1)
        {
            InitializeComponent();
            zmogus = person1;
            vardastxt.Text = zmogus.FirstName;
            pavardetxt.Text = zmogus.LastName;
            email.Text = zmogus.Email;
            username.Text = zmogus.username;
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            string firstName = name_reg_textbox.Text;
            string lastName = lastname_reg_textbox.Text;
            DateTime birthDate;
            string email = email_reg_textbox.Text;
            string username = username_reg_textbox.Text;
            string grupe_id = grupe_id_txt.Text;



            try
            {
                int year = int.Parse(year_reg_textbox.Text);
                int month = int.Parse(month_reg_textbox.Text);
                int day = int.Parse(day_reg_textbox.Text);

                birthDate = new DateTime(year, month, day);
            }
            catch (FormatException)
            {
                MessageBox.Show("Prasau ivesti skaicius", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Prasau iveskite data teisingai", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime minimumDate = DateTime.Now.AddYears(-14);


            if (birthDate <= minimumDate)
            {
                try
                {
                    string password = HashPassword.Hash(lastname_reg_textbox.Text);
                    if (dbconnector.Connectiondb())
                    {
                        string query = "INSERT INTO users (FirstName, LastName, BirthDate, email, username, Password, Grupe_id) VALUES (@FirstName, @LastName, @BirthDate, @Email, @Username, @Password, @Grupe_id)";
                        MySqlCommand cmd = new MySqlCommand(query, dbconnector.GetConnection());
                        cmd.Parameters.AddWithValue("@FirstName", firstName);
                        cmd.Parameters.AddWithValue("@LastName", lastName);
                        cmd.Parameters.AddWithValue("@BirthDate", birthDate);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.Parameters.AddWithValue("@Grupe_id", grupe_id);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Naudotojas sekmingai pridetas!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        naudotojas_add_panel.Visible = false;
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Error registering user: {ex.Message}", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    dbconnector.CloseDB();
                }
            }
            else
            {
                MessageBox.Show("Amziaus cenzas!", "Amziaus cenzas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            naudotojas_add_panel.Visible = true;
            naudotoju_sarasas_panel.Visible = false;
            bendrijos_add_panel.Visible = false;
            bendriju_list_panel.Visible = false;
            panel1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bendriju_list_panel.Visible = true;
            bendrijos_add_panel.Visible = false;
            naudotojas_add_panel.Visible = false;
            naudotoju_sarasas_panel.Visible = false;
            panel1.Visible = false;
            vadybinikas_duomenys.getstatus();
            dataGridView1.DataSource = vadybinikas_duomenys.dtstatus;
        }

        static public int EditNumStatus;
        static public double EditStatus;
        private void vissible_edit_button_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                if (int.TryParse(dataGridView1.CurrentRow.Cells[0].Value?.ToString(), out int idStatus) &&
                    double.TryParse(dataGridView1.CurrentRow.Cells[1].Value?.ToString(), out double newPrice))
                {
                    EditNumStatus = idStatus;
                    EditStatus = newPrice;
                    edit1.Visible = true;
                }
                else
                {
                    MessageBox.Show("Klaidingai issirinkti duomenys.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void vandens_kaina_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                if (int.TryParse(dataGridView1.CurrentRow.Cells[0].Value?.ToString(), out int idStatus) &&
                    double.TryParse(dataGridView1.CurrentRow.Cells[1].Value?.ToString(), out double newPrice))
                {
                    EditNumStatus = idStatus;
                    EditStatus = newPrice;
                    panel4.Visible = true;
                }
                else
                {
                    MessageBox.Show("Klaidingai issirinkti duomenys.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void mokesciu_kaina_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                if (int.TryParse(dataGridView1.CurrentRow.Cells[0].Value?.ToString(), out int idStatus) &&
                    double.TryParse(dataGridView1.CurrentRow.Cells[1].Value?.ToString(), out double newPrice))
                {
                    EditNumStatus = idStatus;
                    EditStatus = newPrice;
                    panel3.Visible = true;
                }
                else
                {
                    MessageBox.Show("Klaidingai issirinkti duomenys.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void edit_btn3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(skaiciai_mokesciai.Text))
            {
                vadybinikas_duomenys.EditPrice3(EditNumStatus, double.Parse(skaiciai_mokesciai.Text));
                panel3.Visible = false;
                MessageBox.Show("Sekmingai", "Super", MessageBoxButtons.OK, MessageBoxIcon.Information);
                vadybinikas_duomenys.getstatus();

            }
        }

        private void edit_btn2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(skaiciai_vando.Text))
            {
                vadybinikas_duomenys.EditPrice2(EditNumStatus, double.Parse(skaiciai_vando.Text));
                panel4.Visible = false;
                MessageBox.Show("Sekmingai", "Super", MessageBoxButtons.OK, MessageBoxIcon.Information);
                vadybinikas_duomenys.getstatus();

            }
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(skaiciai.Text))
            {
                vadybinikas_duomenys.EditPrice(EditNumStatus, double.Parse(skaiciai.Text));
                edit1.Visible = false;
                MessageBox.Show("Sekmingai", "Super", MessageBoxButtons.OK, MessageBoxIcon.Information);
                vadybinikas_duomenys.getstatus();

            }
        }

        private void parodyti_naudotojus_btn_Click(object sender, EventArgs e)
        {
            naudotoju_sarasas_panel.Visible = true;
            bendriju_list_panel.Visible = false;
            bendrijos_add_panel.Visible = false;
            naudotojas_add_panel.Visible = false;
            panel1.Visible = false;
            naudotoju_duomenys.getstatus();
            dataGridView2.DataSource = naudotoju_duomenys.dtstatus1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                if (int.TryParse(dataGridView1.CurrentRow.Cells[0].Value?.ToString(), out int idStatus))
                {
                    EditNumStatus = idStatus;
                    vadybinikas_duomenys.Delete_bendrija(EditNumStatus.ToString());
                    MessageBox.Show("Bendrija sekmingai istrinta", "Sekmingai", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    vadybinikas_duomenys.getstatus();
                }
                else
                {
                    MessageBox.Show("Klaidingai issirinkti duomenys.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void prideti_bendrija_btn_Click(object sender, EventArgs e)
        {
            double elektra = double.Parse(elektra_txt.Text);
            double vando = double.Parse(vando_txt.Text);
            double mokesciai = double.Parse(mokesciai_txt.Text);
            string pavadinimas = pavadinimas_txt.Text;
            try
            {
                string password = HashPassword.Hash(password1_reg_textbox.Text);
                if (dbconnector.Connectiondb())
                {
                    string query = "INSERT INTO bendrija (elektra, vando, mokesciai, pavadinimas) VALUES (@elektra, @vando, @mokesciai, @pavadinimas)";
                    MySqlCommand cmd = new MySqlCommand(query, dbconnector.GetConnection());
                    cmd.Parameters.AddWithValue("@elektra", elektra);
                    cmd.Parameters.AddWithValue("@vando", vando);
                    cmd.Parameters.AddWithValue("@mokesciai", mokesciai);
                    cmd.Parameters.AddWithValue("@pavadinimas", pavadinimas);
                    cmd.ExecuteNonQuery();
                    vadybinikas_duomenys.getstatus();
                    MessageBox.Show("Bendrija sekmingai pridetas!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error registering user: {ex.Message}", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bendriju_list_panel.Visible = false;
            naudotojas_add_panel.Visible = false;
            naudotoju_sarasas_panel.Visible = false;
            bendrijos_add_panel.Visible = true;
            panel1.Visible = false;
        }

        private void delete_user_btn_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow != null)
            {
                if (int.TryParse(dataGridView2.CurrentRow.Cells[0].Value?.ToString(), out int idStatus))
                {
                    EditNumStatus = idStatus;
                    naudotoju_duomenys.Delete(EditNumStatus.ToString());
                    MessageBox.Show("Naudotojas sekmingai istrintas", "Sekmingai", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    naudotoju_duomenys.getstatus();
                }
                else
                {
                    MessageBox.Show("Klaidingai issirinkti duomenys.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Pasirinkit eilute.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void change_id_btn_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow != null)
            {
                if (int.TryParse(dataGridView2.CurrentRow.Cells[0].Value?.ToString(), out int idStatus))
                {
                    EditNumStatus = idStatus;

                    change_id_panel.Visible = true;
                }
                else
                {
                    MessageBox.Show("Klaidingai issirinkti duomenys.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void edit_group_id_btn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(grupes_textbox.Text))
            {
                naudotoju_duomenys.keisti_grupe(EditNumStatus, double.Parse(grupes_textbox.Text));
                change_id_panel.Visible = false;
                MessageBox.Show("Sekmingai", "Super", MessageBoxButtons.OK, MessageBoxIcon.Information);
                naudotoju_duomenys.getstatus();

            }
        }

        private void change_mode_btn_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow != null)
            {
                if (int.TryParse(dataGridView2.CurrentRow.Cells[0].Value?.ToString(), out int idStatus))
                {
                    EditNumStatus = idStatus;

                    change_mode_panel.Visible = true;
                }
                else
                {
                    MessageBox.Show("Klaidingai issirinkti duomenys.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Pasirinkit eilute.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void edit_mode_id_btn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(mode_textbox.Text))
            {
                naudotoju_duomenys.keisti_mode(EditNumStatus, double.Parse(mode_textbox.Text));
                change_mode_panel.Visible = false;
                MessageBox.Show("Sekmingai", "Super", MessageBoxButtons.OK, MessageBoxIcon.Information);
                naudotoju_duomenys.getstatus();

            }
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form = new Form1();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string firstName = name_reg_textbox1.Text;
            string lastName = lastname_reg_textbox1.Text;
            DateTime birthDate;
            string email = email_reg_textbox1.Text;
            string username = username_reg_textbox1.Text;



            try
            {
                int year = int.Parse(year_reg_textbox1.Text);
                int month = int.Parse(month_reg_textbox1.Text);
                int day = int.Parse(day_reg_textbox1.Text);

                birthDate = new DateTime(year, month, day);
            }
            catch (FormatException)
            {
                MessageBox.Show("Prasau ivesti skaicius", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Prasau iveskite data teisingai", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime minimumDate = DateTime.Now.AddYears(-14);


            if (birthDate <= minimumDate)
            {
                try
                {
                    string password = HashPassword.Hash(lastname_reg_textbox1.Text);
                    if (dbconnector.Connectiondb())
                    {
                        string query = "INSERT INTO users (FirstName, LastName, BirthDate, email, username, Password, RoleID) VALUES (@FirstName, @LastName, @BirthDate, @Email, @Username, @Password, @RoleID)";
                        MySqlCommand cmd = new MySqlCommand(query, dbconnector.GetConnection());
                        cmd.Parameters.AddWithValue("@FirstName", firstName);
                        cmd.Parameters.AddWithValue("@LastName", lastName);
                        cmd.Parameters.AddWithValue("@BirthDate", birthDate);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.Parameters.AddWithValue("@RoleID", 4);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Vadybininkas sekmingai pridetas!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        naudotojas_add_panel.Visible = false;
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Error registering user: {ex.Message}", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    dbconnector.CloseDB();
                }
            }
            else
            {
                MessageBox.Show("Amziaus cenzas!", "Amziaus cenzas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = true;
            naudotojas_add_panel.Visible = false;
            naudotoju_sarasas_panel.Visible = false;
            bendrijos_add_panel.Visible = false;
            bendriju_list_panel.Visible = false;
        }
    }
}
