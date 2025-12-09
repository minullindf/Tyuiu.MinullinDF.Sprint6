namespace Tyuiu.MinullinDF.Sprint6.Task6.V29
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelTopSide_MDF = new Panel();
            buttonHelp_MDF = new Button();
            buttonDone_MDF = new Button();
            buttonOpen_MDF = new Button();
            panelOsnova_MDF = new Panel();
            groupBoxOutput_MDF = new GroupBox();
            textBoxOutPut_MDF = new TextBox();
            groupBoxIn_MDF = new GroupBox();
            textBoxInPut_MDF = new TextBox();
            groupBoxTask_MDF = new GroupBox();
            textBoxTask_MDF = new TextBox();
            openFileDialog_MDF = new OpenFileDialog();
            toolTip1 = new ToolTip(components);
            panelTopSide_MDF.SuspendLayout();
            panelOsnova_MDF.SuspendLayout();
            groupBoxOutput_MDF.SuspendLayout();
            groupBoxIn_MDF.SuspendLayout();
            groupBoxTask_MDF.SuspendLayout();
            SuspendLayout();
            // 
            // panelTopSide_MDF
            // 
            panelTopSide_MDF.Controls.Add(buttonHelp_MDF);
            panelTopSide_MDF.Controls.Add(buttonDone_MDF);
            panelTopSide_MDF.Controls.Add(buttonOpen_MDF);
            panelTopSide_MDF.Dock = DockStyle.Top;
            panelTopSide_MDF.Location = new Point(0, 0);
            panelTopSide_MDF.Margin = new Padding(4, 3, 4, 3);
            panelTopSide_MDF.Name = "panelTopSide_MDF";
            panelTopSide_MDF.Size = new Size(933, 65);
            panelTopSide_MDF.TabIndex = 0;
            // 
            // buttonHelp_MDF
            // 
            buttonHelp_MDF.Image = Properties.Resources.user;
            buttonHelp_MDF.Location = new Point(839, 6);
            buttonHelp_MDF.Margin = new Padding(4, 3, 4, 3);
            buttonHelp_MDF.Name = "buttonHelp_MDF";
            buttonHelp_MDF.Size = new Size(80, 54);
            buttonHelp_MDF.TabIndex = 1;
            buttonHelp_MDF.UseVisualStyleBackColor = true;
            // 
            // buttonDone_MDF
            // 
            buttonDone_MDF.Image = Properties.Resources.application_add;
            buttonDone_MDF.Location = new Point(91, 3);
            buttonDone_MDF.Margin = new Padding(4, 3, 4, 3);
            buttonDone_MDF.Name = "buttonDone_MDF";
            buttonDone_MDF.Size = new Size(80, 58);
            buttonDone_MDF.TabIndex = 0;
            buttonDone_MDF.UseVisualStyleBackColor = true;
            // 
            // buttonOpen_MDF
            // 
            buttonOpen_MDF.Image = Properties.Resources.folder_explore;
            buttonOpen_MDF.Location = new Point(4, 3);
            buttonOpen_MDF.Margin = new Padding(4, 3, 4, 3);
            buttonOpen_MDF.Name = "buttonOpen_MDF";
            buttonOpen_MDF.Size = new Size(80, 58);
            buttonOpen_MDF.TabIndex = 0;
            toolTip1.SetToolTip(buttonOpen_MDF, "Открыть файл.\r\nВыберите нужный файл для обработки.\r\n");
            buttonOpen_MDF.UseVisualStyleBackColor = true;
            // 
            // panelOsnova_MDF
            // 
            panelOsnova_MDF.Controls.Add(groupBoxOutput_MDF);
            panelOsnova_MDF.Controls.Add(groupBoxIn_MDF);
            panelOsnova_MDF.Controls.Add(groupBoxTask_MDF);
            panelOsnova_MDF.Dock = DockStyle.Fill;
            panelOsnova_MDF.Location = new Point(0, 65);
            panelOsnova_MDF.Margin = new Padding(4, 3, 4, 3);
            panelOsnova_MDF.Name = "panelOsnova_MDF";
            panelOsnova_MDF.Size = new Size(933, 454);
            panelOsnova_MDF.TabIndex = 2;
            // 
            // groupBoxOutput_MDF
            // 
            groupBoxOutput_MDF.Controls.Add(textBoxOutPut_MDF);
            groupBoxOutput_MDF.Location = new Point(478, 83);
            groupBoxOutput_MDF.Margin = new Padding(4, 3, 4, 3);
            groupBoxOutput_MDF.Name = "groupBoxOutput_MDF";
            groupBoxOutput_MDF.Padding = new Padding(4, 3, 4, 3);
            groupBoxOutput_MDF.Size = new Size(441, 368);
            groupBoxOutput_MDF.TabIndex = 2;
            groupBoxOutput_MDF.TabStop = false;
            groupBoxOutput_MDF.Text = "Вывод: ";
            // 
            // textBoxOutPut_MDF
            // 
            textBoxOutPut_MDF.Dock = DockStyle.Fill;
            textBoxOutPut_MDF.Location = new Point(4, 19);
            textBoxOutPut_MDF.Margin = new Padding(4, 3, 4, 3);
            textBoxOutPut_MDF.Multiline = true;
            textBoxOutPut_MDF.Name = "textBoxOutPut_MDF";
            textBoxOutPut_MDF.ReadOnly = true;
            textBoxOutPut_MDF.ScrollBars = ScrollBars.Vertical;
            textBoxOutPut_MDF.Size = new Size(433, 346);
            textBoxOutPut_MDF.TabIndex = 0;
            // 
            // groupBoxIn_MDF
            // 
            groupBoxIn_MDF.Controls.Add(textBoxInPut_MDF);
            groupBoxIn_MDF.Location = new Point(14, 83);
            groupBoxIn_MDF.Margin = new Padding(4, 3, 4, 3);
            groupBoxIn_MDF.Name = "groupBoxIn_MDF";
            groupBoxIn_MDF.Padding = new Padding(4, 3, 4, 3);
            groupBoxIn_MDF.Size = new Size(444, 368);
            groupBoxIn_MDF.TabIndex = 1;
            groupBoxIn_MDF.TabStop = false;
            groupBoxIn_MDF.Text = "Ввод: ";
            // 
            // textBoxInPut_MDF
            // 
            textBoxInPut_MDF.Dock = DockStyle.Fill;
            textBoxInPut_MDF.Location = new Point(4, 19);
            textBoxInPut_MDF.Margin = new Padding(4, 3, 4, 3);
            textBoxInPut_MDF.Multiline = true;
            textBoxInPut_MDF.Name = "textBoxInPut_MDF";
            textBoxInPut_MDF.ReadOnly = true;
            textBoxInPut_MDF.ScrollBars = ScrollBars.Vertical;
            textBoxInPut_MDF.Size = new Size(436, 346);
            textBoxInPut_MDF.TabIndex = 0;
            // 
            // groupBoxTask_MDF
            // 
            groupBoxTask_MDF.Controls.Add(textBoxTask_MDF);
            groupBoxTask_MDF.Dock = DockStyle.Top;
            groupBoxTask_MDF.Location = new Point(0, 0);
            groupBoxTask_MDF.Margin = new Padding(4, 3, 4, 3);
            groupBoxTask_MDF.Name = "groupBoxTask_MDF";
            groupBoxTask_MDF.Padding = new Padding(4, 3, 4, 3);
            groupBoxTask_MDF.Size = new Size(933, 76);
            groupBoxTask_MDF.TabIndex = 0;
            groupBoxTask_MDF.TabStop = false;
            groupBoxTask_MDF.Text = "Условие: ";
            // 
            // textBoxTask_MDF
            // 
            textBoxTask_MDF.Dock = DockStyle.Fill;
            textBoxTask_MDF.Font = new Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxTask_MDF.Location = new Point(4, 19);
            textBoxTask_MDF.Margin = new Padding(4, 3, 4, 3);
            textBoxTask_MDF.Multiline = true;
            textBoxTask_MDF.Name = "textBoxTask_MDF";
            textBoxTask_MDF.ReadOnly = true;
            textBoxTask_MDF.Size = new Size(925, 54);
            textBoxTask_MDF.TabIndex = 0;
            textBoxTask_MDF.Text = resources.GetString("textBoxTask_MDF.Text");
            // 
            // openFileDialog_MDF
            // 
            openFileDialog_MDF.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(panelOsnova_MDF);
            Controls.Add(panelTopSide_MDF);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 6 | Вариант 14 | Солиев А.Х.";
            panelTopSide_MDF.ResumeLayout(false);
            panelOsnova_MDF.ResumeLayout(false);
            groupBoxOutput_MDF.ResumeLayout(false);
            groupBoxOutput_MDF.PerformLayout();
            groupBoxIn_MDF.ResumeLayout(false);
            groupBoxIn_MDF.PerformLayout();
            groupBoxTask_MDF.ResumeLayout(false);
            groupBoxTask_MDF.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTopSide_MDF;
        private System.Windows.Forms.Button buttonDone_MDF;
        private System.Windows.Forms.Button buttonOpen_MDF;
        private System.Windows.Forms.Panel panelOsnova_MDF;
        private System.Windows.Forms.GroupBox groupBoxOutput_MDF;
        private System.Windows.Forms.TextBox textBoxOutPut_MDF;
        private System.Windows.Forms.GroupBox groupBoxIn_MDF;
        private System.Windows.Forms.TextBox textBoxInPut_MDF;
        private System.Windows.Forms.GroupBox groupBoxTask_MDF;
        private System.Windows.Forms.TextBox textBoxTask_MDF;
        private System.Windows.Forms.OpenFileDialog openFileDialog_MDF;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button buttonHelp_MDF;
    }
}
