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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager));
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.splMain = new DevExpress.XtraEditors.SplitContainerControl();
            this.grdApp = new DevExpress.XtraGrid.GridControl();
            this.gdvApp = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colalias = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colremark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splMember = new DevExpress.XtraEditors.SplitContainerControl();
            this.grpMember = new DevExpress.XtraEditors.GroupControl();
            this.TreNav = new DevExpress.XtraTreeList.TreeList();
            this.colNodeType = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colMember = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.imgNav = new DevExpress.Utils.ImageCollection(this.components);
            this.grpUser = new DevExpress.XtraEditors.GroupControl();
            this.grdFunc = new DevExpress.XtraGrid.GridControl();
            this.gdvFunc = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colname1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colalias1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colisBegin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colisShowText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraScrollable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FolderNode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splMain)).BeginInit();
            this.splMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splMember)).BeginInit();
            this.splMember.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpMember)).BeginInit();
            this.grpMember.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TreNav)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNav)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpUser)).BeginInit();
            this.grpUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdFunc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvFunc)).BeginInit();
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
            this.splMain.Panel1.Controls.Add(this.grdApp);
            this.splMain.Panel1.MinSize = 200;
            this.splMain.Panel2.Controls.Add(this.splMember);
            this.splMain.Panel2.MinSize = 200;
            this.splMain.ScrollBarSmallChange = 1;
            this.splMain.Size = new System.Drawing.Size(1070, 590);
            this.splMain.SplitterPosition = 300;
            this.splMain.TabIndex = 0;
            // 
            // grdApp
            // 
            this.grdApp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdApp.Location = new System.Drawing.Point(0, 0);
            this.grdApp.MainView = this.gdvApp;
            this.grdApp.Name = "grdApp";
            this.grdApp.Size = new System.Drawing.Size(1070, 300);
            this.grdApp.TabIndex = 0;
            this.grdApp.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvApp});
            // 
            // gdvApp
            // 
            this.gdvApp.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colname,
            this.colalias,
            this.colhost,
            this.colremark});
            this.gdvApp.GridControl = this.grdApp;
            this.gdvApp.Name = "gdvApp";
            this.gdvApp.OptionsDetail.EnableMasterViewMode = false;
            // 
            // colname
            // 
            this.colname.Caption = "名称";
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.Visible = true;
            this.colname.VisibleIndex = 0;
            this.colname.Width = 360;
            // 
            // colalias
            // 
            this.colalias.Caption = "简称";
            this.colalias.FieldName = "alias";
            this.colalias.Name = "colalias";
            this.colalias.Visible = true;
            this.colalias.VisibleIndex = 1;
            this.colalias.Width = 160;
            // 
            // colhost
            // 
            this.colhost.Caption = "域名";
            this.colhost.FieldName = "host";
            this.colhost.Name = "colhost";
            this.colhost.Visible = true;
            this.colhost.VisibleIndex = 2;
            this.colhost.Width = 160;
            // 
            // colremark
            // 
            this.colremark.Caption = "备注";
            this.colremark.FieldName = "remark";
            this.colremark.Name = "colremark";
            this.colremark.Visible = true;
            this.colremark.VisibleIndex = 3;
            this.colremark.Width = 336;
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
            this.splMember.Size = new System.Drawing.Size(1070, 285);
            this.splMember.SplitterPosition = 300;
            this.splMember.TabIndex = 0;
            // 
            // grpMember
            // 
            this.grpMember.Controls.Add(this.TreNav);
            this.grpMember.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpMember.Location = new System.Drawing.Point(0, 0);
            this.grpMember.Name = "grpMember";
            this.grpMember.Size = new System.Drawing.Size(300, 285);
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
            this.TreNav.SelectImageList = this.imgNav;
            this.TreNav.Size = new System.Drawing.Size(296, 262);
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
            // grpUser
            // 
            this.grpUser.Controls.Add(this.grdFunc);
            this.grpUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpUser.Location = new System.Drawing.Point(0, 0);
            this.grpUser.Name = "grpUser";
            this.grpUser.Size = new System.Drawing.Size(765, 285);
            this.grpUser.TabIndex = 0;
            this.grpUser.Text = "模块功能";
            // 
            // grdFunc
            // 
            this.grdFunc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdFunc.Location = new System.Drawing.Point(2, 21);
            this.grdFunc.MainView = this.gdvFunc;
            this.grdFunc.Name = "grdFunc";
            this.grdFunc.Size = new System.Drawing.Size(761, 262);
            this.grdFunc.TabIndex = 0;
            this.grdFunc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvFunc,
            this.gridView1});
            // 
            // gdvFunc
            // 
            this.gdvFunc.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colname1,
            this.colalias1,
            this.gridColumn1,
            this.colisBegin,
            this.colisShowText});
            this.gdvFunc.GridControl = this.grdFunc;
            this.gdvFunc.Name = "gdvFunc";
            // 
            // colname1
            // 
            this.colname1.Caption = "名称";
            this.colname1.FieldName = "name";
            this.colname1.Name = "colname1";
            this.colname1.Visible = true;
            this.colname1.VisibleIndex = 0;
            this.colname1.Width = 160;
            // 
            // colalias1
            // 
            this.colalias1.Caption = "标识码";
            this.colalias1.FieldName = "alias";
            this.colalias1.Name = "colalias1";
            this.colalias1.Visible = true;
            this.colalias1.VisibleIndex = 1;
            this.colalias1.Width = 200;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "备注";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            this.gridColumn1.Width = 269;
            // 
            // colisBegin
            // 
            this.colisBegin.Caption = "分组";
            this.colisBegin.FieldName = "isBegin";
            this.colisBegin.Name = "colisBegin";
            this.colisBegin.Visible = true;
            this.colisBegin.VisibleIndex = 3;
            this.colisBegin.Width = 40;
            // 
            // colisShowText
            // 
            this.colisShowText.Caption = "文字";
            this.colisShowText.FieldName = "isShowText";
            this.colisShowText.Name = "colisShowText";
            this.colisShowText.Visible = true;
            this.colisShowText.VisibleIndex = 4;
            this.colisShowText.Width = 40;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grdFunc;
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
            ((System.ComponentModel.ISupportInitialize)(this.grdApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splMember)).EndInit();
            this.splMember.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpMember)).EndInit();
            this.grpMember.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TreNav)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNav)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpUser)).EndInit();
            this.grpUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdFunc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvFunc)).EndInit();
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
        internal GridControl grdApp;
        internal GridView gdvApp;
        private SplitContainerControl splMember;
        private GroupControl grpMember;
        private GroupControl grpUser;
        internal GridControl grdFunc;
        internal GridView gdvFunc;
        private GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colname;
        private DevExpress.XtraGrid.Columns.GridColumn colalias;
        private DevExpress.XtraGrid.Columns.GridColumn colhost;
        private DevExpress.XtraGrid.Columns.GridColumn colremark;
        private DevExpress.XtraGrid.Columns.GridColumn colname1;
        private DevExpress.XtraGrid.Columns.GridColumn colalias1;
        private DevExpress.XtraGrid.Columns.GridColumn colisBegin;
        private DevExpress.XtraGrid.Columns.GridColumn colisShowText;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private ImageCollection imgNav;
    }
}