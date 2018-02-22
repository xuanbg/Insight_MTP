using System.ComponentModel;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace Insight.MTP.Client.Common.Dialogs
{
    partial class Member
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Member));
            this.GrdSelect = new DevExpress.XtraGrid.GridControl();
            this.GdvSelect = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FolderNode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryNode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrgTreeNode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GdvSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panel.Controls.Add(this.GrdSelect);
            this.panel.Size = new System.Drawing.Size(370, 400);
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
            // Cancel
            // 
            this.Cancel.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Cancel.Appearance.Options.UseFont = true;
            this.Cancel.Location = new System.Drawing.Point(200, 424);
            // 
            // Confirm
            // 
            this.Confirm.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Confirm.Appearance.Options.UseFont = true;
            this.Confirm.Location = new System.Drawing.Point(290, 424);
            // 
            // GrdSelect
            // 
            this.GrdSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdSelect.Location = new System.Drawing.Point(0, 0);
            this.GrdSelect.MainView = this.GdvSelect;
            this.GrdSelect.Name = "GrdSelect";
            this.GrdSelect.Size = new System.Drawing.Size(370, 400);
            this.GrdSelect.TabIndex = 1;
            this.GrdSelect.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GdvSelect});
            // 
            // GdvSelect
            // 
            this.GdvSelect.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colName,
            this.colDescription});
            this.GdvSelect.GridControl = this.GrdSelect;
            this.GdvSelect.GroupRowHeight = 25;
            this.GdvSelect.Name = "GdvSelect";
            this.GdvSelect.OptionsFind.AlwaysVisible = true;
            this.GdvSelect.OptionsFind.FindDelay = 100;
            this.GdvSelect.OptionsFind.FindNullPrompt = "输入关键字进行查询...";
            this.GdvSelect.OptionsFind.HighlightFindResults = false;
            this.GdvSelect.OptionsSelection.CheckBoxSelectorColumnWidth = 30;
            this.GdvSelect.OptionsSelection.MultiSelect = true;
            this.GdvSelect.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            // 
            // colName
            // 
            this.colName.Caption = "名称";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            this.colName.Width = 126;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "描述";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 2;
            this.colDescription.Width = 196;
            // 
            // Member
            // 
            this.ClientSize = new System.Drawing.Size(384, 462);
            this.Name = "Member";
            this.Text = "成员对话框";
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FolderNode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryNode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrgTreeNode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GdvSelect)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public GridControl GrdSelect;
        internal GridView GdvSelect;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
    }
}