using System.ComponentModel;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraTab;
using DevExpress.XtraTreeList;

namespace Insight.MTP.Client.Base.Tenants.Views
{
    partial class BindDialog
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BindDialog));
            this.grdApp = new DevExpress.XtraGrid.GridControl();
            this.gdvApp = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FolderNode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryNode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrgTreeNode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvApp)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.grdApp);
            this.panel.Size = new System.Drawing.Size(510, 300);
            this.panel.Visible = false;
            // 
            // Cancel
            // 
            this.Cancel.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Cancel.Appearance.Options.UseFont = true;
            this.Cancel.Location = new System.Drawing.Point(340, 324);
            // 
            // Confirm
            // 
            this.Confirm.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Confirm.Appearance.Options.UseFont = true;
            this.Confirm.Location = new System.Drawing.Point(430, 324);
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
            // grdApp
            // 
            this.grdApp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdApp.Location = new System.Drawing.Point(2, 2);
            this.grdApp.MainView = this.gdvApp;
            this.grdApp.Name = "grdApp";
            this.grdApp.Size = new System.Drawing.Size(506, 296);
            this.grdApp.TabIndex = 0;
            this.grdApp.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvApp});
            // 
            // gdvApp
            // 
            this.gdvApp.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gdvApp.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName});
            this.gdvApp.GridControl = this.grdApp;
            this.gdvApp.Name = "gdvApp";
            this.gdvApp.OptionsFind.AlwaysVisible = true;
            this.gdvApp.OptionsFind.FindDelay = 100;
            this.gdvApp.OptionsFind.FindNullPrompt = "输入关键字进行查询…";
            this.gdvApp.OptionsFind.HighlightFindResults = false;
            this.gdvApp.OptionsSelection.CheckBoxSelectorColumnWidth = 30;
            this.gdvApp.OptionsSelection.MultiSelect = true;
            this.gdvApp.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            // 
            // colName
            // 
            this.colName.Caption = "名称";
            this.colName.FieldName = "name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            this.colName.Width = 140;
            // 
            // Member
            // 
            this.ClientSize = new System.Drawing.Size(524, 362);
            this.Name = "Member";
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FolderNode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryNode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrgTreeNode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvApp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal GridControl grdApp;
        internal GridView gdvApp;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
    }
}
