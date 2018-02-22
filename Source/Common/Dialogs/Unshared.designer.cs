using System.ComponentModel;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace Insight.MTP.Client.Common.Dialogs
{
    partial class Unshared
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Unshared));
            this.grdSharing = new DevExpress.XtraGrid.GridControl();
            this.gdvSharing = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.FolderNode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryNode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrgTreeNode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSharing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvSharing)).BeginInit();
            this.SuspendLayout();
            // 
            // imgFolderNode
            // 
            this.FolderNode.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imgFolderNode.ImageStream")));
            this.FolderNode.Images.SetKeyName(0, "Item.png");
            this.FolderNode.Images.SetKeyName(1, "Folder.png");
            this.FolderNode.Images.SetKeyName(2, "FolderOpen.png");
            // 
            // imgCategoryNode
            // 
            this.CategoryNode.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imgCategoryNode.ImageStream")));
            this.CategoryNode.Images.SetKeyName(0, "Doc.png");
            this.CategoryNode.Images.SetKeyName(1, "Folder.png");
            this.CategoryNode.Images.SetKeyName(2, "FolderOpen.png");
            // 
            // imgOrgTreeNode
            // 
            this.OrgTreeNode.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imgOrgTreeNode.ImageStream")));
            this.OrgTreeNode.Images.SetKeyName(0, "NodeOrg.png");
            this.OrgTreeNode.Images.SetKeyName(1, "NodeDept.png");
            this.OrgTreeNode.Images.SetKeyName(2, "NodePost.png");
            // 
            // btnConfirm
            // 
            this.Confirm.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Confirm.Appearance.Options.UseFont = true;
            this.Confirm.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.Cancel.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Cancel.Appearance.Options.UseFont = true;
            this.Cancel.TabIndex = 3;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.grdSharing);
            // 
            // grdSharing
            // 
            this.grdSharing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdSharing.Location = new System.Drawing.Point(2, 2);
            this.grdSharing.MainView = this.gdvSharing;
            this.grdSharing.Name = "grdSharing";
            this.grdSharing.Size = new System.Drawing.Size(366, 146);
            this.grdSharing.TabIndex = 0;
            this.grdSharing.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvSharing});
            // 
            // gdvSharing
            // 
            this.gdvSharing.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gdvSharing.GridControl = this.grdSharing;
            this.gdvSharing.Name = "gdvSharing";
            this.gdvSharing.OptionsSelection.CheckBoxSelectorColumnWidth = 30;
            this.gdvSharing.OptionsSelection.MultiSelect = true;
            this.gdvSharing.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            // 
            // Cancel
            // 
            this.ClientSize = new System.Drawing.Size(384, 212);
            this.Name = "Unshared";
            this.Text = "取消共享";
            this.Load += new System.EventHandler(this.Transfer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FolderNode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryNode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrgTreeNode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdSharing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvSharing)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GridControl grdSharing;
        private GridView gdvSharing;


    }
}