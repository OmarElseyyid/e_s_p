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

namespace crypto.Forms
{
    public partial class FormMsg : Form
    {

        private TcpClient client;
        public StreamReader STR;
        public StreamWriter STW;
        public string reciever;
        public string TextToSend;
        public string passKey = "sdgoiosd";
        public string selected_algorithm;

        public FormMsg()
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
            tbKey.Text = passKey;
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            if (tb_msg.Text != "")
            {
                TextToSend = tb_msg.Text;
                backgroundWorker2.RunWorkerAsync();
            }
            tb_msg.Text = "";
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (cb_alogo_msg.CheckedItems.Count == 0)
            {
                MessageBox.Show("Lütfen Algoritmayı seçiniz.", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                selected_algorithm = cb_alogo_msg.Text;

                try
                {
                    TcpListener listener = new TcpListener(IPAddress.Any, 10);
                    listener.Start();
                    client = listener.AcceptTcpClient();
                    tb_chat.AppendText("Server Başlatıldı." + " Kullanılan Şifreleme Algoritması: " + selected_algorithm +  "\r\n");
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
            if (cb_alogo_msg2.CheckedItems.Count == 0)
            {
                MessageBox.Show("Lütfen Algoritmayı seçiniz.", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                selected_algorithm = cb_alogo_msg2.Text;

                try
                {
                    client = new TcpClient();
                    IPEndPoint IpEnd = new IPEndPoint(IPAddress.Parse(tb_client_ip.Text), 10);

                    client.Connect(IpEnd);
                    if (client.Connected)
                    {
                        tb_chat.AppendText("Servere Bağlandi. "+ "Kullanılan Şifreleme Algoritması: "+ selected_algorithm + "\r\n");
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
            while (client.Connected)
            {
                try
                {

                    reciever = STR.ReadLine();

                    if (selected_algorithm == "SHA-256")
                    {
                        reciever = Sifreleme_Algoritmalari.Decrypt(passKey, reciever); // SHA-256 algoritması ile deşifreleme işlemi...
                    }
                    else
                    {
                        reciever = Sifreleme_Algoritmalari.ToSPN16_Decrypt(reciever, passKey); // SPN-16 algoritması ile deşifreleme işlemi...
                    }
                    this.tb_chat.Invoke(new MethodInvoker(delegate ()
                    {
                        tb_chat.AppendText("Arkadaş: " + reciever + "\r\n");
                    }));
                    reciever = "";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            if (client.Connected)
            {
                if (selected_algorithm == "SHA-256")
                {
                    STW.WriteLine(Sifreleme_Algoritmalari.Encrypt(passKey, TextToSend)); // SHA256 ile sifreleme islemi..
                }
                else
                {
                    STW.WriteLine(Sifreleme_Algoritmalari.ToSPN16_Encrypt(TextToSend, passKey)); // SPN16 ile sifreleme islemi..
                }
     
                this.tb_chat.Invoke(new MethodInvoker(delegate ()
                {
                    tb_chat.AppendText("Ben: " + TextToSend + "\r\n");

                }));

            }
            else
            {
                MessageBox.Show("Gönderim Başarsız!");
            }

            backgroundWorker2.CancelAsync();
        }
        private void cb_alogo_msg_SelectedIndexChanged(object sender, EventArgs e)
        {

            int index = cb_alogo_msg.SelectedIndex;
            int count = cb_alogo_msg.Items.Count;
            for (int x = 0; x < count; x++)
            {
                if (index != x)
                {
                    cb_alogo_msg.SetItemChecked(x, false);
                }
            }

        }
        private void cb_alogo_msg2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cb_alogo_msg2.SelectedIndex;
            int count = cb_alogo_msg2.Items.Count;
            for (int x = 0; x < count; x++)
            {
                if (index != x)
                {
                    cb_alogo_msg2.SetItemChecked(x, false);
                }
            }
        }
        
        // theme load 
        private void FormMsg_Load_1(object sender, EventArgs e)
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
