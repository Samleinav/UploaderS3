using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace UploaderContent
{
    public partial class Config : Telerik.WinControls.UI.RadForm
    {
        public Config()
        {
            InitializeComponent();
        }

        configdata config;
        private void Config_Load(object sender, EventArgs e)
        {

            this.RegionDropList.DataSource = AmazonRegions.List();
            // TODO: esta línea de código carga datos en la tabla 'localdbDataSet.config' Puede moverla o quitarla según sea necesario.
            config = ConfigData.getCondigData();
            this.S3KeyAccessID.Text = config.S3KeyAccessID;
            this.S3SecretKeyAccess.Text = config.S3SecretKeyAccess;
            this.RegionDropList.DisplayMember = config.region;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            config.Add(this.S3KeyAccessID.Text, this.S3SecretKeyAccess.Text, (string)this.RegionDropList.SelectedValue);
            config.SaveChanges();
            this.Close();
        }
    }
}
