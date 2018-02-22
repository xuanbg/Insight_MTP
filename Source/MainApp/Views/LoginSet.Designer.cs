using System.ComponentModel;
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
            this.labInsight = new DevExpress.XtraEditors.LabelControl();
            this.InsightInput = new DevExpress.XtraEditors.TextEdit();
            this.BaseInupt = new DevExpress.XtraEditors.TextEdit();
            this.labBase = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FolderNode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryNode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrgTreeNode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InsightInput.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseInupt.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.SaveUserCheckBox);
            this.panel.Controls.Add(this.labBase);
            this.panel.Controls.Add(this.labInsight);
            this.panel.Controls.Add(this.BaseInupt);
            this.panel.Controls.Add(this.InsightInput);
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
            this.SaveUserCheckBox.Location = new System.Drawing.Point(20, 115);
            this.SaveUserCheckBox.Name = "SaveUserCheckBox";
            this.SaveUserCheckBox.Size = new System.Drawing.Size(86, 18);
            this.SaveUserCheckBox.TabIndex = 5;
            this.SaveUserCheckBox.Text = "保存用户名";
            this.SaveUserCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SaveUserCheckBox.UseVisualStyleBackColor = true;
            // 
            // labInsight
            // 
            this.labInsight.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labInsight.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labInsight.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labInsight.Location = new System.Drawing.Point(0, 35);
            this.labInsight.Name = "labInsight";
            this.labInsight.Size = new System.Drawing.Size(80, 21);
            this.labInsight.TabIndex = 0;
            this.labInsight.Text = "应用服务：";
            // 
            // InsightInput
            // 
            this.InsightInput.EnterMoveNextControl = true;
            this.InsightInput.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.InsightInput.Location = new System.Drawing.Point(80, 36);
            this.InsightInput.Name = "InsightInput";
            this.InsightInput.Size = new System.Drawing.Size(260, 20);
            this.InsightInput.TabIndex = 1;
            // 
            // BaseInupt
            // 
            this.BaseInupt.EnterMoveNextControl = true;
            this.BaseInupt.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.BaseInupt.Location = new System.Drawing.Point(80, 76);
            this.BaseInupt.Name = "BaseInupt";
            this.BaseInupt.Size = new System.Drawing.Size(260, 20);
            this.BaseInupt.TabIndex = 3;
            // 
            // labBase
            // 
            this.labBase.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labBase.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labBase.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labBase.Location = new System.Drawing.Point(0, 75);
            this.labBase.Name = "labBase";
            this.labBase.Size = new System.Drawing.Size(80, 21);
            this.labBase.TabIndex = 0;
            this.labBase.Text = "验证服务：";
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
            ((System.ComponentModel.ISupportInitialize)(this.InsightInput.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseInupt.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal CheckBox SaveUserCheckBox;
        internal TextEdit InsightInput;
        internal TextEdit BaseInupt;
        private LabelControl labInsight;
        private LabelControl labBase;
    }
}