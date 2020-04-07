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
            AppearancePressed.ForeColor = Color.Maroon;
            AppearanceHovered.ForeColor = Color.DarkOrange;
            AppearanceHovered.BackColor = Color.LightCyan;
            Appearance.Font = new Font(new FontFamily("Tahoma"), 14f, FontStyle.Bold);
        }
    }
}
