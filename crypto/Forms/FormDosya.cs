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

namespace crypto.Forms
{
    public partial class FormDosya : Form
    {
        private TcpClient client;
        public StreamReader STR;
        public StreamWriter STW;
        public string selected_algorithm;

        public FormDosya()
        {
            InitializeComponent();

            //get my ip address
            IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress address in localIP)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    tb_server_ip.Text = address.ToString();
                    tb_client_ip.Text = address.ToString();
                }
            }
        }

        private void sendFile(string fn)
        {
            IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
            IPEndPoint iPEnd = new IPEndPoint(ipAddress, 30);
            Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            string fileName = fn; // "c:\\filetosend.txt";
            byte[] fileNameByte = Encoding.ASCII.GetBytes(fileName);
            byte[] fileNameLen = BitConverter.GetBytes(fileNameByte.Length);
            byte[] fileData = File.ReadAllBytes(fileName);
            byte[] clinetData = new byte[4 + fileName.Length + fileData.Length];

            fileNameLen.CopyTo(clinetData, 0);
            fileNameByte.CopyTo(clinetData, 4);
            fileData.CopyTo(clinetData, 4 + fileNameByte.Length);
            clientSocket.Connect(iPEnd);
            clientSocket.Send(clinetData);
            clientSocket.Close();

        }
        private void textBox1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files != null && files.Length != 0)
            {
                MessageBox.Show(files[0]);
                sendFile(files[0]);
            }
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (cb_alogo_dosya.CheckedItems.Count == 0)
            {
                MessageBox.Show("Lütfen Algoritmayı seçiniz.", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                selected_algorithm = cb_alogo_dosya.Text;

                try
                {
                    TcpListener listener = new TcpListener(IPAddress.Any, 20);
                    listener.Start();
                    client = listener.AcceptTcpClient();
                    STR = new StreamReader(client.GetStream());
                    STW = new StreamWriter(client.GetStream());
                    STW.AutoFlush = true;

                    backgroundWorker1.RunWorkerAsync();
                    backgroundWorker2.WorkerSupportsCancellation = true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }

            }
        }
        private void btn_connect_Click(object sender, EventArgs e)
        {
            if (cb_alogo_dosya2.CheckedItems.Count == 0)
            {
                MessageBox.Show("Lütfen Algoritmayı seçiniz.", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                selected_algorithm = cb_alogo_dosya2.Text;

                try
                {
                    client = new TcpClient();
                    IPEndPoint IpEnd = new IPEndPoint(IPAddress.Parse(tb_client_ip.Text), 20);

                    client.Connect(IpEnd);
                    if (client.Connected)
                    {
                        
                        STR = new StreamReader(client.GetStream());
                        STW = new StreamWriter(client.GetStream());
                        STW.AutoFlush = true;
                        backgroundWorker1.RunWorkerAsync();
                        backgroundWorker2.WorkerSupportsCancellation = true;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            if (client.Connected)
            {
                //if (selected_algorithm == "SHA-256")
                //{
                //    STW.WriteLine(Sifreleme_Algoritmalari.Encrypt(passKey, TextToSend)); // SHA256 ile sifreleme islemi..
                //}
                //else
                //{
                //    //TODO: SPN-16 sifreleme islemi...
                //}

               

            }
            else
            {
                MessageBox.Show("Gönderim Başarsız!");
            }

            backgroundWorker2.CancelAsync();
        }


        private void cb_alogo_dosya_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cb_alogo_dosya.SelectedIndex;
            int count = cb_alogo_dosya.Items.Count;
            for (int x = 0; x < count; x++)
            {
                if (index != x)
                {
                    cb_alogo_dosya.SetItemChecked(x, false);
                }
            }
        }
        private void cb_alogo_dosya2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cb_alogo_dosya2.SelectedIndex;
            int count = cb_alogo_dosya2.Items.Count;
            for (int x = 0; x < count; x++)
            {
                if (index != x)
                {
                    cb_alogo_dosya2.SetItemChecked(x, false);
                }
            }
        }
        //load theme here!..
        private void FormDosya_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
        }

    }
}
