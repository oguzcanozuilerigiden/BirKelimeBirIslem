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

        OyunAyarlari oyunayarlari;
        private DateTime _startTime = DateTime.Now; // Set the starting time
        private TimeSpan _timeSpan = new TimeSpan(0, 1, 0);  // 1 minute 10 seconds as total time
        System.Diagnostics.Stopwatch st = new System.Diagnostics.Stopwatch();

        private void VeriKontrol()
        {
            if (string.IsNullOrEmpty(txtSayi1.Text)) txtSayi1.Text = "1";
            if (string.IsNullOrEmpty(txtSayi2.Text)) txtSayi2.Text = "1";
            if (string.IsNullOrEmpty(txtSayi3.Text)) txtSayi3.Text = "1";
            if (string.IsNullOrEmpty(txtSayi4.Text)) txtSayi4.Text = "1";
            if (string.IsNullOrEmpty(txtSayi5.Text)) txtSayi5.Text = "1";
            if (string.IsNullOrEmpty(txtSayi6.Text)) txtSayi6.Text = "10";
            if (string.IsNullOrEmpty(txtHedef.Text)) txtSayi6.Text = "100";
        }

        private void IslemKarti_Load(object sender, System.EventArgs e)
        {

        }

        private void btnSayiOlustur_Click(object sender, EventArgs e)
        {
            try
            {
                oyunayarlari = new OyunAyarlari();
                lstIslemler.Items.Clear();

                txtSayi1.Text = oyunayarlari.TekBasamakli[0].ToString();
                txtSayi2.Text = oyunayarlari.TekBasamakli[1].ToString();
                txtSayi3.Text = oyunayarlari.TekBasamakli[2].ToString();
                txtSayi4.Text = oyunayarlari.TekBasamakli[3].ToString();
                txtSayi5.Text = oyunayarlari.TekBasamakli[4].ToString();
                txtSayi6.Text = oyunayarlari.IkiBasamakli.ToString();
                txtHedef.Text = oyunayarlari.HedefSayi.ToString();
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
                VeriKontrol();
                lstIslemler.Items.Clear();

                oyunayarlari.TekBasamakli[0] = Convert.ToInt32(txtSayi1.Text);
                oyunayarlari.TekBasamakli[1] = Convert.ToInt32(txtSayi2.Text);
                oyunayarlari.TekBasamakli[2] = Convert.ToInt32(txtSayi3.Text);
                oyunayarlari.TekBasamakli[3] = Convert.ToInt32(txtSayi4.Text);
                oyunayarlari.TekBasamakli[4] = Convert.ToInt32(txtSayi5.Text);
                oyunayarlari.IkiBasamakli = Convert.ToInt32(txtSayi6.Text);
                oyunayarlari.HedefSayi = Convert.ToInt32(txtHedef.Text);

                st.Start();
                var ifd = oyunayarlari.Basla();
                st.Stop();
                lblSure.Text = st.Elapsed.Seconds + ":" + st.Elapsed.Milliseconds;
                lstIslemler.Items.Add(ifd.ToString());
                st.Reset();
            }
            catch (Exception)
            {

                throw;
            }            
        }     

        private void tglSayiGiris_Toggled(object sender, EventArgs e)
        {
            try
            {
                if (tglSayiGiris.IsOn)
                {
                    txtSayi1.ReadOnly = false;
                    txtSayi2.ReadOnly = false;
                    txtSayi3.ReadOnly = false;
                    txtSayi4.ReadOnly = false;
                    txtSayi5.ReadOnly = false;
                    txtSayi6.ReadOnly = false;
                    txtHedef.ReadOnly = false;
                    btnSayiOlustur.Enabled = false;
                }
                else
                {
                    txtSayi1.ReadOnly = true;
                    txtSayi2.ReadOnly = true;
                    txtSayi3.ReadOnly = true;
                    txtSayi4.ReadOnly = true;
                    txtSayi5.ReadOnly = true;
                    txtSayi6.ReadOnly = true;
                    txtHedef.ReadOnly = true;
                    btnSayiOlustur.Enabled = true;
                }
            }
            catch (Exception)
            {
                throw;
            }            
        }
    }
}