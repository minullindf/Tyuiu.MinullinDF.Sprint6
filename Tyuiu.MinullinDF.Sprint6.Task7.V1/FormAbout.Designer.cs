namespace Tyuiu.MinullinDF.Sprint6.Task7.V1
{
    partial class FormAbout
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
            buttonOK_MDF = new Button();
            labelInfo_SAH = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonOK_MDF
            // 
            buttonOK_MDF.Location = new Point(461, 179);
            buttonOK_MDF.Margin = new Padding(4, 3, 4, 3);
            buttonOK_MDF.Name = "buttonOK_MDF";
            buttonOK_MDF.Size = new Size(88, 27);
            buttonOK_MDF.TabIndex = 5;
            buttonOK_MDF.Text = "OK";
            buttonOK_MDF.UseVisualStyleBackColor = true;
            buttonOK_MDF.Click += buttonOK_MDF_Click;
            // 
            // labelInfo_SAH
            // 
            labelInfo_SAH.AutoSize = true;
            labelInfo_SAH.Location = new Point(217, 10);
            labelInfo_SAH.Margin = new Padding(4, 0, 4, 0);
            labelInfo_SAH.Name = "labelInfo_SAH";
            labelInfo_SAH.Size = new Size(0, 15);
            labelInfo_SAH.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(10, 14);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(186, 170);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 210);
            Controls.Add(buttonOK_MDF);
            Controls.Add(labelInfo_SAH);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK_MDF;
        private System.Windows.Forms.Label labelInfo_SAH;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}