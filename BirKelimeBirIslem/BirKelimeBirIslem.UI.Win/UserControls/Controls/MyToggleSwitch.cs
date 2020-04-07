using DevExpress.XtraEditors;
using System.Drawing;
using System.ComponentModel;
using DevExpress.Utils;

namespace BirKelimeBirIslem.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyToggleSwitch : ToggleSwitch
    {
        public MyToggleSwitch()
        {
            Name = "tglDurum";
            Properties.OffText = "Pasif";
            Properties.OnText = "Aktif";
            Properties.AutoHeight = false;
            Properties.AutoWidth = true;
            Properties.GlyphAlignment = HorzAlignment.Far;
            Properties.Appearance.ForeColor = Color.Maroon;            
            //Properties.GlyphAlignment = HorzAlignment.Center;
            //Properties.GlyphVAlignment = VertAlignment.Center;
            Properties.Appearance.Font = new Font(new FontFamily("Tahoma"), 8.25f, FontStyle.Italic);
            IsOn = false;
        }

        public override bool EnterMoveNextControl { get; set; } = true;
    }
}
