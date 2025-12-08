namespace Tyuiu.MinullinDF.Sprint6.Task2.V3
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxCondition_MDF = new GroupBox();
            pictureBox1 = new PictureBox();
            groupBoxOutput_MDF = new GroupBox();
            chart_MDF = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridView_MDF = new DataGridView();
            ColumnX_MDF = new DataGridViewTextBoxColumn();
            ColumnFX_MDF = new DataGridViewTextBoxColumn();
            groupBoxInput_MDF = new GroupBox();
            labelEndValue_MDF = new Label();
            textBoxEndValue_MDF = new TextBox();
            textBoxStartValue_MDF = new TextBox();
            labelStartValue_MDF = new Label();
            groupBoxManagment_MDF = new GroupBox();
            buttonDone_MDF = new Button();
            buttonInfo_MDF = new Button();
            groupBoxCondition_MDF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBoxOutput_MDF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart_MDF).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_MDF).BeginInit();
            groupBoxInput_MDF.SuspendLayout();
            groupBoxManagment_MDF.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxCondition_MDF
            // 
            groupBoxCondition_MDF.Controls.Add(pictureBox1);
            groupBoxCondition_MDF.Location = new Point(12, 37);
            groupBoxCondition_MDF.Name = "groupBoxCondition_MDF";
            groupBoxCondition_MDF.Size = new Size(453, 292);
            groupBoxCondition_MDF.TabIndex = 4;
            groupBoxCondition_MDF.TabStop = false;
            groupBoxCondition_MDF.Text = "Условие";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = Properties.Resources.Task3_V3;
            pictureBox1.Location = new Point(6, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(441, 264);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // groupBoxOutput_MDF
            // 
            groupBoxOutput_MDF.Controls.Add(chart_MDF);
            groupBoxOutput_MDF.Controls.Add(dataGridView_MDF);
            groupBoxOutput_MDF.Location = new Point(471, 37);
            groupBoxOutput_MDF.Name = "groupBoxOutput_MDF";
            groupBoxOutput_MDF.Size = new Size(611, 377);
            groupBoxOutput_MDF.TabIndex = 5;
            groupBoxOutput_MDF.TabStop = false;
            groupBoxOutput_MDF.Text = "Вывод данных";
            // 
            // chart_MDF
            // 
            chartArea5.Name = "ChartArea1";
            chart_MDF.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            chart_MDF.Legends.Add(legend5);
            chart_MDF.Location = new Point(127, 22);
            chart_MDF.Name = "chart_MDF";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.IsVisibleInLegend = false;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            chart_MDF.Series.Add(series5);
            chart_MDF.Size = new Size(478, 349);
            chart_MDF.TabIndex = 1;
            chart_MDF.Text = "chart1";
            // 
            // dataGridView_MDF
            // 
            dataGridView_MDF.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_MDF.Columns.AddRange(new DataGridViewColumn[] { ColumnX_MDF, ColumnFX_MDF });
            dataGridView_MDF.Location = new Point(6, 22);
            dataGridView_MDF.Name = "dataGridView_MDF";
            dataGridView_MDF.RowHeadersVisible = false;
            dataGridView_MDF.Size = new Size(115, 349);
            dataGridView_MDF.TabIndex = 0;
            // 
            // ColumnX_MDF
            // 
            ColumnX_MDF.HeaderText = "X";
            ColumnX_MDF.Name = "ColumnX_MDF";
            ColumnX_MDF.Width = 50;
            // 
            // ColumnFX_MDF
            // 
            ColumnFX_MDF.HeaderText = "f(X)";
            ColumnFX_MDF.Name = "ColumnFX_MDF";
            ColumnFX_MDF.Width = 50;
            // 
            // groupBoxInput_MDF
            // 
            groupBoxInput_MDF.Controls.Add(labelEndValue_MDF);
            groupBoxInput_MDF.Controls.Add(textBoxEndValue_MDF);
            groupBoxInput_MDF.Controls.Add(textBoxStartValue_MDF);
            groupBoxInput_MDF.Controls.Add(labelStartValue_MDF);
            groupBoxInput_MDF.Location = new Point(12, 336);
            groupBoxInput_MDF.Name = "groupBoxInput_MDF";
            groupBoxInput_MDF.Size = new Size(280, 78);
            groupBoxInput_MDF.TabIndex = 6;
            groupBoxInput_MDF.TabStop = false;
            groupBoxInput_MDF.Text = "Ввод данных";
            // 
            // labelEndValue_MDF
            // 
            labelEndValue_MDF.AutoSize = true;
            labelEndValue_MDF.Location = new Point(146, 23);
            labelEndValue_MDF.Name = "labelEndValue_MDF";
            labelEndValue_MDF.Size = new Size(75, 15);
            labelEndValue_MDF.TabIndex = 3;
            labelEndValue_MDF.Text = "Конец шага:";
            // 
            // textBoxEndValue_MDF
            // 
            textBoxEndValue_MDF.Location = new Point(145, 40);
            textBoxEndValue_MDF.Name = "textBoxEndValue_MDF";
            textBoxEndValue_MDF.Size = new Size(129, 23);
            textBoxEndValue_MDF.TabIndex = 2;
            // 
            // textBoxStartValue_MDF
            // 
            textBoxStartValue_MDF.Location = new Point(6, 40);
            textBoxStartValue_MDF.Name = "textBoxStartValue_MDF";
            textBoxStartValue_MDF.Size = new Size(129, 23);
            textBoxStartValue_MDF.TabIndex = 1;
            // 
            // labelStartValue_MDF
            // 
            labelStartValue_MDF.AutoSize = true;
            labelStartValue_MDF.Location = new Point(7, 23);
            labelStartValue_MDF.Name = "labelStartValue_MDF";
            labelStartValue_MDF.Size = new Size(72, 15);
            labelStartValue_MDF.TabIndex = 0;
            labelStartValue_MDF.Text = "Старт шага:";
            // 
            // groupBoxManagment_MDF
            // 
            groupBoxManagment_MDF.Controls.Add(buttonDone_MDF);
            groupBoxManagment_MDF.Controls.Add(buttonInfo_MDF);
            groupBoxManagment_MDF.Location = new Point(299, 336);
            groupBoxManagment_MDF.Name = "groupBoxManagment_MDF";
            groupBoxManagment_MDF.Size = new Size(167, 78);
            groupBoxManagment_MDF.TabIndex = 7;
            groupBoxManagment_MDF.TabStop = false;
            groupBoxManagment_MDF.Text = "Управление";
            // 
            // buttonDone_MDF
            // 
            buttonDone_MDF.BackColor = SystemColors.Desktop;
            buttonDone_MDF.Location = new Point(73, 21);
            buttonDone_MDF.Name = "buttonDone_MDF";
            buttonDone_MDF.Size = new Size(88, 51);
            buttonDone_MDF.TabIndex = 1;
            buttonDone_MDF.Text = "Выполнить";
            buttonDone_MDF.UseVisualStyleBackColor = false;
            buttonDone_MDF.Click += buttonDone_MDF_Click;
            buttonDone_MDF.MouseDown += buttonDone_MDF_MouseDown;
            buttonDone_MDF.MouseEnter += buttonDone_MDF_MouseEnter;
            buttonDone_MDF.MouseLeave += buttonDone_MDF_MouseLeave;
            // 
            // buttonInfo_MDF
            // 
            buttonInfo_MDF.BackColor = SystemColors.Highlight;
            buttonInfo_MDF.Location = new Point(6, 21);
            buttonInfo_MDF.Name = "buttonInfo_MDF";
            buttonInfo_MDF.Size = new Size(61, 51);
            buttonInfo_MDF.TabIndex = 0;
            buttonInfo_MDF.Text = "Справка";
            buttonInfo_MDF.UseVisualStyleBackColor = false;
            buttonInfo_MDF.Click += buttonInfo_MDF_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1094, 450);
            Controls.Add(groupBoxCondition_MDF);
            Controls.Add(groupBoxOutput_MDF);
            Controls.Add(groupBoxInput_MDF);
            Controls.Add(groupBoxManagment_MDF);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 2 | Вариант 3 | Минуллин Д.Ф.";
            groupBoxCondition_MDF.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBoxOutput_MDF.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chart_MDF).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_MDF).EndInit();
            groupBoxInput_MDF.ResumeLayout(false);
            groupBoxInput_MDF.PerformLayout();
            groupBoxManagment_MDF.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition_MDF;
        private PictureBox pictureBox1;
        private GroupBox groupBoxOutput_MDF;
        private GroupBox groupBoxInput_MDF;
        private Label labelEndValue_MDF;
        private TextBox textBoxEndValue_MDF;
        private TextBox textBoxStartValue_MDF;
        private Label labelStartValue_MDF;
        private GroupBox groupBoxManagment_MDF;
        private Button buttonDone_MDF;
        private Button buttonInfo_MDF;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_MDF;
        private DataGridView dataGridView_MDF;
        private DataGridViewTextBoxColumn ColumnX_MDF;
        private DataGridViewTextBoxColumn ColumnFX_MDF;
    }
}
