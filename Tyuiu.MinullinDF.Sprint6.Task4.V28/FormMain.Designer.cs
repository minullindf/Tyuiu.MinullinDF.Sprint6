namespace Tyuiu.MinullinDF.Sprint6.Task4.V28
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            buttonDone_MDF = new Button();
            buttonInfo_MDF = new Button();
            groupBoxManagment_MDF = new GroupBox();
            buttonSave_MDF = new Button();
            labelEndValue_MDF = new Label();
            textBoxEndValue_MDF = new TextBox();
            textBoxStartValue_MDF = new TextBox();
            labelStartValue_MDF = new Label();
            groupBoxInput_MDF = new GroupBox();
            pictureBox1 = new PictureBox();
            groupBoxCondition_MDF = new GroupBox();
            textBoxOutput_MDF = new TextBox();
            groupBoxOutput_MDF = new GroupBox();
            chart_MDF = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panelLeft_MDF = new Panel();
            panelUp_MDF = new Panel();
            panelCenter_MDF = new Panel();
            groupBoxManagment_MDF.SuspendLayout();
            groupBoxInput_MDF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBoxCondition_MDF.SuspendLayout();
            groupBoxOutput_MDF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart_MDF).BeginInit();
            panelLeft_MDF.SuspendLayout();
            panelUp_MDF.SuspendLayout();
            panelCenter_MDF.SuspendLayout();
            SuspendLayout();
            // 
            // buttonDone_MDF
            // 
            buttonDone_MDF.BackColor = SystemColors.Desktop;
            buttonDone_MDF.Location = new Point(6, 52);
            buttonDone_MDF.Name = "buttonDone_MDF";
            buttonDone_MDF.Size = new Size(88, 51);
            buttonDone_MDF.TabIndex = 1;
            buttonDone_MDF.Text = "Выполнить";
            buttonDone_MDF.UseVisualStyleBackColor = false;
            buttonDone_MDF.Click += buttonDone_MDF_Click;
            // 
            // buttonInfo_MDF
            // 
            buttonInfo_MDF.BackColor = SystemColors.Highlight;
            buttonInfo_MDF.Location = new Point(194, 52);
            buttonInfo_MDF.Name = "buttonInfo_MDF";
            buttonInfo_MDF.Size = new Size(61, 51);
            buttonInfo_MDF.TabIndex = 0;
            buttonInfo_MDF.Text = "Справка";
            buttonInfo_MDF.UseVisualStyleBackColor = false;
            buttonInfo_MDF.Click += buttonInfo_MDF_Click;
            // 
            // groupBoxManagment_MDF
            // 
            groupBoxManagment_MDF.Controls.Add(buttonSave_MDF);
            groupBoxManagment_MDF.Controls.Add(buttonDone_MDF);
            groupBoxManagment_MDF.Controls.Add(buttonInfo_MDF);
            groupBoxManagment_MDF.Dock = DockStyle.Right;
            groupBoxManagment_MDF.Location = new Point(764, 5);
            groupBoxManagment_MDF.Name = "groupBoxManagment_MDF";
            groupBoxManagment_MDF.Size = new Size(261, 155);
            groupBoxManagment_MDF.TabIndex = 9;
            groupBoxManagment_MDF.TabStop = false;
            groupBoxManagment_MDF.Text = "Управление";
            // 
            // buttonSave_MDF
            // 
            buttonSave_MDF.BackColor = Color.FromArgb(0, 0, 192);
            buttonSave_MDF.Location = new Point(100, 52);
            buttonSave_MDF.Name = "buttonSave_MDF";
            buttonSave_MDF.Size = new Size(88, 51);
            buttonSave_MDF.TabIndex = 2;
            buttonSave_MDF.Text = "Сохранить";
            buttonSave_MDF.UseVisualStyleBackColor = false;
            buttonSave_MDF.Click += buttonSave_MDF_Click;
            // 
            // labelEndValue_MDF
            // 
            labelEndValue_MDF.AutoSize = true;
            labelEndValue_MDF.Location = new Point(146, 51);
            labelEndValue_MDF.Name = "labelEndValue_MDF";
            labelEndValue_MDF.Size = new Size(75, 15);
            labelEndValue_MDF.TabIndex = 3;
            labelEndValue_MDF.Text = "Конец шага:";
            // 
            // textBoxEndValue_MDF
            // 
            textBoxEndValue_MDF.Location = new Point(145, 68);
            textBoxEndValue_MDF.Name = "textBoxEndValue_MDF";
            textBoxEndValue_MDF.Size = new Size(129, 23);
            textBoxEndValue_MDF.TabIndex = 2;
            // 
            // textBoxStartValue_MDF
            // 
            textBoxStartValue_MDF.Location = new Point(6, 68);
            textBoxStartValue_MDF.Name = "textBoxStartValue_MDF";
            textBoxStartValue_MDF.Size = new Size(129, 23);
            textBoxStartValue_MDF.TabIndex = 1;
            // 
            // labelStartValue_MDF
            // 
            labelStartValue_MDF.AutoSize = true;
            labelStartValue_MDF.Location = new Point(7, 51);
            labelStartValue_MDF.Name = "labelStartValue_MDF";
            labelStartValue_MDF.Size = new Size(72, 15);
            labelStartValue_MDF.TabIndex = 0;
            labelStartValue_MDF.Text = "Старт шага:";
            // 
            // groupBoxInput_MDF
            // 
            groupBoxInput_MDF.Controls.Add(labelEndValue_MDF);
            groupBoxInput_MDF.Controls.Add(textBoxEndValue_MDF);
            groupBoxInput_MDF.Controls.Add(textBoxStartValue_MDF);
            groupBoxInput_MDF.Controls.Add(labelStartValue_MDF);
            groupBoxInput_MDF.Location = new Point(464, 5);
            groupBoxInput_MDF.Name = "groupBoxInput_MDF";
            groupBoxInput_MDF.Size = new Size(294, 155);
            groupBoxInput_MDF.TabIndex = 8;
            groupBoxInput_MDF.TabStop = false;
            groupBoxInput_MDF.Text = "Ввод данных";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.Task4V28;
            pictureBox1.Location = new Point(5, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(443, 129);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // groupBoxCondition_MDF
            // 
            groupBoxCondition_MDF.Controls.Add(pictureBox1);
            groupBoxCondition_MDF.Dock = DockStyle.Left;
            groupBoxCondition_MDF.Location = new Point(5, 5);
            groupBoxCondition_MDF.Name = "groupBoxCondition_MDF";
            groupBoxCondition_MDF.Padding = new Padding(5);
            groupBoxCondition_MDF.Size = new Size(453, 155);
            groupBoxCondition_MDF.TabIndex = 10;
            groupBoxCondition_MDF.TabStop = false;
            groupBoxCondition_MDF.Text = "Условие";
            // 
            // textBoxOutput_MDF
            // 
            textBoxOutput_MDF.Dock = DockStyle.Fill;
            textBoxOutput_MDF.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxOutput_MDF.ImeMode = ImeMode.NoControl;
            textBoxOutput_MDF.Location = new Point(5, 21);
            textBoxOutput_MDF.Multiline = true;
            textBoxOutput_MDF.Name = "textBoxOutput_MDF";
            textBoxOutput_MDF.ReadOnly = true;
            textBoxOutput_MDF.ScrollBars = ScrollBars.Vertical;
            textBoxOutput_MDF.Size = new Size(302, 364);
            textBoxOutput_MDF.TabIndex = 5;
            // 
            // groupBoxOutput_MDF
            // 
            groupBoxOutput_MDF.Controls.Add(textBoxOutput_MDF);
            groupBoxOutput_MDF.Dock = DockStyle.Fill;
            groupBoxOutput_MDF.Location = new Point(5, 5);
            groupBoxOutput_MDF.Name = "groupBoxOutput_MDF";
            groupBoxOutput_MDF.Padding = new Padding(5);
            groupBoxOutput_MDF.Size = new Size(312, 390);
            groupBoxOutput_MDF.TabIndex = 11;
            groupBoxOutput_MDF.TabStop = false;
            groupBoxOutput_MDF.Text = "Вывод данных";
            // 
            // chart_MDF
            // 
            chart_MDF.AccessibleName = "";
            chartArea1.Name = "ChartArea1";
            chart_MDF.ChartAreas.Add(chartArea1);
            chart_MDF.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chart_MDF.Legends.Add(legend1);
            chart_MDF.Location = new Point(5, 5);
            chart_MDF.Name = "chart_MDF";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart_MDF.Series.Add(series1);
            chart_MDF.Size = new Size(698, 390);
            chart_MDF.TabIndex = 12;
            title1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            title1.ForeColor = Color.RoyalBlue;
            title1.Name = "title1";
            title1.Text = "Крутая функция с тригонометрией";
            chart_MDF.Titles.Add(title1);
            // 
            // panelLeft_MDF
            // 
            panelLeft_MDF.Controls.Add(groupBoxOutput_MDF);
            panelLeft_MDF.Dock = DockStyle.Left;
            panelLeft_MDF.Location = new Point(0, 165);
            panelLeft_MDF.Name = "panelLeft_MDF";
            panelLeft_MDF.Padding = new Padding(5);
            panelLeft_MDF.Size = new Size(322, 400);
            panelLeft_MDF.TabIndex = 13;
            // 
            // panelUp_MDF
            // 
            panelUp_MDF.Controls.Add(groupBoxInput_MDF);
            panelUp_MDF.Controls.Add(groupBoxCondition_MDF);
            panelUp_MDF.Controls.Add(groupBoxManagment_MDF);
            panelUp_MDF.Dock = DockStyle.Top;
            panelUp_MDF.Location = new Point(0, 0);
            panelUp_MDF.Name = "panelUp_MDF";
            panelUp_MDF.Padding = new Padding(5);
            panelUp_MDF.Size = new Size(1030, 165);
            panelUp_MDF.TabIndex = 14;
            // 
            // panelCenter_MDF
            // 
            panelCenter_MDF.Controls.Add(chart_MDF);
            panelCenter_MDF.Dock = DockStyle.Fill;
            panelCenter_MDF.Location = new Point(322, 165);
            panelCenter_MDF.Name = "panelCenter_MDF";
            panelCenter_MDF.Padding = new Padding(5);
            panelCenter_MDF.Size = new Size(708, 400);
            panelCenter_MDF.TabIndex = 15;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1030, 565);
            Controls.Add(panelCenter_MDF);
            Controls.Add(panelLeft_MDF);
            Controls.Add(panelUp_MDF);
            MinimumSize = new Size(1046, 592);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 4 | Вариант 28 | Минуллин Д.Ф.";
            groupBoxManagment_MDF.ResumeLayout(false);
            groupBoxInput_MDF.ResumeLayout(false);
            groupBoxInput_MDF.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBoxCondition_MDF.ResumeLayout(false);
            groupBoxOutput_MDF.ResumeLayout(false);
            groupBoxOutput_MDF.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chart_MDF).EndInit();
            panelLeft_MDF.ResumeLayout(false);
            panelUp_MDF.ResumeLayout(false);
            panelCenter_MDF.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button buttonDone_MDF;
        private Button buttonInfo_MDF;
        private GroupBox groupBoxManagment_MDF;
        private Button buttonSave_MDF;
        private Label labelEndValue_MDF;
        private TextBox textBoxEndValue_MDF;
        private TextBox textBoxStartValue_MDF;
        private Label labelStartValue_MDF;
        private GroupBox groupBoxInput_MDF;
        private PictureBox pictureBox1;
        private GroupBox groupBoxCondition_MDF;
        private TextBox textBoxOutput_MDF;
        private GroupBox groupBoxOutput_MDF;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_MDF;
        private Panel panelLeft_MDF;
        private Panel panelUp_MDF;
        private Panel panelCenter_MDF;
    }
}
