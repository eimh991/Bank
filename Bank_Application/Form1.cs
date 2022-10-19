using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Application
{
    public partial class Form1 : Form
    {

        int port = 10000;
        IPEndPoint endPoint;
        string request;
        TcpClient client;
        AutorisationForm autoform = new AutorisationForm();

        public Form1()
        {
            autoform.ShowDialog();
            if (Client.Name != null && Client.Surname !=null)
            {
                InitializeComponent();
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
                lb1.Text = "Добро пожаловать " + Client.Name + " " + Client.Surname;

            }
            else
                this.Close();

        }

        private void btBalance_Click(object sender, EventArgs e)
        {
            string show = "Show" + ";" + Client.Id.ToString();
            requestToTheServer(show);
        }
        private void btCompleteness_Click(object sender, EventArgs e)
        {
            if (tbCompleteness.Text != "")
            {
                string mes = "BalanceAdd" + ";" + Client.Id.ToString() + ";" + tbCompleteness.Text;
                requestToTheServer(mes);
                tbCompleteness.Clear();
            }

        }

        private void btTransfer_Click(object sender, EventArgs e)
        {
            if (tbSum.Text != "" && tbId.Text != "")
            {
                string transfer = "Transfer" + ";" + Client.Id.ToString() + ";" + tbSum.Text + ";" + tbId.Text;
                requestToTheServer(transfer);
                tbBalance.Clear();
                tbId.Clear();
            }
        }

        public void requestToTheServer(string message)
        {
            string[] mes = message.Split(';');
            try
            {  
                endPoint = new IPEndPoint(IPAddress.Parse("192.168.1.103"), port);

                client = new TcpClient();

                client.Connect(endPoint);

                NetworkStream stream = client.GetStream();

                //byte[] data = Encoding.Unicode.GetBytes(message);

                //stream.Write(data, 0, data.Length);
                BinaryWriter writer = new BinaryWriter(stream);
                writer.Write(message);
                writer.Flush();

                BinaryReader reader = new BinaryReader(stream);
                if (mes[0] == "Show")
                {
                    tbBalance.Text = reader.ReadString();
                }else if(mes[0] == "BalanceAdd")
                {
                    rbResCompleteness.Text = reader.ReadString();
                }
                else if (mes[0] == "Transfer")
                {
                    tbResult.Text = reader.ReadString();
                }

                client.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
               
            }
            finally
            {
                if(client != null)
                {
                    client.Close();
                }
            }
        }

        
    }
}
