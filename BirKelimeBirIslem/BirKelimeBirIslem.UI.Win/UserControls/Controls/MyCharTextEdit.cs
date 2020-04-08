using DevExpress.XtraEditors;
using System.Drawing;
using System.ComponentModel;
using DevExpress.Utils;
using DevExpress.XtraEditors.Mask;

namespace BirKelimeBirIslem.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyCharTextEdit : TextEdit
    {
        public MyCharTextEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            Properties.Appearance.Font = new Font(new FontFamily("Tahoma"), 10f, FontStyle.Bold);
            Properties.Appearance.ForeColor = Color.DarkOrange;
            Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
            Properties.Mask.MaskType = MaskType.Regular;
            Properties.Mask.EditMask = "[A-Z]";
            Properties.Mask.AutoComplete = AutoCompleteType.None;//Boş karaktere 0 konmasını engeller
            Properties.NullValuePrompt = "A";
            Properties.NullText = "A";
            Properties.MaxLength = 1;
            Text = "A";
            ReadOnly = true;
        }

        public override bool EnterMoveNextControl { get; set; } = true;
    }
}
