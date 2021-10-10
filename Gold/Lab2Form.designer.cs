
namespace Gold
{
    partial class Lab2Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lowerBorderBox = new System.Windows.Forms.TextBox();
            this.higherBorderBox = new System.Windows.Forms.TextBox();
            this.accurancyBox = new System.Windows.Forms.TextBox();
            this.formulaeBox = new System.Windows.Forms.TextBox();
            this.lowerBorderLabel = new System.Windows.Forms.Label();
            this.higherBorderLabel = new System.Windows.Forms.Label();
            this.accurancyLabel = new System.Windows.Forms.Label();
            this.formulaeLabel = new System.Windows.Forms.Label();
            this.minPointsLabel = new System.Windows.Forms.Label();
            this.lab0Menu = new System.Windows.Forms.MenuStrip();
            this.launchButton = new System.Windows.Forms.ToolStripMenuItem();
            this.exitButton = new System.Windows.Forms.ToolStripMenuItem();
            this.formulaeChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.minPointBox = new System.Windows.Forms.TextBox();
            this.lastMin = new System.Windows.Forms.Button();
            this.nextMin = new System.Windows.Forms.Button();
            this.lab0Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formulaeChart)).BeginInit();
            this.SuspendLayout();
            // 
            // lowerBorderBox
            // 
            this.lowerBorderBox.Location = new System.Drawing.Point(12, 27);
            this.lowerBorderBox.Name = "lowerBorderBox";
            this.lowerBorderBox.Size = new System.Drawing.Size(100, 20);
            this.lowerBorderBox.TabIndex = 0;
            this.lowerBorderBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Params_KeyPress);
            // 
            // higherBorderBox
            // 
            this.higherBorderBox.Location = new System.Drawing.Point(12, 53);
            this.higherBorderBox.Name = "higherBorderBox";
            this.higherBorderBox.Size = new System.Drawing.Size(100, 20);
            this.higherBorderBox.TabIndex = 1;
            this.higherBorderBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Params_KeyPress);
            // 
            // accurancyBox
            // 
            this.accurancyBox.Location = new System.Drawing.Point(12, 79);
            this.accurancyBox.Name = "accurancyBox";
            this.accurancyBox.Size = new System.Drawing.Size(100, 20);
            this.accurancyBox.TabIndex = 2;
            this.accurancyBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Params_KeyPress);
            // 
            // formulaeBox
            // 
            this.formulaeBox.Location = new System.Drawing.Point(12, 105);
            this.formulaeBox.Name = "formulaeBox";
            this.formulaeBox.Size = new System.Drawing.Size(100, 20);
            this.formulaeBox.TabIndex = 3;
            // 
            // lowerBorderLabel
            // 
            this.lowerBorderLabel.AutoSize = true;
            this.lowerBorderLabel.Location = new System.Drawing.Point(118, 30);
            this.lowerBorderLabel.Name = "lowerBorderLabel";
            this.lowerBorderLabel.Size = new System.Drawing.Size(91, 13);
            this.lowerBorderLabel.TabIndex = 4;
            this.lowerBorderLabel.Text = "Нижняя граница";
            // 
            // higherBorderLabel
            // 
            this.higherBorderLabel.AutoSize = true;
            this.higherBorderLabel.Location = new System.Drawing.Point(118, 56);
            this.higherBorderLabel.Name = "higherBorderLabel";
            this.higherBorderLabel.Size = new System.Drawing.Size(93, 13);
            this.higherBorderLabel.TabIndex = 5;
            this.higherBorderLabel.Text = "Верхняя граница";
            // 
            // accurancyLabel
            // 
            this.accurancyLabel.AutoSize = true;
            this.accurancyLabel.Location = new System.Drawing.Point(118, 82);
            this.accurancyLabel.Name = "accurancyLabel";
            this.accurancyLabel.Size = new System.Drawing.Size(54, 13);
            this.accurancyLabel.TabIndex = 6;
            this.accurancyLabel.Text = "Точность";
            // 
            // formulaeLabel
            // 
            this.formulaeLabel.AutoSize = true;
            this.formulaeLabel.Location = new System.Drawing.Point(118, 108);
            this.formulaeLabel.Name = "formulaeLabel";
            this.formulaeLabel.Size = new System.Drawing.Size(53, 13);
            this.formulaeLabel.TabIndex = 7;
            this.formulaeLabel.Text = "Функция";
            // 
            // minPointsLabel
            // 
            this.minPointsLabel.AutoSize = true;
            this.minPointsLabel.Location = new System.Drawing.Point(58, 190);
            this.minPointsLabel.Name = "minPointsLabel";
            this.minPointsLabel.Size = new System.Drawing.Size(93, 13);
            this.minPointsLabel.TabIndex = 10;
            this.minPointsLabel.Text = "Точка минимума";
            // 
            // lab0Menu
            // 
            this.lab0Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.launchButton,
            this.exitButton});
            this.lab0Menu.Location = new System.Drawing.Point(0, 0);
            this.lab0Menu.Name = "lab0Menu";
            this.lab0Menu.Size = new System.Drawing.Size(1073, 24);
            this.lab0Menu.TabIndex = 11;
            // 
            // launchButton
            // 
            this.launchButton.Name = "launchButton";
            this.launchButton.Size = new System.Drawing.Size(57, 20);
            this.launchButton.Text = "Запуск";
            this.launchButton.Click += new System.EventHandler(this.LaunchButton_click);
            // 
            // exitButton
            // 
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(54, 20);
            this.exitButton.Text = "Выход";
            this.exitButton.Click += new System.EventHandler(this.ClearButton_click);
            // 
            // formulaeChart
            // 
            chartArea4.Name = "ChartArea1";
            this.formulaeChart.ChartAreas.Add(chartArea4);
            this.formulaeChart.Location = new System.Drawing.Point(215, 27);
            this.formulaeChart.Name = "formulaeChart";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series7.Name = "Points";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Name = "Line";
            this.formulaeChart.Series.Add(series7);
            this.formulaeChart.Series.Add(series8);
            this.formulaeChart.Size = new System.Drawing.Size(846, 329);
            this.formulaeChart.TabIndex = 12;
            this.formulaeChart.Text = "chart1";
            // 
            // minPointBox
            // 
            this.minPointBox.Enabled = false;
            this.minPointBox.Location = new System.Drawing.Point(4, 206);
            this.minPointBox.Name = "minPointBox";
            this.minPointBox.Size = new System.Drawing.Size(205, 20);
            this.minPointBox.TabIndex = 13;
            // 
            // lastMin
            // 
            this.lastMin.Location = new System.Drawing.Point(4, 232);
            this.lastMin.Name = "lastMin";
            this.lastMin.Size = new System.Drawing.Size(100, 23);
            this.lastMin.TabIndex = 14;
            this.lastMin.Text = "Предыдущая";
            this.lastMin.UseVisualStyleBackColor = true;
            this.lastMin.Click += new System.EventHandler(this.pointChange_Click);
            // 
            // nextMin
            // 
            this.nextMin.Location = new System.Drawing.Point(109, 232);
            this.nextMin.Name = "nextMin";
            this.nextMin.Size = new System.Drawing.Size(100, 23);
            this.nextMin.TabIndex = 15;
            this.nextMin.Text = "Следующая";
            this.nextMin.UseVisualStyleBackColor = true;
            this.nextMin.Click += new System.EventHandler(this.pointChange_Click);
            // 
            // Lab2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 361);
            this.Controls.Add(this.nextMin);
            this.Controls.Add(this.lastMin);
            this.Controls.Add(this.minPointBox);
            this.Controls.Add(this.formulaeChart);
            this.Controls.Add(this.minPointsLabel);
            this.Controls.Add(this.formulaeLabel);
            this.Controls.Add(this.accurancyLabel);
            this.Controls.Add(this.higherBorderLabel);
            this.Controls.Add(this.lowerBorderLabel);
            this.Controls.Add(this.formulaeBox);
            this.Controls.Add(this.accurancyBox);
            this.Controls.Add(this.higherBorderBox);
            this.Controls.Add(this.lowerBorderBox);
            this.Controls.Add(this.lab0Menu);
            this.MainMenuStrip = this.lab0Menu;
            this.Name = "Lab2Form";
            this.Text = "Золотое сечение";
            this.lab0Menu.ResumeLayout(false);
            this.lab0Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formulaeChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lowerBorderBox;
        private System.Windows.Forms.TextBox higherBorderBox;
        private System.Windows.Forms.TextBox accurancyBox;
        private System.Windows.Forms.TextBox formulaeBox;
        private System.Windows.Forms.Label lowerBorderLabel;
        private System.Windows.Forms.Label higherBorderLabel;
        private System.Windows.Forms.Label accurancyLabel;
        private System.Windows.Forms.Label formulaeLabel;
        private System.Windows.Forms.Label minPointsLabel;
        private System.Windows.Forms.MenuStrip lab0Menu;
        private System.Windows.Forms.ToolStripMenuItem launchButton;
        private System.Windows.Forms.ToolStripMenuItem exitButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart formulaeChart;
        private System.Windows.Forms.TextBox minPointBox;
        private System.Windows.Forms.Button lastMin;
        private System.Windows.Forms.Button nextMin;
    }
}

