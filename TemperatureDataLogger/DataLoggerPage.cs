using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using LicenseContext = OfficeOpenXml.LicenseContext;

namespace TemperatureDataLogger
{
    public partial class DataLoggerPage : Form
    {
        public DataLoggerPage()
        {
            InitializeComponent();
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
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

        private void Export_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();


            saveFileDialog.Filter = "Excel Files|*.xlsx";
            saveFileDialog.FileName = "Exportado.xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (var package = new ExcelPackage())
                {
                    var worksheet = package.Workbook.Worksheets.Add("Exportado");

                    // Exporta cabeçalhos e dados em poucas linhas
                    for (int i = 0; i < dataGridView.Columns.Count; i++)
                        worksheet.Cells[1, i + 1].Value = dataGridView.Columns[i].HeaderText;

                    for (int i = 0; i < dataGridView.Rows.Count; i++)
                        for (int j = 0; j < dataGridView.Columns.Count; j++)
                            worksheet.Cells[i + 2, j + 1].Value = dataGridView.Rows[i].Cells[j].Value;

                    package.SaveAs(new FileInfo(saveFileDialog.FileName));
                }
            }
        }

        private void SearchInData_Click(object sender, EventArgs e)
        {
            string dateQuery = txtbSearchQuary.Text.ToString();
            var dateFound = DataBaseQueries.GetDateTemperature(dateQuery);
            try
            {
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (row.Cells[0].Value != null &&
                     Convert.ToDateTime(row.Cells[0].Value) == dateFound)
                    {
                        row.Selected = true;
                        dataGridView.CurrentCell = row.Cells[0];
                        break;
                    }
                }
            }

            catch (Exception)
            {
                Console.WriteLine();
            }
        }
    }
}
