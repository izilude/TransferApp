using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace LibsDataTransferTestApp
{
    public partial class Form1 : Form
    {
        public TcpClient _client;
        public Stream _stream;

        public Form1()
        {
            InitializeComponent();

            _client = new TcpClient("169.254.1.1", 3602);
            _stream = _client.GetStream();
        }

        protected void FtpDownloadFile(string fileNameOnInstrument, string filePathOnComputer)
        {
            FtpWebRequest request = GetFtpConnection(fileNameOnInstrument); request.Method = WebRequestMethods.Ftp.DownloadFile; FtpWebResponse response = (FtpWebResponse)request.GetResponse();

            Stream responseStream = response.GetResponseStream(); if (responseStream != null)
            {
                StreamReader reader = new StreamReader(responseStream); StreamWriter writer = new StreamWriter(filePathOnComputer); writer.Write(reader.ReadToEnd());

                writer.Close(); reader.Close();
            }
            response.Close();
        }

        FtpWebRequest GetFtpConnection(string fileNameOnInstrument)
        {
            string connectionString = string.Format("ftp://169.254.1.1/{0}", fileNameOnInstrument);

            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(connectionString); request.UsePassive = true; request.Credentials = new NetworkCredential("ftpuser", "T$I2FTP"); request.Timeout = 30000; return request;
        }

        public int count = 0;

        private void requestMeasurementButton_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(OutputDirectoryTextbox.Text))
            {
                MessageBox.Show("Directory " + OutputDirectoryTextbox.Text + " Doesn't Exist!");
                return;
            }

            var watch = new Stopwatch();
            watch.Start();

            SendCommand("doclear\r\n");

            SendCommand("dotrig 3 gui tsi\r\n");
            Thread.Sleep(4000);

            SendCommand("dofileexport measurement ftp measurement.xml\r\n");

            count++;
            var path = Path.Combine(OutputDirectoryTextbox.Text, "Measurement" + count.ToString("000") + ".xml");
            FtpDownloadFile("Measurement.xml", path);
            watch.Stop();

            TransferTimeLabel.Text = watch.ElapsedMilliseconds.ToString();
        }

        private void SendCommand(string commandString)
        {
            byte[] buffer = Encoding.ASCII.GetBytes(commandString);
            _stream.Write(buffer,0,buffer.Length);

            while (true)
            {
                var outputByte = _stream.ReadByte();
                if (outputByte == 13) break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = folderBrowserDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                OutputDirectoryTextbox.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
