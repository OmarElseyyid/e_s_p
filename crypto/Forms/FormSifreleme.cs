using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crypto.Forms
{
    public partial class FormSifreleme : Form
    {
        public FormSifreleme()
        {
            InitializeComponent();
           
        }

        private void FormSifreleme_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
        }

        private void btn_sifreleme_Click(object sender, EventArgs e)
        {
            String sifrelenecek_yazi, sifrelenmis_yazi, algoritma;

            sifrelenecek_yazi = tb_yazi.Text;
            algoritma = cb_alogo.Text;
            switch (algoritma)
            {
                case "SHA-256":

                    if (sifrelenecek_yazi == "")
                    {
                        lblSonuc.Text = "Lütfen yazı ekleyiniz.";
                        lblSonuc.ForeColor = System.Drawing.Color.Red;
                    }
                    else
                    {
                        sifrelenmis_yazi = Sifreleme_Algoritmalari.ToSHA256(sifrelenecek_yazi);
                        lblSonuc.Text = sifrelenmis_yazi;
                        lblSonuc.ForeColor = ThemeColor.SecondaryColor;
                    }
                    break;

                case "SPN-16":

                    break;


                default:
                    lblSonuc.Text = "Lütfen algritmayı seçiniz.";
                    lblSonuc.ForeColor = System.Drawing.Color.Red;
                    break;
            }

            
            

        }

        private void cb_alogo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cb_alogo.SelectedIndex;
            int count = cb_alogo.Items.Count;
            for (int x = 0; x < count; x++)
            {
                if (index != x)
                {
                    cb_alogo.SetItemChecked(x, false);
                }
            }
        }
    }
}
