namespace TemperatureDataLogger
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip = new System.Windows.Forms.ToolStrip();
            this.SaveChart = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.conectButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.ipConnectTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.DataLoggerBase = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.lblMaxValue = new System.Windows.Forms.ToolStripLabel();
            this.txtbMinTemp = new System.Windows.Forms.ToolStripTextBox();
            this.lblCelcius1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.lblMinValue = new System.Windows.Forms.ToolStripLabel();
            this.txtbMaxTemp = new System.Windows.Forms.ToolStripTextBox();
            this.lblCelcius2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.plantPanel = new System.Windows.Forms.Panel();
            this.wirePanel1 = new System.Windows.Forms.Panel();
            this.RchtSensorDisplay = new System.Windows.Forms.RichTextBox();
            this.alarmStateBtn = new System.Windows.Forms.Button();
            this.wirePanel2 = new System.Windows.Forms.Panel();
            this.plantPictureBox = new System.Windows.Forms.PictureBox();
            this.CommunicationTimmer = new System.Windows.Forms.Timer(this.components);
            this.variableChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip.SuspendLayout();
            this.plantPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plantPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.variableChart)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.AutoSize = false;
            this.menuStrip.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveChart,
            this.toolStripSeparator2,
            this.conectButton,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.ipConnectTextBox,
            this.toolStripSeparator3,
            this.DataLoggerBase,
            this.toolStripSeparator4,
            this.lblMaxValue,
            this.txtbMinTemp,
            this.lblCelcius1,
            this.toolStripSeparator5,
            this.lblMinValue,
            this.txtbMaxTemp,
            this.lblCelcius2,
            this.toolStripSeparator6});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(898, 66);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "toolStrip1";
            // 
            // SaveChart
            // 
            this.SaveChart.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveChart.Image = global::TemperatureDataLogger.Properties.Resources.save_chart;
            this.SaveChart.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SaveChart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveChart.Name = "SaveChart";
            this.SaveChart.Size = new System.Drawing.Size(97, 63);
            this.SaveChart.Text = "Salvar Gráfico";
            this.SaveChart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.SaveChart.Click += new System.EventHandler(this.SaveChart_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 66);
            // 
            // conectButton
            // 
            this.conectButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conectButton.Image = global::TemperatureDataLogger.Properties.Resources.link;
            this.conectButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.conectButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.conectButton.Name = "conectButton";
            this.conectButton.Size = new System.Drawing.Size(75, 63);
            this.conectButton.Text = "Conectar";
            this.conectButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.conectButton.Click += new System.EventHandler(this.conectButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 66);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(29, 63);
            this.toolStripLabel1.Text = "Ip:";
            // 
            // ipConnectTextBox
            // 
            this.ipConnectTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipConnectTextBox.Name = "ipConnectTextBox";
            this.ipConnectTextBox.Size = new System.Drawing.Size(100, 66);
            this.ipConnectTextBox.Text = "192.168.1.5";
            this.ipConnectTextBox.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 66);
            // 
            // DataLoggerBase
            // 
            this.DataLoggerBase.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataLoggerBase.Image = global::TemperatureDataLogger.Properties.Resources.meter;
            this.DataLoggerBase.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.DataLoggerBase.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DataLoggerBase.Name = "DataLoggerBase";
            this.DataLoggerBase.Size = new System.Drawing.Size(99, 63);
            this.DataLoggerBase.Text = "DataLogger ";
            this.DataLoggerBase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.DataLoggerBase.Click += new System.EventHandler(this.DataLoggerBase_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 66);
            // 
            // lblMaxValue
            // 
            this.lblMaxValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxValue.Name = "lblMaxValue";
            this.lblMaxValue.Size = new System.Drawing.Size(88, 63);
            this.lblMaxValue.Text = "Valor Min:";
            // 
            // txtbMinTemp
            // 
            this.txtbMinTemp.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbMinTemp.Name = "txtbMinTemp";
            this.txtbMinTemp.Size = new System.Drawing.Size(60, 66);
            // 
            // lblCelcius1
            // 
            this.lblCelcius1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelcius1.Name = "lblCelcius1";
            this.lblCelcius1.Size = new System.Drawing.Size(26, 63);
            this.lblCelcius1.Text = "°C";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 66);
            // 
            // lblMinValue
            // 
            this.lblMinValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinValue.Name = "lblMinValue";
            this.lblMinValue.Size = new System.Drawing.Size(91, 63);
            this.lblMinValue.Text = "Valor Máx:";
            // 
            // txtbMaxTemp
            // 
            this.txtbMaxTemp.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbMaxTemp.Name = "txtbMaxTemp";
            this.txtbMaxTemp.Size = new System.Drawing.Size(60, 66);
            // 
            // lblCelcius2
            // 
            this.lblCelcius2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelcius2.Name = "lblCelcius2";
            this.lblCelcius2.Size = new System.Drawing.Size(26, 63);
            this.lblCelcius2.Text = "°C";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 66);
            // 
            // plantPanel
            // 
            this.plantPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.plantPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.plantPanel.Controls.Add(this.wirePanel1);
            this.plantPanel.Controls.Add(this.RchtSensorDisplay);
            this.plantPanel.Controls.Add(this.alarmStateBtn);
            this.plantPanel.Controls.Add(this.wirePanel2);
            this.plantPanel.Controls.Add(this.plantPictureBox);
            this.plantPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.plantPanel.Location = new System.Drawing.Point(0, 66);
            this.plantPanel.Name = "plantPanel";
            this.plantPanel.Size = new System.Drawing.Size(377, 410);
            this.plantPanel.TabIndex = 1;
            // 
            // wirePanel1
            // 
            this.wirePanel1.BackColor = System.Drawing.Color.Blue;
            this.wirePanel1.Location = new System.Drawing.Point(240, 141);
            this.wirePanel1.Name = "wirePanel1";
            this.wirePanel1.Size = new System.Drawing.Size(10, 119);
            this.wirePanel1.TabIndex = 1;
            // 
            // RchtSensorDisplay
            // 
            this.RchtSensorDisplay.BackColor = System.Drawing.SystemColors.InfoText;
            this.RchtSensorDisplay.Cursor = System.Windows.Forms.Cursors.No;
            this.RchtSensorDisplay.Location = new System.Drawing.Point(141, 266);
            this.RchtSensorDisplay.Name = "RchtSensorDisplay";
            this.RchtSensorDisplay.ReadOnly = true;
            this.RchtSensorDisplay.Size = new System.Drawing.Size(170, 58);
            this.RchtSensorDisplay.TabIndex = 2;
            this.RchtSensorDisplay.Text = "";
            // 
            // alarmStateBtn
            // 
            this.alarmStateBtn.BackColor = System.Drawing.Color.Chartreuse;
            this.alarmStateBtn.Cursor = System.Windows.Forms.Cursors.No;
            this.alarmStateBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.alarmStateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.alarmStateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alarmStateBtn.Image = global::TemperatureDataLogger.Properties.Resources.warning;
            this.alarmStateBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.alarmStateBtn.Location = new System.Drawing.Point(0, 0);
            this.alarmStateBtn.Name = "alarmStateBtn";
            this.alarmStateBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.alarmStateBtn.Size = new System.Drawing.Size(373, 47);
            this.alarmStateBtn.TabIndex = 3;
            this.alarmStateBtn.Text = "Alarme: Sem alarmes";
            this.alarmStateBtn.UseVisualStyleBackColor = false;
            // 
            // wirePanel2
            // 
            this.wirePanel2.BackColor = System.Drawing.Color.Blue;
            this.wirePanel2.Location = new System.Drawing.Point(166, 141);
            this.wirePanel2.Name = "wirePanel2";
            this.wirePanel2.Size = new System.Drawing.Size(75, 11);
            this.wirePanel2.TabIndex = 2;
            // 
            // plantPictureBox
            // 
            this.plantPictureBox.Image = global::TemperatureDataLogger.Properties.Resources.camara_fria_valor;
            this.plantPictureBox.Location = new System.Drawing.Point(19, 87);
            this.plantPictureBox.Name = "plantPictureBox";
            this.plantPictureBox.Size = new System.Drawing.Size(141, 139);
            this.plantPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.plantPictureBox.TabIndex = 2;
            this.plantPictureBox.TabStop = false;
            // 
            // variableChart
            // 
            chartArea2.Name = "ChartArea1";
            this.variableChart.ChartAreas.Add(chartArea2);
            this.variableChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.variableChart.Legends.Add(legend2);
            this.variableChart.Location = new System.Drawing.Point(377, 66);
            this.variableChart.Name = "variableChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.variableChart.Series.Add(series2);
            this.variableChart.Size = new System.Drawing.Size(521, 410);
            this.variableChart.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(898, 476);
            this.Controls.Add(this.variableChart);
            this.Controls.Add(this.plantPanel);
            this.Controls.Add(this.menuStrip);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Chamber Supervisory";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.plantPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.plantPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.variableChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip menuStrip;
        private System.Windows.Forms.Panel plantPanel;
        private System.Windows.Forms.PictureBox plantPictureBox;
        private System.Windows.Forms.Panel wirePanel1;
        private System.Windows.Forms.Panel wirePanel2;
        private System.Windows.Forms.Button alarmStateBtn;
        private System.Windows.Forms.RichTextBox RchtSensorDisplay;
        private System.Windows.Forms.Timer CommunicationTimmer;
        private System.Windows.Forms.DataVisualization.Charting.Chart variableChart;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox ipConnectTextBox;
        private System.Windows.Forms.ToolStripButton conectButton;
        private System.Windows.Forms.ToolStripLabel lblMaxValue;
        private System.Windows.Forms.ToolStripButton SaveChart;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton DataLoggerBase;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel lblMinValue;
        private System.Windows.Forms.ToolStripTextBox txtbMaxTemp;
        private System.Windows.Forms.ToolStripTextBox txtbMinTemp;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripLabel lblCelcius1;
        private System.Windows.Forms.ToolStripLabel lblCelcius2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
    }
}

