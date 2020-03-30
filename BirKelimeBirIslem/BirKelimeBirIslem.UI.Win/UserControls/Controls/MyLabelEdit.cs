using DevExpress.XtraEditors;
using System.Drawing;
using System.ComponentModel;
using DevExpress.Utils;

namespace BirKelimeBirIslem.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyLabelEdit : LabelControl
    {
        public MyLabelEdit()
        {
            Appearance.Font = new Font(new FontFamily("Tahoma"), 12f, FontStyle.Bold);
            Appearance.ForeColor = Color.Maroon;
            //Appearance.BackColor = Color.Maroon;
            Appearance.TextOptions.HAlignment = HorzAlignment.Center;
        }
    }
}
