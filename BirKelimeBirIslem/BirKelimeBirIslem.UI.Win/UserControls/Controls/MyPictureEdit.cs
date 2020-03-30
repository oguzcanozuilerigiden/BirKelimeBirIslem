using DevExpress.XtraEditors;
using System.Drawing;
using System.ComponentModel;
using DevExpress.XtraEditors.Controls;

namespace BirKelimeBirIslem.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyPictureEdit : PictureEdit
    {
        public MyPictureEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            Properties.Appearance.ForeColor = Color.Maroon;
            Properties.NullText = "Resim Yok";
            Properties.SizeMode = PictureSizeMode.Stretch;
            Properties.BorderStyle = BorderStyles.NoBorder;
            Properties.Appearance.BackColor = Color.Transparent;
            Properties.ShowMenu = false;
        }
        public override bool EnterMoveNextControl { get; set; } = true;
    }
}
