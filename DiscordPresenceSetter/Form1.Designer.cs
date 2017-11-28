namespace DiscordPresenceSetter
{
    partial class Form1
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SaveChangesButton = new System.Windows.Forms.Button();
            this.ResendPresenceButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.FormLog = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ResendPresenceCheckbox = new System.Windows.Forms.CheckBox();
            this.PartyTimerCounter = new System.Windows.Forms.NumericUpDown();
            this.LargeImageKeyBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.LargeImageTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.MyApplicationID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.DetailsBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SpectateSecretBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.JoinSecretBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CurrentPartySize = new System.Windows.Forms.NumericUpDown();
            this.MatchSecretBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.MaxPartySize = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.SmallImageKeyBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PartyIDBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SmallImageTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.StateBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PartyTimerCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentPartySize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxPartySize)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer1.Size = new System.Drawing.Size(704, 543);
            this.splitContainer1.SplitterDistance = 325;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer2.Size = new System.Drawing.Size(325, 543);
            this.splitContainer2.SplitterDistance = 265;
            this.splitContainer2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SaveChangesButton);
            this.groupBox1.Controls.Add(this.ResendPresenceButton);
            this.groupBox1.Controls.Add(this.StartButton);
            this.groupBox1.Controls.Add(this.StopButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 114);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Presence Controller";
            // 
            // SaveChangesButton
            // 
            this.SaveChangesButton.Location = new System.Drawing.Point(159, 72);
            this.SaveChangesButton.Name = "SaveChangesButton";
            this.SaveChangesButton.Size = new System.Drawing.Size(119, 23);
            this.SaveChangesButton.TabIndex = 51;
            this.SaveChangesButton.Text = "Save Changes";
            this.SaveChangesButton.UseVisualStyleBackColor = true;
            this.SaveChangesButton.Click += new System.EventHandler(this.SaveChangesButton_Click);
            // 
            // ResendPresenceButton
            // 
            this.ResendPresenceButton.Location = new System.Drawing.Point(17, 72);
            this.ResendPresenceButton.Name = "ResendPresenceButton";
            this.ResendPresenceButton.Size = new System.Drawing.Size(119, 23);
            this.ResendPresenceButton.TabIndex = 52;
            this.ResendPresenceButton.Text = "Resend Presence";
            this.ResendPresenceButton.UseVisualStyleBackColor = true;
            this.ResendPresenceButton.Click += new System.EventHandler(this.ResendPresenceButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(16, 26);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(120, 23);
            this.StartButton.TabIndex = 27;
            this.StartButton.Text = "Run";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(159, 26);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(119, 23);
            this.StopButton.TabIndex = 29;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.FormLog);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(325, 274);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DPS - Log";
            // 
            // FormLog
            // 
            this.FormLog.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.FormLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormLog.ForeColor = System.Drawing.SystemColors.Window;
            this.FormLog.Location = new System.Drawing.Point(3, 16);
            this.FormLog.Multiline = true;
            this.FormLog.Name = "FormLog";
            this.FormLog.ReadOnly = true;
            this.FormLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.FormLog.Size = new System.Drawing.Size(319, 255);
            this.FormLog.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.LargeImageKeyBox);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.LargeImageTextBox);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.MyApplicationID);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.DetailsBox);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.SpectateSecretBox);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.JoinSecretBox);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.CurrentPartySize);
            this.groupBox3.Controls.Add(this.MatchSecretBox);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.MaxPartySize);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.SmallImageKeyBox);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.PartyIDBox);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.SmallImageTextBox);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.StateBox);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(16, 11);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(347, 520);
            this.groupBox3.TabIndex = 52;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Presence Settings";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ResendPresenceCheckbox);
            this.groupBox4.Controls.Add(this.PartyTimerCounter);
            this.groupBox4.Location = new System.Drawing.Point(13, 449);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(321, 53);
            this.groupBox4.TabIndex = 77;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Party Timer ( In Minutes ) (60 Minutes Max)";
            // 
            // ResendPresenceCheckbox
            // 
            this.ResendPresenceCheckbox.AutoSize = true;
            this.ResendPresenceCheckbox.Checked = true;
            this.ResendPresenceCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ResendPresenceCheckbox.Location = new System.Drawing.Point(113, 22);
            this.ResendPresenceCheckbox.Name = "ResendPresenceCheckbox";
            this.ResendPresenceCheckbox.Size = new System.Drawing.Size(192, 17);
            this.ResendPresenceCheckbox.TabIndex = 83;
            this.ResendPresenceCheckbox.Text = "Resend Presence On Timer Elapse";
            this.ResendPresenceCheckbox.UseVisualStyleBackColor = true;
            // 
            // PartyTimerCounter
            // 
            this.PartyTimerCounter.Location = new System.Drawing.Point(28, 21);
            this.PartyTimerCounter.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.PartyTimerCounter.Name = "PartyTimerCounter";
            this.PartyTimerCounter.Size = new System.Drawing.Size(58, 20);
            this.PartyTimerCounter.TabIndex = 82;
            this.PartyTimerCounter.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // LargeImageKeyBox
            // 
            this.LargeImageKeyBox.Location = new System.Drawing.Point(108, 224);
            this.LargeImageKeyBox.Name = "LargeImageKeyBox";
            this.LargeImageKeyBox.Size = new System.Drawing.Size(227, 20);
            this.LargeImageKeyBox.TabIndex = 76;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 227);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 13);
            this.label12.TabIndex = 75;
            this.label12.Text = "Large Image Key";
            // 
            // LargeImageTextBox
            // 
            this.LargeImageTextBox.Location = new System.Drawing.Point(108, 248);
            this.LargeImageTextBox.Name = "LargeImageTextBox";
            this.LargeImageTextBox.Size = new System.Drawing.Size(227, 20);
            this.LargeImageTextBox.TabIndex = 74;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 251);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 13);
            this.label13.TabIndex = 73;
            this.label13.Text = "Large Image Text";
            // 
            // MyApplicationID
            // 
            this.MyApplicationID.Location = new System.Drawing.Point(110, 24);
            this.MyApplicationID.Name = "MyApplicationID";
            this.MyApplicationID.Size = new System.Drawing.Size(227, 20);
            this.MyApplicationID.TabIndex = 72;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 71;
            this.label11.Text = "ApplicationID";
            // 
            // DetailsBox
            // 
            this.DetailsBox.Location = new System.Drawing.Point(13, 98);
            this.DetailsBox.Multiline = true;
            this.DetailsBox.Name = "DetailsBox";
            this.DetailsBox.Size = new System.Drawing.Size(322, 73);
            this.DetailsBox.TabIndex = 70;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 69;
            this.label2.Text = "Details";
            // 
            // SpectateSecretBox
            // 
            this.SpectateSecretBox.Location = new System.Drawing.Point(108, 354);
            this.SpectateSecretBox.Name = "SpectateSecretBox";
            this.SpectateSecretBox.Size = new System.Drawing.Size(227, 20);
            this.SpectateSecretBox.TabIndex = 68;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 357);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 13);
            this.label10.TabIndex = 67;
            this.label10.Text = "Spectate Secret";
            // 
            // JoinSecretBox
            // 
            this.JoinSecretBox.Location = new System.Drawing.Point(108, 328);
            this.JoinSecretBox.Name = "JoinSecretBox";
            this.JoinSecretBox.Size = new System.Drawing.Size(227, 20);
            this.JoinSecretBox.TabIndex = 66;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 331);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 65;
            this.label9.Text = "Join Secret";
            // 
            // CurrentPartySize
            // 
            this.CurrentPartySize.Location = new System.Drawing.Point(155, 387);
            this.CurrentPartySize.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.CurrentPartySize.Name = "CurrentPartySize";
            this.CurrentPartySize.Size = new System.Drawing.Size(52, 20);
            this.CurrentPartySize.TabIndex = 64;
            // 
            // MatchSecretBox
            // 
            this.MatchSecretBox.Location = new System.Drawing.Point(108, 300);
            this.MatchSecretBox.Name = "MatchSecretBox";
            this.MatchSecretBox.Size = new System.Drawing.Size(227, 20);
            this.MatchSecretBox.TabIndex = 63;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 303);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 62;
            this.label8.Text = "Match Secret";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 417);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 61;
            this.label7.Text = "Max Party Size(300)";
            // 
            // MaxPartySize
            // 
            this.MaxPartySize.Location = new System.Drawing.Point(155, 413);
            this.MaxPartySize.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.MaxPartySize.Name = "MaxPartySize";
            this.MaxPartySize.Size = new System.Drawing.Size(52, 20);
            this.MaxPartySize.TabIndex = 60;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 389);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 13);
            this.label6.TabIndex = 59;
            this.label6.Text = "CurrentParty Size (Max 300)";
            // 
            // SmallImageKeyBox
            // 
            this.SmallImageKeyBox.Location = new System.Drawing.Point(108, 177);
            this.SmallImageKeyBox.Name = "SmallImageKeyBox";
            this.SmallImageKeyBox.Size = new System.Drawing.Size(227, 20);
            this.SmallImageKeyBox.TabIndex = 58;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 57;
            this.label5.Text = "Small Image Key";
            // 
            // PartyIDBox
            // 
            this.PartyIDBox.Location = new System.Drawing.Point(108, 274);
            this.PartyIDBox.Name = "PartyIDBox";
            this.PartyIDBox.Size = new System.Drawing.Size(227, 20);
            this.PartyIDBox.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 55;
            this.label4.Text = "Party ID";
            // 
            // SmallImageTextBox
            // 
            this.SmallImageTextBox.Location = new System.Drawing.Point(108, 200);
            this.SmallImageTextBox.Name = "SmallImageTextBox";
            this.SmallImageTextBox.Size = new System.Drawing.Size(227, 20);
            this.SmallImageTextBox.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 53;
            this.label3.Text = "Small Image Text";
            // 
            // StateBox
            // 
            this.StateBox.Location = new System.Drawing.Point(110, 53);
            this.StateBox.Name = "StateBox";
            this.StateBox.Size = new System.Drawing.Size(227, 20);
            this.StateBox.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "State (Title)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(704, 543);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Discord Presence Setter V0.0.0.5- (Made By General Wrex)";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PartyTimerCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentPartySize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxPartySize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button SaveChangesButton;
        private System.Windows.Forms.Button ResendPresenceButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox FormLog;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox LargeImageKeyBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox LargeImageTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox MyApplicationID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox DetailsBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SpectateSecretBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox JoinSecretBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown CurrentPartySize;
        private System.Windows.Forms.TextBox MatchSecretBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown MaxPartySize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox SmallImageKeyBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PartyIDBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SmallImageTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox StateBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox ResendPresenceCheckbox;
        private System.Windows.Forms.NumericUpDown PartyTimerCounter;
    }
}

