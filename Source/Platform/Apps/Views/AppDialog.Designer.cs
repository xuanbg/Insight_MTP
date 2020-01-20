namespace Insight.MTP.Client.Platform.Apps.Views
{
    partial class AppDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppDialog));
            this.picIcon = new DevExpress.XtraEditors.PictureEdit();
            this.labName = new DevExpress.XtraEditors.LabelControl();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.labAlias = new DevExpress.XtraEditors.LabelControl();
            this.txtAlias = new DevExpress.XtraEditors.TextEdit();
            this.labHost = new DevExpress.XtraEditors.LabelControl();
            this.txtHost = new DevExpress.XtraEditors.TextEdit();
            this.labLife = new DevExpress.XtraEditors.LabelControl();
            this.labRemark = new DevExpress.XtraEditors.LabelControl();
            this.memRemark = new DevExpress.XtraEditors.MemoEdit();
            this.txtlife = new DevExpress.XtraEditors.TextEdit();
            this.labSecond = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FolderNode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryNode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrgTreeNode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlias.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHost.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memRemark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtlife.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.labSecond);
            this.panel.Controls.Add(this.memRemark);
            this.panel.Controls.Add(this.txtlife);
            this.panel.Controls.Add(this.labLife);
            this.panel.Controls.Add(this.txtAlias);
            this.panel.Controls.Add(this.txtHost);
            this.panel.Controls.Add(this.labRemark);
            this.panel.Controls.Add(this.labAlias);
            this.panel.Controls.Add(this.labHost);
            this.panel.Controls.Add(this.txtName);
            this.panel.Controls.Add(this.labName);
            this.panel.Controls.Add(this.picIcon);
            this.panel.Size = new System.Drawing.Size(370, 200);
            // 
            // FolderNode
            // 
            this.FolderNode.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("FolderNode.ImageStream")));
            this.FolderNode.Images.SetKeyName(0, "Item.png");
            this.FolderNode.Images.SetKeyName(1, "Folder.png");
            this.FolderNode.Images.SetKeyName(2, "FolderOpen.png");
            // 
            // CategoryNode
            // 
            this.CategoryNode.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("CategoryNode.ImageStream")));
            this.CategoryNode.Images.SetKeyName(0, "Doc.png");
            this.CategoryNode.Images.SetKeyName(1, "Folder.png");
            this.CategoryNode.Images.SetKeyName(2, "FolderOpen.png");
            // 
            // OrgTreeNode
            // 
            this.OrgTreeNode.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("OrgTreeNode.ImageStream")));
            this.OrgTreeNode.Images.SetKeyName(0, "NodeOrg.png");
            this.OrgTreeNode.Images.SetKeyName(1, "NodeDept.png");
            this.OrgTreeNode.Images.SetKeyName(2, "NodePost.png");
            // 
            // picIcon
            // 
            this.picIcon.Cursor = System.Windows.Forms.Cursors.Default;
            this.picIcon.Location = new System.Drawing.Point(286, 114);
            this.picIcon.Name = "picIcon";
            this.picIcon.Properties.NullText = "单击上传";
            this.picIcon.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picIcon.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.picIcon.Size = new System.Drawing.Size(64, 64);
            this.picIcon.TabIndex = 0;
            // 
            // labName
            // 
            this.labName.Appearance.Options.UseTextOptions = true;
            this.labName.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labName.Location = new System.Drawing.Point(0, 25);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(60, 14);
            this.labName.TabIndex = 0;
            this.labName.Text = "名称：";
            // 
            // txtName
            // 
            this.txtName.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtName.Location = new System.Drawing.Point(60, 23);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(290, 20);
            this.txtName.TabIndex = 1;
            // 
            // labAlias
            // 
            this.labAlias.Appearance.Options.UseTextOptions = true;
            this.labAlias.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labAlias.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labAlias.Location = new System.Drawing.Point(0, 55);
            this.labAlias.Name = "labAlias";
            this.labAlias.Size = new System.Drawing.Size(60, 14);
            this.labAlias.TabIndex = 0;
            this.labAlias.Text = "简称：";
            // 
            // txtAlias
            // 
            this.txtAlias.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtAlias.Location = new System.Drawing.Point(60, 53);
            this.txtAlias.Name = "txtAlias";
            this.txtAlias.Size = new System.Drawing.Size(150, 20);
            this.txtAlias.TabIndex = 2;
            // 
            // labHost
            // 
            this.labHost.Appearance.Options.UseTextOptions = true;
            this.labHost.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labHost.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labHost.Location = new System.Drawing.Point(0, 85);
            this.labHost.Name = "labHost";
            this.labHost.Size = new System.Drawing.Size(60, 14);
            this.labHost.TabIndex = 0;
            this.labHost.Text = "域名：";
            // 
            // txtHost
            // 
            this.txtHost.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtHost.Location = new System.Drawing.Point(60, 83);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(290, 20);
            this.txtHost.TabIndex = 4;
            // 
            // labLife
            // 
            this.labLife.Appearance.Options.UseTextOptions = true;
            this.labLife.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labLife.Location = new System.Drawing.Point(230, 55);
            this.labLife.Name = "labLife";
            this.labLife.Size = new System.Drawing.Size(60, 14);
            this.labLife.TabIndex = 0;
            this.labLife.Text = "令牌周期：";
            // 
            // labRemark
            // 
            this.labRemark.Appearance.Options.UseTextOptions = true;
            this.labRemark.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labRemark.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labRemark.Location = new System.Drawing.Point(0, 115);
            this.labRemark.Name = "labRemark";
            this.labRemark.Size = new System.Drawing.Size(60, 14);
            this.labRemark.TabIndex = 0;
            this.labRemark.Text = "备注：";
            // 
            // memRemark
            // 
            this.memRemark.ImeMode = System.Windows.Forms.ImeMode.On;
            this.memRemark.Location = new System.Drawing.Point(60, 113);
            this.memRemark.Name = "memRemark";
            this.memRemark.Size = new System.Drawing.Size(213, 65);
            this.memRemark.TabIndex = 5;
            // 
            // txtlife
            // 
            this.txtlife.Location = new System.Drawing.Point(290, 53);
            this.txtlife.Name = "txtlife";
            this.txtlife.Properties.Mask.EditMask = "d";
            this.txtlife.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtlife.Size = new System.Drawing.Size(40, 20);
            this.txtlife.TabIndex = 3;
            // 
            // labSecond
            // 
            this.labSecond.Location = new System.Drawing.Point(337, 55);
            this.labSecond.Name = "labSecond";
            this.labSecond.Size = new System.Drawing.Size(12, 14);
            this.labSecond.TabIndex = 0;
            this.labSecond.Text = "秒";
            // 
            // AppDialog
            // 
            this.ClientSize = new System.Drawing.Size(384, 262);
            this.Name = "AppDialog";
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FolderNode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryNode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrgTreeNode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlias.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHost.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memRemark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtlife.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labLife;
        private DevExpress.XtraEditors.LabelControl labRemark;
        private DevExpress.XtraEditors.LabelControl labAlias;
        private DevExpress.XtraEditors.LabelControl labHost;
        private DevExpress.XtraEditors.LabelControl labName;
        private DevExpress.XtraEditors.LabelControl labSecond;
        internal DevExpress.XtraEditors.PictureEdit picIcon;
        internal DevExpress.XtraEditors.TextEdit txtAlias;
        internal DevExpress.XtraEditors.TextEdit txtName;
        internal DevExpress.XtraEditors.TextEdit txtlife;
        internal DevExpress.XtraEditors.MemoEdit memRemark;
        internal DevExpress.XtraEditors.TextEdit txtHost;
    }
}