namespace BehemothWinFormsApp
{
    partial class ViewControl
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxMake = new TextBox();
            buttonMake = new Button();
            buttonRemove4 = new Button();
            buttonRemove3 = new Button();
            buttonRemove2 = new Button();
            buttonRemove1 = new Button();
            textBoxPlayer4 = new TextBox();
            textBoxPlayer3 = new TextBox();
            textBoxPlayer2 = new TextBox();
            textBoxPlayer1 = new TextBox();
            buttonSSSS = new Button();
            buttonSDSS = new Button();
            buttonSDDS = new Button();
            buttonSDDD = new Button();
            buttonDSSS = new Button();
            buttonDDSS = new Button();
            buttonDDDS = new Button();
            buttonDDDD = new Button();
            SuspendLayout();
            // 
            // textBoxMake
            // 
            textBoxMake.Location = new Point(0, 147);
            textBoxMake.Name = "textBoxMake";
            textBoxMake.Size = new Size(618, 23);
            textBoxMake.TabIndex = 35;
            // 
            // buttonMake
            // 
            buttonMake.Location = new Point(0, 118);
            buttonMake.Name = "buttonMake";
            buttonMake.Size = new Size(618, 23);
            buttonMake.TabIndex = 34;
            buttonMake.Text = "Make";
            buttonMake.UseVisualStyleBackColor = true;
            buttonMake.Click += buttonMake_Click;
            // 
            // buttonRemove4
            // 
            buttonRemove4.Location = new Point(381, 89);
            buttonRemove4.Name = "buttonRemove4";
            buttonRemove4.Size = new Size(75, 23);
            buttonRemove4.TabIndex = 33;
            buttonRemove4.Tag = "4";
            buttonRemove4.Text = "Remove";
            buttonRemove4.UseVisualStyleBackColor = true;
            buttonRemove4.Click += buttonRemove_Click;
            // 
            // buttonRemove3
            // 
            buttonRemove3.Location = new Point(381, 59);
            buttonRemove3.Name = "buttonRemove3";
            buttonRemove3.Size = new Size(75, 23);
            buttonRemove3.TabIndex = 32;
            buttonRemove3.Tag = "3";
            buttonRemove3.Text = "Remove";
            buttonRemove3.UseVisualStyleBackColor = true;
            buttonRemove3.Click += buttonRemove_Click;
            // 
            // buttonRemove2
            // 
            buttonRemove2.Location = new Point(381, 31);
            buttonRemove2.Name = "buttonRemove2";
            buttonRemove2.Size = new Size(75, 23);
            buttonRemove2.TabIndex = 31;
            buttonRemove2.Tag = "2";
            buttonRemove2.Text = "Remove";
            buttonRemove2.UseVisualStyleBackColor = true;
            buttonRemove2.Click += buttonRemove_Click;
            // 
            // buttonRemove1
            // 
            buttonRemove1.Location = new Point(381, 3);
            buttonRemove1.Name = "buttonRemove1";
            buttonRemove1.Size = new Size(75, 23);
            buttonRemove1.TabIndex = 30;
            buttonRemove1.Tag = "1";
            buttonRemove1.Text = "Remove";
            buttonRemove1.UseVisualStyleBackColor = true;
            buttonRemove1.Click += buttonRemove_Click;
            // 
            // textBoxPlayer4
            // 
            textBoxPlayer4.Location = new Point(0, 89);
            textBoxPlayer4.Name = "textBoxPlayer4";
            textBoxPlayer4.ReadOnly = true;
            textBoxPlayer4.Size = new Size(375, 23);
            textBoxPlayer4.TabIndex = 29;
            // 
            // textBoxPlayer3
            // 
            textBoxPlayer3.Location = new Point(0, 60);
            textBoxPlayer3.Name = "textBoxPlayer3";
            textBoxPlayer3.ReadOnly = true;
            textBoxPlayer3.Size = new Size(375, 23);
            textBoxPlayer3.TabIndex = 28;
            // 
            // textBoxPlayer2
            // 
            textBoxPlayer2.Location = new Point(0, 32);
            textBoxPlayer2.Name = "textBoxPlayer2";
            textBoxPlayer2.ReadOnly = true;
            textBoxPlayer2.Size = new Size(375, 23);
            textBoxPlayer2.TabIndex = 27;
            // 
            // textBoxPlayer1
            // 
            textBoxPlayer1.Location = new Point(0, 3);
            textBoxPlayer1.Name = "textBoxPlayer1";
            textBoxPlayer1.ReadOnly = true;
            textBoxPlayer1.Size = new Size(375, 23);
            textBoxPlayer1.TabIndex = 26;
            // 
            // buttonSSSS
            // 
            buttonSSSS.Location = new Point(543, 89);
            buttonSSSS.Name = "buttonSSSS";
            buttonSSSS.Size = new Size(75, 23);
            buttonSSSS.TabIndex = 25;
            buttonSSSS.Text = "SSSS";
            buttonSSSS.UseVisualStyleBackColor = true;
            buttonSSSS.Click += buttonCombinationsClick;
            // 
            // buttonSDSS
            // 
            buttonSDSS.Location = new Point(543, 60);
            buttonSDSS.Name = "buttonSDSS";
            buttonSDSS.Size = new Size(75, 23);
            buttonSDSS.TabIndex = 24;
            buttonSDSS.Text = "SDSS";
            buttonSDSS.UseVisualStyleBackColor = true;
            buttonSDSS.Click += buttonCombinationsClick;
            // 
            // buttonSDDS
            // 
            buttonSDDS.Location = new Point(543, 31);
            buttonSDDS.Name = "buttonSDDS";
            buttonSDDS.Size = new Size(75, 23);
            buttonSDDS.TabIndex = 23;
            buttonSDDS.Text = "SDDS";
            buttonSDDS.UseVisualStyleBackColor = true;
            buttonSDDS.Click += buttonCombinationsClick;
            // 
            // buttonSDDD
            // 
            buttonSDDD.Location = new Point(543, 2);
            buttonSDDD.Name = "buttonSDDD";
            buttonSDDD.Size = new Size(75, 23);
            buttonSDDD.TabIndex = 22;
            buttonSDDD.Text = "SDDD";
            buttonSDDD.UseVisualStyleBackColor = true;
            buttonSDDD.Click += buttonCombinationsClick;
            // 
            // buttonDSSS
            // 
            buttonDSSS.Location = new Point(462, 89);
            buttonDSSS.Name = "buttonDSSS";
            buttonDSSS.Size = new Size(75, 23);
            buttonDSSS.TabIndex = 21;
            buttonDSSS.Text = "DSSS";
            buttonDSSS.UseVisualStyleBackColor = true;
            buttonDSSS.Click += buttonCombinationsClick;
            // 
            // buttonDDSS
            // 
            buttonDDSS.Location = new Point(462, 60);
            buttonDDSS.Name = "buttonDDSS";
            buttonDDSS.Size = new Size(75, 23);
            buttonDDSS.TabIndex = 20;
            buttonDDSS.Text = "DDSS";
            buttonDDSS.UseVisualStyleBackColor = true;
            buttonDDSS.Click += buttonCombinationsClick;
            // 
            // buttonDDDS
            // 
            buttonDDDS.Location = new Point(462, 31);
            buttonDDDS.Name = "buttonDDDS";
            buttonDDDS.Size = new Size(75, 23);
            buttonDDDS.TabIndex = 19;
            buttonDDDS.Text = "DDDS";
            buttonDDDS.UseVisualStyleBackColor = true;
            buttonDDDS.Click += buttonCombinationsClick;
            // 
            // buttonDDDD
            // 
            buttonDDDD.Location = new Point(462, 2);
            buttonDDDD.Name = "buttonDDDD";
            buttonDDDD.Size = new Size(75, 23);
            buttonDDDD.TabIndex = 18;
            buttonDDDD.Text = "DDDD";
            buttonDDDD.UseVisualStyleBackColor = true;
            buttonDDDD.Click += buttonCombinationsClick;
            // 
            // ViewControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBoxMake);
            Controls.Add(buttonMake);
            Controls.Add(buttonRemove4);
            Controls.Add(buttonRemove3);
            Controls.Add(buttonRemove2);
            Controls.Add(buttonRemove1);
            Controls.Add(textBoxPlayer4);
            Controls.Add(textBoxPlayer3);
            Controls.Add(textBoxPlayer2);
            Controls.Add(textBoxPlayer1);
            Controls.Add(buttonSSSS);
            Controls.Add(buttonSDSS);
            Controls.Add(buttonSDDS);
            Controls.Add(buttonSDDD);
            Controls.Add(buttonDSSS);
            Controls.Add(buttonDDSS);
            Controls.Add(buttonDDDS);
            Controls.Add(buttonDDDD);
            Name = "ViewControl";
            Size = new Size(625, 178);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxMake;
        private Button buttonMake;
        private Button buttonRemove4;
        private Button buttonRemove3;
        private Button buttonRemove2;
        private Button buttonRemove1;
        private TextBox textBoxPlayer4;
        private TextBox textBoxPlayer3;
        private TextBox textBoxPlayer2;
        private TextBox textBoxPlayer1;
        private Button buttonSSSS;
        private Button buttonSDSS;
        private Button buttonSDDS;
        private Button buttonSDDD;
        private Button buttonDSSS;
        private Button buttonDDSS;
        private Button buttonDDDS;
        private Button buttonDDDD;
    }
}
