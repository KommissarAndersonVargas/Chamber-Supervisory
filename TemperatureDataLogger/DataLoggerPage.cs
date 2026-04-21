using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemperatureDataLogger
{
    public partial class DataLoggerPage : Form
    {
        public DataLoggerPage()
        {
            InitializeComponent();
        }

        private void DataLoggerPage_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'temperatureDataSetBinding.Temperatures_Table'. Você pode movê-la ou removê-la conforme necessário.
            this.temperatures_TableTableAdapter.Fill(this.temperatureDataSetBinding.Temperatures_Table);
            txtbSearchQuary.Text = DateTime.Now.ToString();

            dataGridView.Columns[0].HeaderText = "Data/Hora";
            dataGridView.Columns[1].HeaderText = "Temperatura (°C)";
            dataGridView.Columns[2].HeaderText = "Temp Máxima (°C)";
            dataGridView.Columns[3].HeaderText = "Temp Mínima (°C)";
        }

        private void UpdateDatabase_Click(object sender, EventArgs e)
        {
            try
            {
                this.temperatures_TableTableAdapter.Fill(this.temperatureDataSetBinding.Temperatures_Table);
            }
            catch (Exception)
            {
            }
        }
    }
}
