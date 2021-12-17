
namespace crypto.Forms
{
    partial class FormDosya
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
            this.btn_connect = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_send = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_client_ip = new System.Windows.Forms.TextBox();
            this.cb_alogo_dosya2 = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_alogo_dosya = new System.Windows.Forms.CheckedListBox();
            this.tb_server_ip = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(564, 106);
            this.btn_connect.Margin = new System.Windows.Forms.Padding(2);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(127, 67);
            this.btn_connect.TabIndex = 15;
            this.btn_connect.Text = "BAĞLAN";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(564, 34);
            this.btn_start.Margin = new System.Windows.Forms.Padding(2);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(127, 69);
            this.btn_start.TabIndex = 14;
            this.btn_start.Text = "BAŞLAT";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(37, 295);
            this.btn_send.Margin = new System.Windows.Forms.Padding(2);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(100, 50);
            this.btn_send.TabIndex = 12;
            this.btn_send.Text = "Gönder";
            this.btn_send.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.AccessibleDescription = "";
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.CausesValidation = false;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.tb_client_ip);
            this.panel2.Controls.Add(this.cb_alogo_dosya2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(37, 108);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(523, 64);
            this.panel2.TabIndex = 10;
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
            // tb_client_ip
            // 
            this.tb_client_ip.Location = new System.Drawing.Point(41, 20);
            this.tb_client_ip.Margin = new System.Windows.Forms.Padding(2);
            this.tb_client_ip.Multiline = true;
            this.tb_client_ip.Name = "tb_client_ip";
            this.tb_client_ip.Size = new System.Drawing.Size(152, 21);
            this.tb_client_ip.TabIndex = 3;
            // 
            // cb_alogo_dosya2
            // 
            this.cb_alogo_dosya2.BackColor = System.Drawing.SystemColors.Control;
            this.cb_alogo_dosya2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cb_alogo_dosya2.CheckOnClick = true;
            this.cb_alogo_dosya2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_alogo_dosya2.FormattingEnabled = true;
            this.cb_alogo_dosya2.Items.AddRange(new object[] {
            "SHA-256",
            "SPN-16"});
            this.cb_alogo_dosya2.Location = new System.Drawing.Point(397, 15);
            this.cb_alogo_dosya2.Margin = new System.Windows.Forms.Padding(2);
            this.cb_alogo_dosya2.Name = "cb_alogo_dosya2";
            this.cb_alogo_dosya2.Size = new System.Drawing.Size(75, 36);
            this.cb_alogo_dosya2.TabIndex = 9;
            this.cb_alogo_dosya2.SelectedIndexChanged += new System.EventHandler(this.cb_alogo_dosya2_SelectedIndexChanged);
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
            // panel1
            // 
            this.panel1.AccessibleDescription = "";
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.CausesValidation = false;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cb_alogo_dosya);
            this.panel1.Controls.Add(this.tb_server_ip);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(37, 36);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(523, 68);
            this.panel1.TabIndex = 9;
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
            // cb_alogo_dosya
            // 
            this.cb_alogo_dosya.BackColor = System.Drawing.SystemColors.Control;
            this.cb_alogo_dosya.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cb_alogo_dosya.CheckOnClick = true;
            this.cb_alogo_dosya.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_alogo_dosya.FormattingEnabled = true;
            this.cb_alogo_dosya.Items.AddRange(new object[] {
            "SHA-256",
            "SPN-16"});
            this.cb_alogo_dosya.Location = new System.Drawing.Point(397, 17);
            this.cb_alogo_dosya.Margin = new System.Windows.Forms.Padding(2);
            this.cb_alogo_dosya.Name = "cb_alogo_dosya";
            this.cb_alogo_dosya.Size = new System.Drawing.Size(75, 36);
            this.cb_alogo_dosya.TabIndex = 7;
            this.cb_alogo_dosya.SelectedIndexChanged += new System.EventHandler(this.cb_alogo_dosya_SelectedIndexChanged);
            // 
            // tb_server_ip
            // 
            this.tb_server_ip.Location = new System.Drawing.Point(41, 32);
            this.tb_server_ip.Margin = new System.Windows.Forms.Padding(2);
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
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // FormDosya
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 604);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormDosya";
            this.Text = "Dosya Gönder";
            this.Load += new System.EventHandler(this.FormDosya_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_client_ip;
        private System.Windows.Forms.CheckedListBox cb_alogo_dosya2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckedListBox cb_alogo_dosya;
        private System.Windows.Forms.TextBox tb_server_ip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}