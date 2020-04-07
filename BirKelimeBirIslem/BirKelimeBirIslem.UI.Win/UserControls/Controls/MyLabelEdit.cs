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
            Appearance.Font = new Font(new FontFamily("Tahoma"), 14f, FontStyle.Bold);
            Appearance.ForeColor = Color.DarkBlue;
            Appearance.BackColor = Color.Orange;
            Appearance.TextOptions.HAlignment = HorzAlignment.Center;
        }
    }
}
