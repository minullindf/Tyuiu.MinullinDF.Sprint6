namespace Tyuiu.MinullinDF.Sprint6.Task3.V2
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
            groupBoxCondition_MDF = new GroupBox();
            textBoxCondition_MDF = new TextBox();
            dataGridView_MDF = new DataGridView();
            groupBoxInput_MDF = new GroupBox();
            textBoxResult_MDF = new TextBox();
            labelStartValue_MDF = new Label();
            buttonQuestion_MDF = new Button();
            buttonDone_MDF = new Button();
            groupBoxCondition_MDF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_MDF).BeginInit();
            groupBoxInput_MDF.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxCondition_MDF
            // 
            groupBoxCondition_MDF.Controls.Add(textBoxCondition_MDF);
            groupBoxCondition_MDF.Controls.Add(dataGridView_MDF);
            groupBoxCondition_MDF.Location = new Point(12, 12);
            groupBoxCondition_MDF.Name = "groupBoxCondition_MDF";
            groupBoxCondition_MDF.Size = new Size(525, 292);
            groupBoxCondition_MDF.TabIndex = 5;
            groupBoxCondition_MDF.TabStop = false;
            groupBoxCondition_MDF.Text = "Условие";
            // 
            // textBoxCondition_MDF
            // 
            textBoxCondition_MDF.Location = new Point(6, 22);
            textBoxCondition_MDF.Multiline = true;
            textBoxCondition_MDF.Name = "textBoxCondition_MDF";
            textBoxCondition_MDF.ReadOnly = true;
            textBoxCondition_MDF.Size = new Size(294, 264);
            textBoxCondition_MDF.TabIndex = 0;
            textBoxCondition_MDF.Text = resources.GetString("textBoxCondition_MDF.Text");
            // 
            // dataGridView_MDF
            // 
            dataGridView_MDF.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_MDF.ColumnHeadersVisible = false;
            dataGridView_MDF.Location = new Point(306, 23);
            dataGridView_MDF.Name = "dataGridView_MDF";
            dataGridView_MDF.RowHeadersVisible = false;
            dataGridView_MDF.Size = new Size(213, 263);
            dataGridView_MDF.TabIndex = 6;
            // 
            // groupBoxInput_MDF
            // 
            groupBoxInput_MDF.Controls.Add(textBoxResult_MDF);
            groupBoxInput_MDF.Controls.Add(labelStartValue_MDF);
            groupBoxInput_MDF.Location = new Point(543, 12);
            groupBoxInput_MDF.Name = "groupBoxInput_MDF";
            groupBoxInput_MDF.Size = new Size(162, 78);
            groupBoxInput_MDF.TabIndex = 7;
            groupBoxInput_MDF.TabStop = false;
            groupBoxInput_MDF.Text = "Ввод данных";
            // 
            // textBoxResult_MDF
            // 
            textBoxResult_MDF.Location = new Point(6, 40);
            textBoxResult_MDF.Name = "textBoxResult_MDF";
            textBoxResult_MDF.ReadOnly = true;
            textBoxResult_MDF.Size = new Size(129, 23);
            textBoxResult_MDF.TabIndex = 1;
            // 
            // labelStartValue_MDF
            // 
            labelStartValue_MDF.AutoSize = true;
            labelStartValue_MDF.Location = new Point(7, 23);
            labelStartValue_MDF.Name = "labelStartValue_MDF";
            labelStartValue_MDF.Size = new Size(63, 15);
            labelStartValue_MDF.TabIndex = 0;
            labelStartValue_MDF.Text = "Результат:";
            // 
            // buttonQuestion_MDF
            // 
            buttonQuestion_MDF.BackColor = SystemColors.HighlightText;
            buttonQuestion_MDF.FlatStyle = FlatStyle.Flat;
            buttonQuestion_MDF.Location = new Point(543, 258);
            buttonQuestion_MDF.Name = "buttonQuestion_MDF";
            buttonQuestion_MDF.Size = new Size(45, 46);
            buttonQuestion_MDF.TabIndex = 14;
            buttonQuestion_MDF.Text = "?";
            buttonQuestion_MDF.UseVisualStyleBackColor = false;
            buttonQuestion_MDF.Click += buttonQuestion_MDF_Click;
            // 
            // buttonDone_MDF
            // 
            buttonDone_MDF.Location = new Point(594, 258);
            buttonDone_MDF.Name = "buttonDone_MDF";
            buttonDone_MDF.Size = new Size(111, 46);
            buttonDone_MDF.TabIndex = 13;
            buttonDone_MDF.Text = "Выполнить";
            buttonDone_MDF.UseVisualStyleBackColor = true;
            buttonDone_MDF.Click += buttonDone_MDF_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(713, 313);
            Controls.Add(buttonQuestion_MDF);
            Controls.Add(groupBoxInput_MDF);
            Controls.Add(buttonDone_MDF);
            Controls.Add(groupBoxCondition_MDF);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormMain";
            Text = "Спринт 6 | Таск 3 | Вариант 2 | Минуллин Д.Ф.";
            Load += FormMain_MDF_Load;
            groupBoxCondition_MDF.ResumeLayout(false);
            groupBoxCondition_MDF.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_MDF).EndInit();
            groupBoxInput_MDF.ResumeLayout(false);
            groupBoxInput_MDF.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition_MDF;
        private TextBox textBoxCondition_MDF;
        private DataGridView dataGridView_MDF;
        private GroupBox groupBoxInput_MDF;
        private TextBox textBoxResult_MDF;
        private Label labelStartValue_MDF;
        private Button buttonQuestion_MDF;
        private Button buttonDone_MDF;
    }
}
