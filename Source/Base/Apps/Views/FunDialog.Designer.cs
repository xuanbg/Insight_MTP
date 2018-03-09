namespace Insight.MTP.Client.Base.Apps.Views
{
    partial class FunDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FunDialog));
            this.picIcon = new DevExpress.XtraEditors.PictureEdit();
            this.labName = new DevExpress.XtraEditors.LabelControl();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.labUrl = new DevExpress.XtraEditors.LabelControl();
            this.txtUrl = new DevExpress.XtraEditors.TextEdit();
            this.labAlias = new DevExpress.XtraEditors.LabelControl();
            this.txtAlias = new DevExpress.XtraEditors.TextEdit();
            this.labIndex = new DevExpress.XtraEditors.LabelControl();
            this.labRemark = new DevExpress.XtraEditors.LabelControl();
            this.memRemark = new DevExpress.XtraEditors.MemoEdit();
            this.speIndex = new DevExpress.XtraEditors.SpinEdit();
            this.labRoute = new DevExpress.XtraEditors.LabelControl();
            this.txtRoute = new DevExpress.XtraEditors.TextEdit();
            this.chkGroup = new DevExpress.XtraEditors.CheckEdit();
            this.chkShow = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FolderNode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryNode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrgTreeNode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlias.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memRemark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speIndex.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRoute.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkShow.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.chkShow);
            this.panel.Controls.Add(this.chkGroup);
            this.panel.Controls.Add(this.memRemark);
            this.panel.Controls.Add(this.labIndex);
            this.panel.Controls.Add(this.txtUrl);
            this.panel.Controls.Add(this.txtRoute);
            this.panel.Controls.Add(this.txtAlias);
            this.panel.Controls.Add(this.labRemark);
            this.panel.Controls.Add(this.labRoute);
            this.panel.Controls.Add(this.labUrl);
            this.panel.Controls.Add(this.labAlias);
            this.panel.Controls.Add(this.txtName);
            this.panel.Controls.Add(this.labName);
            this.panel.Controls.Add(this.picIcon);
            this.panel.Controls.Add(this.speIndex);
            this.panel.Size = new System.Drawing.Size(370, 200);
            // 
            // Cancel
            // 
            this.Cancel.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Cancel.Appearance.Options.UseFont = true;
            this.Cancel.Location = new System.Drawing.Point(200, 224);
            // 
            // Confirm
            // 
            this.Confirm.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Confirm.Appearance.Options.UseFont = true;
            this.Confirm.Location = new System.Drawing.Point(290, 224);
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
            this.picIcon.EditValue = ((object)(resources.GetObject("picIcon.EditValue")));
            this.picIcon.Location = new System.Drawing.Point(165, 24);
            this.picIcon.Name = "picIcon";
            this.picIcon.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picIcon.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.picIcon.Size = new System.Drawing.Size(16, 16);
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
            this.txtName.Location = new System.Drawing.Point(60, 22);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 1;
            // 
            // labUrl
            // 
            this.labUrl.Appearance.Options.UseTextOptions = true;
            this.labUrl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labUrl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labUrl.Location = new System.Drawing.Point(100, 55);
            this.labUrl.Name = "labUrl";
            this.labUrl.Size = new System.Drawing.Size(60, 14);
            this.labUrl.TabIndex = 0;
            this.labUrl.Text = "Url：";
            // 
            // txtUrl
            // 
            this.txtUrl.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtUrl.Location = new System.Drawing.Point(160, 52);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(190, 20);
            this.txtUrl.TabIndex = 5;
            // 
            // labAlias
            // 
            this.labAlias.Appearance.Options.UseTextOptions = true;
            this.labAlias.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labAlias.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labAlias.Location = new System.Drawing.Point(0, 85);
            this.labAlias.Name = "labAlias";
            this.labAlias.Size = new System.Drawing.Size(60, 14);
            this.labAlias.TabIndex = 0;
            this.labAlias.Text = "标识码：";
            // 
            // txtAlias
            // 
            this.txtAlias.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtAlias.Location = new System.Drawing.Point(60, 83);
            this.txtAlias.Name = "txtAlias";
            this.txtAlias.Size = new System.Drawing.Size(290, 20);
            this.txtAlias.TabIndex = 6;
            // 
            // labIndex
            // 
            this.labIndex.Appearance.Options.UseTextOptions = true;
            this.labIndex.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labIndex.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labIndex.Location = new System.Drawing.Point(0, 55);
            this.labIndex.Name = "labIndex";
            this.labIndex.Size = new System.Drawing.Size(60, 14);
            this.labIndex.TabIndex = 0;
            this.labIndex.Text = "序号：";
            // 
            // labRemark
            // 
            this.labRemark.Appearance.Options.UseTextOptions = true;
            this.labRemark.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labRemark.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labRemark.Location = new System.Drawing.Point(0, 145);
            this.labRemark.Name = "labRemark";
            this.labRemark.Size = new System.Drawing.Size(60, 14);
            this.labRemark.TabIndex = 0;
            this.labRemark.Text = "备注：";
            // 
            // memRemark
            // 
            this.memRemark.ImeMode = System.Windows.Forms.ImeMode.On;
            this.memRemark.Location = new System.Drawing.Point(60, 143);
            this.memRemark.Name = "memRemark";
            this.memRemark.Size = new System.Drawing.Size(290, 40);
            this.memRemark.TabIndex = 8;
            // 
            // speIndex
            // 
            this.speIndex.Location = new System.Drawing.Point(60, 52);
            this.speIndex.Name = "speIndex";
            this.speIndex.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.speIndex.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.speIndex.Properties.IsFloatValue = false;
            this.speIndex.Properties.Mask.EditMask = "d";
            this.speIndex.Size = new System.Drawing.Size(40, 20);
            this.speIndex.TabIndex = 3;
            // 
            // labRoute
            // 
            this.labRoute.Appearance.Options.UseTextOptions = true;
            this.labRoute.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labRoute.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labRoute.Location = new System.Drawing.Point(0, 115);
            this.labRoute.Name = "labRoute";
            this.labRoute.Size = new System.Drawing.Size(60, 14);
            this.labRoute.TabIndex = 0;
            this.labRoute.Text = "路由：";
            // 
            // txtRoute
            // 
            this.txtRoute.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtRoute.Location = new System.Drawing.Point(60, 113);
            this.txtRoute.Name = "txtRoute";
            this.txtRoute.Size = new System.Drawing.Size(290, 20);
            this.txtRoute.TabIndex = 7;
            // 
            // chkGroup
            // 
            this.chkGroup.Location = new System.Drawing.Point(195, 23);
            this.chkGroup.Name = "chkGroup";
            this.chkGroup.Properties.Caption = "开始分组";
            this.chkGroup.Size = new System.Drawing.Size(75, 19);
            this.chkGroup.TabIndex = 2;
            // 
            // chkShow
            // 
            this.chkShow.EditValue = true;
            this.chkShow.Location = new System.Drawing.Point(275, 23);
            this.chkShow.Name = "chkShow";
            this.chkShow.Properties.Caption = "显示文字";
            this.chkShow.Size = new System.Drawing.Size(75, 19);
            this.chkShow.TabIndex = 3;
            // 
            // FunDialog
            // 
            this.ClientSize = new System.Drawing.Size(384, 262);
            this.Name = "FunDialog";
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FolderNode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryNode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrgTreeNode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlias.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memRemark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speIndex.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRoute.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkShow.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labIndex;
        private DevExpress.XtraEditors.LabelControl labRemark;
        private DevExpress.XtraEditors.LabelControl labUrl;
        private DevExpress.XtraEditors.LabelControl labAlias;
        private DevExpress.XtraEditors.LabelControl labName;
        internal DevExpress.XtraEditors.PictureEdit picIcon;
        internal DevExpress.XtraEditors.TextEdit txtUrl;
        internal DevExpress.XtraEditors.TextEdit txtName;
        internal DevExpress.XtraEditors.MemoEdit memRemark;
        internal DevExpress.XtraEditors.TextEdit txtAlias;
        internal DevExpress.XtraEditors.TextEdit txtRoute;
        private DevExpress.XtraEditors.LabelControl labRoute;
        internal DevExpress.XtraEditors.CheckEdit chkShow;
        internal DevExpress.XtraEditors.CheckEdit chkGroup;
        internal DevExpress.XtraEditors.SpinEdit speIndex;
    }
}