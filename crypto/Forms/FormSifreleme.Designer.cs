
namespace crypto.Forms
{
    partial class FormSifreleme
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
            this.btn_sifreleme = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_yazi = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.cb_alogo = new System.Windows.Forms.CheckedListBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_sifreleme
            // 
            this.btn_sifreleme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_sifreleme.AutoSize = true;
            this.btn_sifreleme.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sifreleme.Location = new System.Drawing.Point(69, 402);
            this.btn_sifreleme.Name = "btn_sifreleme";
            this.btn_sifreleme.Size = new System.Drawing.Size(971, 64);
            this.btn_sifreleme.TabIndex = 1;
            this.btn_sifreleme.Text = "Şifrele";
            this.btn_sifreleme.UseVisualStyleBackColor = true;
            this.btn_sifreleme.Click += new System.EventHandler(this.btn_sifreleme_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.cb_alogo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tb_yazi);
            this.panel1.Location = new System.Drawing.Point(69, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(971, 290);
            this.panel1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Algritma Seçiniz:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifrelenecek Yazı:";
            // 
            // tb_yazi
            // 
            this.tb_yazi.Location = new System.Drawing.Point(25, 49);
            this.tb_yazi.Multiline = true;
            this.tb_yazi.Name = "tb_yazi";
            this.tb_yazi.Size = new System.Drawing.Size(922, 119);
            this.tb_yazi.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblSonuc);
            this.panel2.Location = new System.Drawing.Point(69, 489);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(971, 190);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-5, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Şifreleme Sonucu:";
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSonuc.Location = new System.Drawing.Point(14, 42);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(239, 24);
            this.lblSonuc.TabIndex = 1;
            this.lblSonuc.Text = "sfdfyutıowtyeu8yrfıowueyf98";
            // 
            // cb_alogo
            // 
            this.cb_alogo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cb_alogo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cb_alogo.CheckOnClick = true;
            this.cb_alogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_alogo.FormattingEnabled = true;
            this.cb_alogo.Items.AddRange(new object[] {
            "SHA-256",
            "SPN-16"});
            this.cb_alogo.Location = new System.Drawing.Point(122, 215);
            this.cb_alogo.Name = "cb_alogo";
            this.cb_alogo.Size = new System.Drawing.Size(131, 66);
            this.cb_alogo.TabIndex = 4;
            this.cb_alogo.SelectedIndexChanged += new System.EventHandler(this.cb_alogo_SelectedIndexChanged);
            // 
            // FormSifreleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 748);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_sifreleme);
            this.Name = "FormSifreleme";
            this.Text = "Şifreleme";
            this.Load += new System.EventHandler(this.FormSifreleme_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_sifreleme;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_yazi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox cb_alogo;
    }
}