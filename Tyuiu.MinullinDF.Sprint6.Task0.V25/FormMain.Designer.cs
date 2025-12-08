namespace Tyuiu.MinullinDF.Sprint6.Task0.V25
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
            textBoxInput_MDF = new TextBox();
            labelVariableX_MDF = new Label();
            pictureBoxCondition_MDF = new PictureBox();
            groupBoxCondition_MDF = new GroupBox();
            textBoxCondition_MDF = new TextBox();
            groupBoxInput_MDF = new GroupBox();
            groupBoxOutput_MDF = new GroupBox();
            labelResult_MDF = new Label();
            textBoxOutput_MDF = new TextBox();
            buttonDone_MDF = new Button();
            buttonQuestion_MDF = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCondition_MDF).BeginInit();
            groupBoxCondition_MDF.SuspendLayout();
            groupBoxInput_MDF.SuspendLayout();
            groupBoxOutput_MDF.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxInput_MDF
            // 
            textBoxInput_MDF.Location = new Point(20, 58);
            textBoxInput_MDF.Name = "textBoxInput_MDF";
            textBoxInput_MDF.Size = new Size(100, 23);
            textBoxInput_MDF.TabIndex = 1;
            textBoxInput_MDF.KeyPress += textBoxInput_MDF_KeyPress;
            // 
            // labelVariableX_MDF
            // 
            labelVariableX_MDF.AutoSize = true;
            labelVariableX_MDF.Location = new Point(20, 19);
            labelVariableX_MDF.Name = "labelVariableX_MDF";
            labelVariableX_MDF.Size = new Size(89, 15);
            labelVariableX_MDF.TabIndex = 2;
            labelVariableX_MDF.Text = "Переменная X:";
            // 
            // pictureBoxCondition_MDF
            // 
            pictureBoxCondition_MDF.Image = Properties.Resources.Task0_V25;
            pictureBoxCondition_MDF.Location = new Point(252, 22);
            pictureBoxCondition_MDF.Name = "pictureBoxCondition_MDF";
            pictureBoxCondition_MDF.Size = new Size(144, 62);
            pictureBoxCondition_MDF.TabIndex = 7;
            pictureBoxCondition_MDF.TabStop = false;
            // 
            // groupBoxCondition_MDF
            // 
            groupBoxCondition_MDF.Controls.Add(textBoxCondition_MDF);
            groupBoxCondition_MDF.Controls.Add(pictureBoxCondition_MDF);
            groupBoxCondition_MDF.Location = new Point(12, 12);
            groupBoxCondition_MDF.Name = "groupBoxCondition_MDF";
            groupBoxCondition_MDF.Size = new Size(406, 232);
            groupBoxCondition_MDF.TabIndex = 8;
            groupBoxCondition_MDF.TabStop = false;
            groupBoxCondition_MDF.Text = "Условие:";
            // 
            // textBoxCondition_MDF
            // 
            textBoxCondition_MDF.Location = new Point(6, 22);
            textBoxCondition_MDF.Multiline = true;
            textBoxCondition_MDF.Name = "textBoxCondition_MDF";
            textBoxCondition_MDF.ReadOnly = true;
            textBoxCondition_MDF.Size = new Size(245, 204);
            textBoxCondition_MDF.TabIndex = 0;
            textBoxCondition_MDF.Text = "Дано выражение вычислить его значение при x = 3, результат вывести в TextBox. Округлить до трёх знаков после запятой. Графический интерфейс оформить по шаблону из лекции.";
            // 
            // groupBoxInput_MDF
            // 
            groupBoxInput_MDF.Controls.Add(labelVariableX_MDF);
            groupBoxInput_MDF.Controls.Add(textBoxInput_MDF);
            groupBoxInput_MDF.Location = new Point(12, 268);
            groupBoxInput_MDF.Name = "groupBoxInput_MDF";
            groupBoxInput_MDF.Size = new Size(200, 100);
            groupBoxInput_MDF.TabIndex = 9;
            groupBoxInput_MDF.TabStop = false;
            groupBoxInput_MDF.Text = "Ввод данных:";
            // 
            // groupBoxOutput_MDF
            // 
            groupBoxOutput_MDF.Controls.Add(labelResult_MDF);
            groupBoxOutput_MDF.Controls.Add(textBoxOutput_MDF);
            groupBoxOutput_MDF.Location = new Point(218, 268);
            groupBoxOutput_MDF.Name = "groupBoxOutput_MDF";
            groupBoxOutput_MDF.Size = new Size(200, 100);
            groupBoxOutput_MDF.TabIndex = 10;
            groupBoxOutput_MDF.TabStop = false;
            groupBoxOutput_MDF.Text = "Вывод данных:";
            // 
            // labelResult_MDF
            // 
            labelResult_MDF.AutoSize = true;
            labelResult_MDF.Location = new Point(20, 19);
            labelResult_MDF.Name = "labelResult_MDF";
            labelResult_MDF.Size = new Size(63, 15);
            labelResult_MDF.TabIndex = 2;
            labelResult_MDF.Text = "Результат:";
            // 
            // textBoxOutput_MDF
            // 
            textBoxOutput_MDF.Location = new Point(20, 58);
            textBoxOutput_MDF.Name = "textBoxOutput_MDF";
            textBoxOutput_MDF.ReadOnly = true;
            textBoxOutput_MDF.Size = new Size(100, 23);
            textBoxOutput_MDF.TabIndex = 1;
            // 
            // buttonDone_MDF
            // 
            buttonDone_MDF.Location = new Point(269, 374);
            buttonDone_MDF.Name = "buttonDone_MDF";
            buttonDone_MDF.Size = new Size(150, 46);
            buttonDone_MDF.TabIndex = 11;
            buttonDone_MDF.Text = "Выполнить";
            buttonDone_MDF.UseVisualStyleBackColor = true;
            buttonDone_MDF.Click += buttonDone_MDF_Click;
            // 
            // buttonQuestion_MDF
            // 
            buttonQuestion_MDF.BackColor = SystemColors.HighlightText;
            buttonQuestion_MDF.FlatStyle = FlatStyle.Flat;
            buttonQuestion_MDF.Location = new Point(218, 374);
            buttonQuestion_MDF.Name = "buttonQuestion_MDF";
            buttonQuestion_MDF.Size = new Size(46, 46);
            buttonQuestion_MDF.TabIndex = 12;
            buttonQuestion_MDF.Text = "?";
            buttonQuestion_MDF.UseVisualStyleBackColor = false;
            buttonQuestion_MDF.Click += buttonQuestion_MDF_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 432);
            Controls.Add(buttonQuestion_MDF);
            Controls.Add(buttonDone_MDF);
            Controls.Add(groupBoxOutput_MDF);
            Controls.Add(groupBoxInput_MDF);
            Controls.Add(groupBoxCondition_MDF);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormMain";
            Text = "Спринт 6 | Таск 0 | Вариант 25 | Минуллин Д.Ф.";
            ((System.ComponentModel.ISupportInitialize)pictureBoxCondition_MDF).EndInit();
            groupBoxCondition_MDF.ResumeLayout(false);
            groupBoxCondition_MDF.PerformLayout();
            groupBoxInput_MDF.ResumeLayout(false);
            groupBoxInput_MDF.PerformLayout();
            groupBoxOutput_MDF.ResumeLayout(false);
            groupBoxOutput_MDF.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox textBoxInput_MDF;
        private Label labelVariableX_MDF;
        private PictureBox pictureBoxCondition_MDF;
        private GroupBox groupBoxCondition_MDF;
        private TextBox textBoxCondition_MDF;
        private GroupBox groupBoxInput_MDF;
        private GroupBox groupBoxOutput_MDF;
        private Label labelResult_MDF;
        private TextBox textBoxOutput_MDF;
        private Button buttonDone_MDF;
        private Button buttonQuestion_MDF;
    }
}
