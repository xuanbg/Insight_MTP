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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NavDialog));
            this.labName = new DevExpress.XtraEditors.LabelControl();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.labModule = new DevExpress.XtraEditors.LabelControl();
            this.txtModule = new DevExpress.XtraEditors.TextEdit();
            this.labIcon = new DevExpress.XtraEditors.LabelControl();
            this.txtIcon = new DevExpress.XtraEditors.TextEdit();
            this.labIndex = new DevExpress.XtraEditors.LabelControl();
            this.speIndex = new DevExpress.XtraEditors.SpinEdit();
            this.cheLoad = new DevExpress.XtraEditors.CheckEdit();
            this.imgNav = new DevExpress.Utils.ImageCollection();
            this.labFile = new DevExpress.XtraEditors.LabelControl();
            this.txtFile = new DevExpress.XtraEditors.TextEdit();
            this.chkGroup = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModule.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIcon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speIndex.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheLoad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNav)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFile.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkGroup.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.chkGroup);
            this.panel.Controls.Add(this.cheLoad);
            this.panel.Controls.Add(this.labIndex);
            this.panel.Controls.Add(this.speIndex);
            this.panel.Controls.Add(this.txtFile);
            this.panel.Controls.Add(this.txtModule);
            this.panel.Controls.Add(this.labFile);
            this.panel.Controls.Add(this.txtIcon);
            this.panel.Controls.Add(this.labModule);
            this.panel.Controls.Add(this.labIcon);
            this.panel.Controls.Add(this.txtName);
            this.panel.Controls.Add(this.labName);
            this.panel.Size = new System.Drawing.Size(370, 130);
            // 
            // cancel
            // 
            this.cancel.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cancel.Appearance.Options.UseFont = true;
            this.cancel.Location = new System.Drawing.Point(200, 154);
            // 
            // confirm
            // 
            this.confirm.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.confirm.Appearance.Options.UseFont = true;
            this.confirm.Location = new System.Drawing.Point(290, 154);
            // 
            // close
            // 
            this.close.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.close.Appearance.Options.UseFont = true;
            this.close.Location = new System.Drawing.Point(290, 104);
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
            this.txtName.EnterMoveNextControl = true;
            this.txtName.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtName.Location = new System.Drawing.Point(60, 23);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(110, 20);
            this.txtName.TabIndex = 2;
            // 
            // labModule
            // 
            this.labModule.Appearance.Options.UseTextOptions = true;
            this.labModule.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labModule.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labModule.Location = new System.Drawing.Point(0, 60);
            this.labModule.Name = "labModule";
            this.labModule.Size = new System.Drawing.Size(60, 14);
            this.labModule.TabIndex = 0;
            this.labModule.Text = "模块名：";
            // 
            // txtModule
            // 
            this.txtModule.EnterMoveNextControl = true;
            this.txtModule.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtModule.Location = new System.Drawing.Point(60, 58);
            this.txtModule.Name = "txtModule";
            this.txtModule.Size = new System.Drawing.Size(110, 20);
            this.txtModule.TabIndex = 3;
            // 
            // labIcon
            // 
            this.labIcon.Appearance.Options.UseTextOptions = true;
            this.labIcon.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labIcon.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labIcon.Location = new System.Drawing.Point(0, 95);
            this.labIcon.Name = "labIcon";
            this.labIcon.Size = new System.Drawing.Size(60, 14);
            this.labIcon.TabIndex = 0;
            this.labIcon.Text = "图标Url：";
            // 
            // txtIcon
            // 
            this.txtIcon.EnterMoveNextControl = true;
            this.txtIcon.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtIcon.Location = new System.Drawing.Point(60, 93);
            this.txtIcon.Name = "txtIcon";
            this.txtIcon.Size = new System.Drawing.Size(213, 20);
            this.txtIcon.TabIndex = 5;
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
            this.speIndex.EnterMoveNextControl = true;
            this.speIndex.Location = new System.Drawing.Point(240, 22);
            this.speIndex.Name = "speIndex";
            this.speIndex.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.speIndex.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.speIndex.Properties.IsFloatValue = false;
            this.speIndex.Properties.Mask.EditMask = "d";
            this.speIndex.Size = new System.Drawing.Size(33, 20);
            this.speIndex.TabIndex = 1;
            // 
            // cheLoad
            // 
            this.cheLoad.Location = new System.Drawing.Point(285, 93);
            this.cheLoad.Name = "cheLoad";
            this.cheLoad.Properties.Caption = "默认启动";
            this.cheLoad.Size = new System.Drawing.Size(75, 19);
            this.cheLoad.TabIndex = 6;
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
            // labFile
            // 
            this.labFile.Appearance.Options.UseTextOptions = true;
            this.labFile.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labFile.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labFile.Location = new System.Drawing.Point(180, 60);
            this.labFile.Name = "labFile";
            this.labFile.Size = new System.Drawing.Size(60, 14);
            this.labFile.TabIndex = 0;
            this.labFile.Text = "文件名：";
            // 
            // txtFile
            // 
            this.txtFile.EnterMoveNextControl = true;
            this.txtFile.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtFile.Location = new System.Drawing.Point(240, 58);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(110, 20);
            this.txtFile.TabIndex = 4;
            // 
            // chkGroup
            // 
            this.chkGroup.Enabled = false;
            this.chkGroup.EnterMoveNextControl = true;
            this.chkGroup.Location = new System.Drawing.Point(285, 23);
            this.chkGroup.Name = "chkGroup";
            this.chkGroup.Properties.Caption = "一级导航";
            this.chkGroup.Size = new System.Drawing.Size(75, 19);
            this.chkGroup.TabIndex = 0;
            // 
            // NavDialog
            // 
            this.ClientSize = new System.Drawing.Size(384, 192);
            this.Name = "NavDialog";
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModule.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIcon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speIndex.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheLoad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNav)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFile.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkGroup.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labModule;
        private DevExpress.XtraEditors.LabelControl labIcon;
        private DevExpress.XtraEditors.LabelControl labName;
        private DevExpress.XtraEditors.LabelControl labIndex;
        private DevExpress.Utils.ImageCollection imgNav;
        private DevExpress.XtraEditors.LabelControl labFile;
        public DevExpress.XtraEditors.TextEdit txtModule;
        public DevExpress.XtraEditors.TextEdit txtFile;
        public DevExpress.XtraEditors.TextEdit txtIcon;
        public DevExpress.XtraEditors.CheckEdit chkGroup;
        public DevExpress.XtraEditors.TextEdit txtName;
        public DevExpress.XtraEditors.SpinEdit speIndex;
        public DevExpress.XtraEditors.CheckEdit cheLoad;
    }
}