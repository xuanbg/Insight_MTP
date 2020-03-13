using System.ComponentModel;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraTab;
using DevExpress.XtraTreeList;


namespace Insight.MTP.Client.System.Roles.Views
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
            this.components = new global::System.ComponentModel.Container();
            global::System.ComponentModel.ComponentResourceManager resources = new global::System.ComponentModel.ComponentResourceManager(typeof(Manager));
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.splRole = new DevExpress.XtraEditors.SplitContainerControl();
            this.grpRole = new DevExpress.XtraEditors.GroupControl();
            this.GrdRole = new DevExpress.XtraGrid.GridControl();
            this.GdvRole = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBuiltIn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TabRole = new Insight.Utils.Controls.PageControl();
            this.splMember = new DevExpress.XtraEditors.SplitContainerControl();
            this.grpMember = new DevExpress.XtraEditors.GroupControl();
            this.TreMember = new DevExpress.XtraTreeList.TreeList();
            this.colNodeType = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colMember = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.imgMember = new DevExpress.Utils.ImageCollection(this.components);
            this.grpUser = new DevExpress.XtraEditors.GroupControl();
            this.GrdUser = new DevExpress.XtraGrid.GridControl();
            this.GdvUser = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoginName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValidity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TabUser = new Insight.Utils.Controls.PageControl();
            this.tabPermission = new DevExpress.XtraTab.XtraTabControl();
            this.pagData = new DevExpress.XtraTab.XtraTabPage();
            this.panData = new DevExpress.XtraEditors.PanelControl();
            this.TreData = new DevExpress.XtraTreeList.TreeList();
            this.colIndexD = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colType = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colModel = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colDescriptionD = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colPermit = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colPermission = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.imgData = new DevExpress.Utils.ImageCollection(this.components);
            this.pagAction = new DevExpress.XtraTab.XtraTabPage();
            this.panAction = new DevExpress.XtraEditors.PanelControl();
            this.TreAction = new DevExpress.XtraTreeList.TreeList();
            this.colIndexA = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colTypeA = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colNameA = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colDescriptionA = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colPermitA = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.imgPermission = new DevExpress.Utils.ImageCollection(this.components);
            this.spcMain = new DevExpress.XtraEditors.SplitContainerControl();
            this.xtraScrollable.SuspendLayout();
            ((global::System.ComponentModel.ISupportInitialize)(this.FolderNode)).BeginInit();
            ((global::System.ComponentModel.ISupportInitialize)(this.splRole)).BeginInit();
            this.splRole.SuspendLayout();
            ((global::System.ComponentModel.ISupportInitialize)(this.grpRole)).BeginInit();
            this.grpRole.SuspendLayout();
            ((global::System.ComponentModel.ISupportInitialize)(this.GrdRole)).BeginInit();
            ((global::System.ComponentModel.ISupportInitialize)(this.GdvRole)).BeginInit();
            ((global::System.ComponentModel.ISupportInitialize)(this.splMember)).BeginInit();
            this.splMember.SuspendLayout();
            ((global::System.ComponentModel.ISupportInitialize)(this.grpMember)).BeginInit();
            this.grpMember.SuspendLayout();
            ((global::System.ComponentModel.ISupportInitialize)(this.TreMember)).BeginInit();
            ((global::System.ComponentModel.ISupportInitialize)(this.imgMember)).BeginInit();
            ((global::System.ComponentModel.ISupportInitialize)(this.grpUser)).BeginInit();
            this.grpUser.SuspendLayout();
            ((global::System.ComponentModel.ISupportInitialize)(this.GrdUser)).BeginInit();
            ((global::System.ComponentModel.ISupportInitialize)(this.GdvUser)).BeginInit();
            ((global::System.ComponentModel.ISupportInitialize)(this.tabPermission)).BeginInit();
            this.tabPermission.SuspendLayout();
            this.pagData.SuspendLayout();
            ((global::System.ComponentModel.ISupportInitialize)(this.panData)).BeginInit();
            this.panData.SuspendLayout();
            ((global::System.ComponentModel.ISupportInitialize)(this.TreData)).BeginInit();
            ((global::System.ComponentModel.ISupportInitialize)(this.imgData)).BeginInit();
            this.pagAction.SuspendLayout();
            ((global::System.ComponentModel.ISupportInitialize)(this.panAction)).BeginInit();
            this.panAction.SuspendLayout();
            ((global::System.ComponentModel.ISupportInitialize)(this.TreAction)).BeginInit();
            ((global::System.ComponentModel.ISupportInitialize)(this.imgPermission)).BeginInit();
            ((global::System.ComponentModel.ISupportInitialize)(this.spcMain)).BeginInit();
            this.spcMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // xtraScrollable
            // 
            this.xtraScrollable.Controls.Add(this.spcMain);
            this.xtraScrollable.Location = new global::System.Drawing.Point(0, 31);
            this.xtraScrollable.Padding = new global::System.Windows.Forms.Padding(5);
            this.xtraScrollable.Size = new global::System.Drawing.Size(1080, 600);
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
            this.barDockControlTop.Location = new global::System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = null;
            this.barDockControlTop.Size = new global::System.Drawing.Size(0, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Location = new global::System.Drawing.Point(0, 0);
            this.barDockControlBottom.Manager = null;
            this.barDockControlBottom.Size = new global::System.Drawing.Size(0, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Location = new global::System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = null;
            this.barDockControlLeft.Size = new global::System.Drawing.Size(0, 0);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Location = new global::System.Drawing.Point(0, 0);
            this.barDockControlRight.Manager = null;
            this.barDockControlRight.Size = new global::System.Drawing.Size(0, 0);
            // 
            // splRole
            // 
            this.splRole.Dock = global::System.Windows.Forms.DockStyle.Fill;
            this.splRole.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.None;
            this.splRole.Horizontal = false;
            this.splRole.Location = new global::System.Drawing.Point(0, 0);
            this.splRole.Name = "splRole";
            this.splRole.Panel1.Controls.Add(this.grpRole);
            this.splRole.Panel1.MinSize = 200;
            this.splRole.Panel2.Controls.Add(this.splMember);
            this.splRole.Panel2.MinSize = 200;
            this.splRole.ScrollBarSmallChange = 1;
            this.splRole.Size = new global::System.Drawing.Size(765, 590);
            this.splRole.SplitterPosition = 295;
            this.splRole.TabIndex = 0;
            // 
            // grpRole
            // 
            this.grpRole.Controls.Add(this.GrdRole);
            this.grpRole.Controls.Add(this.TabRole);
            this.grpRole.Dock = global::System.Windows.Forms.DockStyle.Fill;
            this.grpRole.Location = new global::System.Drawing.Point(0, 0);
            this.grpRole.Name = "grpRole";
            this.grpRole.Size = new global::System.Drawing.Size(765, 295);
            this.grpRole.TabIndex = 0;
            this.grpRole.Text = "角色";
            // 
            // GrdRole
            // 
            this.GrdRole.Dock = global::System.Windows.Forms.DockStyle.Fill;
            this.GrdRole.Location = new global::System.Drawing.Point(2, 21);
            this.GrdRole.MainView = this.GdvRole;
            this.GrdRole.Name = "GrdRole";
            this.GrdRole.Size = new global::System.Drawing.Size(761, 250);
            this.GrdRole.TabIndex = 1;
            this.GrdRole.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GdvRole});
            // 
            // GdvRole
            // 
            this.GdvRole.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colBuiltIn,
            this.colApp,
            this.colName,
            this.colDescription});
            this.GdvRole.GridControl = this.GrdRole;
            this.GdvRole.Name = "GdvRole";
            this.GdvRole.OptionsDetail.EnableMasterViewMode = false;
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
            // TabRole
            // 
            this.TabRole.Dock = global::System.Windows.Forms.DockStyle.Bottom;
            this.TabRole.focusedRowHandle = 0;
            this.TabRole.Location = new global::System.Drawing.Point(2, 271);
            this.TabRole.MaximumSize = new global::System.Drawing.Size(0, 22);
            this.TabRole.MinimumSize = new global::System.Drawing.Size(300, 22);
            this.TabRole.Name = "TabRole";
            this.TabRole.pageSizeItems = ((global::System.Collections.ObjectModel.Collection<string>)(resources.GetObject("TabRole.PageSizeItems")));
            this.TabRole.Size = new global::System.Drawing.Size(761, 22);
            this.TabRole.TabIndex = 2;
            // 
            // splMember
            // 
            this.splMember.Dock = global::System.Windows.Forms.DockStyle.Fill;
            this.splMember.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.None;
            this.splMember.Location = new global::System.Drawing.Point(0, 0);
            this.splMember.Name = "splMember";
            this.splMember.Panel1.Controls.Add(this.grpMember);
            this.splMember.Panel1.MinSize = 160;
            this.splMember.Panel2.Controls.Add(this.grpUser);
            this.splMember.Panel2.MinSize = 300;
            this.splMember.Size = new global::System.Drawing.Size(765, 290);
            this.splMember.SplitterPosition = 225;
            this.splMember.TabIndex = 0;
            // 
            // grpMember
            // 
            this.grpMember.Controls.Add(this.TreMember);
            this.grpMember.Dock = global::System.Windows.Forms.DockStyle.Fill;
            this.grpMember.Location = new global::System.Drawing.Point(0, 0);
            this.grpMember.Name = "grpMember";
            this.grpMember.Size = new global::System.Drawing.Size(225, 290);
            this.grpMember.TabIndex = 0;
            this.grpMember.Text = "角色成员";
            // 
            // TreMember
            // 
            this.TreMember.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.TreMember.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colNodeType,
            this.colMember});
            this.TreMember.DataSource = null;
            this.TreMember.Dock = global::System.Windows.Forms.DockStyle.Fill;
            this.TreMember.Location = new global::System.Drawing.Point(2, 21);
            this.TreMember.Name = "TreMember";
            this.TreMember.OptionsView.ShowColumns = false;
            this.TreMember.ParentFieldName = "ParentId";
            this.TreMember.SelectImageList = this.imgMember;
            this.TreMember.Size = new global::System.Drawing.Size(221, 267);
            this.TreMember.TabIndex = 0;
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
            this.grpUser.Controls.Add(this.GrdUser);
            this.grpUser.Controls.Add(this.TabUser);
            this.grpUser.Dock = global::System.Windows.Forms.DockStyle.Fill;
            this.grpUser.Location = new global::System.Drawing.Point(0, 0);
            this.grpUser.Name = "grpUser";
            this.grpUser.Size = new global::System.Drawing.Size(535, 290);
            this.grpUser.TabIndex = 0;
            this.grpUser.Text = "成员用户";
            // 
            // GrdUser
            // 
            this.GrdUser.Dock = global::System.Windows.Forms.DockStyle.Fill;
            this.GrdUser.Location = new global::System.Drawing.Point(2, 21);
            this.GrdUser.MainView = this.GdvUser;
            this.GrdUser.Name = "GrdUser";
            this.GrdUser.Size = new global::System.Drawing.Size(531, 245);
            this.GrdUser.TabIndex = 0;
            this.GrdUser.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GdvUser});
            // 
            // GdvUser
            // 
            this.GdvUser.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUID,
            this.colName1,
            this.colLoginName,
            this.colDescription1,
            this.colValidity});
            this.GdvUser.GridControl = this.GrdUser;
            this.GdvUser.Name = "GdvUser";
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
            // TabUser
            // 
            this.TabUser.Dock = global::System.Windows.Forms.DockStyle.Bottom;
            this.TabUser.focusedRowHandle = 0;
            this.TabUser.Location = new global::System.Drawing.Point(2, 266);
            this.TabUser.MaximumSize = new global::System.Drawing.Size(0, 22);
            this.TabUser.MinimumSize = new global::System.Drawing.Size(320, 22);
            this.TabUser.Name = "TabUser";
            this.TabUser.pageSizeItems = ((global::System.Collections.ObjectModel.Collection<string>)(resources.GetObject("TabUser.PageSizeItems")));
            this.TabUser.Size = new global::System.Drawing.Size(531, 22);
            this.TabUser.TabIndex = 1;
            // 
            // tabPermission
            // 
            this.tabPermission.Anchor = ((global::System.Windows.Forms.AnchorStyles)((((global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom) 
            | global::System.Windows.Forms.AnchorStyles.Left) 
            | global::System.Windows.Forms.AnchorStyles.Right)));
            this.tabPermission.Location = new global::System.Drawing.Point(0, 0);
            this.tabPermission.Name = "tabPermission";
            this.tabPermission.SelectedTabPage = this.pagData;
            this.tabPermission.Size = new global::System.Drawing.Size(304, 594);
            this.tabPermission.TabIndex = 0;
            this.tabPermission.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.pagAction,
            this.pagData});
            // 
            // pagData
            // 
            this.pagData.Controls.Add(this.panData);
            this.pagData.Name = "pagData";
            this.pagData.Size = new global::System.Drawing.Size(298, 565);
            this.pagData.Text = "数据权限";
            // 
            // panData
            // 
            this.panData.Anchor = ((global::System.Windows.Forms.AnchorStyles)((((global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom) 
            | global::System.Windows.Forms.AnchorStyles.Left) 
            | global::System.Windows.Forms.AnchorStyles.Right)));
            this.panData.Controls.Add(this.TreData);
            this.panData.Location = new global::System.Drawing.Point(2, 2);
            this.panData.Name = "panData";
            this.panData.Size = new global::System.Drawing.Size(294, 561);
            this.panData.TabIndex = 0;
            // 
            // TreData
            // 
            this.TreData.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.TreData.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colIndexD,
            this.colType,
            this.colModel,
            this.colDescriptionD,
            this.colPermit,
            this.colPermission});
            this.TreData.Cursor = global::System.Windows.Forms.Cursors.Default;
            this.TreData.DataSource = null;
            this.TreData.Dock = global::System.Windows.Forms.DockStyle.Fill;
            this.TreData.Location = new global::System.Drawing.Point(2, 2);
            this.TreData.Name = "TreData";
            this.TreData.OptionsView.ShowHorzLines = false;
            this.TreData.OptionsView.ShowIndicator = false;
            this.TreData.OptionsView.ShowVertLines = false;
            this.TreData.ParentFieldName = "ParentId";
            this.TreData.SelectImageList = this.imgData;
            this.TreData.Size = new global::System.Drawing.Size(290, 557);
            this.TreData.TabIndex = 4;
            // 
            // colIndexD
            // 
            this.colIndexD.FieldName = "Index";
            this.colIndexD.Name = "colIndexD";
            this.colIndexD.Width = 50;
            // 
            // colType
            // 
            this.colType.FieldName = "nodeType";
            this.colType.Name = "colType";
            this.colType.Width = 51;
            // 
            // colModel
            // 
            this.colModel.FieldName = "Name";
            this.colModel.MinWidth = 33;
            this.colModel.Name = "colModel";
            this.colModel.Visible = true;
            this.colModel.VisibleIndex = 0;
            this.colModel.Width = 245;
            // 
            // colDescriptionD
            // 
            this.colDescriptionD.FieldName = "Description";
            this.colDescriptionD.Name = "colDescriptionD";
            this.colDescriptionD.Visible = true;
            this.colDescriptionD.VisibleIndex = 1;
            this.colDescriptionD.Width = 60;
            // 
            // colPermit
            // 
            this.colPermit.FieldName = "Permit";
            this.colPermit.Name = "colPermit";
            this.colPermit.Width = 61;
            // 
            // colPermission
            // 
            this.colPermission.FieldName = "Permission";
            this.colPermission.Name = "colPermission";
            this.colPermission.Width = 61;
            // 
            // imgData
            // 
            this.imgData.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imgData.ImageStream")));
            this.imgData.Images.SetKeyName(0, "Navigation.png");
            this.imgData.InsertGalleryImage("database_16x16.png", "images/data/database_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/data/database_16x16.png"), 1);
            this.imgData.Images.SetKeyName(1, "database_16x16.png");
            this.imgData.InsertGalleryImage("new_16x16.png", "images/actions/new_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/new_16x16.png"), 2);
            this.imgData.Images.SetKeyName(2, "new_16x16.png");
            this.imgData.InsertGalleryImage("customer_16x16.png", "images/people/customer_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/people/customer_16x16.png"), 3);
            this.imgData.Images.SetKeyName(3, "customer_16x16.png");
            this.imgData.Images.SetKeyName(4, "NodeDept.png");
            this.imgData.InsertGalleryImage("home_16x16.png", "images/navigation/home_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/navigation/home_16x16.png"), 5);
            this.imgData.Images.SetKeyName(5, "home_16x16.png");
            this.imgData.Images.SetKeyName(6, "NodeOrg.png");
            this.imgData.InsertGalleryImage("documentmap_16x16.png", "images/navigation/documentmap_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/navigation/documentmap_16x16.png"), 7);
            this.imgData.Images.SetKeyName(7, "documentmap_16x16.png");
            // 
            // pagAction
            // 
            this.pagAction.Controls.Add(this.panAction);
            this.pagAction.Name = "pagAction";
            this.pagAction.Size = new global::System.Drawing.Size(297, 564);
            this.pagAction.Text = "功能权限";
            // 
            // panAction
            // 
            this.panAction.Anchor = ((global::System.Windows.Forms.AnchorStyles)((((global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom) 
            | global::System.Windows.Forms.AnchorStyles.Left) 
            | global::System.Windows.Forms.AnchorStyles.Right)));
            this.panAction.Controls.Add(this.TreAction);
            this.panAction.Location = new global::System.Drawing.Point(2, 2);
            this.panAction.Name = "panAction";
            this.panAction.Size = new global::System.Drawing.Size(293, 560);
            this.panAction.TabIndex = 0;
            // 
            // TreAction
            // 
            this.TreAction.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.TreAction.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colIndexA,
            this.colTypeA,
            this.colNameA,
            this.colDescriptionA,
            this.colPermitA});
            this.TreAction.DataSource = null;
            this.TreAction.Dock = global::System.Windows.Forms.DockStyle.Fill;
            this.TreAction.Location = new global::System.Drawing.Point(2, 2);
            this.TreAction.Name = "TreAction";
            this.TreAction.OptionsView.ShowHorzLines = false;
            this.TreAction.OptionsView.ShowIndicator = false;
            this.TreAction.OptionsView.ShowVertLines = false;
            this.TreAction.ParentFieldName = "ParentId";
            this.TreAction.SelectImageList = this.imgPermission;
            this.TreAction.Size = new global::System.Drawing.Size(289, 556);
            this.TreAction.TabIndex = 3;
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
            this.spcMain.Dock = global::System.Windows.Forms.DockStyle.Fill;
            this.spcMain.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2;
            this.spcMain.Location = new global::System.Drawing.Point(5, 5);
            this.spcMain.Name = "spcMain";
            this.spcMain.Panel1.Controls.Add(this.splRole);
            this.spcMain.Panel1.MinSize = 750;
            this.spcMain.Panel2.Controls.Add(this.tabPermission);
            this.spcMain.Panel2.MinSize = 300;
            this.spcMain.Size = new global::System.Drawing.Size(1070, 590);
            this.spcMain.SplitterPosition = 300;
            this.spcMain.TabIndex = 0;
            // 
            // Manager
            // 
            this.Appearance.Options.UseFont = true;
            this.ClientSize = new global::System.Drawing.Size(1080, 631);
            this.Name = "Manager";
            this.xtraScrollable.ResumeLayout(false);
            ((global::System.ComponentModel.ISupportInitialize)(this.FolderNode)).EndInit();
            ((global::System.ComponentModel.ISupportInitialize)(this.splRole)).EndInit();
            this.splRole.ResumeLayout(false);
            ((global::System.ComponentModel.ISupportInitialize)(this.grpRole)).EndInit();
            this.grpRole.ResumeLayout(false);
            ((global::System.ComponentModel.ISupportInitialize)(this.GrdRole)).EndInit();
            ((global::System.ComponentModel.ISupportInitialize)(this.GdvRole)).EndInit();
            ((global::System.ComponentModel.ISupportInitialize)(this.splMember)).EndInit();
            this.splMember.ResumeLayout(false);
            ((global::System.ComponentModel.ISupportInitialize)(this.grpMember)).EndInit();
            this.grpMember.ResumeLayout(false);
            ((global::System.ComponentModel.ISupportInitialize)(this.TreMember)).EndInit();
            ((global::System.ComponentModel.ISupportInitialize)(this.imgMember)).EndInit();
            ((global::System.ComponentModel.ISupportInitialize)(this.grpUser)).EndInit();
            this.grpUser.ResumeLayout(false);
            ((global::System.ComponentModel.ISupportInitialize)(this.GrdUser)).EndInit();
            ((global::System.ComponentModel.ISupportInitialize)(this.GdvUser)).EndInit();
            ((global::System.ComponentModel.ISupportInitialize)(this.tabPermission)).EndInit();
            this.tabPermission.ResumeLayout(false);
            this.pagData.ResumeLayout(false);
            ((global::System.ComponentModel.ISupportInitialize)(this.panData)).EndInit();
            this.panData.ResumeLayout(false);
            ((global::System.ComponentModel.ISupportInitialize)(this.TreData)).EndInit();
            ((global::System.ComponentModel.ISupportInitialize)(this.imgData)).EndInit();
            this.pagAction.ResumeLayout(false);
            ((global::System.ComponentModel.ISupportInitialize)(this.panAction)).EndInit();
            this.panAction.ResumeLayout(false);
            ((global::System.ComponentModel.ISupportInitialize)(this.TreAction)).EndInit();
            ((global::System.ComponentModel.ISupportInitialize)(this.imgPermission)).EndInit();
            ((global::System.ComponentModel.ISupportInitialize)(this.spcMain)).EndInit();
            this.spcMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal Utils.Controls.PageControl TabRole;
        internal Utils.Controls.PageControl TabUser;
        internal GridControl GrdRole;
        internal GridView GdvRole;
        internal GridControl GrdUser;
        internal GridView GdvUser;
        internal TreeList TreMember;
        internal TreeList TreAction;
        internal TreeList TreData;
        internal XtraTabControl tabPermission;
        private BarDockControl barDockControlTop;
        private BarDockControl barDockControlBottom;
        private BarDockControl barDockControlLeft;
        private BarDockControl barDockControlRight;
        private GroupControl grpMember;
        private GroupControl grpRole;
        private GroupControl grpUser;
        private PanelControl panAction;
        private SplitContainerControl splRole;
        private SplitContainerControl splMember;
        private XtraTabPage pagAction;
        private XtraTabPage pagData;
        private ImageCollection imgMember;
        private ImageCollection imgPermission;
        private PanelControl panData;
        private ImageCollection imgData;
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
        private DevExpress.XtraTreeList.Columns.TreeListColumn colPermit;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colPermission;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colDescriptionA;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colPermitA;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colNameA;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colTypeA;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colIndexA;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colDescriptionD;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colModel;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colType;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colIndexD;
        private DevExpress.XtraGrid.Columns.GridColumn colApp;
        private SplitContainerControl spcMain;
    }
}