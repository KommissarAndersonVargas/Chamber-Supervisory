using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Text;
using Modbus.Device;
using System.Net.Sockets;
using System.Windows.Forms.DataVisualization.Charting;
using System.Runtime.CompilerServices;

namespace TemperatureDataLogger
{
    public partial class Form1 : Form
    {
        private TcpClient client;
        private IModbusMaster master;
        private string cache = "x";
        private int tempo = 0;

        public Form1()
        {
            InitializeComponent();
            LoadVisorConfig();
            ConfigurarGraficoSimplesDescalibrado();
        }

        public void ConfigureTimer()
        {

            CommunicationTimmer.Interval = 1000;
            CommunicationTimmer.Tick += Timer_Tick;
            CommunicationTimmer.Start();

        }

        public void ConfigureIpConnection()
        {
            //client = new TcpClient("192.168.1.6", 502); // IP do ESP
            client = new TcpClient();

            client.Connect(ipConnectTextBox.Text, 502);

            master = ModbusIpMaster.CreateIp(client);

        }

        public void LoadVisorConfig()
        {
            RchtSensorDisplay.Font = new Font("OCR A Extended", 36, FontStyle.Bold);
            RchtSensorDisplay.BackColor = Color.Black;
            RchtSensorDisplay.ForeColor = Color.Red;
            RchtSensorDisplay.BorderStyle = BorderStyle.None;
            RchtSensorDisplay.SelectionAlignment = HorizontalAlignment.Center;
            RchtSensorDisplay.Text = "7 °C";
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            try
            {
                if (master == null) return;

                ushort[] dados = master.ReadHoldingRegisters(1, 0, 1);

                string valor = dados[0].ToString();

                this.UpdateSensor(cache, valor);

                cache = valor;
            }
            catch (Exception)
            {
                CommunicationTimmer.Stop();
                MessageBox.Show("Falha na comunicação com o ESP", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateSensor(string cache, string valor)
        {
            if (!cache.Equals(valor))
            {
                // Atualiza visor sensor da câmera 
                RchtSensorDisplay.Text = valor + " °C";
                //Salva no banco de dados 
                if(!string.IsNullOrEmpty(txtbMaxTemp.Text) && !string.IsNullOrEmpty(txtbMinTemp.Text))
                   DataBaseQueries.InsertDatabaseInfo(DateTime.Now, double.Parse(valor), double.Parse(txtbMaxTemp.Text), double.Parse(txtbMinTemp.Text));
                else
                    DataBaseQueries.InsertDatabaseInfo(DateTime.Now, double.Parse(valor), 0, 0);
            }
            AdicionarPontoGrafico(valor);
        }
        public void ConfigurarGraficoSimplesDescalibrado()
        {
            var chart = this.variableChart;
            chart.Series.Clear();
            chart.ChartAreas.Clear();

            ChartArea chartArea = new ChartArea("MainArea")
            {
                AxisX =
                {
                    Title = "Tempo (segundos)",
                    Minimum = 0,
                    Interval = 1,
                    MajorGrid = { LineColor = Color.LightGray }
                },
                AxisY =
                {
                    Title = "Temperatura °C",
                    MajorGrid = { LineColor = Color.LightGray }
                }
            };
            chart.ChartAreas.Add(chartArea);

            chart.Series.Add(new System.Windows.Forms.DataVisualization.Charting.Series("Temperatura") // adiciinado o namespace para evitar conflito de bibliotecas de mesmo nome
            {
                // configuração geal de cores no grafico
                ChartType = SeriesChartType.Line,
                Color = Color.Red,
                BorderWidth = 2,
                XValueType = ChartValueType.Double,
                YValueType = ChartValueType.Double
            });
        }

        public void AdicionarPontoGrafico(string valor)
        {
            var chart = this.variableChart;

            double plotValue = int.Parse(valor);

            tempo++;

            chart.Series["Temperatura"].Points.AddXY(tempo, plotValue);

            if (chart.Series["Temperatura"].Points.Count > 50)
            {
                chart.Series["Temperatura"].Points.RemoveAt(0);
            }

            var chartArea = chart.ChartAreas[0];
            chartArea.AxisX.Minimum = Math.Max(0, tempo - 50);
            chartArea.AxisX.Maximum = tempo;

            chart.Update();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void plantPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void conectButton_Click(object sender, EventArgs e)
        {
            try
            {
                ConfigureIpConnection();
                ConfigureTimer(); // 🔥 só começa aqui
                MessageBox.Show("Conectado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Não foi possível estabelecer uma coenxão {ex.ToString()}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataLoggerBase_Click(object sender, EventArgs e)
        {
            var dataForm = new DataLoggerPage();
            dataForm.Show();
        }

        private void lblMaxValue_Click(object sender, EventArgs e)
        {

        }

        private void variableChart_Click(object sender, EventArgs e)
        {

        }

        private void SaveChart_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PNG Image|*.png|JPEG Image|*.jpg|Bitmap Image|*.bmp";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                variableChart.SaveImage(sfd.FileName, ChartImageFormat.Png);
            }
        }
    }
}
