using System;
using System.Data;
using System.Windows.Forms;

namespace ignitis1
{
    public partial class vadybininkas : Form
    {
        public vadybininkas()
        {
            InitializeComponent();
        }

        private void vadybininkas_Load(object sender, EventArgs e)
        {
            vadybinikas_duomenys.getstatus();
            dataGridView1.DataSource = vadybinikas_duomenys.dtstatus;
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(skaiciai.Text))
            {
                vadybinikas_duomenys.EditPrice(EditNumStatus, double.Parse(skaiciai.Text));
                edit1.Visible = false;
                MessageBox.Show("valiooooooo", "kaif", MessageBoxButtons.OK, MessageBoxIcon.Information);
                vadybinikas_duomenys.getstatus();

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
                    MessageBox.Show("Invalid data selected in the grid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    panel1.Visible = true;
                }
                else
                {
                    MessageBox.Show("Invalid data selected in the grid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void edit_btn2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(skaiciai.Text))
            {
                vadybinikas_duomenys.EditPrice2(EditNumStatus, double.Parse(skaiciai_vando.Text));
                panel1.Visible = false;
                MessageBox.Show("valiooooooo", "kaif", MessageBoxButtons.OK, MessageBoxIcon.Information);
                vadybinikas_duomenys.getstatus();


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
                    panel2.Visible = true;
                }
                else
                {
                    MessageBox.Show("Invalid data selected in the grid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void edit_btn3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(skaiciai3.Text))
            {
                vadybinikas_duomenys.EditPrice3(EditNumStatus, double.Parse(skaiciai3.Text));
                panel2.Visible = false;
                MessageBox.Show("valiooooooo", "kaif", MessageBoxButtons.OK, MessageBoxIcon.Information);
                vadybinikas_duomenys.getstatus();

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
