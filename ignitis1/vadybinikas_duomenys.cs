using System;
using System.Data;
using System.Data.Common;
using System.Windows.Forms;
using System.Windows.Input;

namespace ignitis1
{
    internal class vadybinikas_duomenys : dbconnector
    {
        static public DataTable dtstatus = new DataTable();

        static public void getstatus()
        {
            try
            {
                if (msCommand.Connection.State == ConnectionState.Open)
                {
                    msCommand.Connection.Close();
                }

                msCommand.CommandText = "SELECT * FROM bendrija";
                dtstatus.Clear();
                msDataAdapter.SelectCommand = msCommand;
                msDataAdapter.Fill(dtstatus);
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

        static public bool EditPrice(int idStatus, double nameStatus)
        {
            try
            {
                if (msCommand.Connection.State != ConnectionState.Open)
                {
                    msCommand.Connection.Open();
                }

                msCommand.CommandText = "UPDATE bendrija SET elektra = @nameStatus WHERE bendrijos_id = @idStatus;";
                msCommand.Parameters.Clear();
                msCommand.Parameters.AddWithValue("@nameStatus", nameStatus);
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
        static public bool EditPrice2(int idStatus, double nameStatus)
        {
            try
            {
                if (msCommand.Connection.State != ConnectionState.Open)
                {
                    msCommand.Connection.Open();
                }

                msCommand.CommandText = "UPDATE bendrija SET vando = @nameStatus WHERE bendrijos_id = @idStatus;";
                msCommand.Parameters.Clear();
                msCommand.Parameters.AddWithValue("@nameStatus", nameStatus);
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
        static public bool EditPrice3(int idStatus, double nameStatus)
        {
            try
            {
                if (msCommand.Connection.State != ConnectionState.Open)
                {
                    msCommand.Connection.Open();
                }

                msCommand.CommandText = "UPDATE bendrija SET mokesciai = @nameStatus WHERE bendrijos_id = @idStatus;";
                msCommand.Parameters.Clear();
                msCommand.Parameters.AddWithValue("@nameStatus", nameStatus);
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
        static public void Delete_bendrija(string del)
        {
            try
            {
                if (msCommand.Connection.State != ConnectionState.Open)
                {
                    msCommand.Connection.Open();
                }

                msCommand.CommandText = "DELETE FROM bendrija WHERE bendrijos_id = @del";
                msCommand.Parameters.Clear();
                msCommand.Parameters.AddWithValue("@del", del);
                msCommand.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Error in deleting status"+del, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
