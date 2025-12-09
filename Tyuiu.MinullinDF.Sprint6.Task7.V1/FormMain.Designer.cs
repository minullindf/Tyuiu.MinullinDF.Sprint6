namespace Tyuiu.MinullinDF.Sprint6.Task7.V1
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
            panelTopSide_MDF = new Panel();
            buttonHelp_MDF = new Button();
            buttonSave_MDF = new Button();
            buttonDone_MDF = new Button();
            buttonOpen_MDF = new Button();
            panelFill_MDF = new Panel();
            groupBoxOutPut_MDF = new GroupBox();
            dataGridViewOutPut_MDF = new DataGridView();
            groupBoxInput_MDF = new GroupBox();
            dataGridViewIn_MDF = new DataGridView();
            groupBoxTask_MDF = new GroupBox();
            textBoxTask_MDF = new TextBox();
            openFileDialogTask_MDF = new OpenFileDialog();
            toolTipInfo_MDF = new ToolTip(components);
            saveFileDialogMatrix_MDF = new SaveFileDialog();
            panelTopSide_MDF.SuspendLayout();
            panelFill_MDF.SuspendLayout();
            groupBoxOutPut_MDF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutPut_MDF).BeginInit();
            groupBoxInput_MDF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_MDF).BeginInit();
            groupBoxTask_MDF.SuspendLayout();
            SuspendLayout();
            // 
            // panelTopSide_MDF
            // 
            panelTopSide_MDF.Controls.Add(buttonHelp_MDF);
            panelTopSide_MDF.Controls.Add(buttonSave_MDF);
            panelTopSide_MDF.Controls.Add(buttonDone_MDF);
            panelTopSide_MDF.Controls.Add(buttonOpen_MDF);
            panelTopSide_MDF.Dock = DockStyle.Top;
            panelTopSide_MDF.Location = new Point(0, 0);
            panelTopSide_MDF.Margin = new Padding(4, 3, 4, 3);
            panelTopSide_MDF.Name = "panelTopSide_MDF";
            panelTopSide_MDF.Size = new Size(1214, 73);
            panelTopSide_MDF.TabIndex = 0;
            // 
            // buttonHelp_MDF
            // 
            buttonHelp_MDF.Image = Properties.Resources.tux;
            buttonHelp_MDF.Location = new Point(1128, 3);
            buttonHelp_MDF.Margin = new Padding(4, 3, 4, 3);
            buttonHelp_MDF.Name = "buttonHelp_MDF";
            buttonHelp_MDF.Size = new Size(83, 66);
            buttonHelp_MDF.TabIndex = 0;
            toolTipInfo_MDF.SetToolTip(buttonHelp_MDF, "О программе\r\n");
            buttonHelp_MDF.UseVisualStyleBackColor = true;
            // 
            // buttonSave_MDF
            // 
            buttonSave_MDF.Image = Properties.Resources.script_save;
            buttonSave_MDF.Location = new Point(203, 3);
            buttonSave_MDF.Margin = new Padding(4, 3, 4, 3);
            buttonSave_MDF.Name = "buttonSave_MDF";
            buttonSave_MDF.Size = new Size(83, 66);
            buttonSave_MDF.TabIndex = 0;
            toolTipInfo_MDF.SetToolTip(buttonSave_MDF, "Сохранения результата\r\n");
            buttonSave_MDF.UseVisualStyleBackColor = true;
            // 
            // buttonDone_MDF
            // 
            buttonDone_MDF.Image = Properties.Resources.bug;
            buttonDone_MDF.Location = new Point(108, 3);
            buttonDone_MDF.Margin = new Padding(4, 3, 4, 3);
            buttonDone_MDF.Name = "buttonDone_MDF";
            buttonDone_MDF.Size = new Size(88, 66);
            buttonDone_MDF.TabIndex = 0;
            toolTipInfo_MDF.SetToolTip(buttonDone_MDF, "Выполнить изменения\r\n");
            buttonDone_MDF.UseVisualStyleBackColor = true;
            // 
            // buttonOpen_MDF
            // 
            buttonOpen_MDF.Image = Properties.Resources.emotion_tongue;
            buttonOpen_MDF.Location = new Point(14, 3);
            buttonOpen_MDF.Margin = new Padding(4, 3, 4, 3);
            buttonOpen_MDF.Name = "buttonOpen_MDF";
            buttonOpen_MDF.Size = new Size(88, 66);
            buttonOpen_MDF.TabIndex = 0;
            toolTipInfo_MDF.SetToolTip(buttonOpen_MDF, "Выбор файла.\r\n");
            buttonOpen_MDF.UseVisualStyleBackColor = true;
            // 
            // panelFill_MDF
            // 
            panelFill_MDF.Controls.Add(groupBoxOutPut_MDF);
            panelFill_MDF.Controls.Add(groupBoxInput_MDF);
            panelFill_MDF.Controls.Add(groupBoxTask_MDF);
            panelFill_MDF.Dock = DockStyle.Fill;
            panelFill_MDF.Location = new Point(0, 73);
            panelFill_MDF.Margin = new Padding(4, 3, 4, 3);
            panelFill_MDF.Name = "panelFill_MDF";
            panelFill_MDF.Size = new Size(1214, 592);
            panelFill_MDF.TabIndex = 1;
            // 
            // groupBoxOutPut_MDF
            // 
            groupBoxOutPut_MDF.Controls.Add(dataGridViewOutPut_MDF);
            groupBoxOutPut_MDF.Dock = DockStyle.Right;
            groupBoxOutPut_MDF.Location = new Point(576, 83);
            groupBoxOutPut_MDF.Margin = new Padding(4, 3, 4, 3);
            groupBoxOutPut_MDF.Name = "groupBoxOutPut_MDF";
            groupBoxOutPut_MDF.Padding = new Padding(4, 3, 4, 3);
            groupBoxOutPut_MDF.Size = new Size(638, 509);
            groupBoxOutPut_MDF.TabIndex = 2;
            groupBoxOutPut_MDF.TabStop = false;
            groupBoxOutPut_MDF.Text = "Вывод";
            // 
            // dataGridViewOutPut_MDF
            // 
            dataGridViewOutPut_MDF.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutPut_MDF.Dock = DockStyle.Fill;
            dataGridViewOutPut_MDF.Location = new Point(4, 19);
            dataGridViewOutPut_MDF.Margin = new Padding(4, 3, 4, 3);
            dataGridViewOutPut_MDF.Name = "dataGridViewOutPut_MDF";
            dataGridViewOutPut_MDF.Size = new Size(630, 487);
            dataGridViewOutPut_MDF.TabIndex = 0;
            // 
            // groupBoxInput_MDF
            // 
            groupBoxInput_MDF.Controls.Add(dataGridViewIn_MDF);
            groupBoxInput_MDF.Dock = DockStyle.Left;
            groupBoxInput_MDF.Location = new Point(0, 83);
            groupBoxInput_MDF.Margin = new Padding(4, 3, 4, 3);
            groupBoxInput_MDF.Name = "groupBoxInput_MDF";
            groupBoxInput_MDF.Padding = new Padding(4, 3, 4, 3);
            groupBoxInput_MDF.Size = new Size(569, 509);
            groupBoxInput_MDF.TabIndex = 1;
            groupBoxInput_MDF.TabStop = false;
            groupBoxInput_MDF.Text = "Ввод";
            // 
            // dataGridViewIn_MDF
            // 
            dataGridViewIn_MDF.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIn_MDF.Dock = DockStyle.Fill;
            dataGridViewIn_MDF.Location = new Point(4, 19);
            dataGridViewIn_MDF.Margin = new Padding(4, 3, 4, 3);
            dataGridViewIn_MDF.Name = "dataGridViewIn_MDF";
            dataGridViewIn_MDF.Size = new Size(561, 487);
            dataGridViewIn_MDF.TabIndex = 0;
            // 
            // groupBoxTask_MDF
            // 
            groupBoxTask_MDF.Controls.Add(textBoxTask_MDF);
            groupBoxTask_MDF.Dock = DockStyle.Top;
            groupBoxTask_MDF.Location = new Point(0, 0);
            groupBoxTask_MDF.Margin = new Padding(4, 3, 4, 3);
            groupBoxTask_MDF.Name = "groupBoxTask_MDF";
            groupBoxTask_MDF.Padding = new Padding(4, 3, 4, 3);
            groupBoxTask_MDF.Size = new Size(1214, 83);
            groupBoxTask_MDF.TabIndex = 0;
            groupBoxTask_MDF.TabStop = false;
            groupBoxTask_MDF.Text = "Условие";
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
            textBoxTask_MDF.Size = new Size(1206, 61);
            textBoxTask_MDF.TabIndex = 0;
            // 
            // openFileDialogTask_MDF
            // 
            openFileDialogTask_MDF.FileName = "openFileDialogTask_MDF";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1214, 665);
            Controls.Add(panelFill_MDF);
            Controls.Add(panelTopSide_MDF);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 7 | Вариант 1 | Минуллин Д.Ф.";
            Load += FormMain_Load;
            panelTopSide_MDF.ResumeLayout(false);
            panelFill_MDF.ResumeLayout(false);
            groupBoxOutPut_MDF.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutPut_MDF).EndInit();
            groupBoxInput_MDF.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_MDF).EndInit();
            groupBoxTask_MDF.ResumeLayout(false);
            groupBoxTask_MDF.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTopSide_MDF;
        private System.Windows.Forms.Panel panelFill_MDF;
        private System.Windows.Forms.GroupBox groupBoxTask_MDF;
        private System.Windows.Forms.TextBox textBoxTask_MDF;
        private System.Windows.Forms.Button buttonHelp_MDF;
        private System.Windows.Forms.Button buttonSave_MDF;
        private System.Windows.Forms.Button buttonDone_MDF;
        private System.Windows.Forms.Button buttonOpen_MDF;
        private System.Windows.Forms.GroupBox groupBoxOutPut_MDF;
        private System.Windows.Forms.GroupBox groupBoxInput_MDF;
        private System.Windows.Forms.DataGridView dataGridViewIn_MDF;
        private System.Windows.Forms.DataGridView dataGridViewOutPut_MDF;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_MDF;
        private System.Windows.Forms.ToolTip toolTipInfo_MDF;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix_MDF;
    }
}
