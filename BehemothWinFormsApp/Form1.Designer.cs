namespace BehemothWinFormsApp
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
            viewControl1 = new ViewControl();
            viewControl2 = new ViewControl();
            viewControl3 = new ViewControl();
            viewControl4 = new ViewControl();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // viewControl1
            // 
            viewControl1.Location = new Point(8, 36);
            viewControl1.Name = "viewControl1";
            viewControl1.Size = new Size(630, 183);
            viewControl1.TabIndex = 0;
            // 
            // viewControl2
            // 
            viewControl2.Location = new Point(644, 36);
            viewControl2.Name = "viewControl2";
            viewControl2.Size = new Size(630, 183);
            viewControl2.TabIndex = 1;
            // 
            // viewControl3
            // 
            viewControl3.Location = new Point(8, 256);
            viewControl3.Name = "viewControl3";
            viewControl3.Size = new Size(630, 183);
            viewControl3.TabIndex = 2;
            // 
            // viewControl4
            // 
            viewControl4.Location = new Point(644, 256);
            viewControl4.Name = "viewControl4";
            viewControl4.Size = new Size(630, 183);
            viewControl4.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 18);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 4;
            label1.Text = "1파티";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(644, 18);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 5;
            label2.Text = "2파티";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 238);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 6;
            label3.Text = "3파티";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(644, 238);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 7;
            label4.Text = "4파티";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1287, 460);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(viewControl4);
            Controls.Add(viewControl3);
            Controls.Add(viewControl2);
            Controls.Add(viewControl1);
            Name = "FormMain";
            Text = "Party";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ViewControl viewControl1;
        private ViewControl viewControl2;
        private ViewControl viewControl3;
        private ViewControl viewControl4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
