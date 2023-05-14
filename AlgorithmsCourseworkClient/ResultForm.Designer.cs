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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.fetchButton = new System.Windows.Forms.Button();
            this.writeButton = new System.Windows.Forms.Button();
            this.resultView = new System.Windows.Forms.DataGridView();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plotButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.timeLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.versionLabel = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.resultView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fetchButton
            // 
            this.fetchButton.Location = new System.Drawing.Point(12, 36);
            this.fetchButton.Name = "fetchButton";
            this.fetchButton.Size = new System.Drawing.Size(220, 57);
            this.fetchButton.TabIndex = 0;
            this.fetchButton.Text = "Получить результаты тестирования";
            this.fetchButton.UseVisualStyleBackColor = true;
            this.fetchButton.Click += new System.EventHandler(this.fetchButton_Click);
            // 
            // writeButton
            // 
            this.writeButton.Location = new System.Drawing.Point(12, 123);
            this.writeButton.Name = "writeButton";
            this.writeButton.Size = new System.Drawing.Size(220, 57);
            this.writeButton.TabIndex = 1;
            this.writeButton.Text = "Запись результатов в word";
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
            this.resultView.Location = new System.Drawing.Point(256, 36);
            this.resultView.Name = "resultView";
            this.resultView.ReadOnly = true;
            this.resultView.Size = new System.Drawing.Size(240, 525);
            this.resultView.TabIndex = 2;
            // 
            // number
            // 
            this.number.Frozen = true;
            this.number.HeaderText = "№";
            this.number.Name = "number";
            this.number.ReadOnly = true;
            // 
            // result
            // 
            this.result.Frozen = true;
            this.result.HeaderText = "Результат";
            this.result.Name = "result";
            this.result.ReadOnly = true;
            // 
            // plotButton
            // 
            this.plotButton.Location = new System.Drawing.Point(536, 37);
            this.plotButton.Name = "plotButton";
            this.plotButton.Size = new System.Drawing.Size(220, 57);
            this.plotButton.TabIndex = 3;
            this.plotButton.Text = "Построение диаграмм";
            this.plotButton.UseVisualStyleBackColor = true;
            this.plotButton.Click += new System.EventHandler(this.plotButton_Click);
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(536, 124);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(220, 57);
            this.openButton.TabIndex = 4;
            this.openButton.Text = "Открыть файл word с результатами тестирования";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(536, 211);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(220, 57);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Выход из приложения";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(805, 36);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Верно";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Неверно";
            this.chart.Series.Add(series1);
            this.chart.Series.Add(series2);
            this.chart.Size = new System.Drawing.Size(300, 525);
            this.chart.TabIndex = 6;
            this.chart.Text = "chart1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timeLabel,
            this.toolStripStatusLabel1,
            this.versionLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 604);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1163, 22);
            this.statusStrip1.TabIndex = 23;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // timeLabel
            // 
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(79, 17);
            this.timeLabel.Text = "Дата и время";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(993, 17);
            this.toolStripStatusLabel1.Spring = true;
            // 
            // versionLabel
            // 
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.versionLabel.Size = new System.Drawing.Size(76, 17);
            this.versionLabel.Text = "Версия: 1.0.0";
            this.versionLabel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 626);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.plotButton);
            this.Controls.Add(this.resultView);
            this.Controls.Add(this.writeButton);
            this.Controls.Add(this.fetchButton);
            this.Name = "ResultForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Результаты тестирования — курсовая работа — Сидорук Данил Вадимович, БФИ-2202";
            ((System.ComponentModel.ISupportInitialize)(this.resultView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn result;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel timeLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel versionLabel;
    }
}