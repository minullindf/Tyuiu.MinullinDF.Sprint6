namespace Tyuiu.MinullinDF.Sprint6.Task1.V7
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
            groupBoxCondition_MDF = new GroupBox();
            pictureBox1 = new PictureBox();
            groupBoxOutput_MDF = new GroupBox();
            textBoxOutput_MDF = new TextBox();
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
            groupBoxInput_MDF.SuspendLayout();
            groupBoxManagment_MDF.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxCondition_MDF
            // 
            groupBoxCondition_MDF.Controls.Add(pictureBox1);
            groupBoxCondition_MDF.Location = new Point(12, 12);
            groupBoxCondition_MDF.Name = "groupBoxCondition_MDF";
            groupBoxCondition_MDF.Size = new Size(453, 292);
            groupBoxCondition_MDF.TabIndex = 0;
            groupBoxCondition_MDF.TabStop = false;
            groupBoxCondition_MDF.Text = "Условие";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = Properties.Resources.Task1_V7;
            pictureBox1.Location = new Point(6, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(441, 264);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // groupBoxOutput_MDF
            // 
            groupBoxOutput_MDF.Controls.Add(textBoxOutput_MDF);
            groupBoxOutput_MDF.Location = new Point(471, 12);
            groupBoxOutput_MDF.Name = "groupBoxOutput_MDF";
            groupBoxOutput_MDF.Size = new Size(317, 377);
            groupBoxOutput_MDF.TabIndex = 1;
            groupBoxOutput_MDF.TabStop = false;
            groupBoxOutput_MDF.Text = "Вывод данных";
            // 
            // textBoxOutput_MDF
            // 
            textBoxOutput_MDF.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxOutput_MDF.ImeMode = ImeMode.NoControl;
            textBoxOutput_MDF.Location = new Point(6, 22);
            textBoxOutput_MDF.Multiline = true;
            textBoxOutput_MDF.Name = "textBoxOutput_MDF";
            textBoxOutput_MDF.ReadOnly = true;
            textBoxOutput_MDF.ScrollBars = ScrollBars.Vertical;
            textBoxOutput_MDF.Size = new Size(305, 349);
            textBoxOutput_MDF.TabIndex = 5;
            // 
            // groupBoxInput_MDF
            // 
            groupBoxInput_MDF.Controls.Add(labelEndValue_MDF);
            groupBoxInput_MDF.Controls.Add(textBoxEndValue_MDF);
            groupBoxInput_MDF.Controls.Add(textBoxStartValue_MDF);
            groupBoxInput_MDF.Controls.Add(labelStartValue_MDF);
            groupBoxInput_MDF.Location = new Point(12, 311);
            groupBoxInput_MDF.Name = "groupBoxInput_MDF";
            groupBoxInput_MDF.Size = new Size(280, 78);
            groupBoxInput_MDF.TabIndex = 2;
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
            groupBoxManagment_MDF.Location = new Point(299, 311);
            groupBoxManagment_MDF.Name = "groupBoxManagment_MDF";
            groupBoxManagment_MDF.Size = new Size(167, 78);
            groupBoxManagment_MDF.TabIndex = 3;
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
            ClientSize = new Size(800, 399);
            Controls.Add(groupBoxManagment_MDF);
            Controls.Add(groupBoxInput_MDF);
            Controls.Add(groupBoxOutput_MDF);
            Controls.Add(groupBoxCondition_MDF);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormMain";
            Text = "Спринт 6 | Таск 1 | Вариант 7 | Минуллин Д.Ф.";
            groupBoxCondition_MDF.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBoxOutput_MDF.ResumeLayout(false);
            groupBoxOutput_MDF.PerformLayout();
            groupBoxInput_MDF.ResumeLayout(false);
            groupBoxInput_MDF.PerformLayout();
            groupBoxManagment_MDF.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition_MDF;
        private GroupBox groupBoxOutput_MDF;
        private GroupBox groupBoxInput_MDF;
        private TextBox textBoxStartValue_MDF;
        private Label labelStartValue_MDF;
        private GroupBox groupBoxManagment_MDF;
        private Button buttonDone_MDF;
        private Button buttonInfo_MDF;
        private TextBox textBoxOutput_MDF;
        private Label labelEndValue_MDF;
        private TextBox textBoxEndValue_MDF;
        private PictureBox pictureBox1;
    }
}
