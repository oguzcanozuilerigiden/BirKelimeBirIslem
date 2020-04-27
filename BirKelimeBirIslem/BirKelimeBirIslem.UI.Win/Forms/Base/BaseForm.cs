using System;

namespace BirKelimeBirIslem.UI.Win.Forms.Base
{
    public partial class BaseForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCikis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Application.Exit();
            this.Close();
        }
    }
}