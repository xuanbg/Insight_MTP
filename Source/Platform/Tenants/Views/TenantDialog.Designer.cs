namespace Insight.MTP.Client.Base.Tenants.Views
{
    partial class TenantDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TenantDialog));
            this.picIcon = new DevExpress.XtraEditors.PictureEdit();
            this.labName = new DevExpress.XtraEditors.LabelControl();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.labAlias = new DevExpress.XtraEditors.LabelControl();
            this.txtAlias = new DevExpress.XtraEditors.TextEdit();
            this.labAddress = new DevExpress.XtraEditors.LabelControl();
            this.labRemark = new DevExpress.XtraEditors.LabelControl();
            this.memRemark = new DevExpress.XtraEditors.MemoEdit();
            this.labContact = new DevExpress.XtraEditors.LabelControl();
            this.txtContact = new DevExpress.XtraEditors.TextEdit();
            this.labMobile = new DevExpress.XtraEditors.LabelControl();
            this.txtMobile = new DevExpress.XtraEditors.TextEdit();
            this.labEmail = new DevExpress.XtraEditors.LabelControl();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.txtAddress = new DevExpress.XtraEditors.TextEdit();
            this.cbeProvince = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbeCity = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbeCounty = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FolderNode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryNode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrgTreeNode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlias.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memRemark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContact.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMobile.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeProvince.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeCity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeCounty.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.memRemark);
            this.panel.Controls.Add(this.txtEmail);
            this.panel.Controls.Add(this.txtMobile);
            this.panel.Controls.Add(this.txtContact);
            this.panel.Controls.Add(this.labEmail);
            this.panel.Controls.Add(this.txtAlias);
            this.panel.Controls.Add(this.labMobile);
            this.panel.Controls.Add(this.txtAddress);
            this.panel.Controls.Add(this.labContact);
            this.panel.Controls.Add(this.labRemark);
            this.panel.Controls.Add(this.labAlias);
            this.panel.Controls.Add(this.labAddress);
            this.panel.Controls.Add(this.txtName);
            this.panel.Controls.Add(this.labName);
            this.panel.Controls.Add(this.picIcon);
            this.panel.Controls.Add(this.cbeProvince);
            this.panel.Controls.Add(this.cbeCity);
            this.panel.Controls.Add(this.cbeCounty);
            this.panel.Size = new System.Drawing.Size(570, 220);
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
            this.picIcon.Location = new System.Drawing.Point(486, 142);
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
            this.txtName.EnterMoveNextControl = true;
            this.txtName.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtName.Location = new System.Drawing.Point(60, 22);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(260, 20);
            this.txtName.TabIndex = 1;
            // 
            // labAlias
            // 
            this.labAlias.Appearance.Options.UseTextOptions = true;
            this.labAlias.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labAlias.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labAlias.Location = new System.Drawing.Point(320, 25);
            this.labAlias.Name = "labAlias";
            this.labAlias.Size = new System.Drawing.Size(60, 14);
            this.labAlias.TabIndex = 0;
            this.labAlias.Text = "简称：";
            // 
            // txtAlias
            // 
            this.txtAlias.EnterMoveNextControl = true;
            this.txtAlias.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtAlias.Location = new System.Drawing.Point(380, 22);
            this.txtAlias.Name = "txtAlias";
            this.txtAlias.Size = new System.Drawing.Size(170, 20);
            this.txtAlias.TabIndex = 2;
            // 
            // labAddress
            // 
            this.labAddress.Appearance.Options.UseTextOptions = true;
            this.labAddress.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labAddress.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labAddress.Location = new System.Drawing.Point(0, 85);
            this.labAddress.Name = "labAddress";
            this.labAddress.Size = new System.Drawing.Size(60, 14);
            this.labAddress.TabIndex = 0;
            this.labAddress.Text = "地址：";
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
            this.memRemark.Location = new System.Drawing.Point(60, 142);
            this.memRemark.Name = "memRemark";
            this.memRemark.Size = new System.Drawing.Size(420, 64);
            this.memRemark.TabIndex = 10;
            // 
            // labContact
            // 
            this.labContact.Appearance.Options.UseTextOptions = true;
            this.labContact.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labContact.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labContact.Location = new System.Drawing.Point(0, 55);
            this.labContact.Name = "labContact";
            this.labContact.Size = new System.Drawing.Size(60, 14);
            this.labContact.TabIndex = 0;
            this.labContact.Text = "联系人：";
            // 
            // txtContact
            // 
            this.txtContact.EnterMoveNextControl = true;
            this.txtContact.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtContact.Location = new System.Drawing.Point(60, 52);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(100, 20);
            this.txtContact.TabIndex = 3;
            // 
            // labMobile
            // 
            this.labMobile.Appearance.Options.UseTextOptions = true;
            this.labMobile.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labMobile.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labMobile.Location = new System.Drawing.Point(160, 55);
            this.labMobile.Name = "labMobile";
            this.labMobile.Size = new System.Drawing.Size(60, 14);
            this.labMobile.TabIndex = 0;
            this.labMobile.Text = "手机号：";
            // 
            // txtMobile
            // 
            this.txtMobile.EnterMoveNextControl = true;
            this.txtMobile.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtMobile.Location = new System.Drawing.Point(220, 52);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Properties.Mask.EditMask = "1[3-9]\\d{9}";
            this.txtMobile.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtMobile.Size = new System.Drawing.Size(100, 20);
            this.txtMobile.TabIndex = 4;
            // 
            // labEmail
            // 
            this.labEmail.Appearance.Options.UseTextOptions = true;
            this.labEmail.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labEmail.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labEmail.Location = new System.Drawing.Point(320, 55);
            this.labEmail.Name = "labEmail";
            this.labEmail.Size = new System.Drawing.Size(60, 14);
            this.labEmail.TabIndex = 0;
            this.labEmail.Text = "邮箱：";
            // 
            // txtEmail
            // 
            this.txtEmail.EnterMoveNextControl = true;
            this.txtEmail.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtEmail.Location = new System.Drawing.Point(380, 52);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Properties.Mask.EditMask = "\\w+([.-]?\\w+)*@\\w+([.-]?\\w+)*(\\.\\w{2,3})+";
            this.txtEmail.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtEmail.Size = new System.Drawing.Size(170, 20);
            this.txtEmail.TabIndex = 5;
            // 
            // txtAddress
            // 
            this.txtAddress.EnterMoveNextControl = true;
            this.txtAddress.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtAddress.Location = new System.Drawing.Point(60, 112);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(490, 20);
            this.txtAddress.TabIndex = 9;
            // 
            // cbeProvince
            // 
            this.cbeProvince.EnterMoveNextControl = true;
            this.cbeProvince.ImeMode = System.Windows.Forms.ImeMode.On;
            this.cbeProvince.Location = new System.Drawing.Point(60, 82);
            this.cbeProvince.Name = "cbeProvince";
            this.cbeProvince.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbeProvince.Size = new System.Drawing.Size(101, 20);
            this.cbeProvince.TabIndex = 6;
            // 
            // cbeCity
            // 
            this.cbeCity.EnterMoveNextControl = true;
            this.cbeCity.ImeMode = System.Windows.Forms.ImeMode.On;
            this.cbeCity.Location = new System.Drawing.Point(170, 82);
            this.cbeCity.Name = "cbeCity";
            this.cbeCity.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbeCity.Size = new System.Drawing.Size(150, 20);
            this.cbeCity.TabIndex = 7;
            // 
            // cbeCounty
            // 
            this.cbeCounty.EnterMoveNextControl = true;
            this.cbeCounty.ImeMode = System.Windows.Forms.ImeMode.On;
            this.cbeCounty.Location = new System.Drawing.Point(330, 82);
            this.cbeCounty.Name = "cbeCounty";
            this.cbeCounty.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbeCounty.Size = new System.Drawing.Size(220, 20);
            this.cbeCounty.TabIndex = 8;
            // 
            // TenantDialog
            // 
            this.ClientSize = new System.Drawing.Size(584, 282);
            this.Name = "TenantDialog";
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FolderNode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryNode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrgTreeNode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlias.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memRemark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContact.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMobile.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeProvince.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeCity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeCounty.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labRemark;
        private DevExpress.XtraEditors.LabelControl labAlias;
        private DevExpress.XtraEditors.LabelControl labAddress;
        private DevExpress.XtraEditors.LabelControl labName;
        internal DevExpress.XtraEditors.PictureEdit picIcon;
        internal DevExpress.XtraEditors.TextEdit txtAlias;
        internal DevExpress.XtraEditors.TextEdit txtName;
        internal DevExpress.XtraEditors.MemoEdit memRemark;
        internal DevExpress.XtraEditors.TextEdit txtEmail;
        internal DevExpress.XtraEditors.TextEdit txtMobile;
        internal DevExpress.XtraEditors.TextEdit txtContact;
        private DevExpress.XtraEditors.LabelControl labEmail;
        private DevExpress.XtraEditors.LabelControl labMobile;
        internal DevExpress.XtraEditors.TextEdit txtAddress;
        private DevExpress.XtraEditors.LabelControl labContact;
        internal DevExpress.XtraEditors.ComboBoxEdit cbeProvince;
        internal DevExpress.XtraEditors.ComboBoxEdit cbeCity;
        internal DevExpress.XtraEditors.ComboBoxEdit cbeCounty;
    }
}