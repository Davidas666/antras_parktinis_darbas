using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ignitis1
{
    public partial class main : Form
    {
        private person zmogus;
        public main(person person1)
        {
            InitializeComponent();
            zmogus = person1;
            vardastxt.Text = zmogus.FirstName;
            pavardetxt.Text = zmogus.LastName;
            email.Text = zmogus.Email;
            username.Text = zmogus.username;
        }

        private void change_password_button_Click(object sender, EventArgs e)
        {
            password_change_panel.Visible = true;

        }


        private void chane_password_button_Click(object sender, EventArgs e)
        {
            new changepassword().pakeisti(zmogus, old_password_textbox.Text, new_password_textbox.Text);
        }

        private void back_to_login_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void change_password_button_Click_1(object sender, EventArgs e)
        {
            password_change_panel.Visible = true;
        }

        private void show_price_Click(object sender, EventArgs e)
        {
            Kainu_panel.Visible = true;
            try
            {
                if (dbconnector.Connectiondb())
                {
                    string query = "SELECT elektra, vando, mokesciai, pavadinimas FROM bendrija WHERE bendrijos_id = @grupe";
                    MySqlCommand cmd = new MySqlCommand(query, dbconnector.GetConnection());
                    cmd.Parameters.AddWithValue("@grupe", zmogus.grupe);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string pavadinimas = reader.GetString("pavadinimas");
                        int elektra = reader.GetInt32("elektra");
                        int vando = reader.GetInt32("vando");
                        int mokesciai = reader.GetInt32("mokesciai");

                        bendrija bendrija1 = new bendrija
                        {
                            elektra = elektra,
                            vando = vando,
                            mokesciai = mokesciai
                        };
                        Pavadinimas_txt.Text = "Jus priklausote " + pavadinimas;
                        elektra_txt.Text = "Elektros kaina jums " + bendrija1.elektra.ToString();
                        vando_txt.Text = "Kaina uz vandeni " + bendrija1.vando.ToString();
                        mokesciai_txt.Text = "Mokesciu kaina " + bendrija1.mokesciai.ToString();
                        reader.Close();
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error retrieving prices: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbconnector.CloseDB();
            }

        }

        private void chane_password_button_Click_1(object sender, EventArgs e)
        {
            if (confirm_password_textbox.Text == new_password_textbox.Text)
            {
                new changepassword().pakeisti(zmogus, old_password_textbox.Text, new_password_textbox.Text);
            }
            else
            {
                MessageBox.Show($"Slaptazodis nesutampa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form = new Form1();
            form.Show();
        }
    }
}

