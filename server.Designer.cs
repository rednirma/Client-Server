namespace Client_Server_tcpip
{
    partial class server
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
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.ChatMsgListBox = new System.Windows.Forms.TextBox();
            this.ServerPortBtn = new System.Windows.Forms.TextBox();
            this.ServerIPBox = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ServerIPLabel = new System.Windows.Forms.Label();
            this.StartServerBtn = new System.Windows.Forms.Button();
            this.SendMsgBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ServerPortLabel = new System.Windows.Forms.Label();
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // ChatMsgListBox
            // 
            this.ChatMsgListBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ChatMsgListBox.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChatMsgListBox.Location = new System.Drawing.Point(42, 128);
            this.ChatMsgListBox.Multiline = true;
            this.ChatMsgListBox.Name = "ChatMsgListBox";
            this.ChatMsgListBox.ReadOnly = true;
            this.ChatMsgListBox.Size = new System.Drawing.Size(717, 207);
            this.ChatMsgListBox.TabIndex = 10;
            this.ChatMsgListBox.TabStop = false;
            // 
            // ServerPortBtn
            // 
            this.ServerPortBtn.Location = new System.Drawing.Point(381, 23);
            this.ServerPortBtn.Name = "ServerPortBtn";
            this.ServerPortBtn.Size = new System.Drawing.Size(207, 23);
            this.ServerPortBtn.TabIndex = 4;
            // 
            // ServerIPBox
            // 
            this.ServerIPBox.Location = new System.Drawing.Point(64, 22);
            this.ServerIPBox.Name = "ServerIPBox";
            this.ServerIPBox.Size = new System.Drawing.Size(228, 23);
            this.ServerIPBox.TabIndex = 3;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // ServerIPLabel
            // 
            this.ServerIPLabel.AutoSize = true;
            this.ServerIPLabel.Location = new System.Drawing.Point(23, 25);
            this.ServerIPLabel.Name = "ServerIPLabel";
            this.ServerIPLabel.Size = new System.Drawing.Size(25, 18);
            this.ServerIPLabel.TabIndex = 1;
            this.ServerIPLabel.Text = "IP:";
            // 
            // StartServerBtn
            // 
            this.StartServerBtn.Location = new System.Drawing.Point(594, 20);
            this.StartServerBtn.Name = "StartServerBtn";
            this.StartServerBtn.Size = new System.Drawing.Size(75, 23);
            this.StartServerBtn.TabIndex = 0;
            this.StartServerBtn.Text = "START";
            this.StartServerBtn.UseVisualStyleBackColor = true;
            this.StartServerBtn.Click += new System.EventHandler(this.StartServerBtn_Click);
            // 
            // SendMsgBtn
            // 
            this.SendMsgBtn.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendMsgBtn.Location = new System.Drawing.Point(684, 357);
            this.SendMsgBtn.Name = "SendMsgBtn";
            this.SendMsgBtn.Size = new System.Drawing.Size(75, 57);
            this.SendMsgBtn.TabIndex = 9;
            this.SendMsgBtn.Text = "SEND";
            this.SendMsgBtn.UseVisualStyleBackColor = true;
            this.SendMsgBtn.Click += new System.EventHandler(this.SendMsgBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ServerPortBtn);
            this.groupBox1.Controls.Add(this.ServerIPBox);
            this.groupBox1.Controls.Add(this.ServerPortLabel);
            this.groupBox1.Controls.Add(this.ServerIPLabel);
            this.groupBox1.Controls.Add(this.StartServerBtn);
            this.groupBox1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(42, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(717, 58);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "YOUR SERVER INFO";
            // 
            // ServerPortLabel
            // 
            this.ServerPortLabel.AutoSize = true;
            this.ServerPortLabel.Location = new System.Drawing.Point(340, 25);
            this.ServerPortLabel.Name = "ServerPortLabel";
            this.ServerPortLabel.Size = new System.Drawing.Size(44, 18);
            this.ServerPortLabel.TabIndex = 2;
            this.ServerPortLabel.Text = "PORT:";
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageTextBox.Location = new System.Drawing.Point(42, 357);
            this.MessageTextBox.Multiline = true;
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Size = new System.Drawing.Size(636, 57);
            this.MessageTextBox.TabIndex = 11;
            // 
            // server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SendMsgBtn);
            this.Controls.Add(this.MessageTextBox);
            this.Controls.Add(this.ChatMsgListBox);
            this.Name = "server";
            this.Text = "server";
            this.Load += new System.EventHandler(this.server_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.TextBox ChatMsgListBox;
        private System.Windows.Forms.TextBox ServerPortBtn;
        private System.Windows.Forms.TextBox ServerIPBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label ServerIPLabel;
        private System.Windows.Forms.Button StartServerBtn;
        private System.Windows.Forms.Button SendMsgBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label ServerPortLabel;
        private System.Windows.Forms.TextBox MessageTextBox;
    }
}