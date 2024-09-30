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
    public partial class server : Form
    {
        private TcpClient Client;
        public StreamReader STR;
        public StreamWriter STW;
        public string Recieve;
        public string TextToSend;

        public server()
        {
            InitializeComponent();
            IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName());

            foreach (IPAddress address in localIP)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    ServerIPBox.Text = address.ToString();
                    ServerPortBtn.Text = "80";
                }
            }
        }

        private void server_Load(object sender, EventArgs e)
        {
        }

        private void StartServerBtn_Click(object sender, EventArgs e)
        {
            if (ServerPortBtn.Text != "")
            {
                TcpListener listener = new TcpListener(IPAddress.Any, int.Parse(ServerPortBtn.Text));
                listener.Start();
                Client = listener.AcceptTcpClient();
                STR = new StreamReader(Client.GetStream());
                STW = new StreamWriter(Client.GetStream());
                STW.AutoFlush = true;
                backgroundWorker1.RunWorkerAsync();
                backgroundWorker2.WorkerSupportsCancellation = true;
            }
            else
            {
                MessageBox.Show("Please enter a correct port number!");
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
                        ChatMsgListBox.AppendText("Client: " + Recieve + "\r\n");
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
                    ChatMsgListBox.AppendText("Server: " + TextToSend + "\r\n");
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
