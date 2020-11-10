using Amazon;
using Amazon.Runtime;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Transfer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace UploaderContent
{
    public partial class FileManager : Telerik.WinControls.UI.RadForm
    {
        public FileManager()
        {
            InitializeComponent();
        }
        configdata S3Config;
        AmazonS3Client client;
        string BuckectSelected { get { return (string)this.BucketsListNames.Text; } }

     

        private void FileManager_Load(object sender, EventArgs e)
        {
            LoadClient();
            var buckets = GetS3Bucket();
            LoadBucketsNames(buckets);
            if (this.BucketsListNames.Items.Count > 0)
            {
                this.BucketsListNames.SelectedIndex = 1;
                LoadFilesKey(this.BuckectSelected);
            }
        }
            
        private void LoadClient()
        {
            S3Config = ConfigData.getCondigData();
            if (S3Config.S3KeyAccessID.Length < 1)
            {
                OpenConfig();
                S3Config = ConfigData.getCondigData();
            }

            client = new AmazonS3Client(S3Config.S3KeyAccessID, S3Config.S3SecretKeyAccess);
        }
        private ListBucketsResponse GetS3Bucket()
        {
            try
            {
                return client.ListBuckets();
            }
            catch (AmazonS3Exception amazonS3Exception)
            {
                throw amazonS3Exception;
            }
        }

        private void OpenConfig()
        {
            var config = new Config();
            config.StartPosition = FormStartPosition.CenterScreen;
            config.ShowDialog();
        }
        private void LoadBucketsNames(ListBucketsResponse buckets)
        {
            List<string> Names = new List<string>();
            foreach(var bucket in buckets.Buckets)
            {
                Names.Add(bucket.BucketName);
            }
            this.BucketsListNames.DataSource = Names;
        }

        private void LoadFilesKey(string bucketName )
        {
            var objects = client.ListObjects(bucketName);

            this.BucketFiles.Items.Clear();
            List<FileModel> files = new List<FileModel>();
            foreach (S3Object item in objects.S3Objects)
            {
                this.BucketFiles.Items.Add(item.Key, item.LastModified, item.Size);
                //files.Add(new FileModel() {Key = item.Key, LastModified= item.LastModified,Size= item.Size });
            }
            //this.BucketFiles.DataSource = files;
        }

        private void DeleteFile(string bucketName)
        {
            if (this.BucketFiles.SelectedIndex < 0)
            {
                RadMessageBox.Show("Please select an Item");
                return;
            }

            var keyName = this.BucketFiles.SelectedItem;
            DeleteObjectRequest request = new DeleteObjectRequest()
            {
                BucketName = bucketName,
                Key = keyName[0].ToString()
            };

            client.DeleteObject(request);
        }

        private async void UploadFile(string bucketName )
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "All Files (*.*)|*.*";
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = false;

            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var fileTransferUtility = new TransferUtility(client);

                    TransferUtilityUploadRequest request = new TransferUtilityUploadRequest()
                    {
                        BucketName = bucketName,
                        FilePath = choofdlog.FileName,
                        Key = choofdlog.SafeFileName
                    };
                    request.UploadProgressEvent +=
                                        new EventHandler<UploadProgressArgs>
                                            (uploadRequest_UploadPartProgressEvent);

                    EnableProgressBar();
                    await fileTransferUtility.UploadAsync(request);
                    MessageBox.Show("Upload Completed");
                    ResetProgressBar();
                }
                catch (AmazonS3Exception e)
                {
                        MessageBox.Show($"Error encountered on server. Message:'{e.Message}' when writing an object");
                }
                catch (Exception e)
                {
                        MessageBox.Show($"Unknown encountered on server. Message:'{e.Message}' when writing an object");
                }
           
            }

        }
         void uploadRequest_UploadPartProgressEvent(object sender, UploadProgressArgs e)
        {
            // Process event.
            this.FileProgressUpload.Maximum = (int)e.TotalBytes;
            this.FileProgressUpload.Value1 = (int)e.TransferredBytes;
        }
        private void UploadMenu_Click(object sender, EventArgs e)
        {
            UploadFile(this.BuckectSelected);
            LoadFilesKey(this.BuckectSelected);
        }

        private void DeleteMenu_Click(object sender, EventArgs e)
        {
            DeleteFile(this.BuckectSelected);
            LoadFilesKey(this.BuckectSelected);
        }

        private void ReloadFilesMenu_Click(object sender, EventArgs e)
        {
            var buckets = GetS3Bucket();
            LoadBucketsNames(buckets);
            if (this.BucketsListNames.Items.Count > 0)
            {
                this.BucketsListNames.SelectedIndex = 1;
                LoadFilesKey(this.BuckectSelected);
            }
        }

        private void ConfigMenu_Click(object sender, EventArgs e)
        {
            OpenConfig();
        }

        private void ResetProgressBar()
        {
            this.FileProgressUpload.Value1 = 0;
            this.FileProgressUpload.Enabled = false;
        }

        private void EnableProgressBar()
        {
            this.FileProgressUpload.Enabled = true;
        }


    }
}
