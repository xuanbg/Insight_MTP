using System.ComponentModel;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraTreeList;

namespace Insight.MTP.Client.Setting.Roles.Views
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
            this.splRole = new DevExpress.XtraEditors.SplitContainerControl();
            this.grpRole = new DevExpress.XtraEditors.GroupControl();
            this.grdRole = new DevExpress.XtraGrid.GridControl();
            this.gdvRole = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBuiltIn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ppcRole = new Insight.Utils.Controls.PageControl();
            this.splMember = new DevExpress.XtraEditors.SplitContainerControl();
            this.grpMember = new DevExpress.XtraEditors.GroupControl();
            this.treMember = new DevExpress.XtraTreeList.TreeList();
            this.colNodeType = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colMember = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.imgMember = new DevExpress.Utils.ImageCollection(this.components);
            this.grpUser = new DevExpress.XtraEditors.GroupControl();
            this.grdUser = new DevExpress.XtraGrid.GridControl();
            this.gdvUser = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoginName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValidity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ppcUser = new Insight.Utils.Controls.PageControl();
            this.imgPermission = new DevExpress.Utils.ImageCollection(this.components);
            this.spcMain = new DevExpress.XtraEditors.SplitContainerControl();
            this.panPermit = new DevExpress.XtraEditors.PanelControl();
            this.treAction = new DevExpress.XtraTreeList.TreeList();
            this.colIndexA = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colTypeA = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colNameA = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colDescriptionA = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colPermitA = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.xtraScrollable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FolderNode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splRole)).BeginInit();
            this.splRole.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpRole)).BeginInit();
            this.grpRole.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splMember)).BeginInit();
            this.splMember.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpMember)).BeginInit();
            this.grpMember.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treMember)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMember)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpUser)).BeginInit();
            this.grpUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPermission)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spcMain)).BeginInit();
            this.spcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panPermit)).BeginInit();
            this.panPermit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treAction)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraScrollable
            // 
            this.xtraScrollable.Controls.Add(this.spcMain);
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
            // splRole
            // 
            this.splRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splRole.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.None;
            this.splRole.Horizontal = false;
            this.splRole.Location = new System.Drawing.Point(0, 0);
            this.splRole.Name = "splRole";
            this.splRole.Panel1.Controls.Add(this.grpRole);
            this.splRole.Panel1.MinSize = 200;
            this.splRole.Panel2.Controls.Add(this.splMember);
            this.splRole.Panel2.MinSize = 200;
            this.splRole.ScrollBarSmallChange = 1;
            this.splRole.Size = new System.Drawing.Size(765, 590);
            this.splRole.SplitterPosition = 295;
            this.splRole.TabIndex = 0;
            // 
            // grpRole
            // 
            this.grpRole.Controls.Add(this.grdRole);
            this.grpRole.Controls.Add(this.ppcRole);
            this.grpRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpRole.Location = new System.Drawing.Point(0, 0);
            this.grpRole.Name = "grpRole";
            this.grpRole.Size = new System.Drawing.Size(765, 295);
            this.grpRole.TabIndex = 0;
            this.grpRole.Text = "角色";
            // 
            // grdRole
            // 
            this.grdRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdRole.Location = new System.Drawing.Point(2, 21);
            this.grdRole.MainView = this.gdvRole;
            this.grdRole.Name = "grdRole";
            this.grdRole.Size = new System.Drawing.Size(761, 250);
            this.grdRole.TabIndex = 0;
            this.grdRole.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvRole});
            // 
            // gdvRole
            // 
            this.gdvRole.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colBuiltIn,
            this.colApp,
            this.colName,
            this.colDescription});
            this.gdvRole.GridControl = this.grdRole;
            this.gdvRole.Name = "gdvRole";
            this.gdvRole.OptionsDetail.EnableMasterViewMode = false;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            // 
            // colBuiltIn
            // 
            this.colBuiltIn.Caption = "内置";
            this.colBuiltIn.FieldName = "isBuiltin";
            this.colBuiltIn.Name = "colBuiltIn";
            this.colBuiltIn.Visible = true;
            this.colBuiltIn.VisibleIndex = 0;
            this.colBuiltIn.Width = 40;
            // 
            // colApp
            // 
            this.colApp.Caption = "所属应用";
            this.colApp.FieldName = "appName";
            this.colApp.Name = "colApp";
            this.colApp.Visible = true;
            this.colApp.VisibleIndex = 1;
            this.colApp.Width = 160;
            // 
            // colName
            // 
            this.colName.Caption = "名称";
            this.colName.FieldName = "name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 2;
            this.colName.Width = 160;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "描述";
            this.colDescription.FieldName = "remark";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 3;
            this.colDescription.Width = 334;
            // 
            // ppcRole
            // 
            this.ppcRole.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ppcRole.focusedRowHandle = 0;
            this.ppcRole.Location = new System.Drawing.Point(2, 271);
            this.ppcRole.MaximumSize = new System.Drawing.Size(0, 22);
            this.ppcRole.MinimumSize = new System.Drawing.Size(300, 22);
            this.ppcRole.Name = "ppcRole";
            this.ppcRole.pageSizeItems = ((System.Collections.ObjectModel.Collection<string>)(resources.GetObject("ppcRole.pageSizeItems")));
            this.ppcRole.Size = new System.Drawing.Size(761, 22);
            this.ppcRole.TabIndex = 0;
            // 
            // splMember
            // 
            this.splMember.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splMember.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.None;
            this.splMember.Location = new System.Drawing.Point(0, 0);
            this.splMember.Name = "splMember";
            this.splMember.Panel1.Controls.Add(this.grpMember);
            this.splMember.Panel1.MinSize = 160;
            this.splMember.Panel2.Controls.Add(this.grpUser);
            this.splMember.Panel2.MinSize = 300;
            this.splMember.Size = new System.Drawing.Size(765, 290);
            this.splMember.SplitterPosition = 225;
            this.splMember.TabIndex = 0;
            // 
            // grpMember
            // 
            this.grpMember.Controls.Add(this.treMember);
            this.grpMember.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpMember.Location = new System.Drawing.Point(0, 0);
            this.grpMember.Name = "grpMember";
            this.grpMember.Size = new System.Drawing.Size(225, 290);
            this.grpMember.TabIndex = 0;
            this.grpMember.Text = "角色成员";
            // 
            // treMember
            // 
            this.treMember.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.treMember.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colNodeType,
            this.colMember});
            this.treMember.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treMember.Location = new System.Drawing.Point(2, 21);
            this.treMember.Name = "treMember";
            this.treMember.OptionsView.ShowColumns = false;
            this.treMember.ParentFieldName = "ParentId";
            this.treMember.SelectImageList = this.imgMember;
            this.treMember.Size = new System.Drawing.Size(221, 267);
            this.treMember.TabIndex = 0;
            this.treMember.Tag = "ONLY_LEVEL0";
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
            // imgMember
            // 
            this.imgMember.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imgMember.ImageStream")));
            this.imgMember.Images.SetKeyName(0, "Suggestion.png");
            this.imgMember.Images.SetKeyName(1, "User.png");
            this.imgMember.Images.SetKeyName(2, "Group.png");
            this.imgMember.Images.SetKeyName(3, "NodePost.png");
            // 
            // grpUser
            // 
            this.grpUser.Controls.Add(this.grdUser);
            this.grpUser.Controls.Add(this.ppcUser);
            this.grpUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpUser.Location = new System.Drawing.Point(0, 0);
            this.grpUser.Name = "grpUser";
            this.grpUser.Size = new System.Drawing.Size(535, 290);
            this.grpUser.TabIndex = 0;
            this.grpUser.Text = "成员用户";
            // 
            // grdUser
            // 
            this.grdUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdUser.Location = new System.Drawing.Point(2, 21);
            this.grdUser.MainView = this.gdvUser;
            this.grdUser.Name = "grdUser";
            this.grdUser.Size = new System.Drawing.Size(531, 245);
            this.grdUser.TabIndex = 0;
            this.grdUser.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvUser});
            // 
            // gdvUser
            // 
            this.gdvUser.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUID,
            this.colName1,
            this.colLoginName,
            this.colDescription1,
            this.colValidity});
            this.gdvUser.GridControl = this.grdUser;
            this.gdvUser.Name = "gdvUser";
            // 
            // colUID
            // 
            this.colUID.FieldName = "ID";
            this.colUID.Name = "colUID";
            // 
            // colName1
            // 
            this.colName1.Caption = "用户姓名";
            this.colName1.FieldName = "name";
            this.colName1.Name = "colName1";
            this.colName1.Visible = true;
            this.colName1.VisibleIndex = 0;
            this.colName1.Width = 120;
            // 
            // colLoginName
            // 
            this.colLoginName.Caption = "登录账号";
            this.colLoginName.FieldName = "account";
            this.colLoginName.Name = "colLoginName";
            this.colLoginName.Visible = true;
            this.colLoginName.VisibleIndex = 1;
            this.colLoginName.Width = 100;
            // 
            // colDescription1
            // 
            this.colDescription1.Caption = "描述";
            this.colDescription1.FieldName = "remark";
            this.colDescription1.Name = "colDescription1";
            this.colDescription1.Visible = true;
            this.colDescription1.VisibleIndex = 2;
            this.colDescription1.Width = 205;
            // 
            // colValidity
            // 
            this.colValidity.Caption = "封禁";
            this.colValidity.FieldName = "isInvalid";
            this.colValidity.Name = "colValidity";
            this.colValidity.Visible = true;
            this.colValidity.VisibleIndex = 3;
            this.colValidity.Width = 40;
            // 
            // ppcUser
            // 
            this.ppcUser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ppcUser.focusedRowHandle = 0;
            this.ppcUser.Location = new System.Drawing.Point(2, 266);
            this.ppcUser.MaximumSize = new System.Drawing.Size(0, 22);
            this.ppcUser.MinimumSize = new System.Drawing.Size(320, 22);
            this.ppcUser.Name = "ppcUser";
            this.ppcUser.pageSizeItems = ((System.Collections.ObjectModel.Collection<string>)(resources.GetObject("ppcUser.pageSizeItems")));
            this.ppcUser.Size = new System.Drawing.Size(531, 22);
            this.ppcUser.TabIndex = 0;
            // 
            // imgPermission
            // 
            this.imgPermission.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imgPermission.ImageStream")));
            this.imgPermission.Images.SetKeyName(0, "Module.png");
            this.imgPermission.InsertGalleryImage("openhyperlink_16x16.png", "images/actions/openhyperlink_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/openhyperlink_16x16.png"), 1);
            this.imgPermission.Images.SetKeyName(1, "openhyperlink_16x16.png");
            this.imgPermission.Images.SetKeyName(2, "Action.png");
            this.imgPermission.InsertGalleryImage("close_16x16.png", "images/actions/close_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/close_16x16.png"), 3);
            this.imgPermission.Images.SetKeyName(3, "close_16x16.png");
            this.imgPermission.InsertGalleryImage("checkbox_16x16.png", "images/content/checkbox_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/content/checkbox_16x16.png"), 4);
            this.imgPermission.Images.SetKeyName(4, "checkbox_16x16.png");
            this.imgPermission.InsertGalleryImage("technology_16x16.png", "images/programming/technology_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/programming/technology_16x16.png"), 5);
            this.imgPermission.Images.SetKeyName(5, "technology_16x16.png");
            // 
            // spcMain
            // 
            this.spcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcMain.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2;
            this.spcMain.Location = new System.Drawing.Point(5, 5);
            this.spcMain.Name = "spcMain";
            this.spcMain.Panel1.Controls.Add(this.splRole);
            this.spcMain.Panel1.MinSize = 750;
            this.spcMain.Panel2.Controls.Add(this.panPermit);
            this.spcMain.Panel2.MinSize = 300;
            this.spcMain.Size = new System.Drawing.Size(1070, 590);
            this.spcMain.SplitterPosition = 300;
            this.spcMain.TabIndex = 0;
            // 
            // panPermit
            // 
            this.panPermit.Controls.Add(this.treAction);
            this.panPermit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panPermit.Location = new System.Drawing.Point(0, 0);
            this.panPermit.Name = "panPermit";
            this.panPermit.Size = new System.Drawing.Size(300, 590);
            this.panPermit.TabIndex = 0;
            // 
            // treAction
            // 
            this.treAction.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.treAction.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colIndexA,
            this.colTypeA,
            this.colNameA,
            this.colDescriptionA,
            this.colPermitA});
            this.treAction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treAction.Location = new System.Drawing.Point(2, 2);
            this.treAction.Name = "treAction";
            this.treAction.OptionsView.ShowHorzLines = false;
            this.treAction.OptionsView.ShowIndicator = false;
            this.treAction.OptionsView.ShowVertLines = false;
            this.treAction.ParentFieldName = "ParentId";
            this.treAction.SelectImageList = this.imgPermission;
            this.treAction.Size = new System.Drawing.Size(296, 586);
            this.treAction.TabIndex = 4;
            this.treAction.Tag = "NODE_TYPE";
            // 
            // colIndexA
            // 
            this.colIndexA.FieldName = "index";
            this.colIndexA.Name = "colIndexA";
            this.colIndexA.Width = 50;
            // 
            // colTypeA
            // 
            this.colTypeA.FieldName = "nodeType";
            this.colTypeA.Name = "colTypeA";
            this.colTypeA.Width = 51;
            // 
            // colNameA
            // 
            this.colNameA.FieldName = "name";
            this.colNameA.MinWidth = 33;
            this.colNameA.Name = "colNameA";
            this.colNameA.Visible = true;
            this.colNameA.VisibleIndex = 0;
            this.colNameA.Width = 245;
            // 
            // colDescriptionA
            // 
            this.colDescriptionA.FieldName = "remark";
            this.colDescriptionA.Name = "colDescriptionA";
            this.colDescriptionA.Visible = true;
            this.colDescriptionA.VisibleIndex = 1;
            this.colDescriptionA.Width = 60;
            // 
            // colPermitA
            // 
            this.colPermitA.FieldName = "permit";
            this.colPermitA.Name = "colPermitA";
            this.colPermitA.Width = 61;
            // 
            // Manager
            // 
            this.Appearance.Options.UseFont = true;
            this.ClientSize = new System.Drawing.Size(1080, 631);
            this.Name = "Manager";
            this.xtraScrollable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FolderNode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splRole)).EndInit();
            this.splRole.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpRole)).EndInit();
            this.grpRole.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splMember)).EndInit();
            this.splMember.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpMember)).EndInit();
            this.grpMember.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treMember)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMember)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpUser)).EndInit();
            this.grpUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPermission)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spcMain)).EndInit();
            this.spcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panPermit)).EndInit();
            this.panPermit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treAction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private BarDockControl barDockControlTop;
        private BarDockControl barDockControlBottom;
        private BarDockControl barDockControlLeft;
        private BarDockControl barDockControlRight;
        private GroupControl grpMember;
        private GroupControl grpRole;
        private GroupControl grpUser;
        private SplitContainerControl splRole;
        private SplitContainerControl splMember;
        private ImageCollection imgMember;
        private ImageCollection imgPermission;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colBuiltIn;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colUID;
        private DevExpress.XtraGrid.Columns.GridColumn colName1;
        private DevExpress.XtraGrid.Columns.GridColumn colLoginName;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription1;
        private DevExpress.XtraGrid.Columns.GridColumn colValidity;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colNodeType;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colMember;
        private DevExpress.XtraGrid.Columns.GridColumn colApp;
        private SplitContainerControl spcMain;
        private PanelControl panPermit;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colIndexA;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colTypeA;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colNameA;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colDescriptionA;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colPermitA;
        public GridControl grdRole;
        public Utils.Controls.PageControl ppcRole;
        public TreeList treMember;
        public GridControl grdUser;
        public GridView gdvUser;
        public GridView gdvRole;
        public TreeList treAction;
        public Utils.Controls.PageControl ppcUser;
    }
}