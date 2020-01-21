namespace Insight.MTP.Client.Platform.Apps.Views
{
    partial class NavDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NavDialog));
            this.picIcon = new DevExpress.XtraEditors.PictureEdit();
            this.labName = new DevExpress.XtraEditors.LabelControl();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.labAlias = new DevExpress.XtraEditors.LabelControl();
            this.txtAlias = new DevExpress.XtraEditors.TextEdit();
            this.labUrl = new DevExpress.XtraEditors.LabelControl();
            this.txtUrl = new DevExpress.XtraEditors.TextEdit();
            this.labRemark = new DevExpress.XtraEditors.LabelControl();
            this.memRemark = new DevExpress.XtraEditors.MemoEdit();
            this.labParent = new DevExpress.XtraEditors.LabelControl();
            this.labIndex = new DevExpress.XtraEditors.LabelControl();
            this.speIndex = new DevExpress.XtraEditors.SpinEdit();
            this.cheLoad = new DevExpress.XtraEditors.CheckEdit();
            this.lueParent = new DevExpress.XtraEditors.TreeListLookUpEdit();
            this.treeListLookUpEdit1TreeList = new DevExpress.XtraTreeList.TreeList();
            this.colName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.imgNav = new DevExpress.Utils.ImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlias.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memRemark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speIndex.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheLoad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueParent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListLookUpEdit1TreeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNav)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.lueParent);
            this.panel.Controls.Add(this.cheLoad);
            this.panel.Controls.Add(this.labParent);
            this.panel.Controls.Add(this.labIndex);
            this.panel.Controls.Add(this.speIndex);
            this.panel.Controls.Add(this.memRemark);
            this.panel.Controls.Add(this.txtAlias);
            this.panel.Controls.Add(this.txtUrl);
            this.panel.Controls.Add(this.labRemark);
            this.panel.Controls.Add(this.labAlias);
            this.panel.Controls.Add(this.labUrl);
            this.panel.Controls.Add(this.txtName);
            this.panel.Controls.Add(this.labName);
            this.panel.Controls.Add(this.picIcon);
            this.panel.Size = new System.Drawing.Size(370, 200);
            // 
            // picIcon
            // 
            this.picIcon.Cursor = System.Windows.Forms.Cursors.Default;
            this.picIcon.Location = new System.Drawing.Point(286, 114);
            this.picIcon.Name = "picIcon";
            this.picIcon.Properties.NullText = "Icon";
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
            this.labName.Location = new System.Drawing.Point(0, 55);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(60, 14);
            this.labName.TabIndex = 0;
            this.labName.Text = "名称：";
            // 
            // txtName
            // 
            this.txtName.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtName.Location = new System.Drawing.Point(60, 53);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(120, 20);
            this.txtName.TabIndex = 4;
            // 
            // labAlias
            // 
            this.labAlias.Appearance.Options.UseTextOptions = true;
            this.labAlias.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labAlias.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labAlias.Location = new System.Drawing.Point(180, 55);
            this.labAlias.Name = "labAlias";
            this.labAlias.Size = new System.Drawing.Size(60, 14);
            this.labAlias.TabIndex = 0;
            this.labAlias.Text = "简称：";
            // 
            // txtAlias
            // 
            this.txtAlias.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtAlias.Location = new System.Drawing.Point(240, 53);
            this.txtAlias.Name = "txtAlias";
            this.txtAlias.Size = new System.Drawing.Size(110, 20);
            this.txtAlias.TabIndex = 5;
            // 
            // labUrl
            // 
            this.labUrl.Appearance.Options.UseTextOptions = true;
            this.labUrl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labUrl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labUrl.Location = new System.Drawing.Point(0, 85);
            this.labUrl.Name = "labUrl";
            this.labUrl.Size = new System.Drawing.Size(60, 14);
            this.labUrl.TabIndex = 0;
            this.labUrl.Text = "Url：";
            // 
            // txtUrl
            // 
            this.txtUrl.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtUrl.Location = new System.Drawing.Point(60, 83);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(290, 20);
            this.txtUrl.TabIndex = 6;
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
            this.memRemark.TabIndex = 7;
            // 
            // labParent
            // 
            this.labParent.Appearance.Options.UseTextOptions = true;
            this.labParent.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labParent.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labParent.Location = new System.Drawing.Point(0, 25);
            this.labParent.Name = "labParent";
            this.labParent.Size = new System.Drawing.Size(60, 14);
            this.labParent.TabIndex = 0;
            this.labParent.Text = "上级：";
            // 
            // labIndex
            // 
            this.labIndex.Appearance.Options.UseTextOptions = true;
            this.labIndex.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labIndex.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labIndex.Location = new System.Drawing.Point(180, 25);
            this.labIndex.Name = "labIndex";
            this.labIndex.Size = new System.Drawing.Size(60, 14);
            this.labIndex.TabIndex = 0;
            this.labIndex.Text = "序号：";
            // 
            // speIndex
            // 
            this.speIndex.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.speIndex.Location = new System.Drawing.Point(240, 22);
            this.speIndex.Name = "speIndex";
            this.speIndex.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.speIndex.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.speIndex.Properties.IsFloatValue = false;
            this.speIndex.Properties.Mask.EditMask = "d";
            this.speIndex.Size = new System.Drawing.Size(33, 20);
            this.speIndex.TabIndex = 2;
            // 
            // cheLoad
            // 
            this.cheLoad.Location = new System.Drawing.Point(285, 23);
            this.cheLoad.Name = "cheLoad";
            this.cheLoad.Properties.Caption = "默认启动";
            this.cheLoad.Size = new System.Drawing.Size(75, 19);
            this.cheLoad.TabIndex = 3;
            // 
            // lueParent
            // 
            this.lueParent.Location = new System.Drawing.Point(60, 22);
            this.lueParent.Name = "lueParent";
            this.lueParent.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueParent.Properties.NullText = "请选择……";
            this.lueParent.Properties.PopupFormMinSize = new System.Drawing.Size(120, 80);
            this.lueParent.Properties.PopupFormSize = new System.Drawing.Size(160, 240);
            this.lueParent.Properties.TreeList = this.treeListLookUpEdit1TreeList;
            this.lueParent.Size = new System.Drawing.Size(120, 20);
            this.lueParent.TabIndex = 1;
            // 
            // treeListLookUpEdit1TreeList
            // 
            this.treeListLookUpEdit1TreeList.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colName});
            this.treeListLookUpEdit1TreeList.Location = new System.Drawing.Point(0, 0);
            this.treeListLookUpEdit1TreeList.Name = "treeListLookUpEdit1TreeList";
            this.treeListLookUpEdit1TreeList.OptionsView.ShowIndentAsRowStyle = true;
            this.treeListLookUpEdit1TreeList.SelectImageList = this.imgNav;
            this.treeListLookUpEdit1TreeList.Size = new System.Drawing.Size(400, 200);
            this.treeListLookUpEdit1TreeList.TabIndex = 0;
            // 
            // colName
            // 
            this.colName.Caption = "名称";
            this.colName.FieldName = "name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // imgNav
            // 
            this.imgNav.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imgNav.ImageStream")));
            this.imgNav.InsertGalleryImage("properties_16x16.png", "images/setup/properties_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/setup/properties_16x16.png"), 0);
            this.imgNav.Images.SetKeyName(0, "properties_16x16.png");
            this.imgNav.InsertGalleryImage("openhyperlink_16x16.png", "images/actions/openhyperlink_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/openhyperlink_16x16.png"), 1);
            this.imgNav.Images.SetKeyName(1, "openhyperlink_16x16.png");
            this.imgNav.InsertGalleryImage("openhyperlink_16x16.png", "images/actions/openhyperlink_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/openhyperlink_16x16.png"), 2);
            this.imgNav.Images.SetKeyName(2, "openhyperlink_16x16.png");
            // 
            // NavDialog
            // 
            this.ClientSize = new System.Drawing.Size(384, 262);
            this.Name = "NavDialog";
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlias.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memRemark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speIndex.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheLoad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueParent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListLookUpEdit1TreeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNav)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labRemark;
        private DevExpress.XtraEditors.LabelControl labAlias;
        private DevExpress.XtraEditors.LabelControl labUrl;
        private DevExpress.XtraEditors.LabelControl labName;
        internal DevExpress.XtraEditors.PictureEdit picIcon;
        internal DevExpress.XtraEditors.TextEdit txtAlias;
        internal DevExpress.XtraEditors.TextEdit txtName;
        internal DevExpress.XtraEditors.MemoEdit memRemark;
        internal DevExpress.XtraEditors.TextEdit txtUrl;
        private DevExpress.XtraEditors.LabelControl labParent;
        private DevExpress.XtraEditors.LabelControl labIndex;
        internal DevExpress.XtraEditors.SpinEdit speIndex;
        internal DevExpress.XtraEditors.CheckEdit cheLoad;
        private DevExpress.XtraTreeList.TreeList treeListLookUpEdit1TreeList;
        internal DevExpress.XtraEditors.TreeListLookUpEdit lueParent;
        private DevExpress.Utils.ImageCollection imgNav;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colName;
    }
}