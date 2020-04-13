using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace BirKelimeBirIslem.UI.Win.Forms
{
    public partial class Anasayfa : DevExpress.XtraEditors.XtraForm
    {
        public Anasayfa()
        {
            InitializeComponent();
        }
        IslemForm.IslemKarti islem = new IslemForm.IslemKarti();
        KelimeForm.KelimeKarti kelime = new KelimeForm.KelimeKarti();

        private void picKelime_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            kelime.ShowDialog();
        }

        private void picIslem_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            islem.ShowDialog();
        }
    }
}