using System.ComponentModel;
using DevExpress.XtraEditors;

namespace Insight.MTP.Client.Platform.Users.Views
{
    partial class UserDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserDialog));
            this.labUserName = new DevExpress.XtraEditors.LabelControl();
            this.labLoginName = new DevExpress.XtraEditors.LabelControl();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtAccount = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.memRemark = new DevExpress.XtraEditors.MemoEdit();
            this.labMemo = new DevExpress.XtraEditors.LabelControl();
            this.labEmail = new DevExpress.XtraEditors.LabelControl();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.labMobile = new DevExpress.XtraEditors.LabelControl();
            this.txtMobile = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memRemark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMobile.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.memRemark);
            this.panel.Controls.Add(this.labMemo);
            this.panel.Controls.Add(this.txtMobile);
            this.panel.Controls.Add(this.txtName);
            this.panel.Controls.Add(this.labMobile);
            this.panel.Controls.Add(this.labelControl1);
            this.panel.Controls.Add(this.txtEmail);
            this.panel.Controls.Add(this.labEmail);
            this.panel.Controls.Add(this.txtAccount);
            this.panel.Controls.Add(this.labelControl2);
            this.panel.Size = new System.Drawing.Size(370, 220);
            // 
            // Cancel
            // 
            this.cancel.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cancel.Appearance.Options.UseFont = true;
            this.cancel.Location = new System.Drawing.Point(200, 244);
            // 
            // Confirm
            // 
            this.confirm.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.confirm.Appearance.Options.UseFont = true;
            this.confirm.Location = new System.Drawing.Point(290, 244);
            // 
            // labUserName
            // 
            this.labUserName.Appearance.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labUserName.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labUserName.Appearance.Options.UseFont = true;
            this.labUserName.Appearance.Options.UseForeColor = true;
            this.labUserName.Appearance.Options.UseTextOptions = true;
            this.labUserName.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labUserName.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labUserName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labUserName.Location = new System.Drawing.Point(10, 50);
            this.labUserName.Name = "labUserName";
            this.labUserName.Size = new System.Drawing.Size(80, 21);
            this.labUserName.TabIndex = 1;
            this.labUserName.Text = "用户名：";
            // 
            // labLoginName
            // 
            this.labLoginName.Appearance.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labLoginName.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labLoginName.Appearance.Options.UseFont = true;
            this.labLoginName.Appearance.Options.UseForeColor = true;
            this.labLoginName.Appearance.Options.UseTextOptions = true;
            this.labLoginName.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labLoginName.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labLoginName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labLoginName.Location = new System.Drawing.Point(10, 90);
            this.labLoginName.Name = "labLoginName";
            this.labLoginName.Size = new System.Drawing.Size(80, 21);
            this.labLoginName.TabIndex = 1;
            this.labLoginName.Text = "登录名：";
            // 
            // txtName
            // 
            this.txtName.EnterMoveNextControl = true;
            this.txtName.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtName.Location = new System.Drawing.Point(80, 20);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(260, 20);
            this.txtName.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(0, 20);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(80, 21);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "用户名称：";
            // 
            // txtAccount
            // 
            this.txtAccount.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtAccount.Location = new System.Drawing.Point(80, 50);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(260, 20);
            this.txtAccount.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(0, 50);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(80, 21);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "登录账号：";
            // 
            // memRemark
            // 
            this.memRemark.ImeMode = System.Windows.Forms.ImeMode.On;
            this.memRemark.Location = new System.Drawing.Point(80, 150);
            this.memRemark.Name = "memRemark";
            this.memRemark.Size = new System.Drawing.Size(260, 50);
            this.memRemark.TabIndex = 5;
            // 
            // labMemo
            // 
            this.labMemo.Appearance.Options.UseTextOptions = true;
            this.labMemo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labMemo.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labMemo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labMemo.Location = new System.Drawing.Point(0, 150);
            this.labMemo.Name = "labMemo";
            this.labMemo.Size = new System.Drawing.Size(80, 21);
            this.labMemo.TabIndex = 0;
            this.labMemo.Text = "描述：";
            // 
            // labEmail
            // 
            this.labEmail.Appearance.Options.UseTextOptions = true;
            this.labEmail.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labEmail.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labEmail.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labEmail.Location = new System.Drawing.Point(0, 110);
            this.labEmail.Name = "labEmail";
            this.labEmail.Size = new System.Drawing.Size(80, 21);
            this.labEmail.TabIndex = 0;
            this.labEmail.Text = "电子邮箱：";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(80, 110);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.None;
            this.txtEmail.Properties.Mask.EditMask = "\\w+([.-]?\\w+)*@\\w+([.-]?\\w+)*(\\.\\w{2,3})+";
            this.txtEmail.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtEmail.Size = new System.Drawing.Size(260, 20);
            this.txtEmail.TabIndex = 4;
            // 
            // labMobile
            // 
            this.labMobile.Appearance.Options.UseTextOptions = true;
            this.labMobile.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labMobile.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labMobile.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labMobile.Location = new System.Drawing.Point(0, 80);
            this.labMobile.Name = "labMobile";
            this.labMobile.Size = new System.Drawing.Size(80, 21);
            this.labMobile.TabIndex = 0;
            this.labMobile.Text = "手机号码：";
            // 
            // txtMobile
            // 
            this.txtMobile.EnterMoveNextControl = true;
            this.txtMobile.Location = new System.Drawing.Point(80, 80);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.None;
            this.txtMobile.Properties.Mask.EditMask = "1[3-9]\\d{9}";
            this.txtMobile.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtMobile.Size = new System.Drawing.Size(260, 20);
            this.txtMobile.TabIndex = 3;
            // 
            // UserDialog
            // 
            this.ClientSize = new System.Drawing.Size(384, 282);
            this.Name = "UserDialog";
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memRemark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMobile.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private LabelControl labUserName;
        private LabelControl labLoginName;
        private LabelControl labelControl1;
        private LabelControl labelControl2;
        private LabelControl labMemo;
        internal TextEdit txtName;
        internal TextEdit txtAccount;
        internal MemoEdit memRemark;
        internal TextEdit txtMobile;
        private LabelControl labMobile;
        internal TextEdit txtEmail;
        private LabelControl labEmail;
    }
}