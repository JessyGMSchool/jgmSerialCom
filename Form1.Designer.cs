namespace lab1_JGM
{
    partial class frmLab1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLab1));
            this.hostnameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.tmr1000ms = new System.Windows.Forms.Timer(this.components);
            this.quitter = new System.Windows.Forms.Button();
            this.btnUDP = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnUART = new System.Windows.Forms.Button();
            this.CmdTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comPortTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSendOnce = new System.Windows.Forms.Button();
            this.currentlyUsingtextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // hostnameTextBox
            // 
            this.hostnameTextBox.Location = new System.Drawing.Point(18, 24);
            this.hostnameTextBox.Name = "hostnameTextBox";
            this.hostnameTextBox.Size = new System.Drawing.Size(293, 20);
            this.hostnameTextBox.TabIndex = 0;
            this.hostnameTextBox.Text = "10.240.8.127";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hostname :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port :";
            // 
            // portTextBox
            // 
            this.portTextBox.Location = new System.Drawing.Point(18, 75);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.portTextBox.Size = new System.Drawing.Size(293, 20);
            this.portTextBox.TabIndex = 3;
            this.portTextBox.Text = "8266";
            // 
            // tmr1000ms
            // 
            this.tmr1000ms.Interval = 1000;
            this.tmr1000ms.Tick += new System.EventHandler(this.tmr1000ms_Tick);
            // 
            // quitter
            // 
            this.quitter.Location = new System.Drawing.Point(18, 263);
            this.quitter.Name = "quitter";
            this.quitter.Size = new System.Drawing.Size(127, 24);
            this.quitter.TabIndex = 15;
            this.quitter.Text = "Quitter";
            this.quitter.UseVisualStyleBackColor = true;
            this.quitter.Click += new System.EventHandler(this.quitter_Click);
            // 
            // btnUDP
            // 
            this.btnUDP.Location = new System.Drawing.Point(18, 173);
            this.btnUDP.Name = "btnUDP";
            this.btnUDP.Size = new System.Drawing.Size(127, 24);
            this.btnUDP.TabIndex = 12;
            this.btnUDP.Text = "UDP";
            this.btnUDP.UseVisualStyleBackColor = true;
            this.btnUDP.Click += new System.EventHandler(this.button_UDP);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(151, 232);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(127, 24);
            this.btnSend.TabIndex = 13;
            this.btnSend.Text = "Send Data (loop)";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.button_SendData);
            // 
            // btnUART
            // 
            this.btnUART.BackColor = System.Drawing.Color.Lime;
            this.btnUART.Enabled = false;
            this.btnUART.Location = new System.Drawing.Point(18, 203);
            this.btnUART.Name = "btnUART";
            this.btnUART.Size = new System.Drawing.Size(127, 24);
            this.btnUART.TabIndex = 14;
            this.btnUART.Text = "UART";
            this.btnUART.UseVisualStyleBackColor = false;
            this.btnUART.Click += new System.EventHandler(this.button_UART);
            // 
            // CmdTextBox
            // 
            this.CmdTextBox.Location = new System.Drawing.Point(18, 126);
            this.CmdTextBox.Name = "CmdTextBox";
            this.CmdTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CmdTextBox.Size = new System.Drawing.Size(293, 20);
            this.CmdTextBox.TabIndex = 17;
            this.CmdTextBox.Text = "fur {\"type\":\"ADC\",\"volts\":5.3,\"ts\":\"\"}";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Commande :";
            // 
            // comPortTextBox
            // 
            this.comPortTextBox.Location = new System.Drawing.Point(212, 206);
            this.comPortTextBox.Name = "comPortTextBox";
            this.comPortTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comPortTextBox.Size = new System.Drawing.Size(66, 20);
            this.comPortTextBox.TabIndex = 18;
            this.comPortTextBox.Text = "COM5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(151, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Com port :";
            // 
            // btnSendOnce
            // 
            this.btnSendOnce.Location = new System.Drawing.Point(18, 232);
            this.btnSendOnce.Name = "btnSendOnce";
            this.btnSendOnce.Size = new System.Drawing.Size(127, 24);
            this.btnSendOnce.TabIndex = 20;
            this.btnSendOnce.Text = "Send Data (once)";
            this.btnSendOnce.UseVisualStyleBackColor = true;
            this.btnSendOnce.Click += new System.EventHandler(this.btnSendOnce_Click);
            // 
            // currentlyUsingtextBox
            // 
            this.currentlyUsingtextBox.Location = new System.Drawing.Point(154, 173);
            this.currentlyUsingtextBox.Name = "currentlyUsingtextBox";
            this.currentlyUsingtextBox.ReadOnly = true;
            this.currentlyUsingtextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.currentlyUsingtextBox.Size = new System.Drawing.Size(124, 20);
            this.currentlyUsingtextBox.TabIndex = 21;
            this.currentlyUsingtextBox.Text = "Currently using UART";
            // 
            // frmLab1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(341, 350);
            this.Controls.Add(this.currentlyUsingtextBox);
            this.Controls.Add(this.btnSendOnce);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comPortTextBox);
            this.Controls.Add(this.CmdTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.quitter);
            this.Controls.Add(this.btnUART);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnUDP);
            this.Controls.Add(this.portTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hostnameTextBox);
            this.Name = "frmLab1";
            this.Text = "jgmSerialCom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox hostnameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox portTextBox;
        private System.Windows.Forms.Timer tmr1000ms;
        private System.Windows.Forms.Button quitter;
        private System.Windows.Forms.Button btnUDP;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnUART;
        private System.Windows.Forms.TextBox CmdTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox comPortTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSendOnce;
        private System.Windows.Forms.TextBox currentlyUsingtextBox;
    }
}

