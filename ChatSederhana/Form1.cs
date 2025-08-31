using System.ComponentModel;
using System.Net;
using System.Net.Sockets;

namespace ChatSederhana
{
    public partial class Form1 : Form
    {
        private TcpClient client;
        private TcpListener listener;
        public StreamReader STR;
        public StreamWriter STW;
        public string recieve;
        public string TextToSend;

        public Form1()
        {
            InitializeComponent();

            // Otomatis ambil IP lokal
            IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress address in localIP)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork) 
                {
                    SeverIPtextBox.Text = address.ToString();
                }
            }
        }

        // Bagian Server
        private async void Startbutton_Click(object sender, EventArgs e)
        {
            try
            {
                listener = new TcpListener(IPAddress.Any, int.Parse(ServerPorttextBox.Text));
                listener.Start();

                ChatScreentextBox.AppendText("Server started... waiting for client" + Environment.NewLine);

                client = await listener.AcceptTcpClientAsync(); 
                ChatScreentextBox.AppendText("Client connected!" + Environment.NewLine);

                STR = new StreamReader(client.GetStream());
                STW = new StreamWriter(client.GetStream());
                STW.AutoFlush = true;

                backgroundWorker1.RunWorkerAsync(); // terima pesan
                backgroundWorker2.WorkerSupportsCancellation = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error start server: " + ex.Message);
            }
        }

        // Bagian Client
        private void Connectbutton_Click(object sender, EventArgs e)
        {
            try
            {
                client = new TcpClient();
                IPEndPoint IpEnd = new IPEndPoint(IPAddress.Parse(ClientIPtextBox.Text), int.Parse(ClientPorttextBox.Text));
                client.Connect(IpEnd); // WAJIB pake banget connect ke server

                ChatScreentextBox.AppendText("Connected to Server" + Environment.NewLine);

                STW = new StreamWriter(client.GetStream());
                STR = new StreamReader(client.GetStream());
                STW.AutoFlush = true;

                backgroundWorker1.RunWorkerAsync(); // mulai baca
                backgroundWorker2.WorkerSupportsCancellation = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connect: " + ex.Message);
            }
        }

        // Menerima Pesan
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (client != null && client.Connected)
            {
                try
                {
                    recieve = STR.ReadLine();
                    if (!string.IsNullOrWhiteSpace(recieve))
                    {
                        this.ChatScreentextBox.Invoke(new MethodInvoker(delegate ()
                        {
                            string time = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
                            ChatScreentextBox.AppendText($"Friend [{time}] : {recieve}" + Environment.NewLine);
                        }));
                    }
                }
                catch { break; }
            }
        }

        // Kirim Pesan
        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            if (client != null && client.Connected && !string.IsNullOrWhiteSpace(TextToSend)) 
            {
                STW.WriteLine(TextToSend);
                this.ChatScreentextBox.Invoke(new MethodInvoker(delegate ()
                {
                    string time = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
                    ChatScreentextBox.AppendText($"Me [{time}] : {TextToSend}" + Environment.NewLine);
                }));
            }
            else
            {
                MessageBox.Show("Sending Failed");
            }
            backgroundWorker2.CancelAsync();
        }

        private void Sendbutton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(MessagetextBox.Text)) 
            {
                TextToSend = MessagetextBox.Text;
                backgroundWorker2.RunWorkerAsync();
            }
            MessagetextBox.Text = "";
        }
    }
}
