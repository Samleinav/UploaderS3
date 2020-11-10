namespace UploaderContent
{
    partial class Config
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Config));
            this.S3KeyAccessID = new Telerik.WinControls.UI.RadTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.S3SecretKeyAccess = new Telerik.WinControls.UI.RadTextBox();
            this.RegionDropList = new Telerik.WinControls.UI.RadDropDownList();
            this.Save = new Telerik.WinControls.UI.RadButton();
            this.materialBlueGreyTheme1 = new Telerik.WinControls.Themes.MaterialBlueGreyTheme();
            ((System.ComponentModel.ISupportInitialize)(this.S3KeyAccessID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.S3SecretKeyAccess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegionDropList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Save)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // S3KeyAccessID
            // 
            this.S3KeyAccessID.Location = new System.Drawing.Point(140, 28);
            this.S3KeyAccessID.Name = "S3KeyAccessID";
            this.S3KeyAccessID.Size = new System.Drawing.Size(473, 36);
            this.S3KeyAccessID.TabIndex = 0;
            this.S3KeyAccessID.ThemeName = "MaterialBlueGrey";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "S3 Key Access ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Secret Key Access";
            // 
            // S3SecretKeyAccess
            // 
            this.S3SecretKeyAccess.Location = new System.Drawing.Point(140, 70);
            this.S3SecretKeyAccess.Name = "S3SecretKeyAccess";
            this.S3SecretKeyAccess.Size = new System.Drawing.Size(473, 36);
            this.S3SecretKeyAccess.TabIndex = 3;
            this.S3SecretKeyAccess.ThemeName = "MaterialBlueGrey";
            // 
            // RegionDropList
            // 
            this.RegionDropList.DisplayMember = "Region Select";
            this.RegionDropList.Location = new System.Drawing.Point(17, 127);
            this.RegionDropList.Name = "RegionDropList";
            this.RegionDropList.Size = new System.Drawing.Size(233, 36);
            this.RegionDropList.TabIndex = 5;
            this.RegionDropList.ThemeName = "MaterialBlueGrey";
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(526, 169);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(110, 36);
            this.Save.TabIndex = 6;
            this.Save.Text = "Save";
            this.Save.ThemeName = "MaterialBlueGrey";
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 217);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.RegionDropList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.S3SecretKeyAccess);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.S3KeyAccessID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Config";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Config";
            this.ThemeName = "MaterialBlueGrey";
            this.Load += new System.EventHandler(this.Config_Load);
            ((System.ComponentModel.ISupportInitialize)(this.S3KeyAccessID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.S3SecretKeyAccess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegionDropList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Save)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadTextBox S3KeyAccessID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Telerik.WinControls.UI.RadTextBox S3SecretKeyAccess;
        private Telerik.WinControls.UI.RadDropDownList RegionDropList;
        private Telerik.WinControls.UI.RadButton Save;
        private Telerik.WinControls.Themes.MaterialBlueGreyTheme materialBlueGreyTheme1;
    }
}
