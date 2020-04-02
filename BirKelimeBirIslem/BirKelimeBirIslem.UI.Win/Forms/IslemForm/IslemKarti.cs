using BirKelimeBirIslem.UI.Win.Classes;
using BirKelimeBirIslem.UI.Win.Forms.Base;
using System;
using System.Linq;

namespace BirKelimeBirIslem.UI.Win.Forms.IslemForm
{
    public partial class IslemKarti : BaseForm
    {
        public IslemKarti()
        {
            InitializeComponent();
        }
        SayiOyun so;
        private void IslemKarti_Load(object sender, System.EventArgs e)
        {

            so = new SayiOyun();
            txtSayi1.Text = so.BirBasamaklilar[0].ToString();
            txtSayi2.Text = so.BirBasamaklilar[1].ToString();
            txtSayi3.Text = so.BirBasamaklilar[2].ToString();
            txtSayi4.Text = so.BirBasamaklilar[3].ToString();
            txtSayi5.Text = so.BirBasamaklilar[4].ToString();
            txtSayi6.Text = so.IkiBasamakli.ToString();
            lblHedef.Text = so.HedefSayi.ToString();
        }

        private void btnBasla_Click(object sender, System.EventArgs e)
        {
            lstIslemler.Items.Clear();
            so.BirBasamaklilar[0] = Convert.ToInt32(txtSayi1.Text);
            so.BirBasamaklilar[1] = Convert.ToInt32(txtSayi2.Text);
            so.BirBasamaklilar[2] = Convert.ToInt32(txtSayi3.Text);
            so.BirBasamaklilar[3] = Convert.ToInt32(txtSayi4.Text);
            so.BirBasamaklilar[4] = Convert.ToInt32(txtSayi5.Text);
            so.IkiBasamakli = Convert.ToInt32(txtSayi6.Text);
            so.HedefSayi = Convert.ToInt32(lblHedef.Text);

           var ifd= so.EnYakinIfade();
            int adet = ifd.ToString().ToCharArray().Count(c => c == '=');
            lstIslemler.ItemHeight = (adet + 1) * 15;
            lstIslemler.Items.Add(ifd.ToString());
            int fark = Math.Abs(Convert.ToInt32(ifd.Sayi.ToString()) - so.HedefSayi);
            string puan;
            switch (fark)
            {
                case 0:
                    puan = "10 (Tam sonuç)";
                    break;
                case 1:
                    puan = "9 (Bir yaklaşık sonuç)";
                    break;
                case 2:
                    puan = "8 (İki yaklaşık sonuç)";
                    break;
                case 3:
                    puan = "7 (Üç yaklaşık sonuç)";
                    break;
                case 4:
                    puan = "6 (Dört yaklaşık sonuç)";
                    break;
                case 5:
                    puan = "5 (Beş yaklaşık sonuç)";
                    break;
                case 6:
                    puan = "4 (Altı yaklaşık sonuç)";
                    break;
                case 7:
                    puan = "3 (Yedi yaklaşık sonuç)";
                    break;
                case 8:
                    puan = "2 (Sekiz yaklaşık sonuç)";
                    break;
                case 9:
                    puan = "1 (Dokuz yaklaşık sonuç)";
                    break;
                default:
                    puan = "Puan alamadınız!";
                    break;
            }

            //int adet = ifd.ToString().ToCharArray().Count(c => c == '=');
            //lstIslemler.ItemHeight = (adet + 1) * 15;
            lstIslemler.Items.Add("Puanınız:" + puan);
        }
    }
}