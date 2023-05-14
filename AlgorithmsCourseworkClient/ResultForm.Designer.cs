namespace AlgorithmsCourseworkGUI
{
    partial class ResultForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.fetchButton = new System.Windows.Forms.Button();
            this.writeButton = new System.Windows.Forms.Button();
            this.resultView = new System.Windows.Forms.DataGridView();
            this.plotButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.timeLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.versionLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.writeExcelButton = new System.Windows.Forms.Button();
            this.openExcelButton = new System.Windows.Forms.Button();
            this.writeSortExcelButton = new System.Windows.Forms.Button();
            this.sortedView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sortButton = new System.Windows.Forms.Button();
            this.insertColumnButton = new System.Windows.Forms.Button();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.resultView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sortedView)).BeginInit();
            this.SuspendLayout();
            // 
            // fetchButton
            // 
            this.fetchButton.Location = new System.Drawing.Point(16, 44);
            this.fetchButton.Margin = new System.Windows.Forms.Padding(4);
            this.fetchButton.Name = "fetchButton";
            this.fetchButton.Size = new System.Drawing.Size(160, 70);
            this.fetchButton.TabIndex = 0;
            this.fetchButton.Text = "Получить результаты тестирования";
            this.fetchButton.UseVisualStyleBackColor = true;
            this.fetchButton.Click += new System.EventHandler(this.fetchButton_Click);
            // 
            // writeButton
            // 
            this.writeButton.Location = new System.Drawing.Point(16, 259);
            this.writeButton.Margin = new System.Windows.Forms.Padding(4);
            this.writeButton.Name = "writeButton";
            this.writeButton.Size = new System.Drawing.Size(160, 70);
            this.writeButton.TabIndex = 1;
            this.writeButton.Text = "Запись таблицы в word";
            this.writeButton.UseVisualStyleBackColor = true;
            this.writeButton.Click += new System.EventHandler(this.writeButton_Click);
            // 
            // resultView
            // 
            this.resultView.AllowUserToAddRows = false;
            this.resultView.AllowUserToDeleteRows = false;
            this.resultView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.result});
            this.resultView.Location = new System.Drawing.Point(184, 44);
            this.resultView.Margin = new System.Windows.Forms.Padding(4);
            this.resultView.Name = "resultView";
            this.resultView.RowHeadersWidth = 51;
            this.resultView.Size = new System.Drawing.Size(317, 646);
            this.resultView.TabIndex = 2;
            // 
            // plotButton
            // 
            this.plotButton.Location = new System.Drawing.Point(1015, 47);
            this.plotButton.Margin = new System.Windows.Forms.Padding(4);
            this.plotButton.Name = "plotButton";
            this.plotButton.Size = new System.Drawing.Size(160, 70);
            this.plotButton.TabIndex = 3;
            this.plotButton.Text = "Построение диаграмм";
            this.plotButton.UseVisualStyleBackColor = true;
            this.plotButton.Click += new System.EventHandler(this.plotButton_Click);
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(1015, 154);
            this.openButton.Margin = new System.Windows.Forms.Padding(4);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(160, 70);
            this.openButton.TabIndex = 4;
            this.openButton.Text = "Открыть файл word с результатами тестирования";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(1015, 368);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(160, 70);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Выход из приложения";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // chart
            // 
            chartArea3.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart.Legends.Add(legend3);
            this.chart.Location = new System.Drawing.Point(1183, 44);
            this.chart.Margin = new System.Windows.Forms.Padding(4);
            this.chart.Name = "chart";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Верно";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Неверно";
            this.chart.Series.Add(series5);
            this.chart.Series.Add(series6);
            this.chart.Size = new System.Drawing.Size(351, 646);
            this.chart.TabIndex = 6;
            this.chart.Text = "chart1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timeLabel,
            this.toolStripStatusLabel1,
            this.versionLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 744);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1551, 26);
            this.statusStrip1.TabIndex = 23;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // timeLabel
            // 
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(102, 20);
            this.timeLabel.Text = "Дата и время";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(1333, 20);
            this.toolStripStatusLabel1.Spring = true;
            // 
            // versionLabel
            // 
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.versionLabel.Size = new System.Drawing.Size(96, 20);
            this.versionLabel.Text = "Версия: 1.0.0";
            this.versionLabel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // writeExcelButton
            // 
            this.writeExcelButton.Location = new System.Drawing.Point(16, 368);
            this.writeExcelButton.Margin = new System.Windows.Forms.Padding(4);
            this.writeExcelButton.Name = "writeExcelButton";
            this.writeExcelButton.Size = new System.Drawing.Size(160, 70);
            this.writeExcelButton.TabIndex = 24;
            this.writeExcelButton.Text = "Сохранение графика и запись результатов в excel\r\n";
            this.writeExcelButton.UseVisualStyleBackColor = true;
            this.writeExcelButton.Click += new System.EventHandler(this.writeExcelButton_Click);
            // 
            // openExcelButton
            // 
            this.openExcelButton.Location = new System.Drawing.Point(1015, 261);
            this.openExcelButton.Margin = new System.Windows.Forms.Padding(4);
            this.openExcelButton.Name = "openExcelButton";
            this.openExcelButton.Size = new System.Drawing.Size(160, 70);
            this.openExcelButton.TabIndex = 25;
            this.openExcelButton.Text = "Открыть файл excel с результатами тестирования";
            this.openExcelButton.UseVisualStyleBackColor = true;
            this.openExcelButton.Click += new System.EventHandler(this.openExcelButton_Click);
            // 
            // writeSortExcelButton
            // 
            this.writeSortExcelButton.Location = new System.Drawing.Point(509, 154);
            this.writeSortExcelButton.Margin = new System.Windows.Forms.Padding(4);
            this.writeSortExcelButton.Name = "writeSortExcelButton";
            this.writeSortExcelButton.Size = new System.Drawing.Size(160, 70);
            this.writeSortExcelButton.TabIndex = 29;
            this.writeSortExcelButton.Text = "Сохранение графика и запись результатов в excel\r\n";
            this.writeSortExcelButton.UseVisualStyleBackColor = true;
            this.writeSortExcelButton.Click += new System.EventHandler(this.writeSortExcelButton_Click);
            // 
            // sortedView
            // 
            this.sortedView.AllowUserToAddRows = false;
            this.sortedView.AllowUserToDeleteRows = false;
            this.sortedView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sortedView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.sortedView.Location = new System.Drawing.Point(677, 44);
            this.sortedView.Margin = new System.Windows.Forms.Padding(4);
            this.sortedView.Name = "sortedView";
            this.sortedView.ReadOnly = true;
            this.sortedView.RowHeadersWidth = 51;
            this.sortedView.Size = new System.Drawing.Size(330, 646);
            this.sortedView.TabIndex = 28;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "№";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn2.Frozen = true;
            this.dataGridViewTextBoxColumn2.HeaderText = "Результат";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 106;
            // 
            // sortButton
            // 
            this.sortButton.Location = new System.Drawing.Point(509, 47);
            this.sortButton.Margin = new System.Windows.Forms.Padding(4);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(160, 70);
            this.sortButton.TabIndex = 27;
            this.sortButton.Text = "Отсортировать результаты";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // insertColumnButton
            // 
            this.insertColumnButton.Location = new System.Drawing.Point(16, 154);
            this.insertColumnButton.Margin = new System.Windows.Forms.Padding(4);
            this.insertColumnButton.Name = "insertColumnButton";
            this.insertColumnButton.Size = new System.Drawing.Size(160, 70);
            this.insertColumnButton.TabIndex = 30;
            this.insertColumnButton.Text = "Вставить столбец";
            this.insertColumnButton.UseVisualStyleBackColor = true;
            this.insertColumnButton.Click += new System.EventHandler(this.insertColumnButton_Click);
            // 
            // number
            // 
            this.number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.number.Frozen = true;
            this.number.HeaderText = "№";
            this.number.MinimumWidth = 6;
            this.number.Name = "number";
            this.number.ReadOnly = true;
            this.number.Width = 50;
            // 
            // result
            // 
            this.result.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.result.Frozen = true;
            this.result.HeaderText = "Результат";
            this.result.MinimumWidth = 6;
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.Width = 106;
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1551, 770);
            this.Controls.Add(this.insertColumnButton);
            this.Controls.Add(this.writeSortExcelButton);
            this.Controls.Add(this.sortedView);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.openExcelButton);
            this.Controls.Add(this.writeExcelButton);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.plotButton);
            this.Controls.Add(this.resultView);
            this.Controls.Add(this.writeButton);
            this.Controls.Add(this.fetchButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ResultForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Результаты тестирования — курсовая работа — Сидорук Данил Вадимович, БФИ-2202";
            ((System.ComponentModel.ISupportInitialize)(this.resultView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sortedView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fetchButton;
        private System.Windows.Forms.Button writeButton;
        private System.Windows.Forms.DataGridView resultView;
        private System.Windows.Forms.Button plotButton;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel timeLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel versionLabel;
        private System.Windows.Forms.Button writeExcelButton;
        private System.Windows.Forms.Button openExcelButton;
        private System.Windows.Forms.Button writeSortExcelButton;
        private System.Windows.Forms.DataGridView sortedView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.Button insertColumnButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn result;
    }
}