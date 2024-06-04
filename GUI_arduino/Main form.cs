using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;

namespace GUI_arduino
{
    public partial class Form1 : Form
    {
        //Variabel yang digunakan
        private Color defaultColor;
        private string barcodeData, jdgData, latestReceivedData = "", result;
        private string connectionString = "Data Source=DESKTOP-66EIFJP\\SQLEXPRESS;Initial Catalog=LSBU_Packing;Integrated Security=True;TrustServerCertificate=True";
        private bool isKeyboardEnabled = true;
        private ToolTip toolTip;

        private int check = 0;

        public Form1()
        {
            //SETUP
            InitializeComponent();
            toolTip = new ToolTip();

            //Mengatur trigger key untuk scanner
            this.KeyPreview = true;
            this.Focus();
        }

        // Definisi kelas Model
        public class Model
        {
            public string Date { get; set; }
            public string ModelNumber { get; set; }
            public string SerialNumber { get; set; }
            public string Result { get; set; }
        }

        //array data
        private string[] model = {
            "NA-W145FCV1 (V)", "NA-W125FCV1 (V)", "NA-W98FCV1 (V)", "NA-W88BCV1 (V)", "NA-W78BCV1 (V)",
            "NA-W100BBZ2 (H)", "NA-W96BBZ2 (H)", "NA-W86BBZ2(H)", "NA-W76BBZ2(H)", "NA-W96BBZ2 (D)",
            "NA-W86BBZ2 (D)", "NA-W76BBZ2 (D)", "NA-W100G1 (ARC)", "NA-W100G1 (ART)", "NA-W100G1(ARG)",
            "NA-W90B1 (GRG)", "NA-W120G1 (VRT)", "NA-W50B1 (W)", "NA-W1000B (WSA)", "NA-W800B (H)",
            "NA-W120G1 (H)", "NA-W120G1 (HTW)"};

        //8887549777585

        private string[] posNumber = {
            "9780201379624","8887549777608", "8887549777622", "8887549777646", "8887549777660",
            "8887549736711", "8887549720987", "8887549720970", "8887549720963", "8887549829253",
            "8887549829260", "8887549829277", "8887549664939", "8887549664953", "8887549664946",
            "8887549664960", "8887549779909", "4549980490655", "8887549788413", "8887549788420",
            "8887549762475", "4713170842931", };

        private void Form1_Load(object sender, EventArgs e)
        {
            toolTip.SetToolTip(label5, "Copyright © 2024 PENS & UNSURYA");
            string[] ports = SerialPort.GetPortNames();
            portBox.Items.AddRange(ports);

            // Menambahkan seluruh elemen array ke dalam ComboBox
            setModelBox.Items.AddRange(model);

            // Menambahkan event handler untuk SelectedIndexChanged
            setModelBox.SelectedIndexChanged += setModelBox_SelectedIndexChanged;
        }

        private void setModelBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int slcIndex = setModelBox.SelectedIndex;

            // Menggunakan indeks untuk mengakses nilai dalam array lain
            if (slcIndex >= 0 && slcIndex < model.Length)
            {
                barcodeData = posNumber[slcIndex];
                selectedId.Text = barcodeData;
                scanBox.Focus();
            }
        }

        // Pembanding scan dengan barcode data
        private void judgement()
        {
            if (jdgData == barcodeData)
            {
                serialPort1.Write("OK"); //Mengirim data ke serial
                jdgLabel.Visible = true;
                jdgLabel.Text = "OK";
                result = "OK";
                BeginInvoke(new Action(() => OKpanel_ChangeColor(Color.Green)));
                CreateModel();
            }
            else if (jdgData != barcodeData)
            {
                serialPort1.Write("NG");//Mengirim data ke serial
                jdgLabel.Visible = true;
                jdgLabel.Text = "NG";
                result = "NG";
                BeginInvoke(new Action(() => NGpanel_ChangeColor(Color.Red)));
                CreateModel();
            }
        }

        public void CreateModel()
        {
            DateTime currentDate = DateTime.Now; // Tanggal dan waktu saat tombol ditekan
            string formattedDate = currentDate.ToString("yyyy-MM-dd HH:mm:ss"); // Format tanggal dan waktu

            var model = new Model
            {
                Date = formattedDate,
                ModelNumber = setModelBox.Text,
                SerialNumber = jdgData,
                Result = result
            };

            AddData(model);

        }

        public void AddData(dynamic model)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;

                command.CommandText = "INSERT INTO Packing_Results (date, model_number, serial_number, result) values (@Date, @ModelNumber, @SerialNumber, @Result)";
                command.Parameters.Add("@Date", SqlDbType.DateTime).Value = model.Date;
                command.Parameters.Add("@ModelNumber", SqlDbType.VarChar).Value = model.ModelNumber;
                command.Parameters.Add("@SerialNumber", SqlDbType.VarChar).Value = model.SerialNumber;
                command.Parameters.Add("@Result", SqlDbType.VarChar).Value = model.Result;
                command.ExecuteNonQuery();
            }
        }

        //Mengubah nilai enumerasi Keys ke representasi string yang sesuai.
        public KeysConverter keysConverter = new KeysConverter();

        private void selectButton_Click(object sender, EventArgs e)
        {
            //open serialport
            try
            {
                serialPort1.PortName = portBox.Text;
                serialPort1.BaudRate = serialPort1.BaudRate;
                serialPort1.Parity = serialPort1.Parity;
                serialPort1.DataBits = serialPort1.DataBits;
                serialPort1.StopBits = serialPort1.StopBits;
                serialPort1.Open();
                MessageBox.Show("Connected to serial port");
                scanBox.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening serial port: " + ex.Message);
            };
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                MessageBox.Show("Disconnected from serial port");
                portBox.Text = "";
            }
        }

        //Handle scanning data 
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (isKeyboardEnabled)
            {
                // Periksa apakah tombol yang ditekan adalah tombol Enter (dengan asumsi pemindai barcode mengirimkan tombol Enter setelah pemindaian)
                if (e.KeyCode == Keys.Enter)
                {
                    e.SuppressKeyPress = true; // Suppress further key presses
                    BeginInvoke(new Action(() =>
                    {
                        string latestReceivedData = scanBox.Text;
                        isKeyboardEnabled = false;
                        jdgData = latestReceivedData.Trim(); //Menghapus /r atau /n (whitespace) dari variabel
                        latestReceivedData = ""; // Clear latestReceivedData after processing
                        judgement();
                    }));
                }
                else
                {
                    // Akumulasi karakter hingga tombol Enter ditekan
                    string character = keysConverter.ConvertToString(e.KeyCode);
                    latestReceivedData += character;
                }
            }
            else
            {
                e.SuppressKeyPress = true; // Input keyboard ditolak
            }
        }

        //Mengganti warna background form jika [NG]
        private void OKpanel_ChangeColor(Color newColor)
        {
            BeginInvoke(new Action(() =>
            {
                if (defaultColor == Color.Empty)
                {
                    defaultColor = panel1.BackColor;
                }

                // Mengubah warna background form 
                panel1.BackColor = newColor;

                // Mengatur timer untuk mengembalikan warna kembali ke default setelah waktu tertentu
                Timer revertTimer = new Timer();
                revertTimer.Interval = 1500; // delay 1.5 detik
                revertTimer.Start(); // Timer menyal
                revertTimer.Tick += (sender, e) =>
                {
                    panel1.BackColor = defaultColor; // Mengembalikan ke warna default
                    scanBox.Clear();
                    jdgLabel.Text = "";
                    revertTimer.Stop(); // Timer mati
                    isKeyboardEnabled = true; //Mengembalikan ke loop scan agar bisa menerima input keyboard kembali
                };
            }));
        }

        //Mengganti warna background form jika [NG]
        private void NGpanel_ChangeColor(Color newColor)
        {
            BeginInvoke(new Action(() =>
            {
                if (defaultColor == Color.Empty)
                {
                    defaultColor = panel1.BackColor;
                }

                // Mengubah warna background form 
                panel1.BackColor = newColor;

                // Mengatur timer untuk mengembalikan warna kembali ke default setelah waktu tertentu
                Timer revertTimer = new Timer();
                revertTimer.Interval = 3500; // delay 6 detik
                revertTimer.Start(); // Timer menyala
                revertTimer.Tick += (sender, e) =>
                {
                    panel1.BackColor = defaultColor; // Mengembalikan ke warna default
                    scanBox.Clear();
                    jdgLabel.Text = "";
                    revertTimer.Stop(); // Timer mati
                    isKeyboardEnabled = true; //Mengembalikan ke loop scan agar bisa menerima input keyboard kembali
                };
            }));
        }
    }
}
