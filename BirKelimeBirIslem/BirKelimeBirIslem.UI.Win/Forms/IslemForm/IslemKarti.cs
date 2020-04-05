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
        Oyun oyun;
        private void IslemKarti_Load(object sender, System.EventArgs e)
        {
            tglVeriGiris.IsOn = false;
        }
        private void btnSayiOlustur_Click(object sender, EventArgs e)
        {
            oyun = new Oyun();
            lstIslemler.Items.Clear();

            txtSayi1.Text = oyun.TekBasamakli[0].ToString();
            txtSayi2.Text = oyun.TekBasamakli[1].ToString();
            txtSayi3.Text = oyun.TekBasamakli[2].ToString();
            txtSayi4.Text = oyun.TekBasamakli[3].ToString();
            txtSayi5.Text = oyun.TekBasamakli[4].ToString();
            txtSayi6.Text = oyun.IkiBasamakli.ToString();
            lblHedef.Text = oyun.HedefSayi.ToString();
        }
        private void btnBasla_Click(object sender, System.EventArgs e)
        {           
            oyun.TekBasamakli[0] = Convert.ToInt32(txtSayi1.Text);
            oyun.TekBasamakli[1] = Convert.ToInt32(txtSayi2.Text);
            oyun.TekBasamakli[2] = Convert.ToInt32(txtSayi3.Text);
            oyun.TekBasamakli[3] = Convert.ToInt32(txtSayi4.Text);
            oyun.TekBasamakli[4] = Convert.ToInt32(txtSayi5.Text);
            oyun.IkiBasamakli = Convert.ToInt32(txtSayi6.Text);
            oyun.HedefSayi = Convert.ToInt32(lblHedef.Text);

            var ifd= oyun.Basla();
            int adet = ifd.ToString().ToCharArray().Count(c => c == '=');
            lstIslemler.ItemHeight = (adet + 1) * 15;
            lstIslemler.Items.Add(ifd.ToString());
        }

        private void tglVeriGiris_Toggled(object sender, EventArgs e)
        {
            if(tglVeriGiris.IsOn)
            {
                txtSayi1.ReadOnly = true;
                txtSayi2.ReadOnly = true;
                txtSayi3.ReadOnly = true;
                txtSayi4.ReadOnly = true;
                txtSayi5.ReadOnly = true;
                txtSayi6.ReadOnly = true;
            }
            else
            {
                txtSayi1.ReadOnly = false;
                txtSayi2.ReadOnly = false;
                txtSayi3.ReadOnly = false;
                txtSayi4.ReadOnly = false;
                txtSayi5.ReadOnly = false;
                txtSayi6.ReadOnly = false;
            }
        }
    }
}