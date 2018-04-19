using System;
using System.Timers;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading;
using System.Net.NetworkInformation;

namespace ReadDeviceLogFile
{
    public partial class Form1 : Form
    {
        ListView.CheckedListViewItemCollection checkedItems;

        System.Timers.Timer timer = new System.Timers.Timer();

        private Thread demoThread = null;
        delegate void ReadFileVoidDelegate();

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_connect_Click(object sender, EventArgs e)
        {           

            if (!String.IsNullOrEmpty((txtbox_filename.Text))){
                string directoryPath = "C:\\Users\\Admin\\DevicesLogFiles";
                string[] devicesLogFiles = Directory.GetFiles(directoryPath);
                foreach (string deviceLogFile in devicesLogFiles)
                {
                    string fileName = Path.GetFileNameWithoutExtension(deviceLogFile);
                    if (fileName.StartsWith(txtbox_filename.Text)){
                        var listViewItem = new ListViewItem(fileName);
                        listView1.Items.Add(listViewItem);
                    }
                }
            }
        }

        private void checkbox_selectall_CheckedChanged(object sender, EventArgs e)
        {
            for(int i = 0; i < listView1.Items.Count; i++)
            {
                listView1.Items[i].Checked = true;
            }
        }

        private void checkBox_unselectall_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                listView1.Items[i].Checked = false;
            }
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtbox_foldername.Text))
            {
                MessageBox.Show("Please choose a folder !", "Thông báo lỗi");
            }
            else
            {
                checkedItems = listView1.CheckedItems;

                if (checkedItems.Count == 0)
                {
                    MessageBox.Show("Please choose file !", "Thông báo lỗi");
                }
                else
                {
                    //System.Timers.Timer timer = new System.Timers.Timer();
                    timer.Interval = 5000;
                    timer.Elapsed += OnTimedEvent;
                    timer.AutoReset = true;

                    if (btn_start.Text == "Start")
                    {
                        btn_start.Text = "Stop";

                        timer.Start();
                    }
                    else
                    {
                        btn_start.Text = "Start";

                        timer.Stop();
                    }
                }
            }          
        }

        //Thread
        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        { 

            demoThread = new Thread(new ThreadStart(ThreadProcSafe));

            demoThread.Start();
        }

        private void ThreadProcSafe()
        {
            ReadData();
        }

        private void ReadData()
        {
            if (listView1.InvokeRequired)
            {
                ReadFileVoidDelegate d = new ReadFileVoidDelegate(ReadData);
                Invoke(d, new object[] {});
            }
            else
            {
                checkedItems = listView1.CheckedItems;
              
                foreach (ListViewItem item in checkedItems)
                {
                    //string deviceLogFilePath = "C:\\Users\\Admin\\DevicesLogFiles\\" + item.Text + ".txt";
                    
                    string deviceLogFilePath = "C:\\Users\\Admin\\DevicesLogFiles\\" + item.Text + ".txt";

                    string lastLine = ReadLastLine(deviceLogFilePath, Encoding.ASCII, "\n");

                    SendData(lastLine);                    
                }
            }
        }

        private string ReadLastLine(string path, Encoding encoding, string character)
        {
            int flag = 1;
            int charsize = encoding.GetByteCount("\n");
            byte[] buffer = encoding.GetBytes(character);
            using(FileStream fileStream = new FileStream(path, FileMode.Open))
            {
                long endposition = fileStream.Length / charsize;
                for(long pos = charsize; pos < endposition; pos += charsize)
                {
                    fileStream.Seek(-pos, SeekOrigin.End);
                    fileStream.Read(buffer, 0, buffer.Length);

                    //vì log file có dòng cuối cùng là dòng trống nên phải gặp kí tự xuống 
                    //dòng thứ 2 từ dưới lên mới là dònng cuối cùng có thông tin
                    if (encoding.GetString(buffer) == character)
                    {
                        if(flag == 1)
                        {
                            pos += charsize;
                            flag = 2;
                        }
                        else
                        {
                            buffer = new byte[fileStream.Length - fileStream.Position];
                            fileStream.Read(buffer, 0, buffer.Length);
                            return encoding.GetString(buffer);
                        }
                    }
                }
            }
            return null;
        }

        private void SendData(string postData)
        {
            //send data
            string Url = txtbox_servername.Text + "/Service1.svc/GetData";
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] data = encoding.GetBytes(postData);
            // declare httpwebrequet wrt url defined above
            WebRequest request = WebRequest.Create(Url);
            // set method as post
            request.Method = "POST";
            // set content type
            request.ContentType = "application/x-www-form-urlencoded";
            // set content length
            request.ContentLength = data.Length;
            // get stream data out of webrequest object
            Stream newStream = request.GetRequestStream();
            newStream.Write(data, 0, data.Length);
            newStream.Close();
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            response.Close();

        }

        private void btn_stop_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_openfolder_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtbox_foldername.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void btn_testconnection_Click(object sender, EventArgs e)
        {
            Uri url = new Uri(txtbox_servername.Text);
            string host = string.Format("{0}", url.Host);

            Ping ping = new Ping();
            PingReply pingReply = ping.Send(host);
            if(pingReply.Status == IPStatus.Success)
            {
                MessageBox.Show("Connect to server successfull !", "Test connection");
            }
            else
            {
                MessageBox.Show("Connect to server failed !", "Test connection");
            }
        }
    }
}
