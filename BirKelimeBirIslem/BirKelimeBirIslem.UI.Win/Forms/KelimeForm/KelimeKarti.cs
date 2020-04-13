using BirKelimeBirIslem.UI.Win.Forms.Base;
using BirKelimeBirIslem.UI.Win.Classes.Kelime;
using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace BirKelimeBirIslem.UI.Win.Forms.KelimeForm
{
    public partial class KelimeKarti : BaseForm
    {
        public KelimeKarti()
        {
            InitializeComponent();
            btnBasla.ItemClick += BtnBasla_ItemClick;
            btnOlustur.ItemClick += BtnOlustur_ItemClick;
            tglGiris.ItemClick += TglGiris_ItemClick;
            btnDosya.ItemClick += BtnDosya_ItemClick;      
        }        

        KelimeAyarlari kelimeayarlari;
        XtraOpenFileDialog dosya = new XtraOpenFileDialog();

        private DateTime _startTime = DateTime.Now;
        private TimeSpan _timeSpan = new TimeSpan(0, 1, 0);  // 1 minute 10 seconds as total time
        System.Diagnostics.Stopwatch st = new System.Diagnostics.Stopwatch();

        private bool VeriKontrol()
        {
            if (kelimeayarlari == null)
            {
                XtraMessageBox.Show("Veri Seçimi Yapınız!", "Bilgilendirme", MessageBoxButtons.OK);
                return false;
            }
            else
            {
                if (string.IsNullOrEmpty(txtHarf1.Text)) txtHarf1.Text = "A";
                if (string.IsNullOrEmpty(txtHarf2.Text)) txtHarf2.Text = "A";
                if (string.IsNullOrEmpty(txtHarf3.Text)) txtHarf3.Text = "A";
                if (string.IsNullOrEmpty(txtHarf4.Text)) txtHarf4.Text = "A";
                if (string.IsNullOrEmpty(txtHarf5.Text)) txtHarf5.Text = "A";
                if (string.IsNullOrEmpty(txtHarf6.Text)) txtHarf6.Text = "A";
                if (string.IsNullOrEmpty(txtHarf7.Text)) txtHarf7.Text = "A";
                if (string.IsNullOrEmpty(txtHarf8.Text)) txtHarf8.Text = "A";
                return true;
            }
        }

        private void KelimeKarti_Load(object sender, System.EventArgs e)
        {
            lblSure.Caption = "00:00";
        }

        private void TglGiris_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (tglGiris.Checked)
                {
                    txtHarf1.ReadOnly = false;
                    txtHarf2.ReadOnly = false;
                    txtHarf3.ReadOnly = false;
                    txtHarf4.ReadOnly = false;
                    txtHarf5.ReadOnly = false;
                    txtHarf6.ReadOnly = false;
                    txtHarf7.ReadOnly = false;
                    txtHarf8.ReadOnly = false;
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
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void BtnBasla_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

                    st.Start();
                    var ifd = kelimeayarlari.Basla();
                    st.Stop();
                    lblSure.Caption = st.Elapsed.Seconds + ":" + st.Elapsed.Milliseconds;
                    lstKelime.Items.Add(ifd.ToString());
                    lblPuan.Caption = ifd.puan.ToString();
                    //lstKelime.MakeItemVisible(1);

                    st.Reset();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void BtnOlustur_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void BtnDosya_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                dosya.Filter = "Excel Dosyası |*.xls;*.xlsx";
                dosya.Title = "Excel Dosyası Seçiniz.";
                dosya.FilterIndex = 2;
                dosya.RestoreDirectory = true;
                dosya.ShowDialog();
                if (dosya.FileName != "")
                {
                    kelimeayarlari = new KelimeAyarlari(dosya.FileName);
                    if (kelimeayarlari != null) XtraMessageBox.Show("Veriler Başarıyla Yüklendi", "Bilgilendirme", MessageBoxButtons.OK);
                    else XtraMessageBox.Show("Veri Yükleme Hatası!", "Bilgilendirme", MessageBoxButtons.OK);
                }
                else XtraMessageBox.Show("Dosya Seçilmedi!", "Bilgilendirme", MessageBoxButtons.OK);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}