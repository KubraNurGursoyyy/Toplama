using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deniz_Hocanın__Dersi_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        int Topla(int sayi1, int sayi2)
        {
            int toplam;
            toplam = sayi1 + sayi2;
            return toplam;
        }


        void EkranHazirla()
        {
            txtBirinciSayi.Text = "0";
            txtİkinciSayi.Text = "0";
            txtBirinciSayi.Focus();

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            EkranHazirla();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            EkranHazirla();
        }

        private void txtBirinciSayi_TextChanged(object sender, EventArgs e)
        {

        }

        private Boolean Doğrula()
        {
            try
            {
                Convert.ToInt32(txtBirinciSayi.Text);
                Convert.ToInt32(txtİkinciSayi.Text);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            if (Doğrula())
            {
                int birinciSayi = Convert.ToInt32(txtBirinciSayi.Text);
                int ikinciSayi = Convert.ToInt32(txtİkinciSayi.Text);
                txtSonuc.Text = Convert.ToString(Topla(birinciSayi, ikinciSayi));
                LogYaz("İşlem Başarılı! Sonuç :" + Topla(birinciSayi, ikinciSayi));
            }
            else
            {
                MessageBox.Show("Girdiğiniz değerlerde hata var!");
                LogYaz("İşlem Başarısız.");
            }
            EkranHazirla();
        }

        private void txtBirinciSayi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtİkinciSayi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void FormTopla_Load(object sender, EventArgs e)
        {

        }

        private void FormTopla_Shown(object sender, EventArgs e)
        {

        }

        private void txtSonuc_TextChanged(object sender, EventArgs e)
        {

        }

        void LogYaz(string mesaj)
        {
            ListView1.Items.Add(mesaj);

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            ListView1.Items.Remove(ListView1.FocusedItem);
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSıfırla_Click(object sender, EventArgs e)
        {
            ListView1.Items.Clear();
        }
    }
}
