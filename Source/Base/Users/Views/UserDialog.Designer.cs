using System.ComponentModel;
using DevExpress.XtraEditors;

namespace Insight.MTP.Client.Base.Users.Views
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
            this.UserName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.LoginName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.Description = new DevExpress.XtraEditors.MemoEdit();
            this.labMemo = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FolderNode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryNode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrgTreeNode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Description.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.Description);
            this.panel.Controls.Add(this.labMemo);
            this.panel.Controls.Add(this.UserName);
            this.panel.Controls.Add(this.labelControl1);
            this.panel.Controls.Add(this.LoginName);
            this.panel.Controls.Add(this.labelControl2);
            // 
            // Cancel
            // 
            this.Cancel.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Cancel.Appearance.Options.UseFont = true;
            // 
            // Confirm
            // 
            this.Confirm.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Confirm.Appearance.Options.UseFont = true;
            // 
            // labUserName
            // 
            this.labUserName.Appearance.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labUserName.Appearance.ForeColor = System.Drawing.Color.Black;
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
            this.labLoginName.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labLoginName.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labLoginName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labLoginName.Location = new System.Drawing.Point(10, 90);
            this.labLoginName.Name = "labLoginName";
            this.labLoginName.Size = new System.Drawing.Size(80, 21);
            this.labLoginName.TabIndex = 1;
            this.labLoginName.Text = "登录名：";
            // 
            // UserName
            // 
            this.UserName.EnterMoveNextControl = true;
            this.UserName.Location = new System.Drawing.Point(80, 20);
            this.UserName.Name = "UserName";
            this.UserName.Properties.NullText = "推荐使用用户姓名（中文）作为用户名";
            this.UserName.Size = new System.Drawing.Size(260, 20);
            this.UserName.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(0, 20);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(80, 21);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "用户名：";
            // 
            // LoginName
            // 
            this.LoginName.Location = new System.Drawing.Point(80, 50);
            this.LoginName.Name = "LoginName";
            this.LoginName.Properties.NullText = "请输入用户登录名，由大小写英文字母组成";
            this.LoginName.Size = new System.Drawing.Size(260, 20);
            this.LoginName.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(0, 50);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(80, 21);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "登录名：";
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(80, 80);
            this.Description.Name = "Description";
            this.Description.Properties.NullText = "请输入用户描述…";
            this.Description.Size = new System.Drawing.Size(260, 50);
            this.Description.TabIndex = 3;
            // 
            // labMemo
            // 
            this.labMemo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labMemo.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labMemo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labMemo.Location = new System.Drawing.Point(0, 80);
            this.labMemo.Name = "labMemo";
            this.labMemo.Size = new System.Drawing.Size(80, 21);
            this.labMemo.TabIndex = 0;
            this.labMemo.Text = "描述：";
            // 
            // UserDialog
            // 
            this.ClientSize = new System.Drawing.Size(384, 212);
            this.Name = "UserDialog";
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FolderNode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryNode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrgTreeNode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Description.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private LabelControl labUserName;
        private LabelControl labLoginName;
        private LabelControl labelControl1;
        private LabelControl labelControl2;
        private LabelControl labMemo;
        internal TextEdit UserName;
        internal TextEdit LoginName;
        internal MemoEdit Description;
    }
}