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
            this.myPictureEdit1 = new BirKelimeBirIslem.UI.Win.UserControls.Controls.MyPictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.myPictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // myPictureEdit1
            // 
            this.myPictureEdit1.Cursor = System.Windows.Forms.Cursors.Default;
            this.myPictureEdit1.EditValue = ((object)(resources.GetObject("myPictureEdit1.EditValue")));
            this.myPictureEdit1.EnterMoveNextControl = true;
            this.myPictureEdit1.Location = new System.Drawing.Point(3, 43);
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
            this.ClientSize = new System.Drawing.Size(898, 368);
            this.Controls.Add(this.myPictureEdit1);
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(900, 400);
            this.Name = "BaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.myPictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.Controls.MyPictureEdit myPictureEdit1;
    }
}