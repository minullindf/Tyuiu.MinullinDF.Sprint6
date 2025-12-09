namespace Tyuiu.MinullinDF.Sprint6.Task5.V12
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panelTopSide_MDF = new Panel();
            buttonDone_MDF = new Button();
            buttonOpenF_MDF = new Button();
            buttonHelp_MDF = new Button();
            groupBoxTask_MDF = new GroupBox();
            textBox1 = new TextBox();
            panelLeftSide_MDF = new Panel();
            groupBoxOutPut_MDF = new GroupBox();
            dataGridViewResult_MDF = new DataGridView();
            panelFill_MDF = new Panel();
            chartFunction_MDF = new System.Windows.Forms.DataVisualization.Charting.Chart();
            splitter1 = new Splitter();
            panelTopSide_MDF.SuspendLayout();
            groupBoxTask_MDF.SuspendLayout();
            panelLeftSide_MDF.SuspendLayout();
            groupBoxOutPut_MDF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_MDF).BeginInit();
            panelFill_MDF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_MDF).BeginInit();
            SuspendLayout();
            // 
            // panelTopSide_MDF
            // 
            panelTopSide_MDF.Controls.Add(buttonDone_MDF);
            panelTopSide_MDF.Controls.Add(buttonOpenF_MDF);
            panelTopSide_MDF.Controls.Add(buttonHelp_MDF);
            panelTopSide_MDF.Controls.Add(groupBoxTask_MDF);
            panelTopSide_MDF.Dock = DockStyle.Top;
            panelTopSide_MDF.Location = new Point(0, 0);
            panelTopSide_MDF.Margin = new Padding(4, 3, 4, 3);
            panelTopSide_MDF.Name = "panelTopSide_MDF";
            panelTopSide_MDF.Size = new Size(1022, 115);
            panelTopSide_MDF.TabIndex = 0;
            // 
            // buttonDone_MDF
            // 
            buttonDone_MDF.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonDone_MDF.BackColor = Color.Green;
            buttonDone_MDF.Location = new Point(697, 29);
            buttonDone_MDF.Margin = new Padding(4, 3, 4, 3);
            buttonDone_MDF.Name = "buttonDone_MDF";
            buttonDone_MDF.Size = new Size(99, 65);
            buttonDone_MDF.TabIndex = 3;
            buttonDone_MDF.Text = "Выполнить";
            buttonDone_MDF.UseVisualStyleBackColor = false;
            buttonDone_MDF.Click += buttonDone_MDF_Click;
            // 
            // buttonOpenF_MDF
            // 
            buttonOpenF_MDF.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonOpenF_MDF.BackColor = Color.RoyalBlue;
            buttonOpenF_MDF.Location = new Point(803, 29);
            buttonOpenF_MDF.Margin = new Padding(4, 3, 4, 3);
            buttonOpenF_MDF.Name = "buttonOpenF_MDF";
            buttonOpenF_MDF.Size = new Size(99, 65);
            buttonOpenF_MDF.TabIndex = 2;
            buttonOpenF_MDF.Text = "Открыть Файл";
            buttonOpenF_MDF.UseVisualStyleBackColor = false;
            buttonOpenF_MDF.Click += buttonOpenF_MDF_Click;
            // 
            // buttonHelp_MDF
            // 
            buttonHelp_MDF.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_MDF.BackColor = SystemColors.MenuHighlight;
            buttonHelp_MDF.Location = new Point(910, 29);
            buttonHelp_MDF.Margin = new Padding(4, 3, 4, 3);
            buttonHelp_MDF.Name = "buttonHelp_MDF";
            buttonHelp_MDF.Size = new Size(98, 65);
            buttonHelp_MDF.TabIndex = 1;
            buttonHelp_MDF.Text = "Справка";
            buttonHelp_MDF.UseVisualStyleBackColor = false;
            buttonHelp_MDF.Click += buttonHelp_MDF_Click;
            // 
            // groupBoxTask_MDF
            // 
            groupBoxTask_MDF.Controls.Add(textBox1);
            groupBoxTask_MDF.Location = new Point(14, 14);
            groupBoxTask_MDF.Margin = new Padding(4, 3, 4, 3);
            groupBoxTask_MDF.Name = "groupBoxTask_MDF";
            groupBoxTask_MDF.Padding = new Padding(4, 3, 4, 3);
            groupBoxTask_MDF.Size = new Size(642, 87);
            groupBoxTask_MDF.TabIndex = 0;
            groupBoxTask_MDF.TabStop = false;
            groupBoxTask_MDF.Text = "Условие";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(7, 22);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(627, 57);
            textBox1.TabIndex = 0;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // panelLeftSide_MDF
            // 
            panelLeftSide_MDF.Controls.Add(groupBoxOutPut_MDF);
            panelLeftSide_MDF.Dock = DockStyle.Left;
            panelLeftSide_MDF.Location = new Point(0, 115);
            panelLeftSide_MDF.Margin = new Padding(4, 3, 4, 3);
            panelLeftSide_MDF.Name = "panelLeftSide_MDF";
            panelLeftSide_MDF.Padding = new Padding(10);
            panelLeftSide_MDF.Size = new Size(158, 513);
            panelLeftSide_MDF.TabIndex = 1;
            // 
            // groupBoxOutPut_MDF
            // 
            groupBoxOutPut_MDF.Controls.Add(dataGridViewResult_MDF);
            groupBoxOutPut_MDF.Dock = DockStyle.Fill;
            groupBoxOutPut_MDF.Location = new Point(10, 10);
            groupBoxOutPut_MDF.Margin = new Padding(4, 3, 4, 3);
            groupBoxOutPut_MDF.Name = "groupBoxOutPut_MDF";
            groupBoxOutPut_MDF.Padding = new Padding(4, 3, 4, 3);
            groupBoxOutPut_MDF.Size = new Size(138, 493);
            groupBoxOutPut_MDF.TabIndex = 0;
            groupBoxOutPut_MDF.TabStop = false;
            groupBoxOutPut_MDF.Text = "Вывод Данных:";
            // 
            // dataGridViewResult_MDF
            // 
            dataGridViewResult_MDF.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_MDF.Dock = DockStyle.Fill;
            dataGridViewResult_MDF.Location = new Point(4, 19);
            dataGridViewResult_MDF.Margin = new Padding(4, 3, 4, 3);
            dataGridViewResult_MDF.Name = "dataGridViewResult_MDF";
            dataGridViewResult_MDF.Size = new Size(130, 471);
            dataGridViewResult_MDF.TabIndex = 1;
            // 
            // panelFill_MDF
            // 
            panelFill_MDF.Controls.Add(chartFunction_MDF);
            panelFill_MDF.Controls.Add(splitter1);
            panelFill_MDF.Dock = DockStyle.Fill;
            panelFill_MDF.Location = new Point(158, 115);
            panelFill_MDF.Margin = new Padding(4, 3, 4, 3);
            panelFill_MDF.Name = "panelFill_MDF";
            panelFill_MDF.Padding = new Padding(10);
            panelFill_MDF.Size = new Size(864, 513);
            panelFill_MDF.TabIndex = 2;
            // 
            // chartFunction_MDF
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_MDF.ChartAreas.Add(chartArea1);
            chartFunction_MDF.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartFunction_MDF.Legends.Add(legend1);
            chartFunction_MDF.Location = new Point(22, 10);
            chartFunction_MDF.Margin = new Padding(4, 3, 4, 3);
            chartFunction_MDF.Name = "chartFunction_MDF";
            chartFunction_MDF.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_MDF.Series.Add(series1);
            chartFunction_MDF.Size = new Size(832, 493);
            chartFunction_MDF.TabIndex = 1;
            chartFunction_MDF.Text = "chartFunc_MDF";
            // 
            // splitter1
            // 
            splitter1.Location = new Point(10, 10);
            splitter1.Margin = new Padding(4, 3, 4, 3);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(12, 493);
            splitter1.TabIndex = 0;
            splitter1.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 628);
            Controls.Add(panelFill_MDF);
            Controls.Add(panelLeftSide_MDF);
            Controls.Add(panelTopSide_MDF);
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(1001, 667);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 5 | Вариант 12 | Минуллин Д.Ф.";
            panelTopSide_MDF.ResumeLayout(false);
            groupBoxTask_MDF.ResumeLayout(false);
            groupBoxTask_MDF.PerformLayout();
            panelLeftSide_MDF.ResumeLayout(false);
            groupBoxOutPut_MDF.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_MDF).EndInit();
            panelFill_MDF.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartFunction_MDF).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTopSide_MDF;
        private System.Windows.Forms.Button buttonDone_MDF;
        private System.Windows.Forms.Button buttonOpenF_MDF;
        private System.Windows.Forms.Button buttonHelp_MDF;
        private System.Windows.Forms.GroupBox groupBoxTask_MDF;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panelLeftSide_MDF;
        private System.Windows.Forms.GroupBox groupBoxOutPut_MDF;
        private System.Windows.Forms.Panel panelFill_MDF;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_MDF;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.DataGridView dataGridViewResult_MDF;
    }
}
