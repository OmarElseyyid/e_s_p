
namespace crypto
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btn_dosya = new System.Windows.Forms.Button();
            this.btn_msg = new System.Windows.Forms.Button();
            this.btn_sifreleme = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btn_dosya);
            this.panelMenu.Controls.Add(this.btn_msg);
            this.panelMenu.Controls.Add(this.btn_sifreleme);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(335, 757);
            this.panelMenu.TabIndex = 0;
            // 
            // btn_dosya
            // 
            this.btn_dosya.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_dosya.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(57)))), ((int)(((byte)(88)))));
            this.btn_dosya.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dosya.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dosya.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_dosya.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btn_dosya.Location = new System.Drawing.Point(0, 227);
            this.btn_dosya.Name = "btn_dosya";
            this.btn_dosya.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_dosya.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_dosya.Size = new System.Drawing.Size(335, 69);
            this.btn_dosya.TabIndex = 3;
            this.btn_dosya.Text = "Dosya Paylaşımı";
            this.btn_dosya.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dosya.UseVisualStyleBackColor = true;
            this.btn_dosya.Click += new System.EventHandler(this.btn_dosya_Click);
            // 
            // btn_msg
            // 
            this.btn_msg.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_msg.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(57)))), ((int)(((byte)(88)))));
            this.btn_msg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_msg.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_msg.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_msg.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btn_msg.Location = new System.Drawing.Point(0, 158);
            this.btn_msg.Name = "btn_msg";
            this.btn_msg.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_msg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_msg.Size = new System.Drawing.Size(335, 69);
            this.btn_msg.TabIndex = 2;
            this.btn_msg.Text = "Mesajlaşma";
            this.btn_msg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_msg.UseVisualStyleBackColor = true;
            this.btn_msg.Click += new System.EventHandler(this.btn_msg_Click);
            // 
            // btn_sifreleme
            // 
            this.btn_sifreleme.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_sifreleme.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(57)))), ((int)(((byte)(88)))));
            this.btn_sifreleme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sifreleme.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sifreleme.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_sifreleme.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btn_sifreleme.Location = new System.Drawing.Point(0, 89);
            this.btn_sifreleme.Name = "btn_sifreleme";
            this.btn_sifreleme.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_sifreleme.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_sifreleme.Size = new System.Drawing.Size(335, 69);
            this.btn_sifreleme.TabIndex = 1;
            this.btn_sifreleme.Text = "Şifreleme";
            this.btn_sifreleme.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sifreleme.UseVisualStyleBackColor = true;
            this.btn_sifreleme.Click += new System.EventHandler(this.btn_sifreleme_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.lblLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(335, 89);
            this.panelLogo.TabIndex = 0;
            // 
            // lblLogo
            // 
            this.lblLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Palace Script MT", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.LightGray;
            this.lblLogo.Location = new System.Drawing.Point(78, 33);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(163, 31);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "MS Encryption";
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.Teal;
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(335, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1039, 89);
            this.panelTitleBar.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Montserrat", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(374, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(247, 59);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Ana Sayıfa";
            // 
            // panelDesktop
            // 
            this.panelDesktop.Controls.Add(this.panel1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(335, 89);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1039, 668);
            this.panelDesktop.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(109, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(828, 519);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Peru;
            this.label2.Location = new System.Drawing.Point(90, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(635, 68);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yazı şifreleme ve şifreli mesaj gönderme programı\r\n\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(199, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 96);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yazılım Sınama Ödevi\r\n\r\nMahmud ELSEYYİDÖMER - 192802066\r\nABDULSELAM MUHAMMED HASA" +
    "N - 192803003\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 757);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelDesktop.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btn_sifreleme;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btn_dosya;
        private System.Windows.Forms.Button btn_msg;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

