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
            this.stackPanel1 = new DevExpress.Utils.Layout.StackPanel();
            this.myPictureEdit1 = new BirKelimeBirIslem.UI.Win.UserControls.Controls.MyPictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel1)).BeginInit();
            this.stackPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myPictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // stackPanel1
            // 
            this.stackPanel1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.stackPanel1.Appearance.Options.UseBackColor = true;
            this.stackPanel1.Controls.Add(this.myPictureEdit1);
            this.stackPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.stackPanel1.Location = new System.Drawing.Point(0, 0);
            this.stackPanel1.Name = "stackPanel1";
            this.stackPanel1.Size = new System.Drawing.Size(848, 92);
            this.stackPanel1.TabIndex = 1;
            // 
            // myPictureEdit1
            // 
            this.myPictureEdit1.Cursor = System.Windows.Forms.Cursors.Default;
            this.myPictureEdit1.EditValue = ((object)(resources.GetObject("myPictureEdit1.EditValue")));
            this.myPictureEdit1.EnterMoveNextControl = true;
            this.myPictureEdit1.Location = new System.Drawing.Point(3, 19);
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
            this.myPictureEdit1.Size = new System.Drawing.Size(310, 54);
            this.myPictureEdit1.TabIndex = 0;
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(848, 368);
            this.Controls.Add(this.stackPanel1);
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 700);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(650, 400);
            this.Name = "BaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel1)).EndInit();
            this.stackPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.myPictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.Controls.MyPictureEdit myPictureEdit1;
        private DevExpress.Utils.Layout.StackPanel stackPanel1;
    }
}