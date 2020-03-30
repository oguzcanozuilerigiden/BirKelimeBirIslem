using DevExpress.XtraEditors;
using System.Drawing;
using System.ComponentModel;

namespace BirKelimeBirIslem.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MySimpleButton : SimpleButton
    {
        public MySimpleButton()
        {
            Appearance.ForeColor = Color.Maroon;
        }
    }
}
