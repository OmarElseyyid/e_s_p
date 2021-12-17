
namespace crypto.Forms
{
    partial class FormMsg
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_alogo_msg = new System.Windows.Forms.CheckedListBox();
            this.tb_server_ip = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tb_client_ip = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_connect = new System.Windows.Forms.Button();
            this.tb_msg = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.tb_chat = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_alogo_msg2 = new System.Windows.Forms.CheckedListBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AccessibleDescription = "";
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.CausesValidation = false;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cb_alogo_msg);
            this.panel1.Controls.Add(this.tb_server_ip);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(39, 36);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(523, 68);
            this.panel1.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(244, 12);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Şifreleme Algoritması:";
            // 
            // cb_alogo_msg
            // 
            this.cb_alogo_msg.BackColor = System.Drawing.SystemColors.Control;
            this.cb_alogo_msg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cb_alogo_msg.CheckOnClick = true;
            this.cb_alogo_msg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_alogo_msg.FormattingEnabled = true;
            this.cb_alogo_msg.Items.AddRange(new object[] {
            "SHA-256",
            "SPN-16"});
            this.cb_alogo_msg.Location = new System.Drawing.Point(397, 17);
            this.cb_alogo_msg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_alogo_msg.Name = "cb_alogo_msg";
            this.cb_alogo_msg.Size = new System.Drawing.Size(75, 36);
            this.cb_alogo_msg.TabIndex = 7;
            this.cb_alogo_msg.SelectedIndexChanged += new System.EventHandler(this.cb_alogo_msg_SelectedIndexChanged);
            // 
            // tb_server_ip
            // 
            this.tb_server_ip.Location = new System.Drawing.Point(41, 32);
            this.tb_server_ip.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_server_ip.Multiline = true;
            this.tb_server_ip.Name = "tb_server_ip";
            this.tb_server_ip.Size = new System.Drawing.Size(152, 22);
            this.tb_server_ip.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "IP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 1);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server";
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(566, 34);
            this.btn_start.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(127, 69);
            this.btn_start.TabIndex = 6;
            this.btn_start.Text = "BAŞLAT";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // panel2
            // 
            this.panel2.AccessibleDescription = "";
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.CausesValidation = false;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.tb_client_ip);
            this.panel2.Controls.Add(this.cb_alogo_msg2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(39, 108);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(523, 64);
            this.panel2.TabIndex = 1;
            // 
            // tb_client_ip
            // 
            this.tb_client_ip.Location = new System.Drawing.Point(41, 20);
            this.tb_client_ip.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_client_ip.Multiline = true;
            this.tb_client_ip.Name = "tb_client_ip";
            this.tb_client_ip.Size = new System.Drawing.Size(152, 21);
            this.tb_client_ip.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Client";
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(566, 106);
            this.btn_connect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(127, 67);
            this.btn_connect.TabIndex = 7;
            this.btn_connect.Text = "BAĞLAN";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // tb_msg
            // 
            this.tb_msg.Location = new System.Drawing.Point(39, 474);
            this.tb_msg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_msg.Multiline = true;
            this.tb_msg.Name = "tb_msg";
            this.tb_msg.Size = new System.Drawing.Size(550, 50);
            this.tb_msg.TabIndex = 3;
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(592, 474);
            this.btn_send.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(100, 50);
            this.btn_send.TabIndex = 4;
            this.btn_send.Text = "Gönder";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // tb_chat
            // 
            this.tb_chat.Enabled = false;
            this.tb_chat.Location = new System.Drawing.Point(39, 197);
            this.tb_chat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_chat.Multiline = true;
            this.tb_chat.Name = "tb_chat";
            this.tb_chat.ReadOnly = true;
            this.tb_chat.Size = new System.Drawing.Size(653, 272);
            this.tb_chat.TabIndex = 5;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 181);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Yazışma Ekranı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(244, 10);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Şifreleme Algoritması:";
            // 
            // cb_alogo_msg2
            // 
            this.cb_alogo_msg2.BackColor = System.Drawing.SystemColors.Control;
            this.cb_alogo_msg2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cb_alogo_msg2.CheckOnClick = true;
            this.cb_alogo_msg2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_alogo_msg2.FormattingEnabled = true;
            this.cb_alogo_msg2.Items.AddRange(new object[] {
            "SHA-256",
            "SPN-16"});
            this.cb_alogo_msg2.Location = new System.Drawing.Point(397, 15);
            this.cb_alogo_msg2.Margin = new System.Windows.Forms.Padding(2);
            this.cb_alogo_msg2.Name = "cb_alogo_msg2";
            this.cb_alogo_msg2.Size = new System.Drawing.Size(75, 36);
            this.cb_alogo_msg2.TabIndex = 9;
            this.cb_alogo_msg2.SelectedIndexChanged += new System.EventHandler(this.cb_alogo_msg2_SelectedIndexChanged);
            // 
            // FormMsg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 603);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_chat);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.tb_msg);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormMsg";
            this.Text = "Mesaj Gönder";
            this.Load += new System.EventHandler(this.FormMsg_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tb_msg;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.TextBox tb_server_ip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.TextBox tb_client_ip;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_chat;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.CheckedListBox cb_alogo_msg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckedListBox cb_alogo_msg2;
    }
}