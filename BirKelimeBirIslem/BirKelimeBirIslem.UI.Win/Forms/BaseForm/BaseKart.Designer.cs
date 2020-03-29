namespace BirKelimeBirIslem.UI.Win.Forms.BaseForm
{
    partial class BaseKart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseKart));
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.ToolTipSeparatorItem toolTipSeparatorItem1 = new DevExpress.Utils.ToolTipSeparatorItem();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem2 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem3 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem2 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.ToolTipSeparatorItem toolTipSeparatorItem2 = new DevExpress.Utils.ToolTipSeparatorItem();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem4 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.SuperToolTip superToolTip3 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem5 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem3 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.ToolTipSeparatorItem toolTipSeparatorItem3 = new DevExpress.Utils.ToolTipSeparatorItem();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem6 = new DevExpress.Utils.ToolTipTitleItem();
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnIslem = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Kelime = new DevExpress.XtraBars.BarButtonItem();
            this.btnCikis = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ımageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ımageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.DrawGroupCaptions = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.DrawGroupsBorderMode = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.ribbonControl.SearchEditItem,
            this.btnIslem,
            this.btn_Kelime,
            this.btnCikis});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 4;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl.ShowQatLocationSelector = false;
            this.ribbonControl.ShowToolbarCustomizeItem = false;
            this.ribbonControl.Size = new System.Drawing.Size(769, 109);
            this.ribbonControl.StatusBar = this.ribbonStatusBar1;
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            this.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // btnIslem
            // 
            this.btnIslem.Caption = "İşlem Oyunu";
            this.btnIslem.Id = 1;
            this.btnIslem.ImageOptions.Image = global::BirKelimeBirIslem.UI.Win.Properties.Resources.autosum_16x16;
            this.btnIslem.ImageOptions.LargeImage = global::BirKelimeBirIslem.UI.Win.Properties.Resources.autosum_32x32;
            this.btnIslem.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I));
            this.btnIslem.Name = "btnIslem";
            toolTipTitleItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            toolTipTitleItem1.Text = "(Ctrl + I)";
            toolTipItem1.LeftIndent = 6;
            toolTipItem1.Text = "İşlem Oyunu";
            toolTipTitleItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            toolTipTitleItem2.LeftIndent = 6;
            toolTipTitleItem2.Text = "İşlem Oyununu Açar.";
            superToolTip1.Items.Add(toolTipTitleItem1);
            superToolTip1.Items.Add(toolTipItem1);
            superToolTip1.Items.Add(toolTipSeparatorItem1);
            superToolTip1.Items.Add(toolTipTitleItem2);
            this.btnIslem.SuperTip = superToolTip1;
            // 
            // btn_Kelime
            // 
            this.btn_Kelime.Caption = "Kelime Oyunu";
            this.btn_Kelime.Id = 2;
            this.btn_Kelime.ImageOptions.Image = global::BirKelimeBirIslem.UI.Win.Properties.Resources.modifystyle_16x16;
            this.btn_Kelime.ImageOptions.LargeImage = global::BirKelimeBirIslem.UI.Win.Properties.Resources.modifystyle_32x32;
            this.btn_Kelime.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.K));
            this.btn_Kelime.Name = "btn_Kelime";
            toolTipTitleItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            toolTipTitleItem3.Text = "(Ctrl + K)";
            toolTipItem2.LeftIndent = 6;
            toolTipItem2.Text = "Kelime Oyunu";
            toolTipTitleItem4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            toolTipTitleItem4.LeftIndent = 6;
            toolTipTitleItem4.Text = "Kelime Oyununu Açar.";
            superToolTip2.Items.Add(toolTipTitleItem3);
            superToolTip2.Items.Add(toolTipItem2);
            superToolTip2.Items.Add(toolTipSeparatorItem2);
            superToolTip2.Items.Add(toolTipTitleItem4);
            this.btn_Kelime.SuperTip = superToolTip2;
            // 
            // btnCikis
            // 
            this.btnCikis.Caption = "Çıkış";
            this.btnCikis.Id = 3;
            this.btnCikis.ImageOptions.Image = global::BirKelimeBirIslem.UI.Win.Properties.Resources.close_16x16;
            this.btnCikis.ImageOptions.LargeImage = global::BirKelimeBirIslem.UI.Win.Properties.Resources.close_32x32;
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.ShortcutKeyDisplayString = "Esc";
            toolTipTitleItem5.ImageOptions.Image = global::BirKelimeBirIslem.UI.Win.Properties.Resources.comment_16x16;
            toolTipTitleItem5.Text = "(Esc)";
            toolTipItem3.LeftIndent = 6;
            toolTipItem3.Text = "Çıkış";
            toolTipTitleItem6.ImageOptions.Image = global::BirKelimeBirIslem.UI.Win.Properties.Resources.suggestion_16x16;
            toolTipTitleItem6.LeftIndent = 6;
            toolTipTitleItem6.Text = "Programı Kapatır.";
            superToolTip3.Items.Add(toolTipTitleItem5);
            superToolTip3.Items.Add(toolTipItem3);
            superToolTip3.Items.Add(toolTipSeparatorItem3);
            superToolTip3.Items.Add(toolTipTitleItem6);
            this.btnCikis.SuperTip = superToolTip3;
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnIslem);
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_Kelime);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnCikis);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 295);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(769, 24);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // ımageCollection1
            // 
            this.ımageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("ımageCollection1.ImageStream")));
            this.ımageCollection1.Images.SetKeyName(0, "logo.jpg");
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureEdit1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureEdit1.Location = new System.Drawing.Point(532, 118);
            this.pictureEdit1.MenuManager = this.ribbonControl;
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(203, 171);
            this.pictureEdit1.TabIndex = 2;
            // 
            // BaseKart
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Highlight;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 319);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl);
            this.IconOptions.ShowIcon = false;
            this.MinimizeBox = false;
            this.Name = "BaseKart";
            this.Ribbon = this.ribbonControl;
            this.ShowInTaskbar = false;
            this.StatusBar = this.ribbonStatusBar1;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ımageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.BarButtonItem btnIslem;
        private DevExpress.XtraBars.BarButtonItem btn_Kelime;
        private DevExpress.XtraBars.BarButtonItem btnCikis;
        private DevExpress.Utils.ImageCollection ımageCollection1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
    }
}