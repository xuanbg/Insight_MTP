using System.ComponentModel;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraTab;
using DevExpress.XtraTreeList;

namespace Insight.MTP.Client.Base.Apps.Views
{
    partial class Manager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager));
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.splMain = new DevExpress.XtraEditors.SplitContainerControl();
            this.GrdApp = new DevExpress.XtraGrid.GridControl();
            this.GdvApp = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.splMember = new DevExpress.XtraEditors.SplitContainerControl();
            this.grpMember = new DevExpress.XtraEditors.GroupControl();
            this.TreNav = new DevExpress.XtraTreeList.TreeList();
            this.colNodeType = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colMember = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.grpUser = new DevExpress.XtraEditors.GroupControl();
            this.GrdFunc = new DevExpress.XtraGrid.GridControl();
            this.GdvFunc = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraScrollable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FolderNode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splMain)).BeginInit();
            this.splMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GdvApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splMember)).BeginInit();
            this.splMember.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpMember)).BeginInit();
            this.grpMember.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TreNav)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpUser)).BeginInit();
            this.grpUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdFunc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GdvFunc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraScrollable
            // 
            this.xtraScrollable.Controls.Add(this.splMain);
            this.xtraScrollable.Location = new System.Drawing.Point(0, 31);
            this.xtraScrollable.Padding = new System.Windows.Forms.Padding(5);
            this.xtraScrollable.Size = new System.Drawing.Size(1080, 600);
            // 
            // FolderNode
            // 
            this.FolderNode.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("FolderNode.ImageStream")));
            this.FolderNode.Images.SetKeyName(0, "Item.png");
            this.FolderNode.Images.SetKeyName(1, "Folder.png");
            this.FolderNode.Images.SetKeyName(2, "FolderOpen.png");
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = null;
            this.barDockControlTop.Size = new System.Drawing.Size(0, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 0);
            this.barDockControlBottom.Manager = null;
            this.barDockControlBottom.Size = new System.Drawing.Size(0, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = null;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 0);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Location = new System.Drawing.Point(0, 0);
            this.barDockControlRight.Manager = null;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 0);
            // 
            // splMain
            // 
            this.splMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splMain.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.None;
            this.splMain.Horizontal = false;
            this.splMain.Location = new System.Drawing.Point(5, 5);
            this.splMain.Name = "splMain";
            this.splMain.Panel1.Controls.Add(this.GrdApp);
            this.splMain.Panel1.MinSize = 200;
            this.splMain.Panel2.Controls.Add(this.splMember);
            this.splMain.Panel2.MinSize = 360;
            this.splMain.ScrollBarSmallChange = 1;
            this.splMain.Size = new System.Drawing.Size(1070, 590);
            this.splMain.SplitterPosition = 225;
            this.splMain.TabIndex = 0;
            // 
            // GrdApp
            // 
            this.GrdApp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdApp.Location = new System.Drawing.Point(0, 0);
            this.GrdApp.MainView = this.GdvApp;
            this.GrdApp.Name = "GrdApp";
            this.GrdApp.Size = new System.Drawing.Size(1070, 225);
            this.GrdApp.TabIndex = 0;
            this.GrdApp.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GdvApp});
            // 
            // GdvApp
            // 
            this.GdvApp.GridControl = this.GrdApp;
            this.GdvApp.Name = "GdvApp";
            this.GdvApp.OptionsDetail.EnableMasterViewMode = false;
            // 
            // splMember
            // 
            this.splMember.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splMember.Location = new System.Drawing.Point(0, 0);
            this.splMember.Name = "splMember";
            this.splMember.Panel1.Controls.Add(this.grpMember);
            this.splMember.Panel1.MinSize = 300;
            this.splMember.Panel2.Controls.Add(this.grpUser);
            this.splMember.Panel2.MinSize = 500;
            this.splMember.Size = new System.Drawing.Size(1070, 360);
            this.splMember.SplitterPosition = 300;
            this.splMember.TabIndex = 0;
            // 
            // grpMember
            // 
            this.grpMember.Controls.Add(this.TreNav);
            this.grpMember.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpMember.Location = new System.Drawing.Point(0, 0);
            this.grpMember.Name = "grpMember";
            this.grpMember.Size = new System.Drawing.Size(300, 360);
            this.grpMember.TabIndex = 0;
            this.grpMember.Text = "导航";
            // 
            // TreNav
            // 
            this.TreNav.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.TreNav.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colNodeType,
            this.colMember});
            this.TreNav.DataSource = null;
            this.TreNav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TreNav.Location = new System.Drawing.Point(2, 21);
            this.TreNav.Name = "TreNav";
            this.TreNav.OptionsView.ShowColumns = false;
            this.TreNav.ParentFieldName = "ParentId";
            this.TreNav.Size = new System.Drawing.Size(296, 337);
            this.TreNav.TabIndex = 0;
            // 
            // colNodeType
            // 
            this.colNodeType.FieldName = "nodeType";
            this.colNodeType.Name = "colNodeType";
            this.colNodeType.Width = 67;
            // 
            // colMember
            // 
            this.colMember.FieldName = "name";
            this.colMember.MinWidth = 33;
            this.colMember.Name = "colMember";
            this.colMember.Visible = true;
            this.colMember.VisibleIndex = 0;
            this.colMember.Width = 99;
            // 
            // grpUser
            // 
            this.grpUser.Controls.Add(this.GrdFunc);
            this.grpUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpUser.Location = new System.Drawing.Point(0, 0);
            this.grpUser.Name = "grpUser";
            this.grpUser.Size = new System.Drawing.Size(765, 360);
            this.grpUser.TabIndex = 0;
            this.grpUser.Text = "模块功能";
            // 
            // GrdFunc
            // 
            this.GrdFunc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdFunc.Location = new System.Drawing.Point(2, 21);
            this.GrdFunc.MainView = this.GdvFunc;
            this.GrdFunc.Name = "GrdFunc";
            this.GrdFunc.Size = new System.Drawing.Size(761, 337);
            this.GrdFunc.TabIndex = 0;
            this.GrdFunc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GdvFunc,
            this.gridView1});
            // 
            // GdvFunc
            // 
            this.GdvFunc.GridControl = this.GrdFunc;
            this.GdvFunc.Name = "GdvFunc";
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.GrdFunc;
            this.gridView1.Name = "gridView1";
            // 
            // Manager
            // 
            this.Appearance.Options.UseFont = true;
            this.ClientSize = new System.Drawing.Size(1080, 631);
            this.Name = "Manager";
            this.xtraScrollable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FolderNode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splMain)).EndInit();
            this.splMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrdApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GdvApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splMember)).EndInit();
            this.splMember.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpMember)).EndInit();
            this.grpMember.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TreNav)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpUser)).EndInit();
            this.grpUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrdFunc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GdvFunc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal TreeList TreNav;
        private BarDockControl barDockControlTop;
        private BarDockControl barDockControlBottom;
        private BarDockControl barDockControlLeft;
        private BarDockControl barDockControlRight;
        private SplitContainerControl splMain;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colNodeType;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colMember;
        internal GridControl GrdApp;
        internal GridView GdvApp;
        private SplitContainerControl splMember;
        private GroupControl grpMember;
        private GroupControl grpUser;
        internal GridControl GrdFunc;
        internal GridView GdvFunc;
        private GridView gridView1;
    }
}