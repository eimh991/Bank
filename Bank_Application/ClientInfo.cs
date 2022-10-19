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
    public partial class ClientInfo : Form
    {
        DataBase dataBase = new DataBase();
        SqlCommand command;
        public ClientInfo()
        {
            
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbName.Text != "" && tbSurname.Text != "")
            {
                try
                {
                    string query = $"INSERT INTO Client(Name,Surname,Registration_Id) VALUES(@parm1,@parm2,@parm3)";
                    dataBase.OpenConnection();
                    command = new SqlCommand(query, dataBase.Connection);
                    command.Parameters.Add("@parm1", SqlDbType.NVarChar).Value = tbName.Text;
                    command.Parameters.Add("@parm2", SqlDbType.NVarChar).Value = tbSurname.Text;
                    command.Parameters.Add("@parm3", SqlDbType.Int).Value = Client.RegistarionId;
                    command.ExecuteNonQuery();
                    MessageBox.Show("Вы успешно зарегистрировались");
                    this.Hide();
                    AutorisationForm autorisation = new AutorisationForm();
                    
                    autorisation.ShowDialog();

                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
