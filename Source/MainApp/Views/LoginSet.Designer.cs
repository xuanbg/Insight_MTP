﻿using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Insight.MTP.Client.MainApp.Views
{
    public partial class LoginSet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginSet));
            this.SaveUserCheckBox = new System.Windows.Forms.CheckBox();
            this.BaseInupt = new DevExpress.XtraEditors.TextEdit();
            this.labBase = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FolderNode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryNode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrgTreeNode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseInupt.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.SaveUserCheckBox);
            this.panel.Controls.Add(this.labBase);
            this.panel.Controls.Add(this.BaseInupt);
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
            // SaveUserCheckBox
            // 
            this.SaveUserCheckBox.AutoSize = true;
            this.SaveUserCheckBox.Location = new System.Drawing.Point(260, 95);
            this.SaveUserCheckBox.Name = "SaveUserCheckBox";
            this.SaveUserCheckBox.Size = new System.Drawing.Size(86, 18);
            this.SaveUserCheckBox.TabIndex = 5;
            this.SaveUserCheckBox.Text = "保存用户名";
            this.SaveUserCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SaveUserCheckBox.UseVisualStyleBackColor = true;
            // 
            // BaseInupt
            // 
            this.BaseInupt.EnterMoveNextControl = true;
            this.BaseInupt.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.BaseInupt.Location = new System.Drawing.Point(100, 60);
            this.BaseInupt.Name = "BaseInupt";
            this.BaseInupt.Size = new System.Drawing.Size(250, 20);
            this.BaseInupt.TabIndex = 3;
            // 
            // labBase
            // 
            this.labBase.Appearance.Options.UseTextOptions = true;
            this.labBase.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labBase.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labBase.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labBase.Location = new System.Drawing.Point(0, 60);
            this.labBase.Name = "labBase";
            this.labBase.Size = new System.Drawing.Size(100, 21);
            this.labBase.TabIndex = 0;
            this.labBase.Text = "验证服务地址：";
            // 
            // LoginSet
            // 
            this.ClientSize = new System.Drawing.Size(384, 211);
            this.Name = "LoginSet";
            this.Text = "设置";
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FolderNode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryNode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrgTreeNode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseInupt.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal CheckBox SaveUserCheckBox;
        internal TextEdit BaseInupt;
        private LabelControl labBase;
    }
}