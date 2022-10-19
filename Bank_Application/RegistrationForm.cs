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

namespace Bank_Application
{
    public partial class RegistrationForm : Form
    {
        
        DataBase dataBase = new DataBase();
        DataTable table;
        SqlCommand command;
        SqlDataAdapter adapter;
        
        public RegistrationForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;
            tbPasswordReg.UseSystemPasswordChar = true;
            pbRegShow.Visible = true;
            pbRegHide.Visible = false;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if(tbLoginReg.Text !="" && tbPasswordReg.Text != "")
            {
                try
                {
                    Autorisation.Login = tbLoginReg.Text;
                    Autorisation.Pasword = tbPasswordReg.Text;
                    string query = $"INSERT INTO Registration(User_Login, User_Password) VALUES (@parm1,@parm2)";
                    dataBase.OpenConnection();
                    command = new SqlCommand(query, dataBase.Connection);
                    command.Parameters.Add("@parm1", SqlDbType.NVarChar).Value = tbLoginReg.Text;
                    command.Parameters.Add("@parm2", SqlDbType.NVarChar).Value = tbLoginReg.Text;
                    command.ExecuteNonQuery();
                    dataBase.CloseConnection();
                    FindId();
                    
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    dataBase.CloseConnection();
                    
                }
            }
            else
            {
                MessageBox.Show("Вы не ввели логин или пароль");
            }
        }
        private void FindId()
        {
             
            adapter = new SqlDataAdapter();
            table = new DataTable();
            string query = $"SELECT * FROM Registration WHERE User_Login = '{tbLoginReg.Text}' and User_Password = '{tbPasswordReg.Text}'  ";
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
                table.Rows.Add(row);
            }
         
            Client.RegistarionId = Convert.ToInt32(row[0].ToString());
            reader.Close();
            dataBase.CloseConnection();
            RegistrationClient();
        }
        public void RegistrationClient()
        {
            this.Hide();
            ClientInfo info = new ClientInfo();
            info.ShowDialog();
        }

        private void pbRegShow_Click(object sender, EventArgs e)
        {
            tbPasswordReg.UseSystemPasswordChar = false;
            pbRegShow.Visible = false;
            pbRegHide.Visible = true;
        }

        private void pbRegHide_Click(object sender, EventArgs e)
        {
            tbPasswordReg.UseSystemPasswordChar = true;
            pbRegShow.Visible = true;
            pbRegHide.Visible = false;
        }
    }
}
