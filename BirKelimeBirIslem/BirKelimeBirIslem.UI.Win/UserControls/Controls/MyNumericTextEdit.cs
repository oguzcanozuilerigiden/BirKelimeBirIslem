using DevExpress.XtraEditors;
using System.Drawing;
using System.ComponentModel;
using DevExpress.Utils;
using DevExpress.XtraEditors.Mask;

namespace BirKelimeBirIslem.UI.Win.UserControls
{
    [ToolboxItem(true)]
    public class MyNumericTextEdit : TextEdit
    {
        public MyNumericTextEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            Properties.Appearance.Font = new Font(new FontFamily("Tahoma"), 10f, FontStyle.Bold);
            Properties.Appearance.ForeColor = Color.DarkOrange;
            Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
            Properties.Mask.MaskType = MaskType.Regular;
            Properties.Mask.EditMask = @"\d?";
            Properties.Mask.AutoComplete = AutoCompleteType.None;//Boş karaktere 0 konmasını engeller
            Properties.NullText = "1";
            Properties.NullValuePrompt = "1";
            Properties.MaxLength = 1;
            Text = "1";
            ReadOnly = true;
        }

        public override bool EnterMoveNextControl { get; set; } = true;
    }
}
