using DevExpress.XtraEditors;
using System.Drawing;
using System.ComponentModel;
using DevExpress.Utils;

namespace BirKelimeBirIslem.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]

    class MyListBoxControl :ListBoxControl
    {
        public MyListBoxControl()
        {
            Appearance.ForeColor = Color.Maroon;
            //Appearance.BackColor = Color.Maroon;
            Appearance.TextOptions.HAlignment = HorzAlignment.Near;
        }
    }
}
