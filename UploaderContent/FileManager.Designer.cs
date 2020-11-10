namespace UploaderContent
{
    partial class FileManager
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
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn1 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 0", "Name");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn2 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 1", "Last Modified");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn3 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 2", "Size");
            Telerik.WinControls.UI.ListViewDataItemGroup listViewDataItemGroup1 = new Telerik.WinControls.UI.ListViewDataItemGroup("Files");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileManager));
            this.materialBlueGreyTheme1 = new Telerik.WinControls.Themes.MaterialBlueGreyTheme();
            this.radOpenFileDialog1 = new Telerik.WinControls.UI.RadOpenFileDialog();
            this.BucketFiles = new Telerik.WinControls.UI.RadListView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.BucketsListNames = new Telerik.WinControls.UI.RadDropDownList();
            this.ConfigMenu = new Telerik.WinControls.UI.RadButton();
            this.UploadMenu = new Telerik.WinControls.UI.RadButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DeleteMenu = new Telerik.WinControls.UI.RadButton();
            this.ReloadFilesMenu = new Telerik.WinControls.UI.RadButton();
            this.FileProgressUpload = new Telerik.WinControls.UI.RadProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.BucketFiles)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BucketsListNames)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConfigMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UploadMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReloadFilesMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FileProgressUpload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // BucketFiles
            // 
            this.BucketFiles.AllowDragDrop = true;
            this.BucketFiles.AllowDrop = true;
            listViewDetailColumn1.HeaderText = "Name";
            listViewDetailColumn1.MinWidth = 35F;
            listViewDetailColumn2.HeaderText = "Last Modified";
            listViewDetailColumn3.HeaderText = "Size";
            this.BucketFiles.Columns.AddRange(new Telerik.WinControls.UI.ListViewDetailColumn[] {
            listViewDetailColumn1,
            listViewDetailColumn2,
            listViewDetailColumn3});
            this.BucketFiles.GroupItemSize = new System.Drawing.Size(200, 32);
            listViewDataItemGroup1.Text = "Files";
            this.BucketFiles.Groups.AddRange(new Telerik.WinControls.UI.ListViewDataItemGroup[] {
            listViewDataItemGroup1});
            this.BucketFiles.ItemSize = new System.Drawing.Size(200, 32);
            this.BucketFiles.ItemSpacing = -1;
            this.BucketFiles.Location = new System.Drawing.Point(12, 59);
            this.BucketFiles.Name = "BucketFiles";
            this.BucketFiles.Size = new System.Drawing.Size(794, 407);
            this.BucketFiles.TabIndex = 2;
            this.BucketFiles.ThemeName = "MaterialBlueGrey";
            this.BucketFiles.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.ConfigMenu);
            this.flowLayoutPanel1.Controls.Add(this.BucketsListNames);
            this.flowLayoutPanel1.Controls.Add(this.ReloadFilesMenu);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.UploadMenu);
            this.flowLayoutPanel1.Controls.Add(this.DeleteMenu);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(818, 47);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // BucketsListNames
            // 
            this.BucketsListNames.Location = new System.Drawing.Point(129, 3);
            this.BucketsListNames.Name = "BucketsListNames";
            this.BucketsListNames.Size = new System.Drawing.Size(222, 36);
            this.BucketsListNames.TabIndex = 0;
            this.BucketsListNames.Text = "Select Bucket ";
            this.BucketsListNames.ThemeName = "MaterialBlueGrey";
            // 
            // ConfigMenu
            // 
            this.ConfigMenu.Location = new System.Drawing.Point(3, 3);
            this.ConfigMenu.Name = "ConfigMenu";
            this.ConfigMenu.Size = new System.Drawing.Size(120, 36);
            this.ConfigMenu.TabIndex = 1;
            this.ConfigMenu.Text = "Config";
            this.ConfigMenu.ThemeName = "MaterialBlueGrey";
            this.ConfigMenu.Click += new System.EventHandler(this.ConfigMenu_Click);
            // 
            // UploadMenu
            // 
            this.UploadMenu.Location = new System.Drawing.Point(566, 3);
            this.UploadMenu.Name = "UploadMenu";
            this.UploadMenu.Size = new System.Drawing.Size(120, 36);
            this.UploadMenu.TabIndex = 2;
            this.UploadMenu.Text = "Upload";
            this.UploadMenu.ThemeName = "MaterialBlueGrey";
            this.UploadMenu.Click += new System.EventHandler(this.UploadMenu_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(420, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(140, 36);
            this.panel1.TabIndex = 3;
            // 
            // DeleteMenu
            // 
            this.DeleteMenu.Location = new System.Drawing.Point(692, 3);
            this.DeleteMenu.Name = "DeleteMenu";
            this.DeleteMenu.Size = new System.Drawing.Size(120, 36);
            this.DeleteMenu.TabIndex = 4;
            this.DeleteMenu.Text = "Delete";
            this.DeleteMenu.ThemeName = "MaterialBlueGrey";
            this.DeleteMenu.Click += new System.EventHandler(this.DeleteMenu_Click);
            // 
            // ReloadFilesMenu
            // 
            this.ReloadFilesMenu.Image = global::UploaderContent.Properties.Resources.refresh__2_;
            this.ReloadFilesMenu.Location = new System.Drawing.Point(357, 3);
            this.ReloadFilesMenu.Name = "ReloadFilesMenu";
            this.ReloadFilesMenu.Size = new System.Drawing.Size(57, 36);
            this.ReloadFilesMenu.TabIndex = 5;
            this.ReloadFilesMenu.ThemeName = "MaterialBlueGrey";
            this.ReloadFilesMenu.Click += new System.EventHandler(this.ReloadFilesMenu_Click);
            // 
            // FileProgressUpload
            // 
            this.FileProgressUpload.Dock = System.Windows.Forms.DockStyle.Top;
            this.FileProgressUpload.Enabled = false;
            this.FileProgressUpload.Location = new System.Drawing.Point(0, 47);
            this.FileProgressUpload.Name = "FileProgressUpload";
            this.FileProgressUpload.Size = new System.Drawing.Size(818, 10);
            this.FileProgressUpload.TabIndex = 3;
            this.FileProgressUpload.ThemeName = "MaterialBlueGrey";
            // 
            // FileManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 478);
            this.Controls.Add(this.FileProgressUpload);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.BucketFiles);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FileManager";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "S3 uploader";
            this.ThemeName = "MaterialBlueGrey";
            this.Load += new System.EventHandler(this.FileManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BucketFiles)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BucketsListNames)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConfigMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UploadMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReloadFilesMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FileProgressUpload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.MaterialBlueGreyTheme materialBlueGreyTheme1;
        private Telerik.WinControls.UI.RadOpenFileDialog radOpenFileDialog1;
        private Telerik.WinControls.UI.RadListView BucketFiles;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Telerik.WinControls.UI.RadDropDownList BucketsListNames;
        private Telerik.WinControls.UI.RadButton ConfigMenu;
        private System.Windows.Forms.Panel panel1;
        private Telerik.WinControls.UI.RadButton UploadMenu;
        private Telerik.WinControls.UI.RadButton DeleteMenu;
        private Telerik.WinControls.UI.RadButton ReloadFilesMenu;
        private Telerik.WinControls.UI.RadProgressBar FileProgressUpload;
    }
}