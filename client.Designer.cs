namespace Client_Server_tcpip
{
    partial class client
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SendMsgBtn = new System.Windows.Forms.Button();
            this.ClientConnectBtn = new System.Windows.Forms.Button();
            this.ClientIPLabel = new System.Windows.Forms.Label();
            this.ClientPortLabel = new System.Windows.Forms.Label();
            this.ClientIPBox = new System.Windows.Forms.TextBox();
            this.ClientPortBox = new System.Windows.Forms.TextBox();
            this.ChatMsgListBox = new System.Windows.Forms.TextBox();
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ClientPortBox);
            this.groupBox2.Controls.Add(this.ClientIPBox);
            this.groupBox2.Controls.Add(this.ClientPortLabel);
            this.groupBox2.Controls.Add(this.ClientIPLabel);
            this.groupBox2.Controls.Add(this.ClientConnectBtn);
            this.groupBox2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(45, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(717, 58);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ENTER THE SERVER INFO";
            // 
            // SendMsgBtn
            // 
            this.SendMsgBtn.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendMsgBtn.Location = new System.Drawing.Point(687, 350);
            this.SendMsgBtn.Name = "SendMsgBtn";
            this.SendMsgBtn.Size = new System.Drawing.Size(75, 57);
            this.SendMsgBtn.TabIndex = 4;
            this.SendMsgBtn.Text = "SEND";
            this.SendMsgBtn.UseVisualStyleBackColor = true;
            this.SendMsgBtn.Click += new System.EventHandler(this.SendMsgBtn_Click);
            // 
            // ClientConnectBtn
            // 
            this.ClientConnectBtn.Location = new System.Drawing.Point(594, 20);
            this.ClientConnectBtn.Name = "ClientConnectBtn";
            this.ClientConnectBtn.Size = new System.Drawing.Size(75, 23);
            this.ClientConnectBtn.TabIndex = 0;
            this.ClientConnectBtn.Text = "CONNECT";
            this.ClientConnectBtn.UseVisualStyleBackColor = true;
            this.ClientConnectBtn.Click += new System.EventHandler(this.ClientConnectBtn_Click);
            // 
            // ClientIPLabel
            // 
            this.ClientIPLabel.AutoSize = true;
            this.ClientIPLabel.Location = new System.Drawing.Point(23, 25);
            this.ClientIPLabel.Name = "ClientIPLabel";
            this.ClientIPLabel.Size = new System.Drawing.Size(25, 18);
            this.ClientIPLabel.TabIndex = 3;
            this.ClientIPLabel.Text = "IP:";
            // 
            // ClientPortLabel
            // 
            this.ClientPortLabel.AutoSize = true;
            this.ClientPortLabel.Location = new System.Drawing.Point(340, 25);
            this.ClientPortLabel.Name = "ClientPortLabel";
            this.ClientPortLabel.Size = new System.Drawing.Size(44, 18);
            this.ClientPortLabel.TabIndex = 4;
            this.ClientPortLabel.Text = "PORT:";
            // 
            // ClientIPBox
            // 
            this.ClientIPBox.Location = new System.Drawing.Point(64, 22);
            this.ClientIPBox.Name = "ClientIPBox";
            this.ClientIPBox.Size = new System.Drawing.Size(228, 23);
            this.ClientIPBox.TabIndex = 5;
            // 
            // ClientPortBox
            // 
            this.ClientPortBox.Location = new System.Drawing.Point(381, 22);
            this.ClientPortBox.Name = "ClientPortBox";
            this.ClientPortBox.Size = new System.Drawing.Size(207, 23);
            this.ClientPortBox.TabIndex = 6;
            // 
            // ChatMsgListBox
            // 
            this.ChatMsgListBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ChatMsgListBox.Location = new System.Drawing.Point(45, 121);
            this.ChatMsgListBox.Multiline = true;
            this.ChatMsgListBox.Name = "ChatMsgListBox";
            this.ChatMsgListBox.ReadOnly = true;
            this.ChatMsgListBox.Size = new System.Drawing.Size(717, 207);
            this.ChatMsgListBox.TabIndex = 5;
            this.ChatMsgListBox.TabStop = false;
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Location = new System.Drawing.Point(45, 350);
            this.MessageTextBox.Multiline = true;
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Size = new System.Drawing.Size(636, 57);
            this.MessageTextBox.TabIndex = 6;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MessageTextBox);
            this.Controls.Add(this.SendMsgBtn);
            this.Controls.Add(this.ChatMsgListBox);
            this.Controls.Add(this.groupBox2);
            this.Name = "client";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.client_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button SendMsgBtn;
        private System.Windows.Forms.TextBox ClientPortBox;
        private System.Windows.Forms.TextBox ClientIPBox;
        private System.Windows.Forms.Label ClientPortLabel;
        private System.Windows.Forms.Label ClientIPLabel;
        private System.Windows.Forms.Button ClientConnectBtn;
        private System.Windows.Forms.TextBox ChatMsgListBox;
        private System.Windows.Forms.TextBox MessageTextBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}

