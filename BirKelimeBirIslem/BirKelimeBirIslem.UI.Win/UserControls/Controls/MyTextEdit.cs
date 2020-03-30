using DevExpress.XtraEditors;
using System.Drawing;
using System.ComponentModel;


namespace BirKelimeBirIslem.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyTextEdit : TextEdit
    {
        public MyTextEdit()
        {
            Properties.MaxLength = 50;
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            //Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
            Enabled = true;            
        }
        public override bool EnterMoveNextControl { get; set; } = true;
    }
}
