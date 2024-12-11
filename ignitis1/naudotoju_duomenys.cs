using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ignitis1
{
    internal class naudotoju_duomenys : dbconnector
    {
        static public DataTable dtstatus1 = new DataTable();
        static public void getstatus()
        {
            try
            {
                if (msCommand.Connection.State == ConnectionState.Open)
                {
                    msCommand.Connection.Close();
                }

                msCommand.CommandText = "SELECT * FROM users";
                dtstatus1.Clear();
                msDataAdapter.SelectCommand = msCommand;
                msDataAdapter.Fill(dtstatus1);
            }
            catch (DbException dbEx)
            {
                MessageBox.Show($"Database error: {dbEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        static public void Delete(string del)
        {
            try
            {
                if (msCommand.Connection.State != ConnectionState.Open)
                {
                    msCommand.Connection.Open();
                }

                msCommand.CommandText = "DELETE FROM users WHERE UserID = @del";
                msCommand.Parameters.Clear();
                msCommand.Parameters.AddWithValue("@del", del);
                msCommand.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Error in deleting status" + del, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        static public bool keisti_grupe(int idStatus, double Grupe_id)
        {
            try
            {
                if (msCommand.Connection.State != ConnectionState.Open)
                {
                    msCommand.Connection.Open();
                }

                msCommand.CommandText = "UPDATE users SET Grupe_id = @Grupe_id WHERE UserID = @idStatus;";
                msCommand.Parameters.Clear();
                msCommand.Parameters.AddWithValue("@Grupe_id", Grupe_id);
                msCommand.Parameters.AddWithValue("@idStatus", idStatus);

                return msCommand.ExecuteNonQuery() > 0;
            }
            catch (DbException dbEx)
            {
                MessageBox.Show($"Database error: {dbEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                if (msCommand.Connection.State == ConnectionState.Open)
                {
                    msCommand.Connection.Close();
                }
            }
        }
        static public bool keisti_mode(int idStatus, double RoleID)
        {
            try
            {
                if (msCommand.Connection.State != ConnectionState.Open)
                {
                    msCommand.Connection.Open();
                }

                msCommand.CommandText = "UPDATE users SET RoleID = @RoleID WHERE UserID = @idStatus;";
                msCommand.Parameters.Clear();
                msCommand.Parameters.AddWithValue("@RoleID", RoleID);
                msCommand.Parameters.AddWithValue("@idStatus", idStatus);

                return msCommand.ExecuteNonQuery() > 0;
            }
            catch (DbException dbEx)
            {
                MessageBox.Show($"Database error: {dbEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                if (msCommand.Connection.State == ConnectionState.Open)
                {
                    msCommand.Connection.Close();
                }
            }
        }
    }

}
