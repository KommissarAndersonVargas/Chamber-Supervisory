using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using TemperatureDataLogger.Business;

namespace TemperatureDataLogger
{
    public partial class Form1 : Form
    {
        private string SensorChache = "x";
        private int ChartTime = 0;
        private readonly int TimerInterval = 1000;
        private readonly int ChartSamples = 50;

        public Form1()
        {
            InitializeComponent();
            LoadVisorConfig();
            ConfigurarGraficoSimplesDescalibrado();
        }

        public void ConfigureTimer()
        {
            CommunicationTimmer.Interval = TimerInterval;
            CommunicationTimmer.Tick += Timer_Tick;
            CommunicationTimmer.Start();
        }

        public void LoadVisorConfig()
        {
            RchtSensorDisplay.Font = new Font(Properties.Resources.DisplayFont, 36, FontStyle.Bold);
            RchtSensorDisplay.BackColor = Color.Black;
            RchtSensorDisplay.ForeColor = Color.Red;
            RchtSensorDisplay.BorderStyle = BorderStyle.None;
            RchtSensorDisplay.SelectionAlignment = HorizontalAlignment.Center;
            RchtSensorDisplay.Text = Properties.Resources.ErrorTxt;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            try
            {

                string modBusValue = IhmBLL.GetModbusTcpData();

                this.UpdateSensor(SensorChache, modBusValue);

                var canTurnOnPump = IhmBLL.MayTriggersTheOutput(
                    modBusValue,
                    txtbMaxTemp.Text,
                    txtbMinTemp.Text);

                IhmBLL.TriggersTheOutput(canTurnOnPump);

                if (canTurnOnPump)
                {
                    alarmStateBtn.BackColor = Color.Red;
                    alarmStateBtn.Text = Properties.Resources.AlarmOccurence;
                }

                else
                {
                    alarmStateBtn.BackColor = Color.Chartreuse;
                    alarmStateBtn.Text = Properties.Resources.NoAlarmOccurence_Alarme_;
                }
            }
            catch (Exception ex) // colocar excessao junto no ressource
            {
                CommunicationTimmer.Stop();
                MessageBox.Show(
                    string.Format(Properties.Resources.ComunicationFail,ex.Message),
                    Properties.Resources.WarningTxt, 
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void UpdateSensor(string cache, string valor)
        {
            if (!cache.Equals(valor))
            {
                // Atualiza visor sensor da câmera 
                RchtSensorDisplay.Text = valor + " °C";
                //Salva no banco de dados 

                if (!string.IsNullOrEmpty(txtbMaxTemp.Text) && !string.IsNullOrEmpty(txtbMinTemp.Text))
                    IhmBLL.SaveChangeOfTemperature(
                        double.Parse(valor),
                        double.Parse(txtbMaxTemp.Text),
                        double.Parse(txtbMinTemp.Text));
                else
                    IhmBLL.SaveChangeOfTemperature(double.Parse(valor), 0, 0);
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
                    Title = Properties.Resources.ChartTime,
                    Minimum = 0,
                    Interval = 1,
                    MajorGrid = { LineColor = Color.LightGray }
                },
                AxisY =
                {
                    Title = Properties.Resources.ChartTemperature,
                    MajorGrid = { LineColor = Color.LightGray }
                }
            };
            chart.ChartAreas.Add(chartArea);

            chart.Series.Add(
                new System.Windows.Forms.DataVisualization.Charting
                .Series(Properties.Resources.ChartTemperatureTxt) // adiciinado o namespace para evitar conflito de bibliotecas de mesmo nome
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

            ChartTime++;

            chart.Series[Properties.Resources.ChartTemperatureTxt].Points.AddXY(ChartTime, plotValue);

            if (chart.Series[Properties.Resources.ChartTemperatureTxt].Points.Count > ChartSamples)
            {
                chart.Series[Properties.Resources.ChartTemperatureTxt].Points.RemoveAt(0);
            }

            var chartArea = chart.ChartAreas[0];
            chartArea.AxisX.Minimum = Math.Max(0, ChartTime - ChartSamples);
            chartArea.AxisX.Maximum = ChartTime;

            chart.Update();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void conectButton_Click(object sender, EventArgs e)
        {
            try
            {
                IhmBLL.ConfigureTCPIpConnection(ipConnectTextBox.Text as string);
                ConfigureTimer();

                MessageBox.Show(
                    Properties.Resources.SucessfulyConnected,
                    Properties.Resources.InfoTxt,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex) // colocar excessao junto
            {
                MessageBox.Show(
                    string.Format(Properties.Resources.ErrorDuringConnecting, ex.Message),
                    Properties.Resources.ErrorTxt,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void DataLoggerBase_Click(object sender, EventArgs e)
        {
            var dataForm = new DataLoggerPage();
            dataForm.Show();
        }

        private void SaveChart_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = Properties.Resources.SdfImageFilter;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                variableChart.SaveImage(sfd.FileName, ChartImageFormat.Png);
            }
        }
    }
}
