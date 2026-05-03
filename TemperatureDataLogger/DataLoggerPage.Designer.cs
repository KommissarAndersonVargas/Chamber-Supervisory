namespace TemperatureDataLogger
{
    partial class DataLoggerPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Export = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.UpdateDatabase = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.SearchInData = new System.Windows.Forms.ToolStripButton();
            this.txtbSearchQuary = new System.Windows.Forms.ToolStripTextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.dataandtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temperatureValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temperatures_TableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.temperatureDataSetBinding = new TemperatureDataLogger.DataSet.TemperatureDataSet();
            this.temperatures_TableTableAdapter = new TemperatureDataLogger.DataSet.TemperatureDataSetTableAdapters.Temperatures_TableTableAdapter();
            this.tableAdapterManager = new TemperatureDataLogger.DataSet.TemperatureDataSetTableAdapters.TableAdapterManager();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temperatures_TableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temperatureDataSetBinding)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.Gray;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Export,
            this.toolStripSeparator1,
            this.UpdateDatabase,
            this.toolStripSeparator2,
            this.SearchInData,
            this.txtbSearchQuary});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(455, 77);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "dataLoggerToolStrip";
            // 
            // Export
            // 
            this.Export.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Export.Image = global::TemperatureDataLogger.Properties.Resources.excel;
            this.Export.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Export.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(64, 74);
            this.Export.Text = "Exportar";
            this.Export.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Export.Click += new System.EventHandler(this.Export_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 77);
            // 
            // UpdateDatabase
            // 
            this.UpdateDatabase.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateDatabase.Image = global::TemperatureDataLogger.Properties.Resources._95904_database_right_arrow_icon;
            this.UpdateDatabase.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.UpdateDatabase.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UpdateDatabase.Name = "UpdateDatabase";
            this.UpdateDatabase.Size = new System.Drawing.Size(67, 74);
            this.UpdateDatabase.Text = "Atualizar";
            this.UpdateDatabase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.UpdateDatabase.Click += new System.EventHandler(this.UpdateDatabase_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 77);
            // 
            // SearchInData
            // 
            this.SearchInData.Image = global::TemperatureDataLogger.Properties.Resources.search_zoom;
            this.SearchInData.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SearchInData.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SearchInData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SearchInData.Name = "SearchInData";
            this.SearchInData.Size = new System.Drawing.Size(52, 74);
            this.SearchInData.ToolTipText = "Procurar";
            this.SearchInData.Click += new System.EventHandler(this.SearchInData_Click);
            // 
            // txtbSearchQuary
            // 
            this.txtbSearchQuary.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbSearchQuary.Name = "txtbSearchQuary";
            this.txtbSearchQuary.Size = new System.Drawing.Size(130, 77);
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataandtimeDataGridViewTextBoxColumn,
            this.temperatureValueDataGridViewTextBoxColumn,
            this.maxValueDataGridViewTextBoxColumn,
            this.minValueDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.temperatures_TableBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 77);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(455, 424);
            this.dataGridView.TabIndex = 1;
            // 
            // dataandtimeDataGridViewTextBoxColumn
            // 
            this.dataandtimeDataGridViewTextBoxColumn.DataPropertyName = "Data_and_time";
            this.dataandtimeDataGridViewTextBoxColumn.HeaderText = "Data_and_time";
            this.dataandtimeDataGridViewTextBoxColumn.Name = "dataandtimeDataGridViewTextBoxColumn";
            // 
            // temperatureValueDataGridViewTextBoxColumn
            // 
            this.temperatureValueDataGridViewTextBoxColumn.DataPropertyName = "Temperature_Value";
            this.temperatureValueDataGridViewTextBoxColumn.HeaderText = "Temperature_Value";
            this.temperatureValueDataGridViewTextBoxColumn.Name = "temperatureValueDataGridViewTextBoxColumn";
            // 
            // maxValueDataGridViewTextBoxColumn
            // 
            this.maxValueDataGridViewTextBoxColumn.DataPropertyName = "Max_Value";
            this.maxValueDataGridViewTextBoxColumn.HeaderText = "Max_Value";
            this.maxValueDataGridViewTextBoxColumn.Name = "maxValueDataGridViewTextBoxColumn";
            // 
            // minValueDataGridViewTextBoxColumn
            // 
            this.minValueDataGridViewTextBoxColumn.DataPropertyName = "Min_Value";
            this.minValueDataGridViewTextBoxColumn.HeaderText = "Min_Value";
            this.minValueDataGridViewTextBoxColumn.Name = "minValueDataGridViewTextBoxColumn";
            // 
            // temperatures_TableBindingSource
            // 
            this.temperatures_TableBindingSource.DataMember = "Temperatures_Table";
            this.temperatures_TableBindingSource.DataSource = this.temperatureDataSetBinding;
            // 
            // temperatureDataSetBinding
            // 
            this.temperatureDataSetBinding.DataSetName = "TemperatureDataSet";
            this.temperatureDataSetBinding.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // temperatures_TableTableAdapter
            // 
            this.temperatures_TableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Temperatures_TableTableAdapter = this.temperatures_TableTableAdapter;
            this.tableAdapterManager.UpdateOrder = TemperatureDataLogger.DataSet.TemperatureDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // DataLoggerPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 501);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.Name = "DataLoggerPage";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.DataLoggerPage_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temperatures_TableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temperatureDataSetBinding)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Export;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataGridView dataGridView;
        private DataSet.TemperatureDataSet temperatureDataSetBinding;
        private System.Windows.Forms.BindingSource temperatures_TableBindingSource;
        private DataSet.TemperatureDataSetTableAdapters.Temperatures_TableTableAdapter temperatures_TableTableAdapter;
        private DataSet.TemperatureDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStripButton UpdateDatabase;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton SearchInData;
        private System.Windows.Forms.ToolStripTextBox txtbSearchQuary;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataandtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn temperatureValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minValueDataGridViewTextBoxColumn;
    }
}