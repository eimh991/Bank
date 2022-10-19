using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Bank_Application
{
    public partial class AutorisationForm : Form
    {
        
        DataBase dataBase = new DataBase();
        DataTable table;
        SqlCommand command;
        SqlDataAdapter adapter;
        public AutorisationForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;
            tbPassword.UseSystemPasswordChar = true;
            pbShow.Visible = true;
            pbHide.Visible = false;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (tbPassword.Text != "" && tbLogin.Text != "")
            {
                try
                {
                    
                    adapter = new SqlDataAdapter();
                    table = new DataTable();
                    string query = $"SELECT * FROM Registration WHERE User_Login = '{tbLogin.Text}' and User_Password = '{tbPassword.Text}'  ";
                    dataBase.OpenConnection();
                    command = new SqlCommand(query, dataBase.Connection);
                    adapter.SelectCommand = command;
                    adapter.Fill(table);
                    if (table.Rows.Count == 1)
                    {
                        //MessageBox.Show("Вы вошли успешно ");
                        ChoseRegistrarionClienId();
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Вы ввели не правильный логин или пароль");
                        tbLogin.Text = "";
                        tbPassword.Text = "";
                    }

                    dataBase.CloseConnection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    dataBase.CloseConnection();
                }
            }else
            {
                MessageBox.Show("Вы не ввели логин либо пароль");
            }

        }


        private void pbHide_Click(object sender, EventArgs e)
        {
            tbPassword.UseSystemPasswordChar = true;
            pbShow.Visible = true;
            pbHide.Visible = false;
            
        }
        public int ChoseRegistrarionClienId()
        {
            DataRow row = table.NewRow();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {

                for (int i = 0; i < reader.FieldCount; i++)
                {
                    row[i] = reader[i];
                }
                table.Rows.Add(row);
            }
            reader.Close();
            CreateClient(Convert.ToInt32(row[0]));
            return Convert.ToInt32(row[0]);
        }

        public void CreateClient(int id)
        {
            string query = $"SELECT * FROM Client WHERE  Registration_Id = {id}";
            dataBase.OpenConnection();
            command = new SqlCommand(query, dataBase.Connection);
            adapter.SelectCommand = command;
            adapter.Fill(table);
            DataRow row = table.NewRow();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    row[i] = reader[i];
                }
                Client.Id = Convert.ToInt32(row[0]);
                Client.Name= row[1].ToString();
                Client.Surname= row[2].ToString();
                Client.Balance= float.Parse(row[3].ToString());
                Client.RegistarionId = Convert.ToInt32(row[4]);
                //MessageBox.Show(Client.Id + " " + Client.Name + " " + Client.Surname + " " +  Client.Balance + " "+ Client.RegistarionId);
            }
            table.Rows.Add(row);
           


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.ShowDialog();
        }

        private void pbShow_Click(object sender, EventArgs e)
        {
            tbPassword.UseSystemPasswordChar = false;
            pbHide.Visible = true;
            pbShow.Visible = false;

        }
    }
}
