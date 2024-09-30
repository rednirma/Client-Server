using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;



namespace Client_Server_tcpip
{
    public partial class client : Form
    {
        private TcpClient Client;
        public StreamReader STR;
        public StreamWriter STW;
        public string Recieve;
        public string TextToSend;
        public client()
        {
            InitializeComponent();
            
        }

        private void client_Load(object sender, EventArgs e)
        {
            groupBox2.Show();
        }

        private void StartServerBtn_Click(object sender, EventArgs e)
        {
        }

        private void ClientConnectBtn_Click(object sender, EventArgs e)
        {
            if (ClientPortBox.Text != "" && ClientIPBox.Text != "")
            {
                Client = new TcpClient();
                IPEndPoint IpEnd = new IPEndPoint(IPAddress.Parse(ClientIPBox.Text), int.Parse(ClientPortBox.Text));
                Client.Connect(IpEnd);

                try
                {
                    ChatMsgListBox.AppendText("connect to the server" + "\r\n");
                    STW = new StreamWriter(Client.GetStream());
                    STR = new StreamReader(Client.GetStream());
                    STW.AutoFlush = true;
                    backgroundWorker1.RunWorkerAsync();
                    backgroundWorker2.WorkerSupportsCancellation = true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
            else if (ClientIPBox.Text == "" && ClientPortBox.Text == "")
            {
                MessageBox.Show("Please enter the server details!");
            }
            else
            {
                if (ClientPortBox.Text == "")
                {
                    MessageBox.Show("Please enter a correct port!");
                }
                else if (ClientIPBox.Text == "")
                {
                    MessageBox.Show("Please enter a correct IP!");
                }
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (Client.Connected) 
            {
                try
                {
                    Recieve = STR.ReadLine();
                    this.ChatMsgListBox.Invoke(new MethodInvoker(delegate ()
                    {
                        ChatMsgListBox.AppendText("Server " + Recieve + "\r\n");
                    }));
                    Recieve = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            if (Client.Connected)
            {
                STW.WriteLine(TextToSend);
                this.ChatMsgListBox.Invoke(new MethodInvoker(delegate ()
                {
                    ChatMsgListBox.AppendText("Client: " + TextToSend + "\r\n");
                }));
            }
            else 
            {
                MessageBox.Show("sending failed");
            }
            backgroundWorker2.CancelAsync();

        }

        private void SendMsgBtn_Click(object sender, EventArgs e)
        {
            if (MessageTextBox.Text != "") 
            { 
                TextToSend = MessageTextBox.Text;
                backgroundWorker2.RunWorkerAsync();
            }
            MessageTextBox.Text = "";
        }
    }
}
