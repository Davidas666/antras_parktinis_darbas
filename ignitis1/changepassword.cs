using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ignitis1
{
    internal class changepassword
    {
        public void pakeisti(person person1, string oldpass, string newpass)
        {
            if (HashPassword.Hash(oldpass) == person1.password)
            {

                if (dbconnector.Connectiondb())
                {
                    string pass = HashPassword.Hash(newpass); 
                    string query = "UPDATE users SET Password = @NewPassword WHERE email = @Email AND UserID = @UserID";
                    MySqlCommand cmd = new MySqlCommand(query, dbconnector.GetConnection());
                    cmd.Parameters.AddWithValue("@NewPassword", pass);
                    cmd.Parameters.AddWithValue("@Email", person1.Email);
                    cmd.Parameters.AddWithValue("@UserID", person1.UserID);

                    try
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Password updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Invalid old password.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show($"Error updating password: {ex.Message}", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        dbconnector.CloseDB();
                    }
                }

            }
            else
            {
                MessageBox.Show($"Old password incorrect", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
