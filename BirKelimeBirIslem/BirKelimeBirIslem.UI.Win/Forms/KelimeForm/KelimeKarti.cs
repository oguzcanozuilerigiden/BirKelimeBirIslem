using BirKelimeBirIslem.UI.Win.Forms.Base;
using BirKelimeBirIslem.UI.Win.Classes.Kelime;
using DevExpress.XtraEditors;
using System;

namespace BirKelimeBirIslem.UI.Win.Forms.KelimeForm
{
    public partial class KelimeKarti : BaseForm
    {
        public KelimeKarti()
        {
            InitializeComponent();
            myToggleSwitch1.Toggled += MyToggleSwitch1_Toggled;
        }

        private void MyToggleSwitch1_Toggled(object sender, EventArgs e)
        {
            try
            {
                if (tglHarfGiris.IsOn)
                {
                    txtHarf1.ReadOnly = false;
                    txtHarf2.ReadOnly = false;
                    txtHarf3.ReadOnly = false;
                    txtHarf4.ReadOnly = false;
                    txtHarf5.ReadOnly = false;
                    txtHarf6.ReadOnly = false;
                    txtHarf7.ReadOnly = false;
                    txtHarf8.ReadOnly = false;
                    txtJoker.ReadOnly = false;
                    btnHarfOlustur.Enabled = false;
                }
                else
                {
                    txtHarf1.ReadOnly = true;
                    txtHarf2.ReadOnly = true;
                    txtHarf3.ReadOnly = true;
                    txtHarf4.ReadOnly = true;
                    txtHarf5.ReadOnly = true;
                    txtHarf6.ReadOnly = true;
                    txtHarf7.ReadOnly = true;
                    txtHarf8.ReadOnly = true;
                    txtJoker.ReadOnly = true;
                    btnHarfOlustur.Enabled = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        KelimeAyarlari kelimeayarlari;

        private DateTime _startTime = DateTime.Now; // Set the starting time
        private TimeSpan _timeSpan = new TimeSpan(0, 1, 0);  // 1 minute 10 seconds as total time
        System.Diagnostics.Stopwatch st = new System.Diagnostics.Stopwatch();

        private bool VeriKontrol()
        {
            if (kelimeayarlari != null)
            {
                XtraMessageBox.Show("Veri Seçimi Yapınız!");
                return false;
            }
            return true;
        }

        private void KelimeKarti_Load(object sender, System.EventArgs e)
        {
            lblSure.Text = "00:00";
        }

        private void BtnDosya_Click(object sender, System.EventArgs e)
        {
            XtraOpenFileDialog dosya = new XtraOpenFileDialog();
            dosya.Filter = "Excel Dosyası |*.xls;*.xlsx";
            dosya.Title = "Excel Dosyası Seçiniz.";
            dosya.FilterIndex = 2;
            dosya.RestoreDirectory = true;
            dosya.ShowDialog();
            BtnDosya.Text = dosya.SafeFileName;

            kelimeayarlari = new KelimeAyarlari(dosya.FileName);
        }

        private void btnHarfOlustur_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (VeriKontrol())
                {
                    kelimeayarlari.Harf();
                    lstKelime.Items.Clear();

                    txtHarf1.Text = kelimeayarlari.Harfler[0].ToString();
                    txtHarf2.Text = kelimeayarlari.Harfler[1].ToString();
                    txtHarf3.Text = kelimeayarlari.Harfler[2].ToString();
                    txtHarf4.Text = kelimeayarlari.Harfler[3].ToString();
                    txtHarf5.Text = kelimeayarlari.Harfler[4].ToString();
                    txtHarf6.Text = kelimeayarlari.Harfler[5].ToString();
                    txtHarf7.Text = kelimeayarlari.Harfler[6].ToString();
                    txtHarf8.Text = kelimeayarlari.Harfler[7].ToString();
                    txtJoker.Text = kelimeayarlari.Harfler[8].ToString();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnBasla_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (VeriKontrol())
                {
                    lstKelime.Items.Clear();
                    kelimeayarlari.Harfler[0] = txtHarf1.Text;
                    kelimeayarlari.Harfler[1] = txtHarf2.Text;
                    kelimeayarlari.Harfler[2] = txtHarf3.Text;
                    kelimeayarlari.Harfler[3] = txtHarf4.Text;
                    kelimeayarlari.Harfler[4] = txtHarf5.Text;
                    kelimeayarlari.Harfler[5] = txtHarf6.Text;
                    kelimeayarlari.Harfler[6] = txtHarf7.Text;
                    kelimeayarlari.Harfler[7] = txtHarf8.Text;
                    kelimeayarlari.Harfler[8] = txtJoker.Text;

                    st.Start();
                    var ifd = kelimeayarlari.Basla();
                    st.Stop();
                    lblSure.Text = st.Elapsed.Seconds + ":" + st.Elapsed.Milliseconds;
                    lstKelime.Items.Add(ifd.ToString());
                    st.Reset();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}