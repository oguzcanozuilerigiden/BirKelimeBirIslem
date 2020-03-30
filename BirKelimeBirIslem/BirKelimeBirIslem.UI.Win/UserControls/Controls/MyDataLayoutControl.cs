using System.Drawing;
using System.ComponentModel;
using DevExpress.XtraDataLayout;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Utils;
using System.Windows.Forms;
using DevExpress.Utils;

namespace BirKelimeBirIslem.UI.Win.UserControls.Controls
{

    [ToolboxItem(true)]
    public class MyDataLayoutControl : DataLayoutControl
    {
        public MyDataLayoutControl()
        {
            OptionsFocus.EnableAutoTabOrder = false;
        }
        protected override LayoutControlImplementor CreateILayoutControlImplementorCore()
        {
            return new MyLayoutControlImplementor(this);
        }
    }

    internal class MyLayoutControlImplementor : LayoutControlImplementor
    {
        public MyLayoutControlImplementor(ILayoutControlOwner owner) : base(owner)
        {
        }

        public override BaseLayoutItem CreateLayoutItem(LayoutGroup parent)
        {
            var item = base.CreateLayoutItem(parent);
            item.AppearanceItemCaption.ForeColor = Color.Maroon;
            item.TextLocation = Locations.Top;
            item.AppearanceItemCaption.TextOptions.HAlignment = HorzAlignment.Center;
            item.AppearanceItemCaption.Font = new Font(new FontFamily("Tahoma"), 12f, FontStyle.Bold);

            return item;
        }

        public override LayoutGroup CreateLayoutGroup(LayoutGroup parent)
        {
            var grp = base.CreateLayoutGroup(parent);
            grp.LayoutMode = LayoutMode.Table;

            grp.OptionsTableLayoutGroup.ColumnDefinitions[0].SizeType = SizeType.Absolute;//0. Sütunu Sabit Yap
            grp.OptionsTableLayoutGroup.ColumnDefinitions[0].Width = 100;

            grp.OptionsTableLayoutGroup.ColumnDefinitions[1].SizeType = SizeType.Absolute;//1. Sütunu Yüzde Ayarlı yap
            grp.OptionsTableLayoutGroup.ColumnDefinitions[1].Width = 100;

            grp.OptionsTableLayoutGroup.ColumnDefinitions.Add(new ColumnDefinition { SizeType = SizeType.Absolute, Width = 100 });//Yeni sütun ekle
            grp.OptionsTableLayoutGroup.ColumnDefinitions.Add(new ColumnDefinition { SizeType = SizeType.Absolute, Width = 100 });//Yeni sütun ekle
            grp.OptionsTableLayoutGroup.ColumnDefinitions.Add(new ColumnDefinition { SizeType = SizeType.Absolute, Width = 100 });//Yeni sütun ekle

            grp.OptionsTableLayoutGroup.ColumnDefinitions.Add(new ColumnDefinition { SizeType = SizeType.Percent, Width = 100 });//Yeni sütun ekle
            grp.OptionsTableLayoutGroup.ColumnDefinitions.Add(new ColumnDefinition { SizeType = SizeType.Absolute, Width = 100 });//Yeni sütun ekle
            grp.OptionsTableLayoutGroup.ColumnDefinitions.Add(new ColumnDefinition { SizeType = SizeType.Absolute, Width = 100 });//Yeni sütun ekle
            //Satır İşlemleri
            grp.OptionsTableLayoutGroup.RowDefinitions.Clear();//Satırları Temizler

            for (int i = 0; i < 3; i++)
            {
                //9 satır + 1 satır
                grp.OptionsTableLayoutGroup.RowDefinitions.Add(new RowDefinition
                {                    
                    SizeType = SizeType.Absolute,
                    Height = 50
                });
                if (i + 1 != 3) continue;
                grp.OptionsTableLayoutGroup.RowDefinitions.Add(new RowDefinition
                {
                    SizeType = SizeType.Percent,
                    Height = 100
                });
            }

            return grp;
        }        
    }
}
