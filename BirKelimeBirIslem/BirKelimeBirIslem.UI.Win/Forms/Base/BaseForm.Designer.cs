namespace BirKelimeBirIslem.UI.Win.Forms.Base
{
    partial class BaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.myLabelEdit2 = new BirKelimeBirIslem.UI.Win.UserControls.Controls.MyLabelEdit();
            this.lblSure = new BirKelimeBirIslem.UI.Win.UserControls.Controls.MyLabelEdit();
            this.myPictureEdit1 = new BirKelimeBirIslem.UI.Win.UserControls.Controls.MyPictureEdit();
            this.myToggleSwitch1 = new BirKelimeBirIslem.UI.Win.UserControls.Controls.MyToggleSwitch();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myPictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myToggleSwitch1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tablePanel1
            // 
            this.tablePanel1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.tablePanel1.Appearance.Options.UseBackColor = true;
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 400F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 70.42F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 104F)});
            this.tablePanel1.Controls.Add(this.myToggleSwitch1);
            this.tablePanel1.Controls.Add(this.myLabelEdit2);
            this.tablePanel1.Controls.Add(this.lblSure);
            this.tablePanel1.Controls.Add(this.myPictureEdit1);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 33F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 37F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 50F)});
            this.tablePanel1.Size = new System.Drawing.Size(733, 100);
            this.tablePanel1.TabIndex = 3;
            // 
            // myLabelEdit2
            // 
            this.myLabelEdit2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.myLabelEdit2.Appearance.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.myLabelEdit2.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.myLabelEdit2.Appearance.Options.UseBackColor = true;
            this.myLabelEdit2.Appearance.Options.UseFont = true;
            this.myLabelEdit2.Appearance.Options.UseForeColor = true;
            this.myLabelEdit2.Appearance.Options.UseTextOptions = true;
            this.myLabelEdit2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.myLabelEdit2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.tablePanel1.SetColumn(this.myLabelEdit2, 2);
            this.myLabelEdit2.Location = new System.Drawing.Point(632, 5);
            this.myLabelEdit2.Name = "myLabelEdit2";
            this.tablePanel1.SetRow(this.myLabelEdit2, 0);
            this.myLabelEdit2.Size = new System.Drawing.Size(98, 23);
            this.myLabelEdit2.TabIndex = 5;
            this.myLabelEdit2.Text = "Süre:";
            // 
            // lblSure
            // 
            this.lblSure.Appearance.BackColor = System.Drawing.Color.Orange;
            this.lblSure.Appearance.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.lblSure.Appearance.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblSure.Appearance.Options.UseBackColor = true;
            this.lblSure.Appearance.Options.UseFont = true;
            this.lblSure.Appearance.Options.UseForeColor = true;
            this.lblSure.Appearance.Options.UseTextOptions = true;
            this.lblSure.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblSure.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.tablePanel1.SetColumn(this.lblSure, 2);
            this.lblSure.Location = new System.Drawing.Point(632, 40);
            this.lblSure.Name = "lblSure";
            this.tablePanel1.SetRow(this.lblSure, 1);
            this.lblSure.Size = new System.Drawing.Size(98, 23);
            this.lblSure.TabIndex = 4;
            this.lblSure.Text = "00:00";
            // 
            // myPictureEdit1
            // 
            this.tablePanel1.SetColumn(this.myPictureEdit1, 0);
            this.myPictureEdit1.Cursor = System.Windows.Forms.Cursors.Default;
            this.myPictureEdit1.EditValue = ((object)(resources.GetObject("myPictureEdit1.EditValue")));
            this.myPictureEdit1.EnterMoveNextControl = true;
            this.myPictureEdit1.Location = new System.Drawing.Point(3, 10);
            this.myPictureEdit1.Name = "myPictureEdit1";
            this.myPictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.myPictureEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.myPictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.myPictureEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.myPictureEdit1.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.myPictureEdit1.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.myPictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.myPictureEdit1.Properties.NullText = "Resim Yok";
            this.myPictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.myPictureEdit1.Properties.ShowMenu = false;
            this.myPictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.tablePanel1.SetRow(this.myPictureEdit1, 0);
            this.tablePanel1.SetRowSpan(this.myPictureEdit1, 3);
            this.myPictureEdit1.Size = new System.Drawing.Size(394, 79);
            this.myPictureEdit1.TabIndex = 3;
            // 
            // myToggleSwitch1
            // 
            this.tablePanel1.SetColumn(this.myToggleSwitch1, 2);
            this.myToggleSwitch1.EnterMoveNextControl = true;
            this.myToggleSwitch1.Location = new System.Drawing.Point(632, 76);
            this.myToggleSwitch1.Name = "myToggleSwitch1";
            this.myToggleSwitch1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic);
            this.myToggleSwitch1.Properties.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.myToggleSwitch1.Properties.Appearance.Options.UseFont = true;
            this.myToggleSwitch1.Properties.Appearance.Options.UseForeColor = true;
            this.myToggleSwitch1.Properties.AutoHeight = false;
            this.myToggleSwitch1.Properties.AutoWidth = true;
            this.myToggleSwitch1.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.myToggleSwitch1.Properties.OffText = "Pasif";
            this.myToggleSwitch1.Properties.OnText = "Aktif";
            this.tablePanel1.SetRow(this.myToggleSwitch1, 3);
            this.myToggleSwitch1.Size = new System.Drawing.Size(80, 18);
            this.myToggleSwitch1.TabIndex = 6;
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(733, 368);
            this.Controls.Add(this.tablePanel1);
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 700);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(650, 400);
            this.Name = "BaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myPictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myToggleSwitch1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private UserControls.Controls.MyLabelEdit myLabelEdit2;
        private UserControls.Controls.MyPictureEdit myPictureEdit1;
        protected UserControls.Controls.MyLabelEdit lblSure;
        protected UserControls.Controls.MyToggleSwitch myToggleSwitch1;
    }
}